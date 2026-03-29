#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VellumNodeExecutionEvent : global::System.IEquatable<VellumNodeExecutionEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeExecutionInitiatedEvent? NodeExecutionInitiatedEvent { get; init; }
#else
        public global::Vellum.NodeExecutionInitiatedEvent? NodeExecutionInitiatedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeExecutionInitiatedEvent))]
#endif
        public bool IsNodeExecutionInitiatedEvent => NodeExecutionInitiatedEvent != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeExecutionStreamingEvent? NodeExecutionStreamingEvent { get; init; }
#else
        public global::Vellum.NodeExecutionStreamingEvent? NodeExecutionStreamingEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeExecutionStreamingEvent))]
#endif
        public bool IsNodeExecutionStreamingEvent => NodeExecutionStreamingEvent != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeExecutionFulfilledEvent? NodeExecutionFulfilledEvent { get; init; }
#else
        public global::Vellum.NodeExecutionFulfilledEvent? NodeExecutionFulfilledEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeExecutionFulfilledEvent))]
#endif
        public bool IsNodeExecutionFulfilledEvent => NodeExecutionFulfilledEvent != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeExecutionRejectedEvent? NodeExecutionRejectedEvent { get; init; }
#else
        public global::Vellum.NodeExecutionRejectedEvent? NodeExecutionRejectedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeExecutionRejectedEvent))]
#endif
        public bool IsNodeExecutionRejectedEvent => NodeExecutionRejectedEvent != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeExecutionPausedEvent? NodeExecutionPausedEvent { get; init; }
#else
        public global::Vellum.NodeExecutionPausedEvent? NodeExecutionPausedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeExecutionPausedEvent))]
#endif
        public bool IsNodeExecutionPausedEvent => NodeExecutionPausedEvent != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeExecutionResumedEvent? NodeExecutionResumedEvent { get; init; }
#else
        public global::Vellum.NodeExecutionResumedEvent? NodeExecutionResumedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeExecutionResumedEvent))]
#endif
        public bool IsNodeExecutionResumedEvent => NodeExecutionResumedEvent != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeExecutionLogEvent? NodeExecutionLogEvent { get; init; }
#else
        public global::Vellum.NodeExecutionLogEvent? NodeExecutionLogEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeExecutionLogEvent))]
