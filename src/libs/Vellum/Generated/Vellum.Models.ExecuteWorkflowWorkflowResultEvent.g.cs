#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ExecuteWorkflowWorkflowResultEvent : global::System.IEquatable<ExecuteWorkflowWorkflowResultEvent>
    {
        /// <summary>
        /// The successful response from the Workflow execution containing the produced outputs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.FulfilledExecuteWorkflowWorkflowResultEvent? FulfilledExecuteWorkflowWorkflowResultEvent { get; init; }
#else
        public global::Vellum.FulfilledExecuteWorkflowWorkflowResultEvent? FulfilledExecuteWorkflowWorkflowResultEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FulfilledExecuteWorkflowWorkflowResultEvent))]
#endif
        public bool IsFulfilledExecuteWorkflowWorkflowResultEvent => FulfilledExecuteWorkflowWorkflowResultEvent != null;

        /// <summary>
        /// The unsuccessful response from the Workflow execution containing an error specifying what went wrong.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.RejectedExecuteWorkflowWorkflowResultEvent? RejectedExecuteWorkflowWorkflowResultEvent { get; init; }
#else
        public global::Vellum.RejectedExecuteWorkflowWorkflowResultEvent? RejectedExecuteWorkflowWorkflowResultEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RejectedExecuteWorkflowWorkflowResultEvent))]
#endif
        public bool IsRejectedExecuteWorkflowWorkflowResultEvent => RejectedExecuteWorkflowWorkflowResultEvent != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecuteWorkflowWorkflowResultEvent(global::Vellum.FulfilledExecuteWorkflowWorkflowResultEvent value) => new ExecuteWorkflowWorkflowResultEvent((global::Vellum.FulfilledExecuteWorkflowWorkflowResultEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.FulfilledExecuteWorkflowWorkflowResultEvent?(ExecuteWorkflowWorkflowResultEvent @this) => @this.FulfilledExecuteWorkflowWorkflowResultEvent;

        /// <summary>
        /// 
        /// </summary>
        public ExecuteWorkflowWorkflowResultEvent(global::Vellum.FulfilledExecuteWorkflowWorkflowResultEvent? value)
        {
            FulfilledExecuteWorkflowWorkflowResultEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecuteWorkflowWorkflowResultEvent(global::Vellum.RejectedExecuteWorkflowWorkflowResultEvent value) => new ExecuteWorkflowWorkflowResultEvent((global::Vellum.RejectedExecuteWorkflowWorkflowResultEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.RejectedExecuteWorkflowWorkflowResultEvent?(ExecuteWorkflowWorkflowResultEvent @this) => @this.RejectedExecuteWorkflowWorkflowResultEvent;

        /// <summary>
        /// 
        /// </summary>
        public ExecuteWorkflowWorkflowResultEvent(global::Vellum.RejectedExecuteWorkflowWorkflowResultEvent? value)
        {
            RejectedExecuteWorkflowWorkflowResultEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ExecuteWorkflowWorkflowResultEvent(
            global::Vellum.FulfilledExecuteWorkflowWorkflowResultEvent? fulfilledExecuteWorkflowWorkflowResultEvent,
            global::Vellum.RejectedExecuteWorkflowWorkflowResultEvent? rejectedExecuteWorkflowWorkflowResultEvent
            )
        {
            FulfilledExecuteWorkflowWorkflowResultEvent = fulfilledExecuteWorkflowWorkflowResultEvent;
            RejectedExecuteWorkflowWorkflowResultEvent = rejectedExecuteWorkflowWorkflowResultEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RejectedExecuteWorkflowWorkflowResultEvent as object ??
            FulfilledExecuteWorkflowWorkflowResultEvent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FulfilledExecuteWorkflowWorkflowResultEvent?.ToString() ??
            RejectedExecuteWorkflowWorkflowResultEvent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFulfilledExecuteWorkflowWorkflowResultEvent && !IsRejectedExecuteWorkflowWorkflowResultEvent || !IsFulfilledExecuteWorkflowWorkflowResultEvent && IsRejectedExecuteWorkflowWorkflowResultEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.FulfilledExecuteWorkflowWorkflowResultEvent?, TResult>? fulfilledExecuteWorkflowWorkflowResultEvent = null,
            global::System.Func<global::Vellum.RejectedExecuteWorkflowWorkflowResultEvent?, TResult>? rejectedExecuteWorkflowWorkflowResultEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFulfilledExecuteWorkflowWorkflowResultEvent && fulfilledExecuteWorkflowWorkflowResultEvent != null)
            {
                return fulfilledExecuteWorkflowWorkflowResultEvent(FulfilledExecuteWorkflowWorkflowResultEvent!);
            }
            else if (IsRejectedExecuteWorkflowWorkflowResultEvent && rejectedExecuteWorkflowWorkflowResultEvent != null)
            {
                return rejectedExecuteWorkflowWorkflowResultEvent(RejectedExecuteWorkflowWorkflowResultEvent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.FulfilledExecuteWorkflowWorkflowResultEvent?>? fulfilledExecuteWorkflowWorkflowResultEvent = null,
            global::System.Action<global::Vellum.RejectedExecuteWorkflowWorkflowResultEvent?>? rejectedExecuteWorkflowWorkflowResultEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFulfilledExecuteWorkflowWorkflowResultEvent)
            {
                fulfilledExecuteWorkflowWorkflowResultEvent?.Invoke(FulfilledExecuteWorkflowWorkflowResultEvent!);
            }
            else if (IsRejectedExecuteWorkflowWorkflowResultEvent)
            {
                rejectedExecuteWorkflowWorkflowResultEvent?.Invoke(RejectedExecuteWorkflowWorkflowResultEvent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FulfilledExecuteWorkflowWorkflowResultEvent,
                typeof(global::Vellum.FulfilledExecuteWorkflowWorkflowResultEvent),
                RejectedExecuteWorkflowWorkflowResultEvent,
                typeof(global::Vellum.RejectedExecuteWorkflowWorkflowResultEvent),
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
        public bool Equals(ExecuteWorkflowWorkflowResultEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.FulfilledExecuteWorkflowWorkflowResultEvent?>.Default.Equals(FulfilledExecuteWorkflowWorkflowResultEvent, other.FulfilledExecuteWorkflowWorkflowResultEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.RejectedExecuteWorkflowWorkflowResultEvent?>.Default.Equals(RejectedExecuteWorkflowWorkflowResultEvent, other.RejectedExecuteWorkflowWorkflowResultEvent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ExecuteWorkflowWorkflowResultEvent obj1, ExecuteWorkflowWorkflowResultEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ExecuteWorkflowWorkflowResultEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ExecuteWorkflowWorkflowResultEvent obj1, ExecuteWorkflowWorkflowResultEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExecuteWorkflowWorkflowResultEvent o && Equals(o);
        }
    }
}
