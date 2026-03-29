#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PromptDeploymentInputRequest : global::System.IEquatable<PromptDeploymentInputRequest>
    {
        /// <summary>
        /// A user input representing a string value
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.StringInputRequest? StringInputRequest { get; init; }
#else
        public global::Vellum.StringInputRequest? StringInputRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StringInputRequest))]
#endif
        public bool IsStringInputRequest => StringInputRequest != null;

        /// <summary>
        /// A user input representing a JSON object
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.JSONInputRequest? JSONInputRequest { get; init; }
#else
        public global::Vellum.JSONInputRequest? JSONInputRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JSONInputRequest))]
#endif
        public bool IsJSONInputRequest => JSONInputRequest != null;

        /// <summary>
        /// A user input representing a list of chat messages
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ChatHistoryInputRequest? ChatHistoryInputRequest { get; init; }
#else
        public global::Vellum.ChatHistoryInputRequest? ChatHistoryInputRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatHistoryInputRequest))]
#endif
        public bool IsChatHistoryInputRequest => ChatHistoryInputRequest != null;

        /// <summary>
        /// A user input representing a Vellum Audio value
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.AudioInputRequest? AudioInputRequest { get; init; }
#else
        public global::Vellum.AudioInputRequest? AudioInputRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioInputRequest))]
#endif
        public bool IsAudioInputRequest => AudioInputRequest != null;

        /// <summary>
        /// A user input representing a Vellum Video value
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.VideoInputRequest? VideoInputRequest { get; init; }
#else
        public global::Vellum.VideoInputRequest? VideoInputRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoInputRequest))]
#endif
        public bool IsVideoInputRequest => VideoInputRequest != null;

        /// <summary>
        /// A user input representing a Vellum Image value
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ImageInputRequest? ImageInputRequest { get; init; }
#else
        public global::Vellum.ImageInputRequest? ImageInputRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageInputRequest))]
#endif
        public bool IsImageInputRequest => ImageInputRequest != null;

        /// <summary>
        /// A user input representing a Vellum Document value
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.DocumentInputRequest? DocumentInputRequest { get; init; }
#else
        public global::Vellum.DocumentInputRequest? DocumentInputRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DocumentInputRequest))]
