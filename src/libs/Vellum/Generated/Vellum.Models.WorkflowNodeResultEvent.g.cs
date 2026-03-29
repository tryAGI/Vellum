#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WorkflowNodeResultEvent : global::System.IEquatable<WorkflowNodeResultEvent>
    {
        /// <summary>
        /// An event that indicates that the node has initiated its execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.InitiatedWorkflowNodeResultEvent? InitiatedWorkflowNodeResultEvent { get; init; }
#else
        public global::Vellum.InitiatedWorkflowNodeResultEvent? InitiatedWorkflowNodeResultEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InitiatedWorkflowNodeResultEvent))]
#endif
        public bool IsInitiatedWorkflowNodeResultEvent => InitiatedWorkflowNodeResultEvent != null;

        /// <summary>
        /// An event that indicates that the node has execution is in progress.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.StreamingWorkflowNodeResultEvent? StreamingWorkflowNodeResultEvent { get; init; }
#else
        public global::Vellum.StreamingWorkflowNodeResultEvent? StreamingWorkflowNodeResultEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingWorkflowNodeResultEvent))]
#endif
        public bool IsStreamingWorkflowNodeResultEvent => StreamingWorkflowNodeResultEvent != null;

        /// <summary>
        /// An event that indicates that the node has fulfilled its execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.FulfilledWorkflowNodeResultEvent? FulfilledWorkflowNodeResultEvent { get; init; }
#else
        public global::Vellum.FulfilledWorkflowNodeResultEvent? FulfilledWorkflowNodeResultEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FulfilledWorkflowNodeResultEvent))]
#endif
        public bool IsFulfilledWorkflowNodeResultEvent => FulfilledWorkflowNodeResultEvent != null;

        /// <summary>
        /// An event that indicates that the node has rejected its execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.RejectedWorkflowNodeResultEvent? RejectedWorkflowNodeResultEvent { get; init; }
#else
        public global::Vellum.RejectedWorkflowNodeResultEvent? RejectedWorkflowNodeResultEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RejectedWorkflowNodeResultEvent))]
