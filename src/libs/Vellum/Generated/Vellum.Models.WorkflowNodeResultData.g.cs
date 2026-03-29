#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WorkflowNodeResultData : global::System.IEquatable<WorkflowNodeResultData>
    {
        /// <summary>
        /// A Node Result Event emitted from a Prompt Node.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.PromptNodeResult? PromptNodeResult { get; init; }
#else
        public global::Vellum.PromptNodeResult? PromptNodeResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PromptNodeResult))]
#endif
        public bool IsPromptNodeResult => PromptNodeResult != null;

        /// <summary>
        /// A Node Result Event emitted from a Search Node.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.SearchNodeResult? SearchNodeResult { get; init; }
#else
        public global::Vellum.SearchNodeResult? SearchNodeResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchNodeResult))]
#endif
        public bool IsSearchNodeResult => SearchNodeResult != null;

        /// <summary>
        /// A Node Result Event emitted from a Templating Node.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TemplatingNodeResult? TemplatingNodeResult { get; init; }
#else
        public global::Vellum.TemplatingNodeResult? TemplatingNodeResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TemplatingNodeResult))]
#endif
        public bool IsTemplatingNodeResult => TemplatingNodeResult != null;

        /// <summary>
        /// A Node Result Event emitted from a Code Execution Node.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.CodeExecutionNodeResult? CodeExecutionNodeResult { get; init; }
#else
        public global::Vellum.CodeExecutionNodeResult? CodeExecutionNodeResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionNodeResult))]
#endif
        public bool IsCodeExecutionNodeResult => CodeExecutionNodeResult != null;

        /// <summary>
        /// A Node Result Event emitted from a Conditional Node.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ConditionalNodeResult? ConditionalNodeResult { get; init; }
#else
        public global::Vellum.ConditionalNodeResult? ConditionalNodeResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConditionalNodeResult))]
#endif
        public bool IsConditionalNodeResult => ConditionalNodeResult != null;

        /// <summary>
        /// A Node Result Event emitted from an API Node.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ApiNodeResult? ApiNodeResult { get; init; }
#else
        public global::Vellum.ApiNodeResult? ApiNodeResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiNodeResult))]
#endif
        public bool IsApiNodeResult => ApiNodeResult != null;

        /// <summary>
        /// A Node Result Event emitted from a Terminal Node.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TerminalNodeResult? TerminalNodeResult { get; init; }
#else
        public global::Vellum.TerminalNodeResult? TerminalNodeResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TerminalNodeResult))]
#endif
        public bool IsTerminalNodeResult => TerminalNodeResult != null;

        /// <summary>
        /// A Node Result Event emitted from a Merge Node.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.MergeNodeResult? MergeNodeResult { get; init; }
#else
        public global::Vellum.MergeNodeResult? MergeNodeResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MergeNodeResult))]
#endif
        public bool IsMergeNodeResult => MergeNodeResult != null;

        /// <summary>
        /// A Node Result Event emitted from a Subworkflow Node.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.SubworkflowNodeResult? SubworkflowNodeResult { get; init; }
#else
        public global::Vellum.SubworkflowNodeResult? SubworkflowNodeResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubworkflowNodeResult))]
#endif
        public bool IsSubworkflowNodeResult => SubworkflowNodeResult != null;

        /// <summary>
        /// A Node Result Event emitted from a Metric Node.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.MetricNodeResult? MetricNodeResult { get; init; }
#else
        public global::Vellum.MetricNodeResult? MetricNodeResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MetricNodeResult))]
#endif
        public bool IsMetricNodeResult => MetricNodeResult != null;

        /// <summary>
        /// A Node Result Event emitted from a Map Node.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.MapNodeResult? MapNodeResult { get; init; }
#else
        public global::Vellum.MapNodeResult? MapNodeResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MapNodeResult))]
