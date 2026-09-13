
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.PromptDeploymentInputRequest>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutePromptApiErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CompilePromptDeploymentExpandMetaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeploymentProviderPayloadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeploymentProviderPayloadResponsePayload), TypeInfoPropertyName = "DeploymentProviderPayloadResponsePayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CompilePromptMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeploymentProviderPayloadResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ErrorEnum?), TypeInfoPropertyName = "NullableErrorEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumErrorCodeEnum?), TypeInfoPropertyName = "NullableVellumErrorCodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ThinkingEnum?), TypeInfoPropertyName = "NullableThinkingEnum2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.V1DeploymentsGetParametersStatus?), TypeInfoPropertyName = "NullableV1DeploymentsGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SandboxEnum?), TypeInfoPropertyName = "NullableSandboxEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptVersionBuildConfig?), TypeInfoPropertyName = "NullablePromptVersionBuildConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReleaseTagSource?), TypeInfoPropertyName = "NullableReleaseTagSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReleaseReviewState?), TypeInfoPropertyName = "NullableReleaseReviewState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.V1DeploymentsIdReleaseTagsGetParametersSource?), TypeInfoPropertyName = "NullableV1DeploymentsIdReleaseTagsGetParametersSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ArrayChatMessageContentItemRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ChatMessageRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.PromptDeploymentInputRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.VellumValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ArrayChatMessageContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.SearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.VellumVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.SlimDeploymentRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.ReleaseReleaseTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.SlimReleaseReview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.DeploymentReleaseTagRead>))]
    internal sealed partial class DeploymentsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeploymentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DeploymentsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DeploymentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vellum.JsonConverters.PromptDeploymentInputRequestJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.DeploymentProviderPayloadResponsePayloadJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.ArrayChatMessageContentItemJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.ChatMessageContentJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.SearchResultMetaSourceJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.VellumValueJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.PromptVersionBuildConfigJsonConverter());
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

                    || typeToConvert == typeof(global::Vellum.V1DeploymentsIdReleaseTagsGetParametersSource?);
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
                    0 => new DeploymentsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}