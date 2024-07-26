using Unity.Collections;
using Unity.Jobs;
using LitDamper;
using LitDamper.Adapters;

[assembly: RegisterGenericJobType(typeof(DamperUpdateJob<FixedString32Bytes, StringOptions, FixedString32BytesMotionAdapter>))]
[assembly: RegisterGenericJobType(typeof(DamperUpdateJob<FixedString64Bytes, StringOptions, FixedString64BytesMotionAdapter>))]
[assembly: RegisterGenericJobType(typeof(DamperUpdateJob<FixedString128Bytes, StringOptions, FixedString128BytesMotionAdapter>))]
[assembly: RegisterGenericJobType(typeof(DamperUpdateJob<FixedString512Bytes, StringOptions, FixedString512BytesMotionAdapter>))]
[assembly: RegisterGenericJobType(typeof(DamperUpdateJob<FixedString4096Bytes, StringOptions, FixedString4096BytesMotionAdapter>))]

namespace LitDamper.Adapters
{
    public readonly struct FixedString32BytesMotionAdapter : IDamperAdapter<FixedString32Bytes, StringOptions>
    {
        public FixedString32Bytes Evaluate(ref FixedString32Bytes startValue, ref FixedString32Bytes endValue, ref StringOptions options, in DamperEvaluationContext context)
        {
            var start = startValue;
            var end = endValue;
            var customScrambleChars = options.CustomScrambleChars;
            ref var randomState = ref options.RandomState;
            if (randomState.state == 0) randomState = ref SharedRandom.Random;
            FixedStringHelper.Interpolate(ref start, ref end, context.Progress, options.ScrambleMode, options.RichTextEnabled, ref randomState, ref customScrambleChars, out var result);
            return result;
        }
    }

    public readonly struct FixedString64BytesMotionAdapter : IDamperAdapter<FixedString64Bytes, StringOptions>
    {
        public FixedString64Bytes Evaluate(ref FixedString64Bytes startValue, ref FixedString64Bytes endValue, ref StringOptions options, in DamperEvaluationContext context)
        {
            var start = startValue;
            var end = endValue;
            var customScrambleChars = options.CustomScrambleChars;
            ref var randomState = ref options.RandomState;
            if (randomState.state == 0) randomState = ref SharedRandom.Random;
            FixedStringHelper.Interpolate(ref start, ref end, context.Progress, options.ScrambleMode, options.RichTextEnabled, ref randomState, ref customScrambleChars, out var result);
            return result;
        }
    }

    public readonly struct FixedString128BytesMotionAdapter : IDamperAdapter<FixedString128Bytes, StringOptions>
    {
        public FixedString128Bytes Evaluate(ref FixedString128Bytes startValue, ref FixedString128Bytes endValue, ref StringOptions options, in DamperEvaluationContext context)
        {
            var start = startValue;
            var end = endValue;
            var customScrambleChars = options.CustomScrambleChars;
            ref var randomState = ref options.RandomState;
            if (randomState.state == 0) randomState = ref SharedRandom.Random;
            FixedStringHelper.Interpolate(ref start, ref end, context.Progress, options.ScrambleMode, options.RichTextEnabled, ref randomState, ref customScrambleChars, out var result);
            return result;
        }
    }

    public readonly struct FixedString512BytesMotionAdapter : IDamperAdapter<FixedString512Bytes, StringOptions>
    {
        public FixedString512Bytes Evaluate(ref FixedString512Bytes startValue, ref FixedString512Bytes endValue, ref StringOptions options, in DamperEvaluationContext context)
        {
            var start = startValue;
            var end = endValue;
            var customScrambleChars = options.CustomScrambleChars;
            ref var randomState = ref options.RandomState;
            if (randomState.state == 0) randomState = ref SharedRandom.Random;
            FixedStringHelper.Interpolate(ref start, ref end, context.Progress, options.ScrambleMode, options.RichTextEnabled, ref randomState, ref customScrambleChars, out var result);
            return result;
        }
    }

    public readonly struct FixedString4096BytesMotionAdapter : IDamperAdapter<FixedString4096Bytes, StringOptions>
    {
        public FixedString4096Bytes Evaluate(ref FixedString4096Bytes startValue, ref FixedString4096Bytes endValue, ref StringOptions options, in DamperEvaluationContext context)
        {
            var start = startValue;
            var end = endValue;
            var customScrambleChars = options.CustomScrambleChars;
            ref var randomState = ref options.RandomState;
            if (randomState.state == 0) randomState = ref SharedRandom.Random;
            FixedStringHelper.Interpolate(ref start, ref end, context.Progress, options.ScrambleMode, options.RichTextEnabled, ref randomState, ref customScrambleChars, out var result);
            return result;
        }
    }
}