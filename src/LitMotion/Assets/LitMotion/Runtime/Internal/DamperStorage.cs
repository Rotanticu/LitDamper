using System;
using System.Runtime.CompilerServices;
using LitDamper.Collections;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

// TODO: Constantize the exception message

namespace LitDamper
{
    internal struct StorageEntry : IEquatable<StorageEntry>
    {
        public int? Next;
        public int DenseIndex;
        public int Version;

        public readonly bool Equals(StorageEntry other)
        {
            return other.Next == Next && other.DenseIndex == DenseIndex && other.Version == Version;
        }

        public override readonly bool Equals(object obj)
        {
            if (obj is StorageEntry entry) return Equals(entry);
            return false;
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Next, DenseIndex, Version);
        }
    }

    internal unsafe interface IMotionStorage
    {
        bool IsActive(DamperHandle handle);
        void Cancel(DamperHandle handle);
        void Complete(DamperHandle handle);
        ref DamperDataCore GetDataRef(DamperHandle handle);
        ref DamperCallbackData GetCallbackDataRef(DamperHandle handle);
        void Reset();
    }

    internal sealed class StorageEntryList
    {
        public StorageEntryList(int initialCapacity = 32)
        {
            entries = new StorageEntry[initialCapacity];
            Reset();
        }

        StorageEntry[] entries;
        int? freeEntry;

        public StorageEntry this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => entries[index];
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => entries[index] = value;
        }

        public void EnsureCapacity(int capacity)
        {
            var currentLength = entries.Length;
            if (currentLength >= capacity) return;

            Array.Resize(ref entries, capacity);
            for (int i = currentLength; i < entries.Length; i++)
            {
                entries[i] = new() { Next = i == capacity - 1 ? freeEntry : i + 1, DenseIndex = -1, Version = 1 };
            }
            freeEntry = currentLength;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public StorageEntry Alloc(int denseIndex, out int entryIndex)
        {
            // Ensure array capacity
            if (freeEntry == null)
            {
                var currentLength = entries.Length;
                EnsureCapacity(entries.Length * 2);
                freeEntry = currentLength;
            }

            // Find free entry
            entryIndex = freeEntry.Value;
            var entry = entries[entryIndex];
            freeEntry = entry.Next;
            entry.Next = null;
            entry.DenseIndex = denseIndex;
            entries[entryIndex] = entry;

            return entry;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Free(int index)
        {
            var entry = entries[index];
            entry.Next = freeEntry;
            entry.Version++;
            entries[index] = entry;
            freeEntry = index;
        }

        public void Reset()
        {
            for (int i = 0; i < entries.Length; i++)
            {
                entries[i] = new() { Next = i == entries.Length - 1 ? null : i + 1, DenseIndex = -1, Version = 1 };
            }
            freeEntry = 0;
        }
    }

    internal sealed class DamperStorage<TValue, TOptions, TAdapter> : IMotionStorage
        where TValue : unmanaged
        where TOptions : unmanaged, IDamperOptions
        where TAdapter : unmanaged, IDamperAdapter<TValue, TOptions>
    {
        public DamperStorage(int id)
        {
            StorageId = id;
            AllocatorHelper = RewindableAllocatorFactory.CreateAllocator();
        }

        // Entry
        readonly StorageEntryList entries = new(InitialCapacity);

        // Data
        public int?[] toEntryIndex = new int?[InitialCapacity];
        public DamperData<TValue, TOptions>[] dataArray = new DamperData<TValue, TOptions>[InitialCapacity];
        public DamperCallbackData[] callbacksArray = new DamperCallbackData[InitialCapacity];

        // Allocator
        AllocatorHelper<RewindableAllocator> AllocatorHelper;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<DamperData<TValue, TOptions>> GetDataSpan() => dataArray.AsSpan(0, tail);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<DamperCallbackData> GetCallbacksSpan() => callbacksArray.AsSpan(0, tail);

        int tail;

        const int InitialCapacity = 8;

        public int StorageId { get; }
        public int Count => tail;

        public (int EntryIndex, int Version) Append(in DamperData<TValue, TOptions> data, in DamperCallbackData callbacks)
        {
            if (tail == dataArray.Length)
            {
                var newLength = tail * 2;
                Array.Resize(ref toEntryIndex, newLength);
                Array.Resize(ref dataArray, newLength);
                Array.Resize(ref callbacksArray, newLength);
            }

            var entry = entries.Alloc(tail, out var entryIndex);
#if LITMOTION_ENABLE_MOTION_LOG
            UnityEngine.Debug.Log("[Add] Entry:" + entryIndex + " Dense:" + entry.DenseIndex + " Version:" + entry.Version);
#endif

            toEntryIndex[tail] = entryIndex;
            dataArray[tail] = data;
            callbacksArray[tail] = callbacks;

            tail++;

            return (entryIndex, entry.Version);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void RemoveAt(int denseIndex)
        {
            tail--;

            // swap elements
            dataArray[denseIndex] = dataArray[tail];
            // dataArray[tail] = default;
            callbacksArray[denseIndex] = callbacksArray[tail];
            // callbacksArray[tail] = default;

            // swap entry indexes
            var prevEntryIndex = toEntryIndex[denseIndex];
            var currentEntryIndex = toEntryIndex[denseIndex] = toEntryIndex[tail];
            // toEntryIndex[tail] = default;

            // update entry
            if (currentEntryIndex != null)
            {
                var index = (int)currentEntryIndex;
                var entry = entries[index];
                entry.DenseIndex = denseIndex;
                entries[index] = entry;
            }

            // free entry
            if (prevEntryIndex != null)
            {
                entries.Free((int)prevEntryIndex);
            }

#if LITMOTION_ENABLE_MOTION_LOG
            var v = entries[(int)prevEntryIndex].Version - 1;
            UnityEngine.Debug.Log("[Remove] Entry:" + prevEntryIndex + " Dense:" + denseIndex + " Version:" + v);
#endif
        }

        public void RemoveAll(NativeList<int> indexes)
        {
            var entryIndexes = new NativeArray<int>(indexes.Length, Allocator.Temp, NativeArrayOptions.UninitializedMemory);
            var lastCallbacksSpan = GetCallbacksSpan();
            for (int i = 0; i < entryIndexes.Length; i++)
            {
                entryIndexes[i] = (int)toEntryIndex[indexes[i]];
            }

            for (int i = 0; i < entryIndexes.Length; i++)
            {
                RemoveAt(entries[entryIndexes[i]].DenseIndex);
            }

            // Avoid Memory leak
            lastCallbacksSpan[tail..].Clear();
            entryIndexes.Dispose();
        }

        public void EnsureCapacity(int capacity)
        {
            if (capacity > dataArray.Length)
            {
                Array.Resize(ref toEntryIndex, capacity);
                Array.Resize(ref dataArray, capacity);
                Array.Resize(ref callbacksArray, capacity);
                entries.EnsureCapacity(capacity);
            }
        }

        public void Cancel(DamperHandle handle)
        {
            var entry = entries[handle.Index];
            var denseIndex = entry.DenseIndex;
            if (denseIndex < 0 || denseIndex >= dataArray.Length)
            {
                throw new ArgumentException("Motion has been destroyed or no longer exists.");
            }

            ref var motion = ref GetDataSpan()[denseIndex];
            var version = entry.Version;
            if (version <= 0 || version != handle.Version || motion.Core.Status == DamperStatus.None)
            {
                throw new ArgumentException("Motion has been destroyed or no longer exists.");
            }

            motion.Core.Status = DamperStatus.Canceled;

            ref var callbackData = ref GetCallbacksSpan()[denseIndex];
            try
            {
                callbackData.OnCancelAction?.Invoke();
            }
            catch (Exception ex)
            {
                DamperDispatcher.GetUnhandledExceptionHandler()?.Invoke(ex);
            }
        }

        public void Complete(DamperHandle handle)
        {
            var entry = entries[handle.Index];
            var denseIndex = entry.DenseIndex;
            if (denseIndex < 0 || denseIndex >= tail)
            {
                throw new ArgumentException("Motion has been destroyed or no longer exists.");
            }

            ref var motion = ref GetDataSpan()[denseIndex];
            var version = entry.Version;
            if (version <= 0 || version != handle.Version || motion.Core.Status == DamperStatus.None)
            {
                throw new ArgumentException("Motion has been destroyed or no longer exists.");
            }

            ref var callbackData = ref GetCallbacksSpan()[denseIndex];
            if (callbackData.IsCallbackRunning)
            {
                throw new InvalidOperationException("Recursion of Complete call was detected.");
            }
            callbackData.IsCallbackRunning = true;

            // To avoid duplication of Complete processing, it is treated as canceled internally.
            motion.Core.Status = DamperStatus.Canceled;

            var endValue = callbackData.GetTargetValueUnsafe<TValue>();

            try
            {
                callbackData.InvokeUnsafe(endValue);
            }
            catch (Exception ex)
            {
                DamperDispatcher.GetUnhandledExceptionHandler()?.Invoke(ex);
            }

            try
            {
                callbackData.OnCompleteAction?.Invoke();
            }
            catch (Exception ex)
            {
                DamperDispatcher.GetUnhandledExceptionHandler()?.Invoke(ex);
            }

            callbackData.IsCallbackRunning = false;
        }

        public bool IsActive(DamperHandle handle)
        {
            var entry = entries[handle.Index];
            var denseIndex = entry.DenseIndex;
            if (denseIndex < 0 || denseIndex >= dataArray.Length) return false;

            var version = entry.Version;
            if (version <= 0 || version != handle.Version) return false;
            var motion = dataArray[denseIndex];
            return motion.Core.Status is DamperStatus.Scheduled or DamperStatus.Delayed or DamperStatus.Playing;
        }

        public ref DamperCallbackData GetCallbackDataRef(DamperHandle handle)
        {
            CheckIndex(handle);
            return ref callbacksArray[entries[handle.Index].DenseIndex];
        }

        public ref DamperDataCore GetDataRef(DamperHandle handle)
        {
            CheckIndex(handle);
            return ref UnsafeUtility.As<DamperData<TValue, TOptions>, DamperDataCore>(ref dataArray[entries[handle.Index].DenseIndex]);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void CheckIndex(DamperHandle handle)
        {
            var entry = entries[handle.Index];
            var denseIndex = entry.DenseIndex;
            if (denseIndex < 0 || denseIndex >= dataArray.Length)
            {
                throw new ArgumentException("Motion has been destroyed or no longer exists.");
            }

            var version = entry.Version;
            if (version <= 0 || version != handle.Version || dataArray[denseIndex].Core.Status == DamperStatus.None)
            {
                throw new ArgumentException("Motion has been destroyed or no longer exists.");
            }
        }

        public void Reset()
        {
            entries.Reset();

            toEntryIndex.AsSpan().Clear();
            dataArray.AsSpan().Clear();
            callbacksArray.AsSpan().Clear();
            tail = 0;

            AllocatorHelper.Allocator.Rewind();
        }
    }
}