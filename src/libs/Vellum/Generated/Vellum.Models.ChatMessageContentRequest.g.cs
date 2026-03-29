#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatMessageContentRequest : global::System.IEquatable<ChatMessageContentRequest>
    {
        /// <summary>
        /// A string value that is used in a chat message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.StringChatMessageContentRequest? StringChatMessageContentRequest { get; init; }
#else
        public global::Vellum.StringChatMessageContentRequest? StringChatMessageContentRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StringChatMessageContentRequest))]
#endif
        public bool IsStringChatMessageContentRequest => StringChatMessageContentRequest != null;

        /// <summary>
        /// A function call value that is used in a chat message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.FunctionCallChatMessageContentRequest? FunctionCallChatMessageContentRequest { get; init; }
#else
        public global::Vellum.FunctionCallChatMessageContentRequest? FunctionCallChatMessageContentRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallChatMessageContentRequest))]
#endif
        public bool IsFunctionCallChatMessageContentRequest => FunctionCallChatMessageContentRequest != null;

        /// <summary>
        /// A list of chat message content items.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ArrayChatMessageContentRequest? ArrayChatMessageContentRequest { get; init; }
#else
        public global::Vellum.ArrayChatMessageContentRequest? ArrayChatMessageContentRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArrayChatMessageContentRequest))]
#endif
        public bool IsArrayChatMessageContentRequest => ArrayChatMessageContentRequest != null;

        /// <summary>
        /// An audio value that is used in a chat message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.AudioChatMessageContentRequest? AudioChatMessageContentRequest { get; init; }
#else
        public global::Vellum.AudioChatMessageContentRequest? AudioChatMessageContentRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioChatMessageContentRequest))]
#endif
        public bool IsAudioChatMessageContentRequest => AudioChatMessageContentRequest != null;

        /// <summary>
        /// A video value that is used in a chat message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.VideoChatMessageContentRequest? VideoChatMessageContentRequest { get; init; }
#else
        public global::Vellum.VideoChatMessageContentRequest? VideoChatMessageContentRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoChatMessageContentRequest))]
#endif
        public bool IsVideoChatMessageContentRequest => VideoChatMessageContentRequest != null;

        /// <summary>
        /// An image value that is used in a chat message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ImageChatMessageContentRequest? ImageChatMessageContentRequest { get; init; }
#else
        public global::Vellum.ImageChatMessageContentRequest? ImageChatMessageContentRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageChatMessageContentRequest))]
#endif
        public bool IsImageChatMessageContentRequest => ImageChatMessageContentRequest != null;

        /// <summary>
        /// A document value that is used in a chat message.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.DocumentChatMessageContentRequest? DocumentChatMessageContentRequest { get; init; }
#else
        public global::Vellum.DocumentChatMessageContentRequest? DocumentChatMessageContentRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DocumentChatMessageContentRequest))]
