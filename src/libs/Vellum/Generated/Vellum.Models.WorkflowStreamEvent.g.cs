#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WorkflowStreamEvent : global::System.IEquatable<WorkflowStreamEvent>
    {
        /// <summary>
        /// A WORKFLOW-level event emitted from the workflow's execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowExecutionWorkflowResultEvent? WorkflowExecutionWorkflowResultEvent { get; init; }
#else
        public global::Vellum.WorkflowExecutionWorkflowResultEvent? WorkflowExecutionWorkflowResultEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowExecutionWorkflowResultEvent))]
#endif
        public bool IsWorkflowExecutionWorkflowResultEvent => WorkflowExecutionWorkflowResultEvent != null;

        /// <summary>
        /// A NODE-level event emitted from the workflow's execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowExecutionNodeResultEvent? WorkflowExecutionNodeResultEvent { get; init; }
#else
        public global::Vellum.WorkflowExecutionNodeResultEvent? WorkflowExecutionNodeResultEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowExecutionNodeResultEvent))]
#endif
        public bool IsWorkflowExecutionNodeResultEvent => WorkflowExecutionNodeResultEvent != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowStreamEvent(global::Vellum.WorkflowExecutionWorkflowResultEvent value) => new WorkflowStreamEvent((global::Vellum.WorkflowExecutionWorkflowResultEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowExecutionWorkflowResultEvent?(WorkflowStreamEvent @this) => @this.WorkflowExecutionWorkflowResultEvent;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowStreamEvent(global::Vellum.WorkflowExecutionWorkflowResultEvent? value)
        {
            WorkflowExecutionWorkflowResultEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowStreamEvent(global::Vellum.WorkflowExecutionNodeResultEvent value) => new WorkflowStreamEvent((global::Vellum.WorkflowExecutionNodeResultEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowExecutionNodeResultEvent?(WorkflowStreamEvent @this) => @this.WorkflowExecutionNodeResultEvent;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowStreamEvent(global::Vellum.WorkflowExecutionNodeResultEvent? value)
        {
            WorkflowExecutionNodeResultEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WorkflowStreamEvent(
            global::Vellum.WorkflowExecutionWorkflowResultEvent? workflowExecutionWorkflowResultEvent,
            global::Vellum.WorkflowExecutionNodeResultEvent? workflowExecutionNodeResultEvent
            )
        {
            WorkflowExecutionWorkflowResultEvent = workflowExecutionWorkflowResultEvent;
            WorkflowExecutionNodeResultEvent = workflowExecutionNodeResultEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WorkflowExecutionNodeResultEvent as object ??
            WorkflowExecutionWorkflowResultEvent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WorkflowExecutionWorkflowResultEvent?.ToString() ??
            WorkflowExecutionNodeResultEvent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWorkflowExecutionWorkflowResultEvent && !IsWorkflowExecutionNodeResultEvent || !IsWorkflowExecutionWorkflowResultEvent && IsWorkflowExecutionNodeResultEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.WorkflowExecutionWorkflowResultEvent?, TResult>? workflowExecutionWorkflowResultEvent = null,
            global::System.Func<global::Vellum.WorkflowExecutionNodeResultEvent?, TResult>? workflowExecutionNodeResultEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowExecutionWorkflowResultEvent && workflowExecutionWorkflowResultEvent != null)
            {
                return workflowExecutionWorkflowResultEvent(WorkflowExecutionWorkflowResultEvent!);
            }
            else if (IsWorkflowExecutionNodeResultEvent && workflowExecutionNodeResultEvent != null)
            {
                return workflowExecutionNodeResultEvent(WorkflowExecutionNodeResultEvent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.WorkflowExecutionWorkflowResultEvent?>? workflowExecutionWorkflowResultEvent = null,
            global::System.Action<global::Vellum.WorkflowExecutionNodeResultEvent?>? workflowExecutionNodeResultEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowExecutionWorkflowResultEvent)
            {
                workflowExecutionWorkflowResultEvent?.Invoke(WorkflowExecutionWorkflowResultEvent!);
            }
            else if (IsWorkflowExecutionNodeResultEvent)
            {
                workflowExecutionNodeResultEvent?.Invoke(WorkflowExecutionNodeResultEvent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WorkflowExecutionWorkflowResultEvent,
                typeof(global::Vellum.WorkflowExecutionWorkflowResultEvent),
                WorkflowExecutionNodeResultEvent,
                typeof(global::Vellum.WorkflowExecutionNodeResultEvent),
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
        public bool Equals(WorkflowStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowExecutionWorkflowResultEvent?>.Default.Equals(WorkflowExecutionWorkflowResultEvent, other.WorkflowExecutionWorkflowResultEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowExecutionNodeResultEvent?>.Default.Equals(WorkflowExecutionNodeResultEvent, other.WorkflowExecutionNodeResultEvent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WorkflowStreamEvent obj1, WorkflowStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WorkflowStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WorkflowStreamEvent obj1, WorkflowStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WorkflowStreamEvent o && Equals(o);
        }
    }
}
