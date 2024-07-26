#if LITMOTION_SUPPORT_TMP
using System.Buffers;
using UnityEngine;
using Unity.Collections;
using TMPro;
#if LITMOTION_SUPPORT_ZSTRING
using Cysharp.Text;
#endif

namespace LitDamper.Extensions
{
    /// <summary>
    /// Provides binding extension methods for TMP_Text
    /// </summary>
    public static class LitMotionTextMeshProExtensions
    {
        /// <summary>
        /// Create a motion data and bind it to TMP_Text.fontSize
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToFontSize<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TMP_Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                target.fontSize = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TMP_Text.maxVisibleCharacters
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToMaxVisibleCharacters<TOptions, TAdapter>(this DamperBuilder<int, TOptions, TAdapter> builder, TMP_Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<int, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                target.maxVisibleCharacters = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TMP_Text.maxVisibleLines
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToMaxVisibleLines<TOptions, TAdapter>(this DamperBuilder<int, TOptions, TAdapter> builder, TMP_Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<int, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                target.maxVisibleLines = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TMP_Text.maxVisibleWords
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToMaxVisibleWords<TOptions, TAdapter>(this DamperBuilder<int, TOptions, TAdapter> builder, TMP_Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<int, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                target.maxVisibleWords = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TMP_Text.color
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToColor<TOptions, TAdapter>(this DamperBuilder<Color, TOptions, TAdapter> builder, TMP_Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Color, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                target.color = x;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TMP_Text.color.r
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToColorR<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TMP_Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                var c = target.color;
                c.r = x;
                target.color = c;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TMP_Text.color.g
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToColorG<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TMP_Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                var c = target.color;
                c.g = x;
                target.color = c;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TMP_Text.color.b
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToColorB<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TMP_Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                var c = target.color;
                c.b = x;
                target.color = c;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TMP_Text.color.a
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToColorA<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TMP_Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                var c = target.color;
                c.a = x;
                target.color = c;
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TMP_Text.text.
        /// </summary>
        /// <remarks>
        /// Note: This extension method uses TMP_Text.SetText() to achieve zero allocation, so it is recommended to use this method when binding to text.
        /// </remarks>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <returns>Handle of the created motion data.</returns>
        public unsafe static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<FixedString32Bytes, TOptions, TAdapter> builder, TMP_Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<FixedString32Bytes, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                var enumerator = x.GetEnumerator();
                var length = 0;
                var buffer = ArrayPool<char>.Shared.Rent(64);
                fixed (char* c = buffer)
                {
                    Unicode.Utf8ToUtf16(x.GetUnsafePtr(), x.Length, c, out length, x.Length * 2);
                }
                target.SetText(buffer, 0, length);
                ArrayPool<char>.Shared.Return(buffer);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TMP_Text.text.
        /// </summary>
        /// <remarks>
        /// Note: This extension method uses TMP_Text.SetText() to achieve zero allocation, so it is recommended to use this method when binding to text.
        /// </remarks>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <returns>Handle of the created motion data.</returns>
        public unsafe static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<FixedString64Bytes, TOptions, TAdapter> builder, TMP_Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<FixedString64Bytes, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                var enumerator = x.GetEnumerator();
                var length = 0;
                var buffer = ArrayPool<char>.Shared.Rent(128);
                fixed (char* c = buffer)
                {
                    Unicode.Utf8ToUtf16(x.GetUnsafePtr(), x.Length, c, out length, x.Length * 2);
                }
                target.SetText(buffer, 0, length);
                ArrayPool<char>.Shared.Return(buffer);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TMP_Text.text.
        /// </summary>
        /// <remarks>
        /// Note: This extension method uses TMP_Text.SetText() to achieve zero allocation, so it is recommended to use this method when binding to text.
        /// </remarks>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <returns>Handle of the created motion data.</returns>
        public unsafe static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<FixedString128Bytes, TOptions, TAdapter> builder, TMP_Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<FixedString128Bytes, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                var enumerator = x.GetEnumerator();
                var length = 0;
                var buffer = ArrayPool<char>.Shared.Rent(256);
                fixed (char* c = buffer)
                {
                    Unicode.Utf8ToUtf16(x.GetUnsafePtr(), x.Length, c, out length, x.Length * 2);
                }
                target.SetText(buffer, 0, length);
                ArrayPool<char>.Shared.Return(buffer);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TMP_Text.text.
        /// </summary>
        /// <remarks>
        /// Note: This extension method uses TMP_Text.SetText() to achieve zero allocation, so it is recommended to use this method when binding to text.
        /// </remarks>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <returns>Handle of the created motion data.</returns>
        public unsafe static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<FixedString512Bytes, TOptions, TAdapter> builder, TMP_Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<FixedString512Bytes, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                var enumerator = x.GetEnumerator();
                var length = 0;
                var buffer = ArrayPool<char>.Shared.Rent(1024);
                fixed (char* c = buffer)
                {
                    Unicode.Utf8ToUtf16(x.GetUnsafePtr(), x.Length, c, out length, x.Length * 2);
                }
                target.SetText(buffer, 0, length);
                ArrayPool<char>.Shared.Return(buffer);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TMP_Text.text.
        /// </summary>
        /// <remarks>
        /// Note: This extension method uses TMP_Text.SetText() to achieve zero allocation, so it is recommended to use this method when binding to text.
        /// </remarks>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <returns>Handle of the created motion data.</returns>
        public unsafe static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<FixedString4096Bytes, TOptions, TAdapter> builder, TMP_Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<FixedString4096Bytes, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
                var enumerator = x.GetEnumerator();
                var length = 0;
                var buffer = ArrayPool<char>.Shared.Rent(8192);
                fixed (char* c = buffer)
                {
                    Unicode.Utf8ToUtf16(x.GetUnsafePtr(), x.Length, c, out length, x.Length * 2);
                }
                target.SetText(buffer, 0, length);
                ArrayPool<char>.Shared.Return(buffer);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TMP_Text.text.
        /// </summary>
        /// <remarks>
        /// Note: This extension method uses TMP_Text.SetText() to achieve zero allocation, so it is recommended to use this method when binding to text.
        /// </remarks>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <returns>Handle of the created motion data.</returns>
        public unsafe static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<int, TOptions, TAdapter> builder, TMP_Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<int, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {

                var buffer = ArrayPool<char>.Shared.Rent(128);
                var bufferOffset = 0;
                Utf16StringHelper.WriteInt32(ref buffer, ref bufferOffset, x);
                target.SetText(buffer, 0, bufferOffset);
                ArrayPool<char>.Shared.Return(buffer);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TMP_Text.text.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="format">Format string</param>
        /// <returns>Handle of the created motion data.</returns>
        public unsafe static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<int, TOptions, TAdapter> builder, TMP_Text text, string format)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<int, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, format, static (x, target, format) =>
            {
#if LITMOTION_SUPPORT_ZSTRING
                target.SetTextFormat(format, x);
#else
                target.text = string.Format(format, x);
#endif
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TMP_Text.text.
        /// </summary>
        /// <remarks>
        /// Note: This extension method uses TMP_Text.SetText() to achieve zero allocation, so it is recommended to use this method when binding to text.
        /// </remarks>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <returns>Handle of the created motion data.</returns>
        public unsafe static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<long, TOptions, TAdapter> builder, TMP_Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<long, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {

                var buffer = ArrayPool<char>.Shared.Rent(128);
                var bufferOffset = 0;
                Utf16StringHelper.WriteInt64(ref buffer, ref bufferOffset, x);
                target.SetText(buffer, 0, bufferOffset);
                ArrayPool<char>.Shared.Return(buffer);
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TMP_Text.text.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="format">Format string</param>
        /// <returns>Handle of the created motion data.</returns>
        public unsafe static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<long, TOptions, TAdapter> builder, TMP_Text text, string format)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<long, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, format, static (x, target, format) =>
            {
#if LITMOTION_SUPPORT_ZSTRING
                target.SetTextFormat(format, x);
#else
                target.text = string.Format(format, x);
#endif
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TMP_Text.text.
        /// </summary>
        /// <remarks>
        /// Note: This extension method uses TMP_Text.SetText() to achieve zero allocation, so it is recommended to use this method when binding to text.
        /// </remarks>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <returns>Handle of the created motion data.</returns>
        public unsafe static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TMP_Text text)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            const string format = "{0}";
            Error.IsNull(text);
            return builder.BindWithState(text, static (x, target) =>
            {
#if LITMOTION_SUPPORT_ZSTRING
                target.SetTextFormat(format, x);
#else
                target.SetText(format, x);
#endif
            });
        }

        /// <summary>
        /// Create a motion data and bind it to TMP_Text.text.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="format">Format string</param>
        /// <returns>Handle of the created motion data.</returns>
        public unsafe static DamperHandle BindToText<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TMP_Text text, string format)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);
            return builder.BindWithState(text, format, static (x, target, format) =>
            {
#if LITMOTION_SUPPORT_ZSTRING
                target.SetTextFormat(format, x);
#else
                target.text = string.Format(format, x);
#endif
            });
        }

        /// <summary>
        /// Create motion data and bind it to the character color.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="charIndex">Target character index</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToTMPCharColor<TOptions, TAdapter>(this DamperBuilder<Color, TOptions, TAdapter> builder, TMP_Text text, int charIndex)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Color, TOptions>
        {
            Error.IsNull(text);

            var animator = TextMeshProMotionAnimator.Get(text);
            animator.EnsureCapacity(charIndex + 1);
            var handle = builder.BindWithState(animator, (x, target) =>
            {
                animator.charInfoArray[charIndex].color = x;
            });
            animator.motionHandleList.Add(handle);

            return handle;
        }

        /// <summary>
        /// Create motion data and bind it to the character color.r.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="charIndex">Target character index</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToTMPCharColorR<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TMP_Text text, int charIndex)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);

            var animator = TextMeshProMotionAnimator.Get(text);
            animator.EnsureCapacity(charIndex + 1);
            var handle = builder.BindWithState(animator, (x, target) =>
            {
                animator.charInfoArray[charIndex].color.r = x;
            });
            animator.motionHandleList.Add(handle);

            return handle;
        }

