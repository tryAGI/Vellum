#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct WorkflowRequestInputRequest : global::System.IEquatable<WorkflowRequestInputRequest>
    {
        /// <summary>
        /// The input for a string variable in a Workflow.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowRequestStringInputRequest? WorkflowRequestStringInputRequest { get; init; }
#else
        public global::Vellum.WorkflowRequestStringInputRequest? WorkflowRequestStringInputRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowRequestStringInputRequest))]
#endif
        public bool IsWorkflowRequestStringInputRequest => WorkflowRequestStringInputRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflowRequestStringInputRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.WorkflowRequestStringInputRequest? value)
        {
            value = WorkflowRequestStringInputRequest;
            return IsWorkflowRequestStringInputRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestStringInputRequest PickWorkflowRequestStringInputRequest() => WorkflowRequestStringInputRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowRequestStringInputRequest' but the value was {ToString()}.");

        /// <summary>
        /// The input for a JSON variable in a Workflow.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowRequestJSONInputRequest? WorkflowRequestJSONInputRequest { get; init; }
#else
        public global::Vellum.WorkflowRequestJSONInputRequest? WorkflowRequestJSONInputRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowRequestJSONInputRequest))]
#endif
        public bool IsWorkflowRequestJSONInputRequest => WorkflowRequestJSONInputRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflowRequestJSONInputRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.WorkflowRequestJSONInputRequest? value)
        {
            value = WorkflowRequestJSONInputRequest;
            return IsWorkflowRequestJSONInputRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestJSONInputRequest PickWorkflowRequestJSONInputRequest() => WorkflowRequestJSONInputRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowRequestJSONInputRequest' but the value was {ToString()}.");

        /// <summary>
        /// The input for a chat history variable in a Workflow.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowRequestChatHistoryInputRequest? WorkflowRequestChatHistoryInputRequest { get; init; }
#else
        public global::Vellum.WorkflowRequestChatHistoryInputRequest? WorkflowRequestChatHistoryInputRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowRequestChatHistoryInputRequest))]
#endif
        public bool IsWorkflowRequestChatHistoryInputRequest => WorkflowRequestChatHistoryInputRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflowRequestChatHistoryInputRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.WorkflowRequestChatHistoryInputRequest? value)
        {
            value = WorkflowRequestChatHistoryInputRequest;
            return IsWorkflowRequestChatHistoryInputRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestChatHistoryInputRequest PickWorkflowRequestChatHistoryInputRequest() => WorkflowRequestChatHistoryInputRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowRequestChatHistoryInputRequest' but the value was {ToString()}.");

        /// <summary>
        /// The input for a number variable in a Workflow.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowRequestNumberInputRequest? WorkflowRequestNumberInputRequest { get; init; }
#else
        public global::Vellum.WorkflowRequestNumberInputRequest? WorkflowRequestNumberInputRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowRequestNumberInputRequest))]
#endif
        public bool IsWorkflowRequestNumberInputRequest => WorkflowRequestNumberInputRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflowRequestNumberInputRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.WorkflowRequestNumberInputRequest? value)
        {
            value = WorkflowRequestNumberInputRequest;
            return IsWorkflowRequestNumberInputRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestNumberInputRequest PickWorkflowRequestNumberInputRequest() => WorkflowRequestNumberInputRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowRequestNumberInputRequest' but the value was {ToString()}.");

        /// <summary>
        /// The input for an audio variable in a Workflow.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowRequestAudioInputRequest? WorkflowRequestAudioInputRequest { get; init; }
#else
        public global::Vellum.WorkflowRequestAudioInputRequest? WorkflowRequestAudioInputRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowRequestAudioInputRequest))]
