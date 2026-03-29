#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ArrayChatMessageContentItem : global::System.IEquatable<ArrayChatMessageContentItem>
    {
        /// <summary>
        /// A string value that is used in a chat message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.StringChatMessageContent? StringChatMessageContent { get; init; }
#else
        public global::Vellum.StringChatMessageContent? StringChatMessageContent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StringChatMessageContent))]
#endif
        public bool IsStringChatMessageContent => StringChatMessageContent != null;

        /// <summary>
        /// A function call value that is used in a chat message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.FunctionCallChatMessageContent? FunctionCallChatMessageContent { get; init; }
#else
        public global::Vellum.FunctionCallChatMessageContent? FunctionCallChatMessageContent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallChatMessageContent))]
#endif
        public bool IsFunctionCallChatMessageContent => FunctionCallChatMessageContent != null;

        /// <summary>
        /// An audio value that is used in a chat message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.AudioChatMessageContent? AudioChatMessageContent { get; init; }
#else
        public global::Vellum.AudioChatMessageContent? AudioChatMessageContent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioChatMessageContent))]
#endif
        public bool IsAudioChatMessageContent => AudioChatMessageContent != null;

        /// <summary>
        /// A video value that is used in a chat message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.VideoChatMessageContent? VideoChatMessageContent { get; init; }
#else
        public global::Vellum.VideoChatMessageContent? VideoChatMessageContent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoChatMessageContent))]
#endif
        public bool IsVideoChatMessageContent => VideoChatMessageContent != null;

        /// <summary>
        /// An image value that is used in a chat message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ImageChatMessageContent? ImageChatMessageContent { get; init; }
#else
        public global::Vellum.ImageChatMessageContent? ImageChatMessageContent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageChatMessageContent))]
#endif
        public bool IsImageChatMessageContent => ImageChatMessageContent != null;

        /// <summary>
        /// A document value that is used in a chat message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.DocumentChatMessageContent? DocumentChatMessageContent { get; init; }
#else
        public global::Vellum.DocumentChatMessageContent? DocumentChatMessageContent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DocumentChatMessageContent))]
