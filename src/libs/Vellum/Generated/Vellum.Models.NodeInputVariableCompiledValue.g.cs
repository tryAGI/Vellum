#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct NodeInputVariableCompiledValue : global::System.IEquatable<NodeInputVariableCompiledValue>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeInputCompiledStringValue? NodeInputCompiledStringValue { get; init; }
#else
        public global::Vellum.NodeInputCompiledStringValue? NodeInputCompiledStringValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeInputCompiledStringValue))]
#endif
        public bool IsNodeInputCompiledStringValue => NodeInputCompiledStringValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeInputCompiledNumberValue? NodeInputCompiledNumberValue { get; init; }
#else
        public global::Vellum.NodeInputCompiledNumberValue? NodeInputCompiledNumberValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeInputCompiledNumberValue))]
#endif
        public bool IsNodeInputCompiledNumberValue => NodeInputCompiledNumberValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeInputCompiledJsonValue? NodeInputCompiledJsonValue { get; init; }
#else
        public global::Vellum.NodeInputCompiledJsonValue? NodeInputCompiledJsonValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeInputCompiledJsonValue))]
#endif
        public bool IsNodeInputCompiledJsonValue => NodeInputCompiledJsonValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeInputCompiledChatHistoryValue? NodeInputCompiledChatHistoryValue { get; init; }
#else
        public global::Vellum.NodeInputCompiledChatHistoryValue? NodeInputCompiledChatHistoryValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeInputCompiledChatHistoryValue))]
#endif
        public bool IsNodeInputCompiledChatHistoryValue => NodeInputCompiledChatHistoryValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeInputCompiledSearchResultsValue? NodeInputCompiledSearchResultsValue { get; init; }
#else
        public global::Vellum.NodeInputCompiledSearchResultsValue? NodeInputCompiledSearchResultsValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeInputCompiledSearchResultsValue))]
#endif
        public bool IsNodeInputCompiledSearchResultsValue => NodeInputCompiledSearchResultsValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeInputCompiledErrorValue? NodeInputCompiledErrorValue { get; init; }
#else
        public global::Vellum.NodeInputCompiledErrorValue? NodeInputCompiledErrorValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeInputCompiledErrorValue))]
#endif
        public bool IsNodeInputCompiledErrorValue => NodeInputCompiledErrorValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeInputCompiledArrayValue? NodeInputCompiledArrayValue { get; init; }
#else
        public global::Vellum.NodeInputCompiledArrayValue? NodeInputCompiledArrayValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeInputCompiledArrayValue))]
#endif
        public bool IsNodeInputCompiledArrayValue => NodeInputCompiledArrayValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeInputCompiledFunctionCallValue? NodeInputCompiledFunctionCallValue { get; init; }
#else
        public global::Vellum.NodeInputCompiledFunctionCallValue? NodeInputCompiledFunctionCallValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeInputCompiledFunctionCallValue))]
#endif
        public bool IsNodeInputCompiledFunctionCallValue => NodeInputCompiledFunctionCallValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeInputCompiledSecretValue? NodeInputCompiledSecretValue { get; init; }
#else
        public global::Vellum.NodeInputCompiledSecretValue? NodeInputCompiledSecretValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeInputCompiledSecretValue))]
#endif
        public bool IsNodeInputCompiledSecretValue => NodeInputCompiledSecretValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeInputCompiledAudioValue? NodeInputCompiledAudioValue { get; init; }
#else
        public global::Vellum.NodeInputCompiledAudioValue? NodeInputCompiledAudioValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeInputCompiledAudioValue))]
#endif
        public bool IsNodeInputCompiledAudioValue => NodeInputCompiledAudioValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeInputCompiledVideoValue? NodeInputCompiledVideoValue { get; init; }
#else
        public global::Vellum.NodeInputCompiledVideoValue? NodeInputCompiledVideoValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeInputCompiledVideoValue))]
#endif
        public bool IsNodeInputCompiledVideoValue => NodeInputCompiledVideoValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeInputCompiledImageValue? NodeInputCompiledImageValue { get; init; }