#endif
        public bool IsWorkflowRequestAudioInputRequest => WorkflowRequestAudioInputRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflowRequestAudioInputRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.WorkflowRequestAudioInputRequest? value)
        {
            value = WorkflowRequestAudioInputRequest;
            return IsWorkflowRequestAudioInputRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestAudioInputRequest PickWorkflowRequestAudioInputRequest() => WorkflowRequestAudioInputRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowRequestAudioInputRequest' but the value was {ToString()}.");

        /// <summary>
        /// The input for a video variable in a Workflow.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowRequestVideoInputRequest? WorkflowRequestVideoInputRequest { get; init; }
#else
        public global::Vellum.WorkflowRequestVideoInputRequest? WorkflowRequestVideoInputRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowRequestVideoInputRequest))]
#endif
        public bool IsWorkflowRequestVideoInputRequest => WorkflowRequestVideoInputRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflowRequestVideoInputRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.WorkflowRequestVideoInputRequest? value)
        {
            value = WorkflowRequestVideoInputRequest;
            return IsWorkflowRequestVideoInputRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestVideoInputRequest PickWorkflowRequestVideoInputRequest() => WorkflowRequestVideoInputRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowRequestVideoInputRequest' but the value was {ToString()}.");

        /// <summary>
        /// The input for an image variable in a Workflow.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowRequestImageInputRequest? WorkflowRequestImageInputRequest { get; init; }
#else
        public global::Vellum.WorkflowRequestImageInputRequest? WorkflowRequestImageInputRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowRequestImageInputRequest))]
#endif
        public bool IsWorkflowRequestImageInputRequest => WorkflowRequestImageInputRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflowRequestImageInputRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.WorkflowRequestImageInputRequest? value)
        {
            value = WorkflowRequestImageInputRequest;
            return IsWorkflowRequestImageInputRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestImageInputRequest PickWorkflowRequestImageInputRequest() => WorkflowRequestImageInputRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowRequestImageInputRequest' but the value was {ToString()}.");

        /// <summary>
        /// The input for a document variable in a Workflow.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowRequestDocumentInputRequest? WorkflowRequestDocumentInputRequest { get; init; }
#else
        public global::Vellum.WorkflowRequestDocumentInputRequest? WorkflowRequestDocumentInputRequest { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowRequestDocumentInputRequest))]
