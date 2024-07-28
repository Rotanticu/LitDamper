using System;
using UnityEngine;

namespace LitDamper
{
    public struct VelocityDamperOptions : IEquatable<VelocityDamperOptions>, IDamperOptions
    {
        public double TargetVelocity;

        public static VelocityDamperOptions Default
        {
            get
            {
                return new VelocityDamperOptions()
                {
                    TargetVelocity = 1d,
                };
            }
        }

        public readonly bool Equals(VelocityDamperOptions other)
        {
            return other.TargetVelocity == TargetVelocity;
        }

        public override readonly bool Equals(object obj)
        {
            if (obj is VelocityDamperOptions options) return Equals(options);
            return false;
        }

        public override readonly int GetHashCode()
        {
            return TargetVelocity.GetHashCode();
        }
    }
}
