#if LITMOTION_SUPPORT_VFX_GRAPH
using UnityEngine;
using UnityEngine.VFX;

namespace LitDamper.Extensions
{
    /// <summary>
    /// Provides binding extension methods for VisualEffect.
    /// </summary>
    public static class LitMotionVisualEffectExtensions
    {
        /// <summary>
        /// Create a motion data and bind it to VisualEffect parameter.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToVisualEffectFloat<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, VisualEffect visualEffect, string name)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(visualEffect);
            return builder.BindWithState(visualEffect, name, static (x, target, n) =>
            {
                target.SetFloat(n, x);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualEffect parameter.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToVisualEffectFloat<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, VisualEffect visualEffect, int nameID)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(visualEffect);
            return builder.BindWithState(visualEffect, (x, target) =>
            {
                target.SetFloat(nameID, x);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualEffect parameter.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToVisualEffectInt<TOptions, TAdapter>(this DamperBuilder<int, TOptions, TAdapter> builder, VisualEffect visualEffect, string name)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<int, TOptions>
        {
            Error.IsNull(visualEffect);
            return builder.BindWithState(visualEffect, name, static (x, target, n) =>
            {
                target.SetInt(n, x);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualEffect parameter.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToVisualEffectInt<TOptions, TAdapter>(this DamperBuilder<int, TOptions, TAdapter> builder, VisualEffect visualEffect, int nameID)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<int, TOptions>
        {
            Error.IsNull(visualEffect);
            return builder.BindWithState(visualEffect, (x, target) =>
            {
                target.SetFloat(nameID, x);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualEffect parameter.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToVisualEffectVector2<TOptions, TAdapter>(this DamperBuilder<Vector2, TOptions, TAdapter> builder, VisualEffect visualEffect, string name)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector2, TOptions>
        {
            Error.IsNull(visualEffect);
            return builder.BindWithState(visualEffect, name, static (x, target, n) =>
            {
                target.SetVector2(n, x);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualEffect parameter.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToVisualEffectVector2<TOptions, TAdapter>(this DamperBuilder<Vector2, TOptions, TAdapter> builder, VisualEffect visualEffect, int nameID)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector2, TOptions>
        {
            Error.IsNull(visualEffect);
            return builder.BindWithState(visualEffect, (x, target) =>
            {
                target.SetVector2(nameID, x);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualEffect parameter.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToVisualEffectVector3<TOptions, TAdapter>(this DamperBuilder<Vector3, TOptions, TAdapter> builder, VisualEffect visualEffect, string name)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector3, TOptions>
        {
            Error.IsNull(visualEffect);
            return builder.BindWithState(visualEffect, name, static (x, target, n) =>
            {
                target.SetVector3(n, x);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualEffect parameter.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToVisualEffectVector3<TOptions, TAdapter>(this DamperBuilder<Vector3, TOptions, TAdapter> builder, VisualEffect visualEffect, int nameID)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector3, TOptions>
        {
            Error.IsNull(visualEffect);
            return builder.BindWithState(visualEffect, (x, target) =>
            {
                target.SetVector3(nameID, x);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualEffect parameter.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToVisualEffectVector4<TOptions, TAdapter>(this DamperBuilder<Vector4, TOptions, TAdapter> builder, VisualEffect visualEffect, string name)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector4, TOptions>
        {
            Error.IsNull(visualEffect);
            return builder.BindWithState(visualEffect, name, static (x, target, n) =>
            {
                target.SetVector4(n, x);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualEffect parameter.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToVisualEffectVector4<TOptions, TAdapter>(this DamperBuilder<Vector4, TOptions, TAdapter> builder, VisualEffect visualEffect, int nameID)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector4, TOptions>
        {
            Error.IsNull(visualEffect);
            return builder.BindWithState(visualEffect, (x, target) =>
            {
                target.SetVector4(nameID, x);
            });
        }
    }
}
#endif
