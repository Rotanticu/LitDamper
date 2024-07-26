using Unity.Jobs;
using UnityEngine;
using LitDamper;
using LitDamper.Adapters;

[assembly: RegisterGenericJobType(typeof(DamperUpdateJob<float, ShakeOptions, FloatShakeMotionAdapter>))]
[assembly: RegisterGenericJobType(typeof(DamperUpdateJob<Vector2, ShakeOptions, Vector2ShakeMotionAdapter>))]
[assembly: RegisterGenericJobType(typeof(DamperUpdateJob<Vector3, ShakeOptions, Vector3ShakeMotionAdapter>))]

namespace LitDamper.Adapters
{
    // Note: Shake motion uses startValue as offset and endValue as vibration strength.

    public readonly struct FloatShakeMotionAdapter : IDamperAdapter<float, ShakeOptions>
    {
        public float Evaluate(ref float startValue, ref float endValue, ref ShakeOptions options, in DamperEvaluationContext context)
        {
            VibrationHelper.EvaluateStrength(endValue, options.Frequency, options.DampingRatio, context.Progress, out var s);
            float multipliar;
            if (options.RandomState.state == 0)
            {
                multipliar = SharedRandom.Random.NextFloat(-1f, 1f);
            }
            else
            {
                multipliar = options.RandomState.NextFloat(-1f, 1f);
            }
            return startValue + s * multipliar;
        }
    }

    public readonly struct Vector2ShakeMotionAdapter : IDamperAdapter<Vector2, ShakeOptions>
    {
        public Vector2 Evaluate(ref Vector2 startValue, ref Vector2 endValue, ref ShakeOptions options, in DamperEvaluationContext context)
        {
            VibrationHelper.EvaluateStrength(endValue, options.Frequency, options.DampingRatio, context.Progress, out var s);
            Vector2 multipliar;
            if (options.RandomState.state == 0)
            {
                multipliar = new Vector2(SharedRandom.Random.NextFloat(-1f, 1f), SharedRandom.Random.NextFloat(-1f, 1f));
            }
            else
            {
                multipliar = new Vector2(options.RandomState.NextFloat(-1f, 1f), options.RandomState.NextFloat(-1f, 1f));
            }
            return startValue + new Vector2(s.x * multipliar.x, s.y * multipliar.y);
        }
    }

    public readonly struct Vector3ShakeMotionAdapter : IDamperAdapter<Vector3, ShakeOptions>
    {
        public Vector3 Evaluate(ref Vector3 startValue, ref Vector3 endValue, ref ShakeOptions options, in DamperEvaluationContext context)
        {
            VibrationHelper.EvaluateStrength(endValue, options.Frequency, options.DampingRatio, context.Progress, out var s);
            Vector3 multipliar;
            if (options.RandomState.state == 0)
            {
                multipliar = new Vector3(SharedRandom.Random.NextFloat(-1f, 1f), SharedRandom.Random.NextFloat(-1f, 1f), SharedRandom.Random.NextFloat(-1f, 1f));
            }
            else
            {
                multipliar = new Vector3(options.RandomState.NextFloat(-1f, 1f), options.RandomState.NextFloat(-1f, 1f), options.RandomState.NextFloat(-1f, 1f));
            }
            return startValue + new Vector3(s.x * multipliar.x, s.y * multipliar.y, s.z * multipliar.z);
        }
    }
}