#else
        public global::Vellum.NodeInputCompiledImageValue? NodeInputCompiledImageValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeInputCompiledImageValue))]
#endif
        public bool IsNodeInputCompiledImageValue => NodeInputCompiledImageValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeInputCompiledDocumentValue? NodeInputCompiledDocumentValue { get; init; }
#else
        public global::Vellum.NodeInputCompiledDocumentValue? NodeInputCompiledDocumentValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeInputCompiledDocumentValue))]
#endif
        public bool IsNodeInputCompiledDocumentValue => NodeInputCompiledDocumentValue != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledStringValue value) => new NodeInputVariableCompiledValue((global::Vellum.NodeInputCompiledStringValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeInputCompiledStringValue?(NodeInputVariableCompiledValue @this) => @this.NodeInputCompiledStringValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledStringValue? value)
        {
            NodeInputCompiledStringValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledNumberValue value) => new NodeInputVariableCompiledValue((global::Vellum.NodeInputCompiledNumberValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeInputCompiledNumberValue?(NodeInputVariableCompiledValue @this) => @this.NodeInputCompiledNumberValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledNumberValue? value)
        {
            NodeInputCompiledNumberValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledJsonValue value) => new NodeInputVariableCompiledValue((global::Vellum.NodeInputCompiledJsonValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeInputCompiledJsonValue?(NodeInputVariableCompiledValue @this) => @this.NodeInputCompiledJsonValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledJsonValue? value)
        {
            NodeInputCompiledJsonValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledChatHistoryValue value) => new NodeInputVariableCompiledValue((global::Vellum.NodeInputCompiledChatHistoryValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeInputCompiledChatHistoryValue?(NodeInputVariableCompiledValue @this) => @this.NodeInputCompiledChatHistoryValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledChatHistoryValue? value)
        {
            NodeInputCompiledChatHistoryValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledSearchResultsValue value) => new NodeInputVariableCompiledValue((global::Vellum.NodeInputCompiledSearchResultsValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeInputCompiledSearchResultsValue?(NodeInputVariableCompiledValue @this) => @this.NodeInputCompiledSearchResultsValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledSearchResultsValue? value)
        {
            NodeInputCompiledSearchResultsValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledErrorValue value) => new NodeInputVariableCompiledValue((global::Vellum.NodeInputCompiledErrorValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeInputCompiledErrorValue?(NodeInputVariableCompiledValue @this) => @this.NodeInputCompiledErrorValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledErrorValue? value)
        {
            NodeInputCompiledErrorValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledArrayValue value) => new NodeInputVariableCompiledValue((global::Vellum.NodeInputCompiledArrayValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeInputCompiledArrayValue?(NodeInputVariableCompiledValue @this) => @this.NodeInputCompiledArrayValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledArrayValue? value)
        {
            NodeInputCompiledArrayValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledFunctionCallValue value) => new NodeInputVariableCompiledValue((global::Vellum.NodeInputCompiledFunctionCallValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeInputCompiledFunctionCallValue?(NodeInputVariableCompiledValue @this) => @this.NodeInputCompiledFunctionCallValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledFunctionCallValue? value)
        {
            NodeInputCompiledFunctionCallValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledSecretValue value) => new NodeInputVariableCompiledValue((global::Vellum.NodeInputCompiledSecretValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeInputCompiledSecretValue?(NodeInputVariableCompiledValue @this) => @this.NodeInputCompiledSecretValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledSecretValue? value)
        {
            NodeInputCompiledSecretValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledAudioValue value) => new NodeInputVariableCompiledValue((global::Vellum.NodeInputCompiledAudioValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeInputCompiledAudioValue?(NodeInputVariableCompiledValue @this) => @this.NodeInputCompiledAudioValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledAudioValue? value)
        {
            NodeInputCompiledAudioValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledVideoValue value) => new NodeInputVariableCompiledValue((global::Vellum.NodeInputCompiledVideoValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeInputCompiledVideoValue?(NodeInputVariableCompiledValue @this) => @this.NodeInputCompiledVideoValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledVideoValue? value)
        {
            NodeInputCompiledVideoValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledImageValue value) => new NodeInputVariableCompiledValue((global::Vellum.NodeInputCompiledImageValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeInputCompiledImageValue?(NodeInputVariableCompiledValue @this) => @this.NodeInputCompiledImageValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledImageValue? value)
        {
            NodeInputCompiledImageValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledDocumentValue value) => new NodeInputVariableCompiledValue((global::Vellum.NodeInputCompiledDocumentValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeInputCompiledDocumentValue?(NodeInputVariableCompiledValue @this) => @this.NodeInputCompiledDocumentValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeInputVariableCompiledValue(global::Vellum.NodeInputCompiledDocumentValue? value)
        {
            NodeInputCompiledDocumentValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public NodeInputVariableCompiledValue(
            global::Vellum.NodeInputCompiledStringValue? nodeInputCompiledStringValue,
            global::Vellum.NodeInputCompiledNumberValue? nodeInputCompiledNumberValue,
            global::Vellum.NodeInputCompiledJsonValue? nodeInputCompiledJsonValue,
            global::Vellum.NodeInputCompiledChatHistoryValue? nodeInputCompiledChatHistoryValue,
            global::Vellum.NodeInputCompiledSearchResultsValue? nodeInputCompiledSearchResultsValue,
            global::Vellum.NodeInputCompiledErrorValue? nodeInputCompiledErrorValue,
            global::Vellum.NodeInputCompiledArrayValue? nodeInputCompiledArrayValue,
            global::Vellum.NodeInputCompiledFunctionCallValue? nodeInputCompiledFunctionCallValue,
            global::Vellum.NodeInputCompiledSecretValue? nodeInputCompiledSecretValue,
            global::Vellum.NodeInputCompiledAudioValue? nodeInputCompiledAudioValue,
            global::Vellum.NodeInputCompiledVideoValue? nodeInputCompiledVideoValue,
            global::Vellum.NodeInputCompiledImageValue? nodeInputCompiledImageValue,
            global::Vellum.NodeInputCompiledDocumentValue? nodeInputCompiledDocumentValue
            )
        {
            NodeInputCompiledStringValue = nodeInputCompiledStringValue;
            NodeInputCompiledNumberValue = nodeInputCompiledNumberValue;
            NodeInputCompiledJsonValue = nodeInputCompiledJsonValue;
            NodeInputCompiledChatHistoryValue = nodeInputCompiledChatHistoryValue;
            NodeInputCompiledSearchResultsValue = nodeInputCompiledSearchResultsValue;
            NodeInputCompiledErrorValue = nodeInputCompiledErrorValue;
            NodeInputCompiledArrayValue = nodeInputCompiledArrayValue;
            NodeInputCompiledFunctionCallValue = nodeInputCompiledFunctionCallValue;
            NodeInputCompiledSecretValue = nodeInputCompiledSecretValue;
            NodeInputCompiledAudioValue = nodeInputCompiledAudioValue;
            NodeInputCompiledVideoValue = nodeInputCompiledVideoValue;
            NodeInputCompiledImageValue = nodeInputCompiledImageValue;
            NodeInputCompiledDocumentValue = nodeInputCompiledDocumentValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            NodeInputCompiledDocumentValue as object ??
            NodeInputCompiledImageValue as object ??
            NodeInputCompiledVideoValue as object ??
            NodeInputCompiledAudioValue as object ??
            NodeInputCompiledSecretValue as object ??
            NodeInputCompiledFunctionCallValue as object ??
            NodeInputCompiledArrayValue as object ??
            NodeInputCompiledErrorValue as object ??
            NodeInputCompiledSearchResultsValue as object ??
            NodeInputCompiledChatHistoryValue as object ??
            NodeInputCompiledJsonValue as object ??
            NodeInputCompiledNumberValue as object ??
            NodeInputCompiledStringValue as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            NodeInputCompiledStringValue?.ToString() ??
            NodeInputCompiledNumberValue?.ToString() ??
            NodeInputCompiledJsonValue?.ToString() ??
            NodeInputCompiledChatHistoryValue?.ToString() ??
            NodeInputCompiledSearchResultsValue?.ToString() ??
            NodeInputCompiledErrorValue?.ToString() ??
            NodeInputCompiledArrayValue?.ToString() ??
            NodeInputCompiledFunctionCallValue?.ToString() ??
            NodeInputCompiledSecretValue?.ToString() ??
            NodeInputCompiledAudioValue?.ToString() ??
            NodeInputCompiledVideoValue?.ToString() ??
            NodeInputCompiledImageValue?.ToString() ??
            NodeInputCompiledDocumentValue?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNodeInputCompiledStringValue && !IsNodeInputCompiledNumberValue && !IsNodeInputCompiledJsonValue && !IsNodeInputCompiledChatHistoryValue && !IsNodeInputCompiledSearchResultsValue && !IsNodeInputCompiledErrorValue && !IsNodeInputCompiledArrayValue && !IsNodeInputCompiledFunctionCallValue && !IsNodeInputCompiledSecretValue && !IsNodeInputCompiledAudioValue && !IsNodeInputCompiledVideoValue && !IsNodeInputCompiledImageValue && !IsNodeInputCompiledDocumentValue || !IsNodeInputCompiledStringValue && IsNodeInputCompiledNumberValue && !IsNodeInputCompiledJsonValue && !IsNodeInputCompiledChatHistoryValue && !IsNodeInputCompiledSearchResultsValue && !IsNodeInputCompiledErrorValue && !IsNodeInputCompiledArrayValue && !IsNodeInputCompiledFunctionCallValue && !IsNodeInputCompiledSecretValue && !IsNodeInputCompiledAudioValue && !IsNodeInputCompiledVideoValue && !IsNodeInputCompiledImageValue && !IsNodeInputCompiledDocumentValue || !IsNodeInputCompiledStringValue && !IsNodeInputCompiledNumberValue && IsNodeInputCompiledJsonValue && !IsNodeInputCompiledChatHistoryValue && !IsNodeInputCompiledSearchResultsValue && !IsNodeInputCompiledErrorValue && !IsNodeInputCompiledArrayValue && !IsNodeInputCompiledFunctionCallValue && !IsNodeInputCompiledSecretValue && !IsNodeInputCompiledAudioValue && !IsNodeInputCompiledVideoValue && !IsNodeInputCompiledImageValue && !IsNodeInputCompiledDocumentValue || !IsNodeInputCompiledStringValue && !IsNodeInputCompiledNumberValue && !IsNodeInputCompiledJsonValue && IsNodeInputCompiledChatHistoryValue && !IsNodeInputCompiledSearchResultsValue && !IsNodeInputCompiledErrorValue && !IsNodeInputCompiledArrayValue && !IsNodeInputCompiledFunctionCallValue && !IsNodeInputCompiledSecretValue && !IsNodeInputCompiledAudioValue && !IsNodeInputCompiledVideoValue && !IsNodeInputCompiledImageValue && !IsNodeInputCompiledDocumentValue || !IsNodeInputCompiledStringValue && !IsNodeInputCompiledNumberValue && !IsNodeInputCompiledJsonValue && !IsNodeInputCompiledChatHistoryValue && IsNodeInputCompiledSearchResultsValue && !IsNodeInputCompiledErrorValue && !IsNodeInputCompiledArrayValue && !IsNodeInputCompiledFunctionCallValue && !IsNodeInputCompiledSecretValue && !IsNodeInputCompiledAudioValue && !IsNodeInputCompiledVideoValue && !IsNodeInputCompiledImageValue && !IsNodeInputCompiledDocumentValue || !IsNodeInputCompiledStringValue && !IsNodeInputCompiledNumberValue && !IsNodeInputCompiledJsonValue && !IsNodeInputCompiledChatHistoryValue && !IsNodeInputCompiledSearchResultsValue && IsNodeInputCompiledErrorValue && !IsNodeInputCompiledArrayValue && !IsNodeInputCompiledFunctionCallValue && !IsNodeInputCompiledSecretValue && !IsNodeInputCompiledAudioValue && !IsNodeInputCompiledVideoValue && !IsNodeInputCompiledImageValue && !IsNodeInputCompiledDocumentValue || !IsNodeInputCompiledStringValue && !IsNodeInputCompiledNumberValue && !IsNodeInputCompiledJsonValue && !IsNodeInputCompiledChatHistoryValue && !IsNodeInputCompiledSearchResultsValue && !IsNodeInputCompiledErrorValue && IsNodeInputCompiledArrayValue && !IsNodeInputCompiledFunctionCallValue && !IsNodeInputCompiledSecretValue && !IsNodeInputCompiledAudioValue && !IsNodeInputCompiledVideoValue && !IsNodeInputCompiledImageValue && !IsNodeInputCompiledDocumentValue || !IsNodeInputCompiledStringValue && !IsNodeInputCompiledNumberValue && !IsNodeInputCompiledJsonValue && !IsNodeInputCompiledChatHistoryValue && !IsNodeInputCompiledSearchResultsValue && !IsNodeInputCompiledErrorValue && !IsNodeInputCompiledArrayValue && IsNodeInputCompiledFunctionCallValue && !IsNodeInputCompiledSecretValue && !IsNodeInputCompiledAudioValue && !IsNodeInputCompiledVideoValue && !IsNodeInputCompiledImageValue && !IsNodeInputCompiledDocumentValue || !IsNodeInputCompiledStringValue && !IsNodeInputCompiledNumberValue && !IsNodeInputCompiledJsonValue && !IsNodeInputCompiledChatHistoryValue && !IsNodeInputCompiledSearchResultsValue && !IsNodeInputCompiledErrorValue && !IsNodeInputCompiledArrayValue && !IsNodeInputCompiledFunctionCallValue && IsNodeInputCompiledSecretValue && !IsNodeInputCompiledAudioValue && !IsNodeInputCompiledVideoValue && !IsNodeInputCompiledImageValue && !IsNodeInputCompiledDocumentValue || !IsNodeInputCompiledStringValue && !IsNodeInputCompiledNumberValue && !IsNodeInputCompiledJsonValue && !IsNodeInputCompiledChatHistoryValue && !IsNodeInputCompiledSearchResultsValue && !IsNodeInputCompiledErrorValue && !IsNodeInputCompiledArrayValue && !IsNodeInputCompiledFunctionCallValue && !IsNodeInputCompiledSecretValue && IsNodeInputCompiledAudioValue && !IsNodeInputCompiledVideoValue && !IsNodeInputCompiledImageValue && !IsNodeInputCompiledDocumentValue || !IsNodeInputCompiledStringValue && !IsNodeInputCompiledNumberValue && !IsNodeInputCompiledJsonValue && !IsNodeInputCompiledChatHistoryValue && !IsNodeInputCompiledSearchResultsValue && !IsNodeInputCompiledErrorValue && !IsNodeInputCompiledArrayValue && !IsNodeInputCompiledFunctionCallValue && !IsNodeInputCompiledSecretValue && !IsNodeInputCompiledAudioValue && IsNodeInputCompiledVideoValue && !IsNodeInputCompiledImageValue && !IsNodeInputCompiledDocumentValue || !IsNodeInputCompiledStringValue && !IsNodeInputCompiledNumberValue && !IsNodeInputCompiledJsonValue && !IsNodeInputCompiledChatHistoryValue && !IsNodeInputCompiledSearchResultsValue && !IsNodeInputCompiledErrorValue && !IsNodeInputCompiledArrayValue && !IsNodeInputCompiledFunctionCallValue && !IsNodeInputCompiledSecretValue && !IsNodeInputCompiledAudioValue && !IsNodeInputCompiledVideoValue && IsNodeInputCompiledImageValue && !IsNodeInputCompiledDocumentValue || !IsNodeInputCompiledStringValue && !IsNodeInputCompiledNumberValue && !IsNodeInputCompiledJsonValue && !IsNodeInputCompiledChatHistoryValue && !IsNodeInputCompiledSearchResultsValue && !IsNodeInputCompiledErrorValue && !IsNodeInputCompiledArrayValue && !IsNodeInputCompiledFunctionCallValue && !IsNodeInputCompiledSecretValue && !IsNodeInputCompiledAudioValue && !IsNodeInputCompiledVideoValue && !IsNodeInputCompiledImageValue && IsNodeInputCompiledDocumentValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.NodeInputCompiledStringValue?, TResult>? nodeInputCompiledStringValue = null,
            global::System.Func<global::Vellum.NodeInputCompiledNumberValue?, TResult>? nodeInputCompiledNumberValue = null,
            global::System.Func<global::Vellum.NodeInputCompiledJsonValue?, TResult>? nodeInputCompiledJsonValue = null,
            global::System.Func<global::Vellum.NodeInputCompiledChatHistoryValue?, TResult>? nodeInputCompiledChatHistoryValue = null,
            global::System.Func<global::Vellum.NodeInputCompiledSearchResultsValue?, TResult>? nodeInputCompiledSearchResultsValue = null,
            global::System.Func<global::Vellum.NodeInputCompiledErrorValue?, TResult>? nodeInputCompiledErrorValue = null,
            global::System.Func<global::Vellum.NodeInputCompiledArrayValue?, TResult>? nodeInputCompiledArrayValue = null,
            global::System.Func<global::Vellum.NodeInputCompiledFunctionCallValue?, TResult>? nodeInputCompiledFunctionCallValue = null,
            global::System.Func<global::Vellum.NodeInputCompiledSecretValue?, TResult>? nodeInputCompiledSecretValue = null,
            global::System.Func<global::Vellum.NodeInputCompiledAudioValue?, TResult>? nodeInputCompiledAudioValue = null,
            global::System.Func<global::Vellum.NodeInputCompiledVideoValue?, TResult>? nodeInputCompiledVideoValue = null,
            global::System.Func<global::Vellum.NodeInputCompiledImageValue?, TResult>? nodeInputCompiledImageValue = null,
            global::System.Func<global::Vellum.NodeInputCompiledDocumentValue?, TResult>? nodeInputCompiledDocumentValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNodeInputCompiledStringValue && nodeInputCompiledStringValue != null)
            {
                return nodeInputCompiledStringValue(NodeInputCompiledStringValue!);
            }
            else if (IsNodeInputCompiledNumberValue && nodeInputCompiledNumberValue != null)
            {
                return nodeInputCompiledNumberValue(NodeInputCompiledNumberValue!);
            }
            else if (IsNodeInputCompiledJsonValue && nodeInputCompiledJsonValue != null)
            {
                return nodeInputCompiledJsonValue(NodeInputCompiledJsonValue!);
            }
            else if (IsNodeInputCompiledChatHistoryValue && nodeInputCompiledChatHistoryValue != null)
            {
                return nodeInputCompiledChatHistoryValue(NodeInputCompiledChatHistoryValue!);
            }
            else if (IsNodeInputCompiledSearchResultsValue && nodeInputCompiledSearchResultsValue != null)
            {
                return nodeInputCompiledSearchResultsValue(NodeInputCompiledSearchResultsValue!);
            }
            else if (IsNodeInputCompiledErrorValue && nodeInputCompiledErrorValue != null)
            {
                return nodeInputCompiledErrorValue(NodeInputCompiledErrorValue!);
            }
            else if (IsNodeInputCompiledArrayValue && nodeInputCompiledArrayValue != null)
            {
                return nodeInputCompiledArrayValue(NodeInputCompiledArrayValue!);
            }
            else if (IsNodeInputCompiledFunctionCallValue && nodeInputCompiledFunctionCallValue != null)
            {
                return nodeInputCompiledFunctionCallValue(NodeInputCompiledFunctionCallValue!);
            }
            else if (IsNodeInputCompiledSecretValue && nodeInputCompiledSecretValue != null)
            {
                return nodeInputCompiledSecretValue(NodeInputCompiledSecretValue!);
            }
            else if (IsNodeInputCompiledAudioValue && nodeInputCompiledAudioValue != null)
            {
                return nodeInputCompiledAudioValue(NodeInputCompiledAudioValue!);
            }
            else if (IsNodeInputCompiledVideoValue && nodeInputCompiledVideoValue != null)
            {
                return nodeInputCompiledVideoValue(NodeInputCompiledVideoValue!);
            }
            else if (IsNodeInputCompiledImageValue && nodeInputCompiledImageValue != null)
            {
                return nodeInputCompiledImageValue(NodeInputCompiledImageValue!);
            }
            else if (IsNodeInputCompiledDocumentValue && nodeInputCompiledDocumentValue != null)
            {
                return nodeInputCompiledDocumentValue(NodeInputCompiledDocumentValue!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.NodeInputCompiledStringValue?>? nodeInputCompiledStringValue = null,
            global::System.Action<global::Vellum.NodeInputCompiledNumberValue?>? nodeInputCompiledNumberValue = null,
            global::System.Action<global::Vellum.NodeInputCompiledJsonValue?>? nodeInputCompiledJsonValue = null,
            global::System.Action<global::Vellum.NodeInputCompiledChatHistoryValue?>? nodeInputCompiledChatHistoryValue = null,
            global::System.Action<global::Vellum.NodeInputCompiledSearchResultsValue?>? nodeInputCompiledSearchResultsValue = null,
            global::System.Action<global::Vellum.NodeInputCompiledErrorValue?>? nodeInputCompiledErrorValue = null,
            global::System.Action<global::Vellum.NodeInputCompiledArrayValue?>? nodeInputCompiledArrayValue = null,
            global::System.Action<global::Vellum.NodeInputCompiledFunctionCallValue?>? nodeInputCompiledFunctionCallValue = null,
            global::System.Action<global::Vellum.NodeInputCompiledSecretValue?>? nodeInputCompiledSecretValue = null,
            global::System.Action<global::Vellum.NodeInputCompiledAudioValue?>? nodeInputCompiledAudioValue = null,
            global::System.Action<global::Vellum.NodeInputCompiledVideoValue?>? nodeInputCompiledVideoValue = null,
            global::System.Action<global::Vellum.NodeInputCompiledImageValue?>? nodeInputCompiledImageValue = null,
            global::System.Action<global::Vellum.NodeInputCompiledDocumentValue?>? nodeInputCompiledDocumentValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNodeInputCompiledStringValue)
            {
                nodeInputCompiledStringValue?.Invoke(NodeInputCompiledStringValue!);
            }
            else if (IsNodeInputCompiledNumberValue)
            {
                nodeInputCompiledNumberValue?.Invoke(NodeInputCompiledNumberValue!);
            }
            else if (IsNodeInputCompiledJsonValue)
            {
                nodeInputCompiledJsonValue?.Invoke(NodeInputCompiledJsonValue!);
            }
            else if (IsNodeInputCompiledChatHistoryValue)
            {
                nodeInputCompiledChatHistoryValue?.Invoke(NodeInputCompiledChatHistoryValue!);
            }
            else if (IsNodeInputCompiledSearchResultsValue)
            {
                nodeInputCompiledSearchResultsValue?.Invoke(NodeInputCompiledSearchResultsValue!);
            }
            else if (IsNodeInputCompiledErrorValue)
            {
                nodeInputCompiledErrorValue?.Invoke(NodeInputCompiledErrorValue!);
            }
            else if (IsNodeInputCompiledArrayValue)
            {
                nodeInputCompiledArrayValue?.Invoke(NodeInputCompiledArrayValue!);
            }
            else if (IsNodeInputCompiledFunctionCallValue)
            {
                nodeInputCompiledFunctionCallValue?.Invoke(NodeInputCompiledFunctionCallValue!);
            }
            else if (IsNodeInputCompiledSecretValue)
            {
                nodeInputCompiledSecretValue?.Invoke(NodeInputCompiledSecretValue!);
            }
            else if (IsNodeInputCompiledAudioValue)
            {
                nodeInputCompiledAudioValue?.Invoke(NodeInputCompiledAudioValue!);
            }
            else if (IsNodeInputCompiledVideoValue)
            {
                nodeInputCompiledVideoValue?.Invoke(NodeInputCompiledVideoValue!);
            }
            else if (IsNodeInputCompiledImageValue)
            {
                nodeInputCompiledImageValue?.Invoke(NodeInputCompiledImageValue!);
            }
            else if (IsNodeInputCompiledDocumentValue)
            {
                nodeInputCompiledDocumentValue?.Invoke(NodeInputCompiledDocumentValue!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                NodeInputCompiledStringValue,
                typeof(global::Vellum.NodeInputCompiledStringValue),
                NodeInputCompiledNumberValue,
                typeof(global::Vellum.NodeInputCompiledNumberValue),
                NodeInputCompiledJsonValue,
                typeof(global::Vellum.NodeInputCompiledJsonValue),
                NodeInputCompiledChatHistoryValue,
                typeof(global::Vellum.NodeInputCompiledChatHistoryValue),
                NodeInputCompiledSearchResultsValue,
                typeof(global::Vellum.NodeInputCompiledSearchResultsValue),
                NodeInputCompiledErrorValue,
                typeof(global::Vellum.NodeInputCompiledErrorValue),
                NodeInputCompiledArrayValue,
                typeof(global::Vellum.NodeInputCompiledArrayValue),
                NodeInputCompiledFunctionCallValue,
                typeof(global::Vellum.NodeInputCompiledFunctionCallValue),
                NodeInputCompiledSecretValue,
                typeof(global::Vellum.NodeInputCompiledSecretValue),
                NodeInputCompiledAudioValue,
                typeof(global::Vellum.NodeInputCompiledAudioValue),
                NodeInputCompiledVideoValue,
                typeof(global::Vellum.NodeInputCompiledVideoValue),
                NodeInputCompiledImageValue,
                typeof(global::Vellum.NodeInputCompiledImageValue),
                NodeInputCompiledDocumentValue,
                typeof(global::Vellum.NodeInputCompiledDocumentValue),
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
        public bool Equals(NodeInputVariableCompiledValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeInputCompiledStringValue?>.Default.Equals(NodeInputCompiledStringValue, other.NodeInputCompiledStringValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeInputCompiledNumberValue?>.Default.Equals(NodeInputCompiledNumberValue, other.NodeInputCompiledNumberValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeInputCompiledJsonValue?>.Default.Equals(NodeInputCompiledJsonValue, other.NodeInputCompiledJsonValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeInputCompiledChatHistoryValue?>.Default.Equals(NodeInputCompiledChatHistoryValue, other.NodeInputCompiledChatHistoryValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeInputCompiledSearchResultsValue?>.Default.Equals(NodeInputCompiledSearchResultsValue, other.NodeInputCompiledSearchResultsValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeInputCompiledErrorValue?>.Default.Equals(NodeInputCompiledErrorValue, other.NodeInputCompiledErrorValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeInputCompiledArrayValue?>.Default.Equals(NodeInputCompiledArrayValue, other.NodeInputCompiledArrayValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeInputCompiledFunctionCallValue?>.Default.Equals(NodeInputCompiledFunctionCallValue, other.NodeInputCompiledFunctionCallValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeInputCompiledSecretValue?>.Default.Equals(NodeInputCompiledSecretValue, other.NodeInputCompiledSecretValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeInputCompiledAudioValue?>.Default.Equals(NodeInputCompiledAudioValue, other.NodeInputCompiledAudioValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeInputCompiledVideoValue?>.Default.Equals(NodeInputCompiledVideoValue, other.NodeInputCompiledVideoValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeInputCompiledImageValue?>.Default.Equals(NodeInputCompiledImageValue, other.NodeInputCompiledImageValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeInputCompiledDocumentValue?>.Default.Equals(NodeInputCompiledDocumentValue, other.NodeInputCompiledDocumentValue) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NodeInputVariableCompiledValue obj1, NodeInputVariableCompiledValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NodeInputVariableCompiledValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NodeInputVariableCompiledValue obj1, NodeInputVariableCompiledValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NodeInputVariableCompiledValue o && Equals(o);
        }
    }
}
