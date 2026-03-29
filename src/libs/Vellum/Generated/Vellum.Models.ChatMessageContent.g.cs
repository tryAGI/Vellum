#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatMessageContent : global::System.IEquatable<ChatMessageContent>
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
        /// A list of chat message content items.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ArrayChatMessageContent? ArrayChatMessageContent { get; init; }
#else
        public global::Vellum.ArrayChatMessageContent? ArrayChatMessageContent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArrayChatMessageContent))]
#endif
        public bool IsArrayChatMessageContent => ArrayChatMessageContent != null;

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
        public static implicit operator ChatMessageContent(global::Vellum.StringChatMessageContent value) => new ChatMessageContent((global::Vellum.StringChatMessageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.StringChatMessageContent?(ChatMessageContent @this) => @this.StringChatMessageContent;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageContent(global::Vellum.StringChatMessageContent? value)
        {
            StringChatMessageContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageContent(global::Vellum.FunctionCallChatMessageContent value) => new ChatMessageContent((global::Vellum.FunctionCallChatMessageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.FunctionCallChatMessageContent?(ChatMessageContent @this) => @this.FunctionCallChatMessageContent;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageContent(global::Vellum.FunctionCallChatMessageContent? value)
        {
            FunctionCallChatMessageContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageContent(global::Vellum.ArrayChatMessageContent value) => new ChatMessageContent((global::Vellum.ArrayChatMessageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ArrayChatMessageContent?(ChatMessageContent @this) => @this.ArrayChatMessageContent;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageContent(global::Vellum.ArrayChatMessageContent? value)
        {
            ArrayChatMessageContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageContent(global::Vellum.AudioChatMessageContent value) => new ChatMessageContent((global::Vellum.AudioChatMessageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.AudioChatMessageContent?(ChatMessageContent @this) => @this.AudioChatMessageContent;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageContent(global::Vellum.AudioChatMessageContent? value)
        {
            AudioChatMessageContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageContent(global::Vellum.VideoChatMessageContent value) => new ChatMessageContent((global::Vellum.VideoChatMessageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.VideoChatMessageContent?(ChatMessageContent @this) => @this.VideoChatMessageContent;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageContent(global::Vellum.VideoChatMessageContent? value)
        {
            VideoChatMessageContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageContent(global::Vellum.ImageChatMessageContent value) => new ChatMessageContent((global::Vellum.ImageChatMessageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ImageChatMessageContent?(ChatMessageContent @this) => @this.ImageChatMessageContent;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageContent(global::Vellum.ImageChatMessageContent? value)
        {
            ImageChatMessageContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageContent(global::Vellum.DocumentChatMessageContent value) => new ChatMessageContent((global::Vellum.DocumentChatMessageContent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.DocumentChatMessageContent?(ChatMessageContent @this) => @this.DocumentChatMessageContent;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageContent(global::Vellum.DocumentChatMessageContent? value)
        {
            DocumentChatMessageContent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageContent(
            global::Vellum.StringChatMessageContent? stringChatMessageContent,
            global::Vellum.FunctionCallChatMessageContent? functionCallChatMessageContent,
            global::Vellum.ArrayChatMessageContent? arrayChatMessageContent,
            global::Vellum.AudioChatMessageContent? audioChatMessageContent,
            global::Vellum.VideoChatMessageContent? videoChatMessageContent,
            global::Vellum.ImageChatMessageContent? imageChatMessageContent,
            global::Vellum.DocumentChatMessageContent? documentChatMessageContent
            )
        {
            StringChatMessageContent = stringChatMessageContent;
            FunctionCallChatMessageContent = functionCallChatMessageContent;
            ArrayChatMessageContent = arrayChatMessageContent;
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
            ArrayChatMessageContent as object ??
            FunctionCallChatMessageContent as object ??
            StringChatMessageContent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StringChatMessageContent?.ToString() ??
            FunctionCallChatMessageContent?.ToString() ??
            ArrayChatMessageContent?.ToString() ??
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
            return IsStringChatMessageContent && !IsFunctionCallChatMessageContent && !IsArrayChatMessageContent && !IsAudioChatMessageContent && !IsVideoChatMessageContent && !IsImageChatMessageContent && !IsDocumentChatMessageContent || !IsStringChatMessageContent && IsFunctionCallChatMessageContent && !IsArrayChatMessageContent && !IsAudioChatMessageContent && !IsVideoChatMessageContent && !IsImageChatMessageContent && !IsDocumentChatMessageContent || !IsStringChatMessageContent && !IsFunctionCallChatMessageContent && IsArrayChatMessageContent && !IsAudioChatMessageContent && !IsVideoChatMessageContent && !IsImageChatMessageContent && !IsDocumentChatMessageContent || !IsStringChatMessageContent && !IsFunctionCallChatMessageContent && !IsArrayChatMessageContent && IsAudioChatMessageContent && !IsVideoChatMessageContent && !IsImageChatMessageContent && !IsDocumentChatMessageContent || !IsStringChatMessageContent && !IsFunctionCallChatMessageContent && !IsArrayChatMessageContent && !IsAudioChatMessageContent && IsVideoChatMessageContent && !IsImageChatMessageContent && !IsDocumentChatMessageContent || !IsStringChatMessageContent && !IsFunctionCallChatMessageContent && !IsArrayChatMessageContent && !IsAudioChatMessageContent && !IsVideoChatMessageContent && IsImageChatMessageContent && !IsDocumentChatMessageContent || !IsStringChatMessageContent && !IsFunctionCallChatMessageContent && !IsArrayChatMessageContent && !IsAudioChatMessageContent && !IsVideoChatMessageContent && !IsImageChatMessageContent && IsDocumentChatMessageContent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.StringChatMessageContent?, TResult>? stringChatMessageContent = null,
            global::System.Func<global::Vellum.FunctionCallChatMessageContent?, TResult>? functionCallChatMessageContent = null,
            global::System.Func<global::Vellum.ArrayChatMessageContent?, TResult>? arrayChatMessageContent = null,
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
            else if (IsArrayChatMessageContent && arrayChatMessageContent != null)
            {
                return arrayChatMessageContent(ArrayChatMessageContent!);
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
            global::System.Action<global::Vellum.ArrayChatMessageContent?>? arrayChatMessageContent = null,
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
            else if (IsArrayChatMessageContent)
            {
                arrayChatMessageContent?.Invoke(ArrayChatMessageContent!);
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
                ArrayChatMessageContent,
                typeof(global::Vellum.ArrayChatMessageContent),
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
        public bool Equals(ChatMessageContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.StringChatMessageContent?>.Default.Equals(StringChatMessageContent, other.StringChatMessageContent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.FunctionCallChatMessageContent?>.Default.Equals(FunctionCallChatMessageContent, other.FunctionCallChatMessageContent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ArrayChatMessageContent?>.Default.Equals(ArrayChatMessageContent, other.ArrayChatMessageContent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.AudioChatMessageContent?>.Default.Equals(AudioChatMessageContent, other.AudioChatMessageContent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.VideoChatMessageContent?>.Default.Equals(VideoChatMessageContent, other.VideoChatMessageContent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ImageChatMessageContent?>.Default.Equals(ImageChatMessageContent, other.ImageChatMessageContent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.DocumentChatMessageContent?>.Default.Equals(DocumentChatMessageContent, other.DocumentChatMessageContent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatMessageContent obj1, ChatMessageContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatMessageContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatMessageContent obj1, ChatMessageContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatMessageContent o && Equals(o);
        }
    }
}
