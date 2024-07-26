namespace LitDamper
{
    /// <summary>
    /// Motion status.
    /// </summary>
    public enum DamperStatus
    {
        None = 0,
        Scheduled = 1,
        Delayed = 2,
        Playing = 3,
        Completed = 4,
        Canceled = 5,
        Disposed = 6,
    }
}