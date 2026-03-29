#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TerminalNodeResultOutput : global::System.IEquatable<TerminalNodeResultOutput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TerminalNodeStringResult? TerminalNodeStringResult { get; init; }
#else
        public global::Vellum.TerminalNodeStringResult? TerminalNodeStringResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TerminalNodeStringResult))]
#endif
        public bool IsTerminalNodeStringResult => TerminalNodeStringResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TerminalNodeNumberResult? TerminalNodeNumberResult { get; init; }
#else
        public global::Vellum.TerminalNodeNumberResult? TerminalNodeNumberResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TerminalNodeNumberResult))]
#endif
        public bool IsTerminalNodeNumberResult => TerminalNodeNumberResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TerminalNodeJsonResult? TerminalNodeJsonResult { get; init; }
#else
        public global::Vellum.TerminalNodeJsonResult? TerminalNodeJsonResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TerminalNodeJsonResult))]
#endif
        public bool IsTerminalNodeJsonResult => TerminalNodeJsonResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TerminalNodeChatHistoryResult? TerminalNodeChatHistoryResult { get; init; }
#else
        public global::Vellum.TerminalNodeChatHistoryResult? TerminalNodeChatHistoryResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TerminalNodeChatHistoryResult))]
#endif
        public bool IsTerminalNodeChatHistoryResult => TerminalNodeChatHistoryResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TerminalNodeSearchResultsResult? TerminalNodeSearchResultsResult { get; init; }
#else
        public global::Vellum.TerminalNodeSearchResultsResult? TerminalNodeSearchResultsResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TerminalNodeSearchResultsResult))]
#endif
        public bool IsTerminalNodeSearchResultsResult => TerminalNodeSearchResultsResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TerminalNodeErrorResult? TerminalNodeErrorResult { get; init; }
#else
        public global::Vellum.TerminalNodeErrorResult? TerminalNodeErrorResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TerminalNodeErrorResult))]
#endif
        public bool IsTerminalNodeErrorResult => TerminalNodeErrorResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TerminalNodeArrayResult? TerminalNodeArrayResult { get; init; }
#else
        public global::Vellum.TerminalNodeArrayResult? TerminalNodeArrayResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TerminalNodeArrayResult))]
#endif
        public bool IsTerminalNodeArrayResult => TerminalNodeArrayResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TerminalNodeFunctionCallResult? TerminalNodeFunctionCallResult { get; init; }
#else
        public global::Vellum.TerminalNodeFunctionCallResult? TerminalNodeFunctionCallResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TerminalNodeFunctionCallResult))]
