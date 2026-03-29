#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WorkflowError : global::System.IEquatable<WorkflowError>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowEventError? WorkflowEventError { get; init; }
#else
        public global::Vellum.WorkflowEventError? WorkflowEventError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowEventError))]
#endif
        public bool IsWorkflowEventError => WorkflowEventError != null;

        /// <summary>
        /// Workflow initialization error.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowInitializationError? WorkflowInitializationError { get; init; }
#else
        public global::Vellum.WorkflowInitializationError? WorkflowInitializationError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowInitializationError))]
#endif
        public bool IsWorkflowInitializationError => WorkflowInitializationError != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowError(global::Vellum.WorkflowEventError value) => new WorkflowError((global::Vellum.WorkflowEventError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowEventError?(WorkflowError @this) => @this.WorkflowEventError;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowError(global::Vellum.WorkflowEventError? value)
        {
            WorkflowEventError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowError(global::Vellum.WorkflowInitializationError value) => new WorkflowError((global::Vellum.WorkflowInitializationError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowInitializationError?(WorkflowError @this) => @this.WorkflowInitializationError;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowError(global::Vellum.WorkflowInitializationError? value)
        {
            WorkflowInitializationError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WorkflowError(
            global::Vellum.WorkflowEventError? workflowEventError,
            global::Vellum.WorkflowInitializationError? workflowInitializationError
            )
        {
            WorkflowEventError = workflowEventError;
            WorkflowInitializationError = workflowInitializationError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WorkflowInitializationError as object ??
            WorkflowEventError as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WorkflowEventError?.ToString() ??
            WorkflowInitializationError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWorkflowEventError && !IsWorkflowInitializationError || !IsWorkflowEventError && IsWorkflowInitializationError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.WorkflowEventError?, TResult>? workflowEventError = null,
            global::System.Func<global::Vellum.WorkflowInitializationError?, TResult>? workflowInitializationError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowEventError && workflowEventError != null)
            {
                return workflowEventError(WorkflowEventError!);
            }
            else if (IsWorkflowInitializationError && workflowInitializationError != null)
            {
                return workflowInitializationError(WorkflowInitializationError!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.WorkflowEventError?>? workflowEventError = null,
            global::System.Action<global::Vellum.WorkflowInitializationError?>? workflowInitializationError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowEventError)
            {
                workflowEventError?.Invoke(WorkflowEventError!);
            }
            else if (IsWorkflowInitializationError)
            {
                workflowInitializationError?.Invoke(WorkflowInitializationError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WorkflowEventError,
                typeof(global::Vellum.WorkflowEventError),
                WorkflowInitializationError,
                typeof(global::Vellum.WorkflowInitializationError),
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
        public bool Equals(WorkflowError other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowEventError?>.Default.Equals(WorkflowEventError, other.WorkflowEventError) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowInitializationError?>.Default.Equals(WorkflowInitializationError, other.WorkflowInitializationError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WorkflowError obj1, WorkflowError obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WorkflowError>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WorkflowError obj1, WorkflowError obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WorkflowError o && Equals(o);
        }
    }
}
