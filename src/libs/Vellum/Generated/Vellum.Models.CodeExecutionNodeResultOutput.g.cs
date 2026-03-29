#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CodeExecutionNodeResultOutput : global::System.IEquatable<CodeExecutionNodeResultOutput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.CodeExecutionNodeStringResult? CodeExecutionNodeStringResult { get; init; }
#else
        public global::Vellum.CodeExecutionNodeStringResult? CodeExecutionNodeStringResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionNodeStringResult))]
#endif
        public bool IsCodeExecutionNodeStringResult => CodeExecutionNodeStringResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.CodeExecutionNodeNumberResult? CodeExecutionNodeNumberResult { get; init; }
#else
        public global::Vellum.CodeExecutionNodeNumberResult? CodeExecutionNodeNumberResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionNodeNumberResult))]
#endif
        public bool IsCodeExecutionNodeNumberResult => CodeExecutionNodeNumberResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.CodeExecutionNodeJsonResult? CodeExecutionNodeJsonResult { get; init; }
#else
        public global::Vellum.CodeExecutionNodeJsonResult? CodeExecutionNodeJsonResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionNodeJsonResult))]
#endif
        public bool IsCodeExecutionNodeJsonResult => CodeExecutionNodeJsonResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.CodeExecutionNodeChatHistoryResult? CodeExecutionNodeChatHistoryResult { get; init; }
#else
        public global::Vellum.CodeExecutionNodeChatHistoryResult? CodeExecutionNodeChatHistoryResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionNodeChatHistoryResult))]
#endif
        public bool IsCodeExecutionNodeChatHistoryResult => CodeExecutionNodeChatHistoryResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.CodeExecutionNodeSearchResultsResult? CodeExecutionNodeSearchResultsResult { get; init; }
#else
        public global::Vellum.CodeExecutionNodeSearchResultsResult? CodeExecutionNodeSearchResultsResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionNodeSearchResultsResult))]
#endif
        public bool IsCodeExecutionNodeSearchResultsResult => CodeExecutionNodeSearchResultsResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.CodeExecutionNodeErrorResult? CodeExecutionNodeErrorResult { get; init; }
#else
        public global::Vellum.CodeExecutionNodeErrorResult? CodeExecutionNodeErrorResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionNodeErrorResult))]
#endif
        public bool IsCodeExecutionNodeErrorResult => CodeExecutionNodeErrorResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.CodeExecutionNodeArrayResult? CodeExecutionNodeArrayResult { get; init; }
#else
        public global::Vellum.CodeExecutionNodeArrayResult? CodeExecutionNodeArrayResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionNodeArrayResult))]
#endif
        public bool IsCodeExecutionNodeArrayResult => CodeExecutionNodeArrayResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.CodeExecutionNodeFunctionCallResult? CodeExecutionNodeFunctionCallResult { get; init; }
#else
        public global::Vellum.CodeExecutionNodeFunctionCallResult? CodeExecutionNodeFunctionCallResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionNodeFunctionCallResult))]
