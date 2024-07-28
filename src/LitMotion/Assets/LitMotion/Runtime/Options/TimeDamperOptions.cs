using System;
using UnityEngine;

namespace LitDamper
{
    public struct TimeDamperOptions : IEquatable<TimeDamperOptions>, IDamperOptions
    {
        public double TargetTime;

        public static TimeDamperOptions Default
        {
            get
            {
                return new TimeDamperOptions()
                {
                    TargetTime = 0.9d,
                };
            }
        }

        public readonly bool Equals(TimeDamperOptions other)
        {
            return other.TargetTime == TargetTime;
        }

        public override readonly bool Equals(object obj)
        {
            if (obj is TimeDamperOptions options) return Equals(options);
            return false;
        }

        public override readonly int GetHashCode()
        {
            return TargetTime.GetHashCode();
        }
    }
}
