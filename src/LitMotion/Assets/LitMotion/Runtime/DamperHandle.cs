using System;

namespace LitDamper
{
    /// <summary>
    /// An identifier that represents a specific motion entity.
    /// </summary>
    public struct DamperHandle : IEquatable<DamperHandle>
    {
        /// <summary>
        /// The ID of motion storage.
        /// </summary>
        public int StorageId;

        /// <summary>
        /// The ID of motion entity.
        /// </summary>
        public int Index;

        /// <summary>
        /// The generational version of motion entity.
        /// </summary>
        public int Version;

        /// <summary>
        /// Motion playback speed.
        /// </summary>
        public readonly float PlaybackSpeed
        {
            get
            {
                return MotionStorageManager.GetMotionDataRef(this).PlaybackSpeed;
            }
            set
            {
                if (value < 0f) Error.PlaybackSpeedMustBeZeroOrGreater();
                MotionStorageManager.GetMotionDataRef(this).PlaybackSpeed = value;
            }
        }

        public readonly bool Equals(DamperHandle other)
        {
            return Index == other.Index && Version == other.Version && StorageId == other.StorageId;
        }

        public override readonly bool Equals(object obj)
        {
            if (obj is DamperHandle handle) return Equals(handle);
            return false;
        }

        public override readonly int GetHashCode()
        {
            return HashCode.Combine(Index, Version, StorageId);
        }

        public static bool operator ==(DamperHandle a, DamperHandle b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(DamperHandle a, DamperHandle b)
        {
            return !(a == b);
        }
    }
}