#endif
        public bool IsNodeExecutionLogEvent => NodeExecutionLogEvent != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumNodeExecutionEvent(global::Vellum.NodeExecutionInitiatedEvent value) => new VellumNodeExecutionEvent((global::Vellum.NodeExecutionInitiatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeExecutionInitiatedEvent?(VellumNodeExecutionEvent @this) => @this.NodeExecutionInitiatedEvent;

        /// <summary>
        /// 
        /// </summary>
        public VellumNodeExecutionEvent(global::Vellum.NodeExecutionInitiatedEvent? value)
        {
            NodeExecutionInitiatedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumNodeExecutionEvent(global::Vellum.NodeExecutionStreamingEvent value) => new VellumNodeExecutionEvent((global::Vellum.NodeExecutionStreamingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeExecutionStreamingEvent?(VellumNodeExecutionEvent @this) => @this.NodeExecutionStreamingEvent;

        /// <summary>
        /// 
        /// </summary>
        public VellumNodeExecutionEvent(global::Vellum.NodeExecutionStreamingEvent? value)
        {
            NodeExecutionStreamingEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumNodeExecutionEvent(global::Vellum.NodeExecutionFulfilledEvent value) => new VellumNodeExecutionEvent((global::Vellum.NodeExecutionFulfilledEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeExecutionFulfilledEvent?(VellumNodeExecutionEvent @this) => @this.NodeExecutionFulfilledEvent;

        /// <summary>
        /// 
        /// </summary>
        public VellumNodeExecutionEvent(global::Vellum.NodeExecutionFulfilledEvent? value)
        {
            NodeExecutionFulfilledEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumNodeExecutionEvent(global::Vellum.NodeExecutionRejectedEvent value) => new VellumNodeExecutionEvent((global::Vellum.NodeExecutionRejectedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeExecutionRejectedEvent?(VellumNodeExecutionEvent @this) => @this.NodeExecutionRejectedEvent;

        /// <summary>
        /// 
        /// </summary>
        public VellumNodeExecutionEvent(global::Vellum.NodeExecutionRejectedEvent? value)
        {
            NodeExecutionRejectedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumNodeExecutionEvent(global::Vellum.NodeExecutionPausedEvent value) => new VellumNodeExecutionEvent((global::Vellum.NodeExecutionPausedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeExecutionPausedEvent?(VellumNodeExecutionEvent @this) => @this.NodeExecutionPausedEvent;

        /// <summary>
        /// 
        /// </summary>
        public VellumNodeExecutionEvent(global::Vellum.NodeExecutionPausedEvent? value)
        {
            NodeExecutionPausedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumNodeExecutionEvent(global::Vellum.NodeExecutionResumedEvent value) => new VellumNodeExecutionEvent((global::Vellum.NodeExecutionResumedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeExecutionResumedEvent?(VellumNodeExecutionEvent @this) => @this.NodeExecutionResumedEvent;

        /// <summary>
        /// 
        /// </summary>
        public VellumNodeExecutionEvent(global::Vellum.NodeExecutionResumedEvent? value)
        {
            NodeExecutionResumedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumNodeExecutionEvent(global::Vellum.NodeExecutionLogEvent value) => new VellumNodeExecutionEvent((global::Vellum.NodeExecutionLogEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeExecutionLogEvent?(VellumNodeExecutionEvent @this) => @this.NodeExecutionLogEvent;

        /// <summary>
        /// 
        /// </summary>
        public VellumNodeExecutionEvent(global::Vellum.NodeExecutionLogEvent? value)
        {
            NodeExecutionLogEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VellumNodeExecutionEvent(
            global::Vellum.NodeExecutionInitiatedEvent? nodeExecutionInitiatedEvent,
            global::Vellum.NodeExecutionStreamingEvent? nodeExecutionStreamingEvent,
            global::Vellum.NodeExecutionFulfilledEvent? nodeExecutionFulfilledEvent,
            global::Vellum.NodeExecutionRejectedEvent? nodeExecutionRejectedEvent,
            global::Vellum.NodeExecutionPausedEvent? nodeExecutionPausedEvent,
            global::Vellum.NodeExecutionResumedEvent? nodeExecutionResumedEvent,
            global::Vellum.NodeExecutionLogEvent? nodeExecutionLogEvent
            )
        {
            NodeExecutionInitiatedEvent = nodeExecutionInitiatedEvent;
            NodeExecutionStreamingEvent = nodeExecutionStreamingEvent;
            NodeExecutionFulfilledEvent = nodeExecutionFulfilledEvent;
            NodeExecutionRejectedEvent = nodeExecutionRejectedEvent;
            NodeExecutionPausedEvent = nodeExecutionPausedEvent;
            NodeExecutionResumedEvent = nodeExecutionResumedEvent;
            NodeExecutionLogEvent = nodeExecutionLogEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            NodeExecutionLogEvent as object ??
            NodeExecutionResumedEvent as object ??
            NodeExecutionPausedEvent as object ??
            NodeExecutionRejectedEvent as object ??
            NodeExecutionFulfilledEvent as object ??
            NodeExecutionStreamingEvent as object ??
            NodeExecutionInitiatedEvent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            NodeExecutionInitiatedEvent?.ToString() ??
            NodeExecutionStreamingEvent?.ToString() ??
            NodeExecutionFulfilledEvent?.ToString() ??
            NodeExecutionRejectedEvent?.ToString() ??
            NodeExecutionPausedEvent?.ToString() ??
            NodeExecutionResumedEvent?.ToString() ??
            NodeExecutionLogEvent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNodeExecutionInitiatedEvent && !IsNodeExecutionStreamingEvent && !IsNodeExecutionFulfilledEvent && !IsNodeExecutionRejectedEvent && !IsNodeExecutionPausedEvent && !IsNodeExecutionResumedEvent && !IsNodeExecutionLogEvent || !IsNodeExecutionInitiatedEvent && IsNodeExecutionStreamingEvent && !IsNodeExecutionFulfilledEvent && !IsNodeExecutionRejectedEvent && !IsNodeExecutionPausedEvent && !IsNodeExecutionResumedEvent && !IsNodeExecutionLogEvent || !IsNodeExecutionInitiatedEvent && !IsNodeExecutionStreamingEvent && IsNodeExecutionFulfilledEvent && !IsNodeExecutionRejectedEvent && !IsNodeExecutionPausedEvent && !IsNodeExecutionResumedEvent && !IsNodeExecutionLogEvent || !IsNodeExecutionInitiatedEvent && !IsNodeExecutionStreamingEvent && !IsNodeExecutionFulfilledEvent && IsNodeExecutionRejectedEvent && !IsNodeExecutionPausedEvent && !IsNodeExecutionResumedEvent && !IsNodeExecutionLogEvent || !IsNodeExecutionInitiatedEvent && !IsNodeExecutionStreamingEvent && !IsNodeExecutionFulfilledEvent && !IsNodeExecutionRejectedEvent && IsNodeExecutionPausedEvent && !IsNodeExecutionResumedEvent && !IsNodeExecutionLogEvent || !IsNodeExecutionInitiatedEvent && !IsNodeExecutionStreamingEvent && !IsNodeExecutionFulfilledEvent && !IsNodeExecutionRejectedEvent && !IsNodeExecutionPausedEvent && IsNodeExecutionResumedEvent && !IsNodeExecutionLogEvent || !IsNodeExecutionInitiatedEvent && !IsNodeExecutionStreamingEvent && !IsNodeExecutionFulfilledEvent && !IsNodeExecutionRejectedEvent && !IsNodeExecutionPausedEvent && !IsNodeExecutionResumedEvent && IsNodeExecutionLogEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.NodeExecutionInitiatedEvent?, TResult>? nodeExecutionInitiatedEvent = null,
            global::System.Func<global::Vellum.NodeExecutionStreamingEvent?, TResult>? nodeExecutionStreamingEvent = null,
            global::System.Func<global::Vellum.NodeExecutionFulfilledEvent?, TResult>? nodeExecutionFulfilledEvent = null,
            global::System.Func<global::Vellum.NodeExecutionRejectedEvent?, TResult>? nodeExecutionRejectedEvent = null,
            global::System.Func<global::Vellum.NodeExecutionPausedEvent?, TResult>? nodeExecutionPausedEvent = null,
            global::System.Func<global::Vellum.NodeExecutionResumedEvent?, TResult>? nodeExecutionResumedEvent = null,
            global::System.Func<global::Vellum.NodeExecutionLogEvent?, TResult>? nodeExecutionLogEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNodeExecutionInitiatedEvent && nodeExecutionInitiatedEvent != null)
            {
                return nodeExecutionInitiatedEvent(NodeExecutionInitiatedEvent!);
            }
            else if (IsNodeExecutionStreamingEvent && nodeExecutionStreamingEvent != null)
            {
                return nodeExecutionStreamingEvent(NodeExecutionStreamingEvent!);
            }
            else if (IsNodeExecutionFulfilledEvent && nodeExecutionFulfilledEvent != null)
            {
                return nodeExecutionFulfilledEvent(NodeExecutionFulfilledEvent!);
            }
            else if (IsNodeExecutionRejectedEvent && nodeExecutionRejectedEvent != null)
            {
                return nodeExecutionRejectedEvent(NodeExecutionRejectedEvent!);
            }
            else if (IsNodeExecutionPausedEvent && nodeExecutionPausedEvent != null)
            {
                return nodeExecutionPausedEvent(NodeExecutionPausedEvent!);
            }
            else if (IsNodeExecutionResumedEvent && nodeExecutionResumedEvent != null)
            {
                return nodeExecutionResumedEvent(NodeExecutionResumedEvent!);
            }
            else if (IsNodeExecutionLogEvent && nodeExecutionLogEvent != null)
            {
                return nodeExecutionLogEvent(NodeExecutionLogEvent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.NodeExecutionInitiatedEvent?>? nodeExecutionInitiatedEvent = null,
            global::System.Action<global::Vellum.NodeExecutionStreamingEvent?>? nodeExecutionStreamingEvent = null,
            global::System.Action<global::Vellum.NodeExecutionFulfilledEvent?>? nodeExecutionFulfilledEvent = null,
            global::System.Action<global::Vellum.NodeExecutionRejectedEvent?>? nodeExecutionRejectedEvent = null,
            global::System.Action<global::Vellum.NodeExecutionPausedEvent?>? nodeExecutionPausedEvent = null,
            global::System.Action<global::Vellum.NodeExecutionResumedEvent?>? nodeExecutionResumedEvent = null,
            global::System.Action<global::Vellum.NodeExecutionLogEvent?>? nodeExecutionLogEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNodeExecutionInitiatedEvent)
            {
                nodeExecutionInitiatedEvent?.Invoke(NodeExecutionInitiatedEvent!);
            }
            else if (IsNodeExecutionStreamingEvent)
            {
                nodeExecutionStreamingEvent?.Invoke(NodeExecutionStreamingEvent!);
            }
            else if (IsNodeExecutionFulfilledEvent)
            {
                nodeExecutionFulfilledEvent?.Invoke(NodeExecutionFulfilledEvent!);
            }
            else if (IsNodeExecutionRejectedEvent)
            {
                nodeExecutionRejectedEvent?.Invoke(NodeExecutionRejectedEvent!);
            }
            else if (IsNodeExecutionPausedEvent)
            {
                nodeExecutionPausedEvent?.Invoke(NodeExecutionPausedEvent!);
            }
            else if (IsNodeExecutionResumedEvent)
            {
                nodeExecutionResumedEvent?.Invoke(NodeExecutionResumedEvent!);
            }
            else if (IsNodeExecutionLogEvent)
            {
                nodeExecutionLogEvent?.Invoke(NodeExecutionLogEvent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                NodeExecutionInitiatedEvent,
                typeof(global::Vellum.NodeExecutionInitiatedEvent),
                NodeExecutionStreamingEvent,
                typeof(global::Vellum.NodeExecutionStreamingEvent),
                NodeExecutionFulfilledEvent,
                typeof(global::Vellum.NodeExecutionFulfilledEvent),
                NodeExecutionRejectedEvent,
                typeof(global::Vellum.NodeExecutionRejectedEvent),
                NodeExecutionPausedEvent,
                typeof(global::Vellum.NodeExecutionPausedEvent),
                NodeExecutionResumedEvent,
                typeof(global::Vellum.NodeExecutionResumedEvent),
                NodeExecutionLogEvent,
                typeof(global::Vellum.NodeExecutionLogEvent),
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
        public bool Equals(VellumNodeExecutionEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeExecutionInitiatedEvent?>.Default.Equals(NodeExecutionInitiatedEvent, other.NodeExecutionInitiatedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeExecutionStreamingEvent?>.Default.Equals(NodeExecutionStreamingEvent, other.NodeExecutionStreamingEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeExecutionFulfilledEvent?>.Default.Equals(NodeExecutionFulfilledEvent, other.NodeExecutionFulfilledEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeExecutionRejectedEvent?>.Default.Equals(NodeExecutionRejectedEvent, other.NodeExecutionRejectedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeExecutionPausedEvent?>.Default.Equals(NodeExecutionPausedEvent, other.NodeExecutionPausedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeExecutionResumedEvent?>.Default.Equals(NodeExecutionResumedEvent, other.NodeExecutionResumedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeExecutionLogEvent?>.Default.Equals(NodeExecutionLogEvent, other.NodeExecutionLogEvent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VellumNodeExecutionEvent obj1, VellumNodeExecutionEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VellumNodeExecutionEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VellumNodeExecutionEvent obj1, VellumNodeExecutionEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VellumNodeExecutionEvent o && Equals(o);
        }
    }
}
