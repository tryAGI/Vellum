
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Vellum
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.StringEnum), TypeInfoPropertyName = "StringEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.JsonEnum), TypeInfoPropertyName = "JsonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ChatHistoryEnum), TypeInfoPropertyName = "ChatHistoryEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ChatMessageRole), TypeInfoPropertyName = "ChatMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FunctionCallEnum), TypeInfoPropertyName = "FunctionCallEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ArrayEnum), TypeInfoPropertyName = "ArrayEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.AudioEnum), TypeInfoPropertyName = "AudioEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VideoEnum), TypeInfoPropertyName = "VideoEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ImageEnum), TypeInfoPropertyName = "ImageEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentEnum), TypeInfoPropertyName = "DocumentEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MLModelUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.UnitEnum), TypeInfoPropertyName = "UnitEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.Price))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.StringVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.JsonVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ErrorEnum), TypeInfoPropertyName = "ErrorEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumErrorCodeEnum), TypeInfoPropertyName = "VellumErrorCodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ErrorVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FunctionCallVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ThinkingEnum), TypeInfoPropertyName = "ThinkingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ThinkingVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NumberEnum), TypeInfoPropertyName = "NumberEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NumberVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.AudioVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VideoVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ImageVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ArrayVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.VellumValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumValue), TypeInfoPropertyName = "VellumValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.StringChatMessageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FunctionCallChatMessageContentValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FunctionCallChatMessageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.AudioChatMessageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VideoChatMessageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ImageChatMessageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentChatMessageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ArrayChatMessageContentItem), TypeInfoPropertyName = "ArrayChatMessageContentItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ArrayChatMessageContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.ArrayChatMessageContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ChatMessageContent), TypeInfoPropertyName = "ChatMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ChatHistoryVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultsEnum), TypeInfoPropertyName = "SearchResultsEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PdfEnum), TypeInfoPropertyName = "PdfEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PdfSearchResultMetaSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultMetaSource), TypeInfoPropertyName = "SearchResultMetaSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultsVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.SearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowEventErrorRawData), TypeInfoPropertyName = "WorkflowEventErrorRawData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionEventErrorCode), TypeInfoPropertyName = "WorkflowExecutionEventErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowEventError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowEnum), TypeInfoPropertyName = "WorkflowEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutionStringVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutionNumberVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutionJsonVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutionChatHistoryVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutionSearchResultsVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutionErrorVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutionArrayVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutionFunctionCallVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutionThinkingVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutionAudioVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutionVideoVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutionImageVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutionDocumentVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutionVellumValue), TypeInfoPropertyName = "ExecutionVellumValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.ExecutionVellumValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SpanLinkTypeEnum), TypeInfoPropertyName = "SpanLinkTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SpanLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ParentContext), TypeInfoPropertyName = "ParentContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumCodeResourceDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowParentContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.SpanLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowNodeEnum), TypeInfoPropertyName = "WorkflowNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeParentContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowReleaseTagEnum), TypeInfoPropertyName = "WorkflowReleaseTagEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowDeploymentParentContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowSandboxEnum), TypeInfoPropertyName = "WorkflowSandboxEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowSandboxParentContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptReleaseTagEnum), TypeInfoPropertyName = "PromptReleaseTagEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptDeploymentParentContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ApiRequestEnum), TypeInfoPropertyName = "ApiRequestEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ApiActorTypeEnum), TypeInfoPropertyName = "ApiActorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.APIRequestParentContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExternalEnum), TypeInfoPropertyName = "ExternalEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExternalParentContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ScheduledEnum), TypeInfoPropertyName = "ScheduledEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ScheduledTriggerContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.IntegrationEnum), TypeInfoPropertyName = "IntegrationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.IntegrationTriggerContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionInitiatedEnum), TypeInfoPropertyName = "NodeExecutionInitiatedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionInitiatedBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ApiVersionEnum), TypeInfoPropertyName = "ApiVersionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionInitiatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionStreamingEnum), TypeInfoPropertyName = "NodeExecutionStreamingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.BaseOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionStreamingBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionStreamingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionFulfilledEnum), TypeInfoPropertyName = "NodeExecutionFulfilledEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.InvokedPort))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionFulfilledBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.InvokedPort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionFulfilledEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionRejectedEnum), TypeInfoPropertyName = "NodeExecutionRejectedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumSdkErrorRawData), TypeInfoPropertyName = "VellumSdkErrorRawData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumSdkErrorCodeEnum), TypeInfoPropertyName = "VellumSdkErrorCodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumSdkError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionRejectedBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionRejectedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionPausedEnum), TypeInfoPropertyName = "NodeExecutionPausedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionPausedBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionPausedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionResumedEnum), TypeInfoPropertyName = "NodeExecutionResumedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionResumedBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionResumedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionLogEnum), TypeInfoPropertyName = "NodeExecutionLogEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SeverityEnum), TypeInfoPropertyName = "SeverityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionLogBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionLogEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionInitiatedEnum), TypeInfoPropertyName = "WorkflowExecutionInitiatedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionInitiatedBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionInitiatedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionStreamingEnum), TypeInfoPropertyName = "WorkflowExecutionStreamingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionStreamingBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionStreamingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionRejectedEnum), TypeInfoPropertyName = "WorkflowExecutionRejectedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionRejectedBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionRejectedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionFulfilledEnum), TypeInfoPropertyName = "WorkflowExecutionFulfilledEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionFulfilledBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionFulfilledEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionPausedEnum), TypeInfoPropertyName = "WorkflowExecutionPausedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CodeResourceDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExternalInputDescriptor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.CodeResourceDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionPausedBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.ExternalInputDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionPausedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionResumedEnum), TypeInfoPropertyName = "WorkflowExecutionResumedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionResumedBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionResumedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionSnapshottedEnum), TypeInfoPropertyName = "WorkflowExecutionSnapshottedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionSnapshottedBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionSnapshottedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowInitializationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowError), TypeInfoPropertyName = "WorkflowError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MLModelUsageWrapper))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionUsageCalculationErrorCodeEnum), TypeInfoPropertyName = "WorkflowExecutionUsageCalculationErrorCodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionUsageCalculationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionUsageResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.MLModelUsageWrapper>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.Price>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.WorkflowExecutionUsageResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionEnum), TypeInfoPropertyName = "WorkflowExecutionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumWorkflowExecutionEvent), TypeInfoPropertyName = "VellumWorkflowExecutionEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionSpanAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionUsageCalculationFulfilledBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.VellumWorkflowExecutionEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionEnum), TypeInfoPropertyName = "NodeExecutionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumNodeExecutionEvent), TypeInfoPropertyName = "VellumNodeExecutionEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionSpanAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.VellumNodeExecutionEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumSpan), TypeInfoPropertyName = "VellumSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.VellumSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ErrorDetailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.UpdateActiveWorkspaceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.StringEnum?), TypeInfoPropertyName = "NullableStringEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.JsonEnum?), TypeInfoPropertyName = "NullableJsonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ChatHistoryEnum?), TypeInfoPropertyName = "NullableChatHistoryEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ChatMessageRole?), TypeInfoPropertyName = "NullableChatMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FunctionCallEnum?), TypeInfoPropertyName = "NullableFunctionCallEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ArrayEnum?), TypeInfoPropertyName = "NullableArrayEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.AudioEnum?), TypeInfoPropertyName = "NullableAudioEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VideoEnum?), TypeInfoPropertyName = "NullableVideoEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ImageEnum?), TypeInfoPropertyName = "NullableImageEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentEnum?), TypeInfoPropertyName = "NullableDocumentEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.UnitEnum?), TypeInfoPropertyName = "NullableUnitEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ErrorEnum?), TypeInfoPropertyName = "NullableErrorEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumErrorCodeEnum?), TypeInfoPropertyName = "NullableVellumErrorCodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ThinkingEnum?), TypeInfoPropertyName = "NullableThinkingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NumberEnum?), TypeInfoPropertyName = "NullableNumberEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumValue?), TypeInfoPropertyName = "NullableVellumValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ArrayChatMessageContentItem?), TypeInfoPropertyName = "NullableArrayChatMessageContentItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ChatMessageContent?), TypeInfoPropertyName = "NullableChatMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultsEnum?), TypeInfoPropertyName = "NullableSearchResultsEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PdfEnum?), TypeInfoPropertyName = "NullablePdfEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultMetaSource?), TypeInfoPropertyName = "NullableSearchResultMetaSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowEventErrorRawData?), TypeInfoPropertyName = "NullableWorkflowEventErrorRawData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionEventErrorCode?), TypeInfoPropertyName = "NullableWorkflowExecutionEventErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowEnum?), TypeInfoPropertyName = "NullableWorkflowEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutionVellumValue?), TypeInfoPropertyName = "NullableExecutionVellumValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SpanLinkTypeEnum?), TypeInfoPropertyName = "NullableSpanLinkTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ParentContext?), TypeInfoPropertyName = "NullableParentContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowNodeEnum?), TypeInfoPropertyName = "NullableWorkflowNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowReleaseTagEnum?), TypeInfoPropertyName = "NullableWorkflowReleaseTagEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowSandboxEnum?), TypeInfoPropertyName = "NullableWorkflowSandboxEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptReleaseTagEnum?), TypeInfoPropertyName = "NullablePromptReleaseTagEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ApiRequestEnum?), TypeInfoPropertyName = "NullableApiRequestEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ApiActorTypeEnum?), TypeInfoPropertyName = "NullableApiActorTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExternalEnum?), TypeInfoPropertyName = "NullableExternalEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ScheduledEnum?), TypeInfoPropertyName = "NullableScheduledEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.IntegrationEnum?), TypeInfoPropertyName = "NullableIntegrationEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionInitiatedEnum?), TypeInfoPropertyName = "NullableNodeExecutionInitiatedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ApiVersionEnum?), TypeInfoPropertyName = "NullableApiVersionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionStreamingEnum?), TypeInfoPropertyName = "NullableNodeExecutionStreamingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionFulfilledEnum?), TypeInfoPropertyName = "NullableNodeExecutionFulfilledEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionRejectedEnum?), TypeInfoPropertyName = "NullableNodeExecutionRejectedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumSdkErrorRawData?), TypeInfoPropertyName = "NullableVellumSdkErrorRawData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumSdkErrorCodeEnum?), TypeInfoPropertyName = "NullableVellumSdkErrorCodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionPausedEnum?), TypeInfoPropertyName = "NullableNodeExecutionPausedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionResumedEnum?), TypeInfoPropertyName = "NullableNodeExecutionResumedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionLogEnum?), TypeInfoPropertyName = "NullableNodeExecutionLogEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SeverityEnum?), TypeInfoPropertyName = "NullableSeverityEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionInitiatedEnum?), TypeInfoPropertyName = "NullableWorkflowExecutionInitiatedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionStreamingEnum?), TypeInfoPropertyName = "NullableWorkflowExecutionStreamingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionRejectedEnum?), TypeInfoPropertyName = "NullableWorkflowExecutionRejectedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionFulfilledEnum?), TypeInfoPropertyName = "NullableWorkflowExecutionFulfilledEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionPausedEnum?), TypeInfoPropertyName = "NullableWorkflowExecutionPausedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionResumedEnum?), TypeInfoPropertyName = "NullableWorkflowExecutionResumedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionSnapshottedEnum?), TypeInfoPropertyName = "NullableWorkflowExecutionSnapshottedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowError?), TypeInfoPropertyName = "NullableWorkflowError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionUsageCalculationErrorCodeEnum?), TypeInfoPropertyName = "NullableWorkflowExecutionUsageCalculationErrorCodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionEnum?), TypeInfoPropertyName = "NullableWorkflowExecutionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumWorkflowExecutionEvent?), TypeInfoPropertyName = "NullableVellumWorkflowExecutionEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionEnum?), TypeInfoPropertyName = "NullableNodeExecutionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumNodeExecutionEvent?), TypeInfoPropertyName = "NullableVellumNodeExecutionEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumSpan?), TypeInfoPropertyName = "NullableVellumSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.VellumValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ArrayChatMessageContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.SearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ExecutionVellumValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.SpanLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.InvokedPort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.CodeResourceDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ExternalInputDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.MLModelUsageWrapper>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.Price>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.WorkflowExecutionUsageResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.VellumWorkflowExecutionEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.VellumNodeExecutionEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.VellumSpan>))]
    internal sealed partial class WorkflowExecutionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkflowExecutionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static WorkflowExecutionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private WorkflowExecutionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Vellum.JsonConverters.ArrayChatMessageContentItemJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.ChatMessageContentJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.SearchResultMetaSourceJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.VellumValueJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.WorkflowEventErrorRawDataJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.ExecutionVellumValueJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.ParentContextJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.VellumSdkErrorRawDataJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.WorkflowErrorJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.VellumWorkflowExecutionEventJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.VellumNodeExecutionEventJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.VellumSpanJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Vellum.StringEnum)

                    || typeToConvert == typeof(global::Vellum.StringEnum?)

                    || typeToConvert == typeof(global::Vellum.JsonEnum)

                    || typeToConvert == typeof(global::Vellum.JsonEnum?)

                    || typeToConvert == typeof(global::Vellum.ChatHistoryEnum)

                    || typeToConvert == typeof(global::Vellum.ChatHistoryEnum?)

                    || typeToConvert == typeof(global::Vellum.ChatMessageRole)

                    || typeToConvert == typeof(global::Vellum.ChatMessageRole?)

                    || typeToConvert == typeof(global::Vellum.FunctionCallEnum)

                    || typeToConvert == typeof(global::Vellum.FunctionCallEnum?)

                    || typeToConvert == typeof(global::Vellum.ArrayEnum)

                    || typeToConvert == typeof(global::Vellum.ArrayEnum?)

                    || typeToConvert == typeof(global::Vellum.AudioEnum)

                    || typeToConvert == typeof(global::Vellum.AudioEnum?)

                    || typeToConvert == typeof(global::Vellum.VideoEnum)

                    || typeToConvert == typeof(global::Vellum.VideoEnum?)

                    || typeToConvert == typeof(global::Vellum.ImageEnum)

                    || typeToConvert == typeof(global::Vellum.ImageEnum?)

                    || typeToConvert == typeof(global::Vellum.DocumentEnum)

                    || typeToConvert == typeof(global::Vellum.DocumentEnum?)

                    || typeToConvert == typeof(global::Vellum.UnitEnum)

                    || typeToConvert == typeof(global::Vellum.UnitEnum?)

                    || typeToConvert == typeof(global::Vellum.ErrorEnum)

                    || typeToConvert == typeof(global::Vellum.ErrorEnum?)

                    || typeToConvert == typeof(global::Vellum.VellumErrorCodeEnum)

                    || typeToConvert == typeof(global::Vellum.VellumErrorCodeEnum?)

                    || typeToConvert == typeof(global::Vellum.ThinkingEnum)

                    || typeToConvert == typeof(global::Vellum.ThinkingEnum?)

                    || typeToConvert == typeof(global::Vellum.NumberEnum)

                    || typeToConvert == typeof(global::Vellum.NumberEnum?)

                    || typeToConvert == typeof(global::Vellum.SearchResultsEnum)

                    || typeToConvert == typeof(global::Vellum.SearchResultsEnum?)

                    || typeToConvert == typeof(global::Vellum.PdfEnum)

                    || typeToConvert == typeof(global::Vellum.PdfEnum?)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionEventErrorCode)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionEventErrorCode?)

                    || typeToConvert == typeof(global::Vellum.WorkflowEnum)

                    || typeToConvert == typeof(global::Vellum.WorkflowEnum?)

                    || typeToConvert == typeof(global::Vellum.SpanLinkTypeEnum)

                    || typeToConvert == typeof(global::Vellum.SpanLinkTypeEnum?)

                    || typeToConvert == typeof(global::Vellum.WorkflowNodeEnum)

                    || typeToConvert == typeof(global::Vellum.WorkflowNodeEnum?)

                    || typeToConvert == typeof(global::Vellum.WorkflowReleaseTagEnum)

                    || typeToConvert == typeof(global::Vellum.WorkflowReleaseTagEnum?)

                    || typeToConvert == typeof(global::Vellum.WorkflowSandboxEnum)

                    || typeToConvert == typeof(global::Vellum.WorkflowSandboxEnum?)

                    || typeToConvert == typeof(global::Vellum.PromptReleaseTagEnum)

                    || typeToConvert == typeof(global::Vellum.PromptReleaseTagEnum?)

                    || typeToConvert == typeof(global::Vellum.ApiRequestEnum)

                    || typeToConvert == typeof(global::Vellum.ApiRequestEnum?)

                    || typeToConvert == typeof(global::Vellum.ApiActorTypeEnum)

                    || typeToConvert == typeof(global::Vellum.ApiActorTypeEnum?)

                    || typeToConvert == typeof(global::Vellum.ExternalEnum)

                    || typeToConvert == typeof(global::Vellum.ExternalEnum?)

                    || typeToConvert == typeof(global::Vellum.ScheduledEnum)

                    || typeToConvert == typeof(global::Vellum.ScheduledEnum?)

                    || typeToConvert == typeof(global::Vellum.IntegrationEnum)

                    || typeToConvert == typeof(global::Vellum.IntegrationEnum?)

                    || typeToConvert == typeof(global::Vellum.NodeExecutionInitiatedEnum)

                    || typeToConvert == typeof(global::Vellum.NodeExecutionInitiatedEnum?)

                    || typeToConvert == typeof(global::Vellum.ApiVersionEnum)

                    || typeToConvert == typeof(global::Vellum.ApiVersionEnum?)

                    || typeToConvert == typeof(global::Vellum.NodeExecutionStreamingEnum)

                    || typeToConvert == typeof(global::Vellum.NodeExecutionStreamingEnum?)

                    || typeToConvert == typeof(global::Vellum.NodeExecutionFulfilledEnum)

                    || typeToConvert == typeof(global::Vellum.NodeExecutionFulfilledEnum?)

                    || typeToConvert == typeof(global::Vellum.NodeExecutionRejectedEnum)

                    || typeToConvert == typeof(global::Vellum.NodeExecutionRejectedEnum?)

                    || typeToConvert == typeof(global::Vellum.VellumSdkErrorCodeEnum)

                    || typeToConvert == typeof(global::Vellum.VellumSdkErrorCodeEnum?)

                    || typeToConvert == typeof(global::Vellum.NodeExecutionPausedEnum)

                    || typeToConvert == typeof(global::Vellum.NodeExecutionPausedEnum?)

                    || typeToConvert == typeof(global::Vellum.NodeExecutionResumedEnum)

                    || typeToConvert == typeof(global::Vellum.NodeExecutionResumedEnum?)

                    || typeToConvert == typeof(global::Vellum.NodeExecutionLogEnum)

                    || typeToConvert == typeof(global::Vellum.NodeExecutionLogEnum?)

                    || typeToConvert == typeof(global::Vellum.SeverityEnum)

                    || typeToConvert == typeof(global::Vellum.SeverityEnum?)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionInitiatedEnum)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionInitiatedEnum?)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionStreamingEnum)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionStreamingEnum?)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionRejectedEnum)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionRejectedEnum?)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionFulfilledEnum)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionFulfilledEnum?)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionPausedEnum)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionPausedEnum?)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionResumedEnum)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionResumedEnum?)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionSnapshottedEnum)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionSnapshottedEnum?)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionUsageCalculationErrorCodeEnum)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionUsageCalculationErrorCodeEnum?)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionEnum)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionEnum?)

                    || typeToConvert == typeof(global::Vellum.NodeExecutionEnum)

                    || typeToConvert == typeof(global::Vellum.NodeExecutionEnum?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vellum.StringEnum))
                {
                    return new global::Vellum.JsonConverters.StringEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.StringEnum?))
                {
                    return new global::Vellum.JsonConverters.StringEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.JsonEnum))
                {
                    return new global::Vellum.JsonConverters.JsonEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.JsonEnum?))
                {
                    return new global::Vellum.JsonConverters.JsonEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ChatHistoryEnum))
                {
                    return new global::Vellum.JsonConverters.ChatHistoryEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ChatHistoryEnum?))
                {
                    return new global::Vellum.JsonConverters.ChatHistoryEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ChatMessageRole))
                {
                    return new global::Vellum.JsonConverters.ChatMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ChatMessageRole?))
                {
                    return new global::Vellum.JsonConverters.ChatMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.FunctionCallEnum))
                {
                    return new global::Vellum.JsonConverters.FunctionCallEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.FunctionCallEnum?))
                {
                    return new global::Vellum.JsonConverters.FunctionCallEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ArrayEnum))
                {
                    return new global::Vellum.JsonConverters.ArrayEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ArrayEnum?))
                {
                    return new global::Vellum.JsonConverters.ArrayEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.AudioEnum))
                {
                    return new global::Vellum.JsonConverters.AudioEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.AudioEnum?))
                {
                    return new global::Vellum.JsonConverters.AudioEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.VideoEnum))
                {
                    return new global::Vellum.JsonConverters.VideoEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.VideoEnum?))
                {
                    return new global::Vellum.JsonConverters.VideoEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ImageEnum))
                {
                    return new global::Vellum.JsonConverters.ImageEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ImageEnum?))
                {
                    return new global::Vellum.JsonConverters.ImageEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DocumentEnum))
                {
                    return new global::Vellum.JsonConverters.DocumentEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DocumentEnum?))
                {
                    return new global::Vellum.JsonConverters.DocumentEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.UnitEnum))
                {
                    return new global::Vellum.JsonConverters.UnitEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.UnitEnum?))
                {
                    return new global::Vellum.JsonConverters.UnitEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ErrorEnum))
                {
                    return new global::Vellum.JsonConverters.ErrorEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ErrorEnum?))
                {
                    return new global::Vellum.JsonConverters.ErrorEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.VellumErrorCodeEnum))
                {
                    return new global::Vellum.JsonConverters.VellumErrorCodeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.VellumErrorCodeEnum?))
                {
                    return new global::Vellum.JsonConverters.VellumErrorCodeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ThinkingEnum))
                {
                    return new global::Vellum.JsonConverters.ThinkingEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ThinkingEnum?))
                {
                    return new global::Vellum.JsonConverters.ThinkingEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.NumberEnum))
                {
                    return new global::Vellum.JsonConverters.NumberEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.NumberEnum?))
                {
                    return new global::Vellum.JsonConverters.NumberEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SearchResultsEnum))
                {
                    return new global::Vellum.JsonConverters.SearchResultsEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SearchResultsEnum?))
                {
                    return new global::Vellum.JsonConverters.SearchResultsEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.PdfEnum))
                {
                    return new global::Vellum.JsonConverters.PdfEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.PdfEnum?))
                {
                    return new global::Vellum.JsonConverters.PdfEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionEventErrorCode))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionEventErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionEventErrorCode?))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionEventErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowEnum))
                {
                    return new global::Vellum.JsonConverters.WorkflowEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowEnum?))
                {
                    return new global::Vellum.JsonConverters.WorkflowEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SpanLinkTypeEnum))
                {
                    return new global::Vellum.JsonConverters.SpanLinkTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SpanLinkTypeEnum?))
                {
                    return new global::Vellum.JsonConverters.SpanLinkTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowNodeEnum))
                {
                    return new global::Vellum.JsonConverters.WorkflowNodeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowNodeEnum?))
                {
                    return new global::Vellum.JsonConverters.WorkflowNodeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowReleaseTagEnum))
                {
                    return new global::Vellum.JsonConverters.WorkflowReleaseTagEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowReleaseTagEnum?))
                {
                    return new global::Vellum.JsonConverters.WorkflowReleaseTagEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowSandboxEnum))
                {
                    return new global::Vellum.JsonConverters.WorkflowSandboxEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowSandboxEnum?))
                {
                    return new global::Vellum.JsonConverters.WorkflowSandboxEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.PromptReleaseTagEnum))
                {
                    return new global::Vellum.JsonConverters.PromptReleaseTagEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.PromptReleaseTagEnum?))
                {
                    return new global::Vellum.JsonConverters.PromptReleaseTagEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ApiRequestEnum))
                {
                    return new global::Vellum.JsonConverters.ApiRequestEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ApiRequestEnum?))
                {
                    return new global::Vellum.JsonConverters.ApiRequestEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ApiActorTypeEnum))
                {
                    return new global::Vellum.JsonConverters.ApiActorTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ApiActorTypeEnum?))
                {
                    return new global::Vellum.JsonConverters.ApiActorTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ExternalEnum))
                {
                    return new global::Vellum.JsonConverters.ExternalEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ExternalEnum?))
                {
                    return new global::Vellum.JsonConverters.ExternalEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ScheduledEnum))
                {
                    return new global::Vellum.JsonConverters.ScheduledEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ScheduledEnum?))
                {
                    return new global::Vellum.JsonConverters.ScheduledEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.IntegrationEnum))
                {
                    return new global::Vellum.JsonConverters.IntegrationEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.IntegrationEnum?))
                {
                    return new global::Vellum.JsonConverters.IntegrationEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.NodeExecutionInitiatedEnum))
                {
                    return new global::Vellum.JsonConverters.NodeExecutionInitiatedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.NodeExecutionInitiatedEnum?))
                {
                    return new global::Vellum.JsonConverters.NodeExecutionInitiatedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ApiVersionEnum))
                {
                    return new global::Vellum.JsonConverters.ApiVersionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ApiVersionEnum?))
                {
                    return new global::Vellum.JsonConverters.ApiVersionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.NodeExecutionStreamingEnum))
                {
                    return new global::Vellum.JsonConverters.NodeExecutionStreamingEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.NodeExecutionStreamingEnum?))
                {
                    return new global::Vellum.JsonConverters.NodeExecutionStreamingEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.NodeExecutionFulfilledEnum))
                {
                    return new global::Vellum.JsonConverters.NodeExecutionFulfilledEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.NodeExecutionFulfilledEnum?))
                {
                    return new global::Vellum.JsonConverters.NodeExecutionFulfilledEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.NodeExecutionRejectedEnum))
                {
                    return new global::Vellum.JsonConverters.NodeExecutionRejectedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.NodeExecutionRejectedEnum?))
                {
                    return new global::Vellum.JsonConverters.NodeExecutionRejectedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.VellumSdkErrorCodeEnum))
                {
                    return new global::Vellum.JsonConverters.VellumSdkErrorCodeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.VellumSdkErrorCodeEnum?))
                {
                    return new global::Vellum.JsonConverters.VellumSdkErrorCodeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.NodeExecutionPausedEnum))
                {
                    return new global::Vellum.JsonConverters.NodeExecutionPausedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.NodeExecutionPausedEnum?))
                {
                    return new global::Vellum.JsonConverters.NodeExecutionPausedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.NodeExecutionResumedEnum))
                {
                    return new global::Vellum.JsonConverters.NodeExecutionResumedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.NodeExecutionResumedEnum?))
                {
                    return new global::Vellum.JsonConverters.NodeExecutionResumedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.NodeExecutionLogEnum))
                {
                    return new global::Vellum.JsonConverters.NodeExecutionLogEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.NodeExecutionLogEnum?))
                {
                    return new global::Vellum.JsonConverters.NodeExecutionLogEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SeverityEnum))
                {
                    return new global::Vellum.JsonConverters.SeverityEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SeverityEnum?))
                {
                    return new global::Vellum.JsonConverters.SeverityEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionInitiatedEnum))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionInitiatedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionInitiatedEnum?))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionInitiatedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionStreamingEnum))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionStreamingEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionStreamingEnum?))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionStreamingEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionRejectedEnum))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionRejectedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionRejectedEnum?))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionRejectedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionFulfilledEnum))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionFulfilledEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionFulfilledEnum?))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionFulfilledEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionPausedEnum))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionPausedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionPausedEnum?))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionPausedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionResumedEnum))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionResumedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionResumedEnum?))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionResumedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionSnapshottedEnum))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionSnapshottedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionSnapshottedEnum?))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionSnapshottedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionUsageCalculationErrorCodeEnum))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionUsageCalculationErrorCodeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionUsageCalculationErrorCodeEnum?))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionUsageCalculationErrorCodeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionEnum))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionEnum?))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.NodeExecutionEnum))
                {
                    return new global::Vellum.JsonConverters.NodeExecutionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.NodeExecutionEnum?))
                {
                    return new global::Vellum.JsonConverters.NodeExecutionEnumNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new WorkflowExecutionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}