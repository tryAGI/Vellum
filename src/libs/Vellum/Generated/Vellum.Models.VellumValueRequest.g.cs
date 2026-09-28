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
        ///
        /// </summary>
        public bool TryPickStringVellumValueRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.StringVellumValueRequest? value)
        {
            value = StringVellumValueRequest;
            return IsStringVellumValueRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.StringVellumValueRequest PickStringVellumValueRequest() => StringVellumValueRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StringVellumValueRequest' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickNumberVellumValueRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.NumberVellumValueRequest? value)
        {
            value = NumberVellumValueRequest;
            return IsNumberVellumValueRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NumberVellumValueRequest PickNumberVellumValueRequest() => NumberVellumValueRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NumberVellumValueRequest' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickJsonVellumValueRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.JsonVellumValueRequest? value)
        {
            value = JsonVellumValueRequest;
            return IsJsonVellumValueRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.JsonVellumValueRequest PickJsonVellumValueRequest() => JsonVellumValueRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JsonVellumValueRequest' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickAudioVellumValueRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.AudioVellumValueRequest? value)
        {
            value = AudioVellumValueRequest;
            return IsAudioVellumValueRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.AudioVellumValueRequest PickAudioVellumValueRequest() => AudioVellumValueRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioVellumValueRequest' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickVideoVellumValueRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.VideoVellumValueRequest? value)
        {
            value = VideoVellumValueRequest;
            return IsVideoVellumValueRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VideoVellumValueRequest PickVideoVellumValueRequest() => VideoVellumValueRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoVellumValueRequest' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickImageVellumValueRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.ImageVellumValueRequest? value)
        {
            value = ImageVellumValueRequest;
            return IsImageVellumValueRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ImageVellumValueRequest PickImageVellumValueRequest() => ImageVellumValueRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageVellumValueRequest' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickDocumentVellumValueRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.DocumentVellumValueRequest? value)
        {
            value = DocumentVellumValueRequest;
            return IsDocumentVellumValueRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentVellumValueRequest PickDocumentVellumValueRequest() => DocumentVellumValueRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DocumentVellumValueRequest' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickFunctionCallVellumValueRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.FunctionCallVellumValueRequest? value)
        {
            value = FunctionCallVellumValueRequest;
            return IsFunctionCallVellumValueRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FunctionCallVellumValueRequest PickFunctionCallVellumValueRequest() => FunctionCallVellumValueRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallVellumValueRequest' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickErrorVellumValueRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.ErrorVellumValueRequest? value)
        {
            value = ErrorVellumValueRequest;
            return IsErrorVellumValueRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ErrorVellumValueRequest PickErrorVellumValueRequest() => ErrorVellumValueRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ErrorVellumValueRequest' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickArrayVellumValueRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.ArrayVellumValueRequest? value)
        {
            value = ArrayVellumValueRequest;
            return IsArrayVellumValueRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ArrayVellumValueRequest PickArrayVellumValueRequest() => ArrayVellumValueRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ArrayVellumValueRequest' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickChatHistoryVellumValueRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.ChatHistoryVellumValueRequest? value)
        {
            value = ChatHistoryVellumValueRequest;
            return IsChatHistoryVellumValueRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ChatHistoryVellumValueRequest PickChatHistoryVellumValueRequest() => ChatHistoryVellumValueRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatHistoryVellumValueRequest' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickSearchResultsVellumValueRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.SearchResultsVellumValueRequest? value)
        {
            value = SearchResultsVellumValueRequest;
            return IsSearchResultsVellumValueRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultsVellumValueRequest PickSearchResultsVellumValueRequest() => SearchResultsVellumValueRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchResultsVellumValueRequest' but the value was {ToString()}.");

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
        public bool TryPickThinkingVellumValueRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.ThinkingVellumValueRequest? value)
        {
            value = ThinkingVellumValueRequest;
            return IsThinkingVellumValueRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ThinkingVellumValueRequest PickThinkingVellumValueRequest() => ThinkingVellumValueRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ThinkingVellumValueRequest' but the value was {ToString()}.");
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
        public static VellumValueRequest FromStringVellumValueRequest(global::Vellum.StringVellumValueRequest? value) => new VellumValueRequest(value);

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
        public static VellumValueRequest FromNumberVellumValueRequest(global::Vellum.NumberVellumValueRequest? value) => new VellumValueRequest(value);

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
        public static VellumValueRequest FromJsonVellumValueRequest(global::Vellum.JsonVellumValueRequest? value) => new VellumValueRequest(value);

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
        public static VellumValueRequest FromAudioVellumValueRequest(global::Vellum.AudioVellumValueRequest? value) => new VellumValueRequest(value);

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
        public static VellumValueRequest FromVideoVellumValueRequest(global::Vellum.VideoVellumValueRequest? value) => new VellumValueRequest(value);

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
        public static VellumValueRequest FromImageVellumValueRequest(global::Vellum.ImageVellumValueRequest? value) => new VellumValueRequest(value);

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
        public static VellumValueRequest FromDocumentVellumValueRequest(global::Vellum.DocumentVellumValueRequest? value) => new VellumValueRequest(value);

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
        public static VellumValueRequest FromFunctionCallVellumValueRequest(global::Vellum.FunctionCallVellumValueRequest? value) => new VellumValueRequest(value);

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
        public static VellumValueRequest FromErrorVellumValueRequest(global::Vellum.ErrorVellumValueRequest? value) => new VellumValueRequest(value);

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
        public static VellumValueRequest FromArrayVellumValueRequest(global::Vellum.ArrayVellumValueRequest? value) => new VellumValueRequest(value);

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
        public static VellumValueRequest FromChatHistoryVellumValueRequest(global::Vellum.ChatHistoryVellumValueRequest? value) => new VellumValueRequest(value);

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
        public static VellumValueRequest FromSearchResultsVellumValueRequest(global::Vellum.SearchResultsVellumValueRequest? value) => new VellumValueRequest(value);

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
        public static VellumValueRequest FromThinkingVellumValueRequest(global::Vellum.ThinkingVellumValueRequest? value) => new VellumValueRequest(value);

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
            global::System.Func<global::Vellum.StringVellumValueRequest, TResult>? stringVellumValueRequest = null,
            global::System.Func<global::Vellum.NumberVellumValueRequest, TResult>? numberVellumValueRequest = null,
            global::System.Func<global::Vellum.JsonVellumValueRequest, TResult>? jsonVellumValueRequest = null,
            global::System.Func<global::Vellum.AudioVellumValueRequest, TResult>? audioVellumValueRequest = null,
            global::System.Func<global::Vellum.VideoVellumValueRequest, TResult>? videoVellumValueRequest = null,
            global::System.Func<global::Vellum.ImageVellumValueRequest, TResult>? imageVellumValueRequest = null,
            global::System.Func<global::Vellum.DocumentVellumValueRequest, TResult>? documentVellumValueRequest = null,
            global::System.Func<global::Vellum.FunctionCallVellumValueRequest, TResult>? functionCallVellumValueRequest = null,
            global::System.Func<global::Vellum.ErrorVellumValueRequest, TResult>? errorVellumValueRequest = null,
            global::System.Func<global::Vellum.ArrayVellumValueRequest, TResult>? arrayVellumValueRequest = null,
            global::System.Func<global::Vellum.ChatHistoryVellumValueRequest, TResult>? chatHistoryVellumValueRequest = null,
            global::System.Func<global::Vellum.SearchResultsVellumValueRequest, TResult>? searchResultsVellumValueRequest = null,
            global::System.Func<global::Vellum.ThinkingVellumValueRequest, TResult>? thinkingVellumValueRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StringVellumValueRequest is { } __value0 && stringVellumValueRequest != null)
            {
                return stringVellumValueRequest(__value0);
            }
            else if (NumberVellumValueRequest is { } __value1 && numberVellumValueRequest != null)
            {
                return numberVellumValueRequest(__value1);
            }
            else if (JsonVellumValueRequest is { } __value2 && jsonVellumValueRequest != null)
            {
                return jsonVellumValueRequest(__value2);
            }
            else if (AudioVellumValueRequest is { } __value3 && audioVellumValueRequest != null)
            {
                return audioVellumValueRequest(__value3);
            }
            else if (VideoVellumValueRequest is { } __value4 && videoVellumValueRequest != null)
            {
                return videoVellumValueRequest(__value4);
            }
            else if (ImageVellumValueRequest is { } __value5 && imageVellumValueRequest != null)
            {
                return imageVellumValueRequest(__value5);
            }
            else if (DocumentVellumValueRequest is { } __value6 && documentVellumValueRequest != null)
            {
                return documentVellumValueRequest(__value6);
            }
            else if (FunctionCallVellumValueRequest is { } __value7 && functionCallVellumValueRequest != null)
            {
                return functionCallVellumValueRequest(__value7);
            }
            else if (ErrorVellumValueRequest is { } __value8 && errorVellumValueRequest != null)
            {
                return errorVellumValueRequest(__value8);
            }
            else if (ArrayVellumValueRequest is { } __value9 && arrayVellumValueRequest != null)
            {
                return arrayVellumValueRequest(__value9);
            }
            else if (ChatHistoryVellumValueRequest is { } __value10 && chatHistoryVellumValueRequest != null)
            {
                return chatHistoryVellumValueRequest(__value10);
            }
            else if (SearchResultsVellumValueRequest is { } __value11 && searchResultsVellumValueRequest != null)
            {
                return searchResultsVellumValueRequest(__value11);
            }
            else if (ThinkingVellumValueRequest is { } __value12 && thinkingVellumValueRequest != null)
            {
                return thinkingVellumValueRequest(__value12);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.StringVellumValueRequest>? stringVellumValueRequest = null,

            global::System.Action<global::Vellum.NumberVellumValueRequest>? numberVellumValueRequest = null,

            global::System.Action<global::Vellum.JsonVellumValueRequest>? jsonVellumValueRequest = null,

            global::System.Action<global::Vellum.AudioVellumValueRequest>? audioVellumValueRequest = null,

            global::System.Action<global::Vellum.VideoVellumValueRequest>? videoVellumValueRequest = null,

            global::System.Action<global::Vellum.ImageVellumValueRequest>? imageVellumValueRequest = null,

            global::System.Action<global::Vellum.DocumentVellumValueRequest>? documentVellumValueRequest = null,

            global::System.Action<global::Vellum.FunctionCallVellumValueRequest>? functionCallVellumValueRequest = null,

            global::System.Action<global::Vellum.ErrorVellumValueRequest>? errorVellumValueRequest = null,

            global::System.Action<global::Vellum.ArrayVellumValueRequest>? arrayVellumValueRequest = null,

            global::System.Action<global::Vellum.ChatHistoryVellumValueRequest>? chatHistoryVellumValueRequest = null,

            global::System.Action<global::Vellum.SearchResultsVellumValueRequest>? searchResultsVellumValueRequest = null,

            global::System.Action<global::Vellum.ThinkingVellumValueRequest>? thinkingVellumValueRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StringVellumValueRequest is { } __value0)
            {
                stringVellumValueRequest?.Invoke(__value0);
            }
            else if (NumberVellumValueRequest is { } __value1)
            {
                numberVellumValueRequest?.Invoke(__value1);
            }
            else if (JsonVellumValueRequest is { } __value2)
            {
                jsonVellumValueRequest?.Invoke(__value2);
            }
            else if (AudioVellumValueRequest is { } __value3)
            {
                audioVellumValueRequest?.Invoke(__value3);
            }
            else if (VideoVellumValueRequest is { } __value4)
            {
                videoVellumValueRequest?.Invoke(__value4);
            }
            else if (ImageVellumValueRequest is { } __value5)
            {
                imageVellumValueRequest?.Invoke(__value5);
            }
            else if (DocumentVellumValueRequest is { } __value6)
            {
                documentVellumValueRequest?.Invoke(__value6);
            }
            else if (FunctionCallVellumValueRequest is { } __value7)
            {
                functionCallVellumValueRequest?.Invoke(__value7);
            }
            else if (ErrorVellumValueRequest is { } __value8)
            {
                errorVellumValueRequest?.Invoke(__value8);
            }
            else if (ArrayVellumValueRequest is { } __value9)
            {
                arrayVellumValueRequest?.Invoke(__value9);
            }
            else if (ChatHistoryVellumValueRequest is { } __value10)
            {
                chatHistoryVellumValueRequest?.Invoke(__value10);
            }
            else if (SearchResultsVellumValueRequest is { } __value11)
            {
                searchResultsVellumValueRequest?.Invoke(__value11);
            }
            else if (ThinkingVellumValueRequest is { } __value12)
            {
                thinkingVellumValueRequest?.Invoke(__value12);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vellum.StringVellumValueRequest>? stringVellumValueRequest = null,
            global::System.Action<global::Vellum.NumberVellumValueRequest>? numberVellumValueRequest = null,
            global::System.Action<global::Vellum.JsonVellumValueRequest>? jsonVellumValueRequest = null,
            global::System.Action<global::Vellum.AudioVellumValueRequest>? audioVellumValueRequest = null,
            global::System.Action<global::Vellum.VideoVellumValueRequest>? videoVellumValueRequest = null,
            global::System.Action<global::Vellum.ImageVellumValueRequest>? imageVellumValueRequest = null,
            global::System.Action<global::Vellum.DocumentVellumValueRequest>? documentVellumValueRequest = null,
            global::System.Action<global::Vellum.FunctionCallVellumValueRequest>? functionCallVellumValueRequest = null,
            global::System.Action<global::Vellum.ErrorVellumValueRequest>? errorVellumValueRequest = null,
            global::System.Action<global::Vellum.ArrayVellumValueRequest>? arrayVellumValueRequest = null,
            global::System.Action<global::Vellum.ChatHistoryVellumValueRequest>? chatHistoryVellumValueRequest = null,
            global::System.Action<global::Vellum.SearchResultsVellumValueRequest>? searchResultsVellumValueRequest = null,
            global::System.Action<global::Vellum.ThinkingVellumValueRequest>? thinkingVellumValueRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StringVellumValueRequest is { } __value0)
            {
                stringVellumValueRequest?.Invoke(__value0);
            }
            else if (NumberVellumValueRequest is { } __value1)
            {
                numberVellumValueRequest?.Invoke(__value1);
            }
            else if (JsonVellumValueRequest is { } __value2)
            {
                jsonVellumValueRequest?.Invoke(__value2);
            }
            else if (AudioVellumValueRequest is { } __value3)
            {
                audioVellumValueRequest?.Invoke(__value3);
            }
            else if (VideoVellumValueRequest is { } __value4)
            {
                videoVellumValueRequest?.Invoke(__value4);
            }
            else if (ImageVellumValueRequest is { } __value5)
            {
                imageVellumValueRequest?.Invoke(__value5);
            }
            else if (DocumentVellumValueRequest is { } __value6)
            {
                documentVellumValueRequest?.Invoke(__value6);
            }
            else if (FunctionCallVellumValueRequest is { } __value7)
            {
                functionCallVellumValueRequest?.Invoke(__value7);
            }
            else if (ErrorVellumValueRequest is { } __value8)
            {
                errorVellumValueRequest?.Invoke(__value8);
            }
            else if (ArrayVellumValueRequest is { } __value9)
            {
                arrayVellumValueRequest?.Invoke(__value9);
            }
            else if (ChatHistoryVellumValueRequest is { } __value10)
            {
                chatHistoryVellumValueRequest?.Invoke(__value10);
            }
            else if (SearchResultsVellumValueRequest is { } __value11)
            {
                searchResultsVellumValueRequest?.Invoke(__value11);
            }
            else if (ThinkingVellumValueRequest is { } __value12)
            {
                thinkingVellumValueRequest?.Invoke(__value12);
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
