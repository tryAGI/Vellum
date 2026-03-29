#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WorkflowOutput : global::System.IEquatable<WorkflowOutput>
    {
        /// <summary>
        /// A string output from a Workflow execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowOutputString? WorkflowOutputString { get; init; }
#else
        public global::Vellum.WorkflowOutputString? WorkflowOutputString { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowOutputString))]
#endif
        public bool IsWorkflowOutputString => WorkflowOutputString != null;

        /// <summary>
        /// A number output from a Workflow execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowOutputNumber? WorkflowOutputNumber { get; init; }
#else
        public global::Vellum.WorkflowOutputNumber? WorkflowOutputNumber { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowOutputNumber))]
#endif
        public bool IsWorkflowOutputNumber => WorkflowOutputNumber != null;

        /// <summary>
        /// A JSON output from a Workflow execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowOutputJSON? WorkflowOutputJSON { get; init; }
#else
        public global::Vellum.WorkflowOutputJSON? WorkflowOutputJSON { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowOutputJSON))]
#endif
        public bool IsWorkflowOutputJSON => WorkflowOutputJSON != null;

        /// <summary>
        /// A chat history output from a Workflow execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowOutputChatHistory? WorkflowOutputChatHistory { get; init; }
#else
        public global::Vellum.WorkflowOutputChatHistory? WorkflowOutputChatHistory { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowOutputChatHistory))]
#endif
        public bool IsWorkflowOutputChatHistory => WorkflowOutputChatHistory != null;

        /// <summary>
        /// A search results output from a Workflow execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowOutputSearchResults? WorkflowOutputSearchResults { get; init; }
#else
        public global::Vellum.WorkflowOutputSearchResults? WorkflowOutputSearchResults { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowOutputSearchResults))]
#endif
        public bool IsWorkflowOutputSearchResults => WorkflowOutputSearchResults != null;

        /// <summary>
        /// An array output from a Workflow execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowOutputArray? WorkflowOutputArray { get; init; }
#else
        public global::Vellum.WorkflowOutputArray? WorkflowOutputArray { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowOutputArray))]
#endif
        public bool IsWorkflowOutputArray => WorkflowOutputArray != null;

        /// <summary>
        /// An error output from a Workflow execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowOutputError? WorkflowOutputError { get; init; }
#else
        public global::Vellum.WorkflowOutputError? WorkflowOutputError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowOutputError))]
#endif
        public bool IsWorkflowOutputError => WorkflowOutputError != null;

        /// <summary>
        /// A function call output from a Workflow execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowOutputFunctionCall? WorkflowOutputFunctionCall { get; init; }
#else
        public global::Vellum.WorkflowOutputFunctionCall? WorkflowOutputFunctionCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowOutputFunctionCall))]
#endif
        public bool IsWorkflowOutputFunctionCall => WorkflowOutputFunctionCall != null;

        /// <summary>
        /// An image output from a Workflow execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowOutputImage? WorkflowOutputImage { get; init; }
#else
        public global::Vellum.WorkflowOutputImage? WorkflowOutputImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowOutputImage))]
#endif
        public bool IsWorkflowOutputImage => WorkflowOutputImage != null;

        /// <summary>
        /// An audio output from a Workflow execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowOutputAudio? WorkflowOutputAudio { get; init; }
#else
        public global::Vellum.WorkflowOutputAudio? WorkflowOutputAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowOutputAudio))]
#endif
        public bool IsWorkflowOutputAudio => WorkflowOutputAudio != null;

        /// <summary>
        /// A video output from a Workflow execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowOutputVideo? WorkflowOutputVideo { get; init; }
#else
        public global::Vellum.WorkflowOutputVideo? WorkflowOutputVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowOutputVideo))]
#endif
        public bool IsWorkflowOutputVideo => WorkflowOutputVideo != null;

        /// <summary>
        /// A document output from a Workflow execution.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.WorkflowOutputDocument? WorkflowOutputDocument { get; init; }
#else
        public global::Vellum.WorkflowOutputDocument? WorkflowOutputDocument { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkflowOutputDocument))]
