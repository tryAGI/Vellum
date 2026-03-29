#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WorkflowResultEventOutputData : global::System.IEquatable<WorkflowResultEventOutputData>
    {
        /// <summary>
        /// A string output streamed from a Workflow execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowResultEventOutputDataString? WorkflowResultEventOutputDataString { get; init; }
#else
        public global::Vellum.WorkflowResultEventOutputDataString? WorkflowResultEventOutputDataString { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowResultEventOutputDataString))]
#endif
        public bool IsWorkflowResultEventOutputDataString => WorkflowResultEventOutputDataString != null;

        /// <summary>
        /// A number output streamed from a Workflow execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowResultEventOutputDataNumber? WorkflowResultEventOutputDataNumber { get; init; }
#else
        public global::Vellum.WorkflowResultEventOutputDataNumber? WorkflowResultEventOutputDataNumber { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowResultEventOutputDataNumber))]
#endif
        public bool IsWorkflowResultEventOutputDataNumber => WorkflowResultEventOutputDataNumber != null;

        /// <summary>
        /// A JSON output streamed from a Workflow execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowResultEventOutputDataJSON? WorkflowResultEventOutputDataJSON { get; init; }
#else
        public global::Vellum.WorkflowResultEventOutputDataJSON? WorkflowResultEventOutputDataJSON { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowResultEventOutputDataJSON))]
#endif
        public bool IsWorkflowResultEventOutputDataJSON => WorkflowResultEventOutputDataJSON != null;

        /// <summary>
        /// A Chat History output streamed from a Workflow execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowResultEventOutputDataChatHistory? WorkflowResultEventOutputDataChatHistory { get; init; }
#else
        public global::Vellum.WorkflowResultEventOutputDataChatHistory? WorkflowResultEventOutputDataChatHistory { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowResultEventOutputDataChatHistory))]
#endif
        public bool IsWorkflowResultEventOutputDataChatHistory => WorkflowResultEventOutputDataChatHistory != null;

        /// <summary>
        /// A Search Results output streamed from a Workflow execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowResultEventOutputDataSearchResults? WorkflowResultEventOutputDataSearchResults { get; init; }
#else
        public global::Vellum.WorkflowResultEventOutputDataSearchResults? WorkflowResultEventOutputDataSearchResults { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowResultEventOutputDataSearchResults))]
#endif
        public bool IsWorkflowResultEventOutputDataSearchResults => WorkflowResultEventOutputDataSearchResults != null;

        /// <summary>
        /// An Array output returned from a Workflow execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowResultEventOutputDataArray? WorkflowResultEventOutputDataArray { get; init; }
#else
        public global::Vellum.WorkflowResultEventOutputDataArray? WorkflowResultEventOutputDataArray { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowResultEventOutputDataArray))]
#endif
        public bool IsWorkflowResultEventOutputDataArray => WorkflowResultEventOutputDataArray != null;

        /// <summary>
        /// A Function Call output returned from a Workflow execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowResultEventOutputDataFunctionCall? WorkflowResultEventOutputDataFunctionCall { get; init; }
#else
        public global::Vellum.WorkflowResultEventOutputDataFunctionCall? WorkflowResultEventOutputDataFunctionCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowResultEventOutputDataFunctionCall))]
#endif
        public bool IsWorkflowResultEventOutputDataFunctionCall => WorkflowResultEventOutputDataFunctionCall != null;

        /// <summary>
        /// An Error output streamed from a Workflow execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowResultEventOutputDataError? WorkflowResultEventOutputDataError { get; init; }
#else
        public global::Vellum.WorkflowResultEventOutputDataError? WorkflowResultEventOutputDataError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowResultEventOutputDataError))]
