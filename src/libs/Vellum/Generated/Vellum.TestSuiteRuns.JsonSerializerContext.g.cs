
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.ChatMessageRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.NamedTestCaseVariableValueRequest>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumValueRequest?), TypeInfoPropertyName = "NullableVellumValueRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultMetaSourceRequest?), TypeInfoPropertyName = "NullableSearchResultMetaSourceRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NamedTestCaseVariableValueRequest?), TypeInfoPropertyName = "NullableNamedTestCaseVariableValueRequest2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricStringOutputTypeEnum?), TypeInfoPropertyName = "NullableTestSuiteRunMetricStringOutputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricNumberOutputTypeEnum?), TypeInfoPropertyName = "NullableTestSuiteRunMetricNumberOutputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricJSONOutputTypeEnum?), TypeInfoPropertyName = "NullableTestSuiteRunMetricJSONOutputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricErrorOutputTypeEnum?), TypeInfoPropertyName = "NullableTestSuiteRunMetricErrorOutputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricArrayOutputTypeEnum?), TypeInfoPropertyName = "NullableTestSuiteRunMetricArrayOutputTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteRunMetricOutput?), TypeInfoPropertyName = "NullableTestSuiteRunMetricOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ArrayChatMessageContentItemRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ChatMessageRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.VellumValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ArrayChatMessageContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.SearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.VellumValueRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.SearchResultRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.NamedTestCaseVariableValueRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ExternalTestCaseExecutionRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.NamedTestCaseVariableValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ExternalTestCaseExecution>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.TestSuiteRunMetricOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.TestSuiteRunExecutionOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.TestSuiteRunExecutionMetricResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.TestSuiteRunExecution>))]
    internal sealed partial class TestSuiteRunsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TestSuiteRunsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TestSuiteRunsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TestSuiteRunsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vellum.JsonConverters.ArrayChatMessageContentItemRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.ChatMessageContentRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.ArrayChatMessageContentItemJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.ChatMessageContentJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.SearchResultMetaSourceJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.VellumValueJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.SearchResultMetaSourceRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.VellumValueRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.NamedTestCaseVariableValueRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.TestSuiteRunExecConfigRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.NamedTestCaseVariableValueJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.TestSuiteRunExecConfigJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.TestSuiteRunExecutionOutputJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.TestSuiteRunMetricOutputJsonConverter());
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

                    || typeToConvert == typeof(global::Vellum.TestSuiteRunMetricArrayOutputTypeEnum?);
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
                    0 => new TestSuiteRunsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}