#endif
        public bool IsWorkflowOutputDocument => WorkflowOutputDocument != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowOutput(global::Vellum.WorkflowOutputString value) => new WorkflowOutput((global::Vellum.WorkflowOutputString?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowOutputString?(WorkflowOutput @this) => @this.WorkflowOutputString;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowOutput(global::Vellum.WorkflowOutputString? value)
        {
            WorkflowOutputString = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowOutput(global::Vellum.WorkflowOutputNumber value) => new WorkflowOutput((global::Vellum.WorkflowOutputNumber?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowOutputNumber?(WorkflowOutput @this) => @this.WorkflowOutputNumber;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowOutput(global::Vellum.WorkflowOutputNumber? value)
        {
            WorkflowOutputNumber = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowOutput(global::Vellum.WorkflowOutputJSON value) => new WorkflowOutput((global::Vellum.WorkflowOutputJSON?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowOutputJSON?(WorkflowOutput @this) => @this.WorkflowOutputJSON;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowOutput(global::Vellum.WorkflowOutputJSON? value)
        {
            WorkflowOutputJSON = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowOutput(global::Vellum.WorkflowOutputChatHistory value) => new WorkflowOutput((global::Vellum.WorkflowOutputChatHistory?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowOutputChatHistory?(WorkflowOutput @this) => @this.WorkflowOutputChatHistory;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowOutput(global::Vellum.WorkflowOutputChatHistory? value)
        {
            WorkflowOutputChatHistory = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowOutput(global::Vellum.WorkflowOutputSearchResults value) => new WorkflowOutput((global::Vellum.WorkflowOutputSearchResults?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowOutputSearchResults?(WorkflowOutput @this) => @this.WorkflowOutputSearchResults;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowOutput(global::Vellum.WorkflowOutputSearchResults? value)
        {
            WorkflowOutputSearchResults = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowOutput(global::Vellum.WorkflowOutputArray value) => new WorkflowOutput((global::Vellum.WorkflowOutputArray?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowOutputArray?(WorkflowOutput @this) => @this.WorkflowOutputArray;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowOutput(global::Vellum.WorkflowOutputArray? value)
        {
            WorkflowOutputArray = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowOutput(global::Vellum.WorkflowOutputError value) => new WorkflowOutput((global::Vellum.WorkflowOutputError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowOutputError?(WorkflowOutput @this) => @this.WorkflowOutputError;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowOutput(global::Vellum.WorkflowOutputError? value)
        {
            WorkflowOutputError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowOutput(global::Vellum.WorkflowOutputFunctionCall value) => new WorkflowOutput((global::Vellum.WorkflowOutputFunctionCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowOutputFunctionCall?(WorkflowOutput @this) => @this.WorkflowOutputFunctionCall;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowOutput(global::Vellum.WorkflowOutputFunctionCall? value)
        {
            WorkflowOutputFunctionCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowOutput(global::Vellum.WorkflowOutputImage value) => new WorkflowOutput((global::Vellum.WorkflowOutputImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowOutputImage?(WorkflowOutput @this) => @this.WorkflowOutputImage;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowOutput(global::Vellum.WorkflowOutputImage? value)
        {
            WorkflowOutputImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowOutput(global::Vellum.WorkflowOutputAudio value) => new WorkflowOutput((global::Vellum.WorkflowOutputAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowOutputAudio?(WorkflowOutput @this) => @this.WorkflowOutputAudio;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowOutput(global::Vellum.WorkflowOutputAudio? value)
        {
            WorkflowOutputAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowOutput(global::Vellum.WorkflowOutputVideo value) => new WorkflowOutput((global::Vellum.WorkflowOutputVideo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowOutputVideo?(WorkflowOutput @this) => @this.WorkflowOutputVideo;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowOutput(global::Vellum.WorkflowOutputVideo? value)
        {
            WorkflowOutputVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkflowOutput(global::Vellum.WorkflowOutputDocument value) => new WorkflowOutput((global::Vellum.WorkflowOutputDocument?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.WorkflowOutputDocument?(WorkflowOutput @this) => @this.WorkflowOutputDocument;

        /// <summary>
        /// 
        /// </summary>
        public WorkflowOutput(global::Vellum.WorkflowOutputDocument? value)
        {
            WorkflowOutputDocument = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public WorkflowOutput(
            global::Vellum.WorkflowOutputString? workflowOutputString,
            global::Vellum.WorkflowOutputNumber? workflowOutputNumber,
            global::Vellum.WorkflowOutputJSON? workflowOutputJSON,
            global::Vellum.WorkflowOutputChatHistory? workflowOutputChatHistory,
            global::Vellum.WorkflowOutputSearchResults? workflowOutputSearchResults,
            global::Vellum.WorkflowOutputArray? workflowOutputArray,
            global::Vellum.WorkflowOutputError? workflowOutputError,
            global::Vellum.WorkflowOutputFunctionCall? workflowOutputFunctionCall,
            global::Vellum.WorkflowOutputImage? workflowOutputImage,
            global::Vellum.WorkflowOutputAudio? workflowOutputAudio,
            global::Vellum.WorkflowOutputVideo? workflowOutputVideo,
            global::Vellum.WorkflowOutputDocument? workflowOutputDocument
            )
        {
            WorkflowOutputString = workflowOutputString;
            WorkflowOutputNumber = workflowOutputNumber;
            WorkflowOutputJSON = workflowOutputJSON;
            WorkflowOutputChatHistory = workflowOutputChatHistory;
            WorkflowOutputSearchResults = workflowOutputSearchResults;
            WorkflowOutputArray = workflowOutputArray;
            WorkflowOutputError = workflowOutputError;
            WorkflowOutputFunctionCall = workflowOutputFunctionCall;
            WorkflowOutputImage = workflowOutputImage;
            WorkflowOutputAudio = workflowOutputAudio;
            WorkflowOutputVideo = workflowOutputVideo;
            WorkflowOutputDocument = workflowOutputDocument;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WorkflowOutputDocument as object ??
            WorkflowOutputVideo as object ??
            WorkflowOutputAudio as object ??
            WorkflowOutputImage as object ??
            WorkflowOutputFunctionCall as object ??
            WorkflowOutputError as object ??
            WorkflowOutputArray as object ??
            WorkflowOutputSearchResults as object ??
            WorkflowOutputChatHistory as object ??
            WorkflowOutputJSON as object ??
            WorkflowOutputNumber as object ??
            WorkflowOutputString as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WorkflowOutputString?.ToString() ??
            WorkflowOutputNumber?.ToString() ??
            WorkflowOutputJSON?.ToString() ??
            WorkflowOutputChatHistory?.ToString() ??
            WorkflowOutputSearchResults?.ToString() ??
            WorkflowOutputArray?.ToString() ??
            WorkflowOutputError?.ToString() ??
            WorkflowOutputFunctionCall?.ToString() ??
            WorkflowOutputImage?.ToString() ??
            WorkflowOutputAudio?.ToString() ??
            WorkflowOutputVideo?.ToString() ??
            WorkflowOutputDocument?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWorkflowOutputString && !IsWorkflowOutputNumber && !IsWorkflowOutputJSON && !IsWorkflowOutputChatHistory && !IsWorkflowOutputSearchResults && !IsWorkflowOutputArray && !IsWorkflowOutputError && !IsWorkflowOutputFunctionCall && !IsWorkflowOutputImage && !IsWorkflowOutputAudio && !IsWorkflowOutputVideo && !IsWorkflowOutputDocument || !IsWorkflowOutputString && IsWorkflowOutputNumber && !IsWorkflowOutputJSON && !IsWorkflowOutputChatHistory && !IsWorkflowOutputSearchResults && !IsWorkflowOutputArray && !IsWorkflowOutputError && !IsWorkflowOutputFunctionCall && !IsWorkflowOutputImage && !IsWorkflowOutputAudio && !IsWorkflowOutputVideo && !IsWorkflowOutputDocument || !IsWorkflowOutputString && !IsWorkflowOutputNumber && IsWorkflowOutputJSON && !IsWorkflowOutputChatHistory && !IsWorkflowOutputSearchResults && !IsWorkflowOutputArray && !IsWorkflowOutputError && !IsWorkflowOutputFunctionCall && !IsWorkflowOutputImage && !IsWorkflowOutputAudio && !IsWorkflowOutputVideo && !IsWorkflowOutputDocument || !IsWorkflowOutputString && !IsWorkflowOutputNumber && !IsWorkflowOutputJSON && IsWorkflowOutputChatHistory && !IsWorkflowOutputSearchResults && !IsWorkflowOutputArray && !IsWorkflowOutputError && !IsWorkflowOutputFunctionCall && !IsWorkflowOutputImage && !IsWorkflowOutputAudio && !IsWorkflowOutputVideo && !IsWorkflowOutputDocument || !IsWorkflowOutputString && !IsWorkflowOutputNumber && !IsWorkflowOutputJSON && !IsWorkflowOutputChatHistory && IsWorkflowOutputSearchResults && !IsWorkflowOutputArray && !IsWorkflowOutputError && !IsWorkflowOutputFunctionCall && !IsWorkflowOutputImage && !IsWorkflowOutputAudio && !IsWorkflowOutputVideo && !IsWorkflowOutputDocument || !IsWorkflowOutputString && !IsWorkflowOutputNumber && !IsWorkflowOutputJSON && !IsWorkflowOutputChatHistory && !IsWorkflowOutputSearchResults && IsWorkflowOutputArray && !IsWorkflowOutputError && !IsWorkflowOutputFunctionCall && !IsWorkflowOutputImage && !IsWorkflowOutputAudio && !IsWorkflowOutputVideo && !IsWorkflowOutputDocument || !IsWorkflowOutputString && !IsWorkflowOutputNumber && !IsWorkflowOutputJSON && !IsWorkflowOutputChatHistory && !IsWorkflowOutputSearchResults && !IsWorkflowOutputArray && IsWorkflowOutputError && !IsWorkflowOutputFunctionCall && !IsWorkflowOutputImage && !IsWorkflowOutputAudio && !IsWorkflowOutputVideo && !IsWorkflowOutputDocument || !IsWorkflowOutputString && !IsWorkflowOutputNumber && !IsWorkflowOutputJSON && !IsWorkflowOutputChatHistory && !IsWorkflowOutputSearchResults && !IsWorkflowOutputArray && !IsWorkflowOutputError && IsWorkflowOutputFunctionCall && !IsWorkflowOutputImage && !IsWorkflowOutputAudio && !IsWorkflowOutputVideo && !IsWorkflowOutputDocument || !IsWorkflowOutputString && !IsWorkflowOutputNumber && !IsWorkflowOutputJSON && !IsWorkflowOutputChatHistory && !IsWorkflowOutputSearchResults && !IsWorkflowOutputArray && !IsWorkflowOutputError && !IsWorkflowOutputFunctionCall && IsWorkflowOutputImage && !IsWorkflowOutputAudio && !IsWorkflowOutputVideo && !IsWorkflowOutputDocument || !IsWorkflowOutputString && !IsWorkflowOutputNumber && !IsWorkflowOutputJSON && !IsWorkflowOutputChatHistory && !IsWorkflowOutputSearchResults && !IsWorkflowOutputArray && !IsWorkflowOutputError && !IsWorkflowOutputFunctionCall && !IsWorkflowOutputImage && IsWorkflowOutputAudio && !IsWorkflowOutputVideo && !IsWorkflowOutputDocument || !IsWorkflowOutputString && !IsWorkflowOutputNumber && !IsWorkflowOutputJSON && !IsWorkflowOutputChatHistory && !IsWorkflowOutputSearchResults && !IsWorkflowOutputArray && !IsWorkflowOutputError && !IsWorkflowOutputFunctionCall && !IsWorkflowOutputImage && !IsWorkflowOutputAudio && IsWorkflowOutputVideo && !IsWorkflowOutputDocument || !IsWorkflowOutputString && !IsWorkflowOutputNumber && !IsWorkflowOutputJSON && !IsWorkflowOutputChatHistory && !IsWorkflowOutputSearchResults && !IsWorkflowOutputArray && !IsWorkflowOutputError && !IsWorkflowOutputFunctionCall && !IsWorkflowOutputImage && !IsWorkflowOutputAudio && !IsWorkflowOutputVideo && IsWorkflowOutputDocument;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.WorkflowOutputString?, TResult>? workflowOutputString = null,
            global::System.Func<global::Vellum.WorkflowOutputNumber?, TResult>? workflowOutputNumber = null,
            global::System.Func<global::Vellum.WorkflowOutputJSON?, TResult>? workflowOutputJSON = null,
            global::System.Func<global::Vellum.WorkflowOutputChatHistory?, TResult>? workflowOutputChatHistory = null,
            global::System.Func<global::Vellum.WorkflowOutputSearchResults?, TResult>? workflowOutputSearchResults = null,
            global::System.Func<global::Vellum.WorkflowOutputArray?, TResult>? workflowOutputArray = null,
            global::System.Func<global::Vellum.WorkflowOutputError?, TResult>? workflowOutputError = null,
            global::System.Func<global::Vellum.WorkflowOutputFunctionCall?, TResult>? workflowOutputFunctionCall = null,
            global::System.Func<global::Vellum.WorkflowOutputImage?, TResult>? workflowOutputImage = null,
            global::System.Func<global::Vellum.WorkflowOutputAudio?, TResult>? workflowOutputAudio = null,
            global::System.Func<global::Vellum.WorkflowOutputVideo?, TResult>? workflowOutputVideo = null,
            global::System.Func<global::Vellum.WorkflowOutputDocument?, TResult>? workflowOutputDocument = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowOutputString && workflowOutputString != null)
            {
                return workflowOutputString(WorkflowOutputString!);
            }
            else if (IsWorkflowOutputNumber && workflowOutputNumber != null)
            {
                return workflowOutputNumber(WorkflowOutputNumber!);
            }
            else if (IsWorkflowOutputJSON && workflowOutputJSON != null)
            {
                return workflowOutputJSON(WorkflowOutputJSON!);
            }
            else if (IsWorkflowOutputChatHistory && workflowOutputChatHistory != null)
            {
                return workflowOutputChatHistory(WorkflowOutputChatHistory!);
            }
            else if (IsWorkflowOutputSearchResults && workflowOutputSearchResults != null)
            {
                return workflowOutputSearchResults(WorkflowOutputSearchResults!);
            }
            else if (IsWorkflowOutputArray && workflowOutputArray != null)
            {
                return workflowOutputArray(WorkflowOutputArray!);
            }
            else if (IsWorkflowOutputError && workflowOutputError != null)
            {
                return workflowOutputError(WorkflowOutputError!);
            }
            else if (IsWorkflowOutputFunctionCall && workflowOutputFunctionCall != null)
            {
                return workflowOutputFunctionCall(WorkflowOutputFunctionCall!);
            }
            else if (IsWorkflowOutputImage && workflowOutputImage != null)
            {
                return workflowOutputImage(WorkflowOutputImage!);
            }
            else if (IsWorkflowOutputAudio && workflowOutputAudio != null)
            {
                return workflowOutputAudio(WorkflowOutputAudio!);
            }
            else if (IsWorkflowOutputVideo && workflowOutputVideo != null)
            {
                return workflowOutputVideo(WorkflowOutputVideo!);
            }
            else if (IsWorkflowOutputDocument && workflowOutputDocument != null)
            {
                return workflowOutputDocument(WorkflowOutputDocument!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.WorkflowOutputString?>? workflowOutputString = null,
            global::System.Action<global::Vellum.WorkflowOutputNumber?>? workflowOutputNumber = null,
            global::System.Action<global::Vellum.WorkflowOutputJSON?>? workflowOutputJSON = null,
            global::System.Action<global::Vellum.WorkflowOutputChatHistory?>? workflowOutputChatHistory = null,
            global::System.Action<global::Vellum.WorkflowOutputSearchResults?>? workflowOutputSearchResults = null,
            global::System.Action<global::Vellum.WorkflowOutputArray?>? workflowOutputArray = null,
            global::System.Action<global::Vellum.WorkflowOutputError?>? workflowOutputError = null,
            global::System.Action<global::Vellum.WorkflowOutputFunctionCall?>? workflowOutputFunctionCall = null,
            global::System.Action<global::Vellum.WorkflowOutputImage?>? workflowOutputImage = null,
            global::System.Action<global::Vellum.WorkflowOutputAudio?>? workflowOutputAudio = null,
            global::System.Action<global::Vellum.WorkflowOutputVideo?>? workflowOutputVideo = null,
            global::System.Action<global::Vellum.WorkflowOutputDocument?>? workflowOutputDocument = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkflowOutputString)
            {
                workflowOutputString?.Invoke(WorkflowOutputString!);
            }
            else if (IsWorkflowOutputNumber)
            {
                workflowOutputNumber?.Invoke(WorkflowOutputNumber!);
            }
            else if (IsWorkflowOutputJSON)
            {
                workflowOutputJSON?.Invoke(WorkflowOutputJSON!);
            }
            else if (IsWorkflowOutputChatHistory)
            {
                workflowOutputChatHistory?.Invoke(WorkflowOutputChatHistory!);
            }
            else if (IsWorkflowOutputSearchResults)
            {
                workflowOutputSearchResults?.Invoke(WorkflowOutputSearchResults!);
            }
            else if (IsWorkflowOutputArray)
            {
                workflowOutputArray?.Invoke(WorkflowOutputArray!);
            }
            else if (IsWorkflowOutputError)
            {
                workflowOutputError?.Invoke(WorkflowOutputError!);
            }
            else if (IsWorkflowOutputFunctionCall)
            {
                workflowOutputFunctionCall?.Invoke(WorkflowOutputFunctionCall!);
            }
            else if (IsWorkflowOutputImage)
            {
                workflowOutputImage?.Invoke(WorkflowOutputImage!);
            }
            else if (IsWorkflowOutputAudio)
            {
                workflowOutputAudio?.Invoke(WorkflowOutputAudio!);
            }
            else if (IsWorkflowOutputVideo)
            {
                workflowOutputVideo?.Invoke(WorkflowOutputVideo!);
            }
            else if (IsWorkflowOutputDocument)
            {
                workflowOutputDocument?.Invoke(WorkflowOutputDocument!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WorkflowOutputString,
                typeof(global::Vellum.WorkflowOutputString),
                WorkflowOutputNumber,
                typeof(global::Vellum.WorkflowOutputNumber),
                WorkflowOutputJSON,
                typeof(global::Vellum.WorkflowOutputJSON),
                WorkflowOutputChatHistory,
                typeof(global::Vellum.WorkflowOutputChatHistory),
                WorkflowOutputSearchResults,
                typeof(global::Vellum.WorkflowOutputSearchResults),
                WorkflowOutputArray,
                typeof(global::Vellum.WorkflowOutputArray),
                WorkflowOutputError,
                typeof(global::Vellum.WorkflowOutputError),
                WorkflowOutputFunctionCall,
                typeof(global::Vellum.WorkflowOutputFunctionCall),
                WorkflowOutputImage,
                typeof(global::Vellum.WorkflowOutputImage),
                WorkflowOutputAudio,
                typeof(global::Vellum.WorkflowOutputAudio),
                WorkflowOutputVideo,
                typeof(global::Vellum.WorkflowOutputVideo),
                WorkflowOutputDocument,
                typeof(global::Vellum.WorkflowOutputDocument),
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
        public bool Equals(WorkflowOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowOutputString?>.Default.Equals(WorkflowOutputString, other.WorkflowOutputString) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowOutputNumber?>.Default.Equals(WorkflowOutputNumber, other.WorkflowOutputNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowOutputJSON?>.Default.Equals(WorkflowOutputJSON, other.WorkflowOutputJSON) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowOutputChatHistory?>.Default.Equals(WorkflowOutputChatHistory, other.WorkflowOutputChatHistory) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowOutputSearchResults?>.Default.Equals(WorkflowOutputSearchResults, other.WorkflowOutputSearchResults) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowOutputArray?>.Default.Equals(WorkflowOutputArray, other.WorkflowOutputArray) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowOutputError?>.Default.Equals(WorkflowOutputError, other.WorkflowOutputError) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowOutputFunctionCall?>.Default.Equals(WorkflowOutputFunctionCall, other.WorkflowOutputFunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowOutputImage?>.Default.Equals(WorkflowOutputImage, other.WorkflowOutputImage) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowOutputAudio?>.Default.Equals(WorkflowOutputAudio, other.WorkflowOutputAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowOutputVideo?>.Default.Equals(WorkflowOutputVideo, other.WorkflowOutputVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.WorkflowOutputDocument?>.Default.Equals(WorkflowOutputDocument, other.WorkflowOutputDocument) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WorkflowOutput obj1, WorkflowOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WorkflowOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WorkflowOutput obj1, WorkflowOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WorkflowOutput o && Equals(o);
        }
    }
}
