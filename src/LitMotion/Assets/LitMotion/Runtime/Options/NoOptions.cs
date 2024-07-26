using System;

namespace LitDamper
{
    /// <summary>
    /// A type indicating that motion has no special options. Specify in the type argument of MotionAdapter when the option is not required.
    /// </summary>
    public readonly struct NoOptions : IDamperOptions, IEquatable<NoOptions>
    {
        public bool Equals(NoOptions other)
        {
            return true;
        }

        public override bool Equals(object obj)
        {
            return obj is NoOptions;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}