#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VellumValueRequest : global::System.IEquatable<VellumValueRequest>
    {
        /// <summary>
        /// A value representing a string.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.StringVellumValueRequest? StringVellumValueRequest { get; init; }
#else
        public global::Vellum.StringVellumValueRequest? StringVellumValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StringVellumValueRequest))]
#endif
        public bool IsStringVellumValueRequest => StringVellumValueRequest != null;

        /// <summary>
        /// A value representing a number.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NumberVellumValueRequest? NumberVellumValueRequest { get; init; }
#else
        public global::Vellum.NumberVellumValueRequest? NumberVellumValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NumberVellumValueRequest))]
#endif
        public bool IsNumberVellumValueRequest => NumberVellumValueRequest != null;

        /// <summary>
        /// A value representing a JSON object.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.JsonVellumValueRequest? JsonVellumValueRequest { get; init; }
#else
        public global::Vellum.JsonVellumValueRequest? JsonVellumValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonVellumValueRequest))]
#endif
        public bool IsJsonVellumValueRequest => JsonVellumValueRequest != null;

        /// <summary>
        /// A base Vellum primitive value representing audio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.AudioVellumValueRequest? AudioVellumValueRequest { get; init; }
#else
        public global::Vellum.AudioVellumValueRequest? AudioVellumValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioVellumValueRequest))]
#endif
        public bool IsAudioVellumValueRequest => AudioVellumValueRequest != null;

        /// <summary>
        /// A base Vellum primitive value representing a video.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.VideoVellumValueRequest? VideoVellumValueRequest { get; init; }
#else
        public global::Vellum.VideoVellumValueRequest? VideoVellumValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoVellumValueRequest))]
#endif
        public bool IsVideoVellumValueRequest => VideoVellumValueRequest != null;

        /// <summary>
        /// A base Vellum primitive value representing an image.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ImageVellumValueRequest? ImageVellumValueRequest { get; init; }
#else
        public global::Vellum.ImageVellumValueRequest? ImageVellumValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageVellumValueRequest))]
#endif
        public bool IsImageVellumValueRequest => ImageVellumValueRequest != null;

        /// <summary>
        /// A base Vellum primitive value representing a document.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.DocumentVellumValueRequest? DocumentVellumValueRequest { get; init; }
#else
        public global::Vellum.DocumentVellumValueRequest? DocumentVellumValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DocumentVellumValueRequest))]
#endif
        public bool IsDocumentVellumValueRequest => DocumentVellumValueRequest != null;

        /// <summary>
        /// A value representing a Function Call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.FunctionCallVellumValueRequest? FunctionCallVellumValueRequest { get; init; }
#else
        public global::Vellum.FunctionCallVellumValueRequest? FunctionCallVellumValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallVellumValueRequest))]
#endif
        public bool IsFunctionCallVellumValueRequest => FunctionCallVellumValueRequest != null;

        /// <summary>
        /// A value representing an Error.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ErrorVellumValueRequest? ErrorVellumValueRequest { get; init; }
#else
        public global::Vellum.ErrorVellumValueRequest? ErrorVellumValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ErrorVellumValueRequest))]
#endif
        public bool IsErrorVellumValueRequest => ErrorVellumValueRequest != null;

        /// <summary>
        /// A value representing an array of Vellum variable values.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ArrayVellumValueRequest? ArrayVellumValueRequest { get; init; }
#else
        public global::Vellum.ArrayVellumValueRequest? ArrayVellumValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArrayVellumValueRequest))]
#endif
        public bool IsArrayVellumValueRequest => ArrayVellumValueRequest != null;

        /// <summary>
        /// A value representing Chat History.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ChatHistoryVellumValueRequest? ChatHistoryVellumValueRequest { get; init; }
#else
        public global::Vellum.ChatHistoryVellumValueRequest? ChatHistoryVellumValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatHistoryVellumValueRequest))]
#endif
        public bool IsChatHistoryVellumValueRequest => ChatHistoryVellumValueRequest != null;

        /// <summary>
        /// A value representing Search Results.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.SearchResultsVellumValueRequest? SearchResultsVellumValueRequest { get; init; }
#else
        public global::Vellum.SearchResultsVellumValueRequest? SearchResultsVellumValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchResultsVellumValueRequest))]
