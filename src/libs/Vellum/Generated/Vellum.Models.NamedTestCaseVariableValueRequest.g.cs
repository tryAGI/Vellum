#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct NamedTestCaseVariableValueRequest : global::System.IEquatable<NamedTestCaseVariableValueRequest>
    {
        /// <summary>
        /// Named Test Case value that is of type STRING
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseStringVariableValueRequest? NamedTestCaseStringVariableValueRequest { get; init; }
#else
        public global::Vellum.NamedTestCaseStringVariableValueRequest? NamedTestCaseStringVariableValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseStringVariableValueRequest))]
#endif
        public bool IsNamedTestCaseStringVariableValueRequest => NamedTestCaseStringVariableValueRequest != null;

        /// <summary>
        /// Named Test Case value that is of type NUMBER
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseNumberVariableValueRequest? NamedTestCaseNumberVariableValueRequest { get; init; }
#else
        public global::Vellum.NamedTestCaseNumberVariableValueRequest? NamedTestCaseNumberVariableValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseNumberVariableValueRequest))]
#endif
        public bool IsNamedTestCaseNumberVariableValueRequest => NamedTestCaseNumberVariableValueRequest != null;

        /// <summary>
        /// Named Test Case value that is of type JSON
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseJsonVariableValueRequest? NamedTestCaseJsonVariableValueRequest { get; init; }
#else
        public global::Vellum.NamedTestCaseJsonVariableValueRequest? NamedTestCaseJsonVariableValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseJsonVariableValueRequest))]
#endif
        public bool IsNamedTestCaseJsonVariableValueRequest => NamedTestCaseJsonVariableValueRequest != null;

        /// <summary>
        /// Named Test Case value that is of type CHAT_HISTORY
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseChatHistoryVariableValueRequest? NamedTestCaseChatHistoryVariableValueRequest { get; init; }
#else
        public global::Vellum.NamedTestCaseChatHistoryVariableValueRequest? NamedTestCaseChatHistoryVariableValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseChatHistoryVariableValueRequest))]
#endif
        public bool IsNamedTestCaseChatHistoryVariableValueRequest => NamedTestCaseChatHistoryVariableValueRequest != null;

        /// <summary>
        /// Named Test Case value that is of type SEARCH_RESULTS
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseSearchResultsVariableValueRequest? NamedTestCaseSearchResultsVariableValueRequest { get; init; }
#else
        public global::Vellum.NamedTestCaseSearchResultsVariableValueRequest? NamedTestCaseSearchResultsVariableValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseSearchResultsVariableValueRequest))]
#endif
        public bool IsNamedTestCaseSearchResultsVariableValueRequest => NamedTestCaseSearchResultsVariableValueRequest != null;

        /// <summary>
        /// Named Test Case value that is of type ERROR
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseErrorVariableValueRequest? NamedTestCaseErrorVariableValueRequest { get; init; }
#else
        public global::Vellum.NamedTestCaseErrorVariableValueRequest? NamedTestCaseErrorVariableValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseErrorVariableValueRequest))]
#endif
        public bool IsNamedTestCaseErrorVariableValueRequest => NamedTestCaseErrorVariableValueRequest != null;

        /// <summary>
        /// Named Test Case value that is of type FUNCTION_CALL
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseFunctionCallVariableValueRequest? NamedTestCaseFunctionCallVariableValueRequest { get; init; }
#else
        public global::Vellum.NamedTestCaseFunctionCallVariableValueRequest? NamedTestCaseFunctionCallVariableValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseFunctionCallVariableValueRequest))]
#endif
        public bool IsNamedTestCaseFunctionCallVariableValueRequest => NamedTestCaseFunctionCallVariableValueRequest != null;

        /// <summary>
        /// Named Test Case value that is of type ARRAY
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseArrayVariableValueRequest? NamedTestCaseArrayVariableValueRequest { get; init; }
#else
        public global::Vellum.NamedTestCaseArrayVariableValueRequest? NamedTestCaseArrayVariableValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseArrayVariableValueRequest))]
#endif
        public bool IsNamedTestCaseArrayVariableValueRequest => NamedTestCaseArrayVariableValueRequest != null;

        /// <summary>
        /// Named Test Case value that is of type AUDIO
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseAudioVariableValueRequest? NamedTestCaseAudioVariableValueRequest { get; init; }
#else
        public global::Vellum.NamedTestCaseAudioVariableValueRequest? NamedTestCaseAudioVariableValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseAudioVariableValueRequest))]