#endif
        public bool IsDocumentChatMessageContentRequest => DocumentChatMessageContentRequest != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageContentRequest(global::Vellum.StringChatMessageContentRequest value) => new ChatMessageContentRequest((global::Vellum.StringChatMessageContentRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.StringChatMessageContentRequest?(ChatMessageContentRequest @this) => @this.StringChatMessageContentRequest;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageContentRequest(global::Vellum.StringChatMessageContentRequest? value)
        {
            StringChatMessageContentRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageContentRequest(global::Vellum.FunctionCallChatMessageContentRequest value) => new ChatMessageContentRequest((global::Vellum.FunctionCallChatMessageContentRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.FunctionCallChatMessageContentRequest?(ChatMessageContentRequest @this) => @this.FunctionCallChatMessageContentRequest;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageContentRequest(global::Vellum.FunctionCallChatMessageContentRequest? value)
        {
            FunctionCallChatMessageContentRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageContentRequest(global::Vellum.ArrayChatMessageContentRequest value) => new ChatMessageContentRequest((global::Vellum.ArrayChatMessageContentRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ArrayChatMessageContentRequest?(ChatMessageContentRequest @this) => @this.ArrayChatMessageContentRequest;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageContentRequest(global::Vellum.ArrayChatMessageContentRequest? value)
        {
            ArrayChatMessageContentRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageContentRequest(global::Vellum.AudioChatMessageContentRequest value) => new ChatMessageContentRequest((global::Vellum.AudioChatMessageContentRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.AudioChatMessageContentRequest?(ChatMessageContentRequest @this) => @this.AudioChatMessageContentRequest;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageContentRequest(global::Vellum.AudioChatMessageContentRequest? value)
        {
            AudioChatMessageContentRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageContentRequest(global::Vellum.VideoChatMessageContentRequest value) => new ChatMessageContentRequest((global::Vellum.VideoChatMessageContentRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.VideoChatMessageContentRequest?(ChatMessageContentRequest @this) => @this.VideoChatMessageContentRequest;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageContentRequest(global::Vellum.VideoChatMessageContentRequest? value)
        {
            VideoChatMessageContentRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageContentRequest(global::Vellum.ImageChatMessageContentRequest value) => new ChatMessageContentRequest((global::Vellum.ImageChatMessageContentRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ImageChatMessageContentRequest?(ChatMessageContentRequest @this) => @this.ImageChatMessageContentRequest;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageContentRequest(global::Vellum.ImageChatMessageContentRequest? value)
        {
            ImageChatMessageContentRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatMessageContentRequest(global::Vellum.DocumentChatMessageContentRequest value) => new ChatMessageContentRequest((global::Vellum.DocumentChatMessageContentRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.DocumentChatMessageContentRequest?(ChatMessageContentRequest @this) => @this.DocumentChatMessageContentRequest;

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageContentRequest(global::Vellum.DocumentChatMessageContentRequest? value)
        {
            DocumentChatMessageContentRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatMessageContentRequest(
            global::Vellum.StringChatMessageContentRequest? stringChatMessageContentRequest,
            global::Vellum.FunctionCallChatMessageContentRequest? functionCallChatMessageContentRequest,
            global::Vellum.ArrayChatMessageContentRequest? arrayChatMessageContentRequest,
            global::Vellum.AudioChatMessageContentRequest? audioChatMessageContentRequest,
            global::Vellum.VideoChatMessageContentRequest? videoChatMessageContentRequest,
            global::Vellum.ImageChatMessageContentRequest? imageChatMessageContentRequest,
            global::Vellum.DocumentChatMessageContentRequest? documentChatMessageContentRequest
            )
        {
            StringChatMessageContentRequest = stringChatMessageContentRequest;
            FunctionCallChatMessageContentRequest = functionCallChatMessageContentRequest;
            ArrayChatMessageContentRequest = arrayChatMessageContentRequest;
            AudioChatMessageContentRequest = audioChatMessageContentRequest;
            VideoChatMessageContentRequest = videoChatMessageContentRequest;
            ImageChatMessageContentRequest = imageChatMessageContentRequest;
            DocumentChatMessageContentRequest = documentChatMessageContentRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DocumentChatMessageContentRequest as object ??
            ImageChatMessageContentRequest as object ??
            VideoChatMessageContentRequest as object ??
            AudioChatMessageContentRequest as object ??
            ArrayChatMessageContentRequest as object ??
            FunctionCallChatMessageContentRequest as object ??
            StringChatMessageContentRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StringChatMessageContentRequest?.ToString() ??
            FunctionCallChatMessageContentRequest?.ToString() ??
            ArrayChatMessageContentRequest?.ToString() ??
            AudioChatMessageContentRequest?.ToString() ??
            VideoChatMessageContentRequest?.ToString() ??
            ImageChatMessageContentRequest?.ToString() ??
            DocumentChatMessageContentRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStringChatMessageContentRequest && !IsFunctionCallChatMessageContentRequest && !IsArrayChatMessageContentRequest && !IsAudioChatMessageContentRequest && !IsVideoChatMessageContentRequest && !IsImageChatMessageContentRequest && !IsDocumentChatMessageContentRequest || !IsStringChatMessageContentRequest && IsFunctionCallChatMessageContentRequest && !IsArrayChatMessageContentRequest && !IsAudioChatMessageContentRequest && !IsVideoChatMessageContentRequest && !IsImageChatMessageContentRequest && !IsDocumentChatMessageContentRequest || !IsStringChatMessageContentRequest && !IsFunctionCallChatMessageContentRequest && IsArrayChatMessageContentRequest && !IsAudioChatMessageContentRequest && !IsVideoChatMessageContentRequest && !IsImageChatMessageContentRequest && !IsDocumentChatMessageContentRequest || !IsStringChatMessageContentRequest && !IsFunctionCallChatMessageContentRequest && !IsArrayChatMessageContentRequest && IsAudioChatMessageContentRequest && !IsVideoChatMessageContentRequest && !IsImageChatMessageContentRequest && !IsDocumentChatMessageContentRequest || !IsStringChatMessageContentRequest && !IsFunctionCallChatMessageContentRequest && !IsArrayChatMessageContentRequest && !IsAudioChatMessageContentRequest && IsVideoChatMessageContentRequest && !IsImageChatMessageContentRequest && !IsDocumentChatMessageContentRequest || !IsStringChatMessageContentRequest && !IsFunctionCallChatMessageContentRequest && !IsArrayChatMessageContentRequest && !IsAudioChatMessageContentRequest && !IsVideoChatMessageContentRequest && IsImageChatMessageContentRequest && !IsDocumentChatMessageContentRequest || !IsStringChatMessageContentRequest && !IsFunctionCallChatMessageContentRequest && !IsArrayChatMessageContentRequest && !IsAudioChatMessageContentRequest && !IsVideoChatMessageContentRequest && !IsImageChatMessageContentRequest && IsDocumentChatMessageContentRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.StringChatMessageContentRequest?, TResult>? stringChatMessageContentRequest = null,
            global::System.Func<global::Vellum.FunctionCallChatMessageContentRequest?, TResult>? functionCallChatMessageContentRequest = null,
            global::System.Func<global::Vellum.ArrayChatMessageContentRequest?, TResult>? arrayChatMessageContentRequest = null,
            global::System.Func<global::Vellum.AudioChatMessageContentRequest?, TResult>? audioChatMessageContentRequest = null,
            global::System.Func<global::Vellum.VideoChatMessageContentRequest?, TResult>? videoChatMessageContentRequest = null,
            global::System.Func<global::Vellum.ImageChatMessageContentRequest?, TResult>? imageChatMessageContentRequest = null,
            global::System.Func<global::Vellum.DocumentChatMessageContentRequest?, TResult>? documentChatMessageContentRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringChatMessageContentRequest && stringChatMessageContentRequest != null)
            {
                return stringChatMessageContentRequest(StringChatMessageContentRequest!);
            }
            else if (IsFunctionCallChatMessageContentRequest && functionCallChatMessageContentRequest != null)
            {
                return functionCallChatMessageContentRequest(FunctionCallChatMessageContentRequest!);
            }
            else if (IsArrayChatMessageContentRequest && arrayChatMessageContentRequest != null)
            {
                return arrayChatMessageContentRequest(ArrayChatMessageContentRequest!);
            }
            else if (IsAudioChatMessageContentRequest && audioChatMessageContentRequest != null)
            {
                return audioChatMessageContentRequest(AudioChatMessageContentRequest!);
            }
            else if (IsVideoChatMessageContentRequest && videoChatMessageContentRequest != null)
            {
                return videoChatMessageContentRequest(VideoChatMessageContentRequest!);
            }
            else if (IsImageChatMessageContentRequest && imageChatMessageContentRequest != null)
            {
                return imageChatMessageContentRequest(ImageChatMessageContentRequest!);
            }
            else if (IsDocumentChatMessageContentRequest && documentChatMessageContentRequest != null)
            {
                return documentChatMessageContentRequest(DocumentChatMessageContentRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.StringChatMessageContentRequest?>? stringChatMessageContentRequest = null,
            global::System.Action<global::Vellum.FunctionCallChatMessageContentRequest?>? functionCallChatMessageContentRequest = null,
            global::System.Action<global::Vellum.ArrayChatMessageContentRequest?>? arrayChatMessageContentRequest = null,
            global::System.Action<global::Vellum.AudioChatMessageContentRequest?>? audioChatMessageContentRequest = null,
            global::System.Action<global::Vellum.VideoChatMessageContentRequest?>? videoChatMessageContentRequest = null,
            global::System.Action<global::Vellum.ImageChatMessageContentRequest?>? imageChatMessageContentRequest = null,
            global::System.Action<global::Vellum.DocumentChatMessageContentRequest?>? documentChatMessageContentRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringChatMessageContentRequest)
            {
                stringChatMessageContentRequest?.Invoke(StringChatMessageContentRequest!);
            }
            else if (IsFunctionCallChatMessageContentRequest)
            {
                functionCallChatMessageContentRequest?.Invoke(FunctionCallChatMessageContentRequest!);
            }
            else if (IsArrayChatMessageContentRequest)
            {
                arrayChatMessageContentRequest?.Invoke(ArrayChatMessageContentRequest!);
            }
            else if (IsAudioChatMessageContentRequest)
            {
                audioChatMessageContentRequest?.Invoke(AudioChatMessageContentRequest!);
            }
            else if (IsVideoChatMessageContentRequest)
            {
                videoChatMessageContentRequest?.Invoke(VideoChatMessageContentRequest!);
            }
            else if (IsImageChatMessageContentRequest)
            {
                imageChatMessageContentRequest?.Invoke(ImageChatMessageContentRequest!);
            }
            else if (IsDocumentChatMessageContentRequest)
            {
                documentChatMessageContentRequest?.Invoke(DocumentChatMessageContentRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StringChatMessageContentRequest,
                typeof(global::Vellum.StringChatMessageContentRequest),
                FunctionCallChatMessageContentRequest,
                typeof(global::Vellum.FunctionCallChatMessageContentRequest),
                ArrayChatMessageContentRequest,
                typeof(global::Vellum.ArrayChatMessageContentRequest),
                AudioChatMessageContentRequest,
                typeof(global::Vellum.AudioChatMessageContentRequest),
                VideoChatMessageContentRequest,
                typeof(global::Vellum.VideoChatMessageContentRequest),
                ImageChatMessageContentRequest,
                typeof(global::Vellum.ImageChatMessageContentRequest),
                DocumentChatMessageContentRequest,
                typeof(global::Vellum.DocumentChatMessageContentRequest),
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
        public bool Equals(ChatMessageContentRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.StringChatMessageContentRequest?>.Default.Equals(StringChatMessageContentRequest, other.StringChatMessageContentRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.FunctionCallChatMessageContentRequest?>.Default.Equals(FunctionCallChatMessageContentRequest, other.FunctionCallChatMessageContentRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ArrayChatMessageContentRequest?>.Default.Equals(ArrayChatMessageContentRequest, other.ArrayChatMessageContentRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.AudioChatMessageContentRequest?>.Default.Equals(AudioChatMessageContentRequest, other.AudioChatMessageContentRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.VideoChatMessageContentRequest?>.Default.Equals(VideoChatMessageContentRequest, other.VideoChatMessageContentRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ImageChatMessageContentRequest?>.Default.Equals(ImageChatMessageContentRequest, other.ImageChatMessageContentRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.DocumentChatMessageContentRequest?>.Default.Equals(DocumentChatMessageContentRequest, other.DocumentChatMessageContentRequest) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatMessageContentRequest obj1, ChatMessageContentRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatMessageContentRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatMessageContentRequest obj1, ChatMessageContentRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatMessageContentRequest o && Equals(o);
        }
    }
}
