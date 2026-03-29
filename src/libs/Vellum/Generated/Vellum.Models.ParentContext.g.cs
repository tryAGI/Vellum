#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ParentContext : global::System.IEquatable<ParentContext>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowParentContext? WorkflowParentContext { get; init; }
#else
        public global::Vellum.WorkflowParentContext? WorkflowParentContext { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowParentContext))]
#endif
        public bool IsWorkflowParentContext => WorkflowParentContext != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NodeParentContext? NodeParentContext { get; init; }
#else
        public global::Vellum.NodeParentContext? NodeParentContext { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NodeParentContext))]
#endif
        public bool IsNodeParentContext => NodeParentContext != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowDeploymentParentContext? WorkflowDeploymentParentContext { get; init; }
#else
        public global::Vellum.WorkflowDeploymentParentContext? WorkflowDeploymentParentContext { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowDeploymentParentContext))]
#endif
        public bool IsWorkflowDeploymentParentContext => WorkflowDeploymentParentContext != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowSandboxParentContext? WorkflowSandboxParentContext { get; init; }
#else
        public global::Vellum.WorkflowSandboxParentContext? WorkflowSandboxParentContext { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowSandboxParentContext))]
#endif
        public bool IsWorkflowSandboxParentContext => WorkflowSandboxParentContext != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.PromptDeploymentParentContext? PromptDeploymentParentContext { get; init; }
#else
        public global::Vellum.PromptDeploymentParentContext? PromptDeploymentParentContext { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PromptDeploymentParentContext))]
#endif
        public bool IsPromptDeploymentParentContext => PromptDeploymentParentContext != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.APIRequestParentContext? APIRequestParentContext { get; init; }
#else
        public global::Vellum.APIRequestParentContext? APIRequestParentContext { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(APIRequestParentContext))]
#endif
        public bool IsAPIRequestParentContext => APIRequestParentContext != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ExternalParentContext? ExternalParentContext { get; init; }
#else
        public global::Vellum.ExternalParentContext? ExternalParentContext { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExternalParentContext))]
#endif
        public bool IsExternalParentContext => ExternalParentContext != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ScheduledTriggerContext? ScheduledTriggerContext { get; init; }
#else
        public global::Vellum.ScheduledTriggerContext? ScheduledTriggerContext { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScheduledTriggerContext))]
#endif
        public bool IsScheduledTriggerContext => ScheduledTriggerContext != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.IntegrationTriggerContext? IntegrationTriggerContext { get; init; }
#else
        public global::Vellum.IntegrationTriggerContext? IntegrationTriggerContext { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IntegrationTriggerContext))]