#endif
        public bool IsDocumentInputRequest => DocumentInputRequest != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptDeploymentInputRequest(global::Vellum.StringInputRequest value) => new PromptDeploymentInputRequest((global::Vellum.StringInputRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.StringInputRequest?(PromptDeploymentInputRequest @this) => @this.StringInputRequest;

        /// <summary>
        /// 
        /// </summary>
        public PromptDeploymentInputRequest(global::Vellum.StringInputRequest? value)
        {
            StringInputRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptDeploymentInputRequest(global::Vellum.JSONInputRequest value) => new PromptDeploymentInputRequest((global::Vellum.JSONInputRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.JSONInputRequest?(PromptDeploymentInputRequest @this) => @this.JSONInputRequest;

        /// <summary>
        /// 
        /// </summary>
        public PromptDeploymentInputRequest(global::Vellum.JSONInputRequest? value)
        {
            JSONInputRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptDeploymentInputRequest(global::Vellum.ChatHistoryInputRequest value) => new PromptDeploymentInputRequest((global::Vellum.ChatHistoryInputRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ChatHistoryInputRequest?(PromptDeploymentInputRequest @this) => @this.ChatHistoryInputRequest;

        /// <summary>
        /// 
        /// </summary>
        public PromptDeploymentInputRequest(global::Vellum.ChatHistoryInputRequest? value)
        {
            ChatHistoryInputRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptDeploymentInputRequest(global::Vellum.AudioInputRequest value) => new PromptDeploymentInputRequest((global::Vellum.AudioInputRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.AudioInputRequest?(PromptDeploymentInputRequest @this) => @this.AudioInputRequest;

        /// <summary>
        /// 
        /// </summary>
        public PromptDeploymentInputRequest(global::Vellum.AudioInputRequest? value)
        {
            AudioInputRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptDeploymentInputRequest(global::Vellum.VideoInputRequest value) => new PromptDeploymentInputRequest((global::Vellum.VideoInputRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.VideoInputRequest?(PromptDeploymentInputRequest @this) => @this.VideoInputRequest;

        /// <summary>
        /// 
        /// </summary>
        public PromptDeploymentInputRequest(global::Vellum.VideoInputRequest? value)
        {
            VideoInputRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptDeploymentInputRequest(global::Vellum.ImageInputRequest value) => new PromptDeploymentInputRequest((global::Vellum.ImageInputRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ImageInputRequest?(PromptDeploymentInputRequest @this) => @this.ImageInputRequest;

        /// <summary>
        /// 
        /// </summary>
        public PromptDeploymentInputRequest(global::Vellum.ImageInputRequest? value)
        {
            ImageInputRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptDeploymentInputRequest(global::Vellum.DocumentInputRequest value) => new PromptDeploymentInputRequest((global::Vellum.DocumentInputRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.DocumentInputRequest?(PromptDeploymentInputRequest @this) => @this.DocumentInputRequest;

        /// <summary>
        /// 
        /// </summary>
        public PromptDeploymentInputRequest(global::Vellum.DocumentInputRequest? value)
        {
            DocumentInputRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PromptDeploymentInputRequest(
            global::Vellum.StringInputRequest? stringInputRequest,
            global::Vellum.JSONInputRequest? jSONInputRequest,
            global::Vellum.ChatHistoryInputRequest? chatHistoryInputRequest,
            global::Vellum.AudioInputRequest? audioInputRequest,
            global::Vellum.VideoInputRequest? videoInputRequest,
            global::Vellum.ImageInputRequest? imageInputRequest,
            global::Vellum.DocumentInputRequest? documentInputRequest
            )
        {
            StringInputRequest = stringInputRequest;
            JSONInputRequest = jSONInputRequest;
            ChatHistoryInputRequest = chatHistoryInputRequest;
            AudioInputRequest = audioInputRequest;
            VideoInputRequest = videoInputRequest;
            ImageInputRequest = imageInputRequest;
            DocumentInputRequest = documentInputRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DocumentInputRequest as object ??
            ImageInputRequest as object ??
            VideoInputRequest as object ??
            AudioInputRequest as object ??
            ChatHistoryInputRequest as object ??
            JSONInputRequest as object ??
            StringInputRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StringInputRequest?.ToString() ??
            JSONInputRequest?.ToString() ??
            ChatHistoryInputRequest?.ToString() ??
            AudioInputRequest?.ToString() ??
            VideoInputRequest?.ToString() ??
            ImageInputRequest?.ToString() ??
            DocumentInputRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStringInputRequest && !IsJSONInputRequest && !IsChatHistoryInputRequest && !IsAudioInputRequest && !IsVideoInputRequest && !IsImageInputRequest && !IsDocumentInputRequest || !IsStringInputRequest && IsJSONInputRequest && !IsChatHistoryInputRequest && !IsAudioInputRequest && !IsVideoInputRequest && !IsImageInputRequest && !IsDocumentInputRequest || !IsStringInputRequest && !IsJSONInputRequest && IsChatHistoryInputRequest && !IsAudioInputRequest && !IsVideoInputRequest && !IsImageInputRequest && !IsDocumentInputRequest || !IsStringInputRequest && !IsJSONInputRequest && !IsChatHistoryInputRequest && IsAudioInputRequest && !IsVideoInputRequest && !IsImageInputRequest && !IsDocumentInputRequest || !IsStringInputRequest && !IsJSONInputRequest && !IsChatHistoryInputRequest && !IsAudioInputRequest && IsVideoInputRequest && !IsImageInputRequest && !IsDocumentInputRequest || !IsStringInputRequest && !IsJSONInputRequest && !IsChatHistoryInputRequest && !IsAudioInputRequest && !IsVideoInputRequest && IsImageInputRequest && !IsDocumentInputRequest || !IsStringInputRequest && !IsJSONInputRequest && !IsChatHistoryInputRequest && !IsAudioInputRequest && !IsVideoInputRequest && !IsImageInputRequest && IsDocumentInputRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.StringInputRequest?, TResult>? stringInputRequest = null,
            global::System.Func<global::Vellum.JSONInputRequest?, TResult>? jSONInputRequest = null,
            global::System.Func<global::Vellum.ChatHistoryInputRequest?, TResult>? chatHistoryInputRequest = null,
            global::System.Func<global::Vellum.AudioInputRequest?, TResult>? audioInputRequest = null,
            global::System.Func<global::Vellum.VideoInputRequest?, TResult>? videoInputRequest = null,
            global::System.Func<global::Vellum.ImageInputRequest?, TResult>? imageInputRequest = null,
            global::System.Func<global::Vellum.DocumentInputRequest?, TResult>? documentInputRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringInputRequest && stringInputRequest != null)
            {
                return stringInputRequest(StringInputRequest!);
            }
            else if (IsJSONInputRequest && jSONInputRequest != null)
            {
                return jSONInputRequest(JSONInputRequest!);
            }
            else if (IsChatHistoryInputRequest && chatHistoryInputRequest != null)
            {
                return chatHistoryInputRequest(ChatHistoryInputRequest!);
            }
            else if (IsAudioInputRequest && audioInputRequest != null)
            {
                return audioInputRequest(AudioInputRequest!);
            }
            else if (IsVideoInputRequest && videoInputRequest != null)
            {
                return videoInputRequest(VideoInputRequest!);
            }
            else if (IsImageInputRequest && imageInputRequest != null)
            {
                return imageInputRequest(ImageInputRequest!);
            }
            else if (IsDocumentInputRequest && documentInputRequest != null)
            {
                return documentInputRequest(DocumentInputRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.StringInputRequest?>? stringInputRequest = null,
            global::System.Action<global::Vellum.JSONInputRequest?>? jSONInputRequest = null,
            global::System.Action<global::Vellum.ChatHistoryInputRequest?>? chatHistoryInputRequest = null,
            global::System.Action<global::Vellum.AudioInputRequest?>? audioInputRequest = null,
            global::System.Action<global::Vellum.VideoInputRequest?>? videoInputRequest = null,
            global::System.Action<global::Vellum.ImageInputRequest?>? imageInputRequest = null,
            global::System.Action<global::Vellum.DocumentInputRequest?>? documentInputRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringInputRequest)
            {
                stringInputRequest?.Invoke(StringInputRequest!);
            }
            else if (IsJSONInputRequest)
            {
                jSONInputRequest?.Invoke(JSONInputRequest!);
            }
            else if (IsChatHistoryInputRequest)
            {
                chatHistoryInputRequest?.Invoke(ChatHistoryInputRequest!);
            }
            else if (IsAudioInputRequest)
            {
                audioInputRequest?.Invoke(AudioInputRequest!);
            }
            else if (IsVideoInputRequest)
            {
                videoInputRequest?.Invoke(VideoInputRequest!);
            }
            else if (IsImageInputRequest)
            {
                imageInputRequest?.Invoke(ImageInputRequest!);
            }
            else if (IsDocumentInputRequest)
            {
                documentInputRequest?.Invoke(DocumentInputRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StringInputRequest,
                typeof(global::Vellum.StringInputRequest),
                JSONInputRequest,
                typeof(global::Vellum.JSONInputRequest),
                ChatHistoryInputRequest,
                typeof(global::Vellum.ChatHistoryInputRequest),
                AudioInputRequest,
                typeof(global::Vellum.AudioInputRequest),
                VideoInputRequest,
                typeof(global::Vellum.VideoInputRequest),
                ImageInputRequest,
                typeof(global::Vellum.ImageInputRequest),
                DocumentInputRequest,
                typeof(global::Vellum.DocumentInputRequest),
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
        public bool Equals(PromptDeploymentInputRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.StringInputRequest?>.Default.Equals(StringInputRequest, other.StringInputRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.JSONInputRequest?>.Default.Equals(JSONInputRequest, other.JSONInputRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ChatHistoryInputRequest?>.Default.Equals(ChatHistoryInputRequest, other.ChatHistoryInputRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.AudioInputRequest?>.Default.Equals(AudioInputRequest, other.AudioInputRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.VideoInputRequest?>.Default.Equals(VideoInputRequest, other.VideoInputRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ImageInputRequest?>.Default.Equals(ImageInputRequest, other.ImageInputRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.DocumentInputRequest?>.Default.Equals(DocumentInputRequest, other.DocumentInputRequest) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PromptDeploymentInputRequest obj1, PromptDeploymentInputRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PromptDeploymentInputRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PromptDeploymentInputRequest obj1, PromptDeploymentInputRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PromptDeploymentInputRequest o && Equals(o);
        }
    }
}
