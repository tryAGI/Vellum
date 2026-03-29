#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ExecutionVellumValue : global::System.IEquatable<ExecutionVellumValue>
    {
        /// <summary>
        /// A value representing a string.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ExecutionStringVellumValue? ExecutionStringVellumValue { get; init; }
#else
        public global::Vellum.ExecutionStringVellumValue? ExecutionStringVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExecutionStringVellumValue))]
#endif
        public bool IsExecutionStringVellumValue => ExecutionStringVellumValue != null;

        /// <summary>
        /// A value representing a number.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ExecutionNumberVellumValue? ExecutionNumberVellumValue { get; init; }
#else
        public global::Vellum.ExecutionNumberVellumValue? ExecutionNumberVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExecutionNumberVellumValue))]
#endif
        public bool IsExecutionNumberVellumValue => ExecutionNumberVellumValue != null;

        /// <summary>
        /// A value representing a JSON object.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ExecutionJsonVellumValue? ExecutionJsonVellumValue { get; init; }
#else
        public global::Vellum.ExecutionJsonVellumValue? ExecutionJsonVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExecutionJsonVellumValue))]
#endif
        public bool IsExecutionJsonVellumValue => ExecutionJsonVellumValue != null;

        /// <summary>
        /// A value representing Chat History.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ExecutionChatHistoryVellumValue? ExecutionChatHistoryVellumValue { get; init; }
#else
        public global::Vellum.ExecutionChatHistoryVellumValue? ExecutionChatHistoryVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExecutionChatHistoryVellumValue))]
#endif
        public bool IsExecutionChatHistoryVellumValue => ExecutionChatHistoryVellumValue != null;

        /// <summary>
        /// A value representing Search Results.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ExecutionSearchResultsVellumValue? ExecutionSearchResultsVellumValue { get; init; }
#else
        public global::Vellum.ExecutionSearchResultsVellumValue? ExecutionSearchResultsVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExecutionSearchResultsVellumValue))]
#endif
        public bool IsExecutionSearchResultsVellumValue => ExecutionSearchResultsVellumValue != null;

        /// <summary>
        /// A value representing an Error.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ExecutionErrorVellumValue? ExecutionErrorVellumValue { get; init; }
#else
        public global::Vellum.ExecutionErrorVellumValue? ExecutionErrorVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExecutionErrorVellumValue))]
#endif
        public bool IsExecutionErrorVellumValue => ExecutionErrorVellumValue != null;

        /// <summary>
        /// A value representing an array of Vellum variable values.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ExecutionArrayVellumValue? ExecutionArrayVellumValue { get; init; }
#else
        public global::Vellum.ExecutionArrayVellumValue? ExecutionArrayVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExecutionArrayVellumValue))]
#endif
        public bool IsExecutionArrayVellumValue => ExecutionArrayVellumValue != null;

        /// <summary>
        /// A value representing a Function Call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ExecutionFunctionCallVellumValue? ExecutionFunctionCallVellumValue { get; init; }
#else
        public global::Vellum.ExecutionFunctionCallVellumValue? ExecutionFunctionCallVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExecutionFunctionCallVellumValue))]
#endif
        public bool IsExecutionFunctionCallVellumValue => ExecutionFunctionCallVellumValue != null;

        /// <summary>
        /// A value representing Thinking mode output.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ExecutionThinkingVellumValue? ExecutionThinkingVellumValue { get; init; }
#else
        public global::Vellum.ExecutionThinkingVellumValue? ExecutionThinkingVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExecutionThinkingVellumValue))]
#endif
        public bool IsExecutionThinkingVellumValue => ExecutionThinkingVellumValue != null;

        /// <summary>
        /// A base Vellum primitive value representing audio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ExecutionAudioVellumValue? ExecutionAudioVellumValue { get; init; }
#else
        public global::Vellum.ExecutionAudioVellumValue? ExecutionAudioVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExecutionAudioVellumValue))]
