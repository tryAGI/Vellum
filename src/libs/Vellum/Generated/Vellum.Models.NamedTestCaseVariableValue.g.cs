#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct NamedTestCaseVariableValue : global::System.IEquatable<NamedTestCaseVariableValue>
    {
        /// <summary>
        /// Named Test Case value that is of type STRING
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseStringVariableValue? NamedTestCaseStringVariableValue { get; init; }
#else
        public global::Vellum.NamedTestCaseStringVariableValue? NamedTestCaseStringVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseStringVariableValue))]
#endif
        public bool IsNamedTestCaseStringVariableValue => NamedTestCaseStringVariableValue != null;

        /// <summary>
        /// Named Test Case value that is of type NUMBER
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseNumberVariableValue? NamedTestCaseNumberVariableValue { get; init; }
#else
        public global::Vellum.NamedTestCaseNumberVariableValue? NamedTestCaseNumberVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseNumberVariableValue))]
#endif
        public bool IsNamedTestCaseNumberVariableValue => NamedTestCaseNumberVariableValue != null;

        /// <summary>
        /// Named Test Case value that is of type JSON
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseJsonVariableValue? NamedTestCaseJsonVariableValue { get; init; }
#else
        public global::Vellum.NamedTestCaseJsonVariableValue? NamedTestCaseJsonVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseJsonVariableValue))]
#endif
        public bool IsNamedTestCaseJsonVariableValue => NamedTestCaseJsonVariableValue != null;

        /// <summary>
        /// Named Test Case value that is of type CHAT_HISTORY
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseChatHistoryVariableValue? NamedTestCaseChatHistoryVariableValue { get; init; }
#else
        public global::Vellum.NamedTestCaseChatHistoryVariableValue? NamedTestCaseChatHistoryVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseChatHistoryVariableValue))]
#endif
        public bool IsNamedTestCaseChatHistoryVariableValue => NamedTestCaseChatHistoryVariableValue != null;

        /// <summary>
        /// Named Test Case value that is of type SEARCH_RESULTS
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseSearchResultsVariableValue? NamedTestCaseSearchResultsVariableValue { get; init; }
#else
        public global::Vellum.NamedTestCaseSearchResultsVariableValue? NamedTestCaseSearchResultsVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseSearchResultsVariableValue))]
#endif
        public bool IsNamedTestCaseSearchResultsVariableValue => NamedTestCaseSearchResultsVariableValue != null;

        /// <summary>
        /// Named Test Case value that is of type ERROR
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseErrorVariableValue? NamedTestCaseErrorVariableValue { get; init; }
#else
        public global::Vellum.NamedTestCaseErrorVariableValue? NamedTestCaseErrorVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseErrorVariableValue))]
#endif
        public bool IsNamedTestCaseErrorVariableValue => NamedTestCaseErrorVariableValue != null;

        /// <summary>
        /// Named Test Case value that is of type FUNCTION_CALL
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseFunctionCallVariableValue? NamedTestCaseFunctionCallVariableValue { get; init; }
#else
        public global::Vellum.NamedTestCaseFunctionCallVariableValue? NamedTestCaseFunctionCallVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseFunctionCallVariableValue))]
#endif
        public bool IsNamedTestCaseFunctionCallVariableValue => NamedTestCaseFunctionCallVariableValue != null;

        /// <summary>
        /// Named Test Case value that is of type ARRAY
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseArrayVariableValue? NamedTestCaseArrayVariableValue { get; init; }
#else
        public global::Vellum.NamedTestCaseArrayVariableValue? NamedTestCaseArrayVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseArrayVariableValue))]
#endif
        public bool IsNamedTestCaseArrayVariableValue => NamedTestCaseArrayVariableValue != null;

        /// <summary>
        /// Named Test Case value that is of type AUDIO
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseAudioVariableValue? NamedTestCaseAudioVariableValue { get; init; }
#else
        public global::Vellum.NamedTestCaseAudioVariableValue? NamedTestCaseAudioVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseAudioVariableValue))]
#endif
        public bool IsNamedTestCaseAudioVariableValue => NamedTestCaseAudioVariableValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseVideoVariableValue? NamedTestCaseVideoVariableValue { get; init; }
