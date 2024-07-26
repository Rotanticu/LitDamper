using System;
using System.Runtime.CompilerServices;
using LitDamper.Collections;

namespace LitDamper
{
    internal static class MotionStorageManager
    {
        static FastListCore<IMotionStorage> storageList;

        public static int CurrentStorageId { get; private set; }

        public static void AddStorage<TValue, TOptions, TAdapter>(DamperStorage<TValue, TOptions, TAdapter> storage)
            where TValue : unmanaged
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<TValue, TOptions>
        {
            storageList.Add(storage);
            CurrentStorageId++;
        }

        public static void CompleteMotion(DamperHandle handle)
        {
            CheckStorageId(handle);
            storageList[handle.StorageId].Complete(handle);
        }

        public static void CancelMotion(DamperHandle handle)
        {
            CheckStorageId(handle);
            storageList[handle.StorageId].Cancel(handle);
        }

        public static bool IsActive(DamperHandle handle)
        {
            if (handle.StorageId < 0 || handle.StorageId >= CurrentStorageId) return false;
            return storageList[handle.StorageId].IsActive(handle);
        }

        public static ref DamperDataCore GetMotionDataRef(DamperHandle handle)
        {
            CheckStorageId(handle);
            return ref storageList[handle.StorageId].GetDataRef(handle);
        }

        public static ref DamperCallbackData GetMotionCallbackDataRef(DamperHandle handle)
        {
            CheckStorageId(handle);
            return ref storageList[handle.StorageId].GetCallbackDataRef(handle);
        }

        // For MotionTracker
        public static (Type ValueType, Type OptionsType, Type AdapterType) GetMotionType(DamperHandle handle)
        {
            CheckStorageId(handle);
            var storageType = storageList[handle.StorageId].GetType();
            var valueType = storageType.GenericTypeArguments[0];
            var optionsType = storageType.GenericTypeArguments[1];
            var adapterType = storageType.GenericTypeArguments[2];
            return (valueType, optionsType, adapterType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static void CheckStorageId(in DamperHandle handle)
        {
            if (handle.StorageId < 0 || handle.StorageId >= CurrentStorageId)
                throw new ArgumentException("Invalid storage id.");
        }
    }
}