#endif
        public bool IsSearchResultsVellumValueRequest => SearchResultsVellumValueRequest != null;

        /// <summary>
        /// A value representing Thinking mode output.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ThinkingVellumValueRequest? ThinkingVellumValueRequest { get; init; }
#else
        public global::Vellum.ThinkingVellumValueRequest? ThinkingVellumValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThinkingVellumValueRequest))]
#endif
        public bool IsThinkingVellumValueRequest => ThinkingVellumValueRequest != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValueRequest(global::Vellum.StringVellumValueRequest value) => new VellumValueRequest((global::Vellum.StringVellumValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.StringVellumValueRequest?(VellumValueRequest @this) => @this.StringVellumValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public VellumValueRequest(global::Vellum.StringVellumValueRequest? value)
        {
            StringVellumValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValueRequest(global::Vellum.NumberVellumValueRequest value) => new VellumValueRequest((global::Vellum.NumberVellumValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NumberVellumValueRequest?(VellumValueRequest @this) => @this.NumberVellumValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public VellumValueRequest(global::Vellum.NumberVellumValueRequest? value)
        {
            NumberVellumValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValueRequest(global::Vellum.JsonVellumValueRequest value) => new VellumValueRequest((global::Vellum.JsonVellumValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.JsonVellumValueRequest?(VellumValueRequest @this) => @this.JsonVellumValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public VellumValueRequest(global::Vellum.JsonVellumValueRequest? value)
        {
            JsonVellumValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValueRequest(global::Vellum.AudioVellumValueRequest value) => new VellumValueRequest((global::Vellum.AudioVellumValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.AudioVellumValueRequest?(VellumValueRequest @this) => @this.AudioVellumValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public VellumValueRequest(global::Vellum.AudioVellumValueRequest? value)
        {
            AudioVellumValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValueRequest(global::Vellum.VideoVellumValueRequest value) => new VellumValueRequest((global::Vellum.VideoVellumValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.VideoVellumValueRequest?(VellumValueRequest @this) => @this.VideoVellumValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public VellumValueRequest(global::Vellum.VideoVellumValueRequest? value)
        {
            VideoVellumValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValueRequest(global::Vellum.ImageVellumValueRequest value) => new VellumValueRequest((global::Vellum.ImageVellumValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ImageVellumValueRequest?(VellumValueRequest @this) => @this.ImageVellumValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public VellumValueRequest(global::Vellum.ImageVellumValueRequest? value)
        {
            ImageVellumValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValueRequest(global::Vellum.DocumentVellumValueRequest value) => new VellumValueRequest((global::Vellum.DocumentVellumValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.DocumentVellumValueRequest?(VellumValueRequest @this) => @this.DocumentVellumValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public VellumValueRequest(global::Vellum.DocumentVellumValueRequest? value)
        {
            DocumentVellumValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValueRequest(global::Vellum.FunctionCallVellumValueRequest value) => new VellumValueRequest((global::Vellum.FunctionCallVellumValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.FunctionCallVellumValueRequest?(VellumValueRequest @this) => @this.FunctionCallVellumValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public VellumValueRequest(global::Vellum.FunctionCallVellumValueRequest? value)
        {
            FunctionCallVellumValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValueRequest(global::Vellum.ErrorVellumValueRequest value) => new VellumValueRequest((global::Vellum.ErrorVellumValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ErrorVellumValueRequest?(VellumValueRequest @this) => @this.ErrorVellumValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public VellumValueRequest(global::Vellum.ErrorVellumValueRequest? value)
        {
            ErrorVellumValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValueRequest(global::Vellum.ArrayVellumValueRequest value) => new VellumValueRequest((global::Vellum.ArrayVellumValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ArrayVellumValueRequest?(VellumValueRequest @this) => @this.ArrayVellumValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public VellumValueRequest(global::Vellum.ArrayVellumValueRequest? value)
        {
            ArrayVellumValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValueRequest(global::Vellum.ChatHistoryVellumValueRequest value) => new VellumValueRequest((global::Vellum.ChatHistoryVellumValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ChatHistoryVellumValueRequest?(VellumValueRequest @this) => @this.ChatHistoryVellumValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public VellumValueRequest(global::Vellum.ChatHistoryVellumValueRequest? value)
        {
            ChatHistoryVellumValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValueRequest(global::Vellum.SearchResultsVellumValueRequest value) => new VellumValueRequest((global::Vellum.SearchResultsVellumValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.SearchResultsVellumValueRequest?(VellumValueRequest @this) => @this.SearchResultsVellumValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public VellumValueRequest(global::Vellum.SearchResultsVellumValueRequest? value)
        {
            SearchResultsVellumValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValueRequest(global::Vellum.ThinkingVellumValueRequest value) => new VellumValueRequest((global::Vellum.ThinkingVellumValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ThinkingVellumValueRequest?(VellumValueRequest @this) => @this.ThinkingVellumValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public VellumValueRequest(global::Vellum.ThinkingVellumValueRequest? value)
        {
            ThinkingVellumValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VellumValueRequest(
            global::Vellum.StringVellumValueRequest? stringVellumValueRequest,
            global::Vellum.NumberVellumValueRequest? numberVellumValueRequest,
            global::Vellum.JsonVellumValueRequest? jsonVellumValueRequest,
            global::Vellum.AudioVellumValueRequest? audioVellumValueRequest,
            global::Vellum.VideoVellumValueRequest? videoVellumValueRequest,
            global::Vellum.ImageVellumValueRequest? imageVellumValueRequest,
            global::Vellum.DocumentVellumValueRequest? documentVellumValueRequest,
            global::Vellum.FunctionCallVellumValueRequest? functionCallVellumValueRequest,
            global::Vellum.ErrorVellumValueRequest? errorVellumValueRequest,
            global::Vellum.ArrayVellumValueRequest? arrayVellumValueRequest,
            global::Vellum.ChatHistoryVellumValueRequest? chatHistoryVellumValueRequest,
            global::Vellum.SearchResultsVellumValueRequest? searchResultsVellumValueRequest,
            global::Vellum.ThinkingVellumValueRequest? thinkingVellumValueRequest
            )
        {
            StringVellumValueRequest = stringVellumValueRequest;
            NumberVellumValueRequest = numberVellumValueRequest;
            JsonVellumValueRequest = jsonVellumValueRequest;
            AudioVellumValueRequest = audioVellumValueRequest;
            VideoVellumValueRequest = videoVellumValueRequest;
            ImageVellumValueRequest = imageVellumValueRequest;
            DocumentVellumValueRequest = documentVellumValueRequest;
            FunctionCallVellumValueRequest = functionCallVellumValueRequest;
            ErrorVellumValueRequest = errorVellumValueRequest;
            ArrayVellumValueRequest = arrayVellumValueRequest;
            ChatHistoryVellumValueRequest = chatHistoryVellumValueRequest;
            SearchResultsVellumValueRequest = searchResultsVellumValueRequest;
            ThinkingVellumValueRequest = thinkingVellumValueRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ThinkingVellumValueRequest as object ??
            SearchResultsVellumValueRequest as object ??
            ChatHistoryVellumValueRequest as object ??
            ArrayVellumValueRequest as object ??
            ErrorVellumValueRequest as object ??
            FunctionCallVellumValueRequest as object ??
            DocumentVellumValueRequest as object ??
            ImageVellumValueRequest as object ??
            VideoVellumValueRequest as object ??
            AudioVellumValueRequest as object ??
            JsonVellumValueRequest as object ??
            NumberVellumValueRequest as object ??
            StringVellumValueRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StringVellumValueRequest?.ToString() ??
            NumberVellumValueRequest?.ToString() ??
            JsonVellumValueRequest?.ToString() ??
            AudioVellumValueRequest?.ToString() ??
            VideoVellumValueRequest?.ToString() ??
            ImageVellumValueRequest?.ToString() ??
            DocumentVellumValueRequest?.ToString() ??
            FunctionCallVellumValueRequest?.ToString() ??
            ErrorVellumValueRequest?.ToString() ??
            ArrayVellumValueRequest?.ToString() ??
            ChatHistoryVellumValueRequest?.ToString() ??
            SearchResultsVellumValueRequest?.ToString() ??
            ThinkingVellumValueRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStringVellumValueRequest && !IsNumberVellumValueRequest && !IsJsonVellumValueRequest && !IsAudioVellumValueRequest && !IsVideoVellumValueRequest && !IsImageVellumValueRequest && !IsDocumentVellumValueRequest && !IsFunctionCallVellumValueRequest && !IsErrorVellumValueRequest && !IsArrayVellumValueRequest && !IsChatHistoryVellumValueRequest && !IsSearchResultsVellumValueRequest && !IsThinkingVellumValueRequest || !IsStringVellumValueRequest && IsNumberVellumValueRequest && !IsJsonVellumValueRequest && !IsAudioVellumValueRequest && !IsVideoVellumValueRequest && !IsImageVellumValueRequest && !IsDocumentVellumValueRequest && !IsFunctionCallVellumValueRequest && !IsErrorVellumValueRequest && !IsArrayVellumValueRequest && !IsChatHistoryVellumValueRequest && !IsSearchResultsVellumValueRequest && !IsThinkingVellumValueRequest || !IsStringVellumValueRequest && !IsNumberVellumValueRequest && IsJsonVellumValueRequest && !IsAudioVellumValueRequest && !IsVideoVellumValueRequest && !IsImageVellumValueRequest && !IsDocumentVellumValueRequest && !IsFunctionCallVellumValueRequest && !IsErrorVellumValueRequest && !IsArrayVellumValueRequest && !IsChatHistoryVellumValueRequest && !IsSearchResultsVellumValueRequest && !IsThinkingVellumValueRequest || !IsStringVellumValueRequest && !IsNumberVellumValueRequest && !IsJsonVellumValueRequest && IsAudioVellumValueRequest && !IsVideoVellumValueRequest && !IsImageVellumValueRequest && !IsDocumentVellumValueRequest && !IsFunctionCallVellumValueRequest && !IsErrorVellumValueRequest && !IsArrayVellumValueRequest && !IsChatHistoryVellumValueRequest && !IsSearchResultsVellumValueRequest && !IsThinkingVellumValueRequest || !IsStringVellumValueRequest && !IsNumberVellumValueRequest && !IsJsonVellumValueRequest && !IsAudioVellumValueRequest && IsVideoVellumValueRequest && !IsImageVellumValueRequest && !IsDocumentVellumValueRequest && !IsFunctionCallVellumValueRequest && !IsErrorVellumValueRequest && !IsArrayVellumValueRequest && !IsChatHistoryVellumValueRequest && !IsSearchResultsVellumValueRequest && !IsThinkingVellumValueRequest || !IsStringVellumValueRequest && !IsNumberVellumValueRequest && !IsJsonVellumValueRequest && !IsAudioVellumValueRequest && !IsVideoVellumValueRequest && IsImageVellumValueRequest && !IsDocumentVellumValueRequest && !IsFunctionCallVellumValueRequest && !IsErrorVellumValueRequest && !IsArrayVellumValueRequest && !IsChatHistoryVellumValueRequest && !IsSearchResultsVellumValueRequest && !IsThinkingVellumValueRequest || !IsStringVellumValueRequest && !IsNumberVellumValueRequest && !IsJsonVellumValueRequest && !IsAudioVellumValueRequest && !IsVideoVellumValueRequest && !IsImageVellumValueRequest && IsDocumentVellumValueRequest && !IsFunctionCallVellumValueRequest && !IsErrorVellumValueRequest && !IsArrayVellumValueRequest && !IsChatHistoryVellumValueRequest && !IsSearchResultsVellumValueRequest && !IsThinkingVellumValueRequest || !IsStringVellumValueRequest && !IsNumberVellumValueRequest && !IsJsonVellumValueRequest && !IsAudioVellumValueRequest && !IsVideoVellumValueRequest && !IsImageVellumValueRequest && !IsDocumentVellumValueRequest && IsFunctionCallVellumValueRequest && !IsErrorVellumValueRequest && !IsArrayVellumValueRequest && !IsChatHistoryVellumValueRequest && !IsSearchResultsVellumValueRequest && !IsThinkingVellumValueRequest || !IsStringVellumValueRequest && !IsNumberVellumValueRequest && !IsJsonVellumValueRequest && !IsAudioVellumValueRequest && !IsVideoVellumValueRequest && !IsImageVellumValueRequest && !IsDocumentVellumValueRequest && !IsFunctionCallVellumValueRequest && IsErrorVellumValueRequest && !IsArrayVellumValueRequest && !IsChatHistoryVellumValueRequest && !IsSearchResultsVellumValueRequest && !IsThinkingVellumValueRequest || !IsStringVellumValueRequest && !IsNumberVellumValueRequest && !IsJsonVellumValueRequest && !IsAudioVellumValueRequest && !IsVideoVellumValueRequest && !IsImageVellumValueRequest && !IsDocumentVellumValueRequest && !IsFunctionCallVellumValueRequest && !IsErrorVellumValueRequest && IsArrayVellumValueRequest && !IsChatHistoryVellumValueRequest && !IsSearchResultsVellumValueRequest && !IsThinkingVellumValueRequest || !IsStringVellumValueRequest && !IsNumberVellumValueRequest && !IsJsonVellumValueRequest && !IsAudioVellumValueRequest && !IsVideoVellumValueRequest && !IsImageVellumValueRequest && !IsDocumentVellumValueRequest && !IsFunctionCallVellumValueRequest && !IsErrorVellumValueRequest && !IsArrayVellumValueRequest && IsChatHistoryVellumValueRequest && !IsSearchResultsVellumValueRequest && !IsThinkingVellumValueRequest || !IsStringVellumValueRequest && !IsNumberVellumValueRequest && !IsJsonVellumValueRequest && !IsAudioVellumValueRequest && !IsVideoVellumValueRequest && !IsImageVellumValueRequest && !IsDocumentVellumValueRequest && !IsFunctionCallVellumValueRequest && !IsErrorVellumValueRequest && !IsArrayVellumValueRequest && !IsChatHistoryVellumValueRequest && IsSearchResultsVellumValueRequest && !IsThinkingVellumValueRequest || !IsStringVellumValueRequest && !IsNumberVellumValueRequest && !IsJsonVellumValueRequest && !IsAudioVellumValueRequest && !IsVideoVellumValueRequest && !IsImageVellumValueRequest && !IsDocumentVellumValueRequest && !IsFunctionCallVellumValueRequest && !IsErrorVellumValueRequest && !IsArrayVellumValueRequest && !IsChatHistoryVellumValueRequest && !IsSearchResultsVellumValueRequest && IsThinkingVellumValueRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.StringVellumValueRequest?, TResult>? stringVellumValueRequest = null,
            global::System.Func<global::Vellum.NumberVellumValueRequest?, TResult>? numberVellumValueRequest = null,
            global::System.Func<global::Vellum.JsonVellumValueRequest?, TResult>? jsonVellumValueRequest = null,
            global::System.Func<global::Vellum.AudioVellumValueRequest?, TResult>? audioVellumValueRequest = null,
            global::System.Func<global::Vellum.VideoVellumValueRequest?, TResult>? videoVellumValueRequest = null,
            global::System.Func<global::Vellum.ImageVellumValueRequest?, TResult>? imageVellumValueRequest = null,
            global::System.Func<global::Vellum.DocumentVellumValueRequest?, TResult>? documentVellumValueRequest = null,
            global::System.Func<global::Vellum.FunctionCallVellumValueRequest?, TResult>? functionCallVellumValueRequest = null,
            global::System.Func<global::Vellum.ErrorVellumValueRequest?, TResult>? errorVellumValueRequest = null,
            global::System.Func<global::Vellum.ArrayVellumValueRequest?, TResult>? arrayVellumValueRequest = null,
            global::System.Func<global::Vellum.ChatHistoryVellumValueRequest?, TResult>? chatHistoryVellumValueRequest = null,
            global::System.Func<global::Vellum.SearchResultsVellumValueRequest?, TResult>? searchResultsVellumValueRequest = null,
            global::System.Func<global::Vellum.ThinkingVellumValueRequest?, TResult>? thinkingVellumValueRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringVellumValueRequest && stringVellumValueRequest != null)
            {
                return stringVellumValueRequest(StringVellumValueRequest!);
            }
            else if (IsNumberVellumValueRequest && numberVellumValueRequest != null)
            {
                return numberVellumValueRequest(NumberVellumValueRequest!);
            }
            else if (IsJsonVellumValueRequest && jsonVellumValueRequest != null)
            {
                return jsonVellumValueRequest(JsonVellumValueRequest!);
            }
            else if (IsAudioVellumValueRequest && audioVellumValueRequest != null)
            {
                return audioVellumValueRequest(AudioVellumValueRequest!);
            }
            else if (IsVideoVellumValueRequest && videoVellumValueRequest != null)
            {
                return videoVellumValueRequest(VideoVellumValueRequest!);
            }
            else if (IsImageVellumValueRequest && imageVellumValueRequest != null)
            {
                return imageVellumValueRequest(ImageVellumValueRequest!);
            }
            else if (IsDocumentVellumValueRequest && documentVellumValueRequest != null)
            {
                return documentVellumValueRequest(DocumentVellumValueRequest!);
            }
            else if (IsFunctionCallVellumValueRequest && functionCallVellumValueRequest != null)
            {
                return functionCallVellumValueRequest(FunctionCallVellumValueRequest!);
            }
            else if (IsErrorVellumValueRequest && errorVellumValueRequest != null)
            {
                return errorVellumValueRequest(ErrorVellumValueRequest!);
            }
            else if (IsArrayVellumValueRequest && arrayVellumValueRequest != null)
            {
                return arrayVellumValueRequest(ArrayVellumValueRequest!);
            }
            else if (IsChatHistoryVellumValueRequest && chatHistoryVellumValueRequest != null)
            {
                return chatHistoryVellumValueRequest(ChatHistoryVellumValueRequest!);
            }
            else if (IsSearchResultsVellumValueRequest && searchResultsVellumValueRequest != null)
            {
                return searchResultsVellumValueRequest(SearchResultsVellumValueRequest!);
            }
            else if (IsThinkingVellumValueRequest && thinkingVellumValueRequest != null)
            {
                return thinkingVellumValueRequest(ThinkingVellumValueRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.StringVellumValueRequest?>? stringVellumValueRequest = null,
            global::System.Action<global::Vellum.NumberVellumValueRequest?>? numberVellumValueRequest = null,
            global::System.Action<global::Vellum.JsonVellumValueRequest?>? jsonVellumValueRequest = null,
            global::System.Action<global::Vellum.AudioVellumValueRequest?>? audioVellumValueRequest = null,
            global::System.Action<global::Vellum.VideoVellumValueRequest?>? videoVellumValueRequest = null,
            global::System.Action<global::Vellum.ImageVellumValueRequest?>? imageVellumValueRequest = null,
            global::System.Action<global::Vellum.DocumentVellumValueRequest?>? documentVellumValueRequest = null,
            global::System.Action<global::Vellum.FunctionCallVellumValueRequest?>? functionCallVellumValueRequest = null,
            global::System.Action<global::Vellum.ErrorVellumValueRequest?>? errorVellumValueRequest = null,
            global::System.Action<global::Vellum.ArrayVellumValueRequest?>? arrayVellumValueRequest = null,
            global::System.Action<global::Vellum.ChatHistoryVellumValueRequest?>? chatHistoryVellumValueRequest = null,
            global::System.Action<global::Vellum.SearchResultsVellumValueRequest?>? searchResultsVellumValueRequest = null,
            global::System.Action<global::Vellum.ThinkingVellumValueRequest?>? thinkingVellumValueRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringVellumValueRequest)
            {
                stringVellumValueRequest?.Invoke(StringVellumValueRequest!);
            }
            else if (IsNumberVellumValueRequest)
            {
                numberVellumValueRequest?.Invoke(NumberVellumValueRequest!);
            }
            else if (IsJsonVellumValueRequest)
            {
                jsonVellumValueRequest?.Invoke(JsonVellumValueRequest!);
            }
            else if (IsAudioVellumValueRequest)
            {
                audioVellumValueRequest?.Invoke(AudioVellumValueRequest!);
            }
            else if (IsVideoVellumValueRequest)
            {
                videoVellumValueRequest?.Invoke(VideoVellumValueRequest!);
            }
            else if (IsImageVellumValueRequest)
            {
                imageVellumValueRequest?.Invoke(ImageVellumValueRequest!);
            }
            else if (IsDocumentVellumValueRequest)
            {
                documentVellumValueRequest?.Invoke(DocumentVellumValueRequest!);
            }
            else if (IsFunctionCallVellumValueRequest)
            {
                functionCallVellumValueRequest?.Invoke(FunctionCallVellumValueRequest!);
            }
            else if (IsErrorVellumValueRequest)
            {
                errorVellumValueRequest?.Invoke(ErrorVellumValueRequest!);
            }
            else if (IsArrayVellumValueRequest)
            {
                arrayVellumValueRequest?.Invoke(ArrayVellumValueRequest!);
            }
            else if (IsChatHistoryVellumValueRequest)
            {
                chatHistoryVellumValueRequest?.Invoke(ChatHistoryVellumValueRequest!);
            }
            else if (IsSearchResultsVellumValueRequest)
            {
                searchResultsVellumValueRequest?.Invoke(SearchResultsVellumValueRequest!);
            }
            else if (IsThinkingVellumValueRequest)
            {
                thinkingVellumValueRequest?.Invoke(ThinkingVellumValueRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StringVellumValueRequest,
                typeof(global::Vellum.StringVellumValueRequest),
                NumberVellumValueRequest,
                typeof(global::Vellum.NumberVellumValueRequest),
                JsonVellumValueRequest,
                typeof(global::Vellum.JsonVellumValueRequest),
                AudioVellumValueRequest,
                typeof(global::Vellum.AudioVellumValueRequest),
                VideoVellumValueRequest,
                typeof(global::Vellum.VideoVellumValueRequest),
                ImageVellumValueRequest,
                typeof(global::Vellum.ImageVellumValueRequest),
                DocumentVellumValueRequest,
                typeof(global::Vellum.DocumentVellumValueRequest),
                FunctionCallVellumValueRequest,
                typeof(global::Vellum.FunctionCallVellumValueRequest),
                ErrorVellumValueRequest,
                typeof(global::Vellum.ErrorVellumValueRequest),
                ArrayVellumValueRequest,
                typeof(global::Vellum.ArrayVellumValueRequest),
                ChatHistoryVellumValueRequest,
                typeof(global::Vellum.ChatHistoryVellumValueRequest),
                SearchResultsVellumValueRequest,
                typeof(global::Vellum.SearchResultsVellumValueRequest),
                ThinkingVellumValueRequest,
                typeof(global::Vellum.ThinkingVellumValueRequest),
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
        public bool Equals(VellumValueRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.StringVellumValueRequest?>.Default.Equals(StringVellumValueRequest, other.StringVellumValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NumberVellumValueRequest?>.Default.Equals(NumberVellumValueRequest, other.NumberVellumValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.JsonVellumValueRequest?>.Default.Equals(JsonVellumValueRequest, other.JsonVellumValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.AudioVellumValueRequest?>.Default.Equals(AudioVellumValueRequest, other.AudioVellumValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.VideoVellumValueRequest?>.Default.Equals(VideoVellumValueRequest, other.VideoVellumValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ImageVellumValueRequest?>.Default.Equals(ImageVellumValueRequest, other.ImageVellumValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.DocumentVellumValueRequest?>.Default.Equals(DocumentVellumValueRequest, other.DocumentVellumValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.FunctionCallVellumValueRequest?>.Default.Equals(FunctionCallVellumValueRequest, other.FunctionCallVellumValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ErrorVellumValueRequest?>.Default.Equals(ErrorVellumValueRequest, other.ErrorVellumValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ArrayVellumValueRequest?>.Default.Equals(ArrayVellumValueRequest, other.ArrayVellumValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ChatHistoryVellumValueRequest?>.Default.Equals(ChatHistoryVellumValueRequest, other.ChatHistoryVellumValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.SearchResultsVellumValueRequest?>.Default.Equals(SearchResultsVellumValueRequest, other.SearchResultsVellumValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ThinkingVellumValueRequest?>.Default.Equals(ThinkingVellumValueRequest, other.ThinkingVellumValueRequest) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VellumValueRequest obj1, VellumValueRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VellumValueRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VellumValueRequest obj1, VellumValueRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VellumValueRequest o && Equals(o);
        }
    }
}
