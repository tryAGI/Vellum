#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WorkflowEventErrorRawData : global::System.IEquatable<WorkflowEventErrorRawData>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? WorkflowEventErrorRawDataVariant1 { get; init; }
#else
        public object? WorkflowEventErrorRawDataVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowEventErrorRawDataVariant1))]
#endif
        public bool IsWorkflowEventErrorRawDataVariant1 => WorkflowEventErrorRawDataVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? WorkflowEventErrorRawDataVariant2 { get; init; }
#else
        public string? WorkflowEventErrorRawDataVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowEventErrorRawDataVariant2))]
#endif
        public bool IsWorkflowEventErrorRawDataVariant2 => WorkflowEventErrorRawDataVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowEventErrorRawData(string value) => new WorkflowEventErrorRawData((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(WorkflowEventErrorRawData @this) => @this.WorkflowEventErrorRawDataVariant2;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowEventErrorRawData(string? value)
        {
            WorkflowEventErrorRawDataVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WorkflowEventErrorRawData(
            object? workflowEventErrorRawDataVariant1,
            string? workflowEventErrorRawDataVariant2
            )
        {
            WorkflowEventErrorRawDataVariant1 = workflowEventErrorRawDataVariant1;
            WorkflowEventErrorRawDataVariant2 = workflowEventErrorRawDataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WorkflowEventErrorRawDataVariant2 as object ??
            WorkflowEventErrorRawDataVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WorkflowEventErrorRawDataVariant1?.ToString() ??
            WorkflowEventErrorRawDataVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWorkflowEventErrorRawDataVariant1 && !IsWorkflowEventErrorRawDataVariant2 || !IsWorkflowEventErrorRawDataVariant1 && IsWorkflowEventErrorRawDataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<object?, TResult>? workflowEventErrorRawDataVariant1 = null,
            global::System.Func<string?, TResult>? workflowEventErrorRawDataVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowEventErrorRawDataVariant1 && workflowEventErrorRawDataVariant1 != null)
            {
                return workflowEventErrorRawDataVariant1(WorkflowEventErrorRawDataVariant1!);
            }
            else if (IsWorkflowEventErrorRawDataVariant2 && workflowEventErrorRawDataVariant2 != null)
            {
                return workflowEventErrorRawDataVariant2(WorkflowEventErrorRawDataVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<object?>? workflowEventErrorRawDataVariant1 = null,
            global::System.Action<string?>? workflowEventErrorRawDataVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowEventErrorRawDataVariant1)
            {
                workflowEventErrorRawDataVariant1?.Invoke(WorkflowEventErrorRawDataVariant1!);
            }
            else if (IsWorkflowEventErrorRawDataVariant2)
            {
                workflowEventErrorRawDataVariant2?.Invoke(WorkflowEventErrorRawDataVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WorkflowEventErrorRawDataVariant1,
                typeof(object),
                WorkflowEventErrorRawDataVariant2,
                typeof(string),
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
        public bool Equals(WorkflowEventErrorRawData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(WorkflowEventErrorRawDataVariant1, other.WorkflowEventErrorRawDataVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(WorkflowEventErrorRawDataVariant2, other.WorkflowEventErrorRawDataVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WorkflowEventErrorRawData obj1, WorkflowEventErrorRawData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WorkflowEventErrorRawData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WorkflowEventErrorRawData obj1, WorkflowEventErrorRawData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WorkflowEventErrorRawData o && Equals(o);
        }
    }
}
