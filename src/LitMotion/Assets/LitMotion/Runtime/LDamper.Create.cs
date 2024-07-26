using UnityEngine;
using LitDamper.Adapters;
using System;

namespace LitDamper
{
    /// <summary>
    /// The main class of the LitMotion library that creates and configures motion.
    /// </summary>
    public static partial class LDamper
    {
        /// <summary>
        /// Create a builder for building motion.
        /// </summary>
        /// <param name="from">Start value</param>
        /// <param name="to">End value</param>
        /// <param name="duration">Duration</param>
        /// <returns>Created motion builder</returns>
        public static DamperBuilder<float, NoOptions, FloatMotionAdapter> CreateDamper(Func<float> getCurrentValue,Action<float> setCurrentValue, Func<float> getTargetValue) => CreateDamper<float, NoOptions, FloatMotionAdapter>(getCurrentValue, setCurrentValue, getTargetValue);

        /// <summary>
        /// Create a builder for building motion.
        /// </summary>
        /// <param name="from">Start value</param>
        /// <param name="to">End value</param>
        /// <param name="duration">Duration</param>
        /// <returns>Created motion builder</returns>
        public static DamperBuilder<double, NoOptions, DoubleMotionAdapter> CreateDamper(Func<double> getCurrentValue, Action<double> setCurrentValue, Func<double> getTargetValue) => CreateDamper<double, NoOptions, DoubleMotionAdapter>(getCurrentValue, setCurrentValue, getTargetValue);

        /// <summary>
        /// Create a builder for building motion.
        /// </summary>
        /// <param name="from">Start value</param>
        /// <param name="to">End value</param>
        /// <param name="duration">Duration</param>
        /// <returns>Created motion builder</returns>
        public static DamperBuilder<int, IntegerOptions, IntMotionAdapter> CreateDamper(Func<int> getCurrentValue, Action<int> setCurrentValue, Func<int> getTargetValue) => CreateDamper<int, IntegerOptions, IntMotionAdapter>(getCurrentValue, setCurrentValue, getTargetValue);

        /// <summary>
        /// Create a builder for building motion.
        /// </summary>
        /// <param name="from">Start value</param>
        /// <param name="to">End value</param>
        /// <param name="duration">Duration</param>
        /// <returns>Created motion builder</returns>
        public static DamperBuilder<long, IntegerOptions, LongMotionAdapter> CreateDamper(Func<long> getCurrentValue, Action<long> setCurrentValue, Func<long> getTargetValue) => CreateDamper<long, IntegerOptions, LongMotionAdapter>(getCurrentValue, setCurrentValue, getTargetValue);

        /// <summary>
        /// Create a builder for building motion.
        /// </summary>
        /// <param name="from">Start value</param>
        /// <param name="to">End value</param>
        /// <param name="duration">Duration</param>
        /// <returns>Created motion builder</returns>
        public static DamperBuilder<Vector2, NoOptions, Vector2MotionAdapter> CreateDamper(Func<Vector2> getCurrentValue, Action<Vector2> setCurrentValue, Func<Vector2> getTargetValue) => CreateDamper<Vector2, NoOptions, Vector2MotionAdapter>(getCurrentValue, setCurrentValue, getTargetValue);

        /// <summary>
        /// Create a builder for building motion.
        /// </summary>
        /// <param name="from">Start value</param>
        /// <param name="to">End value</param>
        /// <param name="duration">Duration</param>
        /// <returns>Created motion builder</returns>
        public static DamperBuilder<Vector3, NoOptions, Vector3MotionAdapter> CreateDamper(Func<Vector3> getCurrentValue, Action<Vector3> setCurrentValue, Func<Vector3> getTargetValue) => CreateDamper<Vector3, NoOptions, Vector3MotionAdapter>(getCurrentValue, setCurrentValue, getTargetValue);

        /// <summary>
        /// Create a builder for building motion.
        /// </summary>
        /// <param name="from">Start value</param>
        /// <param name="to">End value</param>
        /// <param name="duration">Duration</param>
        /// <returns>Created motion builder</returns>
        public static DamperBuilder<Vector4, NoOptions, Vector4MotionAdapter> CreateDamper(Func<Vector4> getCurrentValue, Action<Vector4> setCurrentValue, Func<Vector4> getTargetValue) => CreateDamper<Vector4, NoOptions, Vector4MotionAdapter>(getCurrentValue, setCurrentValue, getTargetValue);

        /// <summary>
        /// Create a builder for building motion.
        /// </summary>
        /// <param name="from">Start value</param>
        /// <param name="to">End value</param>
        /// <param name="duration">Duration</param>
        /// <returns>Created motion builder</returns>
        public static DamperBuilder<Quaternion, NoOptions, QuaternionMotionAdapter> CreateDamper(Func<Quaternion> getCurrentValue, Action<Quaternion> setCurrentValue, Func<Quaternion> getTargetValue) => CreateDamper<Quaternion, NoOptions, QuaternionMotionAdapter>(getCurrentValue, setCurrentValue, getTargetValue);

        /// <summary>
        /// Create a builder for building motion.
        /// </summary>
        /// <param name="from">Start value</param>
        /// <param name="to">End value</param>
        /// <param name="duration">Duration</param>
        /// <returns>Created motion builder</returns>
        public static DamperBuilder<Color, NoOptions, ColorMotionAdapter> CreateDamper(Func<Color> getCurrentValue, Action<Color> setCurrentValue, Func<Color> getTargetValue) => CreateDamper<Color, NoOptions, ColorMotionAdapter>(getCurrentValue, setCurrentValue, getTargetValue);

        /// <summary>
        /// Create a builder for building motion.
        /// </summary>
        /// <param name="from">Start value</param>
        /// <param name="to">End value</param>
        /// <param name="duration">Duration</param>
        /// <returns>Created motion builder</returns>
        public static DamperBuilder<Rect, NoOptions, RectMotionAdapter> CreateDamper(Func<Rect> getCurrentValue, Action<Rect> setCurrentValue, Func<Rect> getTargetValue) => CreateDamper<Rect, NoOptions, RectMotionAdapter>(getCurrentValue, setCurrentValue, getTargetValue);

        /// <summary>
        /// Create a builder for building motion.
        /// </summary>
        /// <typeparam name="TValue">The type of value to animate</typeparam>
        /// <typeparam name="TOptions">The type of special parameters given to the motion entity</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="from">Start value</param>
        /// <param name="to">End value</param>
        /// <param name="duration">Duration</param>
        /// <returns>Created motion builder</returns>
        public static DamperBuilder<TValue, TOptions, TAdapter> CreateDamper<TValue, TOptions, TAdapter>(Func<TValue> getCurrentValue, Action<TValue> setCurrentValue, Func<TValue> getTargetValue)
            where TValue : unmanaged
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<TValue, TOptions>
        {
            var buffer = DamperBuilderBuffer<TValue, TOptions>.Rent();
            buffer.CallbackData.GetCurrentValue = getCurrentValue;
            buffer.CallbackData.SetCurrentValue = setCurrentValue;
            buffer.CallbackData.GetTargetValue = getTargetValue;
            return new DamperBuilder<TValue, TOptions, TAdapter>(buffer);
        }
    }
}