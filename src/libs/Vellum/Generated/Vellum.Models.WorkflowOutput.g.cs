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
        ///
        /// </summary>
        public bool TryPickWorkflowOutputString(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.WorkflowOutputString? value)
        {
            value = WorkflowOutputString;
            return IsWorkflowOutputString;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputString PickWorkflowOutputString() => WorkflowOutputString is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowOutputString' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickWorkflowOutputNumber(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.WorkflowOutputNumber? value)
        {
            value = WorkflowOutputNumber;
            return IsWorkflowOutputNumber;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputNumber PickWorkflowOutputNumber() => WorkflowOutputNumber is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowOutputNumber' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickWorkflowOutputJSON(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.WorkflowOutputJSON? value)
        {
            value = WorkflowOutputJSON;
            return IsWorkflowOutputJSON;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputJSON PickWorkflowOutputJSON() => WorkflowOutputJSON is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowOutputJSON' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickWorkflowOutputChatHistory(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.WorkflowOutputChatHistory? value)
        {
            value = WorkflowOutputChatHistory;
            return IsWorkflowOutputChatHistory;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputChatHistory PickWorkflowOutputChatHistory() => WorkflowOutputChatHistory is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowOutputChatHistory' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickWorkflowOutputSearchResults(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.WorkflowOutputSearchResults? value)
        {
            value = WorkflowOutputSearchResults;
            return IsWorkflowOutputSearchResults;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputSearchResults PickWorkflowOutputSearchResults() => WorkflowOutputSearchResults is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowOutputSearchResults' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickWorkflowOutputArray(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.WorkflowOutputArray? value)
        {
            value = WorkflowOutputArray;
            return IsWorkflowOutputArray;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputArray PickWorkflowOutputArray() => WorkflowOutputArray is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowOutputArray' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickWorkflowOutputError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.WorkflowOutputError? value)
        {
            value = WorkflowOutputError;
            return IsWorkflowOutputError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputError PickWorkflowOutputError() => WorkflowOutputError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowOutputError' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickWorkflowOutputFunctionCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.WorkflowOutputFunctionCall? value)
        {
            value = WorkflowOutputFunctionCall;
            return IsWorkflowOutputFunctionCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputFunctionCall PickWorkflowOutputFunctionCall() => WorkflowOutputFunctionCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowOutputFunctionCall' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickWorkflowOutputImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.WorkflowOutputImage? value)
        {
            value = WorkflowOutputImage;
            return IsWorkflowOutputImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputImage PickWorkflowOutputImage() => WorkflowOutputImage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowOutputImage' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickWorkflowOutputAudio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.WorkflowOutputAudio? value)
        {
            value = WorkflowOutputAudio;
            return IsWorkflowOutputAudio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputAudio PickWorkflowOutputAudio() => WorkflowOutputAudio is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowOutputAudio' but the value was {ToString()}.");

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
        ///
        /// </summary>
        public bool TryPickWorkflowOutputVideo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.WorkflowOutputVideo? value)
        {
            value = WorkflowOutputVideo;
            return IsWorkflowOutputVideo;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputVideo PickWorkflowOutputVideo() => WorkflowOutputVideo is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowOutputVideo' but the value was {ToString()}.");

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
        public bool TryPickWorkflowOutputDocument(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.WorkflowOutputDocument? value)
        {
            value = WorkflowOutputDocument;
            return IsWorkflowOutputDocument;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputDocument PickWorkflowOutputDocument() => WorkflowOutputDocument is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkflowOutputDocument' but the value was {ToString()}.");
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
        public static WorkflowOutput FromWorkflowOutputString(global::Vellum.WorkflowOutputString? value) => new WorkflowOutput(value);

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
        public static WorkflowOutput FromWorkflowOutputNumber(global::Vellum.WorkflowOutputNumber? value) => new WorkflowOutput(value);

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
        public static WorkflowOutput FromWorkflowOutputJSON(global::Vellum.WorkflowOutputJSON? value) => new WorkflowOutput(value);

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
        public static WorkflowOutput FromWorkflowOutputChatHistory(global::Vellum.WorkflowOutputChatHistory? value) => new WorkflowOutput(value);

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
        public static WorkflowOutput FromWorkflowOutputSearchResults(global::Vellum.WorkflowOutputSearchResults? value) => new WorkflowOutput(value);

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
        public static WorkflowOutput FromWorkflowOutputArray(global::Vellum.WorkflowOutputArray? value) => new WorkflowOutput(value);

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
        public static WorkflowOutput FromWorkflowOutputError(global::Vellum.WorkflowOutputError? value) => new WorkflowOutput(value);

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
        public static WorkflowOutput FromWorkflowOutputFunctionCall(global::Vellum.WorkflowOutputFunctionCall? value) => new WorkflowOutput(value);

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
        public static WorkflowOutput FromWorkflowOutputImage(global::Vellum.WorkflowOutputImage? value) => new WorkflowOutput(value);

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
        public static WorkflowOutput FromWorkflowOutputAudio(global::Vellum.WorkflowOutputAudio? value) => new WorkflowOutput(value);

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
        public static WorkflowOutput FromWorkflowOutputVideo(global::Vellum.WorkflowOutputVideo? value) => new WorkflowOutput(value);

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
        public static WorkflowOutput FromWorkflowOutputDocument(global::Vellum.WorkflowOutputDocument? value) => new WorkflowOutput(value);

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
            global::System.Func<global::Vellum.WorkflowOutputString, TResult>? workflowOutputString = null,
            global::System.Func<global::Vellum.WorkflowOutputNumber, TResult>? workflowOutputNumber = null,
            global::System.Func<global::Vellum.WorkflowOutputJSON, TResult>? workflowOutputJSON = null,
            global::System.Func<global::Vellum.WorkflowOutputChatHistory, TResult>? workflowOutputChatHistory = null,
            global::System.Func<global::Vellum.WorkflowOutputSearchResults, TResult>? workflowOutputSearchResults = null,
            global::System.Func<global::Vellum.WorkflowOutputArray, TResult>? workflowOutputArray = null,
            global::System.Func<global::Vellum.WorkflowOutputError, TResult>? workflowOutputError = null,
            global::System.Func<global::Vellum.WorkflowOutputFunctionCall, TResult>? workflowOutputFunctionCall = null,
            global::System.Func<global::Vellum.WorkflowOutputImage, TResult>? workflowOutputImage = null,
            global::System.Func<global::Vellum.WorkflowOutputAudio, TResult>? workflowOutputAudio = null,
            global::System.Func<global::Vellum.WorkflowOutputVideo, TResult>? workflowOutputVideo = null,
            global::System.Func<global::Vellum.WorkflowOutputDocument, TResult>? workflowOutputDocument = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (WorkflowOutputString is { } __value0 && workflowOutputString != null)
            {
                return workflowOutputString(__value0);
            }
            else if (WorkflowOutputNumber is { } __value1 && workflowOutputNumber != null)
            {
                return workflowOutputNumber(__value1);
            }
            else if (WorkflowOutputJSON is { } __value2 && workflowOutputJSON != null)
            {
                return workflowOutputJSON(__value2);
            }
            else if (WorkflowOutputChatHistory is { } __value3 && workflowOutputChatHistory != null)
            {
                return workflowOutputChatHistory(__value3);
            }
            else if (WorkflowOutputSearchResults is { } __value4 && workflowOutputSearchResults != null)
            {
                return workflowOutputSearchResults(__value4);
            }
            else if (WorkflowOutputArray is { } __value5 && workflowOutputArray != null)
            {
                return workflowOutputArray(__value5);
            }
            else if (WorkflowOutputError is { } __value6 && workflowOutputError != null)
            {
                return workflowOutputError(__value6);
            }
            else if (WorkflowOutputFunctionCall is { } __value7 && workflowOutputFunctionCall != null)
            {
                return workflowOutputFunctionCall(__value7);
            }
            else if (WorkflowOutputImage is { } __value8 && workflowOutputImage != null)
            {
                return workflowOutputImage(__value8);
            }
            else if (WorkflowOutputAudio is { } __value9 && workflowOutputAudio != null)
            {
                return workflowOutputAudio(__value9);
            }
            else if (WorkflowOutputVideo is { } __value10 && workflowOutputVideo != null)
            {
                return workflowOutputVideo(__value10);
            }
            else if (WorkflowOutputDocument is { } __value11 && workflowOutputDocument != null)
            {
                return workflowOutputDocument(__value11);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.WorkflowOutputString>? workflowOutputString = null,

            global::System.Action<global::Vellum.WorkflowOutputNumber>? workflowOutputNumber = null,

            global::System.Action<global::Vellum.WorkflowOutputJSON>? workflowOutputJSON = null,

            global::System.Action<global::Vellum.WorkflowOutputChatHistory>? workflowOutputChatHistory = null,

            global::System.Action<global::Vellum.WorkflowOutputSearchResults>? workflowOutputSearchResults = null,

            global::System.Action<global::Vellum.WorkflowOutputArray>? workflowOutputArray = null,

            global::System.Action<global::Vellum.WorkflowOutputError>? workflowOutputError = null,

            global::System.Action<global::Vellum.WorkflowOutputFunctionCall>? workflowOutputFunctionCall = null,

            global::System.Action<global::Vellum.WorkflowOutputImage>? workflowOutputImage = null,

            global::System.Action<global::Vellum.WorkflowOutputAudio>? workflowOutputAudio = null,

            global::System.Action<global::Vellum.WorkflowOutputVideo>? workflowOutputVideo = null,

            global::System.Action<global::Vellum.WorkflowOutputDocument>? workflowOutputDocument = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (WorkflowOutputString is { } __value0)
            {
                workflowOutputString?.Invoke(__value0);
            }
            else if (WorkflowOutputNumber is { } __value1)
            {
                workflowOutputNumber?.Invoke(__value1);
            }
            else if (WorkflowOutputJSON is { } __value2)
            {
                workflowOutputJSON?.Invoke(__value2);
            }
            else if (WorkflowOutputChatHistory is { } __value3)
            {
                workflowOutputChatHistory?.Invoke(__value3);
            }
            else if (WorkflowOutputSearchResults is { } __value4)
            {
                workflowOutputSearchResults?.Invoke(__value4);
            }
            else if (WorkflowOutputArray is { } __value5)
            {
                workflowOutputArray?.Invoke(__value5);
            }
            else if (WorkflowOutputError is { } __value6)
            {
                workflowOutputError?.Invoke(__value6);
            }
            else if (WorkflowOutputFunctionCall is { } __value7)
            {
                workflowOutputFunctionCall?.Invoke(__value7);
            }
            else if (WorkflowOutputImage is { } __value8)
            {
                workflowOutputImage?.Invoke(__value8);
            }
            else if (WorkflowOutputAudio is { } __value9)
            {
                workflowOutputAudio?.Invoke(__value9);
            }
            else if (WorkflowOutputVideo is { } __value10)
            {
                workflowOutputVideo?.Invoke(__value10);
            }
            else if (WorkflowOutputDocument is { } __value11)
            {
                workflowOutputDocument?.Invoke(__value11);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vellum.WorkflowOutputString>? workflowOutputString = null,
            global::System.Action<global::Vellum.WorkflowOutputNumber>? workflowOutputNumber = null,
            global::System.Action<global::Vellum.WorkflowOutputJSON>? workflowOutputJSON = null,
            global::System.Action<global::Vellum.WorkflowOutputChatHistory>? workflowOutputChatHistory = null,
            global::System.Action<global::Vellum.WorkflowOutputSearchResults>? workflowOutputSearchResults = null,
            global::System.Action<global::Vellum.WorkflowOutputArray>? workflowOutputArray = null,
            global::System.Action<global::Vellum.WorkflowOutputError>? workflowOutputError = null,
            global::System.Action<global::Vellum.WorkflowOutputFunctionCall>? workflowOutputFunctionCall = null,
            global::System.Action<global::Vellum.WorkflowOutputImage>? workflowOutputImage = null,
            global::System.Action<global::Vellum.WorkflowOutputAudio>? workflowOutputAudio = null,
            global::System.Action<global::Vellum.WorkflowOutputVideo>? workflowOutputVideo = null,
            global::System.Action<global::Vellum.WorkflowOutputDocument>? workflowOutputDocument = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (WorkflowOutputString is { } __value0)
            {
                workflowOutputString?.Invoke(__value0);
            }
            else if (WorkflowOutputNumber is { } __value1)
            {
                workflowOutputNumber?.Invoke(__value1);
            }
            else if (WorkflowOutputJSON is { } __value2)
            {
                workflowOutputJSON?.Invoke(__value2);
            }
            else if (WorkflowOutputChatHistory is { } __value3)
            {
                workflowOutputChatHistory?.Invoke(__value3);
            }
            else if (WorkflowOutputSearchResults is { } __value4)
            {
                workflowOutputSearchResults?.Invoke(__value4);
            }
            else if (WorkflowOutputArray is { } __value5)
            {
                workflowOutputArray?.Invoke(__value5);
            }
            else if (WorkflowOutputError is { } __value6)
            {
                workflowOutputError?.Invoke(__value6);
            }
            else if (WorkflowOutputFunctionCall is { } __value7)
            {
                workflowOutputFunctionCall?.Invoke(__value7);
            }
            else if (WorkflowOutputImage is { } __value8)
            {
                workflowOutputImage?.Invoke(__value8);
            }
            else if (WorkflowOutputAudio is { } __value9)
            {
                workflowOutputAudio?.Invoke(__value9);
            }
            else if (WorkflowOutputVideo is { } __value10)
            {
                workflowOutputVideo?.Invoke(__value10);
            }
            else if (WorkflowOutputDocument is { } __value11)
            {
                workflowOutputDocument?.Invoke(__value11);
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
