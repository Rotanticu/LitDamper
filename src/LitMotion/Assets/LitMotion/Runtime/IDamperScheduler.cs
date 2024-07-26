namespace LitDamper
{
    /// <summary>
    /// Provides the function to schedule the execution of a motion.
    /// </summary>
    public interface IDamperScheduler
    {
        /// <summary>
        /// Schedule the motion.
        /// </summary>
        /// <typeparam name="TValue">The type of value to animate</typeparam>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="data">Motion data</param>
        /// <param name="callbackData">Motion callback data</param>
        /// <returns>Motion handle</returns>
        DamperHandle Schedule<TValue, TOptions, TAdapter>(ref DamperData<TValue, TOptions> data, ref DamperCallbackData callbackData)
            where TValue : unmanaged
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<TValue, TOptions>;

        /// <summary>
        /// Returns the current time.
        /// </summary>
        double Time { get; }
    }

    /// <summary>
    /// Type of time used to play the motion
    /// </summary>
    public enum MotionTimeKind : byte
    {
        Time = 0,
        UnscaledTime = 1,
        Realtime = 2
    }
}