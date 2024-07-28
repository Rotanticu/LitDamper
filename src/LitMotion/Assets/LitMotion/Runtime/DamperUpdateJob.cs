using System;
using Unity.Burst;
using Unity.Burst.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using static Codice.Client.BaseCommands.Import.Commit;
using static Codice.CM.Common.Purge.PurgeReport;

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
        [WriteOnly] public NativeArray<double> Output;

        public void Execute([AssumeRange(0, int.MaxValue)] int index)
        {
            var ptr = DataPtr + index;
            var corePtr = (DamperDataCore*)ptr;

            if (Hint.Likely(corePtr->Status is DamperStatus.Scheduled or DamperStatus.Playing))
            {
                var deltaTime = corePtr->TimeKind switch
                {
                    MotionTimeKind.Time => DeltaTime,
                    MotionTimeKind.UnscaledTime => UnscaledDeltaTime,
                    MotionTimeKind.Realtime => RealDeltaTime,
                    _ => default
                } * corePtr->PlaybackSpeed;

                corePtr->motionTime += deltaTime;

                double currentValue = corePtr->CurrentValue;
                double targetValue = corePtr->TargetValue;

                currentValue = corePtr->springType switch
                {
                    SpringType.SimpleSpring => DamperUtility.SimpleSpringDamperImplicit(currentValue, ref corePtr->velocity, targetValue, corePtr->HalfTime, deltaTime),
                    SpringType.TimedSpring => DamperUtility.TimedSpringDamperImplicit(currentValue, ref corePtr->velocity, ref corePtr->xi, targetValue, UnsafeUtility.As<TOptions, TimeDamperOptions>(ref ptr->Options).TargetTime, corePtr->HalfTime, deltaTime),
                    SpringType.VelocitySpring => DamperUtility.VelocitySpringDamperImplicit(currentValue, ref corePtr->velocity, ref corePtr->xi, targetValue, UnsafeUtility.As<TOptions, VelocityDamperOptions>(ref ptr->Options).TargetVelocity, corePtr->HalfTime, deltaTime),
                    SpringType.DoubleSpring => DamperUtility.DoubleSpringDamperImplicit(currentValue, ref corePtr->velocity, ref corePtr->xi, ref corePtr->vi, targetValue, corePtr->HalfTime, deltaTime),
                    _ => throw new NotImplementedException(),
                };

                corePtr->CurrentValue = currentValue;
                bool isCompleted = DamperUtility.Approximately(currentValue, targetValue);

                if (isCompleted)
                {
                    corePtr->Status = DamperStatus.Completed;
                }
                else
                {
                    corePtr->Status = DamperStatus.Playing;
                }

                //var context = new DamperEvaluationContext()
                //{
                //    Progress = (float)progress,
                //};

                //Output[index] = default(TAdapter).Evaluate(ref DataPtr->CurrentValue, ref DataPtr->TargetValue, ref ptr->Options, context);
                Output[index] = currentValue;
            }
            else if (corePtr->Status is DamperStatus.Completed)
            {
                corePtr->Status = DamperStatus.Delayed;
            }
            else if(corePtr->Status is DamperStatus.Canceled)
            {
                CompletedIndexList.AddNoResize(index);
                corePtr->Status = DamperStatus.Disposed;
            }
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