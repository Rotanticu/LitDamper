using System;
using System.Runtime.InteropServices;
using LitDamper.Collections;
using Unity.Plastic.Newtonsoft.Json.Serialization;

namespace LitDamper
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DamperDataCore
    {
        public DamperStatus Status;

        public float PlaybackSpeed;

        public MotionTimeKind TimeKind;

        public SpringType springType;

        public double HalfTime;

        public double CurrentValue;
        public double TargetValue;

        public double motionTime;
        public double velocity;
        public double t;
        public double xi;
        public double vi;

        public static readonly DamperDataCore Default = new()
        {
            springType = SpringType.DoubleSpring,
            PlaybackSpeed = 1f,
            HalfTime = 0.333d
        };
    }
    
    /// <summary>
    /// A structure representing motion data.
    /// </summary>
    /// <typeparam name="TValue">The type of value to animate</typeparam>
    /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
    [StructLayout(LayoutKind.Sequential)]
    public struct DamperData<TValue, TOptions>
        where TValue : unmanaged
        where TOptions : unmanaged, IDamperOptions
    {
        // Because of pointer casting, this field must always be placed at the beginning.
        public DamperDataCore Core;
        public TOptions Options;

        public static readonly DamperData<TValue, TOptions> Default = new()
        {
            Core = DamperDataCore.Default,
        };
    }
}