#endif
        public bool IsMapNodeResult => MapNodeResult != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowNodeResultData(global::Vellum.PromptNodeResult value) => new WorkflowNodeResultData((global::Vellum.PromptNodeResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.PromptNodeResult?(WorkflowNodeResultData @this) => @this.PromptNodeResult;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowNodeResultData(global::Vellum.PromptNodeResult? value)
        {
            PromptNodeResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowNodeResultData(global::Vellum.SearchNodeResult value) => new WorkflowNodeResultData((global::Vellum.SearchNodeResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.SearchNodeResult?(WorkflowNodeResultData @this) => @this.SearchNodeResult;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowNodeResultData(global::Vellum.SearchNodeResult? value)
        {
            SearchNodeResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowNodeResultData(global::Vellum.TemplatingNodeResult value) => new WorkflowNodeResultData((global::Vellum.TemplatingNodeResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TemplatingNodeResult?(WorkflowNodeResultData @this) => @this.TemplatingNodeResult;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowNodeResultData(global::Vellum.TemplatingNodeResult? value)
        {
            TemplatingNodeResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowNodeResultData(global::Vellum.CodeExecutionNodeResult value) => new WorkflowNodeResultData((global::Vellum.CodeExecutionNodeResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.CodeExecutionNodeResult?(WorkflowNodeResultData @this) => @this.CodeExecutionNodeResult;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowNodeResultData(global::Vellum.CodeExecutionNodeResult? value)
        {
            CodeExecutionNodeResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowNodeResultData(global::Vellum.ConditionalNodeResult value) => new WorkflowNodeResultData((global::Vellum.ConditionalNodeResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ConditionalNodeResult?(WorkflowNodeResultData @this) => @this.ConditionalNodeResult;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowNodeResultData(global::Vellum.ConditionalNodeResult? value)
        {
            ConditionalNodeResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowNodeResultData(global::Vellum.ApiNodeResult value) => new WorkflowNodeResultData((global::Vellum.ApiNodeResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ApiNodeResult?(WorkflowNodeResultData @this) => @this.ApiNodeResult;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowNodeResultData(global::Vellum.ApiNodeResult? value)
        {
            ApiNodeResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowNodeResultData(global::Vellum.TerminalNodeResult value) => new WorkflowNodeResultData((global::Vellum.TerminalNodeResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TerminalNodeResult?(WorkflowNodeResultData @this) => @this.TerminalNodeResult;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowNodeResultData(global::Vellum.TerminalNodeResult? value)
        {
            TerminalNodeResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowNodeResultData(global::Vellum.MergeNodeResult value) => new WorkflowNodeResultData((global::Vellum.MergeNodeResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.MergeNodeResult?(WorkflowNodeResultData @this) => @this.MergeNodeResult;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowNodeResultData(global::Vellum.MergeNodeResult? value)
        {
            MergeNodeResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowNodeResultData(global::Vellum.SubworkflowNodeResult value) => new WorkflowNodeResultData((global::Vellum.SubworkflowNodeResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.SubworkflowNodeResult?(WorkflowNodeResultData @this) => @this.SubworkflowNodeResult;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowNodeResultData(global::Vellum.SubworkflowNodeResult? value)
        {
            SubworkflowNodeResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowNodeResultData(global::Vellum.MetricNodeResult value) => new WorkflowNodeResultData((global::Vellum.MetricNodeResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.MetricNodeResult?(WorkflowNodeResultData @this) => @this.MetricNodeResult;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowNodeResultData(global::Vellum.MetricNodeResult? value)
        {
            MetricNodeResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowNodeResultData(global::Vellum.MapNodeResult value) => new WorkflowNodeResultData((global::Vellum.MapNodeResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.MapNodeResult?(WorkflowNodeResultData @this) => @this.MapNodeResult;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowNodeResultData(global::Vellum.MapNodeResult? value)
        {
            MapNodeResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WorkflowNodeResultData(
            global::Vellum.PromptNodeResult? promptNodeResult,
            global::Vellum.SearchNodeResult? searchNodeResult,
            global::Vellum.TemplatingNodeResult? templatingNodeResult,
            global::Vellum.CodeExecutionNodeResult? codeExecutionNodeResult,
            global::Vellum.ConditionalNodeResult? conditionalNodeResult,
            global::Vellum.ApiNodeResult? apiNodeResult,
            global::Vellum.TerminalNodeResult? terminalNodeResult,
            global::Vellum.MergeNodeResult? mergeNodeResult,
            global::Vellum.SubworkflowNodeResult? subworkflowNodeResult,
            global::Vellum.MetricNodeResult? metricNodeResult,
            global::Vellum.MapNodeResult? mapNodeResult
            )
        {
            PromptNodeResult = promptNodeResult;
            SearchNodeResult = searchNodeResult;
            TemplatingNodeResult = templatingNodeResult;
            CodeExecutionNodeResult = codeExecutionNodeResult;
            ConditionalNodeResult = conditionalNodeResult;
            ApiNodeResult = apiNodeResult;
            TerminalNodeResult = terminalNodeResult;
            MergeNodeResult = mergeNodeResult;
            SubworkflowNodeResult = subworkflowNodeResult;
            MetricNodeResult = metricNodeResult;
            MapNodeResult = mapNodeResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MapNodeResult as object ??
            MetricNodeResult as object ??
            SubworkflowNodeResult as object ??
            MergeNodeResult as object ??
            TerminalNodeResult as object ??
            ApiNodeResult as object ??
            ConditionalNodeResult as object ??
            CodeExecutionNodeResult as object ??
            TemplatingNodeResult as object ??
            SearchNodeResult as object ??
            PromptNodeResult as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PromptNodeResult?.ToString() ??
            SearchNodeResult?.ToString() ??
            TemplatingNodeResult?.ToString() ??
            CodeExecutionNodeResult?.ToString() ??
            ConditionalNodeResult?.ToString() ??
            ApiNodeResult?.ToString() ??
            TerminalNodeResult?.ToString() ??
            MergeNodeResult?.ToString() ??
            SubworkflowNodeResult?.ToString() ??
            MetricNodeResult?.ToString() ??
            MapNodeResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPromptNodeResult && !IsSearchNodeResult && !IsTemplatingNodeResult && !IsCodeExecutionNodeResult && !IsConditionalNodeResult && !IsApiNodeResult && !IsTerminalNodeResult && !IsMergeNodeResult && !IsSubworkflowNodeResult && !IsMetricNodeResult && !IsMapNodeResult || !IsPromptNodeResult && IsSearchNodeResult && !IsTemplatingNodeResult && !IsCodeExecutionNodeResult && !IsConditionalNodeResult && !IsApiNodeResult && !IsTerminalNodeResult && !IsMergeNodeResult && !IsSubworkflowNodeResult && !IsMetricNodeResult && !IsMapNodeResult || !IsPromptNodeResult && !IsSearchNodeResult && IsTemplatingNodeResult && !IsCodeExecutionNodeResult && !IsConditionalNodeResult && !IsApiNodeResult && !IsTerminalNodeResult && !IsMergeNodeResult && !IsSubworkflowNodeResult && !IsMetricNodeResult && !IsMapNodeResult || !IsPromptNodeResult && !IsSearchNodeResult && !IsTemplatingNodeResult && IsCodeExecutionNodeResult && !IsConditionalNodeResult && !IsApiNodeResult && !IsTerminalNodeResult && !IsMergeNodeResult && !IsSubworkflowNodeResult && !IsMetricNodeResult && !IsMapNodeResult || !IsPromptNodeResult && !IsSearchNodeResult && !IsTemplatingNodeResult && !IsCodeExecutionNodeResult && IsConditionalNodeResult && !IsApiNodeResult && !IsTerminalNodeResult && !IsMergeNodeResult && !IsSubworkflowNodeResult && !IsMetricNodeResult && !IsMapNodeResult || !IsPromptNodeResult && !IsSearchNodeResult && !IsTemplatingNodeResult && !IsCodeExecutionNodeResult && !IsConditionalNodeResult && IsApiNodeResult && !IsTerminalNodeResult && !IsMergeNodeResult && !IsSubworkflowNodeResult && !IsMetricNodeResult && !IsMapNodeResult || !IsPromptNodeResult && !IsSearchNodeResult && !IsTemplatingNodeResult && !IsCodeExecutionNodeResult && !IsConditionalNodeResult && !IsApiNodeResult && IsTerminalNodeResult && !IsMergeNodeResult && !IsSubworkflowNodeResult && !IsMetricNodeResult && !IsMapNodeResult || !IsPromptNodeResult && !IsSearchNodeResult && !IsTemplatingNodeResult && !IsCodeExecutionNodeResult && !IsConditionalNodeResult && !IsApiNodeResult && !IsTerminalNodeResult && IsMergeNodeResult && !IsSubworkflowNodeResult && !IsMetricNodeResult && !IsMapNodeResult || !IsPromptNodeResult && !IsSearchNodeResult && !IsTemplatingNodeResult && !IsCodeExecutionNodeResult && !IsConditionalNodeResult && !IsApiNodeResult && !IsTerminalNodeResult && !IsMergeNodeResult && IsSubworkflowNodeResult && !IsMetricNodeResult && !IsMapNodeResult || !IsPromptNodeResult && !IsSearchNodeResult && !IsTemplatingNodeResult && !IsCodeExecutionNodeResult && !IsConditionalNodeResult && !IsApiNodeResult && !IsTerminalNodeResult && !IsMergeNodeResult && !IsSubworkflowNodeResult && IsMetricNodeResult && !IsMapNodeResult || !IsPromptNodeResult && !IsSearchNodeResult && !IsTemplatingNodeResult && !IsCodeExecutionNodeResult && !IsConditionalNodeResult && !IsApiNodeResult && !IsTerminalNodeResult && !IsMergeNodeResult && !IsSubworkflowNodeResult && !IsMetricNodeResult && IsMapNodeResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.PromptNodeResult?, TResult>? promptNodeResult = null,
            global::System.Func<global::Vellum.SearchNodeResult?, TResult>? searchNodeResult = null,
            global::System.Func<global::Vellum.TemplatingNodeResult?, TResult>? templatingNodeResult = null,
            global::System.Func<global::Vellum.CodeExecutionNodeResult?, TResult>? codeExecutionNodeResult = null,
            global::System.Func<global::Vellum.ConditionalNodeResult?, TResult>? conditionalNodeResult = null,
            global::System.Func<global::Vellum.ApiNodeResult?, TResult>? apiNodeResult = null,
            global::System.Func<global::Vellum.TerminalNodeResult?, TResult>? terminalNodeResult = null,
            global::System.Func<global::Vellum.MergeNodeResult?, TResult>? mergeNodeResult = null,
            global::System.Func<global::Vellum.SubworkflowNodeResult?, TResult>? subworkflowNodeResult = null,
            global::System.Func<global::Vellum.MetricNodeResult?, TResult>? metricNodeResult = null,
            global::System.Func<global::Vellum.MapNodeResult?, TResult>? mapNodeResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPromptNodeResult && promptNodeResult != null)
            {
                return promptNodeResult(PromptNodeResult!);
            }
            else if (IsSearchNodeResult && searchNodeResult != null)
            {
                return searchNodeResult(SearchNodeResult!);
            }
            else if (IsTemplatingNodeResult && templatingNodeResult != null)
            {
                return templatingNodeResult(TemplatingNodeResult!);
            }
            else if (IsCodeExecutionNodeResult && codeExecutionNodeResult != null)
            {
                return codeExecutionNodeResult(CodeExecutionNodeResult!);
            }
            else if (IsConditionalNodeResult && conditionalNodeResult != null)
            {
                return conditionalNodeResult(ConditionalNodeResult!);
            }
            else if (IsApiNodeResult && apiNodeResult != null)
            {
                return apiNodeResult(ApiNodeResult!);
            }
            else if (IsTerminalNodeResult && terminalNodeResult != null)
            {
                return terminalNodeResult(TerminalNodeResult!);
            }
            else if (IsMergeNodeResult && mergeNodeResult != null)
            {
                return mergeNodeResult(MergeNodeResult!);
            }
            else if (IsSubworkflowNodeResult && subworkflowNodeResult != null)
            {
                return subworkflowNodeResult(SubworkflowNodeResult!);
            }
            else if (IsMetricNodeResult && metricNodeResult != null)
            {
                return metricNodeResult(MetricNodeResult!);
            }
            else if (IsMapNodeResult && mapNodeResult != null)
            {
                return mapNodeResult(MapNodeResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.PromptNodeResult?>? promptNodeResult = null,
            global::System.Action<global::Vellum.SearchNodeResult?>? searchNodeResult = null,
            global::System.Action<global::Vellum.TemplatingNodeResult?>? templatingNodeResult = null,
            global::System.Action<global::Vellum.CodeExecutionNodeResult?>? codeExecutionNodeResult = null,
            global::System.Action<global::Vellum.ConditionalNodeResult?>? conditionalNodeResult = null,
            global::System.Action<global::Vellum.ApiNodeResult?>? apiNodeResult = null,
            global::System.Action<global::Vellum.TerminalNodeResult?>? terminalNodeResult = null,
            global::System.Action<global::Vellum.MergeNodeResult?>? mergeNodeResult = null,
            global::System.Action<global::Vellum.SubworkflowNodeResult?>? subworkflowNodeResult = null,
            global::System.Action<global::Vellum.MetricNodeResult?>? metricNodeResult = null,
            global::System.Action<global::Vellum.MapNodeResult?>? mapNodeResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPromptNodeResult)
            {
                promptNodeResult?.Invoke(PromptNodeResult!);
            }
            else if (IsSearchNodeResult)
            {
                searchNodeResult?.Invoke(SearchNodeResult!);
            }
            else if (IsTemplatingNodeResult)
            {
                templatingNodeResult?.Invoke(TemplatingNodeResult!);
            }
            else if (IsCodeExecutionNodeResult)
            {
                codeExecutionNodeResult?.Invoke(CodeExecutionNodeResult!);
            }
            else if (IsConditionalNodeResult)
            {
                conditionalNodeResult?.Invoke(ConditionalNodeResult!);
            }
            else if (IsApiNodeResult)
            {
                apiNodeResult?.Invoke(ApiNodeResult!);
            }
            else if (IsTerminalNodeResult)
            {
                terminalNodeResult?.Invoke(TerminalNodeResult!);
            }
            else if (IsMergeNodeResult)
            {
                mergeNodeResult?.Invoke(MergeNodeResult!);
            }
            else if (IsSubworkflowNodeResult)
            {
                subworkflowNodeResult?.Invoke(SubworkflowNodeResult!);
            }
            else if (IsMetricNodeResult)
            {
                metricNodeResult?.Invoke(MetricNodeResult!);
            }
            else if (IsMapNodeResult)
            {
                mapNodeResult?.Invoke(MapNodeResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PromptNodeResult,
                typeof(global::Vellum.PromptNodeResult),
                SearchNodeResult,
                typeof(global::Vellum.SearchNodeResult),
                TemplatingNodeResult,
                typeof(global::Vellum.TemplatingNodeResult),
                CodeExecutionNodeResult,
                typeof(global::Vellum.CodeExecutionNodeResult),
                ConditionalNodeResult,
                typeof(global::Vellum.ConditionalNodeResult),
                ApiNodeResult,
                typeof(global::Vellum.ApiNodeResult),
                TerminalNodeResult,
                typeof(global::Vellum.TerminalNodeResult),
                MergeNodeResult,
                typeof(global::Vellum.MergeNodeResult),
                SubworkflowNodeResult,
                typeof(global::Vellum.SubworkflowNodeResult),
                MetricNodeResult,
                typeof(global::Vellum.MetricNodeResult),
                MapNodeResult,
                typeof(global::Vellum.MapNodeResult),
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
        public bool Equals(WorkflowNodeResultData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.PromptNodeResult?>.Default.Equals(PromptNodeResult, other.PromptNodeResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.SearchNodeResult?>.Default.Equals(SearchNodeResult, other.SearchNodeResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TemplatingNodeResult?>.Default.Equals(TemplatingNodeResult, other.TemplatingNodeResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.CodeExecutionNodeResult?>.Default.Equals(CodeExecutionNodeResult, other.CodeExecutionNodeResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ConditionalNodeResult?>.Default.Equals(ConditionalNodeResult, other.ConditionalNodeResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ApiNodeResult?>.Default.Equals(ApiNodeResult, other.ApiNodeResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TerminalNodeResult?>.Default.Equals(TerminalNodeResult, other.TerminalNodeResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.MergeNodeResult?>.Default.Equals(MergeNodeResult, other.MergeNodeResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.SubworkflowNodeResult?>.Default.Equals(SubworkflowNodeResult, other.SubworkflowNodeResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.MetricNodeResult?>.Default.Equals(MetricNodeResult, other.MetricNodeResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.MapNodeResult?>.Default.Equals(MapNodeResult, other.MapNodeResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WorkflowNodeResultData obj1, WorkflowNodeResultData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WorkflowNodeResultData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WorkflowNodeResultData obj1, WorkflowNodeResultData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WorkflowNodeResultData o && Equals(o);
        }
    }
}