#endif
        public bool IsNamedTestCaseAudioVariableValueRequest => NamedTestCaseAudioVariableValueRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseVideoVariableValueRequest? NamedTestCaseVideoVariableValueRequest { get; init; }
#else
        public global::Vellum.NamedTestCaseVideoVariableValueRequest? NamedTestCaseVideoVariableValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseVideoVariableValueRequest))]
#endif
        public bool IsNamedTestCaseVideoVariableValueRequest => NamedTestCaseVideoVariableValueRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseImageVariableValueRequest? NamedTestCaseImageVariableValueRequest { get; init; }
#else
        public global::Vellum.NamedTestCaseImageVariableValueRequest? NamedTestCaseImageVariableValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseImageVariableValueRequest))]
#endif
        public bool IsNamedTestCaseImageVariableValueRequest => NamedTestCaseImageVariableValueRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedTestCaseDocumentVariableValueRequest? NamedTestCaseDocumentVariableValueRequest { get; init; }
#else
        public global::Vellum.NamedTestCaseDocumentVariableValueRequest? NamedTestCaseDocumentVariableValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedTestCaseDocumentVariableValueRequest))]
#endif
        public bool IsNamedTestCaseDocumentVariableValueRequest => NamedTestCaseDocumentVariableValueRequest != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseStringVariableValueRequest value) => new NamedTestCaseVariableValueRequest((global::Vellum.NamedTestCaseStringVariableValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseStringVariableValueRequest?(NamedTestCaseVariableValueRequest @this) => @this.NamedTestCaseStringVariableValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseStringVariableValueRequest? value)
        {
            NamedTestCaseStringVariableValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseNumberVariableValueRequest value) => new NamedTestCaseVariableValueRequest((global::Vellum.NamedTestCaseNumberVariableValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseNumberVariableValueRequest?(NamedTestCaseVariableValueRequest @this) => @this.NamedTestCaseNumberVariableValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseNumberVariableValueRequest? value)
        {
            NamedTestCaseNumberVariableValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseJsonVariableValueRequest value) => new NamedTestCaseVariableValueRequest((global::Vellum.NamedTestCaseJsonVariableValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseJsonVariableValueRequest?(NamedTestCaseVariableValueRequest @this) => @this.NamedTestCaseJsonVariableValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseJsonVariableValueRequest? value)
        {
            NamedTestCaseJsonVariableValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseChatHistoryVariableValueRequest value) => new NamedTestCaseVariableValueRequest((global::Vellum.NamedTestCaseChatHistoryVariableValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseChatHistoryVariableValueRequest?(NamedTestCaseVariableValueRequest @this) => @this.NamedTestCaseChatHistoryVariableValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseChatHistoryVariableValueRequest? value)
        {
            NamedTestCaseChatHistoryVariableValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseSearchResultsVariableValueRequest value) => new NamedTestCaseVariableValueRequest((global::Vellum.NamedTestCaseSearchResultsVariableValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseSearchResultsVariableValueRequest?(NamedTestCaseVariableValueRequest @this) => @this.NamedTestCaseSearchResultsVariableValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseSearchResultsVariableValueRequest? value)
        {
            NamedTestCaseSearchResultsVariableValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseErrorVariableValueRequest value) => new NamedTestCaseVariableValueRequest((global::Vellum.NamedTestCaseErrorVariableValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseErrorVariableValueRequest?(NamedTestCaseVariableValueRequest @this) => @this.NamedTestCaseErrorVariableValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseErrorVariableValueRequest? value)
        {
            NamedTestCaseErrorVariableValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseFunctionCallVariableValueRequest value) => new NamedTestCaseVariableValueRequest((global::Vellum.NamedTestCaseFunctionCallVariableValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseFunctionCallVariableValueRequest?(NamedTestCaseVariableValueRequest @this) => @this.NamedTestCaseFunctionCallVariableValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseFunctionCallVariableValueRequest? value)
        {
            NamedTestCaseFunctionCallVariableValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseArrayVariableValueRequest value) => new NamedTestCaseVariableValueRequest((global::Vellum.NamedTestCaseArrayVariableValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseArrayVariableValueRequest?(NamedTestCaseVariableValueRequest @this) => @this.NamedTestCaseArrayVariableValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseArrayVariableValueRequest? value)
        {
            NamedTestCaseArrayVariableValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseAudioVariableValueRequest value) => new NamedTestCaseVariableValueRequest((global::Vellum.NamedTestCaseAudioVariableValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseAudioVariableValueRequest?(NamedTestCaseVariableValueRequest @this) => @this.NamedTestCaseAudioVariableValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseAudioVariableValueRequest? value)
        {
            NamedTestCaseAudioVariableValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseVideoVariableValueRequest value) => new NamedTestCaseVariableValueRequest((global::Vellum.NamedTestCaseVideoVariableValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseVideoVariableValueRequest?(NamedTestCaseVariableValueRequest @this) => @this.NamedTestCaseVideoVariableValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseVideoVariableValueRequest? value)
        {
            NamedTestCaseVideoVariableValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseImageVariableValueRequest value) => new NamedTestCaseVariableValueRequest((global::Vellum.NamedTestCaseImageVariableValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseImageVariableValueRequest?(NamedTestCaseVariableValueRequest @this) => @this.NamedTestCaseImageVariableValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseImageVariableValueRequest? value)
        {
            NamedTestCaseImageVariableValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseDocumentVariableValueRequest value) => new NamedTestCaseVariableValueRequest((global::Vellum.NamedTestCaseDocumentVariableValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedTestCaseDocumentVariableValueRequest?(NamedTestCaseVariableValueRequest @this) => @this.NamedTestCaseDocumentVariableValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValueRequest(global::Vellum.NamedTestCaseDocumentVariableValueRequest? value)
        {
            NamedTestCaseDocumentVariableValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public NamedTestCaseVariableValueRequest(
            global::Vellum.NamedTestCaseStringVariableValueRequest? namedTestCaseStringVariableValueRequest,
            global::Vellum.NamedTestCaseNumberVariableValueRequest? namedTestCaseNumberVariableValueRequest,
            global::Vellum.NamedTestCaseJsonVariableValueRequest? namedTestCaseJsonVariableValueRequest,
            global::Vellum.NamedTestCaseChatHistoryVariableValueRequest? namedTestCaseChatHistoryVariableValueRequest,
            global::Vellum.NamedTestCaseSearchResultsVariableValueRequest? namedTestCaseSearchResultsVariableValueRequest,
            global::Vellum.NamedTestCaseErrorVariableValueRequest? namedTestCaseErrorVariableValueRequest,
            global::Vellum.NamedTestCaseFunctionCallVariableValueRequest? namedTestCaseFunctionCallVariableValueRequest,
            global::Vellum.NamedTestCaseArrayVariableValueRequest? namedTestCaseArrayVariableValueRequest,
            global::Vellum.NamedTestCaseAudioVariableValueRequest? namedTestCaseAudioVariableValueRequest,
            global::Vellum.NamedTestCaseVideoVariableValueRequest? namedTestCaseVideoVariableValueRequest,
            global::Vellum.NamedTestCaseImageVariableValueRequest? namedTestCaseImageVariableValueRequest,
            global::Vellum.NamedTestCaseDocumentVariableValueRequest? namedTestCaseDocumentVariableValueRequest
            )
        {
            NamedTestCaseStringVariableValueRequest = namedTestCaseStringVariableValueRequest;
            NamedTestCaseNumberVariableValueRequest = namedTestCaseNumberVariableValueRequest;
            NamedTestCaseJsonVariableValueRequest = namedTestCaseJsonVariableValueRequest;
            NamedTestCaseChatHistoryVariableValueRequest = namedTestCaseChatHistoryVariableValueRequest;
            NamedTestCaseSearchResultsVariableValueRequest = namedTestCaseSearchResultsVariableValueRequest;
            NamedTestCaseErrorVariableValueRequest = namedTestCaseErrorVariableValueRequest;
            NamedTestCaseFunctionCallVariableValueRequest = namedTestCaseFunctionCallVariableValueRequest;
            NamedTestCaseArrayVariableValueRequest = namedTestCaseArrayVariableValueRequest;
            NamedTestCaseAudioVariableValueRequest = namedTestCaseAudioVariableValueRequest;
            NamedTestCaseVideoVariableValueRequest = namedTestCaseVideoVariableValueRequest;
            NamedTestCaseImageVariableValueRequest = namedTestCaseImageVariableValueRequest;
            NamedTestCaseDocumentVariableValueRequest = namedTestCaseDocumentVariableValueRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            NamedTestCaseDocumentVariableValueRequest as object ??
            NamedTestCaseImageVariableValueRequest as object ??
            NamedTestCaseVideoVariableValueRequest as object ??
            NamedTestCaseAudioVariableValueRequest as object ??
            NamedTestCaseArrayVariableValueRequest as object ??
            NamedTestCaseFunctionCallVariableValueRequest as object ??
            NamedTestCaseErrorVariableValueRequest as object ??
            NamedTestCaseSearchResultsVariableValueRequest as object ??
            NamedTestCaseChatHistoryVariableValueRequest as object ??
            NamedTestCaseJsonVariableValueRequest as object ??
            NamedTestCaseNumberVariableValueRequest as object ??
            NamedTestCaseStringVariableValueRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            NamedTestCaseStringVariableValueRequest?.ToString() ??
            NamedTestCaseNumberVariableValueRequest?.ToString() ??
            NamedTestCaseJsonVariableValueRequest?.ToString() ??
            NamedTestCaseChatHistoryVariableValueRequest?.ToString() ??
            NamedTestCaseSearchResultsVariableValueRequest?.ToString() ??
            NamedTestCaseErrorVariableValueRequest?.ToString() ??
            NamedTestCaseFunctionCallVariableValueRequest?.ToString() ??
            NamedTestCaseArrayVariableValueRequest?.ToString() ??
            NamedTestCaseAudioVariableValueRequest?.ToString() ??
            NamedTestCaseVideoVariableValueRequest?.ToString() ??
            NamedTestCaseImageVariableValueRequest?.ToString() ??
            NamedTestCaseDocumentVariableValueRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNamedTestCaseStringVariableValueRequest && !IsNamedTestCaseNumberVariableValueRequest && !IsNamedTestCaseJsonVariableValueRequest && !IsNamedTestCaseChatHistoryVariableValueRequest && !IsNamedTestCaseSearchResultsVariableValueRequest && !IsNamedTestCaseErrorVariableValueRequest && !IsNamedTestCaseFunctionCallVariableValueRequest && !IsNamedTestCaseArrayVariableValueRequest && !IsNamedTestCaseAudioVariableValueRequest && !IsNamedTestCaseVideoVariableValueRequest && !IsNamedTestCaseImageVariableValueRequest && !IsNamedTestCaseDocumentVariableValueRequest || !IsNamedTestCaseStringVariableValueRequest && IsNamedTestCaseNumberVariableValueRequest && !IsNamedTestCaseJsonVariableValueRequest && !IsNamedTestCaseChatHistoryVariableValueRequest && !IsNamedTestCaseSearchResultsVariableValueRequest && !IsNamedTestCaseErrorVariableValueRequest && !IsNamedTestCaseFunctionCallVariableValueRequest && !IsNamedTestCaseArrayVariableValueRequest && !IsNamedTestCaseAudioVariableValueRequest && !IsNamedTestCaseVideoVariableValueRequest && !IsNamedTestCaseImageVariableValueRequest && !IsNamedTestCaseDocumentVariableValueRequest || !IsNamedTestCaseStringVariableValueRequest && !IsNamedTestCaseNumberVariableValueRequest && IsNamedTestCaseJsonVariableValueRequest && !IsNamedTestCaseChatHistoryVariableValueRequest && !IsNamedTestCaseSearchResultsVariableValueRequest && !IsNamedTestCaseErrorVariableValueRequest && !IsNamedTestCaseFunctionCallVariableValueRequest && !IsNamedTestCaseArrayVariableValueRequest && !IsNamedTestCaseAudioVariableValueRequest && !IsNamedTestCaseVideoVariableValueRequest && !IsNamedTestCaseImageVariableValueRequest && !IsNamedTestCaseDocumentVariableValueRequest || !IsNamedTestCaseStringVariableValueRequest && !IsNamedTestCaseNumberVariableValueRequest && !IsNamedTestCaseJsonVariableValueRequest && IsNamedTestCaseChatHistoryVariableValueRequest && !IsNamedTestCaseSearchResultsVariableValueRequest && !IsNamedTestCaseErrorVariableValueRequest && !IsNamedTestCaseFunctionCallVariableValueRequest && !IsNamedTestCaseArrayVariableValueRequest && !IsNamedTestCaseAudioVariableValueRequest && !IsNamedTestCaseVideoVariableValueRequest && !IsNamedTestCaseImageVariableValueRequest && !IsNamedTestCaseDocumentVariableValueRequest || !IsNamedTestCaseStringVariableValueRequest && !IsNamedTestCaseNumberVariableValueRequest && !IsNamedTestCaseJsonVariableValueRequest && !IsNamedTestCaseChatHistoryVariableValueRequest && IsNamedTestCaseSearchResultsVariableValueRequest && !IsNamedTestCaseErrorVariableValueRequest && !IsNamedTestCaseFunctionCallVariableValueRequest && !IsNamedTestCaseArrayVariableValueRequest && !IsNamedTestCaseAudioVariableValueRequest && !IsNamedTestCaseVideoVariableValueRequest && !IsNamedTestCaseImageVariableValueRequest && !IsNamedTestCaseDocumentVariableValueRequest || !IsNamedTestCaseStringVariableValueRequest && !IsNamedTestCaseNumberVariableValueRequest && !IsNamedTestCaseJsonVariableValueRequest && !IsNamedTestCaseChatHistoryVariableValueRequest && !IsNamedTestCaseSearchResultsVariableValueRequest && IsNamedTestCaseErrorVariableValueRequest && !IsNamedTestCaseFunctionCallVariableValueRequest && !IsNamedTestCaseArrayVariableValueRequest && !IsNamedTestCaseAudioVariableValueRequest && !IsNamedTestCaseVideoVariableValueRequest && !IsNamedTestCaseImageVariableValueRequest && !IsNamedTestCaseDocumentVariableValueRequest || !IsNamedTestCaseStringVariableValueRequest && !IsNamedTestCaseNumberVariableValueRequest && !IsNamedTestCaseJsonVariableValueRequest && !IsNamedTestCaseChatHistoryVariableValueRequest && !IsNamedTestCaseSearchResultsVariableValueRequest && !IsNamedTestCaseErrorVariableValueRequest && IsNamedTestCaseFunctionCallVariableValueRequest && !IsNamedTestCaseArrayVariableValueRequest && !IsNamedTestCaseAudioVariableValueRequest && !IsNamedTestCaseVideoVariableValueRequest && !IsNamedTestCaseImageVariableValueRequest && !IsNamedTestCaseDocumentVariableValueRequest || !IsNamedTestCaseStringVariableValueRequest && !IsNamedTestCaseNumberVariableValueRequest && !IsNamedTestCaseJsonVariableValueRequest && !IsNamedTestCaseChatHistoryVariableValueRequest && !IsNamedTestCaseSearchResultsVariableValueRequest && !IsNamedTestCaseErrorVariableValueRequest && !IsNamedTestCaseFunctionCallVariableValueRequest && IsNamedTestCaseArrayVariableValueRequest && !IsNamedTestCaseAudioVariableValueRequest && !IsNamedTestCaseVideoVariableValueRequest && !IsNamedTestCaseImageVariableValueRequest && !IsNamedTestCaseDocumentVariableValueRequest || !IsNamedTestCaseStringVariableValueRequest && !IsNamedTestCaseNumberVariableValueRequest && !IsNamedTestCaseJsonVariableValueRequest && !IsNamedTestCaseChatHistoryVariableValueRequest && !IsNamedTestCaseSearchResultsVariableValueRequest && !IsNamedTestCaseErrorVariableValueRequest && !IsNamedTestCaseFunctionCallVariableValueRequest && !IsNamedTestCaseArrayVariableValueRequest && IsNamedTestCaseAudioVariableValueRequest && !IsNamedTestCaseVideoVariableValueRequest && !IsNamedTestCaseImageVariableValueRequest && !IsNamedTestCaseDocumentVariableValueRequest || !IsNamedTestCaseStringVariableValueRequest && !IsNamedTestCaseNumberVariableValueRequest && !IsNamedTestCaseJsonVariableValueRequest && !IsNamedTestCaseChatHistoryVariableValueRequest && !IsNamedTestCaseSearchResultsVariableValueRequest && !IsNamedTestCaseErrorVariableValueRequest && !IsNamedTestCaseFunctionCallVariableValueRequest && !IsNamedTestCaseArrayVariableValueRequest && !IsNamedTestCaseAudioVariableValueRequest && IsNamedTestCaseVideoVariableValueRequest && !IsNamedTestCaseImageVariableValueRequest && !IsNamedTestCaseDocumentVariableValueRequest || !IsNamedTestCaseStringVariableValueRequest && !IsNamedTestCaseNumberVariableValueRequest && !IsNamedTestCaseJsonVariableValueRequest && !IsNamedTestCaseChatHistoryVariableValueRequest && !IsNamedTestCaseSearchResultsVariableValueRequest && !IsNamedTestCaseErrorVariableValueRequest && !IsNamedTestCaseFunctionCallVariableValueRequest && !IsNamedTestCaseArrayVariableValueRequest && !IsNamedTestCaseAudioVariableValueRequest && !IsNamedTestCaseVideoVariableValueRequest && IsNamedTestCaseImageVariableValueRequest && !IsNamedTestCaseDocumentVariableValueRequest || !IsNamedTestCaseStringVariableValueRequest && !IsNamedTestCaseNumberVariableValueRequest && !IsNamedTestCaseJsonVariableValueRequest && !IsNamedTestCaseChatHistoryVariableValueRequest && !IsNamedTestCaseSearchResultsVariableValueRequest && !IsNamedTestCaseErrorVariableValueRequest && !IsNamedTestCaseFunctionCallVariableValueRequest && !IsNamedTestCaseArrayVariableValueRequest && !IsNamedTestCaseAudioVariableValueRequest && !IsNamedTestCaseVideoVariableValueRequest && !IsNamedTestCaseImageVariableValueRequest && IsNamedTestCaseDocumentVariableValueRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.NamedTestCaseStringVariableValueRequest?, TResult>? namedTestCaseStringVariableValueRequest = null,
            global::System.Func<global::Vellum.NamedTestCaseNumberVariableValueRequest?, TResult>? namedTestCaseNumberVariableValueRequest = null,
            global::System.Func<global::Vellum.NamedTestCaseJsonVariableValueRequest?, TResult>? namedTestCaseJsonVariableValueRequest = null,
            global::System.Func<global::Vellum.NamedTestCaseChatHistoryVariableValueRequest?, TResult>? namedTestCaseChatHistoryVariableValueRequest = null,
            global::System.Func<global::Vellum.NamedTestCaseSearchResultsVariableValueRequest?, TResult>? namedTestCaseSearchResultsVariableValueRequest = null,
            global::System.Func<global::Vellum.NamedTestCaseErrorVariableValueRequest?, TResult>? namedTestCaseErrorVariableValueRequest = null,
            global::System.Func<global::Vellum.NamedTestCaseFunctionCallVariableValueRequest?, TResult>? namedTestCaseFunctionCallVariableValueRequest = null,
            global::System.Func<global::Vellum.NamedTestCaseArrayVariableValueRequest?, TResult>? namedTestCaseArrayVariableValueRequest = null,
            global::System.Func<global::Vellum.NamedTestCaseAudioVariableValueRequest?, TResult>? namedTestCaseAudioVariableValueRequest = null,
            global::System.Func<global::Vellum.NamedTestCaseVideoVariableValueRequest?, TResult>? namedTestCaseVideoVariableValueRequest = null,
            global::System.Func<global::Vellum.NamedTestCaseImageVariableValueRequest?, TResult>? namedTestCaseImageVariableValueRequest = null,
            global::System.Func<global::Vellum.NamedTestCaseDocumentVariableValueRequest?, TResult>? namedTestCaseDocumentVariableValueRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNamedTestCaseStringVariableValueRequest && namedTestCaseStringVariableValueRequest != null)
            {
                return namedTestCaseStringVariableValueRequest(NamedTestCaseStringVariableValueRequest!);
            }
            else if (IsNamedTestCaseNumberVariableValueRequest && namedTestCaseNumberVariableValueRequest != null)
            {
                return namedTestCaseNumberVariableValueRequest(NamedTestCaseNumberVariableValueRequest!);
            }
            else if (IsNamedTestCaseJsonVariableValueRequest && namedTestCaseJsonVariableValueRequest != null)
            {
                return namedTestCaseJsonVariableValueRequest(NamedTestCaseJsonVariableValueRequest!);
            }
            else if (IsNamedTestCaseChatHistoryVariableValueRequest && namedTestCaseChatHistoryVariableValueRequest != null)
            {
                return namedTestCaseChatHistoryVariableValueRequest(NamedTestCaseChatHistoryVariableValueRequest!);
            }
            else if (IsNamedTestCaseSearchResultsVariableValueRequest && namedTestCaseSearchResultsVariableValueRequest != null)
            {
                return namedTestCaseSearchResultsVariableValueRequest(NamedTestCaseSearchResultsVariableValueRequest!);
            }
            else if (IsNamedTestCaseErrorVariableValueRequest && namedTestCaseErrorVariableValueRequest != null)
            {
                return namedTestCaseErrorVariableValueRequest(NamedTestCaseErrorVariableValueRequest!);
            }
            else if (IsNamedTestCaseFunctionCallVariableValueRequest && namedTestCaseFunctionCallVariableValueRequest != null)
            {
                return namedTestCaseFunctionCallVariableValueRequest(NamedTestCaseFunctionCallVariableValueRequest!);
            }
            else if (IsNamedTestCaseArrayVariableValueRequest && namedTestCaseArrayVariableValueRequest != null)
            {
                return namedTestCaseArrayVariableValueRequest(NamedTestCaseArrayVariableValueRequest!);
            }
            else if (IsNamedTestCaseAudioVariableValueRequest && namedTestCaseAudioVariableValueRequest != null)
            {
                return namedTestCaseAudioVariableValueRequest(NamedTestCaseAudioVariableValueRequest!);
            }
            else if (IsNamedTestCaseVideoVariableValueRequest && namedTestCaseVideoVariableValueRequest != null)
            {
                return namedTestCaseVideoVariableValueRequest(NamedTestCaseVideoVariableValueRequest!);
            }
            else if (IsNamedTestCaseImageVariableValueRequest && namedTestCaseImageVariableValueRequest != null)
            {
                return namedTestCaseImageVariableValueRequest(NamedTestCaseImageVariableValueRequest!);
            }
            else if (IsNamedTestCaseDocumentVariableValueRequest && namedTestCaseDocumentVariableValueRequest != null)
            {
                return namedTestCaseDocumentVariableValueRequest(NamedTestCaseDocumentVariableValueRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.NamedTestCaseStringVariableValueRequest?>? namedTestCaseStringVariableValueRequest = null,
            global::System.Action<global::Vellum.NamedTestCaseNumberVariableValueRequest?>? namedTestCaseNumberVariableValueRequest = null,
            global::System.Action<global::Vellum.NamedTestCaseJsonVariableValueRequest?>? namedTestCaseJsonVariableValueRequest = null,
            global::System.Action<global::Vellum.NamedTestCaseChatHistoryVariableValueRequest?>? namedTestCaseChatHistoryVariableValueRequest = null,
            global::System.Action<global::Vellum.NamedTestCaseSearchResultsVariableValueRequest?>? namedTestCaseSearchResultsVariableValueRequest = null,
            global::System.Action<global::Vellum.NamedTestCaseErrorVariableValueRequest?>? namedTestCaseErrorVariableValueRequest = null,
            global::System.Action<global::Vellum.NamedTestCaseFunctionCallVariableValueRequest?>? namedTestCaseFunctionCallVariableValueRequest = null,
            global::System.Action<global::Vellum.NamedTestCaseArrayVariableValueRequest?>? namedTestCaseArrayVariableValueRequest = null,
            global::System.Action<global::Vellum.NamedTestCaseAudioVariableValueRequest?>? namedTestCaseAudioVariableValueRequest = null,
            global::System.Action<global::Vellum.NamedTestCaseVideoVariableValueRequest?>? namedTestCaseVideoVariableValueRequest = null,
            global::System.Action<global::Vellum.NamedTestCaseImageVariableValueRequest?>? namedTestCaseImageVariableValueRequest = null,
            global::System.Action<global::Vellum.NamedTestCaseDocumentVariableValueRequest?>? namedTestCaseDocumentVariableValueRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNamedTestCaseStringVariableValueRequest)
            {
                namedTestCaseStringVariableValueRequest?.Invoke(NamedTestCaseStringVariableValueRequest!);
            }
            else if (IsNamedTestCaseNumberVariableValueRequest)
            {
                namedTestCaseNumberVariableValueRequest?.Invoke(NamedTestCaseNumberVariableValueRequest!);
            }
            else if (IsNamedTestCaseJsonVariableValueRequest)
            {
                namedTestCaseJsonVariableValueRequest?.Invoke(NamedTestCaseJsonVariableValueRequest!);
            }
            else if (IsNamedTestCaseChatHistoryVariableValueRequest)
            {
                namedTestCaseChatHistoryVariableValueRequest?.Invoke(NamedTestCaseChatHistoryVariableValueRequest!);
            }
            else if (IsNamedTestCaseSearchResultsVariableValueRequest)
            {
                namedTestCaseSearchResultsVariableValueRequest?.Invoke(NamedTestCaseSearchResultsVariableValueRequest!);
            }
            else if (IsNamedTestCaseErrorVariableValueRequest)
            {
                namedTestCaseErrorVariableValueRequest?.Invoke(NamedTestCaseErrorVariableValueRequest!);
            }
            else if (IsNamedTestCaseFunctionCallVariableValueRequest)
            {
                namedTestCaseFunctionCallVariableValueRequest?.Invoke(NamedTestCaseFunctionCallVariableValueRequest!);
            }
            else if (IsNamedTestCaseArrayVariableValueRequest)
            {
                namedTestCaseArrayVariableValueRequest?.Invoke(NamedTestCaseArrayVariableValueRequest!);
            }
            else if (IsNamedTestCaseAudioVariableValueRequest)
            {
                namedTestCaseAudioVariableValueRequest?.Invoke(NamedTestCaseAudioVariableValueRequest!);
            }
            else if (IsNamedTestCaseVideoVariableValueRequest)
            {
                namedTestCaseVideoVariableValueRequest?.Invoke(NamedTestCaseVideoVariableValueRequest!);
            }
            else if (IsNamedTestCaseImageVariableValueRequest)
            {
                namedTestCaseImageVariableValueRequest?.Invoke(NamedTestCaseImageVariableValueRequest!);
            }
            else if (IsNamedTestCaseDocumentVariableValueRequest)
            {
                namedTestCaseDocumentVariableValueRequest?.Invoke(NamedTestCaseDocumentVariableValueRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                NamedTestCaseStringVariableValueRequest,
                typeof(global::Vellum.NamedTestCaseStringVariableValueRequest),
                NamedTestCaseNumberVariableValueRequest,
                typeof(global::Vellum.NamedTestCaseNumberVariableValueRequest),
                NamedTestCaseJsonVariableValueRequest,
                typeof(global::Vellum.NamedTestCaseJsonVariableValueRequest),
                NamedTestCaseChatHistoryVariableValueRequest,
                typeof(global::Vellum.NamedTestCaseChatHistoryVariableValueRequest),
                NamedTestCaseSearchResultsVariableValueRequest,
                typeof(global::Vellum.NamedTestCaseSearchResultsVariableValueRequest),
                NamedTestCaseErrorVariableValueRequest,
                typeof(global::Vellum.NamedTestCaseErrorVariableValueRequest),
                NamedTestCaseFunctionCallVariableValueRequest,
                typeof(global::Vellum.NamedTestCaseFunctionCallVariableValueRequest),
                NamedTestCaseArrayVariableValueRequest,
                typeof(global::Vellum.NamedTestCaseArrayVariableValueRequest),
                NamedTestCaseAudioVariableValueRequest,
                typeof(global::Vellum.NamedTestCaseAudioVariableValueRequest),
                NamedTestCaseVideoVariableValueRequest,
                typeof(global::Vellum.NamedTestCaseVideoVariableValueRequest),
                NamedTestCaseImageVariableValueRequest,
                typeof(global::Vellum.NamedTestCaseImageVariableValueRequest),
                NamedTestCaseDocumentVariableValueRequest,
                typeof(global::Vellum.NamedTestCaseDocumentVariableValueRequest),
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
        public bool Equals(NamedTestCaseVariableValueRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseStringVariableValueRequest?>.Default.Equals(NamedTestCaseStringVariableValueRequest, other.NamedTestCaseStringVariableValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseNumberVariableValueRequest?>.Default.Equals(NamedTestCaseNumberVariableValueRequest, other.NamedTestCaseNumberVariableValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseJsonVariableValueRequest?>.Default.Equals(NamedTestCaseJsonVariableValueRequest, other.NamedTestCaseJsonVariableValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseChatHistoryVariableValueRequest?>.Default.Equals(NamedTestCaseChatHistoryVariableValueRequest, other.NamedTestCaseChatHistoryVariableValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseSearchResultsVariableValueRequest?>.Default.Equals(NamedTestCaseSearchResultsVariableValueRequest, other.NamedTestCaseSearchResultsVariableValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseErrorVariableValueRequest?>.Default.Equals(NamedTestCaseErrorVariableValueRequest, other.NamedTestCaseErrorVariableValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseFunctionCallVariableValueRequest?>.Default.Equals(NamedTestCaseFunctionCallVariableValueRequest, other.NamedTestCaseFunctionCallVariableValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseArrayVariableValueRequest?>.Default.Equals(NamedTestCaseArrayVariableValueRequest, other.NamedTestCaseArrayVariableValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseAudioVariableValueRequest?>.Default.Equals(NamedTestCaseAudioVariableValueRequest, other.NamedTestCaseAudioVariableValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseVideoVariableValueRequest?>.Default.Equals(NamedTestCaseVideoVariableValueRequest, other.NamedTestCaseVideoVariableValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseImageVariableValueRequest?>.Default.Equals(NamedTestCaseImageVariableValueRequest, other.NamedTestCaseImageVariableValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedTestCaseDocumentVariableValueRequest?>.Default.Equals(NamedTestCaseDocumentVariableValueRequest, other.NamedTestCaseDocumentVariableValueRequest) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NamedTestCaseVariableValueRequest obj1, NamedTestCaseVariableValueRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NamedTestCaseVariableValueRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NamedTestCaseVariableValueRequest obj1, NamedTestCaseVariableValueRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NamedTestCaseVariableValueRequest o && Equals(o);
        }
    }
}