        /// <summary>
        /// Create motion data and bind it to the character color.g.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="charIndex">Target character index</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToTMPCharColorG<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TMP_Text text, int charIndex)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);

            var animator = TextMeshProMotionAnimator.Get(text);
            animator.EnsureCapacity(charIndex + 1);
            var handle = builder.BindWithState(animator, (x, target) =>
            {
                animator.charInfoArray[charIndex].color.g = x;
            });
            animator.motionHandleList.Add(handle);

            return handle;
        }

        /// <summary>
        /// Create motion data and bind it to the character color.b.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="charIndex">Target character index</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToTMPCharColorB<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TMP_Text text, int charIndex)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);

            var animator = TextMeshProMotionAnimator.Get(text);
            animator.EnsureCapacity(charIndex + 1);
            var handle = builder.BindWithState(animator, (x, target) =>
            {
                animator.charInfoArray[charIndex].color.b = x;
            });
            animator.motionHandleList.Add(handle);

            return handle;
        }

        /// <summary>
        /// Create motion data and bind it to the character color.a.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="charIndex">Target character index</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToTMPCharColorA<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TMP_Text text, int charIndex)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);

            var animator = TextMeshProMotionAnimator.Get(text);
            animator.EnsureCapacity(charIndex + 1);
            var handle = builder.BindWithState(animator, (x, target) =>
            {
                animator.charInfoArray[charIndex].color.a = x;
            });
            animator.motionHandleList.Add(handle);

            return handle;
        }

        /// <summary>
        /// Create motion data and bind it to the character position.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="charIndex">Target character index</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToTMPCharPosition<TOptions, TAdapter>(this DamperBuilder<Vector3, TOptions, TAdapter> builder, TMP_Text text, int charIndex)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector3, TOptions>
        {
            Error.IsNull(text);

            var animator = TextMeshProMotionAnimator.Get(text);
            animator.EnsureCapacity(charIndex + 1);
            var handle = builder.BindWithState(animator, (x, target) =>
            {
                animator.charInfoArray[charIndex].position = x;
            });
            animator.motionHandleList.Add(handle);

            return handle;
        }

        /// <summary>
        /// Create motion data and bind it to the character position.x.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="charIndex">Target character index</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToTMPCharPositionX<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TMP_Text text, int charIndex)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);

            var animator = TextMeshProMotionAnimator.Get(text);
            animator.EnsureCapacity(charIndex + 1);
            var handle = builder.BindWithState(animator, (x, target) =>
            {
                animator.charInfoArray[charIndex].position.x = x;
            });
            animator.motionHandleList.Add(handle);

            return handle;
        }

        /// <summary>
        /// Create motion data and bind it to the character position.y.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="charIndex">Target character index</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToTMPCharPositionY<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TMP_Text text, int charIndex)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);

            var animator = TextMeshProMotionAnimator.Get(text);
            animator.EnsureCapacity(charIndex + 1);
            var handle = builder.BindWithState(animator, (x, target) =>
            {
                animator.charInfoArray[charIndex].position.y = x;
            });
            animator.motionHandleList.Add(handle);

            return handle;
        }

        /// <summary>
        /// Create motion data and bind it to the character position.z.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="charIndex">Target character index</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToTMPCharPositionZ<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TMP_Text text, int charIndex)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);

            var animator = TextMeshProMotionAnimator.Get(text);
            animator.EnsureCapacity(charIndex + 1);
            var handle = builder.BindWithState(animator, (x, target) =>
            {
                animator.charInfoArray[charIndex].position.z = x;
            });
            animator.motionHandleList.Add(handle);

            return handle;
        }

        /// <summary>
        /// Create motion data and bind it to the character rotation.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="charIndex">Target character index</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToTMPCharRotation<TOptions, TAdapter>(this DamperBuilder<Quaternion, TOptions, TAdapter> builder, TMP_Text text, int charIndex)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Quaternion, TOptions>
        {
            Error.IsNull(text);

            var animator = TextMeshProMotionAnimator.Get(text);
            animator.EnsureCapacity(charIndex + 1);
            var handle = builder.BindWithState(animator, (x, target) =>
            {
                animator.charInfoArray[charIndex].rotation = x;
            });
            animator.motionHandleList.Add(handle);

            return handle;
        }

        /// <summary>
        /// Create motion data and bind it to the character rotation (using euler angles).
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="charIndex">Target character index</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToTMPCharEulerAngles<TOptions, TAdapter>(this DamperBuilder<Vector3, TOptions, TAdapter> builder, TMP_Text text, int charIndex)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector3, TOptions>
        {
            Error.IsNull(text);

            var animator = TextMeshProMotionAnimator.Get(text);
            animator.EnsureCapacity(charIndex + 1);
            var handle = builder.BindWithState(animator, (x, target) =>
            {
                animator.charInfoArray[charIndex].rotation = Quaternion.Euler(x);
            });
            animator.motionHandleList.Add(handle);

            return handle;
        }

        /// <summary>
        /// Create motion data and bind it to the character rotation (using euler angles).
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="charIndex">Target character index</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToTMPCharEulerAnglesX<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TMP_Text text, int charIndex)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);

            var animator = TextMeshProMotionAnimator.Get(text);
            animator.EnsureCapacity(charIndex + 1);
            var handle = builder.BindWithState(animator, (x, target) =>
            {
                var eulerAngles = animator.charInfoArray[charIndex].rotation.eulerAngles;
                eulerAngles.x = x;
                animator.charInfoArray[charIndex].rotation = Quaternion.Euler(eulerAngles);
            });
            animator.motionHandleList.Add(handle);

            return handle;
        }

        /// <summary>
        /// Create motion data and bind it to the character rotation (using euler angles).
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="charIndex">Target character index</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToTMPCharEulerAnglesY<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TMP_Text text, int charIndex)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);

            var animator = TextMeshProMotionAnimator.Get(text);
            animator.EnsureCapacity(charIndex + 1);
            var handle = builder.BindWithState(animator, (x, target) =>
            {
                var eulerAngles = animator.charInfoArray[charIndex].rotation.eulerAngles;
                eulerAngles.y = x;
                animator.charInfoArray[charIndex].rotation = Quaternion.Euler(eulerAngles);
            });
            animator.motionHandleList.Add(handle);

            return handle;
        }

        /// <summary>
        /// Create motion data and bind it to the character rotation (using euler angles).
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="charIndex">Target character index</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToTMPCharEulerAnglesZ<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TMP_Text text, int charIndex)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);

            var animator = TextMeshProMotionAnimator.Get(text);
            animator.EnsureCapacity(charIndex + 1);
            var handle = builder.BindWithState(animator, (x, target) =>
            {
                var eulerAngles = animator.charInfoArray[charIndex].rotation.eulerAngles;
                eulerAngles.z = x;
                animator.charInfoArray[charIndex].rotation = Quaternion.Euler(eulerAngles);
            });
            animator.motionHandleList.Add(handle);

            return handle;
        }

        /// <summary>
        /// Create motion data and bind it to the character scale.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="charIndex">Target character index</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToTMPCharScale<TOptions, TAdapter>(this DamperBuilder<Vector3, TOptions, TAdapter> builder, TMP_Text text, int charIndex)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<Vector3, TOptions>
        {
            Error.IsNull(text);

            var animator = TextMeshProMotionAnimator.Get(text);
            animator.EnsureCapacity(charIndex + 1);
            var handle = builder.BindWithState(animator, (x, target) =>
            {
                animator.charInfoArray[charIndex].scale = x;
            });
            animator.motionHandleList.Add(handle);

            return handle;
        }

        /// <summary>
        /// Create motion data and bind it to the character scale.x.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="charIndex">Target character index</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToTMPCharScaleX<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TMP_Text text, int charIndex)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);

            var animator = TextMeshProMotionAnimator.Get(text);
            animator.EnsureCapacity(charIndex + 1);
            var handle = builder.BindWithState(animator, (x, target) =>
            {
                animator.charInfoArray[charIndex].scale.x = x;
            });
            animator.motionHandleList.Add(handle);

            return handle;
        }

        /// <summary>
        /// Create motion data and bind it to the character scale.y.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="charIndex">Target character index</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToTMPCharScaleY<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TMP_Text text, int charIndex)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);

            var animator = TextMeshProMotionAnimator.Get(text);
            animator.EnsureCapacity(charIndex + 1);
            var handle = builder.BindWithState(animator, (x, target) =>
            {
                animator.charInfoArray[charIndex].scale.y = x;
            });
            animator.motionHandleList.Add(handle);

            return handle;
        }

        /// <summary>
        /// Create motion data and bind it to the character scale.z.
        /// </summary>
        /// <typeparam name="TOptions">The type of special parameters given to the motion data</typeparam>
        /// <typeparam name="TAdapter">The type of adapter that support value animation</typeparam>
        /// <param name="builder">This builder</param>
        /// <param name="text">Target TMP_Text</param>
        /// <param name="charIndex">Target character index</param>
        /// <returns>Handle of the created motion data.</returns>
        public static DamperHandle BindToTMPCharScaleZ<TOptions, TAdapter>(this DamperBuilder<float, TOptions, TAdapter> builder, TMP_Text text, int charIndex)
            where TOptions : unmanaged, IDamperOptions
            where TAdapter : unmanaged, IDamperAdapter<float, TOptions>
        {
            Error.IsNull(text);

            var animator = TextMeshProMotionAnimator.Get(text);
            animator.EnsureCapacity(charIndex + 1);
            var handle = builder.BindWithState(animator, (x, target) =>
            {
                animator.charInfoArray[charIndex].scale.z = x;
            });
            animator.motionHandleList.Add(handle);

            return handle;
        }
    }
}
#endif
