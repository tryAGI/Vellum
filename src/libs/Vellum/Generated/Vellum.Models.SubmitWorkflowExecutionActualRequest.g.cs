#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SubmitWorkflowExecutionActualRequest : global::System.IEquatable<SubmitWorkflowExecutionActualRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowExecutionActualStringRequest? WorkflowExecutionActualStringRequest { get; init; }
#else
        public global::Vellum.WorkflowExecutionActualStringRequest? WorkflowExecutionActualStringRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowExecutionActualStringRequest))]
#endif
        public bool IsWorkflowExecutionActualStringRequest => WorkflowExecutionActualStringRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowExecutionActualJsonRequest? WorkflowExecutionActualJsonRequest { get; init; }
#else
        public global::Vellum.WorkflowExecutionActualJsonRequest? WorkflowExecutionActualJsonRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowExecutionActualJsonRequest))]
#endif
        public bool IsWorkflowExecutionActualJsonRequest => WorkflowExecutionActualJsonRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowExecutionActualChatHistoryRequest? WorkflowExecutionActualChatHistoryRequest { get; init; }
#else
        public global::Vellum.WorkflowExecutionActualChatHistoryRequest? WorkflowExecutionActualChatHistoryRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowExecutionActualChatHistoryRequest))]
#endif
        public bool IsWorkflowExecutionActualChatHistoryRequest => WorkflowExecutionActualChatHistoryRequest != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SubmitWorkflowExecutionActualRequest(global::Vellum.WorkflowExecutionActualStringRequest value) => new SubmitWorkflowExecutionActualRequest((global::Vellum.WorkflowExecutionActualStringRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowExecutionActualStringRequest?(SubmitWorkflowExecutionActualRequest @this) => @this.WorkflowExecutionActualStringRequest;

        /// <summary>
        /// 
        /// </summary>
        public SubmitWorkflowExecutionActualRequest(global::Vellum.WorkflowExecutionActualStringRequest? value)
        {
            WorkflowExecutionActualStringRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SubmitWorkflowExecutionActualRequest(global::Vellum.WorkflowExecutionActualJsonRequest value) => new SubmitWorkflowExecutionActualRequest((global::Vellum.WorkflowExecutionActualJsonRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowExecutionActualJsonRequest?(SubmitWorkflowExecutionActualRequest @this) => @this.WorkflowExecutionActualJsonRequest;

        /// <summary>
        /// 
        /// </summary>
        public SubmitWorkflowExecutionActualRequest(global::Vellum.WorkflowExecutionActualJsonRequest? value)
        {
            WorkflowExecutionActualJsonRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SubmitWorkflowExecutionActualRequest(global::Vellum.WorkflowExecutionActualChatHistoryRequest value) => new SubmitWorkflowExecutionActualRequest((global::Vellum.WorkflowExecutionActualChatHistoryRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowExecutionActualChatHistoryRequest?(SubmitWorkflowExecutionActualRequest @this) => @this.WorkflowExecutionActualChatHistoryRequest;

        /// <summary>
        /// 
        /// </summary>
        public SubmitWorkflowExecutionActualRequest(global::Vellum.WorkflowExecutionActualChatHistoryRequest? value)
        {
            WorkflowExecutionActualChatHistoryRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SubmitWorkflowExecutionActualRequest(
            global::Vellum.WorkflowExecutionActualStringRequest? workflowExecutionActualStringRequest,
            global::Vellum.WorkflowExecutionActualJsonRequest? workflowExecutionActualJsonRequest,
            global::Vellum.WorkflowExecutionActualChatHistoryRequest? workflowExecutionActualChatHistoryRequest
            )
        {
            WorkflowExecutionActualStringRequest = workflowExecutionActualStringRequest;
            WorkflowExecutionActualJsonRequest = workflowExecutionActualJsonRequest;
            WorkflowExecutionActualChatHistoryRequest = workflowExecutionActualChatHistoryRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WorkflowExecutionActualChatHistoryRequest as object ??
            WorkflowExecutionActualJsonRequest as object ??
            WorkflowExecutionActualStringRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WorkflowExecutionActualStringRequest?.ToString() ??
            WorkflowExecutionActualJsonRequest?.ToString() ??
            WorkflowExecutionActualChatHistoryRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWorkflowExecutionActualStringRequest && !IsWorkflowExecutionActualJsonRequest && !IsWorkflowExecutionActualChatHistoryRequest || !IsWorkflowExecutionActualStringRequest && IsWorkflowExecutionActualJsonRequest && !IsWorkflowExecutionActualChatHistoryRequest || !IsWorkflowExecutionActualStringRequest && !IsWorkflowExecutionActualJsonRequest && IsWorkflowExecutionActualChatHistoryRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.WorkflowExecutionActualStringRequest?, TResult>? workflowExecutionActualStringRequest = null,
            global::System.Func<global::Vellum.WorkflowExecutionActualJsonRequest?, TResult>? workflowExecutionActualJsonRequest = null,
            global::System.Func<global::Vellum.WorkflowExecutionActualChatHistoryRequest?, TResult>? workflowExecutionActualChatHistoryRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowExecutionActualStringRequest && workflowExecutionActualStringRequest != null)
            {
                return workflowExecutionActualStringRequest(WorkflowExecutionActualStringRequest!);
            }
            else if (IsWorkflowExecutionActualJsonRequest && workflowExecutionActualJsonRequest != null)
            {
                return workflowExecutionActualJsonRequest(WorkflowExecutionActualJsonRequest!);
            }
            else if (IsWorkflowExecutionActualChatHistoryRequest && workflowExecutionActualChatHistoryRequest != null)
            {
                return workflowExecutionActualChatHistoryRequest(WorkflowExecutionActualChatHistoryRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.WorkflowExecutionActualStringRequest?>? workflowExecutionActualStringRequest = null,
            global::System.Action<global::Vellum.WorkflowExecutionActualJsonRequest?>? workflowExecutionActualJsonRequest = null,
            global::System.Action<global::Vellum.WorkflowExecutionActualChatHistoryRequest?>? workflowExecutionActualChatHistoryRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowExecutionActualStringRequest)
            {
                workflowExecutionActualStringRequest?.Invoke(WorkflowExecutionActualStringRequest!);
            }
            else if (IsWorkflowExecutionActualJsonRequest)
            {
                workflowExecutionActualJsonRequest?.Invoke(WorkflowExecutionActualJsonRequest!);
            }
            else if (IsWorkflowExecutionActualChatHistoryRequest)
            {
                workflowExecutionActualChatHistoryRequest?.Invoke(WorkflowExecutionActualChatHistoryRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WorkflowExecutionActualStringRequest,
                typeof(global::Vellum.WorkflowExecutionActualStringRequest),
                WorkflowExecutionActualJsonRequest,
                typeof(global::Vellum.WorkflowExecutionActualJsonRequest),
                WorkflowExecutionActualChatHistoryRequest,
                typeof(global::Vellum.WorkflowExecutionActualChatHistoryRequest),
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
        public bool Equals(SubmitWorkflowExecutionActualRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowExecutionActualStringRequest?>.Default.Equals(WorkflowExecutionActualStringRequest, other.WorkflowExecutionActualStringRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowExecutionActualJsonRequest?>.Default.Equals(WorkflowExecutionActualJsonRequest, other.WorkflowExecutionActualJsonRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowExecutionActualChatHistoryRequest?>.Default.Equals(WorkflowExecutionActualChatHistoryRequest, other.WorkflowExecutionActualChatHistoryRequest) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SubmitWorkflowExecutionActualRequest obj1, SubmitWorkflowExecutionActualRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SubmitWorkflowExecutionActualRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SubmitWorkflowExecutionActualRequest obj1, SubmitWorkflowExecutionActualRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SubmitWorkflowExecutionActualRequest o && Equals(o);
        }
    }
}
