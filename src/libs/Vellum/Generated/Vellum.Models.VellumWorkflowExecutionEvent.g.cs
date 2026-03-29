#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VellumWorkflowExecutionEvent : global::System.IEquatable<VellumWorkflowExecutionEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowExecutionInitiatedEvent? WorkflowExecutionInitiatedEvent { get; init; }
#else
        public global::Vellum.WorkflowExecutionInitiatedEvent? WorkflowExecutionInitiatedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowExecutionInitiatedEvent))]
#endif
        public bool IsWorkflowExecutionInitiatedEvent => WorkflowExecutionInitiatedEvent != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowExecutionStreamingEvent? WorkflowExecutionStreamingEvent { get; init; }
#else
        public global::Vellum.WorkflowExecutionStreamingEvent? WorkflowExecutionStreamingEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowExecutionStreamingEvent))]
#endif
        public bool IsWorkflowExecutionStreamingEvent => WorkflowExecutionStreamingEvent != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowExecutionFulfilledEvent? WorkflowExecutionFulfilledEvent { get; init; }
#else
        public global::Vellum.WorkflowExecutionFulfilledEvent? WorkflowExecutionFulfilledEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowExecutionFulfilledEvent))]
#endif
        public bool IsWorkflowExecutionFulfilledEvent => WorkflowExecutionFulfilledEvent != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowExecutionRejectedEvent? WorkflowExecutionRejectedEvent { get; init; }
#else
        public global::Vellum.WorkflowExecutionRejectedEvent? WorkflowExecutionRejectedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowExecutionRejectedEvent))]
#endif
        public bool IsWorkflowExecutionRejectedEvent => WorkflowExecutionRejectedEvent != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowExecutionPausedEvent? WorkflowExecutionPausedEvent { get; init; }
#else
        public global::Vellum.WorkflowExecutionPausedEvent? WorkflowExecutionPausedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowExecutionPausedEvent))]
#endif
        public bool IsWorkflowExecutionPausedEvent => WorkflowExecutionPausedEvent != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowExecutionResumedEvent? WorkflowExecutionResumedEvent { get; init; }
#else
        public global::Vellum.WorkflowExecutionResumedEvent? WorkflowExecutionResumedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowExecutionResumedEvent))]
#endif
        public bool IsWorkflowExecutionResumedEvent => WorkflowExecutionResumedEvent != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowExecutionSnapshottedEvent? WorkflowExecutionSnapshottedEvent { get; init; }
#else
        public global::Vellum.WorkflowExecutionSnapshottedEvent? WorkflowExecutionSnapshottedEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowExecutionSnapshottedEvent))]
#endif
        public bool IsWorkflowExecutionSnapshottedEvent => WorkflowExecutionSnapshottedEvent != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumWorkflowExecutionEvent(global::Vellum.WorkflowExecutionInitiatedEvent value) => new VellumWorkflowExecutionEvent((global::Vellum.WorkflowExecutionInitiatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowExecutionInitiatedEvent?(VellumWorkflowExecutionEvent @this) => @this.WorkflowExecutionInitiatedEvent;

        /// <summary>
        /// 
        /// </summary>
        public VellumWorkflowExecutionEvent(global::Vellum.WorkflowExecutionInitiatedEvent? value)
        {
            WorkflowExecutionInitiatedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumWorkflowExecutionEvent(global::Vellum.WorkflowExecutionStreamingEvent value) => new VellumWorkflowExecutionEvent((global::Vellum.WorkflowExecutionStreamingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowExecutionStreamingEvent?(VellumWorkflowExecutionEvent @this) => @this.WorkflowExecutionStreamingEvent;

        /// <summary>
        /// 
        /// </summary>
        public VellumWorkflowExecutionEvent(global::Vellum.WorkflowExecutionStreamingEvent? value)
        {
            WorkflowExecutionStreamingEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumWorkflowExecutionEvent(global::Vellum.WorkflowExecutionFulfilledEvent value) => new VellumWorkflowExecutionEvent((global::Vellum.WorkflowExecutionFulfilledEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowExecutionFulfilledEvent?(VellumWorkflowExecutionEvent @this) => @this.WorkflowExecutionFulfilledEvent;

        /// <summary>
        /// 
        /// </summary>
        public VellumWorkflowExecutionEvent(global::Vellum.WorkflowExecutionFulfilledEvent? value)
        {
            WorkflowExecutionFulfilledEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumWorkflowExecutionEvent(global::Vellum.WorkflowExecutionRejectedEvent value) => new VellumWorkflowExecutionEvent((global::Vellum.WorkflowExecutionRejectedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowExecutionRejectedEvent?(VellumWorkflowExecutionEvent @this) => @this.WorkflowExecutionRejectedEvent;

        /// <summary>
        /// 
        /// </summary>
        public VellumWorkflowExecutionEvent(global::Vellum.WorkflowExecutionRejectedEvent? value)
        {
            WorkflowExecutionRejectedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumWorkflowExecutionEvent(global::Vellum.WorkflowExecutionPausedEvent value) => new VellumWorkflowExecutionEvent((global::Vellum.WorkflowExecutionPausedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowExecutionPausedEvent?(VellumWorkflowExecutionEvent @this) => @this.WorkflowExecutionPausedEvent;

        /// <summary>
        /// 
        /// </summary>
        public VellumWorkflowExecutionEvent(global::Vellum.WorkflowExecutionPausedEvent? value)
        {
            WorkflowExecutionPausedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumWorkflowExecutionEvent(global::Vellum.WorkflowExecutionResumedEvent value) => new VellumWorkflowExecutionEvent((global::Vellum.WorkflowExecutionResumedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowExecutionResumedEvent?(VellumWorkflowExecutionEvent @this) => @this.WorkflowExecutionResumedEvent;

        /// <summary>
        /// 
        /// </summary>
        public VellumWorkflowExecutionEvent(global::Vellum.WorkflowExecutionResumedEvent? value)
        {
            WorkflowExecutionResumedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumWorkflowExecutionEvent(global::Vellum.WorkflowExecutionSnapshottedEvent value) => new VellumWorkflowExecutionEvent((global::Vellum.WorkflowExecutionSnapshottedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowExecutionSnapshottedEvent?(VellumWorkflowExecutionEvent @this) => @this.WorkflowExecutionSnapshottedEvent;

        /// <summary>
        /// 
        /// </summary>
        public VellumWorkflowExecutionEvent(global::Vellum.WorkflowExecutionSnapshottedEvent? value)
        {
            WorkflowExecutionSnapshottedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VellumWorkflowExecutionEvent(
            global::Vellum.WorkflowExecutionInitiatedEvent? workflowExecutionInitiatedEvent,
            global::Vellum.WorkflowExecutionStreamingEvent? workflowExecutionStreamingEvent,
            global::Vellum.WorkflowExecutionFulfilledEvent? workflowExecutionFulfilledEvent,
            global::Vellum.WorkflowExecutionRejectedEvent? workflowExecutionRejectedEvent,
            global::Vellum.WorkflowExecutionPausedEvent? workflowExecutionPausedEvent,
            global::Vellum.WorkflowExecutionResumedEvent? workflowExecutionResumedEvent,
            global::Vellum.WorkflowExecutionSnapshottedEvent? workflowExecutionSnapshottedEvent
            )
        {
            WorkflowExecutionInitiatedEvent = workflowExecutionInitiatedEvent;
            WorkflowExecutionStreamingEvent = workflowExecutionStreamingEvent;
            WorkflowExecutionFulfilledEvent = workflowExecutionFulfilledEvent;
            WorkflowExecutionRejectedEvent = workflowExecutionRejectedEvent;
            WorkflowExecutionPausedEvent = workflowExecutionPausedEvent;
            WorkflowExecutionResumedEvent = workflowExecutionResumedEvent;
            WorkflowExecutionSnapshottedEvent = workflowExecutionSnapshottedEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WorkflowExecutionSnapshottedEvent as object ??
            WorkflowExecutionResumedEvent as object ??
            WorkflowExecutionPausedEvent as object ??
            WorkflowExecutionRejectedEvent as object ??
            WorkflowExecutionFulfilledEvent as object ??
            WorkflowExecutionStreamingEvent as object ??
            WorkflowExecutionInitiatedEvent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WorkflowExecutionInitiatedEvent?.ToString() ??
            WorkflowExecutionStreamingEvent?.ToString() ??
            WorkflowExecutionFulfilledEvent?.ToString() ??
            WorkflowExecutionRejectedEvent?.ToString() ??
            WorkflowExecutionPausedEvent?.ToString() ??
            WorkflowExecutionResumedEvent?.ToString() ??
            WorkflowExecutionSnapshottedEvent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWorkflowExecutionInitiatedEvent && !IsWorkflowExecutionStreamingEvent && !IsWorkflowExecutionFulfilledEvent && !IsWorkflowExecutionRejectedEvent && !IsWorkflowExecutionPausedEvent && !IsWorkflowExecutionResumedEvent && !IsWorkflowExecutionSnapshottedEvent || !IsWorkflowExecutionInitiatedEvent && IsWorkflowExecutionStreamingEvent && !IsWorkflowExecutionFulfilledEvent && !IsWorkflowExecutionRejectedEvent && !IsWorkflowExecutionPausedEvent && !IsWorkflowExecutionResumedEvent && !IsWorkflowExecutionSnapshottedEvent || !IsWorkflowExecutionInitiatedEvent && !IsWorkflowExecutionStreamingEvent && IsWorkflowExecutionFulfilledEvent && !IsWorkflowExecutionRejectedEvent && !IsWorkflowExecutionPausedEvent && !IsWorkflowExecutionResumedEvent && !IsWorkflowExecutionSnapshottedEvent || !IsWorkflowExecutionInitiatedEvent && !IsWorkflowExecutionStreamingEvent && !IsWorkflowExecutionFulfilledEvent && IsWorkflowExecutionRejectedEvent && !IsWorkflowExecutionPausedEvent && !IsWorkflowExecutionResumedEvent && !IsWorkflowExecutionSnapshottedEvent || !IsWorkflowExecutionInitiatedEvent && !IsWorkflowExecutionStreamingEvent && !IsWorkflowExecutionFulfilledEvent && !IsWorkflowExecutionRejectedEvent && IsWorkflowExecutionPausedEvent && !IsWorkflowExecutionResumedEvent && !IsWorkflowExecutionSnapshottedEvent || !IsWorkflowExecutionInitiatedEvent && !IsWorkflowExecutionStreamingEvent && !IsWorkflowExecutionFulfilledEvent && !IsWorkflowExecutionRejectedEvent && !IsWorkflowExecutionPausedEvent && IsWorkflowExecutionResumedEvent && !IsWorkflowExecutionSnapshottedEvent || !IsWorkflowExecutionInitiatedEvent && !IsWorkflowExecutionStreamingEvent && !IsWorkflowExecutionFulfilledEvent && !IsWorkflowExecutionRejectedEvent && !IsWorkflowExecutionPausedEvent && !IsWorkflowExecutionResumedEvent && IsWorkflowExecutionSnapshottedEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.WorkflowExecutionInitiatedEvent?, TResult>? workflowExecutionInitiatedEvent = null,
            global::System.Func<global::Vellum.WorkflowExecutionStreamingEvent?, TResult>? workflowExecutionStreamingEvent = null,
            global::System.Func<global::Vellum.WorkflowExecutionFulfilledEvent?, TResult>? workflowExecutionFulfilledEvent = null,
            global::System.Func<global::Vellum.WorkflowExecutionRejectedEvent?, TResult>? workflowExecutionRejectedEvent = null,
            global::System.Func<global::Vellum.WorkflowExecutionPausedEvent?, TResult>? workflowExecutionPausedEvent = null,
            global::System.Func<global::Vellum.WorkflowExecutionResumedEvent?, TResult>? workflowExecutionResumedEvent = null,
            global::System.Func<global::Vellum.WorkflowExecutionSnapshottedEvent?, TResult>? workflowExecutionSnapshottedEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowExecutionInitiatedEvent && workflowExecutionInitiatedEvent != null)
            {
                return workflowExecutionInitiatedEvent(WorkflowExecutionInitiatedEvent!);
            }
            else if (IsWorkflowExecutionStreamingEvent && workflowExecutionStreamingEvent != null)
            {
                return workflowExecutionStreamingEvent(WorkflowExecutionStreamingEvent!);
            }
            else if (IsWorkflowExecutionFulfilledEvent && workflowExecutionFulfilledEvent != null)
            {
                return workflowExecutionFulfilledEvent(WorkflowExecutionFulfilledEvent!);
            }
            else if (IsWorkflowExecutionRejectedEvent && workflowExecutionRejectedEvent != null)
            {
                return workflowExecutionRejectedEvent(WorkflowExecutionRejectedEvent!);
            }
            else if (IsWorkflowExecutionPausedEvent && workflowExecutionPausedEvent != null)
            {
                return workflowExecutionPausedEvent(WorkflowExecutionPausedEvent!);
            }
            else if (IsWorkflowExecutionResumedEvent && workflowExecutionResumedEvent != null)
            {
                return workflowExecutionResumedEvent(WorkflowExecutionResumedEvent!);
            }
            else if (IsWorkflowExecutionSnapshottedEvent && workflowExecutionSnapshottedEvent != null)
            {
                return workflowExecutionSnapshottedEvent(WorkflowExecutionSnapshottedEvent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.WorkflowExecutionInitiatedEvent?>? workflowExecutionInitiatedEvent = null,
            global::System.Action<global::Vellum.WorkflowExecutionStreamingEvent?>? workflowExecutionStreamingEvent = null,
            global::System.Action<global::Vellum.WorkflowExecutionFulfilledEvent?>? workflowExecutionFulfilledEvent = null,
            global::System.Action<global::Vellum.WorkflowExecutionRejectedEvent?>? workflowExecutionRejectedEvent = null,
            global::System.Action<global::Vellum.WorkflowExecutionPausedEvent?>? workflowExecutionPausedEvent = null,
            global::System.Action<global::Vellum.WorkflowExecutionResumedEvent?>? workflowExecutionResumedEvent = null,
            global::System.Action<global::Vellum.WorkflowExecutionSnapshottedEvent?>? workflowExecutionSnapshottedEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowExecutionInitiatedEvent)
            {
                workflowExecutionInitiatedEvent?.Invoke(WorkflowExecutionInitiatedEvent!);
            }
            else if (IsWorkflowExecutionStreamingEvent)
            {
                workflowExecutionStreamingEvent?.Invoke(WorkflowExecutionStreamingEvent!);
            }
            else if (IsWorkflowExecutionFulfilledEvent)
            {
                workflowExecutionFulfilledEvent?.Invoke(WorkflowExecutionFulfilledEvent!);
            }
            else if (IsWorkflowExecutionRejectedEvent)
            {
                workflowExecutionRejectedEvent?.Invoke(WorkflowExecutionRejectedEvent!);
            }
            else if (IsWorkflowExecutionPausedEvent)
            {
                workflowExecutionPausedEvent?.Invoke(WorkflowExecutionPausedEvent!);
            }
            else if (IsWorkflowExecutionResumedEvent)
            {
                workflowExecutionResumedEvent?.Invoke(WorkflowExecutionResumedEvent!);
            }
            else if (IsWorkflowExecutionSnapshottedEvent)
            {
                workflowExecutionSnapshottedEvent?.Invoke(WorkflowExecutionSnapshottedEvent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WorkflowExecutionInitiatedEvent,
                typeof(global::Vellum.WorkflowExecutionInitiatedEvent),
                WorkflowExecutionStreamingEvent,
                typeof(global::Vellum.WorkflowExecutionStreamingEvent),
                WorkflowExecutionFulfilledEvent,
                typeof(global::Vellum.WorkflowExecutionFulfilledEvent),
                WorkflowExecutionRejectedEvent,
                typeof(global::Vellum.WorkflowExecutionRejectedEvent),
                WorkflowExecutionPausedEvent,
                typeof(global::Vellum.WorkflowExecutionPausedEvent),
                WorkflowExecutionResumedEvent,
                typeof(global::Vellum.WorkflowExecutionResumedEvent),
                WorkflowExecutionSnapshottedEvent,
                typeof(global::Vellum.WorkflowExecutionSnapshottedEvent),
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
        public bool Equals(VellumWorkflowExecutionEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowExecutionInitiatedEvent?>.Default.Equals(WorkflowExecutionInitiatedEvent, other.WorkflowExecutionInitiatedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowExecutionStreamingEvent?>.Default.Equals(WorkflowExecutionStreamingEvent, other.WorkflowExecutionStreamingEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowExecutionFulfilledEvent?>.Default.Equals(WorkflowExecutionFulfilledEvent, other.WorkflowExecutionFulfilledEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowExecutionRejectedEvent?>.Default.Equals(WorkflowExecutionRejectedEvent, other.WorkflowExecutionRejectedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowExecutionPausedEvent?>.Default.Equals(WorkflowExecutionPausedEvent, other.WorkflowExecutionPausedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowExecutionResumedEvent?>.Default.Equals(WorkflowExecutionResumedEvent, other.WorkflowExecutionResumedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowExecutionSnapshottedEvent?>.Default.Equals(WorkflowExecutionSnapshottedEvent, other.WorkflowExecutionSnapshottedEvent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VellumWorkflowExecutionEvent obj1, VellumWorkflowExecutionEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VellumWorkflowExecutionEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VellumWorkflowExecutionEvent obj1, VellumWorkflowExecutionEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VellumWorkflowExecutionEvent o && Equals(o);
        }
    }
}