#else
        public global::Vellum.NamedTestCaseVideoVariableValue? NamedTestCaseVideoVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseVideoVariableValue))]
#endif
        public bool IsNamedTestCaseVideoVariableValue => NamedTestCaseVideoVariableValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseImageVariableValue? NamedTestCaseImageVariableValue { get; init; }
#else
        public global::Vellum.NamedTestCaseImageVariableValue? NamedTestCaseImageVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseImageVariableValue))]
#endif
        public bool IsNamedTestCaseImageVariableValue => NamedTestCaseImageVariableValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseDocumentVariableValue? NamedTestCaseDocumentVariableValue { get; init; }
#else
        public global::Vellum.NamedTestCaseDocumentVariableValue? NamedTestCaseDocumentVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseDocumentVariableValue))]
#endif
        public bool IsNamedTestCaseDocumentVariableValue => NamedTestCaseDocumentVariableValue != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValue(global::Vellum.NamedTestCaseStringVariableValue value) => new NamedTestCaseVariableValue((global::Vellum.NamedTestCaseStringVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseStringVariableValue?(NamedTestCaseVariableValue @this) => @this.NamedTestCaseStringVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValue(global::Vellum.NamedTestCaseStringVariableValue? value)
        {
            NamedTestCaseStringVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValue(global::Vellum.NamedTestCaseNumberVariableValue value) => new NamedTestCaseVariableValue((global::Vellum.NamedTestCaseNumberVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseNumberVariableValue?(NamedTestCaseVariableValue @this) => @this.NamedTestCaseNumberVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValue(global::Vellum.NamedTestCaseNumberVariableValue? value)
        {
            NamedTestCaseNumberVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValue(global::Vellum.NamedTestCaseJsonVariableValue value) => new NamedTestCaseVariableValue((global::Vellum.NamedTestCaseJsonVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseJsonVariableValue?(NamedTestCaseVariableValue @this) => @this.NamedTestCaseJsonVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValue(global::Vellum.NamedTestCaseJsonVariableValue? value)
        {
            NamedTestCaseJsonVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValue(global::Vellum.NamedTestCaseChatHistoryVariableValue value) => new NamedTestCaseVariableValue((global::Vellum.NamedTestCaseChatHistoryVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseChatHistoryVariableValue?(NamedTestCaseVariableValue @this) => @this.NamedTestCaseChatHistoryVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValue(global::Vellum.NamedTestCaseChatHistoryVariableValue? value)
        {
            NamedTestCaseChatHistoryVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValue(global::Vellum.NamedTestCaseSearchResultsVariableValue value) => new NamedTestCaseVariableValue((global::Vellum.NamedTestCaseSearchResultsVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseSearchResultsVariableValue?(NamedTestCaseVariableValue @this) => @this.NamedTestCaseSearchResultsVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValue(global::Vellum.NamedTestCaseSearchResultsVariableValue? value)
        {
            NamedTestCaseSearchResultsVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValue(global::Vellum.NamedTestCaseErrorVariableValue value) => new NamedTestCaseVariableValue((global::Vellum.NamedTestCaseErrorVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseErrorVariableValue?(NamedTestCaseVariableValue @this) => @this.NamedTestCaseErrorVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValue(global::Vellum.NamedTestCaseErrorVariableValue? value)
        {
            NamedTestCaseErrorVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValue(global::Vellum.NamedTestCaseFunctionCallVariableValue value) => new NamedTestCaseVariableValue((global::Vellum.NamedTestCaseFunctionCallVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseFunctionCallVariableValue?(NamedTestCaseVariableValue @this) => @this.NamedTestCaseFunctionCallVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValue(global::Vellum.NamedTestCaseFunctionCallVariableValue? value)
        {
            NamedTestCaseFunctionCallVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValue(global::Vellum.NamedTestCaseArrayVariableValue value) => new NamedTestCaseVariableValue((global::Vellum.NamedTestCaseArrayVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseArrayVariableValue?(NamedTestCaseVariableValue @this) => @this.NamedTestCaseArrayVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValue(global::Vellum.NamedTestCaseArrayVariableValue? value)
        {
            NamedTestCaseArrayVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValue(global::Vellum.NamedTestCaseAudioVariableValue value) => new NamedTestCaseVariableValue((global::Vellum.NamedTestCaseAudioVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseAudioVariableValue?(NamedTestCaseVariableValue @this) => @this.NamedTestCaseAudioVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValue(global::Vellum.NamedTestCaseAudioVariableValue? value)
        {
            NamedTestCaseAudioVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValue(global::Vellum.NamedTestCaseVideoVariableValue value) => new NamedTestCaseVariableValue((global::Vellum.NamedTestCaseVideoVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseVideoVariableValue?(NamedTestCaseVariableValue @this) => @this.NamedTestCaseVideoVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValue(global::Vellum.NamedTestCaseVideoVariableValue? value)
        {
            NamedTestCaseVideoVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValue(global::Vellum.NamedTestCaseImageVariableValue value) => new NamedTestCaseVariableValue((global::Vellum.NamedTestCaseImageVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseImageVariableValue?(NamedTestCaseVariableValue @this) => @this.NamedTestCaseImageVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValue(global::Vellum.NamedTestCaseImageVariableValue? value)
        {
            NamedTestCaseImageVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValue(global::Vellum.NamedTestCaseDocumentVariableValue value) => new NamedTestCaseVariableValue((global::Vellum.NamedTestCaseDocumentVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseDocumentVariableValue?(NamedTestCaseVariableValue @this) => @this.NamedTestCaseDocumentVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValue(global::Vellum.NamedTestCaseDocumentVariableValue? value)
        {
            NamedTestCaseDocumentVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValue(
            global::Vellum.NamedTestCaseStringVariableValue? namedTestCaseStringVariableValue,
            global::Vellum.NamedTestCaseNumberVariableValue? namedTestCaseNumberVariableValue,
            global::Vellum.NamedTestCaseJsonVariableValue? namedTestCaseJsonVariableValue,
            global::Vellum.NamedTestCaseChatHistoryVariableValue? namedTestCaseChatHistoryVariableValue,
            global::Vellum.NamedTestCaseSearchResultsVariableValue? namedTestCaseSearchResultsVariableValue,
            global::Vellum.NamedTestCaseErrorVariableValue? namedTestCaseErrorVariableValue,
            global::Vellum.NamedTestCaseFunctionCallVariableValue? namedTestCaseFunctionCallVariableValue,
            global::Vellum.NamedTestCaseArrayVariableValue? namedTestCaseArrayVariableValue,
            global::Vellum.NamedTestCaseAudioVariableValue? namedTestCaseAudioVariableValue,
            global::Vellum.NamedTestCaseVideoVariableValue? namedTestCaseVideoVariableValue,
            global::Vellum.NamedTestCaseImageVariableValue? namedTestCaseImageVariableValue,
            global::Vellum.NamedTestCaseDocumentVariableValue? namedTestCaseDocumentVariableValue
            )
        {
            NamedTestCaseStringVariableValue = namedTestCaseStringVariableValue;
            NamedTestCaseNumberVariableValue = namedTestCaseNumberVariableValue;
            NamedTestCaseJsonVariableValue = namedTestCaseJsonVariableValue;
            NamedTestCaseChatHistoryVariableValue = namedTestCaseChatHistoryVariableValue;
            NamedTestCaseSearchResultsVariableValue = namedTestCaseSearchResultsVariableValue;
            NamedTestCaseErrorVariableValue = namedTestCaseErrorVariableValue;
            NamedTestCaseFunctionCallVariableValue = namedTestCaseFunctionCallVariableValue;
            NamedTestCaseArrayVariableValue = namedTestCaseArrayVariableValue;
            NamedTestCaseAudioVariableValue = namedTestCaseAudioVariableValue;
            NamedTestCaseVideoVariableValue = namedTestCaseVideoVariableValue;
            NamedTestCaseImageVariableValue = namedTestCaseImageVariableValue;
            NamedTestCaseDocumentVariableValue = namedTestCaseDocumentVariableValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            NamedTestCaseDocumentVariableValue as object ??
            NamedTestCaseImageVariableValue as object ??
            NamedTestCaseVideoVariableValue as object ??
            NamedTestCaseAudioVariableValue as object ??
            NamedTestCaseArrayVariableValue as object ??
            NamedTestCaseFunctionCallVariableValue as object ??
            NamedTestCaseErrorVariableValue as object ??
            NamedTestCaseSearchResultsVariableValue as object ??
            NamedTestCaseChatHistoryVariableValue as object ??
            NamedTestCaseJsonVariableValue as object ??
            NamedTestCaseNumberVariableValue as object ??
            NamedTestCaseStringVariableValue as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            NamedTestCaseStringVariableValue?.ToString() ??
            NamedTestCaseNumberVariableValue?.ToString() ??
            NamedTestCaseJsonVariableValue?.ToString() ??
            NamedTestCaseChatHistoryVariableValue?.ToString() ??
            NamedTestCaseSearchResultsVariableValue?.ToString() ??
            NamedTestCaseErrorVariableValue?.ToString() ??
            NamedTestCaseFunctionCallVariableValue?.ToString() ??
            NamedTestCaseArrayVariableValue?.ToString() ??
            NamedTestCaseAudioVariableValue?.ToString() ??
            NamedTestCaseVideoVariableValue?.ToString() ??
            NamedTestCaseImageVariableValue?.ToString() ??
            NamedTestCaseDocumentVariableValue?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNamedTestCaseStringVariableValue && !IsNamedTestCaseNumberVariableValue && !IsNamedTestCaseJsonVariableValue && !IsNamedTestCaseChatHistoryVariableValue && !IsNamedTestCaseSearchResultsVariableValue && !IsNamedTestCaseErrorVariableValue && !IsNamedTestCaseFunctionCallVariableValue && !IsNamedTestCaseArrayVariableValue && !IsNamedTestCaseAudioVariableValue && !IsNamedTestCaseVideoVariableValue && !IsNamedTestCaseImageVariableValue && !IsNamedTestCaseDocumentVariableValue || !IsNamedTestCaseStringVariableValue && IsNamedTestCaseNumberVariableValue && !IsNamedTestCaseJsonVariableValue && !IsNamedTestCaseChatHistoryVariableValue && !IsNamedTestCaseSearchResultsVariableValue && !IsNamedTestCaseErrorVariableValue && !IsNamedTestCaseFunctionCallVariableValue && !IsNamedTestCaseArrayVariableValue && !IsNamedTestCaseAudioVariableValue && !IsNamedTestCaseVideoVariableValue && !IsNamedTestCaseImageVariableValue && !IsNamedTestCaseDocumentVariableValue || !IsNamedTestCaseStringVariableValue && !IsNamedTestCaseNumberVariableValue && IsNamedTestCaseJsonVariableValue && !IsNamedTestCaseChatHistoryVariableValue && !IsNamedTestCaseSearchResultsVariableValue && !IsNamedTestCaseErrorVariableValue && !IsNamedTestCaseFunctionCallVariableValue && !IsNamedTestCaseArrayVariableValue && !IsNamedTestCaseAudioVariableValue && !IsNamedTestCaseVideoVariableValue && !IsNamedTestCaseImageVariableValue && !IsNamedTestCaseDocumentVariableValue || !IsNamedTestCaseStringVariableValue && !IsNamedTestCaseNumberVariableValue && !IsNamedTestCaseJsonVariableValue && IsNamedTestCaseChatHistoryVariableValue && !IsNamedTestCaseSearchResultsVariableValue && !IsNamedTestCaseErrorVariableValue && !IsNamedTestCaseFunctionCallVariableValue && !IsNamedTestCaseArrayVariableValue && !IsNamedTestCaseAudioVariableValue && !IsNamedTestCaseVideoVariableValue && !IsNamedTestCaseImageVariableValue && !IsNamedTestCaseDocumentVariableValue || !IsNamedTestCaseStringVariableValue && !IsNamedTestCaseNumberVariableValue && !IsNamedTestCaseJsonVariableValue && !IsNamedTestCaseChatHistoryVariableValue && IsNamedTestCaseSearchResultsVariableValue && !IsNamedTestCaseErrorVariableValue && !IsNamedTestCaseFunctionCallVariableValue && !IsNamedTestCaseArrayVariableValue && !IsNamedTestCaseAudioVariableValue && !IsNamedTestCaseVideoVariableValue && !IsNamedTestCaseImageVariableValue && !IsNamedTestCaseDocumentVariableValue || !IsNamedTestCaseStringVariableValue && !IsNamedTestCaseNumberVariableValue && !IsNamedTestCaseJsonVariableValue && !IsNamedTestCaseChatHistoryVariableValue && !IsNamedTestCaseSearchResultsVariableValue && IsNamedTestCaseErrorVariableValue && !IsNamedTestCaseFunctionCallVariableValue && !IsNamedTestCaseArrayVariableValue && !IsNamedTestCaseAudioVariableValue && !IsNamedTestCaseVideoVariableValue && !IsNamedTestCaseImageVariableValue && !IsNamedTestCaseDocumentVariableValue || !IsNamedTestCaseStringVariableValue && !IsNamedTestCaseNumberVariableValue && !IsNamedTestCaseJsonVariableValue && !IsNamedTestCaseChatHistoryVariableValue && !IsNamedTestCaseSearchResultsVariableValue && !IsNamedTestCaseErrorVariableValue && IsNamedTestCaseFunctionCallVariableValue && !IsNamedTestCaseArrayVariableValue && !IsNamedTestCaseAudioVariableValue && !IsNamedTestCaseVideoVariableValue && !IsNamedTestCaseImageVariableValue && !IsNamedTestCaseDocumentVariableValue || !IsNamedTestCaseStringVariableValue && !IsNamedTestCaseNumberVariableValue && !IsNamedTestCaseJsonVariableValue && !IsNamedTestCaseChatHistoryVariableValue && !IsNamedTestCaseSearchResultsVariableValue && !IsNamedTestCaseErrorVariableValue && !IsNamedTestCaseFunctionCallVariableValue && IsNamedTestCaseArrayVariableValue && !IsNamedTestCaseAudioVariableValue && !IsNamedTestCaseVideoVariableValue && !IsNamedTestCaseImageVariableValue && !IsNamedTestCaseDocumentVariableValue || !IsNamedTestCaseStringVariableValue && !IsNamedTestCaseNumberVariableValue && !IsNamedTestCaseJsonVariableValue && !IsNamedTestCaseChatHistoryVariableValue && !IsNamedTestCaseSearchResultsVariableValue && !IsNamedTestCaseErrorVariableValue && !IsNamedTestCaseFunctionCallVariableValue && !IsNamedTestCaseArrayVariableValue && IsNamedTestCaseAudioVariableValue && !IsNamedTestCaseVideoVariableValue && !IsNamedTestCaseImageVariableValue && !IsNamedTestCaseDocumentVariableValue || !IsNamedTestCaseStringVariableValue && !IsNamedTestCaseNumberVariableValue && !IsNamedTestCaseJsonVariableValue && !IsNamedTestCaseChatHistoryVariableValue && !IsNamedTestCaseSearchResultsVariableValue && !IsNamedTestCaseErrorVariableValue && !IsNamedTestCaseFunctionCallVariableValue && !IsNamedTestCaseArrayVariableValue && !IsNamedTestCaseAudioVariableValue && IsNamedTestCaseVideoVariableValue && !IsNamedTestCaseImageVariableValue && !IsNamedTestCaseDocumentVariableValue || !IsNamedTestCaseStringVariableValue && !IsNamedTestCaseNumberVariableValue && !IsNamedTestCaseJsonVariableValue && !IsNamedTestCaseChatHistoryVariableValue && !IsNamedTestCaseSearchResultsVariableValue && !IsNamedTestCaseErrorVariableValue && !IsNamedTestCaseFunctionCallVariableValue && !IsNamedTestCaseArrayVariableValue && !IsNamedTestCaseAudioVariableValue && !IsNamedTestCaseVideoVariableValue && IsNamedTestCaseImageVariableValue && !IsNamedTestCaseDocumentVariableValue || !IsNamedTestCaseStringVariableValue && !IsNamedTestCaseNumberVariableValue && !IsNamedTestCaseJsonVariableValue && !IsNamedTestCaseChatHistoryVariableValue && !IsNamedTestCaseSearchResultsVariableValue && !IsNamedTestCaseErrorVariableValue && !IsNamedTestCaseFunctionCallVariableValue && !IsNamedTestCaseArrayVariableValue && !IsNamedTestCaseAudioVariableValue && !IsNamedTestCaseVideoVariableValue && !IsNamedTestCaseImageVariableValue && IsNamedTestCaseDocumentVariableValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.NamedTestCaseStringVariableValue?, TResult>? namedTestCaseStringVariableValue = null,
            global::System.Func<global::Vellum.NamedTestCaseNumberVariableValue?, TResult>? namedTestCaseNumberVariableValue = null,
            global::System.Func<global::Vellum.NamedTestCaseJsonVariableValue?, TResult>? namedTestCaseJsonVariableValue = null,
            global::System.Func<global::Vellum.NamedTestCaseChatHistoryVariableValue?, TResult>? namedTestCaseChatHistoryVariableValue = null,
            global::System.Func<global::Vellum.NamedTestCaseSearchResultsVariableValue?, TResult>? namedTestCaseSearchResultsVariableValue = null,
            global::System.Func<global::Vellum.NamedTestCaseErrorVariableValue?, TResult>? namedTestCaseErrorVariableValue = null,
            global::System.Func<global::Vellum.NamedTestCaseFunctionCallVariableValue?, TResult>? namedTestCaseFunctionCallVariableValue = null,
            global::System.Func<global::Vellum.NamedTestCaseArrayVariableValue?, TResult>? namedTestCaseArrayVariableValue = null,
            global::System.Func<global::Vellum.NamedTestCaseAudioVariableValue?, TResult>? namedTestCaseAudioVariableValue = null,
            global::System.Func<global::Vellum.NamedTestCaseVideoVariableValue?, TResult>? namedTestCaseVideoVariableValue = null,
            global::System.Func<global::Vellum.NamedTestCaseImageVariableValue?, TResult>? namedTestCaseImageVariableValue = null,
            global::System.Func<global::Vellum.NamedTestCaseDocumentVariableValue?, TResult>? namedTestCaseDocumentVariableValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNamedTestCaseStringVariableValue && namedTestCaseStringVariableValue != null)
            {
                return namedTestCaseStringVariableValue(NamedTestCaseStringVariableValue!);
            }
            else if (IsNamedTestCaseNumberVariableValue && namedTestCaseNumberVariableValue != null)
            {
                return namedTestCaseNumberVariableValue(NamedTestCaseNumberVariableValue!);
            }
            else if (IsNamedTestCaseJsonVariableValue && namedTestCaseJsonVariableValue != null)
            {
                return namedTestCaseJsonVariableValue(NamedTestCaseJsonVariableValue!);
            }
            else if (IsNamedTestCaseChatHistoryVariableValue && namedTestCaseChatHistoryVariableValue != null)
            {
                return namedTestCaseChatHistoryVariableValue(NamedTestCaseChatHistoryVariableValue!);
            }
            else if (IsNamedTestCaseSearchResultsVariableValue && namedTestCaseSearchResultsVariableValue != null)
            {
                return namedTestCaseSearchResultsVariableValue(NamedTestCaseSearchResultsVariableValue!);
            }
            else if (IsNamedTestCaseErrorVariableValue && namedTestCaseErrorVariableValue != null)
            {
                return namedTestCaseErrorVariableValue(NamedTestCaseErrorVariableValue!);
            }
            else if (IsNamedTestCaseFunctionCallVariableValue && namedTestCaseFunctionCallVariableValue != null)
            {
                return namedTestCaseFunctionCallVariableValue(NamedTestCaseFunctionCallVariableValue!);
            }
            else if (IsNamedTestCaseArrayVariableValue && namedTestCaseArrayVariableValue != null)
            {
                return namedTestCaseArrayVariableValue(NamedTestCaseArrayVariableValue!);
            }
            else if (IsNamedTestCaseAudioVariableValue && namedTestCaseAudioVariableValue != null)
            {
                return namedTestCaseAudioVariableValue(NamedTestCaseAudioVariableValue!);
            }
            else if (IsNamedTestCaseVideoVariableValue && namedTestCaseVideoVariableValue != null)
            {
                return namedTestCaseVideoVariableValue(NamedTestCaseVideoVariableValue!);
            }
            else if (IsNamedTestCaseImageVariableValue && namedTestCaseImageVariableValue != null)
            {
                return namedTestCaseImageVariableValue(NamedTestCaseImageVariableValue!);
            }
            else if (IsNamedTestCaseDocumentVariableValue && namedTestCaseDocumentVariableValue != null)
            {
                return namedTestCaseDocumentVariableValue(NamedTestCaseDocumentVariableValue!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.NamedTestCaseStringVariableValue?>? namedTestCaseStringVariableValue = null,
            global::System.Action<global::Vellum.NamedTestCaseNumberVariableValue?>? namedTestCaseNumberVariableValue = null,
            global::System.Action<global::Vellum.NamedTestCaseJsonVariableValue?>? namedTestCaseJsonVariableValue = null,
            global::System.Action<global::Vellum.NamedTestCaseChatHistoryVariableValue?>? namedTestCaseChatHistoryVariableValue = null,
            global::System.Action<global::Vellum.NamedTestCaseSearchResultsVariableValue?>? namedTestCaseSearchResultsVariableValue = null,
            global::System.Action<global::Vellum.NamedTestCaseErrorVariableValue?>? namedTestCaseErrorVariableValue = null,
            global::System.Action<global::Vellum.NamedTestCaseFunctionCallVariableValue?>? namedTestCaseFunctionCallVariableValue = null,
            global::System.Action<global::Vellum.NamedTestCaseArrayVariableValue?>? namedTestCaseArrayVariableValue = null,
            global::System.Action<global::Vellum.NamedTestCaseAudioVariableValue?>? namedTestCaseAudioVariableValue = null,
            global::System.Action<global::Vellum.NamedTestCaseVideoVariableValue?>? namedTestCaseVideoVariableValue = null,
            global::System.Action<global::Vellum.NamedTestCaseImageVariableValue?>? namedTestCaseImageVariableValue = null,
            global::System.Action<global::Vellum.NamedTestCaseDocumentVariableValue?>? namedTestCaseDocumentVariableValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNamedTestCaseStringVariableValue)
            {
                namedTestCaseStringVariableValue?.Invoke(NamedTestCaseStringVariableValue!);
            }
            else if (IsNamedTestCaseNumberVariableValue)
            {
                namedTestCaseNumberVariableValue?.Invoke(NamedTestCaseNumberVariableValue!);
            }
            else if (IsNamedTestCaseJsonVariableValue)
            {
                namedTestCaseJsonVariableValue?.Invoke(NamedTestCaseJsonVariableValue!);
            }
            else if (IsNamedTestCaseChatHistoryVariableValue)
            {
                namedTestCaseChatHistoryVariableValue?.Invoke(NamedTestCaseChatHistoryVariableValue!);
            }
            else if (IsNamedTestCaseSearchResultsVariableValue)
            {
                namedTestCaseSearchResultsVariableValue?.Invoke(NamedTestCaseSearchResultsVariableValue!);
            }
            else if (IsNamedTestCaseErrorVariableValue)
            {
                namedTestCaseErrorVariableValue?.Invoke(NamedTestCaseErrorVariableValue!);
            }
            else if (IsNamedTestCaseFunctionCallVariableValue)
            {
                namedTestCaseFunctionCallVariableValue?.Invoke(NamedTestCaseFunctionCallVariableValue!);
            }
            else if (IsNamedTestCaseArrayVariableValue)
            {
                namedTestCaseArrayVariableValue?.Invoke(NamedTestCaseArrayVariableValue!);
            }
            else if (IsNamedTestCaseAudioVariableValue)
            {
                namedTestCaseAudioVariableValue?.Invoke(NamedTestCaseAudioVariableValue!);
            }
            else if (IsNamedTestCaseVideoVariableValue)
            {
                namedTestCaseVideoVariableValue?.Invoke(NamedTestCaseVideoVariableValue!);
            }
            else if (IsNamedTestCaseImageVariableValue)
            {
                namedTestCaseImageVariableValue?.Invoke(NamedTestCaseImageVariableValue!);
            }
            else if (IsNamedTestCaseDocumentVariableValue)
            {
                namedTestCaseDocumentVariableValue?.Invoke(NamedTestCaseDocumentVariableValue!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                NamedTestCaseStringVariableValue,
                typeof(global::Vellum.NamedTestCaseStringVariableValue),
                NamedTestCaseNumberVariableValue,
                typeof(global::Vellum.NamedTestCaseNumberVariableValue),
                NamedTestCaseJsonVariableValue,
                typeof(global::Vellum.NamedTestCaseJsonVariableValue),
                NamedTestCaseChatHistoryVariableValue,
                typeof(global::Vellum.NamedTestCaseChatHistoryVariableValue),
                NamedTestCaseSearchResultsVariableValue,
                typeof(global::Vellum.NamedTestCaseSearchResultsVariableValue),
                NamedTestCaseErrorVariableValue,
                typeof(global::Vellum.NamedTestCaseErrorVariableValue),
                NamedTestCaseFunctionCallVariableValue,
                typeof(global::Vellum.NamedTestCaseFunctionCallVariableValue),
                NamedTestCaseArrayVariableValue,
                typeof(global::Vellum.NamedTestCaseArrayVariableValue),
                NamedTestCaseAudioVariableValue,
                typeof(global::Vellum.NamedTestCaseAudioVariableValue),
                NamedTestCaseVideoVariableValue,
                typeof(global::Vellum.NamedTestCaseVideoVariableValue),
                NamedTestCaseImageVariableValue,
                typeof(global::Vellum.NamedTestCaseImageVariableValue),
                NamedTestCaseDocumentVariableValue,
                typeof(global::Vellum.NamedTestCaseDocumentVariableValue),
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
        public bool Equals(NamedTestCaseVariableValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseStringVariableValue?>.Default.Equals(NamedTestCaseStringVariableValue, other.NamedTestCaseStringVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseNumberVariableValue?>.Default.Equals(NamedTestCaseNumberVariableValue, other.NamedTestCaseNumberVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseJsonVariableValue?>.Default.Equals(NamedTestCaseJsonVariableValue, other.NamedTestCaseJsonVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseChatHistoryVariableValue?>.Default.Equals(NamedTestCaseChatHistoryVariableValue, other.NamedTestCaseChatHistoryVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseSearchResultsVariableValue?>.Default.Equals(NamedTestCaseSearchResultsVariableValue, other.NamedTestCaseSearchResultsVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseErrorVariableValue?>.Default.Equals(NamedTestCaseErrorVariableValue, other.NamedTestCaseErrorVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseFunctionCallVariableValue?>.Default.Equals(NamedTestCaseFunctionCallVariableValue, other.NamedTestCaseFunctionCallVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseArrayVariableValue?>.Default.Equals(NamedTestCaseArrayVariableValue, other.NamedTestCaseArrayVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseAudioVariableValue?>.Default.Equals(NamedTestCaseAudioVariableValue, other.NamedTestCaseAudioVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseVideoVariableValue?>.Default.Equals(NamedTestCaseVideoVariableValue, other.NamedTestCaseVideoVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseImageVariableValue?>.Default.Equals(NamedTestCaseImageVariableValue, other.NamedTestCaseImageVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseDocumentVariableValue?>.Default.Equals(NamedTestCaseDocumentVariableValue, other.NamedTestCaseDocumentVariableValue) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NamedTestCaseVariableValue obj1, NamedTestCaseVariableValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NamedTestCaseVariableValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NamedTestCaseVariableValue obj1, NamedTestCaseVariableValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NamedTestCaseVariableValue o && Equals(o);
        }
    }
}