#endif
        public bool IsExecutionAudioVellumValue => ExecutionAudioVellumValue != null;

        /// <summary>
        /// A base Vellum primitive value representing a video.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ExecutionVideoVellumValue? ExecutionVideoVellumValue { get; init; }
#else
        public global::Vellum.ExecutionVideoVellumValue? ExecutionVideoVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExecutionVideoVellumValue))]
#endif
        public bool IsExecutionVideoVellumValue => ExecutionVideoVellumValue != null;

        /// <summary>
        /// A base Vellum primitive value representing an image.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ExecutionImageVellumValue? ExecutionImageVellumValue { get; init; }
#else
        public global::Vellum.ExecutionImageVellumValue? ExecutionImageVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExecutionImageVellumValue))]
#endif
        public bool IsExecutionImageVellumValue => ExecutionImageVellumValue != null;

        /// <summary>
        /// A base Vellum primitive value representing a document.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ExecutionDocumentVellumValue? ExecutionDocumentVellumValue { get; init; }
#else
        public global::Vellum.ExecutionDocumentVellumValue? ExecutionDocumentVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExecutionDocumentVellumValue))]
#endif
        public bool IsExecutionDocumentVellumValue => ExecutionDocumentVellumValue != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecutionVellumValue(global::Vellum.ExecutionStringVellumValue value) => new ExecutionVellumValue((global::Vellum.ExecutionStringVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ExecutionStringVellumValue?(ExecutionVellumValue @this) => @this.ExecutionStringVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public ExecutionVellumValue(global::Vellum.ExecutionStringVellumValue? value)
        {
            ExecutionStringVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecutionVellumValue(global::Vellum.ExecutionNumberVellumValue value) => new ExecutionVellumValue((global::Vellum.ExecutionNumberVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ExecutionNumberVellumValue?(ExecutionVellumValue @this) => @this.ExecutionNumberVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public ExecutionVellumValue(global::Vellum.ExecutionNumberVellumValue? value)
        {
            ExecutionNumberVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecutionVellumValue(global::Vellum.ExecutionJsonVellumValue value) => new ExecutionVellumValue((global::Vellum.ExecutionJsonVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ExecutionJsonVellumValue?(ExecutionVellumValue @this) => @this.ExecutionJsonVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public ExecutionVellumValue(global::Vellum.ExecutionJsonVellumValue? value)
        {
            ExecutionJsonVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecutionVellumValue(global::Vellum.ExecutionChatHistoryVellumValue value) => new ExecutionVellumValue((global::Vellum.ExecutionChatHistoryVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ExecutionChatHistoryVellumValue?(ExecutionVellumValue @this) => @this.ExecutionChatHistoryVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public ExecutionVellumValue(global::Vellum.ExecutionChatHistoryVellumValue? value)
        {
            ExecutionChatHistoryVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecutionVellumValue(global::Vellum.ExecutionSearchResultsVellumValue value) => new ExecutionVellumValue((global::Vellum.ExecutionSearchResultsVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ExecutionSearchResultsVellumValue?(ExecutionVellumValue @this) => @this.ExecutionSearchResultsVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public ExecutionVellumValue(global::Vellum.ExecutionSearchResultsVellumValue? value)
        {
            ExecutionSearchResultsVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecutionVellumValue(global::Vellum.ExecutionErrorVellumValue value) => new ExecutionVellumValue((global::Vellum.ExecutionErrorVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ExecutionErrorVellumValue?(ExecutionVellumValue @this) => @this.ExecutionErrorVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public ExecutionVellumValue(global::Vellum.ExecutionErrorVellumValue? value)
        {
            ExecutionErrorVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecutionVellumValue(global::Vellum.ExecutionArrayVellumValue value) => new ExecutionVellumValue((global::Vellum.ExecutionArrayVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ExecutionArrayVellumValue?(ExecutionVellumValue @this) => @this.ExecutionArrayVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public ExecutionVellumValue(global::Vellum.ExecutionArrayVellumValue? value)
        {
            ExecutionArrayVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecutionVellumValue(global::Vellum.ExecutionFunctionCallVellumValue value) => new ExecutionVellumValue((global::Vellum.ExecutionFunctionCallVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ExecutionFunctionCallVellumValue?(ExecutionVellumValue @this) => @this.ExecutionFunctionCallVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public ExecutionVellumValue(global::Vellum.ExecutionFunctionCallVellumValue? value)
        {
            ExecutionFunctionCallVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecutionVellumValue(global::Vellum.ExecutionThinkingVellumValue value) => new ExecutionVellumValue((global::Vellum.ExecutionThinkingVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ExecutionThinkingVellumValue?(ExecutionVellumValue @this) => @this.ExecutionThinkingVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public ExecutionVellumValue(global::Vellum.ExecutionThinkingVellumValue? value)
        {
            ExecutionThinkingVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecutionVellumValue(global::Vellum.ExecutionAudioVellumValue value) => new ExecutionVellumValue((global::Vellum.ExecutionAudioVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ExecutionAudioVellumValue?(ExecutionVellumValue @this) => @this.ExecutionAudioVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public ExecutionVellumValue(global::Vellum.ExecutionAudioVellumValue? value)
        {
            ExecutionAudioVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecutionVellumValue(global::Vellum.ExecutionVideoVellumValue value) => new ExecutionVellumValue((global::Vellum.ExecutionVideoVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ExecutionVideoVellumValue?(ExecutionVellumValue @this) => @this.ExecutionVideoVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public ExecutionVellumValue(global::Vellum.ExecutionVideoVellumValue? value)
        {
            ExecutionVideoVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecutionVellumValue(global::Vellum.ExecutionImageVellumValue value) => new ExecutionVellumValue((global::Vellum.ExecutionImageVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ExecutionImageVellumValue?(ExecutionVellumValue @this) => @this.ExecutionImageVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public ExecutionVellumValue(global::Vellum.ExecutionImageVellumValue? value)
        {
            ExecutionImageVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecutionVellumValue(global::Vellum.ExecutionDocumentVellumValue value) => new ExecutionVellumValue((global::Vellum.ExecutionDocumentVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ExecutionDocumentVellumValue?(ExecutionVellumValue @this) => @this.ExecutionDocumentVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public ExecutionVellumValue(global::Vellum.ExecutionDocumentVellumValue? value)
        {
            ExecutionDocumentVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ExecutionVellumValue(
            global::Vellum.ExecutionStringVellumValue? executionStringVellumValue,
            global::Vellum.ExecutionNumberVellumValue? executionNumberVellumValue,
            global::Vellum.ExecutionJsonVellumValue? executionJsonVellumValue,
            global::Vellum.ExecutionChatHistoryVellumValue? executionChatHistoryVellumValue,
            global::Vellum.ExecutionSearchResultsVellumValue? executionSearchResultsVellumValue,
            global::Vellum.ExecutionErrorVellumValue? executionErrorVellumValue,
            global::Vellum.ExecutionArrayVellumValue? executionArrayVellumValue,
            global::Vellum.ExecutionFunctionCallVellumValue? executionFunctionCallVellumValue,
            global::Vellum.ExecutionThinkingVellumValue? executionThinkingVellumValue,
            global::Vellum.ExecutionAudioVellumValue? executionAudioVellumValue,
            global::Vellum.ExecutionVideoVellumValue? executionVideoVellumValue,
            global::Vellum.ExecutionImageVellumValue? executionImageVellumValue,
            global::Vellum.ExecutionDocumentVellumValue? executionDocumentVellumValue
            )
        {
            ExecutionStringVellumValue = executionStringVellumValue;
            ExecutionNumberVellumValue = executionNumberVellumValue;
            ExecutionJsonVellumValue = executionJsonVellumValue;
            ExecutionChatHistoryVellumValue = executionChatHistoryVellumValue;
            ExecutionSearchResultsVellumValue = executionSearchResultsVellumValue;
            ExecutionErrorVellumValue = executionErrorVellumValue;
            ExecutionArrayVellumValue = executionArrayVellumValue;
            ExecutionFunctionCallVellumValue = executionFunctionCallVellumValue;
            ExecutionThinkingVellumValue = executionThinkingVellumValue;
            ExecutionAudioVellumValue = executionAudioVellumValue;
            ExecutionVideoVellumValue = executionVideoVellumValue;
            ExecutionImageVellumValue = executionImageVellumValue;
            ExecutionDocumentVellumValue = executionDocumentVellumValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ExecutionDocumentVellumValue as object ??
            ExecutionImageVellumValue as object ??
            ExecutionVideoVellumValue as object ??
            ExecutionAudioVellumValue as object ??
            ExecutionThinkingVellumValue as object ??
            ExecutionFunctionCallVellumValue as object ??
            ExecutionArrayVellumValue as object ??
            ExecutionErrorVellumValue as object ??
            ExecutionSearchResultsVellumValue as object ??
            ExecutionChatHistoryVellumValue as object ??
            ExecutionJsonVellumValue as object ??
            ExecutionNumberVellumValue as object ??
            ExecutionStringVellumValue as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ExecutionStringVellumValue?.ToString() ??
            ExecutionNumberVellumValue?.ToString() ??
            ExecutionJsonVellumValue?.ToString() ??
            ExecutionChatHistoryVellumValue?.ToString() ??
            ExecutionSearchResultsVellumValue?.ToString() ??
            ExecutionErrorVellumValue?.ToString() ??
            ExecutionArrayVellumValue?.ToString() ??
            ExecutionFunctionCallVellumValue?.ToString() ??
            ExecutionThinkingVellumValue?.ToString() ??
            ExecutionAudioVellumValue?.ToString() ??
            ExecutionVideoVellumValue?.ToString() ??
            ExecutionImageVellumValue?.ToString() ??
            ExecutionDocumentVellumValue?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsExecutionStringVellumValue && !IsExecutionNumberVellumValue && !IsExecutionJsonVellumValue && !IsExecutionChatHistoryVellumValue && !IsExecutionSearchResultsVellumValue && !IsExecutionErrorVellumValue && !IsExecutionArrayVellumValue && !IsExecutionFunctionCallVellumValue && !IsExecutionThinkingVellumValue && !IsExecutionAudioVellumValue && !IsExecutionVideoVellumValue && !IsExecutionImageVellumValue && !IsExecutionDocumentVellumValue || !IsExecutionStringVellumValue && IsExecutionNumberVellumValue && !IsExecutionJsonVellumValue && !IsExecutionChatHistoryVellumValue && !IsExecutionSearchResultsVellumValue && !IsExecutionErrorVellumValue && !IsExecutionArrayVellumValue && !IsExecutionFunctionCallVellumValue && !IsExecutionThinkingVellumValue && !IsExecutionAudioVellumValue && !IsExecutionVideoVellumValue && !IsExecutionImageVellumValue && !IsExecutionDocumentVellumValue || !IsExecutionStringVellumValue && !IsExecutionNumberVellumValue && IsExecutionJsonVellumValue && !IsExecutionChatHistoryVellumValue && !IsExecutionSearchResultsVellumValue && !IsExecutionErrorVellumValue && !IsExecutionArrayVellumValue && !IsExecutionFunctionCallVellumValue && !IsExecutionThinkingVellumValue && !IsExecutionAudioVellumValue && !IsExecutionVideoVellumValue && !IsExecutionImageVellumValue && !IsExecutionDocumentVellumValue || !IsExecutionStringVellumValue && !IsExecutionNumberVellumValue && !IsExecutionJsonVellumValue && IsExecutionChatHistoryVellumValue && !IsExecutionSearchResultsVellumValue && !IsExecutionErrorVellumValue && !IsExecutionArrayVellumValue && !IsExecutionFunctionCallVellumValue && !IsExecutionThinkingVellumValue && !IsExecutionAudioVellumValue && !IsExecutionVideoVellumValue && !IsExecutionImageVellumValue && !IsExecutionDocumentVellumValue || !IsExecutionStringVellumValue && !IsExecutionNumberVellumValue && !IsExecutionJsonVellumValue && !IsExecutionChatHistoryVellumValue && IsExecutionSearchResultsVellumValue && !IsExecutionErrorVellumValue && !IsExecutionArrayVellumValue && !IsExecutionFunctionCallVellumValue && !IsExecutionThinkingVellumValue && !IsExecutionAudioVellumValue && !IsExecutionVideoVellumValue && !IsExecutionImageVellumValue && !IsExecutionDocumentVellumValue || !IsExecutionStringVellumValue && !IsExecutionNumberVellumValue && !IsExecutionJsonVellumValue && !IsExecutionChatHistoryVellumValue && !IsExecutionSearchResultsVellumValue && IsExecutionErrorVellumValue && !IsExecutionArrayVellumValue && !IsExecutionFunctionCallVellumValue && !IsExecutionThinkingVellumValue && !IsExecutionAudioVellumValue && !IsExecutionVideoVellumValue && !IsExecutionImageVellumValue && !IsExecutionDocumentVellumValue || !IsExecutionStringVellumValue && !IsExecutionNumberVellumValue && !IsExecutionJsonVellumValue && !IsExecutionChatHistoryVellumValue && !IsExecutionSearchResultsVellumValue && !IsExecutionErrorVellumValue && IsExecutionArrayVellumValue && !IsExecutionFunctionCallVellumValue && !IsExecutionThinkingVellumValue && !IsExecutionAudioVellumValue && !IsExecutionVideoVellumValue && !IsExecutionImageVellumValue && !IsExecutionDocumentVellumValue || !IsExecutionStringVellumValue && !IsExecutionNumberVellumValue && !IsExecutionJsonVellumValue && !IsExecutionChatHistoryVellumValue && !IsExecutionSearchResultsVellumValue && !IsExecutionErrorVellumValue && !IsExecutionArrayVellumValue && IsExecutionFunctionCallVellumValue && !IsExecutionThinkingVellumValue && !IsExecutionAudioVellumValue && !IsExecutionVideoVellumValue && !IsExecutionImageVellumValue && !IsExecutionDocumentVellumValue || !IsExecutionStringVellumValue && !IsExecutionNumberVellumValue && !IsExecutionJsonVellumValue && !IsExecutionChatHistoryVellumValue && !IsExecutionSearchResultsVellumValue && !IsExecutionErrorVellumValue && !IsExecutionArrayVellumValue && !IsExecutionFunctionCallVellumValue && IsExecutionThinkingVellumValue && !IsExecutionAudioVellumValue && !IsExecutionVideoVellumValue && !IsExecutionImageVellumValue && !IsExecutionDocumentVellumValue || !IsExecutionStringVellumValue && !IsExecutionNumberVellumValue && !IsExecutionJsonVellumValue && !IsExecutionChatHistoryVellumValue && !IsExecutionSearchResultsVellumValue && !IsExecutionErrorVellumValue && !IsExecutionArrayVellumValue && !IsExecutionFunctionCallVellumValue && !IsExecutionThinkingVellumValue && IsExecutionAudioVellumValue && !IsExecutionVideoVellumValue && !IsExecutionImageVellumValue && !IsExecutionDocumentVellumValue || !IsExecutionStringVellumValue && !IsExecutionNumberVellumValue && !IsExecutionJsonVellumValue && !IsExecutionChatHistoryVellumValue && !IsExecutionSearchResultsVellumValue && !IsExecutionErrorVellumValue && !IsExecutionArrayVellumValue && !IsExecutionFunctionCallVellumValue && !IsExecutionThinkingVellumValue && !IsExecutionAudioVellumValue && IsExecutionVideoVellumValue && !IsExecutionImageVellumValue && !IsExecutionDocumentVellumValue || !IsExecutionStringVellumValue && !IsExecutionNumberVellumValue && !IsExecutionJsonVellumValue && !IsExecutionChatHistoryVellumValue && !IsExecutionSearchResultsVellumValue && !IsExecutionErrorVellumValue && !IsExecutionArrayVellumValue && !IsExecutionFunctionCallVellumValue && !IsExecutionThinkingVellumValue && !IsExecutionAudioVellumValue && !IsExecutionVideoVellumValue && IsExecutionImageVellumValue && !IsExecutionDocumentVellumValue || !IsExecutionStringVellumValue && !IsExecutionNumberVellumValue && !IsExecutionJsonVellumValue && !IsExecutionChatHistoryVellumValue && !IsExecutionSearchResultsVellumValue && !IsExecutionErrorVellumValue && !IsExecutionArrayVellumValue && !IsExecutionFunctionCallVellumValue && !IsExecutionThinkingVellumValue && !IsExecutionAudioVellumValue && !IsExecutionVideoVellumValue && !IsExecutionImageVellumValue && IsExecutionDocumentVellumValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.ExecutionStringVellumValue?, TResult>? executionStringVellumValue = null,
            global::System.Func<global::Vellum.ExecutionNumberVellumValue?, TResult>? executionNumberVellumValue = null,
            global::System.Func<global::Vellum.ExecutionJsonVellumValue?, TResult>? executionJsonVellumValue = null,
            global::System.Func<global::Vellum.ExecutionChatHistoryVellumValue?, TResult>? executionChatHistoryVellumValue = null,
            global::System.Func<global::Vellum.ExecutionSearchResultsVellumValue?, TResult>? executionSearchResultsVellumValue = null,
            global::System.Func<global::Vellum.ExecutionErrorVellumValue?, TResult>? executionErrorVellumValue = null,
            global::System.Func<global::Vellum.ExecutionArrayVellumValue?, TResult>? executionArrayVellumValue = null,
            global::System.Func<global::Vellum.ExecutionFunctionCallVellumValue?, TResult>? executionFunctionCallVellumValue = null,
            global::System.Func<global::Vellum.ExecutionThinkingVellumValue?, TResult>? executionThinkingVellumValue = null,
            global::System.Func<global::Vellum.ExecutionAudioVellumValue?, TResult>? executionAudioVellumValue = null,
            global::System.Func<global::Vellum.ExecutionVideoVellumValue?, TResult>? executionVideoVellumValue = null,
            global::System.Func<global::Vellum.ExecutionImageVellumValue?, TResult>? executionImageVellumValue = null,
            global::System.Func<global::Vellum.ExecutionDocumentVellumValue?, TResult>? executionDocumentVellumValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsExecutionStringVellumValue && executionStringVellumValue != null)
            {
                return executionStringVellumValue(ExecutionStringVellumValue!);
            }
            else if (IsExecutionNumberVellumValue && executionNumberVellumValue != null)
            {
                return executionNumberVellumValue(ExecutionNumberVellumValue!);
            }
            else if (IsExecutionJsonVellumValue && executionJsonVellumValue != null)
            {
                return executionJsonVellumValue(ExecutionJsonVellumValue!);
            }
            else if (IsExecutionChatHistoryVellumValue && executionChatHistoryVellumValue != null)
            {
                return executionChatHistoryVellumValue(ExecutionChatHistoryVellumValue!);
            }
            else if (IsExecutionSearchResultsVellumValue && executionSearchResultsVellumValue != null)
            {
                return executionSearchResultsVellumValue(ExecutionSearchResultsVellumValue!);
            }
            else if (IsExecutionErrorVellumValue && executionErrorVellumValue != null)
            {
                return executionErrorVellumValue(ExecutionErrorVellumValue!);
            }
            else if (IsExecutionArrayVellumValue && executionArrayVellumValue != null)
            {
                return executionArrayVellumValue(ExecutionArrayVellumValue!);
            }
            else if (IsExecutionFunctionCallVellumValue && executionFunctionCallVellumValue != null)
            {
                return executionFunctionCallVellumValue(ExecutionFunctionCallVellumValue!);
            }
            else if (IsExecutionThinkingVellumValue && executionThinkingVellumValue != null)
            {
                return executionThinkingVellumValue(ExecutionThinkingVellumValue!);
            }
            else if (IsExecutionAudioVellumValue && executionAudioVellumValue != null)
            {
                return executionAudioVellumValue(ExecutionAudioVellumValue!);
            }
            else if (IsExecutionVideoVellumValue && executionVideoVellumValue != null)
            {
                return executionVideoVellumValue(ExecutionVideoVellumValue!);
            }
            else if (IsExecutionImageVellumValue && executionImageVellumValue != null)
            {
                return executionImageVellumValue(ExecutionImageVellumValue!);
            }
            else if (IsExecutionDocumentVellumValue && executionDocumentVellumValue != null)
            {
                return executionDocumentVellumValue(ExecutionDocumentVellumValue!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.ExecutionStringVellumValue?>? executionStringVellumValue = null,
            global::System.Action<global::Vellum.ExecutionNumberVellumValue?>? executionNumberVellumValue = null,
            global::System.Action<global::Vellum.ExecutionJsonVellumValue?>? executionJsonVellumValue = null,
            global::System.Action<global::Vellum.ExecutionChatHistoryVellumValue?>? executionChatHistoryVellumValue = null,
            global::System.Action<global::Vellum.ExecutionSearchResultsVellumValue?>? executionSearchResultsVellumValue = null,
            global::System.Action<global::Vellum.ExecutionErrorVellumValue?>? executionErrorVellumValue = null,
            global::System.Action<global::Vellum.ExecutionArrayVellumValue?>? executionArrayVellumValue = null,
            global::System.Action<global::Vellum.ExecutionFunctionCallVellumValue?>? executionFunctionCallVellumValue = null,
            global::System.Action<global::Vellum.ExecutionThinkingVellumValue?>? executionThinkingVellumValue = null,
            global::System.Action<global::Vellum.ExecutionAudioVellumValue?>? executionAudioVellumValue = null,
            global::System.Action<global::Vellum.ExecutionVideoVellumValue?>? executionVideoVellumValue = null,
            global::System.Action<global::Vellum.ExecutionImageVellumValue?>? executionImageVellumValue = null,
            global::System.Action<global::Vellum.ExecutionDocumentVellumValue?>? executionDocumentVellumValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsExecutionStringVellumValue)
            {
                executionStringVellumValue?.Invoke(ExecutionStringVellumValue!);
            }
            else if (IsExecutionNumberVellumValue)
            {
                executionNumberVellumValue?.Invoke(ExecutionNumberVellumValue!);
            }
            else if (IsExecutionJsonVellumValue)
            {
                executionJsonVellumValue?.Invoke(ExecutionJsonVellumValue!);
            }
            else if (IsExecutionChatHistoryVellumValue)
            {
                executionChatHistoryVellumValue?.Invoke(ExecutionChatHistoryVellumValue!);
            }
            else if (IsExecutionSearchResultsVellumValue)
            {
                executionSearchResultsVellumValue?.Invoke(ExecutionSearchResultsVellumValue!);
            }
            else if (IsExecutionErrorVellumValue)
            {
                executionErrorVellumValue?.Invoke(ExecutionErrorVellumValue!);
            }
            else if (IsExecutionArrayVellumValue)
            {
                executionArrayVellumValue?.Invoke(ExecutionArrayVellumValue!);
            }
            else if (IsExecutionFunctionCallVellumValue)
            {
                executionFunctionCallVellumValue?.Invoke(ExecutionFunctionCallVellumValue!);
            }
            else if (IsExecutionThinkingVellumValue)
            {
                executionThinkingVellumValue?.Invoke(ExecutionThinkingVellumValue!);
            }
            else if (IsExecutionAudioVellumValue)
            {
                executionAudioVellumValue?.Invoke(ExecutionAudioVellumValue!);
            }
            else if (IsExecutionVideoVellumValue)
            {
                executionVideoVellumValue?.Invoke(ExecutionVideoVellumValue!);
            }
            else if (IsExecutionImageVellumValue)
            {
                executionImageVellumValue?.Invoke(ExecutionImageVellumValue!);
            }
            else if (IsExecutionDocumentVellumValue)
            {
                executionDocumentVellumValue?.Invoke(ExecutionDocumentVellumValue!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ExecutionStringVellumValue,
                typeof(global::Vellum.ExecutionStringVellumValue),
                ExecutionNumberVellumValue,
                typeof(global::Vellum.ExecutionNumberVellumValue),
                ExecutionJsonVellumValue,
                typeof(global::Vellum.ExecutionJsonVellumValue),
                ExecutionChatHistoryVellumValue,
                typeof(global::Vellum.ExecutionChatHistoryVellumValue),
                ExecutionSearchResultsVellumValue,
                typeof(global::Vellum.ExecutionSearchResultsVellumValue),
                ExecutionErrorVellumValue,
                typeof(global::Vellum.ExecutionErrorVellumValue),
                ExecutionArrayVellumValue,
                typeof(global::Vellum.ExecutionArrayVellumValue),
                ExecutionFunctionCallVellumValue,
                typeof(global::Vellum.ExecutionFunctionCallVellumValue),
                ExecutionThinkingVellumValue,
                typeof(global::Vellum.ExecutionThinkingVellumValue),
                ExecutionAudioVellumValue,
                typeof(global::Vellum.ExecutionAudioVellumValue),
                ExecutionVideoVellumValue,
                typeof(global::Vellum.ExecutionVideoVellumValue),
                ExecutionImageVellumValue,
                typeof(global::Vellum.ExecutionImageVellumValue),
                ExecutionDocumentVellumValue,
                typeof(global::Vellum.ExecutionDocumentVellumValue),
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
        public bool Equals(ExecutionVellumValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ExecutionStringVellumValue?>.Default.Equals(ExecutionStringVellumValue, other.ExecutionStringVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ExecutionNumberVellumValue?>.Default.Equals(ExecutionNumberVellumValue, other.ExecutionNumberVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ExecutionJsonVellumValue?>.Default.Equals(ExecutionJsonVellumValue, other.ExecutionJsonVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ExecutionChatHistoryVellumValue?>.Default.Equals(ExecutionChatHistoryVellumValue, other.ExecutionChatHistoryVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ExecutionSearchResultsVellumValue?>.Default.Equals(ExecutionSearchResultsVellumValue, other.ExecutionSearchResultsVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ExecutionErrorVellumValue?>.Default.Equals(ExecutionErrorVellumValue, other.ExecutionErrorVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ExecutionArrayVellumValue?>.Default.Equals(ExecutionArrayVellumValue, other.ExecutionArrayVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ExecutionFunctionCallVellumValue?>.Default.Equals(ExecutionFunctionCallVellumValue, other.ExecutionFunctionCallVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ExecutionThinkingVellumValue?>.Default.Equals(ExecutionThinkingVellumValue, other.ExecutionThinkingVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ExecutionAudioVellumValue?>.Default.Equals(ExecutionAudioVellumValue, other.ExecutionAudioVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ExecutionVideoVellumValue?>.Default.Equals(ExecutionVideoVellumValue, other.ExecutionVideoVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ExecutionImageVellumValue?>.Default.Equals(ExecutionImageVellumValue, other.ExecutionImageVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ExecutionDocumentVellumValue?>.Default.Equals(ExecutionDocumentVellumValue, other.ExecutionDocumentVellumValue) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ExecutionVellumValue obj1, ExecutionVellumValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ExecutionVellumValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ExecutionVellumValue obj1, ExecutionVellumValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExecutionVellumValue o && Equals(o);
        }
    }
}