#endif
        public bool IsRejectedWorkflowNodeResultEvent => RejectedWorkflowNodeResultEvent != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowNodeResultEvent(global::Vellum.InitiatedWorkflowNodeResultEvent value) => new WorkflowNodeResultEvent((global::Vellum.InitiatedWorkflowNodeResultEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.InitiatedWorkflowNodeResultEvent?(WorkflowNodeResultEvent @this) => @this.InitiatedWorkflowNodeResultEvent;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowNodeResultEvent(global::Vellum.InitiatedWorkflowNodeResultEvent? value)
        {
            InitiatedWorkflowNodeResultEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowNodeResultEvent(global::Vellum.StreamingWorkflowNodeResultEvent value) => new WorkflowNodeResultEvent((global::Vellum.StreamingWorkflowNodeResultEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.StreamingWorkflowNodeResultEvent?(WorkflowNodeResultEvent @this) => @this.StreamingWorkflowNodeResultEvent;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowNodeResultEvent(global::Vellum.StreamingWorkflowNodeResultEvent? value)
        {
            StreamingWorkflowNodeResultEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowNodeResultEvent(global::Vellum.FulfilledWorkflowNodeResultEvent value) => new WorkflowNodeResultEvent((global::Vellum.FulfilledWorkflowNodeResultEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.FulfilledWorkflowNodeResultEvent?(WorkflowNodeResultEvent @this) => @this.FulfilledWorkflowNodeResultEvent;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowNodeResultEvent(global::Vellum.FulfilledWorkflowNodeResultEvent? value)
        {
            FulfilledWorkflowNodeResultEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowNodeResultEvent(global::Vellum.RejectedWorkflowNodeResultEvent value) => new WorkflowNodeResultEvent((global::Vellum.RejectedWorkflowNodeResultEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.RejectedWorkflowNodeResultEvent?(WorkflowNodeResultEvent @this) => @this.RejectedWorkflowNodeResultEvent;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowNodeResultEvent(global::Vellum.RejectedWorkflowNodeResultEvent? value)
        {
            RejectedWorkflowNodeResultEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WorkflowNodeResultEvent(
            global::Vellum.InitiatedWorkflowNodeResultEvent? initiatedWorkflowNodeResultEvent,
            global::Vellum.StreamingWorkflowNodeResultEvent? streamingWorkflowNodeResultEvent,
            global::Vellum.FulfilledWorkflowNodeResultEvent? fulfilledWorkflowNodeResultEvent,
            global::Vellum.RejectedWorkflowNodeResultEvent? rejectedWorkflowNodeResultEvent
            )
        {
            InitiatedWorkflowNodeResultEvent = initiatedWorkflowNodeResultEvent;
            StreamingWorkflowNodeResultEvent = streamingWorkflowNodeResultEvent;
            FulfilledWorkflowNodeResultEvent = fulfilledWorkflowNodeResultEvent;
            RejectedWorkflowNodeResultEvent = rejectedWorkflowNodeResultEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RejectedWorkflowNodeResultEvent as object ??
            FulfilledWorkflowNodeResultEvent as object ??
            StreamingWorkflowNodeResultEvent as object ??
            InitiatedWorkflowNodeResultEvent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InitiatedWorkflowNodeResultEvent?.ToString() ??
            StreamingWorkflowNodeResultEvent?.ToString() ??
            FulfilledWorkflowNodeResultEvent?.ToString() ??
            RejectedWorkflowNodeResultEvent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInitiatedWorkflowNodeResultEvent && !IsStreamingWorkflowNodeResultEvent && !IsFulfilledWorkflowNodeResultEvent && !IsRejectedWorkflowNodeResultEvent || !IsInitiatedWorkflowNodeResultEvent && IsStreamingWorkflowNodeResultEvent && !IsFulfilledWorkflowNodeResultEvent && !IsRejectedWorkflowNodeResultEvent || !IsInitiatedWorkflowNodeResultEvent && !IsStreamingWorkflowNodeResultEvent && IsFulfilledWorkflowNodeResultEvent && !IsRejectedWorkflowNodeResultEvent || !IsInitiatedWorkflowNodeResultEvent && !IsStreamingWorkflowNodeResultEvent && !IsFulfilledWorkflowNodeResultEvent && IsRejectedWorkflowNodeResultEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.InitiatedWorkflowNodeResultEvent?, TResult>? initiatedWorkflowNodeResultEvent = null,
            global::System.Func<global::Vellum.StreamingWorkflowNodeResultEvent?, TResult>? streamingWorkflowNodeResultEvent = null,
            global::System.Func<global::Vellum.FulfilledWorkflowNodeResultEvent?, TResult>? fulfilledWorkflowNodeResultEvent = null,
            global::System.Func<global::Vellum.RejectedWorkflowNodeResultEvent?, TResult>? rejectedWorkflowNodeResultEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInitiatedWorkflowNodeResultEvent && initiatedWorkflowNodeResultEvent != null)
            {
                return initiatedWorkflowNodeResultEvent(InitiatedWorkflowNodeResultEvent!);
            }
            else if (IsStreamingWorkflowNodeResultEvent && streamingWorkflowNodeResultEvent != null)
            {
                return streamingWorkflowNodeResultEvent(StreamingWorkflowNodeResultEvent!);
            }
            else if (IsFulfilledWorkflowNodeResultEvent && fulfilledWorkflowNodeResultEvent != null)
            {
                return fulfilledWorkflowNodeResultEvent(FulfilledWorkflowNodeResultEvent!);
            }
            else if (IsRejectedWorkflowNodeResultEvent && rejectedWorkflowNodeResultEvent != null)
            {
                return rejectedWorkflowNodeResultEvent(RejectedWorkflowNodeResultEvent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.InitiatedWorkflowNodeResultEvent?>? initiatedWorkflowNodeResultEvent = null,
            global::System.Action<global::Vellum.StreamingWorkflowNodeResultEvent?>? streamingWorkflowNodeResultEvent = null,
            global::System.Action<global::Vellum.FulfilledWorkflowNodeResultEvent?>? fulfilledWorkflowNodeResultEvent = null,
            global::System.Action<global::Vellum.RejectedWorkflowNodeResultEvent?>? rejectedWorkflowNodeResultEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInitiatedWorkflowNodeResultEvent)
            {
                initiatedWorkflowNodeResultEvent?.Invoke(InitiatedWorkflowNodeResultEvent!);
            }
            else if (IsStreamingWorkflowNodeResultEvent)
            {
                streamingWorkflowNodeResultEvent?.Invoke(StreamingWorkflowNodeResultEvent!);
            }
            else if (IsFulfilledWorkflowNodeResultEvent)
            {
                fulfilledWorkflowNodeResultEvent?.Invoke(FulfilledWorkflowNodeResultEvent!);
            }
            else if (IsRejectedWorkflowNodeResultEvent)
            {
                rejectedWorkflowNodeResultEvent?.Invoke(RejectedWorkflowNodeResultEvent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InitiatedWorkflowNodeResultEvent,
                typeof(global::Vellum.InitiatedWorkflowNodeResultEvent),
                StreamingWorkflowNodeResultEvent,
                typeof(global::Vellum.StreamingWorkflowNodeResultEvent),
                FulfilledWorkflowNodeResultEvent,
                typeof(global::Vellum.FulfilledWorkflowNodeResultEvent),
                RejectedWorkflowNodeResultEvent,
                typeof(global::Vellum.RejectedWorkflowNodeResultEvent),
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
        public bool Equals(WorkflowNodeResultEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.InitiatedWorkflowNodeResultEvent?>.Default.Equals(InitiatedWorkflowNodeResultEvent, other.InitiatedWorkflowNodeResultEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.StreamingWorkflowNodeResultEvent?>.Default.Equals(StreamingWorkflowNodeResultEvent, other.StreamingWorkflowNodeResultEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.FulfilledWorkflowNodeResultEvent?>.Default.Equals(FulfilledWorkflowNodeResultEvent, other.FulfilledWorkflowNodeResultEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.RejectedWorkflowNodeResultEvent?>.Default.Equals(RejectedWorkflowNodeResultEvent, other.RejectedWorkflowNodeResultEvent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WorkflowNodeResultEvent obj1, WorkflowNodeResultEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WorkflowNodeResultEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WorkflowNodeResultEvent obj1, WorkflowNodeResultEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WorkflowNodeResultEvent o && Equals(o);
        }
    }
}
