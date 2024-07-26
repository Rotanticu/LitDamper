using Unity.Jobs;
using UnityEngine;
using LitDamper;
using LitDamper.Adapters;

[assembly: RegisterGenericJobType(typeof(DamperUpdateJob<float, PunchOptions, FloatPunchMotionAdapter>))]
[assembly: RegisterGenericJobType(typeof(DamperUpdateJob<Vector2, PunchOptions, Vector2PunchMotionAdapter>))]
[assembly: RegisterGenericJobType(typeof(DamperUpdateJob<Vector3, PunchOptions, Vector3PunchMotionAdapter>))]

namespace LitDamper.Adapters
{
    // Note: Punch motion uses startValue as offset and endValue as vibration strength.

    public readonly struct FloatPunchMotionAdapter : IDamperAdapter<float, PunchOptions>
    {
        public float Evaluate(ref float startValue, ref float endValue, ref PunchOptions options, in DamperEvaluationContext context)
        {
            VibrationHelper.EvaluateStrength(endValue, options.Frequency, options.DampingRatio, context.Progress, out var result);
            return startValue + result;
        }
    }

    public readonly struct Vector2PunchMotionAdapter : IDamperAdapter<Vector2, PunchOptions>
    {
        public Vector2 Evaluate(ref Vector2 startValue, ref Vector2 endValue, ref PunchOptions options, in DamperEvaluationContext context)
        {
            VibrationHelper.EvaluateStrength(endValue, options.Frequency, options.DampingRatio, context.Progress, out var result);
            return startValue + result;
        }
    }

    public readonly struct Vector3PunchMotionAdapter : IDamperAdapter<Vector3, PunchOptions>
    {
        public Vector3 Evaluate(ref Vector3 startValue, ref Vector3 endValue, ref PunchOptions options, in DamperEvaluationContext context)
        {
            VibrationHelper.EvaluateStrength(endValue, options.Frequency, options.DampingRatio, context.Progress, out var result);
            return startValue + result;
        }
    }
}