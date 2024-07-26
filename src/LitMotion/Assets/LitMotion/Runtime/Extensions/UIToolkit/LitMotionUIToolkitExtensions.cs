#if LITMOTION_SUPPORT_UIELEMENTS
using Unity.Collections;
using UnityEngine;
using UnityEngine.UIElements;
#if LITMOTION_SUPPORT_ZSTRING
using Cysharp.Text;
#endif

namespace LitDamper.Extensions
{
    /// <summary>
    /// Provides binding extension methods for UIElements.
    /// </summary>
    public static class LitMotionUIToolkitExtensions
    {
        #region VisualElement

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.left
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleLeft<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                target.style.left = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.right
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleRight<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                target.style.right = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.top
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleTop<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                target.style.top = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.bottom
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleBottom<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                target.style.bottom = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.width
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleWidth<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                target.style.width = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.height
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleHeight<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                target.style.height = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.color
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleColor<TOptions, TAdapter>(this DamperBuilder<Color, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Color, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                target.style.color = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.color.r
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleColorR<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                var c = target.style.color.value;
                c.r = x;
                target.style.color = c;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.color.g
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleColorG<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                var c = target.style.color.value;
                c.g = x;
                target.style.color = c;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.color.b
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleColorB<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                var c = target.style.color.value;
                c.b = x;
                target.style.color = c;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.color.a
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleColorA<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                var c = target.style.color.value;
                c.a = x;
                target.style.color = c;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.backgroundColor
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleBackgroundColor<TOptions, TAdapter>(this DamperBuilder<Color, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Color, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                target.style.backgroundColor = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.backgroundColor.r
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleBackgroundColorR<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                var c = target.style.backgroundColor.value;
                c.r = x;
                target.style.backgroundColor = c;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.backgroundColor.g
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleBackgroundColorG<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                var c = target.style.backgroundColor.value;
                c.g = x;
                target.style.backgroundColor = c;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.backgroundColor.b
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleBackgroundColorB<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                var c = target.style.backgroundColor.value;
                c.b = x;
                target.style.backgroundColor = c;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.backgroundColor.a
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleBackgroundColorA<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                var c = target.style.backgroundColor.value;
                c.a = x;
                target.style.backgroundColor = c;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.opacity
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleOpacity<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                target.style.opacity = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.fontSize
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleFontSize<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                target.style.fontSize = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.wordSpacing
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleWordSpacing<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                target.style.wordSpacing = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.translate
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleTranslate<TOptions, TAdapter>(this DamperBuilder<Vector3, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector3, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                target.style.translate = new Translate(x.x, x.y, x.z);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.translate
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleTranslate<TOptions, TAdapter>(this DamperBuilder<Vector2, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector2, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                target.style.translate = new Translate(x.x, x.y);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.rotate
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleRotate<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, VisualElement visualElement, AngleUnit angleUnit = AngleUnit.Degree)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, (x, target) =>
            {
                target.style.rotate = new Rotate(new Angle(x, angleUnit));
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.scale
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleScale<TOptions, TAdapter>(this DamperBuilder<Vector3, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector3, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                target.style.scale = new Scale(x);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.transformOrigin
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleTransformOrigin<TOptions, TAdapter>(this DamperBuilder<Vector3, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector3, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                target.style.transformOrigin = new TransformOrigin(x.x, x.y, x.z);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to VisualElement.style.transformOrigin
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToStyleTransformOrigin<TOptions, TAdapter>(this DamperBuilder<Vector2, TOptions, TAdapter> builder, VisualElement visualElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector2, TOptions>
        {
            Error.IsNull(visualElement);
            return builder.BindWithState(visualElement, static (x, target) =>
            {
                target.style.transformOrigin = new TransformOrigin(x.x, x.y);
            });
        }

        #endregion

        #region AbstractProgressBar

        /// <summary>
        /// Create a motion data and bind it to AbstractProgressBar.value
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToProgressBar<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, AbstractProgressBar progressBar)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(progressBar);
            return builder.BindWithState(progressBar, static (x, target) =>
            {
                target.value = x;
            });
        }

        #endregion

        #region TextElement

        /// <summary>
        /// Create a motion data and bind it to TextElement.text
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<FixedString32Bytes, TOptions, TAdapter> builder, TextElement textElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<FixedString32Bytes, TOptions>
        {
            Error.IsNull(textElement);
            return builder.BindWithState(textElement, static (x, target) =>
            {
                target.text = x.ConvertToString();
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TextElement.text
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<FixedString64Bytes, TOptions, TAdapter> builder, TextElement textElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<FixedString64Bytes, TOptions>
        {
            Error.IsNull(textElement);
            return builder.BindWithState(textElement, static (x, target) =>
            {
                target.text = x.ConvertToString();
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TextElement.text
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<FixedString128Bytes, TOptions, TAdapter> builder, TextElement textElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<FixedString128Bytes, TOptions>
        {
            Error.IsNull(textElement);
            return builder.BindWithState(textElement, static (x, target) =>
            {
                target.text = x.ConvertToString();
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TextElement.text
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<FixedString512Bytes, TOptions, TAdapter> builder, TextElement textElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<FixedString512Bytes, TOptions>
        {
            Error.IsNull(textElement);
            return builder.BindWithState(textElement, static (x, target) =>
            {
                target.text = x.ConvertToString();
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TextElement.text
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="transform"></param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<FixedString4096Bytes, TOptions, TAdapter> builder, TextElement textElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<FixedString4096Bytes, TOptions>
        {
            Error.IsNull(textElement);
            return builder.BindWithState(textElement, static (x, target) =>
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
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<int, TOptions, TAdapter> builder, TextElement textElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<int, TOptions>
        {
            Error.IsNull(textElement);
            return builder.BindWithState(textElement, static (x, target) =>
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
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<int, TOptions, TAdapter> builder, TextElement textElement, string format)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<int, TOptions>
        {
            Error.IsNull(textElement);
            return builder.BindWithState(textElement, format, static (x, target, f) =>
            {
#if LITMOTION_SUPPORT_ZSTRING
                target.text = ZString.Format(f, x);
#else
                target.text = string.Format(f, x);
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
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<long, TOptions, TAdapter> builder, TextElement textElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<long, TOptions>
        {
            Error.IsNull(textElement);
            return builder.BindWithState(textElement, static (x, target) =>
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
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<long, TOptions, TAdapter> builder, TextElement textElement, string format)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<long, TOptions>
        {
            Error.IsNull(textElement);
            return builder.BindWithState(textElement, format, static (x, target, format) =>
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
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TextElement textElement)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(textElement);
            return builder.BindWithState(textElement, static (x, target) =>
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
        public static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TextElement textElement, string format)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(textElement);
            return builder.BindWithState(textElement, format, static (x, target, format) =>
            {
#if LITMOTION_SUPPORT_ZSTRING
                target.text = ZString.Format(format, x);
#else
                target.text = string.Format(format, x);
#endif
            });
        }
        #endregion
    }
}
#endif
