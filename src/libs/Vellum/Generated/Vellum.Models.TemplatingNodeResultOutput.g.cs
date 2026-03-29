#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TemplatingNodeResultOutput : global::System.IEquatable<TemplatingNodeResultOutput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TemplatingNodeStringResult? TemplatingNodeStringResult { get; init; }
#else
        public global::Vellum.TemplatingNodeStringResult? TemplatingNodeStringResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TemplatingNodeStringResult))]
#endif
        public bool IsTemplatingNodeStringResult => TemplatingNodeStringResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TemplatingNodeNumberResult? TemplatingNodeNumberResult { get; init; }
#else
        public global::Vellum.TemplatingNodeNumberResult? TemplatingNodeNumberResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TemplatingNodeNumberResult))]
#endif
        public bool IsTemplatingNodeNumberResult => TemplatingNodeNumberResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TemplatingNodeJsonResult? TemplatingNodeJsonResult { get; init; }
#else
        public global::Vellum.TemplatingNodeJsonResult? TemplatingNodeJsonResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TemplatingNodeJsonResult))]
#endif
        public bool IsTemplatingNodeJsonResult => TemplatingNodeJsonResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TemplatingNodeChatHistoryResult? TemplatingNodeChatHistoryResult { get; init; }
#else
        public global::Vellum.TemplatingNodeChatHistoryResult? TemplatingNodeChatHistoryResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TemplatingNodeChatHistoryResult))]
#endif
        public bool IsTemplatingNodeChatHistoryResult => TemplatingNodeChatHistoryResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TemplatingNodeSearchResultsResult? TemplatingNodeSearchResultsResult { get; init; }
#else
        public global::Vellum.TemplatingNodeSearchResultsResult? TemplatingNodeSearchResultsResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TemplatingNodeSearchResultsResult))]
#endif
        public bool IsTemplatingNodeSearchResultsResult => TemplatingNodeSearchResultsResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TemplatingNodeErrorResult? TemplatingNodeErrorResult { get; init; }
#else
        public global::Vellum.TemplatingNodeErrorResult? TemplatingNodeErrorResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TemplatingNodeErrorResult))]
#endif
        public bool IsTemplatingNodeErrorResult => TemplatingNodeErrorResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TemplatingNodeArrayResult? TemplatingNodeArrayResult { get; init; }
#else
        public global::Vellum.TemplatingNodeArrayResult? TemplatingNodeArrayResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TemplatingNodeArrayResult))]
#endif
        public bool IsTemplatingNodeArrayResult => TemplatingNodeArrayResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TemplatingNodeFunctionCallResult? TemplatingNodeFunctionCallResult { get; init; }
#else
        public global::Vellum.TemplatingNodeFunctionCallResult? TemplatingNodeFunctionCallResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TemplatingNodeFunctionCallResult))]