#endif
        public bool IsWorkflowRequestDocumentInputRequest => WorkflowRequestDocumentInputRequest != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkflowRequestDocumentInputRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.WorkflowRequestDocumentInputRequest? value)
        {
            value = WorkflowRequestDocumentInputRequest;
            return IsWorkflowRequestDocumentInputRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestDocumentInputRequest PickWorkflowRequestDocumentInputRequest() => WorkflowRequestDocumentInputRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowRequestDocumentInputRequest' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkflowRequestInputRequest(global::Vellum.WorkflowRequestStringInputRequest value) => new WorkflowRequestInputRequest((global::Vellum.WorkflowRequestStringInputRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vellum.WorkflowRequestStringInputRequest?(WorkflowRequestInputRequest @this) => @this.WorkflowRequestStringInputRequest;

        /// <summary>
        ///
        /// </summary>
        public WorkflowRequestInputRequest(global::Vellum.WorkflowRequestStringInputRequest? value)
        {
            WorkflowRequestStringInputRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkflowRequestInputRequest FromWorkflowRequestStringInputRequest(global::Vellum.WorkflowRequestStringInputRequest? value) => new WorkflowRequestInputRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkflowRequestInputRequest(global::Vellum.WorkflowRequestJSONInputRequest value) => new WorkflowRequestInputRequest((global::Vellum.WorkflowRequestJSONInputRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vellum.WorkflowRequestJSONInputRequest?(WorkflowRequestInputRequest @this) => @this.WorkflowRequestJSONInputRequest;

        /// <summary>
        ///
        /// </summary>
        public WorkflowRequestInputRequest(global::Vellum.WorkflowRequestJSONInputRequest? value)
        {
            WorkflowRequestJSONInputRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkflowRequestInputRequest FromWorkflowRequestJSONInputRequest(global::Vellum.WorkflowRequestJSONInputRequest? value) => new WorkflowRequestInputRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkflowRequestInputRequest(global::Vellum.WorkflowRequestChatHistoryInputRequest value) => new WorkflowRequestInputRequest((global::Vellum.WorkflowRequestChatHistoryInputRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vellum.WorkflowRequestChatHistoryInputRequest?(WorkflowRequestInputRequest @this) => @this.WorkflowRequestChatHistoryInputRequest;

        /// <summary>
        ///
        /// </summary>
        public WorkflowRequestInputRequest(global::Vellum.WorkflowRequestChatHistoryInputRequest? value)
        {
            WorkflowRequestChatHistoryInputRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkflowRequestInputRequest FromWorkflowRequestChatHistoryInputRequest(global::Vellum.WorkflowRequestChatHistoryInputRequest? value) => new WorkflowRequestInputRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkflowRequestInputRequest(global::Vellum.WorkflowRequestNumberInputRequest value) => new WorkflowRequestInputRequest((global::Vellum.WorkflowRequestNumberInputRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vellum.WorkflowRequestNumberInputRequest?(WorkflowRequestInputRequest @this) => @this.WorkflowRequestNumberInputRequest;

        /// <summary>
        ///
        /// </summary>
        public WorkflowRequestInputRequest(global::Vellum.WorkflowRequestNumberInputRequest? value)
        {
            WorkflowRequestNumberInputRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkflowRequestInputRequest FromWorkflowRequestNumberInputRequest(global::Vellum.WorkflowRequestNumberInputRequest? value) => new WorkflowRequestInputRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkflowRequestInputRequest(global::Vellum.WorkflowRequestAudioInputRequest value) => new WorkflowRequestInputRequest((global::Vellum.WorkflowRequestAudioInputRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vellum.WorkflowRequestAudioInputRequest?(WorkflowRequestInputRequest @this) => @this.WorkflowRequestAudioInputRequest;

        /// <summary>
        ///
        /// </summary>
        public WorkflowRequestInputRequest(global::Vellum.WorkflowRequestAudioInputRequest? value)
        {
            WorkflowRequestAudioInputRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkflowRequestInputRequest FromWorkflowRequestAudioInputRequest(global::Vellum.WorkflowRequestAudioInputRequest? value) => new WorkflowRequestInputRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkflowRequestInputRequest(global::Vellum.WorkflowRequestVideoInputRequest value) => new WorkflowRequestInputRequest((global::Vellum.WorkflowRequestVideoInputRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vellum.WorkflowRequestVideoInputRequest?(WorkflowRequestInputRequest @this) => @this.WorkflowRequestVideoInputRequest;

        /// <summary>
        ///
        /// </summary>
        public WorkflowRequestInputRequest(global::Vellum.WorkflowRequestVideoInputRequest? value)
        {
            WorkflowRequestVideoInputRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkflowRequestInputRequest FromWorkflowRequestVideoInputRequest(global::Vellum.WorkflowRequestVideoInputRequest? value) => new WorkflowRequestInputRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkflowRequestInputRequest(global::Vellum.WorkflowRequestImageInputRequest value) => new WorkflowRequestInputRequest((global::Vellum.WorkflowRequestImageInputRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vellum.WorkflowRequestImageInputRequest?(WorkflowRequestInputRequest @this) => @this.WorkflowRequestImageInputRequest;

        /// <summary>
        ///
        /// </summary>
        public WorkflowRequestInputRequest(global::Vellum.WorkflowRequestImageInputRequest? value)
        {
            WorkflowRequestImageInputRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkflowRequestInputRequest FromWorkflowRequestImageInputRequest(global::Vellum.WorkflowRequestImageInputRequest? value) => new WorkflowRequestInputRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkflowRequestInputRequest(global::Vellum.WorkflowRequestDocumentInputRequest value) => new WorkflowRequestInputRequest((global::Vellum.WorkflowRequestDocumentInputRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vellum.WorkflowRequestDocumentInputRequest?(WorkflowRequestInputRequest @this) => @this.WorkflowRequestDocumentInputRequest;

        /// <summary>
        ///
        /// </summary>
        public WorkflowRequestInputRequest(global::Vellum.WorkflowRequestDocumentInputRequest? value)
        {
            WorkflowRequestDocumentInputRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkflowRequestInputRequest FromWorkflowRequestDocumentInputRequest(global::Vellum.WorkflowRequestDocumentInputRequest? value) => new WorkflowRequestInputRequest(value);

        /// <summary>
        ///
        /// </summary>
        public WorkflowRequestInputRequest(
            global::Vellum.WorkflowRequestStringInputRequest? workflowRequestStringInputRequest,
            global::Vellum.WorkflowRequestJSONInputRequest? workflowRequestJSONInputRequest,
            global::Vellum.WorkflowRequestChatHistoryInputRequest? workflowRequestChatHistoryInputRequest,
            global::Vellum.WorkflowRequestNumberInputRequest? workflowRequestNumberInputRequest,
            global::Vellum.WorkflowRequestAudioInputRequest? workflowRequestAudioInputRequest,
            global::Vellum.WorkflowRequestVideoInputRequest? workflowRequestVideoInputRequest,
            global::Vellum.WorkflowRequestImageInputRequest? workflowRequestImageInputRequest,
            global::Vellum.WorkflowRequestDocumentInputRequest? workflowRequestDocumentInputRequest
            )
        {
            WorkflowRequestStringInputRequest = workflowRequestStringInputRequest;
            WorkflowRequestJSONInputRequest = workflowRequestJSONInputRequest;
            WorkflowRequestChatHistoryInputRequest = workflowRequestChatHistoryInputRequest;
            WorkflowRequestNumberInputRequest = workflowRequestNumberInputRequest;
            WorkflowRequestAudioInputRequest = workflowRequestAudioInputRequest;
            WorkflowRequestVideoInputRequest = workflowRequestVideoInputRequest;
            WorkflowRequestImageInputRequest = workflowRequestImageInputRequest;
            WorkflowRequestDocumentInputRequest = workflowRequestDocumentInputRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WorkflowRequestDocumentInputRequest as object ??
            WorkflowRequestImageInputRequest as object ??
            WorkflowRequestVideoInputRequest as object ??
            WorkflowRequestAudioInputRequest as object ??
            WorkflowRequestNumberInputRequest as object ??
            WorkflowRequestChatHistoryInputRequest as object ??
            WorkflowRequestJSONInputRequest as object ??
            WorkflowRequestStringInputRequest as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            WorkflowRequestStringInputRequest?.ToString() ??
            WorkflowRequestJSONInputRequest?.ToString() ??
            WorkflowRequestChatHistoryInputRequest?.ToString() ??
            WorkflowRequestNumberInputRequest?.ToString() ??
            WorkflowRequestAudioInputRequest?.ToString() ??
            WorkflowRequestVideoInputRequest?.ToString() ??
            WorkflowRequestImageInputRequest?.ToString() ??
            WorkflowRequestDocumentInputRequest?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsWorkflowRequestStringInputRequest && !IsWorkflowRequestJSONInputRequest && !IsWorkflowRequestChatHistoryInputRequest && !IsWorkflowRequestNumberInputRequest && !IsWorkflowRequestAudioInputRequest && !IsWorkflowRequestVideoInputRequest && !IsWorkflowRequestImageInputRequest && !IsWorkflowRequestDocumentInputRequest || !IsWorkflowRequestStringInputRequest && IsWorkflowRequestJSONInputRequest && !IsWorkflowRequestChatHistoryInputRequest && !IsWorkflowRequestNumberInputRequest && !IsWorkflowRequestAudioInputRequest && !IsWorkflowRequestVideoInputRequest && !IsWorkflowRequestImageInputRequest && !IsWorkflowRequestDocumentInputRequest || !IsWorkflowRequestStringInputRequest && !IsWorkflowRequestJSONInputRequest && IsWorkflowRequestChatHistoryInputRequest && !IsWorkflowRequestNumberInputRequest && !IsWorkflowRequestAudioInputRequest && !IsWorkflowRequestVideoInputRequest && !IsWorkflowRequestImageInputRequest && !IsWorkflowRequestDocumentInputRequest || !IsWorkflowRequestStringInputRequest && !IsWorkflowRequestJSONInputRequest && !IsWorkflowRequestChatHistoryInputRequest && IsWorkflowRequestNumberInputRequest && !IsWorkflowRequestAudioInputRequest && !IsWorkflowRequestVideoInputRequest && !IsWorkflowRequestImageInputRequest && !IsWorkflowRequestDocumentInputRequest || !IsWorkflowRequestStringInputRequest && !IsWorkflowRequestJSONInputRequest && !IsWorkflowRequestChatHistoryInputRequest && !IsWorkflowRequestNumberInputRequest && IsWorkflowRequestAudioInputRequest && !IsWorkflowRequestVideoInputRequest && !IsWorkflowRequestImageInputRequest && !IsWorkflowRequestDocumentInputRequest || !IsWorkflowRequestStringInputRequest && !IsWorkflowRequestJSONInputRequest && !IsWorkflowRequestChatHistoryInputRequest && !IsWorkflowRequestNumberInputRequest && !IsWorkflowRequestAudioInputRequest && IsWorkflowRequestVideoInputRequest && !IsWorkflowRequestImageInputRequest && !IsWorkflowRequestDocumentInputRequest || !IsWorkflowRequestStringInputRequest && !IsWorkflowRequestJSONInputRequest && !IsWorkflowRequestChatHistoryInputRequest && !IsWorkflowRequestNumberInputRequest && !IsWorkflowRequestAudioInputRequest && !IsWorkflowRequestVideoInputRequest && IsWorkflowRequestImageInputRequest && !IsWorkflowRequestDocumentInputRequest || !IsWorkflowRequestStringInputRequest && !IsWorkflowRequestJSONInputRequest && !IsWorkflowRequestChatHistoryInputRequest && !IsWorkflowRequestNumberInputRequest && !IsWorkflowRequestAudioInputRequest && !IsWorkflowRequestVideoInputRequest && !IsWorkflowRequestImageInputRequest && IsWorkflowRequestDocumentInputRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.WorkflowRequestStringInputRequest, TResult>? workflowRequestStringInputRequest = null,
            global::System.Func<global::Vellum.WorkflowRequestJSONInputRequest, TResult>? workflowRequestJSONInputRequest = null,
            global::System.Func<global::Vellum.WorkflowRequestChatHistoryInputRequest, TResult>? workflowRequestChatHistoryInputRequest = null,
            global::System.Func<global::Vellum.WorkflowRequestNumberInputRequest, TResult>? workflowRequestNumberInputRequest = null,
            global::System.Func<global::Vellum.WorkflowRequestAudioInputRequest, TResult>? workflowRequestAudioInputRequest = null,
            global::System.Func<global::Vellum.WorkflowRequestVideoInputRequest, TResult>? workflowRequestVideoInputRequest = null,
            global::System.Func<global::Vellum.WorkflowRequestImageInputRequest, TResult>? workflowRequestImageInputRequest = null,
            global::System.Func<global::Vellum.WorkflowRequestDocumentInputRequest, TResult>? workflowRequestDocumentInputRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (WorkflowRequestStringInputRequest is { } __value0 && workflowRequestStringInputRequest != null)
            {
                return workflowRequestStringInputRequest(__value0);
            }
            else if (WorkflowRequestJSONInputRequest is { } __value1 && workflowRequestJSONInputRequest != null)
            {
                return workflowRequestJSONInputRequest(__value1);
            }
            else if (WorkflowRequestChatHistoryInputRequest is { } __value2 && workflowRequestChatHistoryInputRequest != null)
            {
                return workflowRequestChatHistoryInputRequest(__value2);
            }
            else if (WorkflowRequestNumberInputRequest is { } __value3 && workflowRequestNumberInputRequest != null)
            {
                return workflowRequestNumberInputRequest(__value3);
            }
            else if (WorkflowRequestAudioInputRequest is { } __value4 && workflowRequestAudioInputRequest != null)
            {
                return workflowRequestAudioInputRequest(__value4);
            }
            else if (WorkflowRequestVideoInputRequest is { } __value5 && workflowRequestVideoInputRequest != null)
            {
                return workflowRequestVideoInputRequest(__value5);
            }
            else if (WorkflowRequestImageInputRequest is { } __value6 && workflowRequestImageInputRequest != null)
            {
                return workflowRequestImageInputRequest(__value6);
            }
            else if (WorkflowRequestDocumentInputRequest is { } __value7 && workflowRequestDocumentInputRequest != null)
            {
                return workflowRequestDocumentInputRequest(__value7);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.WorkflowRequestStringInputRequest>? workflowRequestStringInputRequest = null,

            global::System.Action<global::Vellum.WorkflowRequestJSONInputRequest>? workflowRequestJSONInputRequest = null,

            global::System.Action<global::Vellum.WorkflowRequestChatHistoryInputRequest>? workflowRequestChatHistoryInputRequest = null,

            global::System.Action<global::Vellum.WorkflowRequestNumberInputRequest>? workflowRequestNumberInputRequest = null,

            global::System.Action<global::Vellum.WorkflowRequestAudioInputRequest>? workflowRequestAudioInputRequest = null,

            global::System.Action<global::Vellum.WorkflowRequestVideoInputRequest>? workflowRequestVideoInputRequest = null,

            global::System.Action<global::Vellum.WorkflowRequestImageInputRequest>? workflowRequestImageInputRequest = null,

            global::System.Action<global::Vellum.WorkflowRequestDocumentInputRequest>? workflowRequestDocumentInputRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (WorkflowRequestStringInputRequest is { } __value0)
            {
                workflowRequestStringInputRequest?.Invoke(__value0);
            }
            else if (WorkflowRequestJSONInputRequest is { } __value1)
            {
                workflowRequestJSONInputRequest?.Invoke(__value1);
            }
            else if (WorkflowRequestChatHistoryInputRequest is { } __value2)
            {
                workflowRequestChatHistoryInputRequest?.Invoke(__value2);
            }
            else if (WorkflowRequestNumberInputRequest is { } __value3)
            {
                workflowRequestNumberInputRequest?.Invoke(__value3);
            }
            else if (WorkflowRequestAudioInputRequest is { } __value4)
            {
                workflowRequestAudioInputRequest?.Invoke(__value4);
            }
            else if (WorkflowRequestVideoInputRequest is { } __value5)
            {
                workflowRequestVideoInputRequest?.Invoke(__value5);
            }
            else if (WorkflowRequestImageInputRequest is { } __value6)
            {
                workflowRequestImageInputRequest?.Invoke(__value6);
            }
            else if (WorkflowRequestDocumentInputRequest is { } __value7)
            {
                workflowRequestDocumentInputRequest?.Invoke(__value7);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vellum.WorkflowRequestStringInputRequest>? workflowRequestStringInputRequest = null,
            global::System.Action<global::Vellum.WorkflowRequestJSONInputRequest>? workflowRequestJSONInputRequest = null,
            global::System.Action<global::Vellum.WorkflowRequestChatHistoryInputRequest>? workflowRequestChatHistoryInputRequest = null,
            global::System.Action<global::Vellum.WorkflowRequestNumberInputRequest>? workflowRequestNumberInputRequest = null,
            global::System.Action<global::Vellum.WorkflowRequestAudioInputRequest>? workflowRequestAudioInputRequest = null,
            global::System.Action<global::Vellum.WorkflowRequestVideoInputRequest>? workflowRequestVideoInputRequest = null,
            global::System.Action<global::Vellum.WorkflowRequestImageInputRequest>? workflowRequestImageInputRequest = null,
            global::System.Action<global::Vellum.WorkflowRequestDocumentInputRequest>? workflowRequestDocumentInputRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (WorkflowRequestStringInputRequest is { } __value0)
            {
                workflowRequestStringInputRequest?.Invoke(__value0);
            }
            else if (WorkflowRequestJSONInputRequest is { } __value1)
            {
                workflowRequestJSONInputRequest?.Invoke(__value1);
            }
            else if (WorkflowRequestChatHistoryInputRequest is { } __value2)
            {
                workflowRequestChatHistoryInputRequest?.Invoke(__value2);
            }
            else if (WorkflowRequestNumberInputRequest is { } __value3)
            {
                workflowRequestNumberInputRequest?.Invoke(__value3);
            }
            else if (WorkflowRequestAudioInputRequest is { } __value4)
            {
                workflowRequestAudioInputRequest?.Invoke(__value4);
            }
            else if (WorkflowRequestVideoInputRequest is { } __value5)
            {
                workflowRequestVideoInputRequest?.Invoke(__value5);
            }
            else if (WorkflowRequestImageInputRequest is { } __value6)
            {
                workflowRequestImageInputRequest?.Invoke(__value6);
            }
            else if (WorkflowRequestDocumentInputRequest is { } __value7)
            {
                workflowRequestDocumentInputRequest?.Invoke(__value7);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WorkflowRequestStringInputRequest,
                typeof(global::Vellum.WorkflowRequestStringInputRequest),
                WorkflowRequestJSONInputRequest,
                typeof(global::Vellum.WorkflowRequestJSONInputRequest),
                WorkflowRequestChatHistoryInputRequest,
                typeof(global::Vellum.WorkflowRequestChatHistoryInputRequest),
                WorkflowRequestNumberInputRequest,
                typeof(global::Vellum.WorkflowRequestNumberInputRequest),
                WorkflowRequestAudioInputRequest,
                typeof(global::Vellum.WorkflowRequestAudioInputRequest),
                WorkflowRequestVideoInputRequest,
                typeof(global::Vellum.WorkflowRequestVideoInputRequest),
                WorkflowRequestImageInputRequest,
                typeof(global::Vellum.WorkflowRequestImageInputRequest),
                WorkflowRequestDocumentInputRequest,
                typeof(global::Vellum.WorkflowRequestDocumentInputRequest),
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
        public bool Equals(WorkflowRequestInputRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowRequestStringInputRequest?>.Default.Equals(WorkflowRequestStringInputRequest, other.WorkflowRequestStringInputRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowRequestJSONInputRequest?>.Default.Equals(WorkflowRequestJSONInputRequest, other.WorkflowRequestJSONInputRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowRequestChatHistoryInputRequest?>.Default.Equals(WorkflowRequestChatHistoryInputRequest, other.WorkflowRequestChatHistoryInputRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowRequestNumberInputRequest?>.Default.Equals(WorkflowRequestNumberInputRequest, other.WorkflowRequestNumberInputRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowRequestAudioInputRequest?>.Default.Equals(WorkflowRequestAudioInputRequest, other.WorkflowRequestAudioInputRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowRequestVideoInputRequest?>.Default.Equals(WorkflowRequestVideoInputRequest, other.WorkflowRequestVideoInputRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowRequestImageInputRequest?>.Default.Equals(WorkflowRequestImageInputRequest, other.WorkflowRequestImageInputRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowRequestDocumentInputRequest?>.Default.Equals(WorkflowRequestDocumentInputRequest, other.WorkflowRequestDocumentInputRequest)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WorkflowRequestInputRequest obj1, WorkflowRequestInputRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WorkflowRequestInputRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WorkflowRequestInputRequest obj1, WorkflowRequestInputRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WorkflowRequestInputRequest o && Equals(o);
        }
    }
}
