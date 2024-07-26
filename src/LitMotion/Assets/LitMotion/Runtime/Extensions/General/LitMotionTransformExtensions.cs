using UnityEngine;

namespace LitDamper.Extensions
{
    /// <summary>
    /// Provides binding extension methods for Transform.
    /// </summary>
    public static class LitMotionTransformExtensions
    {
        /// <summary>
        /// Create a motion data and bind it to Transform.position
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToPosition<TOptions, TAdapter>(this DamperBuilder<Vector3, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector3, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                t.position = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Transform.position.x
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToPositionX<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.position;
                p.x = x;
                t.position = p;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Transform.position.y
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToPositionY<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.position;
                p.y = x;
                t.position = p;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Transform.position.z
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToPositionZ<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.position;
                p.z = x;
                t.position = p;
            });
        }
        
        /// <summary>
        /// Create a motion data and bind it to Transform.position.xy
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToPositionXY<TOptions, TAdapter>(this DamperBuilder<Vector2, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector2, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.position;
                p.x = x.x;
                p.y = x.y;
                t.position = p;
            });
        }
        
        /// <summary>
        /// Create a motion data and bind it to Transform.position.xz
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToPositionXZ<TOptions, TAdapter>(this DamperBuilder<Vector2, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector2, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.position;
                p.x = x.x;
                p.z = x.y;
                t.position = p;
            });
        }
        
        /// <summary>
        /// Create a motion data and bind it to Transform.position.yz
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToPositionYZ<TOptions, TAdapter>(this DamperBuilder<Vector2, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector2, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.position;
                p.y = x.x;
                p.z = x.y;
                t.position = p;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Transform.localPosition
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalPosition<TOptions, TAdapter>(this DamperBuilder<Vector3, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector3, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                t.localPosition = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Transform.localPosition.x
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalPositionX<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.localPosition;
                p.x = x;
                t.localPosition = p;
            });
        }


        /// <summary>
        /// Create a motion data and bind it to Transform.localPosition.y
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalPositionY<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.localPosition;
                p.y = x;
                t.localPosition = p;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Transform.localPosition.z
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalPositionZ<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.localPosition;
                p.z = x;
                t.localPosition = p;
            });
        }
        
        /// <summary>
        /// Create a motion data and bind it to Transform.localPosition.xy
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalPositionXY<TOptions, TAdapter>(this DamperBuilder<Vector2, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector2, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.localPosition;
                p.x = x.x;
                p.y = x.y;
                t.localPosition = p;
            });
        }
        
        /// <summary>
        /// Create a motion data and bind it to Transform.localPosition.xz
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalPositionXZ<TOptions, TAdapter>(this DamperBuilder<Vector2, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector2, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.localPosition;
                p.x = x.x;
                p.z = x.y;
                t.localPosition = p;
            });
        }
        
        /// <summary>
        /// Create a motion data and bind it to Transform.localPosition.yz
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalPositionYZ<TOptions, TAdapter>(this DamperBuilder<Vector2, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector2, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.localPosition;
                p.y = x.x;
                p.z = x.y;
                t.localPosition = p;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Transform.rotation
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToRotation<TOptions, TAdapter>(this DamperBuilder<Quaternion, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Quaternion, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                t.rotation = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Transform.localRotation
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalRotation<TOptions, TAdapter>(this DamperBuilder<Quaternion, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Quaternion, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                t.localRotation = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Transform.eulerAngles
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToEulerAngles<TOptions, TAdapter>(this DamperBuilder<Vector3, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector3, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                t.eulerAngles = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Transform.eulerAngles.x
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToEulerAnglesX<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.eulerAngles;
                p.x = x;
                t.eulerAngles = p;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Transform.eulerAngles.y
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToEulerAnglesY<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.eulerAngles;
                p.y = x;
                t.eulerAngles = p;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Transform.eulerAngles.z
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToEulerAnglesZ<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.eulerAngles;
                p.z = x;
                t.eulerAngles = p;
            });
        }
        
        /// <summary>
        /// Create a motion data and bind it to Transform.eulerAngles.xy
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToEulerAnglesXY<TOptions, TAdapter>(this DamperBuilder<Vector2, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector2, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.eulerAngles;
                p.x = x.x;
                p.y = x.y;
                t.eulerAngles = p;
            });
        }
        
        /// <summary>
        /// Create a motion data and bind it to Transform.eulerAngles.xz
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToEulerAnglesXZ<TOptions, TAdapter>(this DamperBuilder<Vector2, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector2, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.eulerAngles;
                p.x = x.x;
                p.z = x.y;
                t.eulerAngles = p;
            });
        }
        
        /// <summary>
        /// Create a motion data and bind it to Transform.eulerAngles.yz
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToEulerAnglesYZ<TOptions, TAdapter>(this DamperBuilder<Vector2, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector2, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.eulerAngles;
                p.y = x.x;
                p.z = x.y;
                t.eulerAngles = p;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Transform.localEulerAngles
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalEulerAngles<TOptions, TAdapter>(this DamperBuilder<Vector3, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector3, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                t.localEulerAngles = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Transform.localEulerAngles.x
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalEulerAnglesX<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.localEulerAngles;
                p.x = x;
                t.localEulerAngles = p;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Transform.localEulerAngles.y
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalEulerAnglesY<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.localEulerAngles;
                p.y = x;
                t.localEulerAngles = p;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Transform.localEulerAngles.z
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalEulerAnglesZ<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.localEulerAngles;
                p.z = x;
                t.localEulerAngles = p;
            });
        }
        
        /// <summary>
        /// Create a motion data and bind it to Transform.localEulerAngles.xy
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalEulerAnglesXY<TOptions, TAdapter>(this DamperBuilder<Vector2, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector2, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.localEulerAngles;
                p.x = x.x;
                p.y = x.y;
                t.localEulerAngles = p;
            });
        }
        
        /// <summary>
        /// Create a motion data and bind it to Transform.localEulerAngles.xz
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalEulerAnglesXZ<TOptions, TAdapter>(this DamperBuilder<Vector2, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector2, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.localEulerAngles;
                p.x = x.x;
                p.z = x.y;
                t.localEulerAngles = p;
            });
        }
        
        /// <summary>
        /// Create a motion data and bind it to Transform.localEulerAngles.yz
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalEulerAnglesYZ<TOptions, TAdapter>(this DamperBuilder<Vector2, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector2, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.localEulerAngles;
                p.y = x.x;
                p.z = x.y;
                t.localEulerAngles = p;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Transform.localScale
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalScale<TOptions, TAdapter>(this DamperBuilder<Vector3, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector3, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                t.localScale = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Transform.localScale.x
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalScaleX<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.localScale;
                p.x = x;
                t.localScale = p;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Transform.localScale.y
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalScaleY<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.localScale;
                p.y = x;
                t.localScale = p;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Transform.localScale.z
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalScaleZ<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.localScale;
                p.z = x;
                t.localScale = p;
            });
        }
        
        /// <summary>
        /// Create a motion data and bind it to Transform.localScale.xy
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalScaleXY<TOptions, TAdapter>(this DamperBuilder<Vector2, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector2, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.localScale;
                p.x = x.x;
                p.y = x.y;
                t.localScale = p;
            });
        }
        
        /// <summary>
        /// Create a motion data and bind it to Transform.localScale.xz
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalScaleXZ<TOptions, TAdapter>(this DamperBuilder<Vector2, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector2, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.localScale;
                p.x = x.x;
                p.z = x.y;
                t.localScale = p;
            });
        }
        
        /// <summary>
        /// Create a motion data and bind it to Transform.localScale.yz
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToLocalScaleYZ<TOptions, TAdapter>(this DamperBuilder<Vector2, TOptions, TAdapter> builder, Transform transform)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector2, TOptions>
        {
            Error.IsNull(transform);
            return builder.BindWithState(transform, static (x, t) =>
            {
                var p = t.localScale;
                p.y = x.x;
                p.z = x.y;
                t.localScale = p;
            });
        }
    }
}