#endif
        public bool IsIntegrationTriggerContext => IntegrationTriggerContext != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParentContext(global::Vellum.WorkflowParentContext value) => new ParentContext((global::Vellum.WorkflowParentContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowParentContext?(ParentContext @this) => @this.WorkflowParentContext;

        /// <summary>
        /// 
        /// </summary>
        public ParentContext(global::Vellum.WorkflowParentContext? value)
        {
            WorkflowParentContext = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParentContext(global::Vellum.NodeParentContext value) => new ParentContext((global::Vellum.NodeParentContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NodeParentContext?(ParentContext @this) => @this.NodeParentContext;

        /// <summary>
        /// 
        /// </summary>
        public ParentContext(global::Vellum.NodeParentContext? value)
        {
            NodeParentContext = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParentContext(global::Vellum.WorkflowDeploymentParentContext value) => new ParentContext((global::Vellum.WorkflowDeploymentParentContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowDeploymentParentContext?(ParentContext @this) => @this.WorkflowDeploymentParentContext;

        /// <summary>
        /// 
        /// </summary>
        public ParentContext(global::Vellum.WorkflowDeploymentParentContext? value)
        {
            WorkflowDeploymentParentContext = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParentContext(global::Vellum.WorkflowSandboxParentContext value) => new ParentContext((global::Vellum.WorkflowSandboxParentContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowSandboxParentContext?(ParentContext @this) => @this.WorkflowSandboxParentContext;

        /// <summary>
        /// 
        /// </summary>
        public ParentContext(global::Vellum.WorkflowSandboxParentContext? value)
        {
            WorkflowSandboxParentContext = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParentContext(global::Vellum.PromptDeploymentParentContext value) => new ParentContext((global::Vellum.PromptDeploymentParentContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.PromptDeploymentParentContext?(ParentContext @this) => @this.PromptDeploymentParentContext;

        /// <summary>
        /// 
        /// </summary>
        public ParentContext(global::Vellum.PromptDeploymentParentContext? value)
        {
            PromptDeploymentParentContext = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParentContext(global::Vellum.APIRequestParentContext value) => new ParentContext((global::Vellum.APIRequestParentContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.APIRequestParentContext?(ParentContext @this) => @this.APIRequestParentContext;

        /// <summary>
        /// 
        /// </summary>
        public ParentContext(global::Vellum.APIRequestParentContext? value)
        {
            APIRequestParentContext = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParentContext(global::Vellum.ExternalParentContext value) => new ParentContext((global::Vellum.ExternalParentContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ExternalParentContext?(ParentContext @this) => @this.ExternalParentContext;

        /// <summary>
        /// 
        /// </summary>
        public ParentContext(global::Vellum.ExternalParentContext? value)
        {
            ExternalParentContext = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParentContext(global::Vellum.ScheduledTriggerContext value) => new ParentContext((global::Vellum.ScheduledTriggerContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ScheduledTriggerContext?(ParentContext @this) => @this.ScheduledTriggerContext;

        /// <summary>
        /// 
        /// </summary>
        public ParentContext(global::Vellum.ScheduledTriggerContext? value)
        {
            ScheduledTriggerContext = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParentContext(global::Vellum.IntegrationTriggerContext value) => new ParentContext((global::Vellum.IntegrationTriggerContext?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.IntegrationTriggerContext?(ParentContext @this) => @this.IntegrationTriggerContext;

        /// <summary>
        /// 
        /// </summary>
        public ParentContext(global::Vellum.IntegrationTriggerContext? value)
        {
            IntegrationTriggerContext = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ParentContext(
            global::Vellum.WorkflowParentContext? workflowParentContext,
            global::Vellum.NodeParentContext? nodeParentContext,
            global::Vellum.WorkflowDeploymentParentContext? workflowDeploymentParentContext,
            global::Vellum.WorkflowSandboxParentContext? workflowSandboxParentContext,
            global::Vellum.PromptDeploymentParentContext? promptDeploymentParentContext,
            global::Vellum.APIRequestParentContext? aPIRequestParentContext,
            global::Vellum.ExternalParentContext? externalParentContext,
            global::Vellum.ScheduledTriggerContext? scheduledTriggerContext,
            global::Vellum.IntegrationTriggerContext? integrationTriggerContext
            )
        {
            WorkflowParentContext = workflowParentContext;
            NodeParentContext = nodeParentContext;
            WorkflowDeploymentParentContext = workflowDeploymentParentContext;
            WorkflowSandboxParentContext = workflowSandboxParentContext;
            PromptDeploymentParentContext = promptDeploymentParentContext;
            APIRequestParentContext = aPIRequestParentContext;
            ExternalParentContext = externalParentContext;
            ScheduledTriggerContext = scheduledTriggerContext;
            IntegrationTriggerContext = integrationTriggerContext;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            IntegrationTriggerContext as object ??
            ScheduledTriggerContext as object ??
            ExternalParentContext as object ??
            APIRequestParentContext as object ??
            PromptDeploymentParentContext as object ??
            WorkflowSandboxParentContext as object ??
            WorkflowDeploymentParentContext as object ??
            NodeParentContext as object ??
            WorkflowParentContext as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WorkflowParentContext?.ToString() ??
            NodeParentContext?.ToString() ??
            WorkflowDeploymentParentContext?.ToString() ??
            WorkflowSandboxParentContext?.ToString() ??
            PromptDeploymentParentContext?.ToString() ??
            APIRequestParentContext?.ToString() ??
            ExternalParentContext?.ToString() ??
            ScheduledTriggerContext?.ToString() ??
            IntegrationTriggerContext?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWorkflowParentContext && !IsNodeParentContext && !IsWorkflowDeploymentParentContext && !IsWorkflowSandboxParentContext && !IsPromptDeploymentParentContext && !IsAPIRequestParentContext && !IsExternalParentContext && !IsScheduledTriggerContext && !IsIntegrationTriggerContext || !IsWorkflowParentContext && IsNodeParentContext && !IsWorkflowDeploymentParentContext && !IsWorkflowSandboxParentContext && !IsPromptDeploymentParentContext && !IsAPIRequestParentContext && !IsExternalParentContext && !IsScheduledTriggerContext && !IsIntegrationTriggerContext || !IsWorkflowParentContext && !IsNodeParentContext && IsWorkflowDeploymentParentContext && !IsWorkflowSandboxParentContext && !IsPromptDeploymentParentContext && !IsAPIRequestParentContext && !IsExternalParentContext && !IsScheduledTriggerContext && !IsIntegrationTriggerContext || !IsWorkflowParentContext && !IsNodeParentContext && !IsWorkflowDeploymentParentContext && IsWorkflowSandboxParentContext && !IsPromptDeploymentParentContext && !IsAPIRequestParentContext && !IsExternalParentContext && !IsScheduledTriggerContext && !IsIntegrationTriggerContext || !IsWorkflowParentContext && !IsNodeParentContext && !IsWorkflowDeploymentParentContext && !IsWorkflowSandboxParentContext && IsPromptDeploymentParentContext && !IsAPIRequestParentContext && !IsExternalParentContext && !IsScheduledTriggerContext && !IsIntegrationTriggerContext || !IsWorkflowParentContext && !IsNodeParentContext && !IsWorkflowDeploymentParentContext && !IsWorkflowSandboxParentContext && !IsPromptDeploymentParentContext && IsAPIRequestParentContext && !IsExternalParentContext && !IsScheduledTriggerContext && !IsIntegrationTriggerContext || !IsWorkflowParentContext && !IsNodeParentContext && !IsWorkflowDeploymentParentContext && !IsWorkflowSandboxParentContext && !IsPromptDeploymentParentContext && !IsAPIRequestParentContext && IsExternalParentContext && !IsScheduledTriggerContext && !IsIntegrationTriggerContext || !IsWorkflowParentContext && !IsNodeParentContext && !IsWorkflowDeploymentParentContext && !IsWorkflowSandboxParentContext && !IsPromptDeploymentParentContext && !IsAPIRequestParentContext && !IsExternalParentContext && IsScheduledTriggerContext && !IsIntegrationTriggerContext || !IsWorkflowParentContext && !IsNodeParentContext && !IsWorkflowDeploymentParentContext && !IsWorkflowSandboxParentContext && !IsPromptDeploymentParentContext && !IsAPIRequestParentContext && !IsExternalParentContext && !IsScheduledTriggerContext && IsIntegrationTriggerContext;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.WorkflowParentContext?, TResult>? workflowParentContext = null,
            global::System.Func<global::Vellum.NodeParentContext?, TResult>? nodeParentContext = null,
            global::System.Func<global::Vellum.WorkflowDeploymentParentContext?, TResult>? workflowDeploymentParentContext = null,
            global::System.Func<global::Vellum.WorkflowSandboxParentContext?, TResult>? workflowSandboxParentContext = null,
            global::System.Func<global::Vellum.PromptDeploymentParentContext?, TResult>? promptDeploymentParentContext = null,
            global::System.Func<global::Vellum.APIRequestParentContext?, TResult>? aPIRequestParentContext = null,
            global::System.Func<global::Vellum.ExternalParentContext?, TResult>? externalParentContext = null,
            global::System.Func<global::Vellum.ScheduledTriggerContext?, TResult>? scheduledTriggerContext = null,
            global::System.Func<global::Vellum.IntegrationTriggerContext?, TResult>? integrationTriggerContext = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowParentContext && workflowParentContext != null)
            {
                return workflowParentContext(WorkflowParentContext!);
            }
            else if (IsNodeParentContext && nodeParentContext != null)
            {
                return nodeParentContext(NodeParentContext!);
            }
            else if (IsWorkflowDeploymentParentContext && workflowDeploymentParentContext != null)
            {
                return workflowDeploymentParentContext(WorkflowDeploymentParentContext!);
            }
            else if (IsWorkflowSandboxParentContext && workflowSandboxParentContext != null)
            {
                return workflowSandboxParentContext(WorkflowSandboxParentContext!);
            }
            else if (IsPromptDeploymentParentContext && promptDeploymentParentContext != null)
            {
                return promptDeploymentParentContext(PromptDeploymentParentContext!);
            }
            else if (IsAPIRequestParentContext && aPIRequestParentContext != null)
            {
                return aPIRequestParentContext(APIRequestParentContext!);
            }
            else if (IsExternalParentContext && externalParentContext != null)
            {
                return externalParentContext(ExternalParentContext!);
            }
            else if (IsScheduledTriggerContext && scheduledTriggerContext != null)
            {
                return scheduledTriggerContext(ScheduledTriggerContext!);
            }
            else if (IsIntegrationTriggerContext && integrationTriggerContext != null)
            {
                return integrationTriggerContext(IntegrationTriggerContext!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.WorkflowParentContext?>? workflowParentContext = null,
            global::System.Action<global::Vellum.NodeParentContext?>? nodeParentContext = null,
            global::System.Action<global::Vellum.WorkflowDeploymentParentContext?>? workflowDeploymentParentContext = null,
            global::System.Action<global::Vellum.WorkflowSandboxParentContext?>? workflowSandboxParentContext = null,
            global::System.Action<global::Vellum.PromptDeploymentParentContext?>? promptDeploymentParentContext = null,
            global::System.Action<global::Vellum.APIRequestParentContext?>? aPIRequestParentContext = null,
            global::System.Action<global::Vellum.ExternalParentContext?>? externalParentContext = null,
            global::System.Action<global::Vellum.ScheduledTriggerContext?>? scheduledTriggerContext = null,
            global::System.Action<global::Vellum.IntegrationTriggerContext?>? integrationTriggerContext = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowParentContext)
            {
                workflowParentContext?.Invoke(WorkflowParentContext!);
            }
            else if (IsNodeParentContext)
            {
                nodeParentContext?.Invoke(NodeParentContext!);
            }
            else if (IsWorkflowDeploymentParentContext)
            {
                workflowDeploymentParentContext?.Invoke(WorkflowDeploymentParentContext!);
            }
            else if (IsWorkflowSandboxParentContext)
            {
                workflowSandboxParentContext?.Invoke(WorkflowSandboxParentContext!);
            }
            else if (IsPromptDeploymentParentContext)
            {
                promptDeploymentParentContext?.Invoke(PromptDeploymentParentContext!);
            }
            else if (IsAPIRequestParentContext)
            {
                aPIRequestParentContext?.Invoke(APIRequestParentContext!);
            }
            else if (IsExternalParentContext)
            {
                externalParentContext?.Invoke(ExternalParentContext!);
            }
            else if (IsScheduledTriggerContext)
            {
                scheduledTriggerContext?.Invoke(ScheduledTriggerContext!);
            }
            else if (IsIntegrationTriggerContext)
            {
                integrationTriggerContext?.Invoke(IntegrationTriggerContext!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WorkflowParentContext,
                typeof(global::Vellum.WorkflowParentContext),
                NodeParentContext,
                typeof(global::Vellum.NodeParentContext),
                WorkflowDeploymentParentContext,
                typeof(global::Vellum.WorkflowDeploymentParentContext),
                WorkflowSandboxParentContext,
                typeof(global::Vellum.WorkflowSandboxParentContext),
                PromptDeploymentParentContext,
                typeof(global::Vellum.PromptDeploymentParentContext),
                APIRequestParentContext,
                typeof(global::Vellum.APIRequestParentContext),
                ExternalParentContext,
                typeof(global::Vellum.ExternalParentContext),
                ScheduledTriggerContext,
                typeof(global::Vellum.ScheduledTriggerContext),
                IntegrationTriggerContext,
                typeof(global::Vellum.IntegrationTriggerContext),
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
        public bool Equals(ParentContext other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowParentContext?>.Default.Equals(WorkflowParentContext, other.WorkflowParentContext) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NodeParentContext?>.Default.Equals(NodeParentContext, other.NodeParentContext) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowDeploymentParentContext?>.Default.Equals(WorkflowDeploymentParentContext, other.WorkflowDeploymentParentContext) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowSandboxParentContext?>.Default.Equals(WorkflowSandboxParentContext, other.WorkflowSandboxParentContext) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.PromptDeploymentParentContext?>.Default.Equals(PromptDeploymentParentContext, other.PromptDeploymentParentContext) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.APIRequestParentContext?>.Default.Equals(APIRequestParentContext, other.APIRequestParentContext) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ExternalParentContext?>.Default.Equals(ExternalParentContext, other.ExternalParentContext) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ScheduledTriggerContext?>.Default.Equals(ScheduledTriggerContext, other.ScheduledTriggerContext) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.IntegrationTriggerContext?>.Default.Equals(IntegrationTriggerContext, other.IntegrationTriggerContext) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ParentContext obj1, ParentContext obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ParentContext>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ParentContext obj1, ParentContext obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ParentContext o && Equals(o);
        }
    }
}
