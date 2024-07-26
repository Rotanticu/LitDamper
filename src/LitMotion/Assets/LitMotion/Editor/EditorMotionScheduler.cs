namespace LitDamper.Editor
{
    /// <summary>
    /// Schedulers available in Editor.
    /// </summary>
    public static class EditorMotionScheduler
    {
        /// <summary>
        /// Scheduler that updates motion at EditorApplication.update.
        /// </summary>
        public static readonly IDamperScheduler Update = new EditorUpdateMotionScheduler();
    }
}