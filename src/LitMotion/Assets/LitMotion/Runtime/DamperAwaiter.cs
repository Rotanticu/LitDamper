using System;
using System.Runtime.CompilerServices;

namespace LitDamper
{
    public readonly struct DamperAwaiter : ICriticalNotifyCompletion
    {
        readonly DamperHandle handle;
        public bool IsCompleted => !handle.IsActive();

        public DamperAwaiter(DamperHandle handle)
        {
            this.handle = handle;
        }

        public DamperAwaiter GetAwaiter()
        {
            return this;
        }

        public void GetResult()
        {
        }

        public void OnCompleted(Action continuation)
        {
            UnsafeOnCompleted(continuation);
        }

        public void UnsafeOnCompleted(Action continuation)
        {
            if (continuation == null) return;

            ref var callbackData = ref MotionStorageManager.GetMotionCallbackDataRef(handle);
            callbackData.OnCompleteAction += continuation;
            callbackData.OnCancelAction += continuation;
        }
    }
}