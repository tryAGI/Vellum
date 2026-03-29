#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateWorkflowEventRequest : global::System.IEquatable<CreateWorkflowEventRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowEvent>? CreateWorkflowEventRequest0 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowEvent>? CreateWorkflowEventRequest0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateWorkflowEventRequest0))]
#endif
        public bool IsCreateWorkflowEventRequest0 => CreateWorkflowEventRequest0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowEvent? WorkflowEvent { get; init; }
#else
        public global::Vellum.WorkflowEvent? WorkflowEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowEvent))]
#endif
        public bool IsWorkflowEvent => WorkflowEvent != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateWorkflowEventRequest(global::Vellum.WorkflowEvent value) => new CreateWorkflowEventRequest((global::Vellum.WorkflowEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowEvent?(CreateWorkflowEventRequest @this) => @this.WorkflowEvent;

        /// <summary>
        /// 
        /// </summary>
        public CreateWorkflowEventRequest(global::Vellum.WorkflowEvent? value)
        {
            WorkflowEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateWorkflowEventRequest(
            global::System.Collections.Generic.IList<global::Vellum.WorkflowEvent>? createWorkflowEventRequest0,
            global::Vellum.WorkflowEvent? workflowEvent
            )
        {
            CreateWorkflowEventRequest0 = createWorkflowEventRequest0;
            WorkflowEvent = workflowEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WorkflowEvent as object ??
            CreateWorkflowEventRequest0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CreateWorkflowEventRequest0?.ToString() ??
            WorkflowEvent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCreateWorkflowEventRequest0 && !IsWorkflowEvent || !IsCreateWorkflowEventRequest0 && IsWorkflowEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::Vellum.WorkflowEvent>?, TResult>? createWorkflowEventRequest0 = null,
            global::System.Func<global::Vellum.WorkflowEvent?, TResult>? workflowEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateWorkflowEventRequest0 && createWorkflowEventRequest0 != null)
            {
                return createWorkflowEventRequest0(CreateWorkflowEventRequest0!);
            }
            else if (IsWorkflowEvent && workflowEvent != null)
            {
                return workflowEvent(WorkflowEvent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::Vellum.WorkflowEvent>?>? createWorkflowEventRequest0 = null,
            global::System.Action<global::Vellum.WorkflowEvent?>? workflowEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCreateWorkflowEventRequest0)
            {
                createWorkflowEventRequest0?.Invoke(CreateWorkflowEventRequest0!);
            }
            else if (IsWorkflowEvent)
            {
                workflowEvent?.Invoke(WorkflowEvent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateWorkflowEventRequest0,
                typeof(global::System.Collections.Generic.IList<global::Vellum.WorkflowEvent>),
                WorkflowEvent,
                typeof(global::Vellum.WorkflowEvent),
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
        public bool Equals(CreateWorkflowEventRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Vellum.WorkflowEvent>?>.Default.Equals(CreateWorkflowEventRequest0, other.CreateWorkflowEventRequest0) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowEvent?>.Default.Equals(WorkflowEvent, other.WorkflowEvent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateWorkflowEventRequest obj1, CreateWorkflowEventRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateWorkflowEventRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateWorkflowEventRequest obj1, CreateWorkflowEventRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateWorkflowEventRequest o && Equals(o);
        }
    }
}
