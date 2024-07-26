using Unity.Jobs;
using Unity.Mathematics;
using LitDamper;
using LitDamper.Adapters;

[assembly: RegisterGenericJobType(typeof(DamperUpdateJob<float, NoOptions, FloatMotionAdapter>))]
[assembly: RegisterGenericJobType(typeof(DamperUpdateJob<double, NoOptions, DoubleMotionAdapter>))]
[assembly: RegisterGenericJobType(typeof(DamperUpdateJob<int, IntegerOptions, IntMotionAdapter>))]
[assembly: RegisterGenericJobType(typeof(DamperUpdateJob<long, IntegerOptions, LongMotionAdapter>))]

namespace LitDamper.Adapters
{
    public readonly struct FloatMotionAdapter : IDamperAdapter<float, NoOptions>
    {
        public float Evaluate(ref float startValue, ref float endValue, ref NoOptions options, in DamperEvaluationContext context)
        {
            return math.lerp(startValue, endValue, context.Progress);
        }
    }

    public readonly struct DoubleMotionAdapter : IDamperAdapter<double, NoOptions>
    {
        public double Evaluate(ref double startValue, ref double endValue, ref NoOptions options, in DamperEvaluationContext context)
        {
            return math.lerp(startValue, endValue, context.Progress);
        }
    }

    public readonly struct IntMotionAdapter : IDamperAdapter<int, IntegerOptions>
    {
        public int Evaluate(ref int startValue, ref int endValue, ref IntegerOptions options, in DamperEvaluationContext context)
        {
            var value = math.lerp(startValue, endValue, context.Progress);

            return options.RoundingMode switch
            {
                RoundingMode.AwayFromZero => value >= 0f ? (int)math.ceil(value) : (int)math.floor(value),
                RoundingMode.ToZero => (int)math.trunc(value),
                RoundingMode.ToPositiveInfinity => (int)math.ceil(value),
                RoundingMode.ToNegativeInfinity => (int)math.floor(value),
                _ => (int)math.round(value),
            };
        }
    }
    public readonly struct LongMotionAdapter : IDamperAdapter<long, IntegerOptions>
    {
        public long Evaluate(ref long startValue, ref long endValue, ref IntegerOptions options, in DamperEvaluationContext context)
        {
            var value = math.lerp((double)startValue, endValue, context.Progress);

            return options.RoundingMode switch
            {
                RoundingMode.AwayFromZero => value >= 0f ? (long)math.ceil(value) : (long)math.floor(value),
                RoundingMode.ToZero => (long)math.trunc(value),
                RoundingMode.ToPositiveInfinity => (long)math.ceil(value),
                RoundingMode.ToNegativeInfinity => (long)math.floor(value),
                _ => (long)math.round(value),
            };
        }
    }
}