#endif
        public bool IsDocumentChatMessageContent => DocumentChatMessageContent != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArrayChatMessageContentItem(global::Vellum.StringChatMessageContent value) => new ArrayChatMessageContentItem((global::Vellum.StringChatMessageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.StringChatMessageContent?(ArrayChatMessageContentItem @this) => @this.StringChatMessageContent;

        /// <summary>
        /// 
        /// </summary>
        public ArrayChatMessageContentItem(global::Vellum.StringChatMessageContent? value)
        {
            StringChatMessageContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArrayChatMessageContentItem(global::Vellum.FunctionCallChatMessageContent value) => new ArrayChatMessageContentItem((global::Vellum.FunctionCallChatMessageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.FunctionCallChatMessageContent?(ArrayChatMessageContentItem @this) => @this.FunctionCallChatMessageContent;

        /// <summary>
        /// 
        /// </summary>
        public ArrayChatMessageContentItem(global::Vellum.FunctionCallChatMessageContent? value)
        {
            FunctionCallChatMessageContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArrayChatMessageContentItem(global::Vellum.AudioChatMessageContent value) => new ArrayChatMessageContentItem((global::Vellum.AudioChatMessageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.AudioChatMessageContent?(ArrayChatMessageContentItem @this) => @this.AudioChatMessageContent;

        /// <summary>
        /// 
        /// </summary>
        public ArrayChatMessageContentItem(global::Vellum.AudioChatMessageContent? value)
        {
            AudioChatMessageContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArrayChatMessageContentItem(global::Vellum.VideoChatMessageContent value) => new ArrayChatMessageContentItem((global::Vellum.VideoChatMessageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.VideoChatMessageContent?(ArrayChatMessageContentItem @this) => @this.VideoChatMessageContent;

        /// <summary>
        /// 
        /// </summary>
        public ArrayChatMessageContentItem(global::Vellum.VideoChatMessageContent? value)
        {
            VideoChatMessageContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArrayChatMessageContentItem(global::Vellum.ImageChatMessageContent value) => new ArrayChatMessageContentItem((global::Vellum.ImageChatMessageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ImageChatMessageContent?(ArrayChatMessageContentItem @this) => @this.ImageChatMessageContent;

        /// <summary>
        /// 
        /// </summary>
        public ArrayChatMessageContentItem(global::Vellum.ImageChatMessageContent? value)
        {
            ImageChatMessageContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ArrayChatMessageContentItem(global::Vellum.DocumentChatMessageContent value) => new ArrayChatMessageContentItem((global::Vellum.DocumentChatMessageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.DocumentChatMessageContent?(ArrayChatMessageContentItem @this) => @this.DocumentChatMessageContent;

        /// <summary>
        /// 
        /// </summary>
        public ArrayChatMessageContentItem(global::Vellum.DocumentChatMessageContent? value)
        {
            DocumentChatMessageContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ArrayChatMessageContentItem(
            global::Vellum.StringChatMessageContent? stringChatMessageContent,
            global::Vellum.FunctionCallChatMessageContent? functionCallChatMessageContent,
            global::Vellum.AudioChatMessageContent? audioChatMessageContent,
            global::Vellum.VideoChatMessageContent? videoChatMessageContent,
            global::Vellum.ImageChatMessageContent? imageChatMessageContent,
            global::Vellum.DocumentChatMessageContent? documentChatMessageContent
            )
        {
            StringChatMessageContent = stringChatMessageContent;
            FunctionCallChatMessageContent = functionCallChatMessageContent;
            AudioChatMessageContent = audioChatMessageContent;
            VideoChatMessageContent = videoChatMessageContent;
            ImageChatMessageContent = imageChatMessageContent;
            DocumentChatMessageContent = documentChatMessageContent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DocumentChatMessageContent as object ??
            ImageChatMessageContent as object ??
            VideoChatMessageContent as object ??
            AudioChatMessageContent as object ??
            FunctionCallChatMessageContent as object ??
            StringChatMessageContent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StringChatMessageContent?.ToString() ??
            FunctionCallChatMessageContent?.ToString() ??
            AudioChatMessageContent?.ToString() ??
            VideoChatMessageContent?.ToString() ??
            ImageChatMessageContent?.ToString() ??
            DocumentChatMessageContent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStringChatMessageContent && !IsFunctionCallChatMessageContent && !IsAudioChatMessageContent && !IsVideoChatMessageContent && !IsImageChatMessageContent && !IsDocumentChatMessageContent || !IsStringChatMessageContent && IsFunctionCallChatMessageContent && !IsAudioChatMessageContent && !IsVideoChatMessageContent && !IsImageChatMessageContent && !IsDocumentChatMessageContent || !IsStringChatMessageContent && !IsFunctionCallChatMessageContent && IsAudioChatMessageContent && !IsVideoChatMessageContent && !IsImageChatMessageContent && !IsDocumentChatMessageContent || !IsStringChatMessageContent && !IsFunctionCallChatMessageContent && !IsAudioChatMessageContent && IsVideoChatMessageContent && !IsImageChatMessageContent && !IsDocumentChatMessageContent || !IsStringChatMessageContent && !IsFunctionCallChatMessageContent && !IsAudioChatMessageContent && !IsVideoChatMessageContent && IsImageChatMessageContent && !IsDocumentChatMessageContent || !IsStringChatMessageContent && !IsFunctionCallChatMessageContent && !IsAudioChatMessageContent && !IsVideoChatMessageContent && !IsImageChatMessageContent && IsDocumentChatMessageContent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.StringChatMessageContent?, TResult>? stringChatMessageContent = null,
            global::System.Func<global::Vellum.FunctionCallChatMessageContent?, TResult>? functionCallChatMessageContent = null,
            global::System.Func<global::Vellum.AudioChatMessageContent?, TResult>? audioChatMessageContent = null,
            global::System.Func<global::Vellum.VideoChatMessageContent?, TResult>? videoChatMessageContent = null,
            global::System.Func<global::Vellum.ImageChatMessageContent?, TResult>? imageChatMessageContent = null,
            global::System.Func<global::Vellum.DocumentChatMessageContent?, TResult>? documentChatMessageContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringChatMessageContent && stringChatMessageContent != null)
            {
                return stringChatMessageContent(StringChatMessageContent!);
            }
            else if (IsFunctionCallChatMessageContent && functionCallChatMessageContent != null)
            {
                return functionCallChatMessageContent(FunctionCallChatMessageContent!);
            }
            else if (IsAudioChatMessageContent && audioChatMessageContent != null)
            {
                return audioChatMessageContent(AudioChatMessageContent!);
            }
            else if (IsVideoChatMessageContent && videoChatMessageContent != null)
            {
                return videoChatMessageContent(VideoChatMessageContent!);
            }
            else if (IsImageChatMessageContent && imageChatMessageContent != null)
            {
                return imageChatMessageContent(ImageChatMessageContent!);
            }
            else if (IsDocumentChatMessageContent && documentChatMessageContent != null)
            {
                return documentChatMessageContent(DocumentChatMessageContent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.StringChatMessageContent?>? stringChatMessageContent = null,
            global::System.Action<global::Vellum.FunctionCallChatMessageContent?>? functionCallChatMessageContent = null,
            global::System.Action<global::Vellum.AudioChatMessageContent?>? audioChatMessageContent = null,
            global::System.Action<global::Vellum.VideoChatMessageContent?>? videoChatMessageContent = null,
            global::System.Action<global::Vellum.ImageChatMessageContent?>? imageChatMessageContent = null,
            global::System.Action<global::Vellum.DocumentChatMessageContent?>? documentChatMessageContent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringChatMessageContent)
            {
                stringChatMessageContent?.Invoke(StringChatMessageContent!);
            }
            else if (IsFunctionCallChatMessageContent)
            {
                functionCallChatMessageContent?.Invoke(FunctionCallChatMessageContent!);
            }
            else if (IsAudioChatMessageContent)
            {
                audioChatMessageContent?.Invoke(AudioChatMessageContent!);
            }
            else if (IsVideoChatMessageContent)
            {
                videoChatMessageContent?.Invoke(VideoChatMessageContent!);
            }
            else if (IsImageChatMessageContent)
            {
                imageChatMessageContent?.Invoke(ImageChatMessageContent!);
            }
            else if (IsDocumentChatMessageContent)
            {
                documentChatMessageContent?.Invoke(DocumentChatMessageContent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StringChatMessageContent,
                typeof(global::Vellum.StringChatMessageContent),
                FunctionCallChatMessageContent,
                typeof(global::Vellum.FunctionCallChatMessageContent),
                AudioChatMessageContent,
                typeof(global::Vellum.AudioChatMessageContent),
                VideoChatMessageContent,
                typeof(global::Vellum.VideoChatMessageContent),
                ImageChatMessageContent,
                typeof(global::Vellum.ImageChatMessageContent),
                DocumentChatMessageContent,
                typeof(global::Vellum.DocumentChatMessageContent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ArrayChatMessageContentItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.StringChatMessageContent?>.Default.Equals(StringChatMessageContent, other.StringChatMessageContent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.FunctionCallChatMessageContent?>.Default.Equals(FunctionCallChatMessageContent, other.FunctionCallChatMessageContent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.AudioChatMessageContent?>.Default.Equals(AudioChatMessageContent, other.AudioChatMessageContent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.VideoChatMessageContent?>.Default.Equals(VideoChatMessageContent, other.VideoChatMessageContent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ImageChatMessageContent?>.Default.Equals(ImageChatMessageContent, other.ImageChatMessageContent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.DocumentChatMessageContent?>.Default.Equals(DocumentChatMessageContent, other.DocumentChatMessageContent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ArrayChatMessageContentItem obj1, ArrayChatMessageContentItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ArrayChatMessageContentItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ArrayChatMessageContentItem obj1, ArrayChatMessageContentItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ArrayChatMessageContentItem o && Equals(o);
        }
    }
}
