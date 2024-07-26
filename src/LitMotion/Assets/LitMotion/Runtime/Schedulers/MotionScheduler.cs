namespace LitDamper
{
    /// <summary>
    /// Schedulers available in Runtime.
    /// </summary>
    public static class MotionScheduler
    {
        static MotionScheduler()
        {
            DefaultScheduler = Update;
        }

        /// <summary>
        /// Default scheduler used if not specified
        /// </summary>
        public static IDamperScheduler DefaultScheduler { get; set; }

        /// <summary>
        /// Scheduler that updates motion at Initialization.
        /// </summary>
        public static readonly IDamperScheduler Initialization = new PlayerLoopMotionScheduler(PlayerLoopTiming.Initialization, MotionTimeKind.Time);
        /// <summary>
        /// Scheduler that updates motion at Initialization. (Ignore timescale)
        /// </summary>
        public static readonly IDamperScheduler InitializationIgnoreTimeScale = new PlayerLoopMotionScheduler(PlayerLoopTiming.Initialization, MotionTimeKind.UnscaledTime);
        /// <summary>
        /// Scheduler that updates motion at Initialization. (Realtime)
        /// </summary>
        public static readonly IDamperScheduler InitializationRealtime = new PlayerLoopMotionScheduler(PlayerLoopTiming.Initialization, MotionTimeKind.Realtime);

        /// <summary>
        /// Scheduler that updates motion at EarlyUpdate.
        /// </summary>
        public static readonly IDamperScheduler EarlyUpdate = new PlayerLoopMotionScheduler(PlayerLoopTiming.EarlyUpdate, MotionTimeKind.Time);
        /// <summary>
        /// Scheduler that updates motion at EarlyUpdate. (Ignore timescale)
        /// </summary>
        public static readonly IDamperScheduler EarlyUpdateIgnoreTimeScale = new PlayerLoopMotionScheduler(PlayerLoopTiming.EarlyUpdate, MotionTimeKind.UnscaledTime);
        /// <summary>
        /// Scheduler that updates motion at EarlyUpdate. (Realtime)
        /// </summary>
        public static readonly IDamperScheduler EarlyUpdateRealtime = new PlayerLoopMotionScheduler(PlayerLoopTiming.EarlyUpdate, MotionTimeKind.Realtime);

        /// <summary>
        /// Scheduler that updates motion at FixedUpdate.
        /// </summary>
        public static readonly IDamperScheduler FixedUpdate = new PlayerLoopMotionScheduler(PlayerLoopTiming.FixedUpdate, MotionTimeKind.Time);

        /// <summary>
        /// Scheduler that updates motion at PreUpdate.
        /// </summary>
        public static readonly IDamperScheduler PreUpdate = new PlayerLoopMotionScheduler(PlayerLoopTiming.PreUpdate, MotionTimeKind.Time);
        /// <summary>
        /// Scheduler that updates motion at PreUpdate. (Ignore timescale)
        /// </summary>
        public static readonly IDamperScheduler PreUpdateIgnoreTimeScale = new PlayerLoopMotionScheduler(PlayerLoopTiming.PreUpdate, MotionTimeKind.UnscaledTime);
        /// <summary>
        /// Scheduler that updates motion at PreUpdate. (Realtime)
        /// </summary>
        public static readonly IDamperScheduler PreUpdateRealtime = new PlayerLoopMotionScheduler(PlayerLoopTiming.PreUpdate, MotionTimeKind.Realtime);

        /// <summary>
        /// Scheduler that updates motion at Update.
        /// </summary>
        public static readonly IDamperScheduler Update = new PlayerLoopMotionScheduler(PlayerLoopTiming.Update, MotionTimeKind.Time);
        /// <summary>
        /// Scheduler that updates motion at Update. (Ignore timescale)
        /// </summary>
        public static readonly IDamperScheduler UpdateIgnoreTimeScale = new PlayerLoopMotionScheduler(PlayerLoopTiming.Update, MotionTimeKind.UnscaledTime);
        /// <summary>
        /// Scheduler that updates motion at Update. (Realtime)
        /// </summary>
        public static readonly IDamperScheduler UpdateRealtime = new PlayerLoopMotionScheduler(PlayerLoopTiming.Update, MotionTimeKind.Realtime);

        /// <summary>
        /// Scheduler that updates motion at PreLateUpdate.
        /// </summary>
        public static readonly IDamperScheduler PreLateUpdate = new PlayerLoopMotionScheduler(PlayerLoopTiming.PreLateUpdate, MotionTimeKind.Time);
        /// <summary>
        /// Scheduler that updates motion at PreLateUpdate. (Ignore timescale)
        /// </summary>
        public static readonly IDamperScheduler PreLateUpdateIgnoreTimeScale = new PlayerLoopMotionScheduler(PlayerLoopTiming.PreLateUpdate, MotionTimeKind.UnscaledTime);
        /// <summary>
        /// Scheduler that updates motion at PreLateUpdate. (Realtime)
        /// </summary>
        public static readonly IDamperScheduler PreLateUpdateRealtime = new PlayerLoopMotionScheduler(PlayerLoopTiming.PreLateUpdate, MotionTimeKind.Realtime);

        /// <summary>
        /// Scheduler that updates motion at PostLateUpdate.
        /// </summary>
        public static readonly IDamperScheduler PostLateUpdate = new PlayerLoopMotionScheduler(PlayerLoopTiming.PostLateUpdate, MotionTimeKind.Time);
        /// <summary>
        /// Scheduler that updates motion at PostLateUpdate. (Ignore timescale)
        /// </summary>
        public static readonly IDamperScheduler PostLateUpdateIgnoreTimeScale = new PlayerLoopMotionScheduler(PlayerLoopTiming.PostLateUpdate, MotionTimeKind.UnscaledTime);
        /// <summary>
        /// Scheduler that updates motion at PostLateUpdate. (Realtime)
        /// </summary>
        public static readonly IDamperScheduler PostLateUpdateRealtime = new PlayerLoopMotionScheduler(PlayerLoopTiming.PostLateUpdate, MotionTimeKind.Realtime);

        /// <summary>
        /// Scheduler that updates motion at TimeUpdate.
        /// </summary>
        public static readonly IDamperScheduler TimeUpdate = new PlayerLoopMotionScheduler(PlayerLoopTiming.TimeUpdate, MotionTimeKind.Time);
        /// <summary>
        /// Scheduler that updates motion at TimeUpdate. (Ignore timescale)
        /// </summary>
        public static readonly IDamperScheduler TimeUpdateIgnoreTimeScale = new PlayerLoopMotionScheduler(PlayerLoopTiming.TimeUpdate, MotionTimeKind.UnscaledTime);
        /// <summary>
        /// Scheduler that updates motion at TimeUpdate. (Realtime)
        /// </summary>
        public static readonly IDamperScheduler TimeUpdateRealtime = new PlayerLoopMotionScheduler(PlayerLoopTiming.TimeUpdate, MotionTimeKind.Realtime);

        /// <summary>
        /// Scheduler that updates motion with `ManualMotionDispatcher.Update()`
        /// </summary>
        public static readonly IDamperScheduler Manual = new ManualMotionScheduler();
    }
}