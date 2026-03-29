#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WorkflowEvent : global::System.IEquatable<WorkflowEvent>
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
        public static implicit operator WorkflowEvent(global::Vellum.NodeExecutionInitiatedEvent value) => new WorkflowEvent((global::Vellum.NodeExecutionInitiatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeExecutionInitiatedEvent?(WorkflowEvent @this) => @this.NodeExecutionInitiatedEvent;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowEvent(global::Vellum.NodeExecutionInitiatedEvent? value)
        {
            NodeExecutionInitiatedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowEvent(global::Vellum.NodeExecutionStreamingEvent value) => new WorkflowEvent((global::Vellum.NodeExecutionStreamingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeExecutionStreamingEvent?(WorkflowEvent @this) => @this.NodeExecutionStreamingEvent;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowEvent(global::Vellum.NodeExecutionStreamingEvent? value)
        {
            NodeExecutionStreamingEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowEvent(global::Vellum.NodeExecutionFulfilledEvent value) => new WorkflowEvent((global::Vellum.NodeExecutionFulfilledEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeExecutionFulfilledEvent?(WorkflowEvent @this) => @this.NodeExecutionFulfilledEvent;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowEvent(global::Vellum.NodeExecutionFulfilledEvent? value)
        {
            NodeExecutionFulfilledEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowEvent(global::Vellum.NodeExecutionRejectedEvent value) => new WorkflowEvent((global::Vellum.NodeExecutionRejectedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeExecutionRejectedEvent?(WorkflowEvent @this) => @this.NodeExecutionRejectedEvent;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowEvent(global::Vellum.NodeExecutionRejectedEvent? value)
        {
            NodeExecutionRejectedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowEvent(global::Vellum.NodeExecutionPausedEvent value) => new WorkflowEvent((global::Vellum.NodeExecutionPausedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeExecutionPausedEvent?(WorkflowEvent @this) => @this.NodeExecutionPausedEvent;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowEvent(global::Vellum.NodeExecutionPausedEvent? value)
        {
            NodeExecutionPausedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowEvent(global::Vellum.NodeExecutionResumedEvent value) => new WorkflowEvent((global::Vellum.NodeExecutionResumedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeExecutionResumedEvent?(WorkflowEvent @this) => @this.NodeExecutionResumedEvent;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowEvent(global::Vellum.NodeExecutionResumedEvent? value)
        {
            NodeExecutionResumedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowEvent(global::Vellum.NodeExecutionLogEvent value) => new WorkflowEvent((global::Vellum.NodeExecutionLogEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeExecutionLogEvent?(WorkflowEvent @this) => @this.NodeExecutionLogEvent;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowEvent(global::Vellum.NodeExecutionLogEvent? value)
        {
            NodeExecutionLogEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowEvent(global::Vellum.WorkflowExecutionInitiatedEvent value) => new WorkflowEvent((global::Vellum.WorkflowExecutionInitiatedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowExecutionInitiatedEvent?(WorkflowEvent @this) => @this.WorkflowExecutionInitiatedEvent;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowEvent(global::Vellum.WorkflowExecutionInitiatedEvent? value)
        {
            WorkflowExecutionInitiatedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowEvent(global::Vellum.WorkflowExecutionStreamingEvent value) => new WorkflowEvent((global::Vellum.WorkflowExecutionStreamingEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowExecutionStreamingEvent?(WorkflowEvent @this) => @this.WorkflowExecutionStreamingEvent;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowEvent(global::Vellum.WorkflowExecutionStreamingEvent? value)
        {
            WorkflowExecutionStreamingEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowEvent(global::Vellum.WorkflowExecutionRejectedEvent value) => new WorkflowEvent((global::Vellum.WorkflowExecutionRejectedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowExecutionRejectedEvent?(WorkflowEvent @this) => @this.WorkflowExecutionRejectedEvent;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowEvent(global::Vellum.WorkflowExecutionRejectedEvent? value)
        {
            WorkflowExecutionRejectedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowEvent(global::Vellum.WorkflowExecutionFulfilledEvent value) => new WorkflowEvent((global::Vellum.WorkflowExecutionFulfilledEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowExecutionFulfilledEvent?(WorkflowEvent @this) => @this.WorkflowExecutionFulfilledEvent;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowEvent(global::Vellum.WorkflowExecutionFulfilledEvent? value)
        {
            WorkflowExecutionFulfilledEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowEvent(global::Vellum.WorkflowExecutionPausedEvent value) => new WorkflowEvent((global::Vellum.WorkflowExecutionPausedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowExecutionPausedEvent?(WorkflowEvent @this) => @this.WorkflowExecutionPausedEvent;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowEvent(global::Vellum.WorkflowExecutionPausedEvent? value)
        {
            WorkflowExecutionPausedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowEvent(global::Vellum.WorkflowExecutionResumedEvent value) => new WorkflowEvent((global::Vellum.WorkflowExecutionResumedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowExecutionResumedEvent?(WorkflowEvent @this) => @this.WorkflowExecutionResumedEvent;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowEvent(global::Vellum.WorkflowExecutionResumedEvent? value)
        {
            WorkflowExecutionResumedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowEvent(global::Vellum.WorkflowExecutionSnapshottedEvent value) => new WorkflowEvent((global::Vellum.WorkflowExecutionSnapshottedEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowExecutionSnapshottedEvent?(WorkflowEvent @this) => @this.WorkflowExecutionSnapshottedEvent;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowEvent(global::Vellum.WorkflowExecutionSnapshottedEvent? value)
        {
            WorkflowExecutionSnapshottedEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WorkflowEvent(
            global::Vellum.NodeExecutionInitiatedEvent? nodeExecutionInitiatedEvent,
            global::Vellum.NodeExecutionStreamingEvent? nodeExecutionStreamingEvent,
            global::Vellum.NodeExecutionFulfilledEvent? nodeExecutionFulfilledEvent,
            global::Vellum.NodeExecutionRejectedEvent? nodeExecutionRejectedEvent,
            global::Vellum.NodeExecutionPausedEvent? nodeExecutionPausedEvent,
            global::Vellum.NodeExecutionResumedEvent? nodeExecutionResumedEvent,
            global::Vellum.NodeExecutionLogEvent? nodeExecutionLogEvent,
            global::Vellum.WorkflowExecutionInitiatedEvent? workflowExecutionInitiatedEvent,
            global::Vellum.WorkflowExecutionStreamingEvent? workflowExecutionStreamingEvent,
            global::Vellum.WorkflowExecutionRejectedEvent? workflowExecutionRejectedEvent,
            global::Vellum.WorkflowExecutionFulfilledEvent? workflowExecutionFulfilledEvent,
            global::Vellum.WorkflowExecutionPausedEvent? workflowExecutionPausedEvent,
            global::Vellum.WorkflowExecutionResumedEvent? workflowExecutionResumedEvent,
            global::Vellum.WorkflowExecutionSnapshottedEvent? workflowExecutionSnapshottedEvent
            )
        {
            NodeExecutionInitiatedEvent = nodeExecutionInitiatedEvent;
            NodeExecutionStreamingEvent = nodeExecutionStreamingEvent;
            NodeExecutionFulfilledEvent = nodeExecutionFulfilledEvent;
            NodeExecutionRejectedEvent = nodeExecutionRejectedEvent;
            NodeExecutionPausedEvent = nodeExecutionPausedEvent;
            NodeExecutionResumedEvent = nodeExecutionResumedEvent;
            NodeExecutionLogEvent = nodeExecutionLogEvent;
            WorkflowExecutionInitiatedEvent = workflowExecutionInitiatedEvent;
            WorkflowExecutionStreamingEvent = workflowExecutionStreamingEvent;
            WorkflowExecutionRejectedEvent = workflowExecutionRejectedEvent;
            WorkflowExecutionFulfilledEvent = workflowExecutionFulfilledEvent;
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
            WorkflowExecutionFulfilledEvent as object ??
            WorkflowExecutionRejectedEvent as object ??
            WorkflowExecutionStreamingEvent as object ??
            WorkflowExecutionInitiatedEvent as object ??
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
            NodeExecutionLogEvent?.ToString() ??
            WorkflowExecutionInitiatedEvent?.ToString() ??
            WorkflowExecutionStreamingEvent?.ToString() ??
            WorkflowExecutionRejectedEvent?.ToString() ??
            WorkflowExecutionFulfilledEvent?.ToString() ??
            WorkflowExecutionPausedEvent?.ToString() ??
            WorkflowExecutionResumedEvent?.ToString() ??
            WorkflowExecutionSnapshottedEvent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNodeExecutionInitiatedEvent && !IsNodeExecutionStreamingEvent && !IsNodeExecutionFulfilledEvent && !IsNodeExecutionRejectedEvent && !IsNodeExecutionPausedEvent && !IsNodeExecutionResumedEvent && !IsNodeExecutionLogEvent && !IsWorkflowExecutionInitiatedEvent && !IsWorkflowExecutionStreamingEvent && !IsWorkflowExecutionRejectedEvent && !IsWorkflowExecutionFulfilledEvent && !IsWorkflowExecutionPausedEvent && !IsWorkflowExecutionResumedEvent && !IsWorkflowExecutionSnapshottedEvent || !IsNodeExecutionInitiatedEvent && IsNodeExecutionStreamingEvent && !IsNodeExecutionFulfilledEvent && !IsNodeExecutionRejectedEvent && !IsNodeExecutionPausedEvent && !IsNodeExecutionResumedEvent && !IsNodeExecutionLogEvent && !IsWorkflowExecutionInitiatedEvent && !IsWorkflowExecutionStreamingEvent && !IsWorkflowExecutionRejectedEvent && !IsWorkflowExecutionFulfilledEvent && !IsWorkflowExecutionPausedEvent && !IsWorkflowExecutionResumedEvent && !IsWorkflowExecutionSnapshottedEvent || !IsNodeExecutionInitiatedEvent && !IsNodeExecutionStreamingEvent && IsNodeExecutionFulfilledEvent && !IsNodeExecutionRejectedEvent && !IsNodeExecutionPausedEvent && !IsNodeExecutionResumedEvent && !IsNodeExecutionLogEvent && !IsWorkflowExecutionInitiatedEvent && !IsWorkflowExecutionStreamingEvent && !IsWorkflowExecutionRejectedEvent && !IsWorkflowExecutionFulfilledEvent && !IsWorkflowExecutionPausedEvent && !IsWorkflowExecutionResumedEvent && !IsWorkflowExecutionSnapshottedEvent || !IsNodeExecutionInitiatedEvent && !IsNodeExecutionStreamingEvent && !IsNodeExecutionFulfilledEvent && IsNodeExecutionRejectedEvent && !IsNodeExecutionPausedEvent && !IsNodeExecutionResumedEvent && !IsNodeExecutionLogEvent && !IsWorkflowExecutionInitiatedEvent && !IsWorkflowExecutionStreamingEvent && !IsWorkflowExecutionRejectedEvent && !IsWorkflowExecutionFulfilledEvent && !IsWorkflowExecutionPausedEvent && !IsWorkflowExecutionResumedEvent && !IsWorkflowExecutionSnapshottedEvent || !IsNodeExecutionInitiatedEvent && !IsNodeExecutionStreamingEvent && !IsNodeExecutionFulfilledEvent && !IsNodeExecutionRejectedEvent && IsNodeExecutionPausedEvent && !IsNodeExecutionResumedEvent && !IsNodeExecutionLogEvent && !IsWorkflowExecutionInitiatedEvent && !IsWorkflowExecutionStreamingEvent && !IsWorkflowExecutionRejectedEvent && !IsWorkflowExecutionFulfilledEvent && !IsWorkflowExecutionPausedEvent && !IsWorkflowExecutionResumedEvent && !IsWorkflowExecutionSnapshottedEvent || !IsNodeExecutionInitiatedEvent && !IsNodeExecutionStreamingEvent && !IsNodeExecutionFulfilledEvent && !IsNodeExecutionRejectedEvent && !IsNodeExecutionPausedEvent && IsNodeExecutionResumedEvent && !IsNodeExecutionLogEvent && !IsWorkflowExecutionInitiatedEvent && !IsWorkflowExecutionStreamingEvent && !IsWorkflowExecutionRejectedEvent && !IsWorkflowExecutionFulfilledEvent && !IsWorkflowExecutionPausedEvent && !IsWorkflowExecutionResumedEvent && !IsWorkflowExecutionSnapshottedEvent || !IsNodeExecutionInitiatedEvent && !IsNodeExecutionStreamingEvent && !IsNodeExecutionFulfilledEvent && !IsNodeExecutionRejectedEvent && !IsNodeExecutionPausedEvent && !IsNodeExecutionResumedEvent && IsNodeExecutionLogEvent && !IsWorkflowExecutionInitiatedEvent && !IsWorkflowExecutionStreamingEvent && !IsWorkflowExecutionRejectedEvent && !IsWorkflowExecutionFulfilledEvent && !IsWorkflowExecutionPausedEvent && !IsWorkflowExecutionResumedEvent && !IsWorkflowExecutionSnapshottedEvent || !IsNodeExecutionInitiatedEvent && !IsNodeExecutionStreamingEvent && !IsNodeExecutionFulfilledEvent && !IsNodeExecutionRejectedEvent && !IsNodeExecutionPausedEvent && !IsNodeExecutionResumedEvent && !IsNodeExecutionLogEvent && IsWorkflowExecutionInitiatedEvent && !IsWorkflowExecutionStreamingEvent && !IsWorkflowExecutionRejectedEvent && !IsWorkflowExecutionFulfilledEvent && !IsWorkflowExecutionPausedEvent && !IsWorkflowExecutionResumedEvent && !IsWorkflowExecutionSnapshottedEvent || !IsNodeExecutionInitiatedEvent && !IsNodeExecutionStreamingEvent && !IsNodeExecutionFulfilledEvent && !IsNodeExecutionRejectedEvent && !IsNodeExecutionPausedEvent && !IsNodeExecutionResumedEvent && !IsNodeExecutionLogEvent && !IsWorkflowExecutionInitiatedEvent && IsWorkflowExecutionStreamingEvent && !IsWorkflowExecutionRejectedEvent && !IsWorkflowExecutionFulfilledEvent && !IsWorkflowExecutionPausedEvent && !IsWorkflowExecutionResumedEvent && !IsWorkflowExecutionSnapshottedEvent || !IsNodeExecutionInitiatedEvent && !IsNodeExecutionStreamingEvent && !IsNodeExecutionFulfilledEvent && !IsNodeExecutionRejectedEvent && !IsNodeExecutionPausedEvent && !IsNodeExecutionResumedEvent && !IsNodeExecutionLogEvent && !IsWorkflowExecutionInitiatedEvent && !IsWorkflowExecutionStreamingEvent && IsWorkflowExecutionRejectedEvent && !IsWorkflowExecutionFulfilledEvent && !IsWorkflowExecutionPausedEvent && !IsWorkflowExecutionResumedEvent && !IsWorkflowExecutionSnapshottedEvent || !IsNodeExecutionInitiatedEvent && !IsNodeExecutionStreamingEvent && !IsNodeExecutionFulfilledEvent && !IsNodeExecutionRejectedEvent && !IsNodeExecutionPausedEvent && !IsNodeExecutionResumedEvent && !IsNodeExecutionLogEvent && !IsWorkflowExecutionInitiatedEvent && !IsWorkflowExecutionStreamingEvent && !IsWorkflowExecutionRejectedEvent && IsWorkflowExecutionFulfilledEvent && !IsWorkflowExecutionPausedEvent && !IsWorkflowExecutionResumedEvent && !IsWorkflowExecutionSnapshottedEvent || !IsNodeExecutionInitiatedEvent && !IsNodeExecutionStreamingEvent && !IsNodeExecutionFulfilledEvent && !IsNodeExecutionRejectedEvent && !IsNodeExecutionPausedEvent && !IsNodeExecutionResumedEvent && !IsNodeExecutionLogEvent && !IsWorkflowExecutionInitiatedEvent && !IsWorkflowExecutionStreamingEvent && !IsWorkflowExecutionRejectedEvent && !IsWorkflowExecutionFulfilledEvent && IsWorkflowExecutionPausedEvent && !IsWorkflowExecutionResumedEvent && !IsWorkflowExecutionSnapshottedEvent || !IsNodeExecutionInitiatedEvent && !IsNodeExecutionStreamingEvent && !IsNodeExecutionFulfilledEvent && !IsNodeExecutionRejectedEvent && !IsNodeExecutionPausedEvent && !IsNodeExecutionResumedEvent && !IsNodeExecutionLogEvent && !IsWorkflowExecutionInitiatedEvent && !IsWorkflowExecutionStreamingEvent && !IsWorkflowExecutionRejectedEvent && !IsWorkflowExecutionFulfilledEvent && !IsWorkflowExecutionPausedEvent && IsWorkflowExecutionResumedEvent && !IsWorkflowExecutionSnapshottedEvent || !IsNodeExecutionInitiatedEvent && !IsNodeExecutionStreamingEvent && !IsNodeExecutionFulfilledEvent && !IsNodeExecutionRejectedEvent && !IsNodeExecutionPausedEvent && !IsNodeExecutionResumedEvent && !IsNodeExecutionLogEvent && !IsWorkflowExecutionInitiatedEvent && !IsWorkflowExecutionStreamingEvent && !IsWorkflowExecutionRejectedEvent && !IsWorkflowExecutionFulfilledEvent && !IsWorkflowExecutionPausedEvent && !IsWorkflowExecutionResumedEvent && IsWorkflowExecutionSnapshottedEvent;
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
            global::System.Func<global::Vellum.WorkflowExecutionInitiatedEvent?, TResult>? workflowExecutionInitiatedEvent = null,
            global::System.Func<global::Vellum.WorkflowExecutionStreamingEvent?, TResult>? workflowExecutionStreamingEvent = null,
            global::System.Func<global::Vellum.WorkflowExecutionRejectedEvent?, TResult>? workflowExecutionRejectedEvent = null,
            global::System.Func<global::Vellum.WorkflowExecutionFulfilledEvent?, TResult>? workflowExecutionFulfilledEvent = null,
            global::System.Func<global::Vellum.WorkflowExecutionPausedEvent?, TResult>? workflowExecutionPausedEvent = null,
            global::System.Func<global::Vellum.WorkflowExecutionResumedEvent?, TResult>? workflowExecutionResumedEvent = null,
            global::System.Func<global::Vellum.WorkflowExecutionSnapshottedEvent?, TResult>? workflowExecutionSnapshottedEvent = null,
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
            else if (IsWorkflowExecutionInitiatedEvent && workflowExecutionInitiatedEvent != null)
            {
                return workflowExecutionInitiatedEvent(WorkflowExecutionInitiatedEvent!);
            }
            else if (IsWorkflowExecutionStreamingEvent && workflowExecutionStreamingEvent != null)
            {
                return workflowExecutionStreamingEvent(WorkflowExecutionStreamingEvent!);
            }
            else if (IsWorkflowExecutionRejectedEvent && workflowExecutionRejectedEvent != null)
            {
                return workflowExecutionRejectedEvent(WorkflowExecutionRejectedEvent!);
            }
            else if (IsWorkflowExecutionFulfilledEvent && workflowExecutionFulfilledEvent != null)
            {
                return workflowExecutionFulfilledEvent(WorkflowExecutionFulfilledEvent!);
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
            global::System.Action<global::Vellum.NodeExecutionInitiatedEvent?>? nodeExecutionInitiatedEvent = null,
            global::System.Action<global::Vellum.NodeExecutionStreamingEvent?>? nodeExecutionStreamingEvent = null,
            global::System.Action<global::Vellum.NodeExecutionFulfilledEvent?>? nodeExecutionFulfilledEvent = null,
            global::System.Action<global::Vellum.NodeExecutionRejectedEvent?>? nodeExecutionRejectedEvent = null,
            global::System.Action<global::Vellum.NodeExecutionPausedEvent?>? nodeExecutionPausedEvent = null,
            global::System.Action<global::Vellum.NodeExecutionResumedEvent?>? nodeExecutionResumedEvent = null,
            global::System.Action<global::Vellum.NodeExecutionLogEvent?>? nodeExecutionLogEvent = null,
            global::System.Action<global::Vellum.WorkflowExecutionInitiatedEvent?>? workflowExecutionInitiatedEvent = null,
            global::System.Action<global::Vellum.WorkflowExecutionStreamingEvent?>? workflowExecutionStreamingEvent = null,
            global::System.Action<global::Vellum.WorkflowExecutionRejectedEvent?>? workflowExecutionRejectedEvent = null,
            global::System.Action<global::Vellum.WorkflowExecutionFulfilledEvent?>? workflowExecutionFulfilledEvent = null,
            global::System.Action<global::Vellum.WorkflowExecutionPausedEvent?>? workflowExecutionPausedEvent = null,
            global::System.Action<global::Vellum.WorkflowExecutionResumedEvent?>? workflowExecutionResumedEvent = null,
            global::System.Action<global::Vellum.WorkflowExecutionSnapshottedEvent?>? workflowExecutionSnapshottedEvent = null,
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
            else if (IsWorkflowExecutionInitiatedEvent)
            {
                workflowExecutionInitiatedEvent?.Invoke(WorkflowExecutionInitiatedEvent!);
            }
            else if (IsWorkflowExecutionStreamingEvent)
            {
                workflowExecutionStreamingEvent?.Invoke(WorkflowExecutionStreamingEvent!);
            }
            else if (IsWorkflowExecutionRejectedEvent)
            {
                workflowExecutionRejectedEvent?.Invoke(WorkflowExecutionRejectedEvent!);
            }
            else if (IsWorkflowExecutionFulfilledEvent)
            {
                workflowExecutionFulfilledEvent?.Invoke(WorkflowExecutionFulfilledEvent!);
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
                WorkflowExecutionInitiatedEvent,
                typeof(global::Vellum.WorkflowExecutionInitiatedEvent),
                WorkflowExecutionStreamingEvent,
                typeof(global::Vellum.WorkflowExecutionStreamingEvent),
                WorkflowExecutionRejectedEvent,
                typeof(global::Vellum.WorkflowExecutionRejectedEvent),
                WorkflowExecutionFulfilledEvent,
                typeof(global::Vellum.WorkflowExecutionFulfilledEvent),
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
        public bool Equals(WorkflowEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeExecutionInitiatedEvent?>.Default.Equals(NodeExecutionInitiatedEvent, other.NodeExecutionInitiatedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeExecutionStreamingEvent?>.Default.Equals(NodeExecutionStreamingEvent, other.NodeExecutionStreamingEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeExecutionFulfilledEvent?>.Default.Equals(NodeExecutionFulfilledEvent, other.NodeExecutionFulfilledEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeExecutionRejectedEvent?>.Default.Equals(NodeExecutionRejectedEvent, other.NodeExecutionRejectedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeExecutionPausedEvent?>.Default.Equals(NodeExecutionPausedEvent, other.NodeExecutionPausedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeExecutionResumedEvent?>.Default.Equals(NodeExecutionResumedEvent, other.NodeExecutionResumedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeExecutionLogEvent?>.Default.Equals(NodeExecutionLogEvent, other.NodeExecutionLogEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowExecutionInitiatedEvent?>.Default.Equals(WorkflowExecutionInitiatedEvent, other.WorkflowExecutionInitiatedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowExecutionStreamingEvent?>.Default.Equals(WorkflowExecutionStreamingEvent, other.WorkflowExecutionStreamingEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowExecutionRejectedEvent?>.Default.Equals(WorkflowExecutionRejectedEvent, other.WorkflowExecutionRejectedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowExecutionFulfilledEvent?>.Default.Equals(WorkflowExecutionFulfilledEvent, other.WorkflowExecutionFulfilledEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowExecutionPausedEvent?>.Default.Equals(WorkflowExecutionPausedEvent, other.WorkflowExecutionPausedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowExecutionResumedEvent?>.Default.Equals(WorkflowExecutionResumedEvent, other.WorkflowExecutionResumedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowExecutionSnapshottedEvent?>.Default.Equals(WorkflowExecutionSnapshottedEvent, other.WorkflowExecutionSnapshottedEvent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WorkflowEvent obj1, WorkflowEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WorkflowEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WorkflowEvent obj1, WorkflowEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WorkflowEvent o && Equals(o);
        }
    }
}
