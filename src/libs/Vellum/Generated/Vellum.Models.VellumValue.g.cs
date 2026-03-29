#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VellumValue : global::System.IEquatable<VellumValue>
    {
        /// <summary>
        /// A value representing a string.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.StringVellumValue? StringVellumValue { get; init; }
#else
        public global::Vellum.StringVellumValue? StringVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StringVellumValue))]
#endif
        public bool IsStringVellumValue => StringVellumValue != null;

        /// <summary>
        /// A value representing a number.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NumberVellumValue? NumberVellumValue { get; init; }
#else
        public global::Vellum.NumberVellumValue? NumberVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NumberVellumValue))]
#endif
        public bool IsNumberVellumValue => NumberVellumValue != null;

        /// <summary>
        /// A value representing a JSON object.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.JsonVellumValue? JsonVellumValue { get; init; }
#else
        public global::Vellum.JsonVellumValue? JsonVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonVellumValue))]
#endif
        public bool IsJsonVellumValue => JsonVellumValue != null;

        /// <summary>
        /// A base Vellum primitive value representing audio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.AudioVellumValue? AudioVellumValue { get; init; }
#else
        public global::Vellum.AudioVellumValue? AudioVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioVellumValue))]
#endif
        public bool IsAudioVellumValue => AudioVellumValue != null;

        /// <summary>
        /// A base Vellum primitive value representing a video.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.VideoVellumValue? VideoVellumValue { get; init; }
#else
        public global::Vellum.VideoVellumValue? VideoVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoVellumValue))]
#endif
        public bool IsVideoVellumValue => VideoVellumValue != null;

        /// <summary>
        /// A base Vellum primitive value representing an image.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ImageVellumValue? ImageVellumValue { get; init; }
#else
        public global::Vellum.ImageVellumValue? ImageVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageVellumValue))]
#endif
        public bool IsImageVellumValue => ImageVellumValue != null;

        /// <summary>
        /// A base Vellum primitive value representing a document.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.DocumentVellumValue? DocumentVellumValue { get; init; }
#else
        public global::Vellum.DocumentVellumValue? DocumentVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DocumentVellumValue))]
#endif
        public bool IsDocumentVellumValue => DocumentVellumValue != null;

        /// <summary>
        /// A value representing a Function Call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.FunctionCallVellumValue? FunctionCallVellumValue { get; init; }
#else
        public global::Vellum.FunctionCallVellumValue? FunctionCallVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallVellumValue))]
#endif
        public bool IsFunctionCallVellumValue => FunctionCallVellumValue != null;

        /// <summary>
        /// A value representing an Error.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ErrorVellumValue? ErrorVellumValue { get; init; }
#else
        public global::Vellum.ErrorVellumValue? ErrorVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ErrorVellumValue))]
#endif
        public bool IsErrorVellumValue => ErrorVellumValue != null;

        /// <summary>
        /// A value representing an array of Vellum variable values.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ArrayVellumValue? ArrayVellumValue { get; init; }
#else
        public global::Vellum.ArrayVellumValue? ArrayVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ArrayVellumValue))]
#endif
        public bool IsArrayVellumValue => ArrayVellumValue != null;

        /// <summary>
        /// A value representing Chat History.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ChatHistoryVellumValue? ChatHistoryVellumValue { get; init; }
#else
        public global::Vellum.ChatHistoryVellumValue? ChatHistoryVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatHistoryVellumValue))]
#endif
        public bool IsChatHistoryVellumValue => ChatHistoryVellumValue != null;

        /// <summary>
        /// A value representing Search Results.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.SearchResultsVellumValue? SearchResultsVellumValue { get; init; }
#else
        public global::Vellum.SearchResultsVellumValue? SearchResultsVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchResultsVellumValue))]
#endif
        public bool IsSearchResultsVellumValue => SearchResultsVellumValue != null;

        /// <summary>
        /// A value representing Thinking mode output.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ThinkingVellumValue? ThinkingVellumValue { get; init; }
#else
        public global::Vellum.ThinkingVellumValue? ThinkingVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThinkingVellumValue))]
