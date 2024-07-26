using UnityEngine;

namespace LitDamper.Extensions
{
    /// <summary>
    /// Provides binding extension methods for SpriteRenderer.
    /// </summary>
    public static class LitMotionSpriteRendererExtensions
    {
        /// <summary>
        /// Create a motion data and bind it to SpriteRenderer.color
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToColor<TOptions, TAdapter>(this DamperBuilder<Color, TOptions, TAdapter> builder, SpriteRenderer spriteRenderer)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Color, TOptions>
        {
            Error.IsNull(spriteRenderer);
            return builder.BindWithState(spriteRenderer, static (x, m) =>
            {
                m.color = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to SpriteRenderer.color.r
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToColorR<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, SpriteRenderer spriteRenderer)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(spriteRenderer);
            return builder.BindWithState(spriteRenderer, static (x, m) =>
            {
                var c = m.color;
                c.r = x;
                m.color = c;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to SpriteRenderer.color.g
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToColorG<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, SpriteRenderer spriteRenderer)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(spriteRenderer);
            return builder.BindWithState(spriteRenderer, static (x, m) =>
            {
                var c = m.color;
                c.g = x;
                m.color = c;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to SpriteRenderer.color.b
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToColorB<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, SpriteRenderer spriteRenderer)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(spriteRenderer);
            return builder.BindWithState(spriteRenderer, static (x, m) =>
            {
                var c = m.color;
                c.b = x;
                m.color = c;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to SpriteRenderer.color.a
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToColorA<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, SpriteRenderer spriteRenderer)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(spriteRenderer);
            return builder.BindWithState(spriteRenderer, static (x, m) =>
            {
                var c = m.color;
                c.a = x;
                m.color = c;
            });
        }
    }
}