#endif
        public bool IsTerminalNodeFunctionCallResult => TerminalNodeFunctionCallResult != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TerminalNodeResultOutput(global::Vellum.TerminalNodeStringResult value) => new TerminalNodeResultOutput((global::Vellum.TerminalNodeStringResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TerminalNodeStringResult?(TerminalNodeResultOutput @this) => @this.TerminalNodeStringResult;

        /// <summary>
        /// 
        /// </summary>
        public TerminalNodeResultOutput(global::Vellum.TerminalNodeStringResult? value)
        {
            TerminalNodeStringResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TerminalNodeResultOutput(global::Vellum.TerminalNodeNumberResult value) => new TerminalNodeResultOutput((global::Vellum.TerminalNodeNumberResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TerminalNodeNumberResult?(TerminalNodeResultOutput @this) => @this.TerminalNodeNumberResult;

        /// <summary>
        /// 
        /// </summary>
        public TerminalNodeResultOutput(global::Vellum.TerminalNodeNumberResult? value)
        {
            TerminalNodeNumberResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TerminalNodeResultOutput(global::Vellum.TerminalNodeJsonResult value) => new TerminalNodeResultOutput((global::Vellum.TerminalNodeJsonResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TerminalNodeJsonResult?(TerminalNodeResultOutput @this) => @this.TerminalNodeJsonResult;

        /// <summary>
        /// 
        /// </summary>
        public TerminalNodeResultOutput(global::Vellum.TerminalNodeJsonResult? value)
        {
            TerminalNodeJsonResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TerminalNodeResultOutput(global::Vellum.TerminalNodeChatHistoryResult value) => new TerminalNodeResultOutput((global::Vellum.TerminalNodeChatHistoryResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TerminalNodeChatHistoryResult?(TerminalNodeResultOutput @this) => @this.TerminalNodeChatHistoryResult;

        /// <summary>
        /// 
        /// </summary>
        public TerminalNodeResultOutput(global::Vellum.TerminalNodeChatHistoryResult? value)
        {
            TerminalNodeChatHistoryResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TerminalNodeResultOutput(global::Vellum.TerminalNodeSearchResultsResult value) => new TerminalNodeResultOutput((global::Vellum.TerminalNodeSearchResultsResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TerminalNodeSearchResultsResult?(TerminalNodeResultOutput @this) => @this.TerminalNodeSearchResultsResult;

        /// <summary>
        /// 
        /// </summary>
        public TerminalNodeResultOutput(global::Vellum.TerminalNodeSearchResultsResult? value)
        {
            TerminalNodeSearchResultsResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TerminalNodeResultOutput(global::Vellum.TerminalNodeErrorResult value) => new TerminalNodeResultOutput((global::Vellum.TerminalNodeErrorResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TerminalNodeErrorResult?(TerminalNodeResultOutput @this) => @this.TerminalNodeErrorResult;

        /// <summary>
        /// 
        /// </summary>
        public TerminalNodeResultOutput(global::Vellum.TerminalNodeErrorResult? value)
        {
            TerminalNodeErrorResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TerminalNodeResultOutput(global::Vellum.TerminalNodeArrayResult value) => new TerminalNodeResultOutput((global::Vellum.TerminalNodeArrayResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TerminalNodeArrayResult?(TerminalNodeResultOutput @this) => @this.TerminalNodeArrayResult;

        /// <summary>
        /// 
        /// </summary>
        public TerminalNodeResultOutput(global::Vellum.TerminalNodeArrayResult? value)
        {
            TerminalNodeArrayResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TerminalNodeResultOutput(global::Vellum.TerminalNodeFunctionCallResult value) => new TerminalNodeResultOutput((global::Vellum.TerminalNodeFunctionCallResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TerminalNodeFunctionCallResult?(TerminalNodeResultOutput @this) => @this.TerminalNodeFunctionCallResult;

        /// <summary>
        /// 
        /// </summary>
        public TerminalNodeResultOutput(global::Vellum.TerminalNodeFunctionCallResult? value)
        {
            TerminalNodeFunctionCallResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TerminalNodeResultOutput(
            global::Vellum.TerminalNodeStringResult? terminalNodeStringResult,
            global::Vellum.TerminalNodeNumberResult? terminalNodeNumberResult,
            global::Vellum.TerminalNodeJsonResult? terminalNodeJsonResult,
            global::Vellum.TerminalNodeChatHistoryResult? terminalNodeChatHistoryResult,
            global::Vellum.TerminalNodeSearchResultsResult? terminalNodeSearchResultsResult,
            global::Vellum.TerminalNodeErrorResult? terminalNodeErrorResult,
            global::Vellum.TerminalNodeArrayResult? terminalNodeArrayResult,
            global::Vellum.TerminalNodeFunctionCallResult? terminalNodeFunctionCallResult
            )
        {
            TerminalNodeStringResult = terminalNodeStringResult;
            TerminalNodeNumberResult = terminalNodeNumberResult;
            TerminalNodeJsonResult = terminalNodeJsonResult;
            TerminalNodeChatHistoryResult = terminalNodeChatHistoryResult;
            TerminalNodeSearchResultsResult = terminalNodeSearchResultsResult;
            TerminalNodeErrorResult = terminalNodeErrorResult;
            TerminalNodeArrayResult = terminalNodeArrayResult;
            TerminalNodeFunctionCallResult = terminalNodeFunctionCallResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TerminalNodeFunctionCallResult as object ??
            TerminalNodeArrayResult as object ??
            TerminalNodeErrorResult as object ??
            TerminalNodeSearchResultsResult as object ??
            TerminalNodeChatHistoryResult as object ??
            TerminalNodeJsonResult as object ??
            TerminalNodeNumberResult as object ??
            TerminalNodeStringResult as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TerminalNodeStringResult?.ToString() ??
            TerminalNodeNumberResult?.ToString() ??
            TerminalNodeJsonResult?.ToString() ??
            TerminalNodeChatHistoryResult?.ToString() ??
            TerminalNodeSearchResultsResult?.ToString() ??
            TerminalNodeErrorResult?.ToString() ??
            TerminalNodeArrayResult?.ToString() ??
            TerminalNodeFunctionCallResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTerminalNodeStringResult && !IsTerminalNodeNumberResult && !IsTerminalNodeJsonResult && !IsTerminalNodeChatHistoryResult && !IsTerminalNodeSearchResultsResult && !IsTerminalNodeErrorResult && !IsTerminalNodeArrayResult && !IsTerminalNodeFunctionCallResult || !IsTerminalNodeStringResult && IsTerminalNodeNumberResult && !IsTerminalNodeJsonResult && !IsTerminalNodeChatHistoryResult && !IsTerminalNodeSearchResultsResult && !IsTerminalNodeErrorResult && !IsTerminalNodeArrayResult && !IsTerminalNodeFunctionCallResult || !IsTerminalNodeStringResult && !IsTerminalNodeNumberResult && IsTerminalNodeJsonResult && !IsTerminalNodeChatHistoryResult && !IsTerminalNodeSearchResultsResult && !IsTerminalNodeErrorResult && !IsTerminalNodeArrayResult && !IsTerminalNodeFunctionCallResult || !IsTerminalNodeStringResult && !IsTerminalNodeNumberResult && !IsTerminalNodeJsonResult && IsTerminalNodeChatHistoryResult && !IsTerminalNodeSearchResultsResult && !IsTerminalNodeErrorResult && !IsTerminalNodeArrayResult && !IsTerminalNodeFunctionCallResult || !IsTerminalNodeStringResult && !IsTerminalNodeNumberResult && !IsTerminalNodeJsonResult && !IsTerminalNodeChatHistoryResult && IsTerminalNodeSearchResultsResult && !IsTerminalNodeErrorResult && !IsTerminalNodeArrayResult && !IsTerminalNodeFunctionCallResult || !IsTerminalNodeStringResult && !IsTerminalNodeNumberResult && !IsTerminalNodeJsonResult && !IsTerminalNodeChatHistoryResult && !IsTerminalNodeSearchResultsResult && IsTerminalNodeErrorResult && !IsTerminalNodeArrayResult && !IsTerminalNodeFunctionCallResult || !IsTerminalNodeStringResult && !IsTerminalNodeNumberResult && !IsTerminalNodeJsonResult && !IsTerminalNodeChatHistoryResult && !IsTerminalNodeSearchResultsResult && !IsTerminalNodeErrorResult && IsTerminalNodeArrayResult && !IsTerminalNodeFunctionCallResult || !IsTerminalNodeStringResult && !IsTerminalNodeNumberResult && !IsTerminalNodeJsonResult && !IsTerminalNodeChatHistoryResult && !IsTerminalNodeSearchResultsResult && !IsTerminalNodeErrorResult && !IsTerminalNodeArrayResult && IsTerminalNodeFunctionCallResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.TerminalNodeStringResult?, TResult>? terminalNodeStringResult = null,
            global::System.Func<global::Vellum.TerminalNodeNumberResult?, TResult>? terminalNodeNumberResult = null,
            global::System.Func<global::Vellum.TerminalNodeJsonResult?, TResult>? terminalNodeJsonResult = null,
            global::System.Func<global::Vellum.TerminalNodeChatHistoryResult?, TResult>? terminalNodeChatHistoryResult = null,
            global::System.Func<global::Vellum.TerminalNodeSearchResultsResult?, TResult>? terminalNodeSearchResultsResult = null,
            global::System.Func<global::Vellum.TerminalNodeErrorResult?, TResult>? terminalNodeErrorResult = null,
            global::System.Func<global::Vellum.TerminalNodeArrayResult?, TResult>? terminalNodeArrayResult = null,
            global::System.Func<global::Vellum.TerminalNodeFunctionCallResult?, TResult>? terminalNodeFunctionCallResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTerminalNodeStringResult && terminalNodeStringResult != null)
            {
                return terminalNodeStringResult(TerminalNodeStringResult!);
            }
            else if (IsTerminalNodeNumberResult && terminalNodeNumberResult != null)
            {
                return terminalNodeNumberResult(TerminalNodeNumberResult!);
            }
            else if (IsTerminalNodeJsonResult && terminalNodeJsonResult != null)
            {
                return terminalNodeJsonResult(TerminalNodeJsonResult!);
            }
            else if (IsTerminalNodeChatHistoryResult && terminalNodeChatHistoryResult != null)
            {
                return terminalNodeChatHistoryResult(TerminalNodeChatHistoryResult!);
            }
            else if (IsTerminalNodeSearchResultsResult && terminalNodeSearchResultsResult != null)
            {
                return terminalNodeSearchResultsResult(TerminalNodeSearchResultsResult!);
            }
            else if (IsTerminalNodeErrorResult && terminalNodeErrorResult != null)
            {
                return terminalNodeErrorResult(TerminalNodeErrorResult!);
            }
            else if (IsTerminalNodeArrayResult && terminalNodeArrayResult != null)
            {
                return terminalNodeArrayResult(TerminalNodeArrayResult!);
            }
            else if (IsTerminalNodeFunctionCallResult && terminalNodeFunctionCallResult != null)
            {
                return terminalNodeFunctionCallResult(TerminalNodeFunctionCallResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.TerminalNodeStringResult?>? terminalNodeStringResult = null,
            global::System.Action<global::Vellum.TerminalNodeNumberResult?>? terminalNodeNumberResult = null,
            global::System.Action<global::Vellum.TerminalNodeJsonResult?>? terminalNodeJsonResult = null,
            global::System.Action<global::Vellum.TerminalNodeChatHistoryResult?>? terminalNodeChatHistoryResult = null,
            global::System.Action<global::Vellum.TerminalNodeSearchResultsResult?>? terminalNodeSearchResultsResult = null,
            global::System.Action<global::Vellum.TerminalNodeErrorResult?>? terminalNodeErrorResult = null,
            global::System.Action<global::Vellum.TerminalNodeArrayResult?>? terminalNodeArrayResult = null,
            global::System.Action<global::Vellum.TerminalNodeFunctionCallResult?>? terminalNodeFunctionCallResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTerminalNodeStringResult)
            {
                terminalNodeStringResult?.Invoke(TerminalNodeStringResult!);
            }
            else if (IsTerminalNodeNumberResult)
            {
                terminalNodeNumberResult?.Invoke(TerminalNodeNumberResult!);
            }
            else if (IsTerminalNodeJsonResult)
            {
                terminalNodeJsonResult?.Invoke(TerminalNodeJsonResult!);
            }
            else if (IsTerminalNodeChatHistoryResult)
            {
                terminalNodeChatHistoryResult?.Invoke(TerminalNodeChatHistoryResult!);
            }
            else if (IsTerminalNodeSearchResultsResult)
            {
                terminalNodeSearchResultsResult?.Invoke(TerminalNodeSearchResultsResult!);
            }
            else if (IsTerminalNodeErrorResult)
            {
                terminalNodeErrorResult?.Invoke(TerminalNodeErrorResult!);
            }
            else if (IsTerminalNodeArrayResult)
            {
                terminalNodeArrayResult?.Invoke(TerminalNodeArrayResult!);
            }
            else if (IsTerminalNodeFunctionCallResult)
            {
                terminalNodeFunctionCallResult?.Invoke(TerminalNodeFunctionCallResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TerminalNodeStringResult,
                typeof(global::Vellum.TerminalNodeStringResult),
                TerminalNodeNumberResult,
                typeof(global::Vellum.TerminalNodeNumberResult),
                TerminalNodeJsonResult,
                typeof(global::Vellum.TerminalNodeJsonResult),
                TerminalNodeChatHistoryResult,
                typeof(global::Vellum.TerminalNodeChatHistoryResult),
                TerminalNodeSearchResultsResult,
                typeof(global::Vellum.TerminalNodeSearchResultsResult),
                TerminalNodeErrorResult,
                typeof(global::Vellum.TerminalNodeErrorResult),
                TerminalNodeArrayResult,
                typeof(global::Vellum.TerminalNodeArrayResult),
                TerminalNodeFunctionCallResult,
                typeof(global::Vellum.TerminalNodeFunctionCallResult),
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
        public bool Equals(TerminalNodeResultOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TerminalNodeStringResult?>.Default.Equals(TerminalNodeStringResult, other.TerminalNodeStringResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TerminalNodeNumberResult?>.Default.Equals(TerminalNodeNumberResult, other.TerminalNodeNumberResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TerminalNodeJsonResult?>.Default.Equals(TerminalNodeJsonResult, other.TerminalNodeJsonResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TerminalNodeChatHistoryResult?>.Default.Equals(TerminalNodeChatHistoryResult, other.TerminalNodeChatHistoryResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TerminalNodeSearchResultsResult?>.Default.Equals(TerminalNodeSearchResultsResult, other.TerminalNodeSearchResultsResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TerminalNodeErrorResult?>.Default.Equals(TerminalNodeErrorResult, other.TerminalNodeErrorResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TerminalNodeArrayResult?>.Default.Equals(TerminalNodeArrayResult, other.TerminalNodeArrayResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TerminalNodeFunctionCallResult?>.Default.Equals(TerminalNodeFunctionCallResult, other.TerminalNodeFunctionCallResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TerminalNodeResultOutput obj1, TerminalNodeResultOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TerminalNodeResultOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TerminalNodeResultOutput obj1, TerminalNodeResultOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TerminalNodeResultOutput o && Equals(o);
        }
    }
}
