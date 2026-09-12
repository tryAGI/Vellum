
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.StringInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.JsonEnum), TypeInfoPropertyName = "JsonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.JSONInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ChatHistoryEnum), TypeInfoPropertyName = "ChatHistoryEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ChatMessageRole), TypeInfoPropertyName = "ChatMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.StringChatMessageContentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FunctionCallEnum), TypeInfoPropertyName = "FunctionCallEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FunctionCallChatMessageContentValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FunctionCallChatMessageContentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ArrayEnum), TypeInfoPropertyName = "ArrayEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.AudioEnum), TypeInfoPropertyName = "AudioEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumAudioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.AudioChatMessageContentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VideoEnum), TypeInfoPropertyName = "VideoEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumVideoRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VideoChatMessageContentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ImageEnum), TypeInfoPropertyName = "ImageEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ImageChatMessageContentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentEnum), TypeInfoPropertyName = "DocumentEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentChatMessageContentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ArrayChatMessageContentItemRequest), TypeInfoPropertyName = "ArrayChatMessageContentItemRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ArrayChatMessageContentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.ArrayChatMessageContentItemRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ChatMessageContentRequest), TypeInfoPropertyName = "ChatMessageContentRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ChatMessageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ChatHistoryInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.ChatMessageRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.AudioInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VideoInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ImageInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptDeploymentInputRequest), TypeInfoPropertyName = "PromptDeploymentInputRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptDeploymentExpandMetaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.RawPromptExecutionOverridesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutePromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.PromptDeploymentInputRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FinishReasonEnum), TypeInfoPropertyName = "FinishReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MLModelUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.UnitEnum), TypeInfoPropertyName = "UnitEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.Price))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptExecutionMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FulfilledEnum), TypeInfoPropertyName = "FulfilledEnum2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptOutput), TypeInfoPropertyName = "PromptOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FulfilledExecutePromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.PromptOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.RejectedEnum), TypeInfoPropertyName = "RejectedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.RejectedExecutePromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutePromptResponse), TypeInfoPropertyName = "ExecutePromptResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutePromptApiErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutePromptStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.InitiatedEnum), TypeInfoPropertyName = "InitiatedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.InitiatedPromptExecutionMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.InitiatedExecutePromptEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.StreamingEnum), TypeInfoPropertyName = "StreamingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.StreamingPromptExecutionMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.StreamingExecutePromptEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FulfilledPromptExecutionMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FulfilledExecutePromptEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.RejectedPromptExecutionMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.RejectedExecutePromptEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutePromptEvent), TypeInfoPropertyName = "ExecutePromptEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SubmitCompletionActualRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SubmitCompletionActualsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.SubmitCompletionActualRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SubmitCompletionActualsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SubmitCompletionActualsErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CompilePromptDeploymentExpandMetaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeploymentProviderPayloadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeploymentProviderPayloadResponsePayload), TypeInfoPropertyName = "DeploymentProviderPayloadResponsePayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CompilePromptMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeploymentProviderPayloadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeploySandboxPromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.EntityStatus), TypeInfoPropertyName = "EntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.EnvironmentEnum), TypeInfoPropertyName = "EnvironmentEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumVariableType), TypeInfoPropertyName = "VellumVariableType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumVariableExtensions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeploymentRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.VellumVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedScenarioInputStringVariableValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedScenarioInputJsonVariableValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedScenarioInputAudioVariableValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedScenarioInputVideoVariableValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedScenarioInputImageVariableValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedScenarioInputDocumentVariableValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedScenarioInputRequest), TypeInfoPropertyName = "NamedScenarioInputRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.UpsertSandboxScenarioRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.NamedScenarioInputRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ScenarioInputStringVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ScenarioInputJsonVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ScenarioInputChatHistoryVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ScenarioInputAudioVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ScenarioInputVideoVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ScenarioInputImageVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ScenarioInputDocumentVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ScenarioInput), TypeInfoPropertyName = "ScenarioInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SandboxScenario))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.ScenarioInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SandboxesDeleteSandboxScenarioResponse204))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.V1DeploymentsGetParametersStatus), TypeInfoPropertyName = "V1DeploymentsGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SlimDeploymentRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PaginatedSlimDeploymentReadList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.SlimDeploymentRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReleaseEnvironment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReleaseCreatedBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SandboxEnum), TypeInfoPropertyName = "SandboxEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptVersionBuildConfigSandbox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptVersionBuildConfig), TypeInfoPropertyName = "PromptVersionBuildConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptDeploymentReleasePromptVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptDeploymentReleasePromptDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReleaseTagSource), TypeInfoPropertyName = "ReleaseTagSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReleaseReleaseTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReleaseReviewReviewer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReleaseReviewState), TypeInfoPropertyName = "ReleaseReviewState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SlimReleaseReview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptDeploymentRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.ReleaseReleaseTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.SlimReleaseReview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeploymentReleaseTagDeploymentHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReleaseTagRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeploymentReleaseTagRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.V1DeploymentsIdReleaseTagsGetParametersSource), TypeInfoPropertyName = "V1DeploymentsIdReleaseTagsGetParametersSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PaginatedDeploymentReleaseTagReadList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.DeploymentReleaseTagRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PatchedDeploymentReleaseTagUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeploymentHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowRequestStringInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowRequestJSONInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowRequestChatHistoryInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowRequestNumberInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowRequestAudioInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowRequestVideoInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowRequestImageInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowRequestDocumentInputRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowRequestInputRequest), TypeInfoPropertyName = "WorkflowRequestInputRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExpandMetaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecuteWorkflowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.WorkflowRequestInputRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowOutputString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowOutputNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowOutputJSON))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowOutputChatHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowOutputSearchResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowOutputArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowOutputError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowOutputFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowOutputImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowOutputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowOutputVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowOutputDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowOutput), TypeInfoPropertyName = "WorkflowOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FulfilledExecuteWorkflowWorkflowResultEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.WorkflowOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowEventErrorRawData), TypeInfoPropertyName = "WorkflowEventErrorRawData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionEventErrorCode), TypeInfoPropertyName = "WorkflowExecutionEventErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowEventError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.RejectedExecuteWorkflowWorkflowResultEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecuteWorkflowWorkflowResultEvent), TypeInfoPropertyName = "ExecuteWorkflowWorkflowResultEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecuteWorkflowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecuteWorkflowErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecuteWorkflowAsyncRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecuteWorkflowAsyncResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecuteWorkflowStreamErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionEventType), TypeInfoPropertyName = "WorkflowExecutionEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecuteWorkflowStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.WorkflowExecutionEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowEnum), TypeInfoPropertyName = "WorkflowEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowResultEventState), TypeInfoPropertyName = "WorkflowResultEventState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowNodeResultEventState), TypeInfoPropertyName = "WorkflowNodeResultEventState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowResultEventOutputDataString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowResultEventOutputDataNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowResultEventOutputDataJSON))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowResultEventOutputDataChatHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowResultEventOutputDataSearchResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowResultEventOutputDataArray))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowResultEventOutputDataFunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowResultEventOutputDataError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowResultEventOutputData), TypeInfoPropertyName = "WorkflowResultEventOutputData2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowResultEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.ExecutionVellumValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionWorkflowResultEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeEnum), TypeInfoPropertyName = "NodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptEnum), TypeInfoPropertyName = "PromptEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptNodeExecutionMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptNodeResultData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptNodeResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchEnum), TypeInfoPropertyName = "SearchEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchNodeResultData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchNodeResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TemplatingEnum), TypeInfoPropertyName = "TemplatingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TemplatingNodeStringResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TemplatingNodeNumberResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TemplatingNodeJsonResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TemplatingNodeChatHistoryResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TemplatingNodeSearchResultsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TemplatingNodeErrorResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TemplatingNodeArrayResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TemplatingNodeFunctionCallResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TemplatingNodeResultOutput), TypeInfoPropertyName = "TemplatingNodeResultOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TemplatingNodeResultData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TemplatingNodeResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CodeExecutionEnum), TypeInfoPropertyName = "CodeExecutionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CodeExecutionNodeStringResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CodeExecutionNodeNumberResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CodeExecutionNodeJsonResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CodeExecutionNodeChatHistoryResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CodeExecutionNodeSearchResultsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CodeExecutionNodeErrorResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CodeExecutionNodeArrayResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CodeExecutionNodeFunctionCallResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CodeExecutionNodeResultOutput), TypeInfoPropertyName = "CodeExecutionNodeResultOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CodeExecutionNodeResultData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CodeExecutionNodeResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ConditionalEnum), TypeInfoPropertyName = "ConditionalEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ConditionalNodeResultData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ConditionalNodeResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ApiEnum), TypeInfoPropertyName = "ApiEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ApiNodeResultData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ApiNodeResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TerminalEnum), TypeInfoPropertyName = "TerminalEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TerminalNodeStringResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TerminalNodeNumberResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TerminalNodeJsonResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TerminalNodeChatHistoryResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TerminalNodeSearchResultsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TerminalNodeErrorResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TerminalNodeArrayResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TerminalNodeFunctionCallResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TerminalNodeResultOutput), TypeInfoPropertyName = "TerminalNodeResultOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TerminalNodeResultData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TerminalNodeResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MergeEnum), TypeInfoPropertyName = "MergeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MergeNodeResultData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MergeNodeResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SubworkflowEnum), TypeInfoPropertyName = "SubworkflowEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SubworkflowNodeResultData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SubworkflowNodeResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MetricEnum), TypeInfoPropertyName = "MetricEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MetricNodeResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MapEnum), TypeInfoPropertyName = "MapEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.IterationStateEnum), TypeInfoPropertyName = "IterationStateEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MapNodeResultData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MapNodeResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowNodeResultData), TypeInfoPropertyName = "WorkflowNodeResultData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeInputCompiledStringValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeInputCompiledNumberValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeInputCompiledJsonValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeInputCompiledChatHistoryValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeInputCompiledSearchResultsValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeInputCompiledErrorValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeInputCompiledArrayValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeInputCompiledFunctionCallValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SecretEnum), TypeInfoPropertyName = "SecretEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumSecret))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeInputCompiledSecretValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeInputCompiledAudioValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeInputCompiledVideoValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeInputCompiledImageValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeInputCompiledDocumentValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeInputVariableCompiledValue), TypeInfoPropertyName = "NodeInputVariableCompiledValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.InitiatedWorkflowNodeResultEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.NodeInputVariableCompiledValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeOutputCompiledStringValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeOutputCompiledNumberValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeOutputCompiledJsonValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeOutputCompiledChatHistoryValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeOutputCompiledSearchResultsValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeOutputCompiledErrorValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeOutputCompiledArrayValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeOutputCompiledFunctionCallValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeOutputCompiledThinkingValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeOutputCompiledValue), TypeInfoPropertyName = "NodeOutputCompiledValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.StreamingWorkflowNodeResultEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FulfilledWorkflowNodeResultEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.NodeOutputCompiledValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.RejectedWorkflowNodeResultEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowNodeResultEvent), TypeInfoPropertyName = "WorkflowNodeResultEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionNodeResultEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowStreamEvent), TypeInfoPropertyName = "WorkflowStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CheckWorkflowExecutionStatusError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CheckWorkflowExecutionStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CheckWorkflowExecutionStatusErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionActualStringRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionActualJsonRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionActualChatHistoryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SubmitWorkflowExecutionActualRequest), TypeInfoPropertyName = "SubmitWorkflowExecutionActualRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SubmitWorkflowExecutionActualsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.SubmitWorkflowExecutionActualRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SubmitWorkflowExecutionActualsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeploySandboxWorkflowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowDisplayIcon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowDeploymentDisplayData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowDeploymentRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecuteWorkflowDeploymentStreamRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowEvent), TypeInfoPropertyName = "WorkflowEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.V1WorkflowDeploymentsGetParametersStatus), TypeInfoPropertyName = "V1WorkflowDeploymentsGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SlimWorkflowDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PaginatedSlimWorkflowDeploymentList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.SlimWorkflowDeployment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.IntegrationName), TypeInfoPropertyName = "IntegrationName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowIntegrationDependency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ModelProviderEnum), TypeInfoPropertyName = "ModelProviderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MLModelHostingInterface), TypeInfoPropertyName = "MLModelHostingInterface2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowModelProviderDependency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowDependency), TypeInfoPropertyName = "WorkflowDependency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowDeploymentReleaseWorkflowVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.WorkflowDependency>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowDeploymentReleaseWorkflowDeployment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowDeploymentRelease))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PaginatedWorkflowDeploymentReleaseList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.WorkflowDeploymentRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowReleaseTagWorkflowDeploymentHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowReleaseTagRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.V1WorkflowDeploymentsIdReleaseTagsGetParametersSource), TypeInfoPropertyName = "V1WorkflowDeploymentsIdReleaseTagsGetParametersSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PaginatedWorkflowReleaseTagReadList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.WorkflowReleaseTagRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PatchedWorkflowReleaseTagUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowDeploymentHistoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowInitializationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowError), TypeInfoPropertyName = "WorkflowError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MLModelUsageWrapper))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionUsageCalculationErrorCodeEnum), TypeInfoPropertyName = "WorkflowExecutionUsageCalculationErrorCodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionUsageCalculationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionUsageResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.MLModelUsageWrapper>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.Price>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionActual))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionViewOnlineEvalMetricResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SlimWorkflowExecutionRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.WorkflowExecutionUsageResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.WorkflowExecutionViewOnlineEvalMetricResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowDeploymentEventExecutionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.SlimWorkflowExecutionRead>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowEventExecutionRead))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.VellumSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ErrorDetailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.UpdateActiveWorkspaceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.WorkflowEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CreateWorkflowEventRequest), TypeInfoPropertyName = "CreateWorkflowEventRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.EventCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchWeightsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultMergingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MetadataFilterRuleCombinator), TypeInfoPropertyName = "MetadataFilterRuleCombinator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.LogicalOperator), TypeInfoPropertyName = "LogicalOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MetadataFilterRuleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.MetadataFilterRuleRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MetadataFilterConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.LogicalConditionEnum), TypeInfoPropertyName = "LogicalConditionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.StringVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NumberVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.JsonVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.AudioVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VideoVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ImageVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FunctionCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FunctionCallVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumErrorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ErrorVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ArrayVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.VellumValueRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumValueRequest), TypeInfoPropertyName = "VellumValueRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ChatHistoryVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PdfSearchResultMetaSourceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultMetaSourceRequest), TypeInfoPropertyName = "SearchResultMetaSourceRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultMetaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultsVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.SearchResultRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ThinkingVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumValueLogicalConditionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.LogicalConditionGroupEnum), TypeInfoPropertyName = "LogicalConditionGroupEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ConditionCombinator), TypeInfoPropertyName = "ConditionCombinator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumValueLogicalConditionGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.VellumValueLogicalExpressionRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumValueLogicalExpressionRequest), TypeInfoPropertyName = "VellumValueLogicalExpressionRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MetadataFiltersRequest), TypeInfoPropertyName = "MetadataFiltersRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchFiltersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchRequestOptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchRequestBodyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentIndexesAddDocumentResponse204))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OpenAIVectorizerConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TextEmbedding3SmallEnum), TypeInfoPropertyName = "TextEmbedding3SmallEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TextEmbedding3LargeEnum), TypeInfoPropertyName = "TextEmbedding3LargeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TextEmbeddingAda002Enum), TypeInfoPropertyName = "TextEmbeddingAda002Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.IntfloatMultilingualE5LargeEnum), TypeInfoPropertyName = "IntfloatMultilingualE5LargeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseCosV1Enum), TypeInfoPropertyName = "SentenceTransformersMultiQaMpnetBaseCosV1Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseDotV1Enum), TypeInfoPropertyName = "SentenceTransformersMultiQaMpnetBaseDotV1Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.HkunlpInstructorXlEnum), TypeInfoPropertyName = "HkunlpInstructorXlEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.InstructorVectorizerConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.HkunlpInstructorXlVectorizerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TextEmbedding004Enum), TypeInfoPropertyName = "TextEmbedding004Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.GoogleVertexAIVectorizerConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TextMultilingualEmbedding002Enum), TypeInfoPropertyName = "TextMultilingualEmbedding002Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.GeminiEmbedding001Enum), TypeInfoPropertyName = "GeminiEmbedding001Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.BaaiBgeSmallEnV15Enum), TypeInfoPropertyName = "BaaiBgeSmallEnV15Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PrivateVectorizerEnum), TypeInfoPropertyName = "PrivateVectorizerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PrivateVectorizerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.IndexingConfigVectorizerRequest), TypeInfoPropertyName = "IndexingConfigVectorizerRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReductoChunkerEnum), TypeInfoPropertyName = "ReductoChunkerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReductoChunkerConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReductoChunkingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SentenceChunkerEnum), TypeInfoPropertyName = "SentenceChunkerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SentenceChunkerConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SentenceChunkingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TokenOverlappingWindowChunkerEnum), TypeInfoPropertyName = "TokenOverlappingWindowChunkerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TokenOverlappingWindowChunkerConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TokenOverlappingWindowChunkingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DelimiterChunkerEnum), TypeInfoPropertyName = "DelimiterChunkerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DelimiterChunkerConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DelimiterChunkingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentIndexChunkingRequest), TypeInfoPropertyName = "DocumentIndexChunkingRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentIndexIndexingConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentIndexCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OpenAIVectorizerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OpenAIVectorizerTextEmbedding3Small))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OpenAIVectorizerTextEmbedding3Large))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OpenAIVectorizerTextEmbeddingAda002))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.BasicVectorizerIntfloatMultilingualE5Large))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.InstructorVectorizerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.HkunlpInstructorXlVectorizer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.GoogleVertexAIVectorizerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PrivateVectorizer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.IndexingConfigVectorizer), TypeInfoPropertyName = "IndexingConfigVectorizer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReductoChunkerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReductoChunking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SentenceChunkerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SentenceChunking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TokenOverlappingWindowChunkerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TokenOverlappingWindowChunking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DelimiterChunkerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DelimiterChunking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentIndexChunking), TypeInfoPropertyName = "DocumentIndexChunking2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentIndexIndexingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentIndexRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.V1DocumentIndexesGetParametersStatus), TypeInfoPropertyName = "V1DocumentIndexesGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PaginatedDocumentIndexReadList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.DocumentIndexRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PatchedDocumentIndexUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentIndexUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentIndexesDestroyResponse204))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentIndexesRemoveDocumentResponse204))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.UploadDocumentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.UploadDocumentErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentProcessingState), TypeInfoPropertyName = "DocumentProcessingState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentStatus), TypeInfoPropertyName = "DocumentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.IndexingStateEnum), TypeInfoPropertyName = "IndexingStateEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentDocumentToDocumentIndex))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.DocumentDocumentToDocumentIndex>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ProcessingFailureReasonEnum), TypeInfoPropertyName = "ProcessingFailureReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SlimDocumentDocumentToDocumentIndex))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SlimDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.SlimDocumentDocumentToDocumentIndex>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PaginatedSlimDocumentList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.SlimDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentsDestroyResponse204))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.UploadedFileRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestCaseStringVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestCaseNumberVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestCaseJsonVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestCaseChatHistoryVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestCaseSearchResultsVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestCaseErrorVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestCaseFunctionCallVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestCaseArrayVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestCaseAudioVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestCaseImageVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestCaseVideoVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestCaseDocumentVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestCaseVariableValue), TypeInfoPropertyName = "TestCaseVariableValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteTestCase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.TestCaseVariableValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PaginatedTestSuiteTestCaseList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.TestSuiteTestCase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseStringVariableValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseNumberVariableValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseJsonVariableValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseChatHistoryVariableValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseSearchResultsVariableValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseErrorVariableValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseFunctionCallVariableValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseArrayVariableValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseAudioVariableValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseVideoVariableValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseImageVariableValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseDocumentVariableValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseVariableValueRequest), TypeInfoPropertyName = "NamedTestCaseVariableValueRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.UpsertTestSuiteTestCaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.NamedTestCaseVariableValueRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CreateEnum), TypeInfoPropertyName = "CreateEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CreateTestSuiteTestCaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReplaceEnum), TypeInfoPropertyName = "ReplaceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReplaceTestSuiteTestCaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.UpsertEnum), TypeInfoPropertyName = "UpsertEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeleteEnum), TypeInfoPropertyName = "DeleteEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteTestCaseDeleteBulkOperationDataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteTestCaseBulkOperationRequest), TypeInfoPropertyName = "TestSuiteTestCaseBulkOperationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CreatedEnum), TypeInfoPropertyName = "CreatedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteTestCaseCreatedBulkResultData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteTestCaseCreatedBulkResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReplacedEnum), TypeInfoPropertyName = "ReplacedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteTestCaseReplacedBulkResultData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteTestCaseReplacedBulkResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeletedEnum), TypeInfoPropertyName = "DeletedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteTestCaseDeletedBulkResultData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteTestCaseDeletedBulkResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteTestCaseRejectedBulkResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteTestCaseBulkResult), TypeInfoPropertyName = "TestSuiteTestCaseBulkResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuitesDeleteTestSuiteTestCaseResponse204))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigTypeEnum), TypeInfoPropertyName = "TestSuiteRunDeploymentReleaseTagExecConfigTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigDataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunPromptSandboxExecConfigTypeEnum), TypeInfoPropertyName = "TestSuiteRunPromptSandboxExecConfigTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunPromptSandboxExecConfigDataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigTypeEnum), TypeInfoPropertyName = "TestSuiteRunPromptSandboxHistoryItemExecConfigTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigDataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigTypeEnum), TypeInfoPropertyName = "TestSuiteRunWorkflowReleaseTagExecConfigTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigDataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunWorkflowSandboxExecConfigTypeEnum), TypeInfoPropertyName = "TestSuiteRunWorkflowSandboxExecConfigTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunWorkflowSandboxExecConfigDataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnum), TypeInfoPropertyName = "TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigDataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExternalTestCaseExecutionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExternalExecConfigDataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.ExternalTestCaseExecutionRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExternalExecConfigTypeEnum), TypeInfoPropertyName = "TestSuiteRunExternalExecConfigTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExternalExecConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExecConfigRequest), TypeInfoPropertyName = "TestSuiteRunExecConfigRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunTestSuite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunState), TypeInfoPropertyName = "TestSuiteRunState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseStringVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseNumberVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseJsonVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseChatHistoryVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseSearchResultsVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseErrorVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseFunctionCallVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseArrayVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseAudioVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseVideoVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseImageVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseDocumentVariableValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseVariableValue), TypeInfoPropertyName = "NamedTestCaseVariableValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExternalTestCaseExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.NamedTestCaseVariableValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExternalExecConfigData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.ExternalTestCaseExecution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExternalExecConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExecConfig), TypeInfoPropertyName = "TestSuiteRunExecConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunProgress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExecutionStringOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExecutionNumberOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExecutionJsonOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExecutionChatHistoryOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExecutionSearchResultsOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExecutionErrorOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExecutionFunctionCallOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExecutionArrayOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExecutionOutput), TypeInfoPropertyName = "TestSuiteRunExecutionOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricStringOutputTypeEnum), TypeInfoPropertyName = "TestSuiteRunMetricStringOutputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricStringOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricNumberOutputTypeEnum), TypeInfoPropertyName = "TestSuiteRunMetricNumberOutputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricNumberOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricJSONOutputTypeEnum), TypeInfoPropertyName = "TestSuiteRunMetricJSONOutputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricJSONOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricErrorOutputTypeEnum), TypeInfoPropertyName = "TestSuiteRunMetricErrorOutputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricErrorOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricArrayOutputTypeEnum), TypeInfoPropertyName = "TestSuiteRunMetricArrayOutputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricArrayOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricOutput), TypeInfoPropertyName = "TestSuiteRunMetricOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExecutionMetricDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExecutionMetricResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.TestSuiteRunMetricOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExecution))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.TestSuiteRunExecutionOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.TestSuiteRunExecutionMetricResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PaginatedTestSuiteRunExecutionList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.TestSuiteRunExecution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.AddEntityToFolderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntitiesAddEntityToFolderResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.V1FolderEntitiesGetParametersEntityStatus), TypeInfoPropertyName = "V1FolderEntitiesGetParametersEntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEnum), TypeInfoPropertyName = "FolderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityFolderData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityFolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptSandboxEnum), TypeInfoPropertyName = "PromptSandboxEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityPromptSandboxData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityPromptSandbox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowSandboxDisplayData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityWorkflowSandboxData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityWorkflowSandbox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentIndexEnum), TypeInfoPropertyName = "DocumentIndexEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityDocumentIndexData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityDocumentIndex))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteEnum), TypeInfoPropertyName = "TestSuiteEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityTestSuiteData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityTestSuite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DatasetEnum), TypeInfoPropertyName = "DatasetEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityDatasetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntity), TypeInfoPropertyName = "FolderEntity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PaginatedFolderEntityList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.FolderEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SecretTypeEnum), TypeInfoPropertyName = "SecretTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkspaceSecretRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PatchedWorkspaceSecretUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.UploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PartialUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.TestSuiteTestCaseBulkOperationRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.TestSuiteTestCaseBulkResult>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ArrayChatMessageContentItemRequest?), TypeInfoPropertyName = "NullableArrayChatMessageContentItemRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ChatMessageContentRequest?), TypeInfoPropertyName = "NullableChatMessageContentRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptDeploymentInputRequest?), TypeInfoPropertyName = "NullablePromptDeploymentInputRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FinishReasonEnum?), TypeInfoPropertyName = "NullableFinishReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.UnitEnum?), TypeInfoPropertyName = "NullableUnitEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FulfilledEnum?), TypeInfoPropertyName = "NullableFulfilledEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ErrorEnum?), TypeInfoPropertyName = "NullableErrorEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumErrorCodeEnum?), TypeInfoPropertyName = "NullableVellumErrorCodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ThinkingEnum?), TypeInfoPropertyName = "NullableThinkingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptOutput?), TypeInfoPropertyName = "NullablePromptOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.RejectedEnum?), TypeInfoPropertyName = "NullableRejectedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutePromptResponse?), TypeInfoPropertyName = "NullableExecutePromptResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.InitiatedEnum?), TypeInfoPropertyName = "NullableInitiatedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.StreamingEnum?), TypeInfoPropertyName = "NullableStreamingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutePromptEvent?), TypeInfoPropertyName = "NullableExecutePromptEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeploymentProviderPayloadResponsePayload?), TypeInfoPropertyName = "NullableDeploymentProviderPayloadResponsePayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.EntityStatus?), TypeInfoPropertyName = "NullableEntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.EnvironmentEnum?), TypeInfoPropertyName = "NullableEnvironmentEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumVariableType?), TypeInfoPropertyName = "NullableVellumVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NumberEnum?), TypeInfoPropertyName = "NullableNumberEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumValue?), TypeInfoPropertyName = "NullableVellumValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ArrayChatMessageContentItem?), TypeInfoPropertyName = "NullableArrayChatMessageContentItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ChatMessageContent?), TypeInfoPropertyName = "NullableChatMessageContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultsEnum?), TypeInfoPropertyName = "NullableSearchResultsEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PdfEnum?), TypeInfoPropertyName = "NullablePdfEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultMetaSource?), TypeInfoPropertyName = "NullableSearchResultMetaSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedScenarioInputRequest?), TypeInfoPropertyName = "NullableNamedScenarioInputRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ScenarioInput?), TypeInfoPropertyName = "NullableScenarioInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.V1DeploymentsGetParametersStatus?), TypeInfoPropertyName = "NullableV1DeploymentsGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SandboxEnum?), TypeInfoPropertyName = "NullableSandboxEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptVersionBuildConfig?), TypeInfoPropertyName = "NullablePromptVersionBuildConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReleaseTagSource?), TypeInfoPropertyName = "NullableReleaseTagSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReleaseReviewState?), TypeInfoPropertyName = "NullableReleaseReviewState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.V1DeploymentsIdReleaseTagsGetParametersSource?), TypeInfoPropertyName = "NullableV1DeploymentsIdReleaseTagsGetParametersSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowRequestInputRequest?), TypeInfoPropertyName = "NullableWorkflowRequestInputRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowOutput?), TypeInfoPropertyName = "NullableWorkflowOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowEventErrorRawData?), TypeInfoPropertyName = "NullableWorkflowEventErrorRawData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionEventErrorCode?), TypeInfoPropertyName = "NullableWorkflowExecutionEventErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecuteWorkflowWorkflowResultEvent?), TypeInfoPropertyName = "NullableExecuteWorkflowWorkflowResultEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionEventType?), TypeInfoPropertyName = "NullableWorkflowExecutionEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowEnum?), TypeInfoPropertyName = "NullableWorkflowEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowResultEventState?), TypeInfoPropertyName = "NullableWorkflowResultEventState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowNodeResultEventState?), TypeInfoPropertyName = "NullableWorkflowNodeResultEventState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowResultEventOutputData?), TypeInfoPropertyName = "NullableWorkflowResultEventOutputData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutionVellumValue?), TypeInfoPropertyName = "NullableExecutionVellumValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeEnum?), TypeInfoPropertyName = "NullableNodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptEnum?), TypeInfoPropertyName = "NullablePromptEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchEnum?), TypeInfoPropertyName = "NullableSearchEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TemplatingEnum?), TypeInfoPropertyName = "NullableTemplatingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TemplatingNodeResultOutput?), TypeInfoPropertyName = "NullableTemplatingNodeResultOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CodeExecutionEnum?), TypeInfoPropertyName = "NullableCodeExecutionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CodeExecutionNodeResultOutput?), TypeInfoPropertyName = "NullableCodeExecutionNodeResultOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ConditionalEnum?), TypeInfoPropertyName = "NullableConditionalEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ApiEnum?), TypeInfoPropertyName = "NullableApiEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TerminalEnum?), TypeInfoPropertyName = "NullableTerminalEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TerminalNodeResultOutput?), TypeInfoPropertyName = "NullableTerminalNodeResultOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MergeEnum?), TypeInfoPropertyName = "NullableMergeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SubworkflowEnum?), TypeInfoPropertyName = "NullableSubworkflowEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MetricEnum?), TypeInfoPropertyName = "NullableMetricEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MapEnum?), TypeInfoPropertyName = "NullableMapEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.IterationStateEnum?), TypeInfoPropertyName = "NullableIterationStateEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowNodeResultData?), TypeInfoPropertyName = "NullableWorkflowNodeResultData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SecretEnum?), TypeInfoPropertyName = "NullableSecretEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeInputVariableCompiledValue?), TypeInfoPropertyName = "NullableNodeInputVariableCompiledValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeOutputCompiledValue?), TypeInfoPropertyName = "NullableNodeOutputCompiledValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowNodeResultEvent?), TypeInfoPropertyName = "NullableWorkflowNodeResultEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowStreamEvent?), TypeInfoPropertyName = "NullableWorkflowStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SubmitWorkflowExecutionActualRequest?), TypeInfoPropertyName = "NullableSubmitWorkflowExecutionActualRequest2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowEvent?), TypeInfoPropertyName = "NullableWorkflowEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.V1WorkflowDeploymentsGetParametersStatus?), TypeInfoPropertyName = "NullableV1WorkflowDeploymentsGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.IntegrationName?), TypeInfoPropertyName = "NullableIntegrationName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ModelProviderEnum?), TypeInfoPropertyName = "NullableModelProviderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MLModelHostingInterface?), TypeInfoPropertyName = "NullableMLModelHostingInterface2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowDependency?), TypeInfoPropertyName = "NullableWorkflowDependency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.V1WorkflowDeploymentsIdReleaseTagsGetParametersSource?), TypeInfoPropertyName = "NullableV1WorkflowDeploymentsIdReleaseTagsGetParametersSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowError?), TypeInfoPropertyName = "NullableWorkflowError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionUsageCalculationErrorCodeEnum?), TypeInfoPropertyName = "NullableWorkflowExecutionUsageCalculationErrorCodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionEnum?), TypeInfoPropertyName = "NullableWorkflowExecutionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumWorkflowExecutionEvent?), TypeInfoPropertyName = "NullableVellumWorkflowExecutionEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionEnum?), TypeInfoPropertyName = "NullableNodeExecutionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumNodeExecutionEvent?), TypeInfoPropertyName = "NullableVellumNodeExecutionEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumSpan?), TypeInfoPropertyName = "NullableVellumSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CreateWorkflowEventRequest?), TypeInfoPropertyName = "NullableCreateWorkflowEventRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MetadataFilterRuleCombinator?), TypeInfoPropertyName = "NullableMetadataFilterRuleCombinator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.LogicalOperator?), TypeInfoPropertyName = "NullableLogicalOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.LogicalConditionEnum?), TypeInfoPropertyName = "NullableLogicalConditionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumValueRequest?), TypeInfoPropertyName = "NullableVellumValueRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultMetaSourceRequest?), TypeInfoPropertyName = "NullableSearchResultMetaSourceRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.LogicalConditionGroupEnum?), TypeInfoPropertyName = "NullableLogicalConditionGroupEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ConditionCombinator?), TypeInfoPropertyName = "NullableConditionCombinator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumValueLogicalExpressionRequest?), TypeInfoPropertyName = "NullableVellumValueLogicalExpressionRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MetadataFiltersRequest?), TypeInfoPropertyName = "NullableMetadataFiltersRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TextEmbedding3SmallEnum?), TypeInfoPropertyName = "NullableTextEmbedding3SmallEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TextEmbedding3LargeEnum?), TypeInfoPropertyName = "NullableTextEmbedding3LargeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TextEmbeddingAda002Enum?), TypeInfoPropertyName = "NullableTextEmbeddingAda002Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.IntfloatMultilingualE5LargeEnum?), TypeInfoPropertyName = "NullableIntfloatMultilingualE5LargeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseCosV1Enum?), TypeInfoPropertyName = "NullableSentenceTransformersMultiQaMpnetBaseCosV1Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseDotV1Enum?), TypeInfoPropertyName = "NullableSentenceTransformersMultiQaMpnetBaseDotV1Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.HkunlpInstructorXlEnum?), TypeInfoPropertyName = "NullableHkunlpInstructorXlEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TextEmbedding004Enum?), TypeInfoPropertyName = "NullableTextEmbedding004Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TextMultilingualEmbedding002Enum?), TypeInfoPropertyName = "NullableTextMultilingualEmbedding002Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.GeminiEmbedding001Enum?), TypeInfoPropertyName = "NullableGeminiEmbedding001Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.BaaiBgeSmallEnV15Enum?), TypeInfoPropertyName = "NullableBaaiBgeSmallEnV15Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PrivateVectorizerEnum?), TypeInfoPropertyName = "NullablePrivateVectorizerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.IndexingConfigVectorizerRequest?), TypeInfoPropertyName = "NullableIndexingConfigVectorizerRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReductoChunkerEnum?), TypeInfoPropertyName = "NullableReductoChunkerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SentenceChunkerEnum?), TypeInfoPropertyName = "NullableSentenceChunkerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TokenOverlappingWindowChunkerEnum?), TypeInfoPropertyName = "NullableTokenOverlappingWindowChunkerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DelimiterChunkerEnum?), TypeInfoPropertyName = "NullableDelimiterChunkerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentIndexChunkingRequest?), TypeInfoPropertyName = "NullableDocumentIndexChunkingRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.IndexingConfigVectorizer?), TypeInfoPropertyName = "NullableIndexingConfigVectorizer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentIndexChunking?), TypeInfoPropertyName = "NullableDocumentIndexChunking2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.V1DocumentIndexesGetParametersStatus?), TypeInfoPropertyName = "NullableV1DocumentIndexesGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentProcessingState?), TypeInfoPropertyName = "NullableDocumentProcessingState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentStatus?), TypeInfoPropertyName = "NullableDocumentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.IndexingStateEnum?), TypeInfoPropertyName = "NullableIndexingStateEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ProcessingFailureReasonEnum?), TypeInfoPropertyName = "NullableProcessingFailureReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestCaseVariableValue?), TypeInfoPropertyName = "NullableTestCaseVariableValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseVariableValueRequest?), TypeInfoPropertyName = "NullableNamedTestCaseVariableValueRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CreateEnum?), TypeInfoPropertyName = "NullableCreateEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReplaceEnum?), TypeInfoPropertyName = "NullableReplaceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.UpsertEnum?), TypeInfoPropertyName = "NullableUpsertEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeleteEnum?), TypeInfoPropertyName = "NullableDeleteEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteTestCaseBulkOperationRequest?), TypeInfoPropertyName = "NullableTestSuiteTestCaseBulkOperationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CreatedEnum?), TypeInfoPropertyName = "NullableCreatedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReplacedEnum?), TypeInfoPropertyName = "NullableReplacedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeletedEnum?), TypeInfoPropertyName = "NullableDeletedEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteTestCaseBulkResult?), TypeInfoPropertyName = "NullableTestSuiteTestCaseBulkResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigTypeEnum?), TypeInfoPropertyName = "NullableTestSuiteRunDeploymentReleaseTagExecConfigTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunPromptSandboxExecConfigTypeEnum?), TypeInfoPropertyName = "NullableTestSuiteRunPromptSandboxExecConfigTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigTypeEnum?), TypeInfoPropertyName = "NullableTestSuiteRunPromptSandboxHistoryItemExecConfigTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigTypeEnum?), TypeInfoPropertyName = "NullableTestSuiteRunWorkflowReleaseTagExecConfigTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunWorkflowSandboxExecConfigTypeEnum?), TypeInfoPropertyName = "NullableTestSuiteRunWorkflowSandboxExecConfigTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnum?), TypeInfoPropertyName = "NullableTestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExternalExecConfigTypeEnum?), TypeInfoPropertyName = "NullableTestSuiteRunExternalExecConfigTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExecConfigRequest?), TypeInfoPropertyName = "NullableTestSuiteRunExecConfigRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunState?), TypeInfoPropertyName = "NullableTestSuiteRunState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseVariableValue?), TypeInfoPropertyName = "NullableNamedTestCaseVariableValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExecConfig?), TypeInfoPropertyName = "NullableTestSuiteRunExecConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunExecutionOutput?), TypeInfoPropertyName = "NullableTestSuiteRunExecutionOutput2")]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricStringOutputTypeEnum?), TypeInfoPropertyName = "NullableTestSuiteRunMetricStringOutputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricNumberOutputTypeEnum?), TypeInfoPropertyName = "NullableTestSuiteRunMetricNumberOutputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricJSONOutputTypeEnum?), TypeInfoPropertyName = "NullableTestSuiteRunMetricJSONOutputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricErrorOutputTypeEnum?), TypeInfoPropertyName = "NullableTestSuiteRunMetricErrorOutputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricArrayOutputTypeEnum?), TypeInfoPropertyName = "NullableTestSuiteRunMetricArrayOutputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricOutput?), TypeInfoPropertyName = "NullableTestSuiteRunMetricOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.V1FolderEntitiesGetParametersEntityStatus?), TypeInfoPropertyName = "NullableV1FolderEntitiesGetParametersEntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEnum?), TypeInfoPropertyName = "NullableFolderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptSandboxEnum?), TypeInfoPropertyName = "NullablePromptSandboxEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentIndexEnum?), TypeInfoPropertyName = "NullableDocumentIndexEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteEnum?), TypeInfoPropertyName = "NullableTestSuiteEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DatasetEnum?), TypeInfoPropertyName = "NullableDatasetEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntity?), TypeInfoPropertyName = "NullableFolderEntity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SecretTypeEnum?), TypeInfoPropertyName = "NullableSecretTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ArrayChatMessageContentItemRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ChatMessageRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.PromptDeploymentInputRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.PromptOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.SubmitCompletionActualRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.VellumValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ArrayChatMessageContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.SearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.VellumVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.NamedScenarioInputRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ScenarioInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.SlimDeploymentRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ReleaseReleaseTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.SlimReleaseReview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.DeploymentReleaseTagRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.WorkflowRequestInputRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.WorkflowOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.WorkflowExecutionEventType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ExecutionVellumValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.NodeInputVariableCompiledValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.NodeOutputCompiledValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.SubmitWorkflowExecutionActualRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.SpanLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.InvokedPort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.CodeResourceDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ExternalInputDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.SlimWorkflowDeployment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.WorkflowDependency>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.WorkflowDeploymentRelease>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.WorkflowReleaseTagRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.MLModelUsageWrapper>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.Price>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.WorkflowExecutionUsageResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.WorkflowExecutionViewOnlineEvalMetricResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.SlimWorkflowExecutionRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.VellumWorkflowExecutionEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.VellumNodeExecutionEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.VellumSpan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.WorkflowEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.MetadataFilterRuleRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.VellumValueRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.SearchResultRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.VellumValueLogicalExpressionRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.DocumentIndexRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.DocumentDocumentToDocumentIndex>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.SlimDocumentDocumentToDocumentIndex>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.SlimDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.TestCaseVariableValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.TestSuiteTestCase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.NamedTestCaseVariableValueRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ExternalTestCaseExecutionRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.NamedTestCaseVariableValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ExternalTestCaseExecution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.TestSuiteRunMetricOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.TestSuiteRunExecutionOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.TestSuiteRunExecutionMetricResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.TestSuiteRunExecution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.FolderEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.TestSuiteTestCaseBulkOperationRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.TestSuiteTestCaseBulkResult>))]
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

         static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Vellum.JsonConverters.ArrayChatMessageContentItemRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.ChatMessageContentRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.PromptDeploymentInputRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.PromptOutputJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.ExecutePromptResponseJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.ExecutePromptEventJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.DeploymentProviderPayloadResponsePayloadJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.ArrayChatMessageContentItemJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.ChatMessageContentJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.SearchResultMetaSourceJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.VellumValueJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.NamedScenarioInputRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.ScenarioInputJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.PromptVersionBuildConfigJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.WorkflowRequestInputRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.WorkflowOutputJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.WorkflowEventErrorRawDataJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.ExecuteWorkflowWorkflowResultEventJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.WorkflowResultEventOutputDataJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.ExecutionVellumValueJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.TemplatingNodeResultOutputJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.CodeExecutionNodeResultOutputJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.TerminalNodeResultOutputJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.WorkflowNodeResultDataJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.NodeInputVariableCompiledValueJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.NodeOutputCompiledValueJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.WorkflowNodeResultEventJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.WorkflowStreamEventJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.SubmitWorkflowExecutionActualRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.ParentContextJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.VellumSdkErrorRawDataJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.WorkflowEventJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.WorkflowDependencyJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.WorkflowErrorJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.VellumWorkflowExecutionEventJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.VellumNodeExecutionEventJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.VellumSpanJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.CreateWorkflowEventRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.SearchResultMetaSourceRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.VellumValueRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.VellumValueLogicalExpressionRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.MetadataFiltersRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.IndexingConfigVectorizerRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.DocumentIndexChunkingRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.IndexingConfigVectorizerJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.DocumentIndexChunkingJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.TestCaseVariableValueJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.NamedTestCaseVariableValueRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.TestSuiteTestCaseBulkOperationRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.TestSuiteTestCaseBulkResultJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.TestSuiteRunExecConfigRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.NamedTestCaseVariableValueJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.TestSuiteRunExecConfigJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.TestSuiteRunExecutionOutputJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.TestSuiteRunMetricOutputJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.FolderEntityJsonConverter());
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

                    || typeToConvert == typeof(global::Vellum.FinishReasonEnum)

                    || typeToConvert == typeof(global::Vellum.FinishReasonEnum?)

                    || typeToConvert == typeof(global::Vellum.UnitEnum)

                    || typeToConvert == typeof(global::Vellum.UnitEnum?)

                    || typeToConvert == typeof(global::Vellum.FulfilledEnum)

                    || typeToConvert == typeof(global::Vellum.FulfilledEnum?)

                    || typeToConvert == typeof(global::Vellum.ErrorEnum)

                    || typeToConvert == typeof(global::Vellum.ErrorEnum?)

                    || typeToConvert == typeof(global::Vellum.VellumErrorCodeEnum)

                    || typeToConvert == typeof(global::Vellum.VellumErrorCodeEnum?)

                    || typeToConvert == typeof(global::Vellum.ThinkingEnum)

                    || typeToConvert == typeof(global::Vellum.ThinkingEnum?)

                    || typeToConvert == typeof(global::Vellum.RejectedEnum)

                    || typeToConvert == typeof(global::Vellum.RejectedEnum?)

                    || typeToConvert == typeof(global::Vellum.InitiatedEnum)

                    || typeToConvert == typeof(global::Vellum.InitiatedEnum?)

                    || typeToConvert == typeof(global::Vellum.StreamingEnum)

                    || typeToConvert == typeof(global::Vellum.StreamingEnum?)

                    || typeToConvert == typeof(global::Vellum.EntityStatus)

                    || typeToConvert == typeof(global::Vellum.EntityStatus?)

                    || typeToConvert == typeof(global::Vellum.EnvironmentEnum)

                    || typeToConvert == typeof(global::Vellum.EnvironmentEnum?)

                    || typeToConvert == typeof(global::Vellum.VellumVariableType)

                    || typeToConvert == typeof(global::Vellum.VellumVariableType?)

                    || typeToConvert == typeof(global::Vellum.NumberEnum)

                    || typeToConvert == typeof(global::Vellum.NumberEnum?)

                    || typeToConvert == typeof(global::Vellum.SearchResultsEnum)

                    || typeToConvert == typeof(global::Vellum.SearchResultsEnum?)

                    || typeToConvert == typeof(global::Vellum.PdfEnum)

                    || typeToConvert == typeof(global::Vellum.PdfEnum?)

                    || typeToConvert == typeof(global::Vellum.V1DeploymentsGetParametersStatus)

                    || typeToConvert == typeof(global::Vellum.V1DeploymentsGetParametersStatus?)

                    || typeToConvert == typeof(global::Vellum.SandboxEnum)

                    || typeToConvert == typeof(global::Vellum.SandboxEnum?)

                    || typeToConvert == typeof(global::Vellum.ReleaseTagSource)

                    || typeToConvert == typeof(global::Vellum.ReleaseTagSource?)

                    || typeToConvert == typeof(global::Vellum.ReleaseReviewState)

                    || typeToConvert == typeof(global::Vellum.ReleaseReviewState?)

                    || typeToConvert == typeof(global::Vellum.V1DeploymentsIdReleaseTagsGetParametersSource)

                    || typeToConvert == typeof(global::Vellum.V1DeploymentsIdReleaseTagsGetParametersSource?)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionEventErrorCode)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionEventErrorCode?)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionEventType)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionEventType?)

                    || typeToConvert == typeof(global::Vellum.WorkflowEnum)

                    || typeToConvert == typeof(global::Vellum.WorkflowEnum?)

                    || typeToConvert == typeof(global::Vellum.WorkflowResultEventState)

                    || typeToConvert == typeof(global::Vellum.WorkflowResultEventState?)

                    || typeToConvert == typeof(global::Vellum.WorkflowNodeResultEventState)

                    || typeToConvert == typeof(global::Vellum.WorkflowNodeResultEventState?)

                    || typeToConvert == typeof(global::Vellum.NodeEnum)

                    || typeToConvert == typeof(global::Vellum.NodeEnum?)

                    || typeToConvert == typeof(global::Vellum.PromptEnum)

                    || typeToConvert == typeof(global::Vellum.PromptEnum?)

                    || typeToConvert == typeof(global::Vellum.SearchEnum)

                    || typeToConvert == typeof(global::Vellum.SearchEnum?)

                    || typeToConvert == typeof(global::Vellum.TemplatingEnum)

                    || typeToConvert == typeof(global::Vellum.TemplatingEnum?)

                    || typeToConvert == typeof(global::Vellum.CodeExecutionEnum)

                    || typeToConvert == typeof(global::Vellum.CodeExecutionEnum?)

                    || typeToConvert == typeof(global::Vellum.ConditionalEnum)

                    || typeToConvert == typeof(global::Vellum.ConditionalEnum?)

                    || typeToConvert == typeof(global::Vellum.ApiEnum)

                    || typeToConvert == typeof(global::Vellum.ApiEnum?)

                    || typeToConvert == typeof(global::Vellum.TerminalEnum)

                    || typeToConvert == typeof(global::Vellum.TerminalEnum?)

                    || typeToConvert == typeof(global::Vellum.MergeEnum)

                    || typeToConvert == typeof(global::Vellum.MergeEnum?)

                    || typeToConvert == typeof(global::Vellum.SubworkflowEnum)

                    || typeToConvert == typeof(global::Vellum.SubworkflowEnum?)

                    || typeToConvert == typeof(global::Vellum.MetricEnum)

                    || typeToConvert == typeof(global::Vellum.MetricEnum?)

                    || typeToConvert == typeof(global::Vellum.MapEnum)

                    || typeToConvert == typeof(global::Vellum.MapEnum?)

                    || typeToConvert == typeof(global::Vellum.IterationStateEnum)

                    || typeToConvert == typeof(global::Vellum.IterationStateEnum?)

                    || typeToConvert == typeof(global::Vellum.SecretEnum)

                    || typeToConvert == typeof(global::Vellum.SecretEnum?)

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

                    || typeToConvert == typeof(global::Vellum.V1WorkflowDeploymentsGetParametersStatus)

                    || typeToConvert == typeof(global::Vellum.V1WorkflowDeploymentsGetParametersStatus?)

                    || typeToConvert == typeof(global::Vellum.IntegrationName)

                    || typeToConvert == typeof(global::Vellum.IntegrationName?)

                    || typeToConvert == typeof(global::Vellum.ModelProviderEnum)

                    || typeToConvert == typeof(global::Vellum.ModelProviderEnum?)

                    || typeToConvert == typeof(global::Vellum.MLModelHostingInterface)

                    || typeToConvert == typeof(global::Vellum.MLModelHostingInterface?)

                    || typeToConvert == typeof(global::Vellum.V1WorkflowDeploymentsIdReleaseTagsGetParametersSource)

                    || typeToConvert == typeof(global::Vellum.V1WorkflowDeploymentsIdReleaseTagsGetParametersSource?)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionUsageCalculationErrorCodeEnum)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionUsageCalculationErrorCodeEnum?)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionEnum)

                    || typeToConvert == typeof(global::Vellum.WorkflowExecutionEnum?)

                    || typeToConvert == typeof(global::Vellum.NodeExecutionEnum)

                    || typeToConvert == typeof(global::Vellum.NodeExecutionEnum?)

                    || typeToConvert == typeof(global::Vellum.MetadataFilterRuleCombinator)

                    || typeToConvert == typeof(global::Vellum.MetadataFilterRuleCombinator?)

                    || typeToConvert == typeof(global::Vellum.LogicalOperator)

                    || typeToConvert == typeof(global::Vellum.LogicalOperator?)

                    || typeToConvert == typeof(global::Vellum.LogicalConditionEnum)

                    || typeToConvert == typeof(global::Vellum.LogicalConditionEnum?)

                    || typeToConvert == typeof(global::Vellum.LogicalConditionGroupEnum)

                    || typeToConvert == typeof(global::Vellum.LogicalConditionGroupEnum?)

                    || typeToConvert == typeof(global::Vellum.ConditionCombinator)

                    || typeToConvert == typeof(global::Vellum.ConditionCombinator?)

                    || typeToConvert == typeof(global::Vellum.TextEmbedding3SmallEnum)

                    || typeToConvert == typeof(global::Vellum.TextEmbedding3SmallEnum?)

                    || typeToConvert == typeof(global::Vellum.TextEmbedding3LargeEnum)

                    || typeToConvert == typeof(global::Vellum.TextEmbedding3LargeEnum?)

                    || typeToConvert == typeof(global::Vellum.TextEmbeddingAda002Enum)

                    || typeToConvert == typeof(global::Vellum.TextEmbeddingAda002Enum?)

                    || typeToConvert == typeof(global::Vellum.IntfloatMultilingualE5LargeEnum)

                    || typeToConvert == typeof(global::Vellum.IntfloatMultilingualE5LargeEnum?)

                    || typeToConvert == typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseCosV1Enum)

                    || typeToConvert == typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseCosV1Enum?)

                    || typeToConvert == typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseDotV1Enum)

                    || typeToConvert == typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseDotV1Enum?)

                    || typeToConvert == typeof(global::Vellum.HkunlpInstructorXlEnum)

                    || typeToConvert == typeof(global::Vellum.HkunlpInstructorXlEnum?)

                    || typeToConvert == typeof(global::Vellum.TextEmbedding004Enum)

                    || typeToConvert == typeof(global::Vellum.TextEmbedding004Enum?)

                    || typeToConvert == typeof(global::Vellum.TextMultilingualEmbedding002Enum)

                    || typeToConvert == typeof(global::Vellum.TextMultilingualEmbedding002Enum?)

                    || typeToConvert == typeof(global::Vellum.GeminiEmbedding001Enum)

                    || typeToConvert == typeof(global::Vellum.GeminiEmbedding001Enum?)

                    || typeToConvert == typeof(global::Vellum.BaaiBgeSmallEnV15Enum)

                    || typeToConvert == typeof(global::Vellum.BaaiBgeSmallEnV15Enum?)

                    || typeToConvert == typeof(global::Vellum.PrivateVectorizerEnum)

                    || typeToConvert == typeof(global::Vellum.PrivateVectorizerEnum?)

                    || typeToConvert == typeof(global::Vellum.ReductoChunkerEnum)

                    || typeToConvert == typeof(global::Vellum.ReductoChunkerEnum?)

                    || typeToConvert == typeof(global::Vellum.SentenceChunkerEnum)

                    || typeToConvert == typeof(global::Vellum.SentenceChunkerEnum?)

                    || typeToConvert == typeof(global::Vellum.TokenOverlappingWindowChunkerEnum)

                    || typeToConvert == typeof(global::Vellum.TokenOverlappingWindowChunkerEnum?)

                    || typeToConvert == typeof(global::Vellum.DelimiterChunkerEnum)

                    || typeToConvert == typeof(global::Vellum.DelimiterChunkerEnum?)

                    || typeToConvert == typeof(global::Vellum.V1DocumentIndexesGetParametersStatus)

                    || typeToConvert == typeof(global::Vellum.V1DocumentIndexesGetParametersStatus?)

                    || typeToConvert == typeof(global::Vellum.DocumentProcessingState)

                    || typeToConvert == typeof(global::Vellum.DocumentProcessingState?)

                    || typeToConvert == typeof(global::Vellum.DocumentStatus)

                    || typeToConvert == typeof(global::Vellum.DocumentStatus?)

                    || typeToConvert == typeof(global::Vellum.IndexingStateEnum)

                    || typeToConvert == typeof(global::Vellum.IndexingStateEnum?)

                    || typeToConvert == typeof(global::Vellum.ProcessingFailureReasonEnum)

                    || typeToConvert == typeof(global::Vellum.ProcessingFailureReasonEnum?)

                    || typeToConvert == typeof(global::Vellum.CreateEnum)

                    || typeToConvert == typeof(global::Vellum.CreateEnum?)

                    || typeToConvert == typeof(global::Vellum.ReplaceEnum)

                    || typeToConvert == typeof(global::Vellum.ReplaceEnum?)

                    || typeToConvert == typeof(global::Vellum.UpsertEnum)

                    || typeToConvert == typeof(global::Vellum.UpsertEnum?)

                    || typeToConvert == typeof(global::Vellum.DeleteEnum)

                    || typeToConvert == typeof(global::Vellum.DeleteEnum?)

                    || typeToConvert == typeof(global::Vellum.CreatedEnum)

                    || typeToConvert == typeof(global::Vellum.CreatedEnum?)

                    || typeToConvert == typeof(global::Vellum.ReplacedEnum)

                    || typeToConvert == typeof(global::Vellum.ReplacedEnum?)

                    || typeToConvert == typeof(global::Vellum.DeletedEnum)

                    || typeToConvert == typeof(global::Vellum.DeletedEnum?)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigTypeEnum)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigTypeEnum?)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunPromptSandboxExecConfigTypeEnum)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunPromptSandboxExecConfigTypeEnum?)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigTypeEnum)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigTypeEnum?)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigTypeEnum)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigTypeEnum?)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunWorkflowSandboxExecConfigTypeEnum)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunWorkflowSandboxExecConfigTypeEnum?)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnum)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnum?)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunExternalExecConfigTypeEnum)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunExternalExecConfigTypeEnum?)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunState)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunState?)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunMetricStringOutputTypeEnum)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunMetricStringOutputTypeEnum?)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunMetricNumberOutputTypeEnum)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunMetricNumberOutputTypeEnum?)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunMetricJSONOutputTypeEnum)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunMetricJSONOutputTypeEnum?)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunMetricErrorOutputTypeEnum)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunMetricErrorOutputTypeEnum?)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunMetricArrayOutputTypeEnum)

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunMetricArrayOutputTypeEnum?)

                    || typeToConvert == typeof(global::Vellum.V1FolderEntitiesGetParametersEntityStatus)

                    || typeToConvert == typeof(global::Vellum.V1FolderEntitiesGetParametersEntityStatus?)

                    || typeToConvert == typeof(global::Vellum.FolderEnum)

                    || typeToConvert == typeof(global::Vellum.FolderEnum?)

                    || typeToConvert == typeof(global::Vellum.PromptSandboxEnum)

                    || typeToConvert == typeof(global::Vellum.PromptSandboxEnum?)

                    || typeToConvert == typeof(global::Vellum.DocumentIndexEnum)

                    || typeToConvert == typeof(global::Vellum.DocumentIndexEnum?)

                    || typeToConvert == typeof(global::Vellum.TestSuiteEnum)

                    || typeToConvert == typeof(global::Vellum.TestSuiteEnum?)

                    || typeToConvert == typeof(global::Vellum.DatasetEnum)

                    || typeToConvert == typeof(global::Vellum.DatasetEnum?)

                    || typeToConvert == typeof(global::Vellum.SecretTypeEnum)

                    || typeToConvert == typeof(global::Vellum.SecretTypeEnum?);
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

                if (typeToConvert == typeof(global::Vellum.FinishReasonEnum))
                {
                    return new global::Vellum.JsonConverters.FinishReasonEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.FinishReasonEnum?))
                {
                    return new global::Vellum.JsonConverters.FinishReasonEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.UnitEnum))
                {
                    return new global::Vellum.JsonConverters.UnitEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.UnitEnum?))
                {
                    return new global::Vellum.JsonConverters.UnitEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.FulfilledEnum))
                {
                    return new global::Vellum.JsonConverters.FulfilledEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.FulfilledEnum?))
                {
                    return new global::Vellum.JsonConverters.FulfilledEnumNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Vellum.RejectedEnum))
                {
                    return new global::Vellum.JsonConverters.RejectedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.RejectedEnum?))
                {
                    return new global::Vellum.JsonConverters.RejectedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.InitiatedEnum))
                {
                    return new global::Vellum.JsonConverters.InitiatedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.InitiatedEnum?))
                {
                    return new global::Vellum.JsonConverters.InitiatedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.StreamingEnum))
                {
                    return new global::Vellum.JsonConverters.StreamingEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.StreamingEnum?))
                {
                    return new global::Vellum.JsonConverters.StreamingEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.EntityStatus))
                {
                    return new global::Vellum.JsonConverters.EntityStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.EntityStatus?))
                {
                    return new global::Vellum.JsonConverters.EntityStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.EnvironmentEnum))
                {
                    return new global::Vellum.JsonConverters.EnvironmentEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.EnvironmentEnum?))
                {
                    return new global::Vellum.JsonConverters.EnvironmentEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.VellumVariableType))
                {
                    return new global::Vellum.JsonConverters.VellumVariableTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.VellumVariableType?))
                {
                    return new global::Vellum.JsonConverters.VellumVariableTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Vellum.V1DeploymentsGetParametersStatus))
                {
                    return new global::Vellum.JsonConverters.V1DeploymentsGetParametersStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.V1DeploymentsGetParametersStatus?))
                {
                    return new global::Vellum.JsonConverters.V1DeploymentsGetParametersStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SandboxEnum))
                {
                    return new global::Vellum.JsonConverters.SandboxEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SandboxEnum?))
                {
                    return new global::Vellum.JsonConverters.SandboxEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ReleaseTagSource))
                {
                    return new global::Vellum.JsonConverters.ReleaseTagSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ReleaseTagSource?))
                {
                    return new global::Vellum.JsonConverters.ReleaseTagSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ReleaseReviewState))
                {
                    return new global::Vellum.JsonConverters.ReleaseReviewStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ReleaseReviewState?))
                {
                    return new global::Vellum.JsonConverters.ReleaseReviewStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.V1DeploymentsIdReleaseTagsGetParametersSource))
                {
                    return new global::Vellum.JsonConverters.V1DeploymentsIdReleaseTagsGetParametersSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.V1DeploymentsIdReleaseTagsGetParametersSource?))
                {
                    return new global::Vellum.JsonConverters.V1DeploymentsIdReleaseTagsGetParametersSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionEventErrorCode))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionEventErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionEventErrorCode?))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionEventErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionEventType))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowExecutionEventType?))
                {
                    return new global::Vellum.JsonConverters.WorkflowExecutionEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowEnum))
                {
                    return new global::Vellum.JsonConverters.WorkflowEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowEnum?))
                {
                    return new global::Vellum.JsonConverters.WorkflowEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowResultEventState))
                {
                    return new global::Vellum.JsonConverters.WorkflowResultEventStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowResultEventState?))
                {
                    return new global::Vellum.JsonConverters.WorkflowResultEventStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowNodeResultEventState))
                {
                    return new global::Vellum.JsonConverters.WorkflowNodeResultEventStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowNodeResultEventState?))
                {
                    return new global::Vellum.JsonConverters.WorkflowNodeResultEventStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.NodeEnum))
                {
                    return new global::Vellum.JsonConverters.NodeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.NodeEnum?))
                {
                    return new global::Vellum.JsonConverters.NodeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.PromptEnum))
                {
                    return new global::Vellum.JsonConverters.PromptEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.PromptEnum?))
                {
                    return new global::Vellum.JsonConverters.PromptEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SearchEnum))
                {
                    return new global::Vellum.JsonConverters.SearchEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SearchEnum?))
                {
                    return new global::Vellum.JsonConverters.SearchEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TemplatingEnum))
                {
                    return new global::Vellum.JsonConverters.TemplatingEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TemplatingEnum?))
                {
                    return new global::Vellum.JsonConverters.TemplatingEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.CodeExecutionEnum))
                {
                    return new global::Vellum.JsonConverters.CodeExecutionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.CodeExecutionEnum?))
                {
                    return new global::Vellum.JsonConverters.CodeExecutionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ConditionalEnum))
                {
                    return new global::Vellum.JsonConverters.ConditionalEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ConditionalEnum?))
                {
                    return new global::Vellum.JsonConverters.ConditionalEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ApiEnum))
                {
                    return new global::Vellum.JsonConverters.ApiEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ApiEnum?))
                {
                    return new global::Vellum.JsonConverters.ApiEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TerminalEnum))
                {
                    return new global::Vellum.JsonConverters.TerminalEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TerminalEnum?))
                {
                    return new global::Vellum.JsonConverters.TerminalEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.MergeEnum))
                {
                    return new global::Vellum.JsonConverters.MergeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.MergeEnum?))
                {
                    return new global::Vellum.JsonConverters.MergeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SubworkflowEnum))
                {
                    return new global::Vellum.JsonConverters.SubworkflowEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SubworkflowEnum?))
                {
                    return new global::Vellum.JsonConverters.SubworkflowEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.MetricEnum))
                {
                    return new global::Vellum.JsonConverters.MetricEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.MetricEnum?))
                {
                    return new global::Vellum.JsonConverters.MetricEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.MapEnum))
                {
                    return new global::Vellum.JsonConverters.MapEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.MapEnum?))
                {
                    return new global::Vellum.JsonConverters.MapEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.IterationStateEnum))
                {
                    return new global::Vellum.JsonConverters.IterationStateEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.IterationStateEnum?))
                {
                    return new global::Vellum.JsonConverters.IterationStateEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SecretEnum))
                {
                    return new global::Vellum.JsonConverters.SecretEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SecretEnum?))
                {
                    return new global::Vellum.JsonConverters.SecretEnumNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Vellum.V1WorkflowDeploymentsGetParametersStatus))
                {
                    return new global::Vellum.JsonConverters.V1WorkflowDeploymentsGetParametersStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.V1WorkflowDeploymentsGetParametersStatus?))
                {
                    return new global::Vellum.JsonConverters.V1WorkflowDeploymentsGetParametersStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.IntegrationName))
                {
                    return new global::Vellum.JsonConverters.IntegrationNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.IntegrationName?))
                {
                    return new global::Vellum.JsonConverters.IntegrationNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ModelProviderEnum))
                {
                    return new global::Vellum.JsonConverters.ModelProviderEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ModelProviderEnum?))
                {
                    return new global::Vellum.JsonConverters.ModelProviderEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.MLModelHostingInterface))
                {
                    return new global::Vellum.JsonConverters.MLModelHostingInterfaceJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.MLModelHostingInterface?))
                {
                    return new global::Vellum.JsonConverters.MLModelHostingInterfaceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.V1WorkflowDeploymentsIdReleaseTagsGetParametersSource))
                {
                    return new global::Vellum.JsonConverters.V1WorkflowDeploymentsIdReleaseTagsGetParametersSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.V1WorkflowDeploymentsIdReleaseTagsGetParametersSource?))
                {
                    return new global::Vellum.JsonConverters.V1WorkflowDeploymentsIdReleaseTagsGetParametersSourceNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Vellum.MetadataFilterRuleCombinator))
                {
                    return new global::Vellum.JsonConverters.MetadataFilterRuleCombinatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.MetadataFilterRuleCombinator?))
                {
                    return new global::Vellum.JsonConverters.MetadataFilterRuleCombinatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.LogicalOperator))
                {
                    return new global::Vellum.JsonConverters.LogicalOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.LogicalOperator?))
                {
                    return new global::Vellum.JsonConverters.LogicalOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.LogicalConditionEnum))
                {
                    return new global::Vellum.JsonConverters.LogicalConditionEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.LogicalConditionEnum?))
                {
                    return new global::Vellum.JsonConverters.LogicalConditionEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.LogicalConditionGroupEnum))
                {
                    return new global::Vellum.JsonConverters.LogicalConditionGroupEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.LogicalConditionGroupEnum?))
                {
                    return new global::Vellum.JsonConverters.LogicalConditionGroupEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ConditionCombinator))
                {
                    return new global::Vellum.JsonConverters.ConditionCombinatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ConditionCombinator?))
                {
                    return new global::Vellum.JsonConverters.ConditionCombinatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TextEmbedding3SmallEnum))
                {
                    return new global::Vellum.JsonConverters.TextEmbedding3SmallEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TextEmbedding3SmallEnum?))
                {
                    return new global::Vellum.JsonConverters.TextEmbedding3SmallEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TextEmbedding3LargeEnum))
                {
                    return new global::Vellum.JsonConverters.TextEmbedding3LargeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TextEmbedding3LargeEnum?))
                {
                    return new global::Vellum.JsonConverters.TextEmbedding3LargeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TextEmbeddingAda002Enum))
                {
                    return new global::Vellum.JsonConverters.TextEmbeddingAda002EnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TextEmbeddingAda002Enum?))
                {
                    return new global::Vellum.JsonConverters.TextEmbeddingAda002EnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.IntfloatMultilingualE5LargeEnum))
                {
                    return new global::Vellum.JsonConverters.IntfloatMultilingualE5LargeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.IntfloatMultilingualE5LargeEnum?))
                {
                    return new global::Vellum.JsonConverters.IntfloatMultilingualE5LargeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseCosV1Enum))
                {
                    return new global::Vellum.JsonConverters.SentenceTransformersMultiQaMpnetBaseCosV1EnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseCosV1Enum?))
                {
                    return new global::Vellum.JsonConverters.SentenceTransformersMultiQaMpnetBaseCosV1EnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseDotV1Enum))
                {
                    return new global::Vellum.JsonConverters.SentenceTransformersMultiQaMpnetBaseDotV1EnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseDotV1Enum?))
                {
                    return new global::Vellum.JsonConverters.SentenceTransformersMultiQaMpnetBaseDotV1EnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.HkunlpInstructorXlEnum))
                {
                    return new global::Vellum.JsonConverters.HkunlpInstructorXlEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.HkunlpInstructorXlEnum?))
                {
                    return new global::Vellum.JsonConverters.HkunlpInstructorXlEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TextEmbedding004Enum))
                {
                    return new global::Vellum.JsonConverters.TextEmbedding004EnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TextEmbedding004Enum?))
                {
                    return new global::Vellum.JsonConverters.TextEmbedding004EnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TextMultilingualEmbedding002Enum))
                {
                    return new global::Vellum.JsonConverters.TextMultilingualEmbedding002EnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TextMultilingualEmbedding002Enum?))
                {
                    return new global::Vellum.JsonConverters.TextMultilingualEmbedding002EnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.GeminiEmbedding001Enum))
                {
                    return new global::Vellum.JsonConverters.GeminiEmbedding001EnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.GeminiEmbedding001Enum?))
                {
                    return new global::Vellum.JsonConverters.GeminiEmbedding001EnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.BaaiBgeSmallEnV15Enum))
                {
                    return new global::Vellum.JsonConverters.BaaiBgeSmallEnV15EnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.BaaiBgeSmallEnV15Enum?))
                {
                    return new global::Vellum.JsonConverters.BaaiBgeSmallEnV15EnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.PrivateVectorizerEnum))
                {
                    return new global::Vellum.JsonConverters.PrivateVectorizerEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.PrivateVectorizerEnum?))
                {
                    return new global::Vellum.JsonConverters.PrivateVectorizerEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ReductoChunkerEnum))
                {
                    return new global::Vellum.JsonConverters.ReductoChunkerEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ReductoChunkerEnum?))
                {
                    return new global::Vellum.JsonConverters.ReductoChunkerEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SentenceChunkerEnum))
                {
                    return new global::Vellum.JsonConverters.SentenceChunkerEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SentenceChunkerEnum?))
                {
                    return new global::Vellum.JsonConverters.SentenceChunkerEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TokenOverlappingWindowChunkerEnum))
                {
                    return new global::Vellum.JsonConverters.TokenOverlappingWindowChunkerEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TokenOverlappingWindowChunkerEnum?))
                {
                    return new global::Vellum.JsonConverters.TokenOverlappingWindowChunkerEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DelimiterChunkerEnum))
                {
                    return new global::Vellum.JsonConverters.DelimiterChunkerEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DelimiterChunkerEnum?))
                {
                    return new global::Vellum.JsonConverters.DelimiterChunkerEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.V1DocumentIndexesGetParametersStatus))
                {
                    return new global::Vellum.JsonConverters.V1DocumentIndexesGetParametersStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.V1DocumentIndexesGetParametersStatus?))
                {
                    return new global::Vellum.JsonConverters.V1DocumentIndexesGetParametersStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DocumentProcessingState))
                {
                    return new global::Vellum.JsonConverters.DocumentProcessingStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DocumentProcessingState?))
                {
                    return new global::Vellum.JsonConverters.DocumentProcessingStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DocumentStatus))
                {
                    return new global::Vellum.JsonConverters.DocumentStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DocumentStatus?))
                {
                    return new global::Vellum.JsonConverters.DocumentStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.IndexingStateEnum))
                {
                    return new global::Vellum.JsonConverters.IndexingStateEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.IndexingStateEnum?))
                {
                    return new global::Vellum.JsonConverters.IndexingStateEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ProcessingFailureReasonEnum))
                {
                    return new global::Vellum.JsonConverters.ProcessingFailureReasonEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ProcessingFailureReasonEnum?))
                {
                    return new global::Vellum.JsonConverters.ProcessingFailureReasonEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.CreateEnum))
                {
                    return new global::Vellum.JsonConverters.CreateEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.CreateEnum?))
                {
                    return new global::Vellum.JsonConverters.CreateEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ReplaceEnum))
                {
                    return new global::Vellum.JsonConverters.ReplaceEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ReplaceEnum?))
                {
                    return new global::Vellum.JsonConverters.ReplaceEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.UpsertEnum))
                {
                    return new global::Vellum.JsonConverters.UpsertEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.UpsertEnum?))
                {
                    return new global::Vellum.JsonConverters.UpsertEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DeleteEnum))
                {
                    return new global::Vellum.JsonConverters.DeleteEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DeleteEnum?))
                {
                    return new global::Vellum.JsonConverters.DeleteEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.CreatedEnum))
                {
                    return new global::Vellum.JsonConverters.CreatedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.CreatedEnum?))
                {
                    return new global::Vellum.JsonConverters.CreatedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ReplacedEnum))
                {
                    return new global::Vellum.JsonConverters.ReplacedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ReplacedEnum?))
                {
                    return new global::Vellum.JsonConverters.ReplacedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DeletedEnum))
                {
                    return new global::Vellum.JsonConverters.DeletedEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DeletedEnum?))
                {
                    return new global::Vellum.JsonConverters.DeletedEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigTypeEnum))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunDeploymentReleaseTagExecConfigTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigTypeEnum?))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunDeploymentReleaseTagExecConfigTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunPromptSandboxExecConfigTypeEnum))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunPromptSandboxExecConfigTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunPromptSandboxExecConfigTypeEnum?))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunPromptSandboxExecConfigTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigTypeEnum))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunPromptSandboxHistoryItemExecConfigTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigTypeEnum?))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunPromptSandboxHistoryItemExecConfigTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigTypeEnum))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunWorkflowReleaseTagExecConfigTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigTypeEnum?))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunWorkflowReleaseTagExecConfigTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunWorkflowSandboxExecConfigTypeEnum))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunWorkflowSandboxExecConfigTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunWorkflowSandboxExecConfigTypeEnum?))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunWorkflowSandboxExecConfigTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnum))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnum?))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunExternalExecConfigTypeEnum))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunExternalExecConfigTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunExternalExecConfigTypeEnum?))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunExternalExecConfigTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunState))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunState?))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunMetricStringOutputTypeEnum))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunMetricStringOutputTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunMetricStringOutputTypeEnum?))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunMetricStringOutputTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunMetricNumberOutputTypeEnum))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunMetricNumberOutputTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunMetricNumberOutputTypeEnum?))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunMetricNumberOutputTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunMetricJSONOutputTypeEnum))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunMetricJSONOutputTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunMetricJSONOutputTypeEnum?))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunMetricJSONOutputTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunMetricErrorOutputTypeEnum))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunMetricErrorOutputTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunMetricErrorOutputTypeEnum?))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunMetricErrorOutputTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunMetricArrayOutputTypeEnum))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunMetricArrayOutputTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteRunMetricArrayOutputTypeEnum?))
                {
                    return new global::Vellum.JsonConverters.TestSuiteRunMetricArrayOutputTypeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.V1FolderEntitiesGetParametersEntityStatus))
                {
                    return new global::Vellum.JsonConverters.V1FolderEntitiesGetParametersEntityStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.V1FolderEntitiesGetParametersEntityStatus?))
                {
                    return new global::Vellum.JsonConverters.V1FolderEntitiesGetParametersEntityStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.FolderEnum))
                {
                    return new global::Vellum.JsonConverters.FolderEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.FolderEnum?))
                {
                    return new global::Vellum.JsonConverters.FolderEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.PromptSandboxEnum))
                {
                    return new global::Vellum.JsonConverters.PromptSandboxEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.PromptSandboxEnum?))
                {
                    return new global::Vellum.JsonConverters.PromptSandboxEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DocumentIndexEnum))
                {
                    return new global::Vellum.JsonConverters.DocumentIndexEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DocumentIndexEnum?))
                {
                    return new global::Vellum.JsonConverters.DocumentIndexEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteEnum))
                {
                    return new global::Vellum.JsonConverters.TestSuiteEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteEnum?))
                {
                    return new global::Vellum.JsonConverters.TestSuiteEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DatasetEnum))
                {
                    return new global::Vellum.JsonConverters.DatasetEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DatasetEnum?))
                {
                    return new global::Vellum.JsonConverters.DatasetEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SecretTypeEnum))
                {
                    return new global::Vellum.JsonConverters.SecretTypeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SecretTypeEnum?))
                {
                    return new global::Vellum.JsonConverters.SecretTypeEnumNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[3];

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
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}