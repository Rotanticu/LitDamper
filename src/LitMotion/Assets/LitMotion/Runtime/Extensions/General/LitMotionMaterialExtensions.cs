using UnityEngine;

namespace LitDamper.Extensions
{
    /// <summary>
    /// Provides binding extension methods for Material.
    /// </summary>
    public static class LitMotionMaterialExtensions
    {
        /// <summary>
        /// Create a motion data and bind it to a material property.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToMaterialFloat<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Material material, string name)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(material);
            return builder.BindWithState(material, name, static (x, m, n) =>
            {
                m.SetFloat(n, x);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to a material property.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToMaterialFloat<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Material material, int nameID)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(material);
            return builder.BindWithState(material, (x, m) =>
            {
                m.SetFloat(nameID, x);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to a material property.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToMaterialInt<TOptions, TAdapter>(this DamperBuilder<int, TOptions, TAdapter> builder, Material material, string name)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<int, TOptions>
        {
            Error.IsNull(material);
            return builder.BindWithState(material, name, static (x, m, n) =>
            {
                m.SetInteger(n, x);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to a material property.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToMaterialInt<TOptions, TAdapter>(this DamperBuilder<int, TOptions, TAdapter> builder, Material material, int nameID)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<int, TOptions>
        {
            Error.IsNull(material);
            return builder.BindWithState(material, (x, m) =>
            {
                m.SetInteger(nameID, x);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to a material property.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToMaterialColor<TOptions, TAdapter>(this DamperBuilder<Color, TOptions, TAdapter> builder, Material material, string name)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Color, TOptions>
        {
            Error.IsNull(material);
            return builder.BindWithState(material, name, static (x, m, n) =>
            {
                m.SetColor(n, x);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to a material property.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToMaterialColor<TOptions, TAdapter>(this DamperBuilder<Color, TOptions, TAdapter> builder, Material material, int nameID)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Color, TOptions>
        {
            Error.IsNull(material);
            return builder.BindWithState(material, (x, m) =>
            {
                m.SetColor(nameID, x);
            });
        }
    }
}
