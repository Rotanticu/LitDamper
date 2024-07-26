using System;
using LitDamper.Collections;

namespace LitDamper
{
    /// <summary>
    /// Manually updatable MotionDispatcher
    /// </summary>
    public static class ManualDamperDispatcher
    {
        static class Cache<TValue, TOptions, TAdapter>
            where TValue : unmanaged
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<TValue, TOptions>
        {
            public static DamperStorage<TValue, TOptions, TAdapter> updateStorage;
            public static UpdateRunner<TValue, TOptions, TAdapter> updateRunner;

            public static DamperStorage<TValue, TOptions, TAdapter> GetOrCreate()
            {
                if (updateStorage == null)
                {
                    var storage = new DamperStorage<TValue, TOptions, TAdapter>(MotionStorageManager.CurrentStorageId);
                    MotionStorageManager.AddStorage(storage);
                    updateStorage = storage;
                }
                return updateStorage;
            }
        }

        static FastListCore<IUpdateRunner> updateRunners;

        /// <summary>
        /// ManualMotionDispatcher time. It increases every time Update is called.
        /// </summary>
        public static double Time { get; set; }

        /// <summary>
        /// Ensures the storage capacity until it reaches at least `capacity`.
        /// </summary>
        /// <param name="capacity">The minimum capacity to ensure.</param>
        public static void EnsureStorageCapacity<TValue, TOptions, TAdapter>(int capacity)
            where TValue : unmanaged
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<TValue, TOptions>
        {
            Cache<TValue, TOptions, TAdapter>.GetOrCreate().EnsureCapacity(capacity);
        }

        /// <summary>
        /// Update all scheduled motions with MotionScheduler.Manual
        /// </summary>
        /// <param name="deltaTime">Delta time</param>
        public static void Update(double deltaTime)
        {
            if (deltaTime < 0f) throw new ArgumentException("deltaTime must be 0 or higher.");
            Time += deltaTime;
            Update();
        }

        /// <summary>
        /// Update all scheduled motions with MotionScheduler.Manual
        /// </summary>
        public static void Update()
        {
            var span = updateRunners.AsSpan();
            for (int i = 0; i < span.Length; i++)
            {
                span[i].Update(Time, Time, Time);
            }
        }

        /// <summary>
        /// Cancel all motions and reset data.
        /// </summary>
        public static void Reset()
        {
            var span = updateRunners.AsSpan();
            for (int i = 0; i < span.Length; i++)
            {
                span[i].Reset();
            }
        }

        internal static DamperHandle Schedule<TValue, TOptions, TAdapter>(in DamperData<TValue, TOptions> data, in DamperCallbackData callbackData)
           where TValue : unmanaged
           where TOptions : unmanaged, IDamperOptions
           where TAdapter : unmanaged, IDamperAdapter<TValue, TOptions>
        {
            DamperStorage<TValue, TOptions, TAdapter> storage = Cache<TValue, TOptions, TAdapter>.GetOrCreate();
            if (Cache<TValue, TOptions, TAdapter>.updateRunner == null)
            {
                var runner = new UpdateRunner<TValue, TOptions, TAdapter>(storage, Time, Time, Time);
                updateRunners.Add(runner);
                Cache<TValue, TOptions, TAdapter>.updateRunner = runner;
            }

            var (EntryIndex, Version) = storage.Append(data, callbackData);
            return new DamperHandle()
            {
                StorageId = storage.StorageId,
                Index = EntryIndex,
                Version = Version
            };
        }
    }
}