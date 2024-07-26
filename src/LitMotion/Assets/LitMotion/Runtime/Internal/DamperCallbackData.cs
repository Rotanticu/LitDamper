using System;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;

namespace LitDamper
{
    /// <summary>
    /// A structure that holds motion callbacks.
    /// </summary>
    public struct DamperCallbackData
    {
        public byte StateCount;
        public bool IsCallbackRunning;
        public bool CancelOnError;
        public bool SkipValuesDuringDelay;
        public object State1;
        public object State2;
        public object State3;

        public object UpdateAction;
        public Action OnCompleteAction;
        public Action OnCancelAction;

        public object GetCurrentValue;
        public object SetCurrentValue;
        public object GetTargetValue;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void InvokeUnsafe<TValue>(in TValue value) where TValue : unmanaged
        {
            switch (StateCount)
            {
                case 0:
                    UnsafeUtility.As<object, Action<TValue>>(ref UpdateAction)?.Invoke(value);
                    break;
                case 1:
                    UnsafeUtility.As<object, Action<TValue, object>>(ref UpdateAction)?.Invoke(value, State1);
                    break;
                case 2:
                    UnsafeUtility.As<object, Action<TValue, object, object>>(ref UpdateAction)?.Invoke(value, State1, State2);
                    break;
                case 3:
                    UnsafeUtility.As<object, Action<TValue, object, object, object>>(ref UpdateAction)?.Invoke(value, State1, State2, State3);
                    break;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TValue GetCurrentValueUnsafe<TValue>() where TValue : unmanaged
        {
            return (TValue)UnsafeUtility.As<object, Func<TValue>>(ref GetCurrentValue)?.Invoke();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetCurrentValueUnsafe<TValue>(in TValue value) where TValue : unmanaged
        {
            UnsafeUtility.As<object, Action<TValue>>(ref GetCurrentValue)?.Invoke(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TValue GetTargetValueUnsafe<TValue>(in TValue value) where TValue : unmanaged
        {
            return (TValue)UnsafeUtility.As<object, Func<TValue>>(ref GetTargetValue)?.Invoke();
        }

        public readonly static DamperCallbackData Default = new() { };
    }
}