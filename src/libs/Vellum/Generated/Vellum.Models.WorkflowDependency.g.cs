#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WorkflowDependency : global::System.IEquatable<WorkflowDependency>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowIntegrationDependency? WorkflowIntegrationDependency { get; init; }
#else
        public global::Vellum.WorkflowIntegrationDependency? WorkflowIntegrationDependency { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowIntegrationDependency))]
#endif
        public bool IsWorkflowIntegrationDependency => WorkflowIntegrationDependency != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowModelProviderDependency? WorkflowModelProviderDependency { get; init; }
#else
        public global::Vellum.WorkflowModelProviderDependency? WorkflowModelProviderDependency { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowModelProviderDependency))]
#endif
        public bool IsWorkflowModelProviderDependency => WorkflowModelProviderDependency != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowDependency(global::Vellum.WorkflowIntegrationDependency value) => new WorkflowDependency((global::Vellum.WorkflowIntegrationDependency?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowIntegrationDependency?(WorkflowDependency @this) => @this.WorkflowIntegrationDependency;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowDependency(global::Vellum.WorkflowIntegrationDependency? value)
        {
            WorkflowIntegrationDependency = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowDependency(global::Vellum.WorkflowModelProviderDependency value) => new WorkflowDependency((global::Vellum.WorkflowModelProviderDependency?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowModelProviderDependency?(WorkflowDependency @this) => @this.WorkflowModelProviderDependency;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowDependency(global::Vellum.WorkflowModelProviderDependency? value)
        {
            WorkflowModelProviderDependency = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WorkflowDependency(
            global::Vellum.WorkflowIntegrationDependency? workflowIntegrationDependency,
            global::Vellum.WorkflowModelProviderDependency? workflowModelProviderDependency
            )
        {
            WorkflowIntegrationDependency = workflowIntegrationDependency;
            WorkflowModelProviderDependency = workflowModelProviderDependency;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WorkflowModelProviderDependency as object ??
            WorkflowIntegrationDependency as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WorkflowIntegrationDependency?.ToString() ??
            WorkflowModelProviderDependency?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWorkflowIntegrationDependency && !IsWorkflowModelProviderDependency || !IsWorkflowIntegrationDependency && IsWorkflowModelProviderDependency;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.WorkflowIntegrationDependency?, TResult>? workflowIntegrationDependency = null,
            global::System.Func<global::Vellum.WorkflowModelProviderDependency?, TResult>? workflowModelProviderDependency = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowIntegrationDependency && workflowIntegrationDependency != null)
            {
                return workflowIntegrationDependency(WorkflowIntegrationDependency!);
            }
            else if (IsWorkflowModelProviderDependency && workflowModelProviderDependency != null)
            {
                return workflowModelProviderDependency(WorkflowModelProviderDependency!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.WorkflowIntegrationDependency?>? workflowIntegrationDependency = null,
            global::System.Action<global::Vellum.WorkflowModelProviderDependency?>? workflowModelProviderDependency = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowIntegrationDependency)
            {
                workflowIntegrationDependency?.Invoke(WorkflowIntegrationDependency!);
            }
            else if (IsWorkflowModelProviderDependency)
            {
                workflowModelProviderDependency?.Invoke(WorkflowModelProviderDependency!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WorkflowIntegrationDependency,
                typeof(global::Vellum.WorkflowIntegrationDependency),
                WorkflowModelProviderDependency,
                typeof(global::Vellum.WorkflowModelProviderDependency),
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
        public bool Equals(WorkflowDependency other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowIntegrationDependency?>.Default.Equals(WorkflowIntegrationDependency, other.WorkflowIntegrationDependency) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowModelProviderDependency?>.Default.Equals(WorkflowModelProviderDependency, other.WorkflowModelProviderDependency) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WorkflowDependency obj1, WorkflowDependency obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WorkflowDependency>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WorkflowDependency obj1, WorkflowDependency obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WorkflowDependency o && Equals(o);
        }
    }
}
