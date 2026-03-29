#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct NodeOutputCompiledValue : global::System.IEquatable<NodeOutputCompiledValue>
    {
        /// <summary>
        /// An output returned by a node that is of type STRING.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeOutputCompiledStringValue? NodeOutputCompiledStringValue { get; init; }
#else
        public global::Vellum.NodeOutputCompiledStringValue? NodeOutputCompiledStringValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeOutputCompiledStringValue))]
#endif
        public bool IsNodeOutputCompiledStringValue => NodeOutputCompiledStringValue != null;

        /// <summary>
        /// An output returned by a node that is of type NUMBER.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeOutputCompiledNumberValue? NodeOutputCompiledNumberValue { get; init; }
#else
        public global::Vellum.NodeOutputCompiledNumberValue? NodeOutputCompiledNumberValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeOutputCompiledNumberValue))]
#endif
        public bool IsNodeOutputCompiledNumberValue => NodeOutputCompiledNumberValue != null;

        /// <summary>
        /// An output returned by a node that is of type JSON.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeOutputCompiledJsonValue? NodeOutputCompiledJsonValue { get; init; }
#else
        public global::Vellum.NodeOutputCompiledJsonValue? NodeOutputCompiledJsonValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeOutputCompiledJsonValue))]
#endif
        public bool IsNodeOutputCompiledJsonValue => NodeOutputCompiledJsonValue != null;

        /// <summary>
        /// An output returned by a node that is of type CHAT_HISTORY.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeOutputCompiledChatHistoryValue? NodeOutputCompiledChatHistoryValue { get; init; }
#else
        public global::Vellum.NodeOutputCompiledChatHistoryValue? NodeOutputCompiledChatHistoryValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeOutputCompiledChatHistoryValue))]
#endif
        public bool IsNodeOutputCompiledChatHistoryValue => NodeOutputCompiledChatHistoryValue != null;

        /// <summary>
        /// An output returned by a node that is of type SEARCH_RESULTS.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeOutputCompiledSearchResultsValue? NodeOutputCompiledSearchResultsValue { get; init; }
#else
        public global::Vellum.NodeOutputCompiledSearchResultsValue? NodeOutputCompiledSearchResultsValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeOutputCompiledSearchResultsValue))]
#endif
        public bool IsNodeOutputCompiledSearchResultsValue => NodeOutputCompiledSearchResultsValue != null;

        /// <summary>
        /// An output returned by a node that is of type ERROR.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeOutputCompiledErrorValue? NodeOutputCompiledErrorValue { get; init; }
#else
        public global::Vellum.NodeOutputCompiledErrorValue? NodeOutputCompiledErrorValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeOutputCompiledErrorValue))]
#endif
        public bool IsNodeOutputCompiledErrorValue => NodeOutputCompiledErrorValue != null;

        /// <summary>
        /// An output returned by a node that is of type ARRAY.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeOutputCompiledArrayValue? NodeOutputCompiledArrayValue { get; init; }
#else
        public global::Vellum.NodeOutputCompiledArrayValue? NodeOutputCompiledArrayValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeOutputCompiledArrayValue))]
#endif
        public bool IsNodeOutputCompiledArrayValue => NodeOutputCompiledArrayValue != null;

        /// <summary>
        /// An output returned by a node that is of type FUNCTION_CALL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeOutputCompiledFunctionCallValue? NodeOutputCompiledFunctionCallValue { get; init; }
#else
        public global::Vellum.NodeOutputCompiledFunctionCallValue? NodeOutputCompiledFunctionCallValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeOutputCompiledFunctionCallValue))]
#endif
        public bool IsNodeOutputCompiledFunctionCallValue => NodeOutputCompiledFunctionCallValue != null;

        /// <summary>
        /// An output returned by a node that is of type THINKING.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeOutputCompiledThinkingValue? NodeOutputCompiledThinkingValue { get; init; }
#else
        public global::Vellum.NodeOutputCompiledThinkingValue? NodeOutputCompiledThinkingValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeOutputCompiledThinkingValue))]
#endif
        public bool IsNodeOutputCompiledThinkingValue => NodeOutputCompiledThinkingValue != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeOutputCompiledValue(global::Vellum.NodeOutputCompiledStringValue value) => new NodeOutputCompiledValue((global::Vellum.NodeOutputCompiledStringValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeOutputCompiledStringValue?(NodeOutputCompiledValue @this) => @this.NodeOutputCompiledStringValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeOutputCompiledValue(global::Vellum.NodeOutputCompiledStringValue? value)
        {
            NodeOutputCompiledStringValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeOutputCompiledValue(global::Vellum.NodeOutputCompiledNumberValue value) => new NodeOutputCompiledValue((global::Vellum.NodeOutputCompiledNumberValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeOutputCompiledNumberValue?(NodeOutputCompiledValue @this) => @this.NodeOutputCompiledNumberValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeOutputCompiledValue(global::Vellum.NodeOutputCompiledNumberValue? value)
        {
            NodeOutputCompiledNumberValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeOutputCompiledValue(global::Vellum.NodeOutputCompiledJsonValue value) => new NodeOutputCompiledValue((global::Vellum.NodeOutputCompiledJsonValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeOutputCompiledJsonValue?(NodeOutputCompiledValue @this) => @this.NodeOutputCompiledJsonValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeOutputCompiledValue(global::Vellum.NodeOutputCompiledJsonValue? value)
        {
            NodeOutputCompiledJsonValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeOutputCompiledValue(global::Vellum.NodeOutputCompiledChatHistoryValue value) => new NodeOutputCompiledValue((global::Vellum.NodeOutputCompiledChatHistoryValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeOutputCompiledChatHistoryValue?(NodeOutputCompiledValue @this) => @this.NodeOutputCompiledChatHistoryValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeOutputCompiledValue(global::Vellum.NodeOutputCompiledChatHistoryValue? value)
        {
            NodeOutputCompiledChatHistoryValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeOutputCompiledValue(global::Vellum.NodeOutputCompiledSearchResultsValue value) => new NodeOutputCompiledValue((global::Vellum.NodeOutputCompiledSearchResultsValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeOutputCompiledSearchResultsValue?(NodeOutputCompiledValue @this) => @this.NodeOutputCompiledSearchResultsValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeOutputCompiledValue(global::Vellum.NodeOutputCompiledSearchResultsValue? value)
        {
            NodeOutputCompiledSearchResultsValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeOutputCompiledValue(global::Vellum.NodeOutputCompiledErrorValue value) => new NodeOutputCompiledValue((global::Vellum.NodeOutputCompiledErrorValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeOutputCompiledErrorValue?(NodeOutputCompiledValue @this) => @this.NodeOutputCompiledErrorValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeOutputCompiledValue(global::Vellum.NodeOutputCompiledErrorValue? value)
        {
            NodeOutputCompiledErrorValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeOutputCompiledValue(global::Vellum.NodeOutputCompiledArrayValue value) => new NodeOutputCompiledValue((global::Vellum.NodeOutputCompiledArrayValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeOutputCompiledArrayValue?(NodeOutputCompiledValue @this) => @this.NodeOutputCompiledArrayValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeOutputCompiledValue(global::Vellum.NodeOutputCompiledArrayValue? value)
        {
            NodeOutputCompiledArrayValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeOutputCompiledValue(global::Vellum.NodeOutputCompiledFunctionCallValue value) => new NodeOutputCompiledValue((global::Vellum.NodeOutputCompiledFunctionCallValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeOutputCompiledFunctionCallValue?(NodeOutputCompiledValue @this) => @this.NodeOutputCompiledFunctionCallValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeOutputCompiledValue(global::Vellum.NodeOutputCompiledFunctionCallValue? value)
        {
            NodeOutputCompiledFunctionCallValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NodeOutputCompiledValue(global::Vellum.NodeOutputCompiledThinkingValue value) => new NodeOutputCompiledValue((global::Vellum.NodeOutputCompiledThinkingValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeOutputCompiledThinkingValue?(NodeOutputCompiledValue @this) => @this.NodeOutputCompiledThinkingValue;

        /// <summary>
        /// 
        /// </summary>
        public NodeOutputCompiledValue(global::Vellum.NodeOutputCompiledThinkingValue? value)
        {
            NodeOutputCompiledThinkingValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public NodeOutputCompiledValue(
            global::Vellum.NodeOutputCompiledStringValue? nodeOutputCompiledStringValue,
            global::Vellum.NodeOutputCompiledNumberValue? nodeOutputCompiledNumberValue,
            global::Vellum.NodeOutputCompiledJsonValue? nodeOutputCompiledJsonValue,
            global::Vellum.NodeOutputCompiledChatHistoryValue? nodeOutputCompiledChatHistoryValue,
            global::Vellum.NodeOutputCompiledSearchResultsValue? nodeOutputCompiledSearchResultsValue,
            global::Vellum.NodeOutputCompiledErrorValue? nodeOutputCompiledErrorValue,
            global::Vellum.NodeOutputCompiledArrayValue? nodeOutputCompiledArrayValue,
            global::Vellum.NodeOutputCompiledFunctionCallValue? nodeOutputCompiledFunctionCallValue,
            global::Vellum.NodeOutputCompiledThinkingValue? nodeOutputCompiledThinkingValue
            )
        {
            NodeOutputCompiledStringValue = nodeOutputCompiledStringValue;
            NodeOutputCompiledNumberValue = nodeOutputCompiledNumberValue;
            NodeOutputCompiledJsonValue = nodeOutputCompiledJsonValue;
            NodeOutputCompiledChatHistoryValue = nodeOutputCompiledChatHistoryValue;
            NodeOutputCompiledSearchResultsValue = nodeOutputCompiledSearchResultsValue;
            NodeOutputCompiledErrorValue = nodeOutputCompiledErrorValue;
            NodeOutputCompiledArrayValue = nodeOutputCompiledArrayValue;
            NodeOutputCompiledFunctionCallValue = nodeOutputCompiledFunctionCallValue;
            NodeOutputCompiledThinkingValue = nodeOutputCompiledThinkingValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            NodeOutputCompiledThinkingValue as object ??
            NodeOutputCompiledFunctionCallValue as object ??
            NodeOutputCompiledArrayValue as object ??
            NodeOutputCompiledErrorValue as object ??
            NodeOutputCompiledSearchResultsValue as object ??
            NodeOutputCompiledChatHistoryValue as object ??
            NodeOutputCompiledJsonValue as object ??
            NodeOutputCompiledNumberValue as object ??
            NodeOutputCompiledStringValue as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            NodeOutputCompiledStringValue?.ToString() ??
            NodeOutputCompiledNumberValue?.ToString() ??
            NodeOutputCompiledJsonValue?.ToString() ??
            NodeOutputCompiledChatHistoryValue?.ToString() ??
            NodeOutputCompiledSearchResultsValue?.ToString() ??
            NodeOutputCompiledErrorValue?.ToString() ??
            NodeOutputCompiledArrayValue?.ToString() ??
            NodeOutputCompiledFunctionCallValue?.ToString() ??
            NodeOutputCompiledThinkingValue?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNodeOutputCompiledStringValue && !IsNodeOutputCompiledNumberValue && !IsNodeOutputCompiledJsonValue && !IsNodeOutputCompiledChatHistoryValue && !IsNodeOutputCompiledSearchResultsValue && !IsNodeOutputCompiledErrorValue && !IsNodeOutputCompiledArrayValue && !IsNodeOutputCompiledFunctionCallValue && !IsNodeOutputCompiledThinkingValue || !IsNodeOutputCompiledStringValue && IsNodeOutputCompiledNumberValue && !IsNodeOutputCompiledJsonValue && !IsNodeOutputCompiledChatHistoryValue && !IsNodeOutputCompiledSearchResultsValue && !IsNodeOutputCompiledErrorValue && !IsNodeOutputCompiledArrayValue && !IsNodeOutputCompiledFunctionCallValue && !IsNodeOutputCompiledThinkingValue || !IsNodeOutputCompiledStringValue && !IsNodeOutputCompiledNumberValue && IsNodeOutputCompiledJsonValue && !IsNodeOutputCompiledChatHistoryValue && !IsNodeOutputCompiledSearchResultsValue && !IsNodeOutputCompiledErrorValue && !IsNodeOutputCompiledArrayValue && !IsNodeOutputCompiledFunctionCallValue && !IsNodeOutputCompiledThinkingValue || !IsNodeOutputCompiledStringValue && !IsNodeOutputCompiledNumberValue && !IsNodeOutputCompiledJsonValue && IsNodeOutputCompiledChatHistoryValue && !IsNodeOutputCompiledSearchResultsValue && !IsNodeOutputCompiledErrorValue && !IsNodeOutputCompiledArrayValue && !IsNodeOutputCompiledFunctionCallValue && !IsNodeOutputCompiledThinkingValue || !IsNodeOutputCompiledStringValue && !IsNodeOutputCompiledNumberValue && !IsNodeOutputCompiledJsonValue && !IsNodeOutputCompiledChatHistoryValue && IsNodeOutputCompiledSearchResultsValue && !IsNodeOutputCompiledErrorValue && !IsNodeOutputCompiledArrayValue && !IsNodeOutputCompiledFunctionCallValue && !IsNodeOutputCompiledThinkingValue || !IsNodeOutputCompiledStringValue && !IsNodeOutputCompiledNumberValue && !IsNodeOutputCompiledJsonValue && !IsNodeOutputCompiledChatHistoryValue && !IsNodeOutputCompiledSearchResultsValue && IsNodeOutputCompiledErrorValue && !IsNodeOutputCompiledArrayValue && !IsNodeOutputCompiledFunctionCallValue && !IsNodeOutputCompiledThinkingValue || !IsNodeOutputCompiledStringValue && !IsNodeOutputCompiledNumberValue && !IsNodeOutputCompiledJsonValue && !IsNodeOutputCompiledChatHistoryValue && !IsNodeOutputCompiledSearchResultsValue && !IsNodeOutputCompiledErrorValue && IsNodeOutputCompiledArrayValue && !IsNodeOutputCompiledFunctionCallValue && !IsNodeOutputCompiledThinkingValue || !IsNodeOutputCompiledStringValue && !IsNodeOutputCompiledNumberValue && !IsNodeOutputCompiledJsonValue && !IsNodeOutputCompiledChatHistoryValue && !IsNodeOutputCompiledSearchResultsValue && !IsNodeOutputCompiledErrorValue && !IsNodeOutputCompiledArrayValue && IsNodeOutputCompiledFunctionCallValue && !IsNodeOutputCompiledThinkingValue || !IsNodeOutputCompiledStringValue && !IsNodeOutputCompiledNumberValue && !IsNodeOutputCompiledJsonValue && !IsNodeOutputCompiledChatHistoryValue && !IsNodeOutputCompiledSearchResultsValue && !IsNodeOutputCompiledErrorValue && !IsNodeOutputCompiledArrayValue && !IsNodeOutputCompiledFunctionCallValue && IsNodeOutputCompiledThinkingValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.NodeOutputCompiledStringValue?, TResult>? nodeOutputCompiledStringValue = null,
            global::System.Func<global::Vellum.NodeOutputCompiledNumberValue?, TResult>? nodeOutputCompiledNumberValue = null,
            global::System.Func<global::Vellum.NodeOutputCompiledJsonValue?, TResult>? nodeOutputCompiledJsonValue = null,
            global::System.Func<global::Vellum.NodeOutputCompiledChatHistoryValue?, TResult>? nodeOutputCompiledChatHistoryValue = null,
            global::System.Func<global::Vellum.NodeOutputCompiledSearchResultsValue?, TResult>? nodeOutputCompiledSearchResultsValue = null,
            global::System.Func<global::Vellum.NodeOutputCompiledErrorValue?, TResult>? nodeOutputCompiledErrorValue = null,
            global::System.Func<global::Vellum.NodeOutputCompiledArrayValue?, TResult>? nodeOutputCompiledArrayValue = null,
            global::System.Func<global::Vellum.NodeOutputCompiledFunctionCallValue?, TResult>? nodeOutputCompiledFunctionCallValue = null,
            global::System.Func<global::Vellum.NodeOutputCompiledThinkingValue?, TResult>? nodeOutputCompiledThinkingValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNodeOutputCompiledStringValue && nodeOutputCompiledStringValue != null)
            {
                return nodeOutputCompiledStringValue(NodeOutputCompiledStringValue!);
            }
            else if (IsNodeOutputCompiledNumberValue && nodeOutputCompiledNumberValue != null)
            {
                return nodeOutputCompiledNumberValue(NodeOutputCompiledNumberValue!);
            }
            else if (IsNodeOutputCompiledJsonValue && nodeOutputCompiledJsonValue != null)
            {
                return nodeOutputCompiledJsonValue(NodeOutputCompiledJsonValue!);
            }
            else if (IsNodeOutputCompiledChatHistoryValue && nodeOutputCompiledChatHistoryValue != null)
            {
                return nodeOutputCompiledChatHistoryValue(NodeOutputCompiledChatHistoryValue!);
            }
            else if (IsNodeOutputCompiledSearchResultsValue && nodeOutputCompiledSearchResultsValue != null)
            {
                return nodeOutputCompiledSearchResultsValue(NodeOutputCompiledSearchResultsValue!);
            }
            else if (IsNodeOutputCompiledErrorValue && nodeOutputCompiledErrorValue != null)
            {
                return nodeOutputCompiledErrorValue(NodeOutputCompiledErrorValue!);
            }
            else if (IsNodeOutputCompiledArrayValue && nodeOutputCompiledArrayValue != null)
            {
                return nodeOutputCompiledArrayValue(NodeOutputCompiledArrayValue!);
            }
            else if (IsNodeOutputCompiledFunctionCallValue && nodeOutputCompiledFunctionCallValue != null)
            {
                return nodeOutputCompiledFunctionCallValue(NodeOutputCompiledFunctionCallValue!);
            }
            else if (IsNodeOutputCompiledThinkingValue && nodeOutputCompiledThinkingValue != null)
            {
                return nodeOutputCompiledThinkingValue(NodeOutputCompiledThinkingValue!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.NodeOutputCompiledStringValue?>? nodeOutputCompiledStringValue = null,
            global::System.Action<global::Vellum.NodeOutputCompiledNumberValue?>? nodeOutputCompiledNumberValue = null,
            global::System.Action<global::Vellum.NodeOutputCompiledJsonValue?>? nodeOutputCompiledJsonValue = null,
            global::System.Action<global::Vellum.NodeOutputCompiledChatHistoryValue?>? nodeOutputCompiledChatHistoryValue = null,
            global::System.Action<global::Vellum.NodeOutputCompiledSearchResultsValue?>? nodeOutputCompiledSearchResultsValue = null,
            global::System.Action<global::Vellum.NodeOutputCompiledErrorValue?>? nodeOutputCompiledErrorValue = null,
            global::System.Action<global::Vellum.NodeOutputCompiledArrayValue?>? nodeOutputCompiledArrayValue = null,
            global::System.Action<global::Vellum.NodeOutputCompiledFunctionCallValue?>? nodeOutputCompiledFunctionCallValue = null,
            global::System.Action<global::Vellum.NodeOutputCompiledThinkingValue?>? nodeOutputCompiledThinkingValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNodeOutputCompiledStringValue)
            {
                nodeOutputCompiledStringValue?.Invoke(NodeOutputCompiledStringValue!);
            }
            else if (IsNodeOutputCompiledNumberValue)
            {
                nodeOutputCompiledNumberValue?.Invoke(NodeOutputCompiledNumberValue!);
            }
            else if (IsNodeOutputCompiledJsonValue)
            {
                nodeOutputCompiledJsonValue?.Invoke(NodeOutputCompiledJsonValue!);
            }
            else if (IsNodeOutputCompiledChatHistoryValue)
            {
                nodeOutputCompiledChatHistoryValue?.Invoke(NodeOutputCompiledChatHistoryValue!);
            }
            else if (IsNodeOutputCompiledSearchResultsValue)
            {
                nodeOutputCompiledSearchResultsValue?.Invoke(NodeOutputCompiledSearchResultsValue!);
            }
            else if (IsNodeOutputCompiledErrorValue)
            {
                nodeOutputCompiledErrorValue?.Invoke(NodeOutputCompiledErrorValue!);
            }
            else if (IsNodeOutputCompiledArrayValue)
            {
                nodeOutputCompiledArrayValue?.Invoke(NodeOutputCompiledArrayValue!);
            }
            else if (IsNodeOutputCompiledFunctionCallValue)
            {
                nodeOutputCompiledFunctionCallValue?.Invoke(NodeOutputCompiledFunctionCallValue!);
            }
            else if (IsNodeOutputCompiledThinkingValue)
            {
                nodeOutputCompiledThinkingValue?.Invoke(NodeOutputCompiledThinkingValue!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                NodeOutputCompiledStringValue,
                typeof(global::Vellum.NodeOutputCompiledStringValue),
                NodeOutputCompiledNumberValue,
                typeof(global::Vellum.NodeOutputCompiledNumberValue),
                NodeOutputCompiledJsonValue,
                typeof(global::Vellum.NodeOutputCompiledJsonValue),
                NodeOutputCompiledChatHistoryValue,
                typeof(global::Vellum.NodeOutputCompiledChatHistoryValue),
                NodeOutputCompiledSearchResultsValue,
                typeof(global::Vellum.NodeOutputCompiledSearchResultsValue),
                NodeOutputCompiledErrorValue,
                typeof(global::Vellum.NodeOutputCompiledErrorValue),
                NodeOutputCompiledArrayValue,
                typeof(global::Vellum.NodeOutputCompiledArrayValue),
                NodeOutputCompiledFunctionCallValue,
                typeof(global::Vellum.NodeOutputCompiledFunctionCallValue),
                NodeOutputCompiledThinkingValue,
                typeof(global::Vellum.NodeOutputCompiledThinkingValue),
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
        public bool Equals(NodeOutputCompiledValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeOutputCompiledStringValue?>.Default.Equals(NodeOutputCompiledStringValue, other.NodeOutputCompiledStringValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeOutputCompiledNumberValue?>.Default.Equals(NodeOutputCompiledNumberValue, other.NodeOutputCompiledNumberValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeOutputCompiledJsonValue?>.Default.Equals(NodeOutputCompiledJsonValue, other.NodeOutputCompiledJsonValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeOutputCompiledChatHistoryValue?>.Default.Equals(NodeOutputCompiledChatHistoryValue, other.NodeOutputCompiledChatHistoryValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeOutputCompiledSearchResultsValue?>.Default.Equals(NodeOutputCompiledSearchResultsValue, other.NodeOutputCompiledSearchResultsValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeOutputCompiledErrorValue?>.Default.Equals(NodeOutputCompiledErrorValue, other.NodeOutputCompiledErrorValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeOutputCompiledArrayValue?>.Default.Equals(NodeOutputCompiledArrayValue, other.NodeOutputCompiledArrayValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeOutputCompiledFunctionCallValue?>.Default.Equals(NodeOutputCompiledFunctionCallValue, other.NodeOutputCompiledFunctionCallValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeOutputCompiledThinkingValue?>.Default.Equals(NodeOutputCompiledThinkingValue, other.NodeOutputCompiledThinkingValue) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NodeOutputCompiledValue obj1, NodeOutputCompiledValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NodeOutputCompiledValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NodeOutputCompiledValue obj1, NodeOutputCompiledValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NodeOutputCompiledValue o && Equals(o);
        }
    }
}