#endif
        public bool IsThinkingVellumValue => ThinkingVellumValue != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValue(global::Vellum.StringVellumValue value) => new VellumValue((global::Vellum.StringVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.StringVellumValue?(VellumValue @this) => @this.StringVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public VellumValue(global::Vellum.StringVellumValue? value)
        {
            StringVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValue(global::Vellum.NumberVellumValue value) => new VellumValue((global::Vellum.NumberVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NumberVellumValue?(VellumValue @this) => @this.NumberVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public VellumValue(global::Vellum.NumberVellumValue? value)
        {
            NumberVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValue(global::Vellum.JsonVellumValue value) => new VellumValue((global::Vellum.JsonVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.JsonVellumValue?(VellumValue @this) => @this.JsonVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public VellumValue(global::Vellum.JsonVellumValue? value)
        {
            JsonVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValue(global::Vellum.AudioVellumValue value) => new VellumValue((global::Vellum.AudioVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.AudioVellumValue?(VellumValue @this) => @this.AudioVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public VellumValue(global::Vellum.AudioVellumValue? value)
        {
            AudioVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValue(global::Vellum.VideoVellumValue value) => new VellumValue((global::Vellum.VideoVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.VideoVellumValue?(VellumValue @this) => @this.VideoVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public VellumValue(global::Vellum.VideoVellumValue? value)
        {
            VideoVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValue(global::Vellum.ImageVellumValue value) => new VellumValue((global::Vellum.ImageVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ImageVellumValue?(VellumValue @this) => @this.ImageVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public VellumValue(global::Vellum.ImageVellumValue? value)
        {
            ImageVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValue(global::Vellum.DocumentVellumValue value) => new VellumValue((global::Vellum.DocumentVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.DocumentVellumValue?(VellumValue @this) => @this.DocumentVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public VellumValue(global::Vellum.DocumentVellumValue? value)
        {
            DocumentVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValue(global::Vellum.FunctionCallVellumValue value) => new VellumValue((global::Vellum.FunctionCallVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.FunctionCallVellumValue?(VellumValue @this) => @this.FunctionCallVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public VellumValue(global::Vellum.FunctionCallVellumValue? value)
        {
            FunctionCallVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValue(global::Vellum.ErrorVellumValue value) => new VellumValue((global::Vellum.ErrorVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ErrorVellumValue?(VellumValue @this) => @this.ErrorVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public VellumValue(global::Vellum.ErrorVellumValue? value)
        {
            ErrorVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValue(global::Vellum.ArrayVellumValue value) => new VellumValue((global::Vellum.ArrayVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ArrayVellumValue?(VellumValue @this) => @this.ArrayVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public VellumValue(global::Vellum.ArrayVellumValue? value)
        {
            ArrayVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValue(global::Vellum.ChatHistoryVellumValue value) => new VellumValue((global::Vellum.ChatHistoryVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ChatHistoryVellumValue?(VellumValue @this) => @this.ChatHistoryVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public VellumValue(global::Vellum.ChatHistoryVellumValue? value)
        {
            ChatHistoryVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValue(global::Vellum.SearchResultsVellumValue value) => new VellumValue((global::Vellum.SearchResultsVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.SearchResultsVellumValue?(VellumValue @this) => @this.SearchResultsVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public VellumValue(global::Vellum.SearchResultsVellumValue? value)
        {
            SearchResultsVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValue(global::Vellum.ThinkingVellumValue value) => new VellumValue((global::Vellum.ThinkingVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ThinkingVellumValue?(VellumValue @this) => @this.ThinkingVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public VellumValue(global::Vellum.ThinkingVellumValue? value)
        {
            ThinkingVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VellumValue(
            global::Vellum.StringVellumValue? stringVellumValue,
            global::Vellum.NumberVellumValue? numberVellumValue,
            global::Vellum.JsonVellumValue? jsonVellumValue,
            global::Vellum.AudioVellumValue? audioVellumValue,
            global::Vellum.VideoVellumValue? videoVellumValue,
            global::Vellum.ImageVellumValue? imageVellumValue,
            global::Vellum.DocumentVellumValue? documentVellumValue,
            global::Vellum.FunctionCallVellumValue? functionCallVellumValue,
            global::Vellum.ErrorVellumValue? errorVellumValue,
            global::Vellum.ArrayVellumValue? arrayVellumValue,
            global::Vellum.ChatHistoryVellumValue? chatHistoryVellumValue,
            global::Vellum.SearchResultsVellumValue? searchResultsVellumValue,
            global::Vellum.ThinkingVellumValue? thinkingVellumValue
            )
        {
            StringVellumValue = stringVellumValue;
            NumberVellumValue = numberVellumValue;
            JsonVellumValue = jsonVellumValue;
            AudioVellumValue = audioVellumValue;
            VideoVellumValue = videoVellumValue;
            ImageVellumValue = imageVellumValue;
            DocumentVellumValue = documentVellumValue;
            FunctionCallVellumValue = functionCallVellumValue;
            ErrorVellumValue = errorVellumValue;
            ArrayVellumValue = arrayVellumValue;
            ChatHistoryVellumValue = chatHistoryVellumValue;
            SearchResultsVellumValue = searchResultsVellumValue;
            ThinkingVellumValue = thinkingVellumValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ThinkingVellumValue as object ??
            SearchResultsVellumValue as object ??
            ChatHistoryVellumValue as object ??
            ArrayVellumValue as object ??
            ErrorVellumValue as object ??
            FunctionCallVellumValue as object ??
            DocumentVellumValue as object ??
            ImageVellumValue as object ??
            VideoVellumValue as object ??
            AudioVellumValue as object ??
            JsonVellumValue as object ??
            NumberVellumValue as object ??
            StringVellumValue as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StringVellumValue?.ToString() ??
            NumberVellumValue?.ToString() ??
            JsonVellumValue?.ToString() ??
            AudioVellumValue?.ToString() ??
            VideoVellumValue?.ToString() ??
            ImageVellumValue?.ToString() ??
            DocumentVellumValue?.ToString() ??
            FunctionCallVellumValue?.ToString() ??
            ErrorVellumValue?.ToString() ??
            ArrayVellumValue?.ToString() ??
            ChatHistoryVellumValue?.ToString() ??
            SearchResultsVellumValue?.ToString() ??
            ThinkingVellumValue?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStringVellumValue && !IsNumberVellumValue && !IsJsonVellumValue && !IsAudioVellumValue && !IsVideoVellumValue && !IsImageVellumValue && !IsDocumentVellumValue && !IsFunctionCallVellumValue && !IsErrorVellumValue && !IsArrayVellumValue && !IsChatHistoryVellumValue && !IsSearchResultsVellumValue && !IsThinkingVellumValue || !IsStringVellumValue && IsNumberVellumValue && !IsJsonVellumValue && !IsAudioVellumValue && !IsVideoVellumValue && !IsImageVellumValue && !IsDocumentVellumValue && !IsFunctionCallVellumValue && !IsErrorVellumValue && !IsArrayVellumValue && !IsChatHistoryVellumValue && !IsSearchResultsVellumValue && !IsThinkingVellumValue || !IsStringVellumValue && !IsNumberVellumValue && IsJsonVellumValue && !IsAudioVellumValue && !IsVideoVellumValue && !IsImageVellumValue && !IsDocumentVellumValue && !IsFunctionCallVellumValue && !IsErrorVellumValue && !IsArrayVellumValue && !IsChatHistoryVellumValue && !IsSearchResultsVellumValue && !IsThinkingVellumValue || !IsStringVellumValue && !IsNumberVellumValue && !IsJsonVellumValue && IsAudioVellumValue && !IsVideoVellumValue && !IsImageVellumValue && !IsDocumentVellumValue && !IsFunctionCallVellumValue && !IsErrorVellumValue && !IsArrayVellumValue && !IsChatHistoryVellumValue && !IsSearchResultsVellumValue && !IsThinkingVellumValue || !IsStringVellumValue && !IsNumberVellumValue && !IsJsonVellumValue && !IsAudioVellumValue && IsVideoVellumValue && !IsImageVellumValue && !IsDocumentVellumValue && !IsFunctionCallVellumValue && !IsErrorVellumValue && !IsArrayVellumValue && !IsChatHistoryVellumValue && !IsSearchResultsVellumValue && !IsThinkingVellumValue || !IsStringVellumValue && !IsNumberVellumValue && !IsJsonVellumValue && !IsAudioVellumValue && !IsVideoVellumValue && IsImageVellumValue && !IsDocumentVellumValue && !IsFunctionCallVellumValue && !IsErrorVellumValue && !IsArrayVellumValue && !IsChatHistoryVellumValue && !IsSearchResultsVellumValue && !IsThinkingVellumValue || !IsStringVellumValue && !IsNumberVellumValue && !IsJsonVellumValue && !IsAudioVellumValue && !IsVideoVellumValue && !IsImageVellumValue && IsDocumentVellumValue && !IsFunctionCallVellumValue && !IsErrorVellumValue && !IsArrayVellumValue && !IsChatHistoryVellumValue && !IsSearchResultsVellumValue && !IsThinkingVellumValue || !IsStringVellumValue && !IsNumberVellumValue && !IsJsonVellumValue && !IsAudioVellumValue && !IsVideoVellumValue && !IsImageVellumValue && !IsDocumentVellumValue && IsFunctionCallVellumValue && !IsErrorVellumValue && !IsArrayVellumValue && !IsChatHistoryVellumValue && !IsSearchResultsVellumValue && !IsThinkingVellumValue || !IsStringVellumValue && !IsNumberVellumValue && !IsJsonVellumValue && !IsAudioVellumValue && !IsVideoVellumValue && !IsImageVellumValue && !IsDocumentVellumValue && !IsFunctionCallVellumValue && IsErrorVellumValue && !IsArrayVellumValue && !IsChatHistoryVellumValue && !IsSearchResultsVellumValue && !IsThinkingVellumValue || !IsStringVellumValue && !IsNumberVellumValue && !IsJsonVellumValue && !IsAudioVellumValue && !IsVideoVellumValue && !IsImageVellumValue && !IsDocumentVellumValue && !IsFunctionCallVellumValue && !IsErrorVellumValue && IsArrayVellumValue && !IsChatHistoryVellumValue && !IsSearchResultsVellumValue && !IsThinkingVellumValue || !IsStringVellumValue && !IsNumberVellumValue && !IsJsonVellumValue && !IsAudioVellumValue && !IsVideoVellumValue && !IsImageVellumValue && !IsDocumentVellumValue && !IsFunctionCallVellumValue && !IsErrorVellumValue && !IsArrayVellumValue && IsChatHistoryVellumValue && !IsSearchResultsVellumValue && !IsThinkingVellumValue || !IsStringVellumValue && !IsNumberVellumValue && !IsJsonVellumValue && !IsAudioVellumValue && !IsVideoVellumValue && !IsImageVellumValue && !IsDocumentVellumValue && !IsFunctionCallVellumValue && !IsErrorVellumValue && !IsArrayVellumValue && !IsChatHistoryVellumValue && IsSearchResultsVellumValue && !IsThinkingVellumValue || !IsStringVellumValue && !IsNumberVellumValue && !IsJsonVellumValue && !IsAudioVellumValue && !IsVideoVellumValue && !IsImageVellumValue && !IsDocumentVellumValue && !IsFunctionCallVellumValue && !IsErrorVellumValue && !IsArrayVellumValue && !IsChatHistoryVellumValue && !IsSearchResultsVellumValue && IsThinkingVellumValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.StringVellumValue?, TResult>? stringVellumValue = null,
            global::System.Func<global::Vellum.NumberVellumValue?, TResult>? numberVellumValue = null,
            global::System.Func<global::Vellum.JsonVellumValue?, TResult>? jsonVellumValue = null,
            global::System.Func<global::Vellum.AudioVellumValue?, TResult>? audioVellumValue = null,
            global::System.Func<global::Vellum.VideoVellumValue?, TResult>? videoVellumValue = null,
            global::System.Func<global::Vellum.ImageVellumValue?, TResult>? imageVellumValue = null,
            global::System.Func<global::Vellum.DocumentVellumValue?, TResult>? documentVellumValue = null,
            global::System.Func<global::Vellum.FunctionCallVellumValue?, TResult>? functionCallVellumValue = null,
            global::System.Func<global::Vellum.ErrorVellumValue?, TResult>? errorVellumValue = null,
            global::System.Func<global::Vellum.ArrayVellumValue?, TResult>? arrayVellumValue = null,
            global::System.Func<global::Vellum.ChatHistoryVellumValue?, TResult>? chatHistoryVellumValue = null,
            global::System.Func<global::Vellum.SearchResultsVellumValue?, TResult>? searchResultsVellumValue = null,
            global::System.Func<global::Vellum.ThinkingVellumValue?, TResult>? thinkingVellumValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringVellumValue && stringVellumValue != null)
            {
                return stringVellumValue(StringVellumValue!);
            }
            else if (IsNumberVellumValue && numberVellumValue != null)
            {
                return numberVellumValue(NumberVellumValue!);
            }
            else if (IsJsonVellumValue && jsonVellumValue != null)
            {
                return jsonVellumValue(JsonVellumValue!);
            }
            else if (IsAudioVellumValue && audioVellumValue != null)
            {
                return audioVellumValue(AudioVellumValue!);
            }
            else if (IsVideoVellumValue && videoVellumValue != null)
            {
                return videoVellumValue(VideoVellumValue!);
            }
            else if (IsImageVellumValue && imageVellumValue != null)
            {
                return imageVellumValue(ImageVellumValue!);
            }
            else if (IsDocumentVellumValue && documentVellumValue != null)
            {
                return documentVellumValue(DocumentVellumValue!);
            }
            else if (IsFunctionCallVellumValue && functionCallVellumValue != null)
            {
                return functionCallVellumValue(FunctionCallVellumValue!);
            }
            else if (IsErrorVellumValue && errorVellumValue != null)
            {
                return errorVellumValue(ErrorVellumValue!);
            }
            else if (IsArrayVellumValue && arrayVellumValue != null)
            {
                return arrayVellumValue(ArrayVellumValue!);
            }
            else if (IsChatHistoryVellumValue && chatHistoryVellumValue != null)
            {
                return chatHistoryVellumValue(ChatHistoryVellumValue!);
            }
            else if (IsSearchResultsVellumValue && searchResultsVellumValue != null)
            {
                return searchResultsVellumValue(SearchResultsVellumValue!);
            }
            else if (IsThinkingVellumValue && thinkingVellumValue != null)
            {
                return thinkingVellumValue(ThinkingVellumValue!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.StringVellumValue?>? stringVellumValue = null,
            global::System.Action<global::Vellum.NumberVellumValue?>? numberVellumValue = null,
            global::System.Action<global::Vellum.JsonVellumValue?>? jsonVellumValue = null,
            global::System.Action<global::Vellum.AudioVellumValue?>? audioVellumValue = null,
            global::System.Action<global::Vellum.VideoVellumValue?>? videoVellumValue = null,
            global::System.Action<global::Vellum.ImageVellumValue?>? imageVellumValue = null,
            global::System.Action<global::Vellum.DocumentVellumValue?>? documentVellumValue = null,
            global::System.Action<global::Vellum.FunctionCallVellumValue?>? functionCallVellumValue = null,
            global::System.Action<global::Vellum.ErrorVellumValue?>? errorVellumValue = null,
            global::System.Action<global::Vellum.ArrayVellumValue?>? arrayVellumValue = null,
            global::System.Action<global::Vellum.ChatHistoryVellumValue?>? chatHistoryVellumValue = null,
            global::System.Action<global::Vellum.SearchResultsVellumValue?>? searchResultsVellumValue = null,
            global::System.Action<global::Vellum.ThinkingVellumValue?>? thinkingVellumValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringVellumValue)
            {
                stringVellumValue?.Invoke(StringVellumValue!);
            }
            else if (IsNumberVellumValue)
            {
                numberVellumValue?.Invoke(NumberVellumValue!);
            }
            else if (IsJsonVellumValue)
            {
                jsonVellumValue?.Invoke(JsonVellumValue!);
            }
            else if (IsAudioVellumValue)
            {
                audioVellumValue?.Invoke(AudioVellumValue!);
            }
            else if (IsVideoVellumValue)
            {
                videoVellumValue?.Invoke(VideoVellumValue!);
            }
            else if (IsImageVellumValue)
            {
                imageVellumValue?.Invoke(ImageVellumValue!);
            }
            else if (IsDocumentVellumValue)
            {
                documentVellumValue?.Invoke(DocumentVellumValue!);
            }
            else if (IsFunctionCallVellumValue)
            {
                functionCallVellumValue?.Invoke(FunctionCallVellumValue!);
            }
            else if (IsErrorVellumValue)
            {
                errorVellumValue?.Invoke(ErrorVellumValue!);
            }
            else if (IsArrayVellumValue)
            {
                arrayVellumValue?.Invoke(ArrayVellumValue!);
            }
            else if (IsChatHistoryVellumValue)
            {
                chatHistoryVellumValue?.Invoke(ChatHistoryVellumValue!);
            }
            else if (IsSearchResultsVellumValue)
            {
                searchResultsVellumValue?.Invoke(SearchResultsVellumValue!);
            }
            else if (IsThinkingVellumValue)
            {
                thinkingVellumValue?.Invoke(ThinkingVellumValue!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StringVellumValue,
                typeof(global::Vellum.StringVellumValue),
                NumberVellumValue,
                typeof(global::Vellum.NumberVellumValue),
                JsonVellumValue,
                typeof(global::Vellum.JsonVellumValue),
                AudioVellumValue,
                typeof(global::Vellum.AudioVellumValue),
                VideoVellumValue,
                typeof(global::Vellum.VideoVellumValue),
                ImageVellumValue,
                typeof(global::Vellum.ImageVellumValue),
                DocumentVellumValue,
                typeof(global::Vellum.DocumentVellumValue),
                FunctionCallVellumValue,
                typeof(global::Vellum.FunctionCallVellumValue),
                ErrorVellumValue,
                typeof(global::Vellum.ErrorVellumValue),
                ArrayVellumValue,
                typeof(global::Vellum.ArrayVellumValue),
                ChatHistoryVellumValue,
                typeof(global::Vellum.ChatHistoryVellumValue),
                SearchResultsVellumValue,
                typeof(global::Vellum.SearchResultsVellumValue),
                ThinkingVellumValue,
                typeof(global::Vellum.ThinkingVellumValue),
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
        public bool Equals(VellumValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.StringVellumValue?>.Default.Equals(StringVellumValue, other.StringVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NumberVellumValue?>.Default.Equals(NumberVellumValue, other.NumberVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.JsonVellumValue?>.Default.Equals(JsonVellumValue, other.JsonVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.AudioVellumValue?>.Default.Equals(AudioVellumValue, other.AudioVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.VideoVellumValue?>.Default.Equals(VideoVellumValue, other.VideoVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ImageVellumValue?>.Default.Equals(ImageVellumValue, other.ImageVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.DocumentVellumValue?>.Default.Equals(DocumentVellumValue, other.DocumentVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.FunctionCallVellumValue?>.Default.Equals(FunctionCallVellumValue, other.FunctionCallVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ErrorVellumValue?>.Default.Equals(ErrorVellumValue, other.ErrorVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ArrayVellumValue?>.Default.Equals(ArrayVellumValue, other.ArrayVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ChatHistoryVellumValue?>.Default.Equals(ChatHistoryVellumValue, other.ChatHistoryVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.SearchResultsVellumValue?>.Default.Equals(SearchResultsVellumValue, other.SearchResultsVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ThinkingVellumValue?>.Default.Equals(ThinkingVellumValue, other.ThinkingVellumValue) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VellumValue obj1, VellumValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VellumValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VellumValue obj1, VellumValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VellumValue o && Equals(o);
        }
    }
}
