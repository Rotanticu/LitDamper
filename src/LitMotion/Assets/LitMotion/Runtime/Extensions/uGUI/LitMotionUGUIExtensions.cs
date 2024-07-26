#if LITMOTION_SUPPORT_UGUI
using UnityEngine;
using UnityEngine.UI;
using Unity.Collections;
#if LITMOTION_SUPPORT_ZSTRING
using Cysharp.Text;
#endif

namespace LitDamper.Extensions
{
    /// <summary>
    /// Provides binding extension methods for Unity UI (uGUI) components.
    /// </summary>
    public static class LitMotionUGUIExtensions
    {
        /// <summary>
        /// Create a motion data and bind it to Graphic.color
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToColor<TOptions, TAdapter>(this DamperBuilder<Color, TOptions, TAdapter> builder, Graphic graphic)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Color, TOptions>
        {
            Error.IsNull(graphic);
            return builder.BindWithState(graphic, static (x, target) =>
            {
                target.color = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Graphic.color.r
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToColorR<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Graphic graphic)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(graphic);
            return builder.BindWithState(graphic, static (x, target) =>
            {
                var c = target.color;
                c.r = x;
                target.color = c;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Graphic.color.g
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToColorG<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Graphic graphic)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(graphic);
            return builder.BindWithState(graphic, static (x, target) =>
            {
                var c = target.color;
                c.g = x;
                target.color = c;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Graphic.color.b
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToColorB<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Graphic graphic)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(graphic);
            return builder.BindWithState(graphic, static (x, target) =>
            {
                var c = target.color;
                c.b = x;
                target.color = c;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Graphic.color.a
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToColorA<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Graphic graphic)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(graphic);
            return builder.BindWithState(graphic, static (x, target) =>
            {
                var c = target.color;
                c.a = x;
                target.color = c;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Image.FillAmount
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToFillAmount<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Image image)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(image);
            return builder.BindWithState(image, static (x, target) =>
            {
                target.fillAmount = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to CanvasGroup.alpha
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToCanvasGroupAlpha<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, CanvasGroup canvasGroup)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(canvasGroup);
            return builder.BindWithState(canvasGroup, static (x, target) =>
            {
                target.alpha = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Text.fontSize
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToFontSize<TOptions, TAdapter>(this DamperBuilder<int, TOptions, TAdapter> builder, Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<int, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                target.fontSize = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Text.text
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<FixedString32Bytes, TOptions, TAdapter> builder, Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<FixedString32Bytes, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                target.text = x.ConvertToString();
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Text.text
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<FixedString64Bytes, TOptions, TAdapter> builder, Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<FixedString64Bytes, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                target.text = x.ConvertToString();
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Text.text
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<FixedString128Bytes, TOptions, TAdapter> builder, Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<FixedString128Bytes, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                target.text = x.ConvertToString();
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Text.text
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<FixedString512Bytes, TOptions, TAdapter> builder, Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<FixedString512Bytes, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                target.text = x.ConvertToString();
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Text.text
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<FixedString4096Bytes, TOptions, TAdapter> builder, Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<FixedString4096Bytes, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                target.text = x.ConvertToString();
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Text.text
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<int, TOptions, TAdapter> builder, Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<int, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                target.text = x.ToString();
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Text.text
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <param name="format">Format string</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<int, TOptions, TAdapter> builder, Text text, string format)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<int, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, format, static (x, target, format) =>
            {
#if LITMOTION_SUPPORT_ZSTRING
                target.text = ZString.Format(format, x);
#else
                target.text = string.Format(format, x);
#endif
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Text.text
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<long, TOptions, TAdapter> builder, Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<long, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                target.text = x.ToString();
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Text.text
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <param name="format">Format string</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<long, TOptions, TAdapter> builder, Text text, string format)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<long, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, format, static (x, target, format) =>
            {
#if LITMOTION_SUPPORT_ZSTRING
                target.text = ZString.Format(format, x);
#else
                target.text = string.Format(format, x);
#endif
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Text.text
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                target.text = x.ToString();
            });
        }

        /// <summary>
        /// Create a motion data and bind it to Text.text
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <param name="format">Format string</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, Text text, string format)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, format, static (x, target, format) =>
            {
#if LITMOTION_SUPPORT_ZSTRING
                target.text = ZString.Format(format, x);
#else
                target.text = string.Format(format, x);
#endif
            });
        }
    }
}
#endif
