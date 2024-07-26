using UnityEditor;

namespace LitDamper.Editor
{
    internal sealed class EditorUpdateMotionScheduler : IDamperScheduler
    {
        public double Time => EditorApplication.timeSinceStartup;

        public DamperHandle Schedule<TValue, TOptions, TAdapter>(ref DamperData<TValue, TOptions> data, ref DamperCallbackData callbackData)
            where TValue : unmanaged
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<TValue, TOptions>
        {
            return EditorMotionDispatcher.Schedule<TValue, TOptions, TAdapter>(data, callbackData);
        }
    }
}