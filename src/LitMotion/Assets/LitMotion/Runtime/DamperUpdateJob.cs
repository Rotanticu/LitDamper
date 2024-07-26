using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace LitDamper
{
    /// <summary>
    /// A job that updates the status of the motion data and outputs the current value.
    /// </summary>
    /// <typeparam name="TValue">The type of value to animate</typeparam>
    /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
    /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
    [BurstCompile]
    public unsafe struct DamperUpdateJob<TValue, TOptions, TAdapter> : IJobParallelFor
        where TValue : unmanaged
        where TOptions : unmanaged, IDamperOptions
        where TAdapter : unmanaged, IDamperAdapter<TValue, TOptions>
    {
        [NativeDisableUnsafePtrRestriction] public DamperData<TValue, TOptions>* DataPtr;
        [ReadOnly] public double DeltaTime;
        [ReadOnly] public double UnscaledDeltaTime;
        [ReadOnly] public double RealDeltaTime;

        [WriteOnly] public NativeList<int>.ParallelWriter CompletedIndexList;
        [WriteOnly] public NativeArray<TValue> Output;

        public void Execute([AssumeRange(0, int.MaxValue)] int index)
        {
            //var ptr = DataPtr + index;
            //var corePtr = (DamperDataCore*)ptr;

            //if (Hint.Likely(corePtr->Status is DamperStatus.Scheduled or DamperStatus.Delayed or DamperStatus.Playing))
            //{
            //    var deltaTime = corePtr->TimeKind switch
            //    {
            //        MotionTimeKind.Time => DeltaTime,
            //        MotionTimeKind.UnscaledTime => UnscaledDeltaTime,
            //        MotionTimeKind.Realtime => RealDeltaTime,
            //        _ => default
            //    };

            //    corePtr->Time = math.max(corePtr->Time + deltaTime * corePtr->PlaybackSpeed, 0.0);
            //    var motionTime = corePtr->Time;

            //    double t;
            //    bool isCompleted;
            //    bool isDelayed;
            //    int completedLoops;
            //    int clampedCompletedLoops;

            //    if (Hint.Unlikely(corePtr->Duration <= 0f))
            //    {
            //        if (corePtr->DelayType == DelayType.FirstLoop || corePtr->Delay == 0f)
            //        {
            //            var time = motionTime - corePtr->Delay;
            //            isCompleted = corePtr->Loops >= 0 && time > 0f;
            //            if (isCompleted)
            //            {
            //                t = 1f;
            //                completedLoops = corePtr->Loops;
            //            }
            //            else
            //            {
            //                t = 0f;
            //                completedLoops = time < 0f ? -1 : 0;
            //            }
            //            clampedCompletedLoops = corePtr->Loops < 0 ? math.max(0, completedLoops) : math.clamp(completedLoops, 0, corePtr->Loops);
            //            isDelayed = time < 0;
            //        }
            //        else
            //        {
            //            completedLoops = (int)math.floor(motionTime / corePtr->Delay);
            //            clampedCompletedLoops = corePtr->Loops < 0 ? math.max(0, completedLoops) : math.clamp(completedLoops, 0, corePtr->Loops);
            //            isCompleted = corePtr->Loops >= 0 && clampedCompletedLoops > corePtr->Loops - 1;
            //            isDelayed = !isCompleted;
            //            t = isCompleted ? 1f : 0f;
            //        }
            //    }
            //    else
            //    {
            //        if (corePtr->DelayType == DelayType.FirstLoop)
            //        {
            //            var time = motionTime - corePtr->Delay;
            //            completedLoops = (int)math.floor(time / corePtr->Duration);
            //            clampedCompletedLoops = corePtr->Loops < 0 ? math.max(0, completedLoops) : math.clamp(completedLoops, 0, corePtr->Loops);
            //            isCompleted = corePtr->Loops >= 0 && clampedCompletedLoops > corePtr->Loops - 1;
            //            isDelayed = time < 0f;

            //            if (isCompleted)
            //            {
            //                t = 1f;
            //            }
            //            else
            //            {
            //                var currentLoopTime = time - corePtr->Duration * clampedCompletedLoops;
            //                t = math.clamp(currentLoopTime / corePtr->Duration, 0f, 1f);
            //            }
            //        }
            //        else
            //        {
            //            var currentLoopTime = math.fmod(motionTime, corePtr->Duration + corePtr->Delay) - corePtr->Delay;
            //            completedLoops = (int)math.floor(motionTime / (corePtr->Duration + corePtr->Delay));
            //            clampedCompletedLoops = corePtr->Loops < 0 ? math.max(0, completedLoops) : math.clamp(completedLoops, 0, corePtr->Loops);
            //            isCompleted = corePtr->Loops >= 0 && clampedCompletedLoops > corePtr->Loops - 1;
            //            isDelayed = currentLoopTime < 0;

            //            if (isCompleted)
            //            {
            //                t = 1f;
            //            }
            //            else
            //            {
            //                t = math.clamp(currentLoopTime / corePtr->Duration, 0f, 1f);
            //            }
            //        }
            //    }

            //    float progress;
            //    switch (corePtr->LoopType)
            //    {
            //        default:
            //        case LoopType.Restart:
            //            progress = GetEasedValue(corePtr, (float)t);
            //            break;
            //        case LoopType.Yoyo:
            //            progress = GetEasedValue(corePtr, (float)t);
            //            if ((clampedCompletedLoops + (int)t) % 2 == 1) progress = 1f - progress;
            //            break;
            //        case LoopType.Incremental:
            //            progress = GetEasedValue(corePtr, 1f) * clampedCompletedLoops + GetEasedValue(corePtr, (float)math.fmod(t, 1f));
            //            break;
            //    }

            //    var totalDuration = corePtr->DelayType == DelayType.FirstLoop
            //        ? corePtr->Delay + corePtr->Duration * corePtr->Loops
            //        : (corePtr->Delay + corePtr->Duration) * corePtr->Loops;

            //    if (corePtr->Loops > 0 && motionTime >= totalDuration)
            //    {
            //        corePtr->Status = DamperStatus.Completed;
            //    }
            //    else if (isDelayed)
            //    {
            //        corePtr->Status = DamperStatus.Delayed;
            //    }
            //    else
            //    {
            //        corePtr->Status = DamperStatus.Playing;
            //    }

            //    var context = new DamperEvaluationContext()
            //    {
            //        Progress = progress
            //    };

            //    Output[index] = default(TAdapter).Evaluate(ref ptr->StartValue, ref ptr->EndValue, ref ptr->Options, context);
            //}
            //else if (corePtr->Status is DamperStatus.Completed or DamperStatus.Canceled)
            //{
            //    CompletedIndexList.AddNoResize(index);
            //    corePtr->Status = DamperStatus.Disposed;
            //}
        }

        //static float GetEasedValue(DamperDataCore* data, float value)
        //{
        //    return data->Ease switch
        //    {
        //        Ease.CustomAnimationCurve => data->AnimationCurve.Evaluate(value),
        //        _ => EaseUtility.Evaluate(value, data->Ease)
        //    };
        //}
    }
}