#endif
        public bool IsWorkflowResultEventOutputDataError => WorkflowResultEventOutputDataError != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowResultEventOutputData(global::Vellum.WorkflowResultEventOutputDataString value) => new WorkflowResultEventOutputData((global::Vellum.WorkflowResultEventOutputDataString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowResultEventOutputDataString?(WorkflowResultEventOutputData @this) => @this.WorkflowResultEventOutputDataString;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowResultEventOutputData(global::Vellum.WorkflowResultEventOutputDataString? value)
        {
            WorkflowResultEventOutputDataString = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowResultEventOutputData(global::Vellum.WorkflowResultEventOutputDataNumber value) => new WorkflowResultEventOutputData((global::Vellum.WorkflowResultEventOutputDataNumber?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowResultEventOutputDataNumber?(WorkflowResultEventOutputData @this) => @this.WorkflowResultEventOutputDataNumber;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowResultEventOutputData(global::Vellum.WorkflowResultEventOutputDataNumber? value)
        {
            WorkflowResultEventOutputDataNumber = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowResultEventOutputData(global::Vellum.WorkflowResultEventOutputDataJSON value) => new WorkflowResultEventOutputData((global::Vellum.WorkflowResultEventOutputDataJSON?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowResultEventOutputDataJSON?(WorkflowResultEventOutputData @this) => @this.WorkflowResultEventOutputDataJSON;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowResultEventOutputData(global::Vellum.WorkflowResultEventOutputDataJSON? value)
        {
            WorkflowResultEventOutputDataJSON = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowResultEventOutputData(global::Vellum.WorkflowResultEventOutputDataChatHistory value) => new WorkflowResultEventOutputData((global::Vellum.WorkflowResultEventOutputDataChatHistory?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowResultEventOutputDataChatHistory?(WorkflowResultEventOutputData @this) => @this.WorkflowResultEventOutputDataChatHistory;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowResultEventOutputData(global::Vellum.WorkflowResultEventOutputDataChatHistory? value)
        {
            WorkflowResultEventOutputDataChatHistory = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowResultEventOutputData(global::Vellum.WorkflowResultEventOutputDataSearchResults value) => new WorkflowResultEventOutputData((global::Vellum.WorkflowResultEventOutputDataSearchResults?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowResultEventOutputDataSearchResults?(WorkflowResultEventOutputData @this) => @this.WorkflowResultEventOutputDataSearchResults;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowResultEventOutputData(global::Vellum.WorkflowResultEventOutputDataSearchResults? value)
        {
            WorkflowResultEventOutputDataSearchResults = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowResultEventOutputData(global::Vellum.WorkflowResultEventOutputDataArray value) => new WorkflowResultEventOutputData((global::Vellum.WorkflowResultEventOutputDataArray?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowResultEventOutputDataArray?(WorkflowResultEventOutputData @this) => @this.WorkflowResultEventOutputDataArray;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowResultEventOutputData(global::Vellum.WorkflowResultEventOutputDataArray? value)
        {
            WorkflowResultEventOutputDataArray = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowResultEventOutputData(global::Vellum.WorkflowResultEventOutputDataFunctionCall value) => new WorkflowResultEventOutputData((global::Vellum.WorkflowResultEventOutputDataFunctionCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowResultEventOutputDataFunctionCall?(WorkflowResultEventOutputData @this) => @this.WorkflowResultEventOutputDataFunctionCall;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowResultEventOutputData(global::Vellum.WorkflowResultEventOutputDataFunctionCall? value)
        {
            WorkflowResultEventOutputDataFunctionCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowResultEventOutputData(global::Vellum.WorkflowResultEventOutputDataError value) => new WorkflowResultEventOutputData((global::Vellum.WorkflowResultEventOutputDataError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowResultEventOutputDataError?(WorkflowResultEventOutputData @this) => @this.WorkflowResultEventOutputDataError;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowResultEventOutputData(global::Vellum.WorkflowResultEventOutputDataError? value)
        {
            WorkflowResultEventOutputDataError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WorkflowResultEventOutputData(
            global::Vellum.WorkflowResultEventOutputDataString? workflowResultEventOutputDataString,
            global::Vellum.WorkflowResultEventOutputDataNumber? workflowResultEventOutputDataNumber,
            global::Vellum.WorkflowResultEventOutputDataJSON? workflowResultEventOutputDataJSON,
            global::Vellum.WorkflowResultEventOutputDataChatHistory? workflowResultEventOutputDataChatHistory,
            global::Vellum.WorkflowResultEventOutputDataSearchResults? workflowResultEventOutputDataSearchResults,
            global::Vellum.WorkflowResultEventOutputDataArray? workflowResultEventOutputDataArray,
            global::Vellum.WorkflowResultEventOutputDataFunctionCall? workflowResultEventOutputDataFunctionCall,
            global::Vellum.WorkflowResultEventOutputDataError? workflowResultEventOutputDataError
            )
        {
            WorkflowResultEventOutputDataString = workflowResultEventOutputDataString;
            WorkflowResultEventOutputDataNumber = workflowResultEventOutputDataNumber;
            WorkflowResultEventOutputDataJSON = workflowResultEventOutputDataJSON;
            WorkflowResultEventOutputDataChatHistory = workflowResultEventOutputDataChatHistory;
            WorkflowResultEventOutputDataSearchResults = workflowResultEventOutputDataSearchResults;
            WorkflowResultEventOutputDataArray = workflowResultEventOutputDataArray;
            WorkflowResultEventOutputDataFunctionCall = workflowResultEventOutputDataFunctionCall;
            WorkflowResultEventOutputDataError = workflowResultEventOutputDataError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WorkflowResultEventOutputDataError as object ??
            WorkflowResultEventOutputDataFunctionCall as object ??
            WorkflowResultEventOutputDataArray as object ??
            WorkflowResultEventOutputDataSearchResults as object ??
            WorkflowResultEventOutputDataChatHistory as object ??
            WorkflowResultEventOutputDataJSON as object ??
            WorkflowResultEventOutputDataNumber as object ??
            WorkflowResultEventOutputDataString as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WorkflowResultEventOutputDataString?.ToString() ??
            WorkflowResultEventOutputDataNumber?.ToString() ??
            WorkflowResultEventOutputDataJSON?.ToString() ??
            WorkflowResultEventOutputDataChatHistory?.ToString() ??
            WorkflowResultEventOutputDataSearchResults?.ToString() ??
            WorkflowResultEventOutputDataArray?.ToString() ??
            WorkflowResultEventOutputDataFunctionCall?.ToString() ??
            WorkflowResultEventOutputDataError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWorkflowResultEventOutputDataString && !IsWorkflowResultEventOutputDataNumber && !IsWorkflowResultEventOutputDataJSON && !IsWorkflowResultEventOutputDataChatHistory && !IsWorkflowResultEventOutputDataSearchResults && !IsWorkflowResultEventOutputDataArray && !IsWorkflowResultEventOutputDataFunctionCall && !IsWorkflowResultEventOutputDataError || !IsWorkflowResultEventOutputDataString && IsWorkflowResultEventOutputDataNumber && !IsWorkflowResultEventOutputDataJSON && !IsWorkflowResultEventOutputDataChatHistory && !IsWorkflowResultEventOutputDataSearchResults && !IsWorkflowResultEventOutputDataArray && !IsWorkflowResultEventOutputDataFunctionCall && !IsWorkflowResultEventOutputDataError || !IsWorkflowResultEventOutputDataString && !IsWorkflowResultEventOutputDataNumber && IsWorkflowResultEventOutputDataJSON && !IsWorkflowResultEventOutputDataChatHistory && !IsWorkflowResultEventOutputDataSearchResults && !IsWorkflowResultEventOutputDataArray && !IsWorkflowResultEventOutputDataFunctionCall && !IsWorkflowResultEventOutputDataError || !IsWorkflowResultEventOutputDataString && !IsWorkflowResultEventOutputDataNumber && !IsWorkflowResultEventOutputDataJSON && IsWorkflowResultEventOutputDataChatHistory && !IsWorkflowResultEventOutputDataSearchResults && !IsWorkflowResultEventOutputDataArray && !IsWorkflowResultEventOutputDataFunctionCall && !IsWorkflowResultEventOutputDataError || !IsWorkflowResultEventOutputDataString && !IsWorkflowResultEventOutputDataNumber && !IsWorkflowResultEventOutputDataJSON && !IsWorkflowResultEventOutputDataChatHistory && IsWorkflowResultEventOutputDataSearchResults && !IsWorkflowResultEventOutputDataArray && !IsWorkflowResultEventOutputDataFunctionCall && !IsWorkflowResultEventOutputDataError || !IsWorkflowResultEventOutputDataString && !IsWorkflowResultEventOutputDataNumber && !IsWorkflowResultEventOutputDataJSON && !IsWorkflowResultEventOutputDataChatHistory && !IsWorkflowResultEventOutputDataSearchResults && IsWorkflowResultEventOutputDataArray && !IsWorkflowResultEventOutputDataFunctionCall && !IsWorkflowResultEventOutputDataError || !IsWorkflowResultEventOutputDataString && !IsWorkflowResultEventOutputDataNumber && !IsWorkflowResultEventOutputDataJSON && !IsWorkflowResultEventOutputDataChatHistory && !IsWorkflowResultEventOutputDataSearchResults && !IsWorkflowResultEventOutputDataArray && IsWorkflowResultEventOutputDataFunctionCall && !IsWorkflowResultEventOutputDataError || !IsWorkflowResultEventOutputDataString && !IsWorkflowResultEventOutputDataNumber && !IsWorkflowResultEventOutputDataJSON && !IsWorkflowResultEventOutputDataChatHistory && !IsWorkflowResultEventOutputDataSearchResults && !IsWorkflowResultEventOutputDataArray && !IsWorkflowResultEventOutputDataFunctionCall && IsWorkflowResultEventOutputDataError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.WorkflowResultEventOutputDataString?, TResult>? workflowResultEventOutputDataString = null,
            global::System.Func<global::Vellum.WorkflowResultEventOutputDataNumber?, TResult>? workflowResultEventOutputDataNumber = null,
            global::System.Func<global::Vellum.WorkflowResultEventOutputDataJSON?, TResult>? workflowResultEventOutputDataJSON = null,
            global::System.Func<global::Vellum.WorkflowResultEventOutputDataChatHistory?, TResult>? workflowResultEventOutputDataChatHistory = null,
            global::System.Func<global::Vellum.WorkflowResultEventOutputDataSearchResults?, TResult>? workflowResultEventOutputDataSearchResults = null,
            global::System.Func<global::Vellum.WorkflowResultEventOutputDataArray?, TResult>? workflowResultEventOutputDataArray = null,
            global::System.Func<global::Vellum.WorkflowResultEventOutputDataFunctionCall?, TResult>? workflowResultEventOutputDataFunctionCall = null,
            global::System.Func<global::Vellum.WorkflowResultEventOutputDataError?, TResult>? workflowResultEventOutputDataError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowResultEventOutputDataString && workflowResultEventOutputDataString != null)
            {
                return workflowResultEventOutputDataString(WorkflowResultEventOutputDataString!);
            }
            else if (IsWorkflowResultEventOutputDataNumber && workflowResultEventOutputDataNumber != null)
            {
                return workflowResultEventOutputDataNumber(WorkflowResultEventOutputDataNumber!);
            }
            else if (IsWorkflowResultEventOutputDataJSON && workflowResultEventOutputDataJSON != null)
            {
                return workflowResultEventOutputDataJSON(WorkflowResultEventOutputDataJSON!);
            }
            else if (IsWorkflowResultEventOutputDataChatHistory && workflowResultEventOutputDataChatHistory != null)
            {
                return workflowResultEventOutputDataChatHistory(WorkflowResultEventOutputDataChatHistory!);
            }
            else if (IsWorkflowResultEventOutputDataSearchResults && workflowResultEventOutputDataSearchResults != null)
            {
                return workflowResultEventOutputDataSearchResults(WorkflowResultEventOutputDataSearchResults!);
            }
            else if (IsWorkflowResultEventOutputDataArray && workflowResultEventOutputDataArray != null)
            {
                return workflowResultEventOutputDataArray(WorkflowResultEventOutputDataArray!);
            }
            else if (IsWorkflowResultEventOutputDataFunctionCall && workflowResultEventOutputDataFunctionCall != null)
            {
                return workflowResultEventOutputDataFunctionCall(WorkflowResultEventOutputDataFunctionCall!);
            }
            else if (IsWorkflowResultEventOutputDataError && workflowResultEventOutputDataError != null)
            {
                return workflowResultEventOutputDataError(WorkflowResultEventOutputDataError!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.WorkflowResultEventOutputDataString?>? workflowResultEventOutputDataString = null,
            global::System.Action<global::Vellum.WorkflowResultEventOutputDataNumber?>? workflowResultEventOutputDataNumber = null,
            global::System.Action<global::Vellum.WorkflowResultEventOutputDataJSON?>? workflowResultEventOutputDataJSON = null,
            global::System.Action<global::Vellum.WorkflowResultEventOutputDataChatHistory?>? workflowResultEventOutputDataChatHistory = null,
            global::System.Action<global::Vellum.WorkflowResultEventOutputDataSearchResults?>? workflowResultEventOutputDataSearchResults = null,
            global::System.Action<global::Vellum.WorkflowResultEventOutputDataArray?>? workflowResultEventOutputDataArray = null,
            global::System.Action<global::Vellum.WorkflowResultEventOutputDataFunctionCall?>? workflowResultEventOutputDataFunctionCall = null,
            global::System.Action<global::Vellum.WorkflowResultEventOutputDataError?>? workflowResultEventOutputDataError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowResultEventOutputDataString)
            {
                workflowResultEventOutputDataString?.Invoke(WorkflowResultEventOutputDataString!);
            }
            else if (IsWorkflowResultEventOutputDataNumber)
            {
                workflowResultEventOutputDataNumber?.Invoke(WorkflowResultEventOutputDataNumber!);
            }
            else if (IsWorkflowResultEventOutputDataJSON)
            {
                workflowResultEventOutputDataJSON?.Invoke(WorkflowResultEventOutputDataJSON!);
            }
            else if (IsWorkflowResultEventOutputDataChatHistory)
            {
                workflowResultEventOutputDataChatHistory?.Invoke(WorkflowResultEventOutputDataChatHistory!);
            }
            else if (IsWorkflowResultEventOutputDataSearchResults)
            {
                workflowResultEventOutputDataSearchResults?.Invoke(WorkflowResultEventOutputDataSearchResults!);
            }
            else if (IsWorkflowResultEventOutputDataArray)
            {
                workflowResultEventOutputDataArray?.Invoke(WorkflowResultEventOutputDataArray!);
            }
            else if (IsWorkflowResultEventOutputDataFunctionCall)
            {
                workflowResultEventOutputDataFunctionCall?.Invoke(WorkflowResultEventOutputDataFunctionCall!);
            }
            else if (IsWorkflowResultEventOutputDataError)
            {
                workflowResultEventOutputDataError?.Invoke(WorkflowResultEventOutputDataError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WorkflowResultEventOutputDataString,
                typeof(global::Vellum.WorkflowResultEventOutputDataString),
                WorkflowResultEventOutputDataNumber,
                typeof(global::Vellum.WorkflowResultEventOutputDataNumber),
                WorkflowResultEventOutputDataJSON,
                typeof(global::Vellum.WorkflowResultEventOutputDataJSON),
                WorkflowResultEventOutputDataChatHistory,
                typeof(global::Vellum.WorkflowResultEventOutputDataChatHistory),
                WorkflowResultEventOutputDataSearchResults,
                typeof(global::Vellum.WorkflowResultEventOutputDataSearchResults),
                WorkflowResultEventOutputDataArray,
                typeof(global::Vellum.WorkflowResultEventOutputDataArray),
                WorkflowResultEventOutputDataFunctionCall,
                typeof(global::Vellum.WorkflowResultEventOutputDataFunctionCall),
                WorkflowResultEventOutputDataError,
                typeof(global::Vellum.WorkflowResultEventOutputDataError),
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
        public bool Equals(WorkflowResultEventOutputData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowResultEventOutputDataString?>.Default.Equals(WorkflowResultEventOutputDataString, other.WorkflowResultEventOutputDataString) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowResultEventOutputDataNumber?>.Default.Equals(WorkflowResultEventOutputDataNumber, other.WorkflowResultEventOutputDataNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowResultEventOutputDataJSON?>.Default.Equals(WorkflowResultEventOutputDataJSON, other.WorkflowResultEventOutputDataJSON) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowResultEventOutputDataChatHistory?>.Default.Equals(WorkflowResultEventOutputDataChatHistory, other.WorkflowResultEventOutputDataChatHistory) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowResultEventOutputDataSearchResults?>.Default.Equals(WorkflowResultEventOutputDataSearchResults, other.WorkflowResultEventOutputDataSearchResults) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowResultEventOutputDataArray?>.Default.Equals(WorkflowResultEventOutputDataArray, other.WorkflowResultEventOutputDataArray) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowResultEventOutputDataFunctionCall?>.Default.Equals(WorkflowResultEventOutputDataFunctionCall, other.WorkflowResultEventOutputDataFunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowResultEventOutputDataError?>.Default.Equals(WorkflowResultEventOutputDataError, other.WorkflowResultEventOutputDataError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WorkflowResultEventOutputData obj1, WorkflowResultEventOutputData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WorkflowResultEventOutputData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WorkflowResultEventOutputData obj1, WorkflowResultEventOutputData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WorkflowResultEventOutputData o && Equals(o);
        }
    }
}
