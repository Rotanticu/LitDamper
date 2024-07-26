namespace LitDamper
{
    internal sealed class ManualMotionScheduler : IDamperScheduler
    {
        public double Time => ManualDamperDispatcher.Time;

        public DamperHandle Schedule<TValue, TOptions, TAdapter>(ref DamperData<TValue, TOptions> data, ref DamperCallbackData callbackData)
            where TValue : unmanaged
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<TValue, TOptions>
        {
            return ManualDamperDispatcher.Schedule<TValue, TOptions, TAdapter>(data, callbackData);
        }
    }
}