#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VellumSpan : global::System.IEquatable<VellumSpan>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowExecutionSpan? WorkflowExecutionSpan { get; init; }
#else
        public global::Vellum.WorkflowExecutionSpan? WorkflowExecutionSpan { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowExecutionSpan))]
#endif
        public bool IsWorkflowExecutionSpan => WorkflowExecutionSpan != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeExecutionSpan? NodeExecutionSpan { get; init; }
#else
        public global::Vellum.NodeExecutionSpan? NodeExecutionSpan { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeExecutionSpan))]
#endif
        public bool IsNodeExecutionSpan => NodeExecutionSpan != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumSpan(global::Vellum.WorkflowExecutionSpan value) => new VellumSpan((global::Vellum.WorkflowExecutionSpan?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowExecutionSpan?(VellumSpan @this) => @this.WorkflowExecutionSpan;

        /// <summary>
        /// 
        /// </summary>
        public VellumSpan(global::Vellum.WorkflowExecutionSpan? value)
        {
            WorkflowExecutionSpan = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumSpan(global::Vellum.NodeExecutionSpan value) => new VellumSpan((global::Vellum.NodeExecutionSpan?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeExecutionSpan?(VellumSpan @this) => @this.NodeExecutionSpan;

        /// <summary>
        /// 
        /// </summary>
        public VellumSpan(global::Vellum.NodeExecutionSpan? value)
        {
            NodeExecutionSpan = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VellumSpan(
            global::Vellum.WorkflowExecutionSpan? workflowExecutionSpan,
            global::Vellum.NodeExecutionSpan? nodeExecutionSpan
            )
        {
            WorkflowExecutionSpan = workflowExecutionSpan;
            NodeExecutionSpan = nodeExecutionSpan;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            NodeExecutionSpan as object ??
            WorkflowExecutionSpan as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WorkflowExecutionSpan?.ToString() ??
            NodeExecutionSpan?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWorkflowExecutionSpan && !IsNodeExecutionSpan || !IsWorkflowExecutionSpan && IsNodeExecutionSpan;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.WorkflowExecutionSpan?, TResult>? workflowExecutionSpan = null,
            global::System.Func<global::Vellum.NodeExecutionSpan?, TResult>? nodeExecutionSpan = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowExecutionSpan && workflowExecutionSpan != null)
            {
                return workflowExecutionSpan(WorkflowExecutionSpan!);
            }
            else if (IsNodeExecutionSpan && nodeExecutionSpan != null)
            {
                return nodeExecutionSpan(NodeExecutionSpan!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.WorkflowExecutionSpan?>? workflowExecutionSpan = null,
            global::System.Action<global::Vellum.NodeExecutionSpan?>? nodeExecutionSpan = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowExecutionSpan)
            {
                workflowExecutionSpan?.Invoke(WorkflowExecutionSpan!);
            }
            else if (IsNodeExecutionSpan)
            {
                nodeExecutionSpan?.Invoke(NodeExecutionSpan!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WorkflowExecutionSpan,
                typeof(global::Vellum.WorkflowExecutionSpan),
                NodeExecutionSpan,
                typeof(global::Vellum.NodeExecutionSpan),
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
        public bool Equals(VellumSpan other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowExecutionSpan?>.Default.Equals(WorkflowExecutionSpan, other.WorkflowExecutionSpan) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeExecutionSpan?>.Default.Equals(NodeExecutionSpan, other.NodeExecutionSpan) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VellumSpan obj1, VellumSpan obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VellumSpan>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VellumSpan obj1, VellumSpan obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VellumSpan o && Equals(o);
        }
    }
}