#endif
        public bool IsCodeExecutionNodeFunctionCallResult => CodeExecutionNodeFunctionCallResult != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeExecutionNodeResultOutput(global::Vellum.CodeExecutionNodeStringResult value) => new CodeExecutionNodeResultOutput((global::Vellum.CodeExecutionNodeStringResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.CodeExecutionNodeStringResult?(CodeExecutionNodeResultOutput @this) => @this.CodeExecutionNodeStringResult;

        /// <summary>
        /// 
        /// </summary>
        public CodeExecutionNodeResultOutput(global::Vellum.CodeExecutionNodeStringResult? value)
        {
            CodeExecutionNodeStringResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeExecutionNodeResultOutput(global::Vellum.CodeExecutionNodeNumberResult value) => new CodeExecutionNodeResultOutput((global::Vellum.CodeExecutionNodeNumberResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.CodeExecutionNodeNumberResult?(CodeExecutionNodeResultOutput @this) => @this.CodeExecutionNodeNumberResult;

        /// <summary>
        /// 
        /// </summary>
        public CodeExecutionNodeResultOutput(global::Vellum.CodeExecutionNodeNumberResult? value)
        {
            CodeExecutionNodeNumberResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeExecutionNodeResultOutput(global::Vellum.CodeExecutionNodeJsonResult value) => new CodeExecutionNodeResultOutput((global::Vellum.CodeExecutionNodeJsonResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.CodeExecutionNodeJsonResult?(CodeExecutionNodeResultOutput @this) => @this.CodeExecutionNodeJsonResult;

        /// <summary>
        /// 
        /// </summary>
        public CodeExecutionNodeResultOutput(global::Vellum.CodeExecutionNodeJsonResult? value)
        {
            CodeExecutionNodeJsonResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeExecutionNodeResultOutput(global::Vellum.CodeExecutionNodeChatHistoryResult value) => new CodeExecutionNodeResultOutput((global::Vellum.CodeExecutionNodeChatHistoryResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.CodeExecutionNodeChatHistoryResult?(CodeExecutionNodeResultOutput @this) => @this.CodeExecutionNodeChatHistoryResult;

        /// <summary>
        /// 
        /// </summary>
        public CodeExecutionNodeResultOutput(global::Vellum.CodeExecutionNodeChatHistoryResult? value)
        {
            CodeExecutionNodeChatHistoryResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeExecutionNodeResultOutput(global::Vellum.CodeExecutionNodeSearchResultsResult value) => new CodeExecutionNodeResultOutput((global::Vellum.CodeExecutionNodeSearchResultsResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.CodeExecutionNodeSearchResultsResult?(CodeExecutionNodeResultOutput @this) => @this.CodeExecutionNodeSearchResultsResult;

        /// <summary>
        /// 
        /// </summary>
        public CodeExecutionNodeResultOutput(global::Vellum.CodeExecutionNodeSearchResultsResult? value)
        {
            CodeExecutionNodeSearchResultsResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeExecutionNodeResultOutput(global::Vellum.CodeExecutionNodeErrorResult value) => new CodeExecutionNodeResultOutput((global::Vellum.CodeExecutionNodeErrorResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.CodeExecutionNodeErrorResult?(CodeExecutionNodeResultOutput @this) => @this.CodeExecutionNodeErrorResult;

        /// <summary>
        /// 
        /// </summary>
        public CodeExecutionNodeResultOutput(global::Vellum.CodeExecutionNodeErrorResult? value)
        {
            CodeExecutionNodeErrorResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeExecutionNodeResultOutput(global::Vellum.CodeExecutionNodeArrayResult value) => new CodeExecutionNodeResultOutput((global::Vellum.CodeExecutionNodeArrayResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.CodeExecutionNodeArrayResult?(CodeExecutionNodeResultOutput @this) => @this.CodeExecutionNodeArrayResult;

        /// <summary>
        /// 
        /// </summary>
        public CodeExecutionNodeResultOutput(global::Vellum.CodeExecutionNodeArrayResult? value)
        {
            CodeExecutionNodeArrayResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CodeExecutionNodeResultOutput(global::Vellum.CodeExecutionNodeFunctionCallResult value) => new CodeExecutionNodeResultOutput((global::Vellum.CodeExecutionNodeFunctionCallResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.CodeExecutionNodeFunctionCallResult?(CodeExecutionNodeResultOutput @this) => @this.CodeExecutionNodeFunctionCallResult;

        /// <summary>
        /// 
        /// </summary>
        public CodeExecutionNodeResultOutput(global::Vellum.CodeExecutionNodeFunctionCallResult? value)
        {
            CodeExecutionNodeFunctionCallResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CodeExecutionNodeResultOutput(
            global::Vellum.CodeExecutionNodeStringResult? codeExecutionNodeStringResult,
            global::Vellum.CodeExecutionNodeNumberResult? codeExecutionNodeNumberResult,
            global::Vellum.CodeExecutionNodeJsonResult? codeExecutionNodeJsonResult,
            global::Vellum.CodeExecutionNodeChatHistoryResult? codeExecutionNodeChatHistoryResult,
            global::Vellum.CodeExecutionNodeSearchResultsResult? codeExecutionNodeSearchResultsResult,
            global::Vellum.CodeExecutionNodeErrorResult? codeExecutionNodeErrorResult,
            global::Vellum.CodeExecutionNodeArrayResult? codeExecutionNodeArrayResult,
            global::Vellum.CodeExecutionNodeFunctionCallResult? codeExecutionNodeFunctionCallResult
            )
        {
            CodeExecutionNodeStringResult = codeExecutionNodeStringResult;
            CodeExecutionNodeNumberResult = codeExecutionNodeNumberResult;
            CodeExecutionNodeJsonResult = codeExecutionNodeJsonResult;
            CodeExecutionNodeChatHistoryResult = codeExecutionNodeChatHistoryResult;
            CodeExecutionNodeSearchResultsResult = codeExecutionNodeSearchResultsResult;
            CodeExecutionNodeErrorResult = codeExecutionNodeErrorResult;
            CodeExecutionNodeArrayResult = codeExecutionNodeArrayResult;
            CodeExecutionNodeFunctionCallResult = codeExecutionNodeFunctionCallResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CodeExecutionNodeFunctionCallResult as object ??
            CodeExecutionNodeArrayResult as object ??
            CodeExecutionNodeErrorResult as object ??
            CodeExecutionNodeSearchResultsResult as object ??
            CodeExecutionNodeChatHistoryResult as object ??
            CodeExecutionNodeJsonResult as object ??
            CodeExecutionNodeNumberResult as object ??
            CodeExecutionNodeStringResult as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CodeExecutionNodeStringResult?.ToString() ??
            CodeExecutionNodeNumberResult?.ToString() ??
            CodeExecutionNodeJsonResult?.ToString() ??
            CodeExecutionNodeChatHistoryResult?.ToString() ??
            CodeExecutionNodeSearchResultsResult?.ToString() ??
            CodeExecutionNodeErrorResult?.ToString() ??
            CodeExecutionNodeArrayResult?.ToString() ??
            CodeExecutionNodeFunctionCallResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCodeExecutionNodeStringResult && !IsCodeExecutionNodeNumberResult && !IsCodeExecutionNodeJsonResult && !IsCodeExecutionNodeChatHistoryResult && !IsCodeExecutionNodeSearchResultsResult && !IsCodeExecutionNodeErrorResult && !IsCodeExecutionNodeArrayResult && !IsCodeExecutionNodeFunctionCallResult || !IsCodeExecutionNodeStringResult && IsCodeExecutionNodeNumberResult && !IsCodeExecutionNodeJsonResult && !IsCodeExecutionNodeChatHistoryResult && !IsCodeExecutionNodeSearchResultsResult && !IsCodeExecutionNodeErrorResult && !IsCodeExecutionNodeArrayResult && !IsCodeExecutionNodeFunctionCallResult || !IsCodeExecutionNodeStringResult && !IsCodeExecutionNodeNumberResult && IsCodeExecutionNodeJsonResult && !IsCodeExecutionNodeChatHistoryResult && !IsCodeExecutionNodeSearchResultsResult && !IsCodeExecutionNodeErrorResult && !IsCodeExecutionNodeArrayResult && !IsCodeExecutionNodeFunctionCallResult || !IsCodeExecutionNodeStringResult && !IsCodeExecutionNodeNumberResult && !IsCodeExecutionNodeJsonResult && IsCodeExecutionNodeChatHistoryResult && !IsCodeExecutionNodeSearchResultsResult && !IsCodeExecutionNodeErrorResult && !IsCodeExecutionNodeArrayResult && !IsCodeExecutionNodeFunctionCallResult || !IsCodeExecutionNodeStringResult && !IsCodeExecutionNodeNumberResult && !IsCodeExecutionNodeJsonResult && !IsCodeExecutionNodeChatHistoryResult && IsCodeExecutionNodeSearchResultsResult && !IsCodeExecutionNodeErrorResult && !IsCodeExecutionNodeArrayResult && !IsCodeExecutionNodeFunctionCallResult || !IsCodeExecutionNodeStringResult && !IsCodeExecutionNodeNumberResult && !IsCodeExecutionNodeJsonResult && !IsCodeExecutionNodeChatHistoryResult && !IsCodeExecutionNodeSearchResultsResult && IsCodeExecutionNodeErrorResult && !IsCodeExecutionNodeArrayResult && !IsCodeExecutionNodeFunctionCallResult || !IsCodeExecutionNodeStringResult && !IsCodeExecutionNodeNumberResult && !IsCodeExecutionNodeJsonResult && !IsCodeExecutionNodeChatHistoryResult && !IsCodeExecutionNodeSearchResultsResult && !IsCodeExecutionNodeErrorResult && IsCodeExecutionNodeArrayResult && !IsCodeExecutionNodeFunctionCallResult || !IsCodeExecutionNodeStringResult && !IsCodeExecutionNodeNumberResult && !IsCodeExecutionNodeJsonResult && !IsCodeExecutionNodeChatHistoryResult && !IsCodeExecutionNodeSearchResultsResult && !IsCodeExecutionNodeErrorResult && !IsCodeExecutionNodeArrayResult && IsCodeExecutionNodeFunctionCallResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.CodeExecutionNodeStringResult?, TResult>? codeExecutionNodeStringResult = null,
            global::System.Func<global::Vellum.CodeExecutionNodeNumberResult?, TResult>? codeExecutionNodeNumberResult = null,
            global::System.Func<global::Vellum.CodeExecutionNodeJsonResult?, TResult>? codeExecutionNodeJsonResult = null,
            global::System.Func<global::Vellum.CodeExecutionNodeChatHistoryResult?, TResult>? codeExecutionNodeChatHistoryResult = null,
            global::System.Func<global::Vellum.CodeExecutionNodeSearchResultsResult?, TResult>? codeExecutionNodeSearchResultsResult = null,
            global::System.Func<global::Vellum.CodeExecutionNodeErrorResult?, TResult>? codeExecutionNodeErrorResult = null,
            global::System.Func<global::Vellum.CodeExecutionNodeArrayResult?, TResult>? codeExecutionNodeArrayResult = null,
            global::System.Func<global::Vellum.CodeExecutionNodeFunctionCallResult?, TResult>? codeExecutionNodeFunctionCallResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeExecutionNodeStringResult && codeExecutionNodeStringResult != null)
            {
                return codeExecutionNodeStringResult(CodeExecutionNodeStringResult!);
            }
            else if (IsCodeExecutionNodeNumberResult && codeExecutionNodeNumberResult != null)
            {
                return codeExecutionNodeNumberResult(CodeExecutionNodeNumberResult!);
            }
            else if (IsCodeExecutionNodeJsonResult && codeExecutionNodeJsonResult != null)
            {
                return codeExecutionNodeJsonResult(CodeExecutionNodeJsonResult!);
            }
            else if (IsCodeExecutionNodeChatHistoryResult && codeExecutionNodeChatHistoryResult != null)
            {
                return codeExecutionNodeChatHistoryResult(CodeExecutionNodeChatHistoryResult!);
            }
            else if (IsCodeExecutionNodeSearchResultsResult && codeExecutionNodeSearchResultsResult != null)
            {
                return codeExecutionNodeSearchResultsResult(CodeExecutionNodeSearchResultsResult!);
            }
            else if (IsCodeExecutionNodeErrorResult && codeExecutionNodeErrorResult != null)
            {
                return codeExecutionNodeErrorResult(CodeExecutionNodeErrorResult!);
            }
            else if (IsCodeExecutionNodeArrayResult && codeExecutionNodeArrayResult != null)
            {
                return codeExecutionNodeArrayResult(CodeExecutionNodeArrayResult!);
            }
            else if (IsCodeExecutionNodeFunctionCallResult && codeExecutionNodeFunctionCallResult != null)
            {
                return codeExecutionNodeFunctionCallResult(CodeExecutionNodeFunctionCallResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.CodeExecutionNodeStringResult?>? codeExecutionNodeStringResult = null,
            global::System.Action<global::Vellum.CodeExecutionNodeNumberResult?>? codeExecutionNodeNumberResult = null,
            global::System.Action<global::Vellum.CodeExecutionNodeJsonResult?>? codeExecutionNodeJsonResult = null,
            global::System.Action<global::Vellum.CodeExecutionNodeChatHistoryResult?>? codeExecutionNodeChatHistoryResult = null,
            global::System.Action<global::Vellum.CodeExecutionNodeSearchResultsResult?>? codeExecutionNodeSearchResultsResult = null,
            global::System.Action<global::Vellum.CodeExecutionNodeErrorResult?>? codeExecutionNodeErrorResult = null,
            global::System.Action<global::Vellum.CodeExecutionNodeArrayResult?>? codeExecutionNodeArrayResult = null,
            global::System.Action<global::Vellum.CodeExecutionNodeFunctionCallResult?>? codeExecutionNodeFunctionCallResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeExecutionNodeStringResult)
            {
                codeExecutionNodeStringResult?.Invoke(CodeExecutionNodeStringResult!);
            }
            else if (IsCodeExecutionNodeNumberResult)
            {
                codeExecutionNodeNumberResult?.Invoke(CodeExecutionNodeNumberResult!);
            }
            else if (IsCodeExecutionNodeJsonResult)
            {
                codeExecutionNodeJsonResult?.Invoke(CodeExecutionNodeJsonResult!);
            }
            else if (IsCodeExecutionNodeChatHistoryResult)
            {
                codeExecutionNodeChatHistoryResult?.Invoke(CodeExecutionNodeChatHistoryResult!);
            }
            else if (IsCodeExecutionNodeSearchResultsResult)
            {
                codeExecutionNodeSearchResultsResult?.Invoke(CodeExecutionNodeSearchResultsResult!);
            }
            else if (IsCodeExecutionNodeErrorResult)
            {
                codeExecutionNodeErrorResult?.Invoke(CodeExecutionNodeErrorResult!);
            }
            else if (IsCodeExecutionNodeArrayResult)
            {
                codeExecutionNodeArrayResult?.Invoke(CodeExecutionNodeArrayResult!);
            }
            else if (IsCodeExecutionNodeFunctionCallResult)
            {
                codeExecutionNodeFunctionCallResult?.Invoke(CodeExecutionNodeFunctionCallResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CodeExecutionNodeStringResult,
                typeof(global::Vellum.CodeExecutionNodeStringResult),
                CodeExecutionNodeNumberResult,
                typeof(global::Vellum.CodeExecutionNodeNumberResult),
                CodeExecutionNodeJsonResult,
                typeof(global::Vellum.CodeExecutionNodeJsonResult),
                CodeExecutionNodeChatHistoryResult,
                typeof(global::Vellum.CodeExecutionNodeChatHistoryResult),
                CodeExecutionNodeSearchResultsResult,
                typeof(global::Vellum.CodeExecutionNodeSearchResultsResult),
                CodeExecutionNodeErrorResult,
                typeof(global::Vellum.CodeExecutionNodeErrorResult),
                CodeExecutionNodeArrayResult,
                typeof(global::Vellum.CodeExecutionNodeArrayResult),
                CodeExecutionNodeFunctionCallResult,
                typeof(global::Vellum.CodeExecutionNodeFunctionCallResult),
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
        public bool Equals(CodeExecutionNodeResultOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.CodeExecutionNodeStringResult?>.Default.Equals(CodeExecutionNodeStringResult, other.CodeExecutionNodeStringResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.CodeExecutionNodeNumberResult?>.Default.Equals(CodeExecutionNodeNumberResult, other.CodeExecutionNodeNumberResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.CodeExecutionNodeJsonResult?>.Default.Equals(CodeExecutionNodeJsonResult, other.CodeExecutionNodeJsonResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.CodeExecutionNodeChatHistoryResult?>.Default.Equals(CodeExecutionNodeChatHistoryResult, other.CodeExecutionNodeChatHistoryResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.CodeExecutionNodeSearchResultsResult?>.Default.Equals(CodeExecutionNodeSearchResultsResult, other.CodeExecutionNodeSearchResultsResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.CodeExecutionNodeErrorResult?>.Default.Equals(CodeExecutionNodeErrorResult, other.CodeExecutionNodeErrorResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.CodeExecutionNodeArrayResult?>.Default.Equals(CodeExecutionNodeArrayResult, other.CodeExecutionNodeArrayResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.CodeExecutionNodeFunctionCallResult?>.Default.Equals(CodeExecutionNodeFunctionCallResult, other.CodeExecutionNodeFunctionCallResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CodeExecutionNodeResultOutput obj1, CodeExecutionNodeResultOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CodeExecutionNodeResultOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CodeExecutionNodeResultOutput obj1, CodeExecutionNodeResultOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CodeExecutionNodeResultOutput o && Equals(o);
        }
    }
}