#endif
        public bool IsTemplatingNodeFunctionCallResult => TemplatingNodeFunctionCallResult != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TemplatingNodeResultOutput(global::Vellum.TemplatingNodeStringResult value) => new TemplatingNodeResultOutput((global::Vellum.TemplatingNodeStringResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TemplatingNodeStringResult?(TemplatingNodeResultOutput @this) => @this.TemplatingNodeStringResult;

        /// <summary>
        /// 
        /// </summary>
        public TemplatingNodeResultOutput(global::Vellum.TemplatingNodeStringResult? value)
        {
            TemplatingNodeStringResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TemplatingNodeResultOutput(global::Vellum.TemplatingNodeNumberResult value) => new TemplatingNodeResultOutput((global::Vellum.TemplatingNodeNumberResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TemplatingNodeNumberResult?(TemplatingNodeResultOutput @this) => @this.TemplatingNodeNumberResult;

        /// <summary>
        /// 
        /// </summary>
        public TemplatingNodeResultOutput(global::Vellum.TemplatingNodeNumberResult? value)
        {
            TemplatingNodeNumberResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TemplatingNodeResultOutput(global::Vellum.TemplatingNodeJsonResult value) => new TemplatingNodeResultOutput((global::Vellum.TemplatingNodeJsonResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TemplatingNodeJsonResult?(TemplatingNodeResultOutput @this) => @this.TemplatingNodeJsonResult;

        /// <summary>
        /// 
        /// </summary>
        public TemplatingNodeResultOutput(global::Vellum.TemplatingNodeJsonResult? value)
        {
            TemplatingNodeJsonResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TemplatingNodeResultOutput(global::Vellum.TemplatingNodeChatHistoryResult value) => new TemplatingNodeResultOutput((global::Vellum.TemplatingNodeChatHistoryResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TemplatingNodeChatHistoryResult?(TemplatingNodeResultOutput @this) => @this.TemplatingNodeChatHistoryResult;

        /// <summary>
        /// 
        /// </summary>
        public TemplatingNodeResultOutput(global::Vellum.TemplatingNodeChatHistoryResult? value)
        {
            TemplatingNodeChatHistoryResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TemplatingNodeResultOutput(global::Vellum.TemplatingNodeSearchResultsResult value) => new TemplatingNodeResultOutput((global::Vellum.TemplatingNodeSearchResultsResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TemplatingNodeSearchResultsResult?(TemplatingNodeResultOutput @this) => @this.TemplatingNodeSearchResultsResult;

        /// <summary>
        /// 
        /// </summary>
        public TemplatingNodeResultOutput(global::Vellum.TemplatingNodeSearchResultsResult? value)
        {
            TemplatingNodeSearchResultsResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TemplatingNodeResultOutput(global::Vellum.TemplatingNodeErrorResult value) => new TemplatingNodeResultOutput((global::Vellum.TemplatingNodeErrorResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TemplatingNodeErrorResult?(TemplatingNodeResultOutput @this) => @this.TemplatingNodeErrorResult;

        /// <summary>
        /// 
        /// </summary>
        public TemplatingNodeResultOutput(global::Vellum.TemplatingNodeErrorResult? value)
        {
            TemplatingNodeErrorResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TemplatingNodeResultOutput(global::Vellum.TemplatingNodeArrayResult value) => new TemplatingNodeResultOutput((global::Vellum.TemplatingNodeArrayResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TemplatingNodeArrayResult?(TemplatingNodeResultOutput @this) => @this.TemplatingNodeArrayResult;

        /// <summary>
        /// 
        /// </summary>
        public TemplatingNodeResultOutput(global::Vellum.TemplatingNodeArrayResult? value)
        {
            TemplatingNodeArrayResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TemplatingNodeResultOutput(global::Vellum.TemplatingNodeFunctionCallResult value) => new TemplatingNodeResultOutput((global::Vellum.TemplatingNodeFunctionCallResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TemplatingNodeFunctionCallResult?(TemplatingNodeResultOutput @this) => @this.TemplatingNodeFunctionCallResult;

        /// <summary>
        /// 
        /// </summary>
        public TemplatingNodeResultOutput(global::Vellum.TemplatingNodeFunctionCallResult? value)
        {
            TemplatingNodeFunctionCallResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TemplatingNodeResultOutput(
            global::Vellum.TemplatingNodeStringResult? templatingNodeStringResult,
            global::Vellum.TemplatingNodeNumberResult? templatingNodeNumberResult,
            global::Vellum.TemplatingNodeJsonResult? templatingNodeJsonResult,
            global::Vellum.TemplatingNodeChatHistoryResult? templatingNodeChatHistoryResult,
            global::Vellum.TemplatingNodeSearchResultsResult? templatingNodeSearchResultsResult,
            global::Vellum.TemplatingNodeErrorResult? templatingNodeErrorResult,
            global::Vellum.TemplatingNodeArrayResult? templatingNodeArrayResult,
            global::Vellum.TemplatingNodeFunctionCallResult? templatingNodeFunctionCallResult
            )
        {
            TemplatingNodeStringResult = templatingNodeStringResult;
            TemplatingNodeNumberResult = templatingNodeNumberResult;
            TemplatingNodeJsonResult = templatingNodeJsonResult;
            TemplatingNodeChatHistoryResult = templatingNodeChatHistoryResult;
            TemplatingNodeSearchResultsResult = templatingNodeSearchResultsResult;
            TemplatingNodeErrorResult = templatingNodeErrorResult;
            TemplatingNodeArrayResult = templatingNodeArrayResult;
            TemplatingNodeFunctionCallResult = templatingNodeFunctionCallResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TemplatingNodeFunctionCallResult as object ??
            TemplatingNodeArrayResult as object ??
            TemplatingNodeErrorResult as object ??
            TemplatingNodeSearchResultsResult as object ??
            TemplatingNodeChatHistoryResult as object ??
            TemplatingNodeJsonResult as object ??
            TemplatingNodeNumberResult as object ??
            TemplatingNodeStringResult as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TemplatingNodeStringResult?.ToString() ??
            TemplatingNodeNumberResult?.ToString() ??
            TemplatingNodeJsonResult?.ToString() ??
            TemplatingNodeChatHistoryResult?.ToString() ??
            TemplatingNodeSearchResultsResult?.ToString() ??
            TemplatingNodeErrorResult?.ToString() ??
            TemplatingNodeArrayResult?.ToString() ??
            TemplatingNodeFunctionCallResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTemplatingNodeStringResult && !IsTemplatingNodeNumberResult && !IsTemplatingNodeJsonResult && !IsTemplatingNodeChatHistoryResult && !IsTemplatingNodeSearchResultsResult && !IsTemplatingNodeErrorResult && !IsTemplatingNodeArrayResult && !IsTemplatingNodeFunctionCallResult || !IsTemplatingNodeStringResult && IsTemplatingNodeNumberResult && !IsTemplatingNodeJsonResult && !IsTemplatingNodeChatHistoryResult && !IsTemplatingNodeSearchResultsResult && !IsTemplatingNodeErrorResult && !IsTemplatingNodeArrayResult && !IsTemplatingNodeFunctionCallResult || !IsTemplatingNodeStringResult && !IsTemplatingNodeNumberResult && IsTemplatingNodeJsonResult && !IsTemplatingNodeChatHistoryResult && !IsTemplatingNodeSearchResultsResult && !IsTemplatingNodeErrorResult && !IsTemplatingNodeArrayResult && !IsTemplatingNodeFunctionCallResult || !IsTemplatingNodeStringResult && !IsTemplatingNodeNumberResult && !IsTemplatingNodeJsonResult && IsTemplatingNodeChatHistoryResult && !IsTemplatingNodeSearchResultsResult && !IsTemplatingNodeErrorResult && !IsTemplatingNodeArrayResult && !IsTemplatingNodeFunctionCallResult || !IsTemplatingNodeStringResult && !IsTemplatingNodeNumberResult && !IsTemplatingNodeJsonResult && !IsTemplatingNodeChatHistoryResult && IsTemplatingNodeSearchResultsResult && !IsTemplatingNodeErrorResult && !IsTemplatingNodeArrayResult && !IsTemplatingNodeFunctionCallResult || !IsTemplatingNodeStringResult && !IsTemplatingNodeNumberResult && !IsTemplatingNodeJsonResult && !IsTemplatingNodeChatHistoryResult && !IsTemplatingNodeSearchResultsResult && IsTemplatingNodeErrorResult && !IsTemplatingNodeArrayResult && !IsTemplatingNodeFunctionCallResult || !IsTemplatingNodeStringResult && !IsTemplatingNodeNumberResult && !IsTemplatingNodeJsonResult && !IsTemplatingNodeChatHistoryResult && !IsTemplatingNodeSearchResultsResult && !IsTemplatingNodeErrorResult && IsTemplatingNodeArrayResult && !IsTemplatingNodeFunctionCallResult || !IsTemplatingNodeStringResult && !IsTemplatingNodeNumberResult && !IsTemplatingNodeJsonResult && !IsTemplatingNodeChatHistoryResult && !IsTemplatingNodeSearchResultsResult && !IsTemplatingNodeErrorResult && !IsTemplatingNodeArrayResult && IsTemplatingNodeFunctionCallResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.TemplatingNodeStringResult?, TResult>? templatingNodeStringResult = null,
            global::System.Func<global::Vellum.TemplatingNodeNumberResult?, TResult>? templatingNodeNumberResult = null,
            global::System.Func<global::Vellum.TemplatingNodeJsonResult?, TResult>? templatingNodeJsonResult = null,
            global::System.Func<global::Vellum.TemplatingNodeChatHistoryResult?, TResult>? templatingNodeChatHistoryResult = null,
            global::System.Func<global::Vellum.TemplatingNodeSearchResultsResult?, TResult>? templatingNodeSearchResultsResult = null,
            global::System.Func<global::Vellum.TemplatingNodeErrorResult?, TResult>? templatingNodeErrorResult = null,
            global::System.Func<global::Vellum.TemplatingNodeArrayResult?, TResult>? templatingNodeArrayResult = null,
            global::System.Func<global::Vellum.TemplatingNodeFunctionCallResult?, TResult>? templatingNodeFunctionCallResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTemplatingNodeStringResult && templatingNodeStringResult != null)
            {
                return templatingNodeStringResult(TemplatingNodeStringResult!);
            }
            else if (IsTemplatingNodeNumberResult && templatingNodeNumberResult != null)
            {
                return templatingNodeNumberResult(TemplatingNodeNumberResult!);
            }
            else if (IsTemplatingNodeJsonResult && templatingNodeJsonResult != null)
            {
                return templatingNodeJsonResult(TemplatingNodeJsonResult!);
            }
            else if (IsTemplatingNodeChatHistoryResult && templatingNodeChatHistoryResult != null)
            {
                return templatingNodeChatHistoryResult(TemplatingNodeChatHistoryResult!);
            }
            else if (IsTemplatingNodeSearchResultsResult && templatingNodeSearchResultsResult != null)
            {
                return templatingNodeSearchResultsResult(TemplatingNodeSearchResultsResult!);
            }
            else if (IsTemplatingNodeErrorResult && templatingNodeErrorResult != null)
            {
                return templatingNodeErrorResult(TemplatingNodeErrorResult!);
            }
            else if (IsTemplatingNodeArrayResult && templatingNodeArrayResult != null)
            {
                return templatingNodeArrayResult(TemplatingNodeArrayResult!);
            }
            else if (IsTemplatingNodeFunctionCallResult && templatingNodeFunctionCallResult != null)
            {
                return templatingNodeFunctionCallResult(TemplatingNodeFunctionCallResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.TemplatingNodeStringResult?>? templatingNodeStringResult = null,
            global::System.Action<global::Vellum.TemplatingNodeNumberResult?>? templatingNodeNumberResult = null,
            global::System.Action<global::Vellum.TemplatingNodeJsonResult?>? templatingNodeJsonResult = null,
            global::System.Action<global::Vellum.TemplatingNodeChatHistoryResult?>? templatingNodeChatHistoryResult = null,
            global::System.Action<global::Vellum.TemplatingNodeSearchResultsResult?>? templatingNodeSearchResultsResult = null,
            global::System.Action<global::Vellum.TemplatingNodeErrorResult?>? templatingNodeErrorResult = null,
            global::System.Action<global::Vellum.TemplatingNodeArrayResult?>? templatingNodeArrayResult = null,
            global::System.Action<global::Vellum.TemplatingNodeFunctionCallResult?>? templatingNodeFunctionCallResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTemplatingNodeStringResult)
            {
                templatingNodeStringResult?.Invoke(TemplatingNodeStringResult!);
            }
            else if (IsTemplatingNodeNumberResult)
            {
                templatingNodeNumberResult?.Invoke(TemplatingNodeNumberResult!);
            }
            else if (IsTemplatingNodeJsonResult)
            {
                templatingNodeJsonResult?.Invoke(TemplatingNodeJsonResult!);
            }
            else if (IsTemplatingNodeChatHistoryResult)
            {
                templatingNodeChatHistoryResult?.Invoke(TemplatingNodeChatHistoryResult!);
            }
            else if (IsTemplatingNodeSearchResultsResult)
            {
                templatingNodeSearchResultsResult?.Invoke(TemplatingNodeSearchResultsResult!);
            }
            else if (IsTemplatingNodeErrorResult)
            {
                templatingNodeErrorResult?.Invoke(TemplatingNodeErrorResult!);
            }
            else if (IsTemplatingNodeArrayResult)
            {
                templatingNodeArrayResult?.Invoke(TemplatingNodeArrayResult!);
            }
            else if (IsTemplatingNodeFunctionCallResult)
            {
                templatingNodeFunctionCallResult?.Invoke(TemplatingNodeFunctionCallResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TemplatingNodeStringResult,
                typeof(global::Vellum.TemplatingNodeStringResult),
                TemplatingNodeNumberResult,
                typeof(global::Vellum.TemplatingNodeNumberResult),
                TemplatingNodeJsonResult,
                typeof(global::Vellum.TemplatingNodeJsonResult),
                TemplatingNodeChatHistoryResult,
                typeof(global::Vellum.TemplatingNodeChatHistoryResult),
                TemplatingNodeSearchResultsResult,
                typeof(global::Vellum.TemplatingNodeSearchResultsResult),
                TemplatingNodeErrorResult,
                typeof(global::Vellum.TemplatingNodeErrorResult),
                TemplatingNodeArrayResult,
                typeof(global::Vellum.TemplatingNodeArrayResult),
                TemplatingNodeFunctionCallResult,
                typeof(global::Vellum.TemplatingNodeFunctionCallResult),
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
        public bool Equals(TemplatingNodeResultOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TemplatingNodeStringResult?>.Default.Equals(TemplatingNodeStringResult, other.TemplatingNodeStringResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TemplatingNodeNumberResult?>.Default.Equals(TemplatingNodeNumberResult, other.TemplatingNodeNumberResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TemplatingNodeJsonResult?>.Default.Equals(TemplatingNodeJsonResult, other.TemplatingNodeJsonResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TemplatingNodeChatHistoryResult?>.Default.Equals(TemplatingNodeChatHistoryResult, other.TemplatingNodeChatHistoryResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TemplatingNodeSearchResultsResult?>.Default.Equals(TemplatingNodeSearchResultsResult, other.TemplatingNodeSearchResultsResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TemplatingNodeErrorResult?>.Default.Equals(TemplatingNodeErrorResult, other.TemplatingNodeErrorResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TemplatingNodeArrayResult?>.Default.Equals(TemplatingNodeArrayResult, other.TemplatingNodeArrayResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TemplatingNodeFunctionCallResult?>.Default.Equals(TemplatingNodeFunctionCallResult, other.TemplatingNodeFunctionCallResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TemplatingNodeResultOutput obj1, TemplatingNodeResultOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TemplatingNodeResultOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TemplatingNodeResultOutput obj1, TemplatingNodeResultOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TemplatingNodeResultOutput o && Equals(o);
        }
    }
}
