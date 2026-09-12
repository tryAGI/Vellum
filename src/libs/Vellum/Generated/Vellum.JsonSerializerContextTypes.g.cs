
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.StringEnum? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.StringInputRequest? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.JsonEnum? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.JSONInputRequest? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ChatHistoryEnum? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ChatMessageRole? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.StringChatMessageContentRequest? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FunctionCallEnum? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FunctionCallChatMessageContentValueRequest? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FunctionCallChatMessageContentRequest? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ArrayEnum? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.AudioEnum? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumAudioRequest? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.AudioChatMessageContentRequest? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VideoEnum? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumVideoRequest? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VideoChatMessageContentRequest? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ImageEnum? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumImageRequest? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ImageChatMessageContentRequest? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentEnum? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumDocumentRequest? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentChatMessageContentRequest? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ArrayChatMessageContentItemRequest? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ArrayChatMessageContentRequest? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.ArrayChatMessageContentItemRequest>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ChatMessageContentRequest? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ChatMessageRequest? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ChatHistoryInputRequest? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.ChatMessageRequest>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.AudioInputRequest? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VideoInputRequest? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ImageInputRequest? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentInputRequest? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptDeploymentInputRequest? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptDeploymentExpandMetaRequest? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.RawPromptExecutionOverridesRequest? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutePromptRequest? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.PromptDeploymentInputRequest>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FinishReasonEnum? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MLModelUsage? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.UnitEnum? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.Price? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptExecutionMeta? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FulfilledEnum? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.StringVellumValue? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.JsonVellumValue? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ErrorEnum? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumErrorCodeEnum? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumError? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ErrorVellumValue? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FunctionCall? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FunctionCallVellumValue? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ThinkingEnum? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ThinkingVellumValue? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptOutput? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FulfilledExecutePromptResponse? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.PromptOutput>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.RejectedEnum? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.RejectedExecutePromptResponse? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutePromptResponse? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutePromptApiErrorResponse? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutePromptStreamRequest? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.InitiatedEnum? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.InitiatedPromptExecutionMeta? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.InitiatedExecutePromptEvent? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.StreamingEnum? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.StreamingPromptExecutionMeta? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.StreamingExecutePromptEvent? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FulfilledPromptExecutionMeta? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FulfilledExecutePromptEvent? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.RejectedPromptExecutionMeta? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.RejectedExecutePromptEvent? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutePromptEvent? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SubmitCompletionActualRequest? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SubmitCompletionActualsRequest? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SubmitCompletionActualRequest>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SubmitCompletionActualsResponse200? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SubmitCompletionActualsErrorResponse? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CompilePromptDeploymentExpandMetaRequest? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DeploymentProviderPayloadRequest? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DeploymentProviderPayloadResponsePayload? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CompilePromptMeta? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DeploymentProviderPayloadResponse? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DeploySandboxPromptRequest? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.EntityStatus? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.EnvironmentEnum? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumVariableType? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NumberEnum? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NumberVellumValue? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumAudio? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.AudioVellumValue? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumVideo? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VideoVellumValue? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumImage? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ImageVellumValue? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumDocument? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentVellumValue? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ArrayVellumValue? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.VellumValue>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumValue? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.StringChatMessageContent? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FunctionCallChatMessageContentValue? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FunctionCallChatMessageContent? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.AudioChatMessageContent? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VideoChatMessageContent? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ImageChatMessageContent? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentChatMessageContent? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ArrayChatMessageContentItem? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ArrayChatMessageContent? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.ArrayChatMessageContentItem>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ChatMessageContent? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ChatMessage? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ChatHistoryVellumValue? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.ChatMessage>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultsEnum? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultDocument? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PdfEnum? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PdfSearchResultMetaSource? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultMetaSource? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultMeta? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResult? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultsVellumValue? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SearchResult>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumVariableExtensions? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumVariable? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DeploymentRead? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.VellumVariable>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedScenarioInputStringVariableValueRequest? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedScenarioInputJsonVariableValueRequest? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedScenarioInputAudioVariableValueRequest? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedScenarioInputVideoVariableValueRequest? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedScenarioInputImageVariableValueRequest? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedScenarioInputDocumentVariableValueRequest? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedScenarioInputRequest? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.UpsertSandboxScenarioRequest? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.NamedScenarioInputRequest>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ScenarioInputStringVariableValue? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ScenarioInputJsonVariableValue? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ScenarioInputChatHistoryVariableValue? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ScenarioInputAudioVariableValue? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ScenarioInputVideoVariableValue? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ScenarioInputImageVariableValue? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ScenarioInputDocumentVariableValue? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ScenarioInput? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SandboxScenario? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.ScenarioInput>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SandboxesDeleteSandboxScenarioResponse204? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.V1DeploymentsGetParametersStatus? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SlimDeploymentRead? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PaginatedSlimDeploymentReadList? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SlimDeploymentRead>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReleaseEnvironment? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReleaseCreatedBy? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SandboxEnum? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptVersionBuildConfigSandbox? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptVersionBuildConfig? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptDeploymentReleasePromptVersion? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptDeploymentReleasePromptDeployment? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReleaseTagSource? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReleaseReleaseTag? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReleaseReviewReviewer? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReleaseReviewState? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SlimReleaseReview? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptDeploymentRelease? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.ReleaseReleaseTag>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SlimReleaseReview>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DeploymentReleaseTagDeploymentHistoryItem? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReleaseTagRelease? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DeploymentReleaseTagRead? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.V1DeploymentsIdReleaseTagsGetParametersSource? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PaginatedDeploymentReleaseTagReadList? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.DeploymentReleaseTagRead>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PatchedDeploymentReleaseTagUpdateRequest? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DeploymentHistoryItem? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestStringInputRequest? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestJSONInputRequest? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestChatHistoryInputRequest? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestNumberInputRequest? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestAudioInputRequest? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestVideoInputRequest? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestImageInputRequest? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestDocumentInputRequest? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestInputRequest? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExpandMetaRequest? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecuteWorkflowRequest? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowRequestInputRequest>? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputString? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputNumber? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputJSON? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputChatHistory? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputSearchResults? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputArray? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputError? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputFunctionCall? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputImage? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputAudio? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputVideo? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputDocument? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutput? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FulfilledExecuteWorkflowWorkflowResultEvent? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowOutput>? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowEventErrorRawData? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionEventErrorCode? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowEventError? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.RejectedExecuteWorkflowWorkflowResultEvent? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecuteWorkflowWorkflowResultEvent? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecuteWorkflowResponse? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecuteWorkflowErrorResponse? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecuteWorkflowAsyncRequest? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecuteWorkflowAsyncResponse? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecuteWorkflowStreamErrorResponse? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionEventType? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecuteWorkflowStreamRequest? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowExecutionEventType>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowEnum? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEventState? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowNodeResultEventState? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEventOutputDataString? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEventOutputDataNumber? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEventOutputDataJSON? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEventOutputDataChatHistory? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEventOutputDataSearchResults? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEventOutputDataArray? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEventOutputDataFunctionCall? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEventOutputDataError? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEventOutputData? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionStringVellumValue? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionNumberVellumValue? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionJsonVellumValue? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionChatHistoryVellumValue? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionSearchResultsVellumValue? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionErrorVellumValue? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionArrayVellumValue? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionFunctionCallVellumValue? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionThinkingVellumValue? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionAudioVellumValue? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionVideoVellumValue? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionImageVellumValue? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionDocumentVellumValue? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionVellumValue? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEvent? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.ExecutionVellumValue>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionWorkflowResultEvent? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeEnum? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptEnum? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptNodeExecutionMeta? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptNodeResultData? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptNodeResult? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchEnum? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchNodeResultData? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchNodeResult? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingEnum? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeStringResult? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeNumberResult? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeJsonResult? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeChatHistoryResult? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeSearchResultsResult? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeErrorResult? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeArrayResult? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeFunctionCallResult? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeResultOutput? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeResultData? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeResult? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionEnum? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeStringResult? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeNumberResult? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeJsonResult? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeChatHistoryResult? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeSearchResultsResult? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeErrorResult? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeArrayResult? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeFunctionCallResult? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeResultOutput? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeResultData? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeResult? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ConditionalEnum? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ConditionalNodeResultData? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ConditionalNodeResult? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ApiEnum? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ApiNodeResultData? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ApiNodeResult? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalEnum? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeStringResult? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeNumberResult? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeJsonResult? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeChatHistoryResult? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeSearchResultsResult? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeErrorResult? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeArrayResult? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeFunctionCallResult? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeResultOutput? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeResultData? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeResult? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MergeEnum? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MergeNodeResultData? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MergeNodeResult? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SubworkflowEnum? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SubworkflowNodeResultData? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SubworkflowNodeResult? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MetricEnum? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MetricNodeResult? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MapEnum? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.IterationStateEnum? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MapNodeResultData? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MapNodeResult? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowNodeResultData? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledStringValue? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledNumberValue? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledJsonValue? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledChatHistoryValue? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledSearchResultsValue? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledErrorValue? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledArrayValue? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledFunctionCallValue? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SecretEnum? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumSecret? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledSecretValue? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledAudioValue? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledVideoValue? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledImageValue? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledDocumentValue? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputVariableCompiledValue? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.InitiatedWorkflowNodeResultEvent? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.NodeInputVariableCompiledValue>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeOutputCompiledStringValue? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeOutputCompiledNumberValue? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeOutputCompiledJsonValue? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeOutputCompiledChatHistoryValue? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeOutputCompiledSearchResultsValue? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeOutputCompiledErrorValue? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeOutputCompiledArrayValue? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeOutputCompiledFunctionCallValue? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeOutputCompiledThinkingValue? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeOutputCompiledValue? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.StreamingWorkflowNodeResultEvent? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FulfilledWorkflowNodeResultEvent? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.NodeOutputCompiledValue>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.RejectedWorkflowNodeResultEvent? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowNodeResultEvent? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionNodeResultEvent? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowStreamEvent? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CheckWorkflowExecutionStatusError? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CheckWorkflowExecutionStatusResponse? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CheckWorkflowExecutionStatusErrorResponse? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionActualStringRequest? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionActualJsonRequest? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionActualChatHistoryRequest? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SubmitWorkflowExecutionActualRequest? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SubmitWorkflowExecutionActualsRequest? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SubmitWorkflowExecutionActualRequest>? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SubmitWorkflowExecutionActualsResponse200? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DeploySandboxWorkflowRequest? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowDisplayIcon? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowDeploymentDisplayData? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowDeploymentRead? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecuteWorkflowDeploymentStreamRequest? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SpanLinkTypeEnum? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SpanLink? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ParentContext? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumCodeResourceDefinition? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowParentContext? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SpanLink>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowNodeEnum? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeParentContext? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowReleaseTagEnum? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowDeploymentParentContext? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowSandboxEnum? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowSandboxParentContext? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptReleaseTagEnum? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptDeploymentParentContext? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ApiRequestEnum? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ApiActorTypeEnum? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.APIRequestParentContext? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExternalEnum? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExternalParentContext? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ScheduledEnum? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ScheduledTriggerContext? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.IntegrationEnum? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.IntegrationTriggerContext? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionInitiatedEnum? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionInitiatedBody? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ApiVersionEnum? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionInitiatedEvent? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionStreamingEnum? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.BaseOutput? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionStreamingBody? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionStreamingEvent? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionFulfilledEnum? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.InvokedPort? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionFulfilledBody? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.InvokedPort>? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionFulfilledEvent? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionRejectedEnum? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumSdkErrorRawData? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumSdkErrorCodeEnum? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumSdkError? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionRejectedBody? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionRejectedEvent? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionPausedEnum? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionPausedBody? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionPausedEvent? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionResumedEnum? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionResumedBody? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionResumedEvent? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionLogEnum? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SeverityEnum? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionLogBody? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionLogEvent? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionInitiatedEnum? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionInitiatedBody? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionInitiatedEvent? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionStreamingEnum? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionStreamingBody? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionStreamingEvent? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionRejectedEnum? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionRejectedBody? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionRejectedEvent? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionFulfilledEnum? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionFulfilledBody? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionFulfilledEvent? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionPausedEnum? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeResourceDefinition? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExternalInputDescriptor? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.CodeResourceDefinition>? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionPausedBody? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.ExternalInputDescriptor>? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionPausedEvent? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionResumedEnum? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionResumedBody? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionResumedEvent? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionSnapshottedEnum? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionSnapshottedBody? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionSnapshottedEvent? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowEvent? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.V1WorkflowDeploymentsGetParametersStatus? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SlimWorkflowDeployment? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PaginatedSlimWorkflowDeploymentList? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SlimWorkflowDeployment>? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.IntegrationName? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowIntegrationDependency? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ModelProviderEnum? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MLModelHostingInterface? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowModelProviderDependency? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowDependency? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowDeploymentReleaseWorkflowVersion? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowDependency>? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowDeploymentReleaseWorkflowDeployment? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowDeploymentRelease? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PaginatedWorkflowDeploymentReleaseList? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowDeploymentRelease>? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowReleaseTagWorkflowDeploymentHistoryItem? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowReleaseTagRead? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.V1WorkflowDeploymentsIdReleaseTagsGetParametersSource? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PaginatedWorkflowReleaseTagReadList? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowReleaseTagRead>? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PatchedWorkflowReleaseTagUpdateRequest? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowDeploymentHistoryItem? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowInitializationError? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowError? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MLModelUsageWrapper? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionUsageCalculationErrorCodeEnum? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionUsageCalculationError? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionUsageResult? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.MLModelUsageWrapper>? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.Price>? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionActual? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionViewOnlineEvalMetricResult? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SlimWorkflowExecutionRead? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowExecutionUsageResult>? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowExecutionViewOnlineEvalMetricResult>? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowDeploymentEventExecutionsResponse? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SlimWorkflowExecutionRead>? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionEnum? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumWorkflowExecutionEvent? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionSpanAttributes? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionUsageCalculationFulfilledBody? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionSpan? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.VellumWorkflowExecutionEvent>? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionEnum? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumNodeExecutionEvent? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionSpanAttributes? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionSpan? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.VellumNodeExecutionEvent>? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumSpan? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowEventExecutionRead? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.VellumSpan>? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ErrorDetailResponse? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.UpdateActiveWorkspaceResponse? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionDetail? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowEvent>? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CreateWorkflowEventRequest? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.EventCreateResponse? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchWeightsRequest? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultMergingRequest? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MetadataFilterRuleCombinator? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.LogicalOperator? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MetadataFilterRuleRequest? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.MetadataFilterRuleRequest>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MetadataFilterConfigRequest? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.LogicalConditionEnum? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.StringVellumValueRequest? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NumberVellumValueRequest? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.JsonVellumValueRequest? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.AudioVellumValueRequest? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VideoVellumValueRequest? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ImageVellumValueRequest? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentVellumValueRequest? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FunctionCallRequest? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FunctionCallVellumValueRequest? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumErrorRequest? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ErrorVellumValueRequest? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ArrayVellumValueRequest? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.VellumValueRequest>? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumValueRequest? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ChatHistoryVellumValueRequest? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultDocumentRequest? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PdfSearchResultMetaSourceRequest? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultMetaSourceRequest? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultMetaRequest? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultRequest? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultsVellumValueRequest? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SearchResultRequest>? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ThinkingVellumValueRequest? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumValueLogicalConditionRequest? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.LogicalConditionGroupEnum? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ConditionCombinator? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumValueLogicalConditionGroupRequest? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.VellumValueLogicalExpressionRequest>? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumValueLogicalExpressionRequest? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MetadataFiltersRequest? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchFiltersRequest? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchRequestOptionsRequest? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchRequestBodyRequest? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResponse? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchErrorResponse? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexesAddDocumentResponse204? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.OpenAIVectorizerConfigRequest? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TextEmbedding3SmallEnum? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TextEmbedding3LargeEnum? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TextEmbeddingAda002Enum? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.IntfloatMultilingualE5LargeEnum? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SentenceTransformersMultiQaMpnetBaseCosV1Enum? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SentenceTransformersMultiQaMpnetBaseDotV1Enum? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.HkunlpInstructorXlEnum? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.InstructorVectorizerConfigRequest? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.HkunlpInstructorXlVectorizerRequest? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TextEmbedding004Enum? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.GoogleVertexAIVectorizerConfigRequest? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TextMultilingualEmbedding002Enum? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.GeminiEmbedding001Enum? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.BaaiBgeSmallEnV15Enum? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PrivateVectorizerEnum? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PrivateVectorizerRequest? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.IndexingConfigVectorizerRequest? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReductoChunkerEnum? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReductoChunkerConfigRequest? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReductoChunkingRequest? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SentenceChunkerEnum? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SentenceChunkerConfigRequest? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SentenceChunkingRequest? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TokenOverlappingWindowChunkerEnum? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TokenOverlappingWindowChunkerConfigRequest? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TokenOverlappingWindowChunkingRequest? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DelimiterChunkerEnum? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DelimiterChunkerConfigRequest? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DelimiterChunkingRequest? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexChunkingRequest? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexIndexingConfigRequest? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexCreateRequest? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.OpenAIVectorizerConfig? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.OpenAIVectorizerTextEmbedding3Small? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.OpenAIVectorizerTextEmbedding3Large? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.OpenAIVectorizerTextEmbeddingAda002? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.BasicVectorizerIntfloatMultilingualE5Large? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.InstructorVectorizerConfig? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.HkunlpInstructorXlVectorizer? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.GoogleVertexAIVectorizerConfig? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.GoogleVertexAIVectorizerTextEmbedding004? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PrivateVectorizer? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.IndexingConfigVectorizer? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReductoChunkerConfig? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReductoChunking? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SentenceChunkerConfig? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SentenceChunking? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TokenOverlappingWindowChunkerConfig? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TokenOverlappingWindowChunking? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DelimiterChunkerConfig? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DelimiterChunking? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexChunking? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexIndexingConfig? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexRead? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.V1DocumentIndexesGetParametersStatus? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PaginatedDocumentIndexReadList? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.DocumentIndexRead>? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PatchedDocumentIndexUpdateRequest? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexUpdateRequest? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexesDestroyResponse204? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexesRemoveDocumentResponse204? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.UploadDocumentResponse? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.UploadDocumentErrorResponse? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentProcessingState? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentStatus? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.IndexingStateEnum? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentDocumentToDocumentIndex? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentRead? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.DocumentDocumentToDocumentIndex>? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ProcessingFailureReasonEnum? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SlimDocumentDocumentToDocumentIndex? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SlimDocument? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SlimDocumentDocumentToDocumentIndex>? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PaginatedSlimDocumentList? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SlimDocument>? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentsDestroyResponse204? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.UploadedFileRead? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseStringVariableValue? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseNumberVariableValue? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseJsonVariableValue? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseChatHistoryVariableValue? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseSearchResultsVariableValue? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseErrorVariableValue? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseFunctionCallVariableValue? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseArrayVariableValue? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseAudioVariableValue? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseImageVariableValue? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseVideoVariableValue? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseDocumentVariableValue? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseVariableValue? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCase? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.TestCaseVariableValue>? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PaginatedTestSuiteTestCaseList? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.TestSuiteTestCase>? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseStringVariableValueRequest? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseNumberVariableValueRequest? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseJsonVariableValueRequest? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseChatHistoryVariableValueRequest? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseSearchResultsVariableValueRequest? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseErrorVariableValueRequest? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseFunctionCallVariableValueRequest? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseArrayVariableValueRequest? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseAudioVariableValueRequest? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseVideoVariableValueRequest? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseImageVariableValueRequest? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseDocumentVariableValueRequest? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseVariableValueRequest? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.UpsertTestSuiteTestCaseRequest? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.NamedTestCaseVariableValueRequest>? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CreateEnum? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CreateTestSuiteTestCaseRequest? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReplaceEnum? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReplaceTestSuiteTestCaseRequest? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.UpsertEnum? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DeleteEnum? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseDeleteBulkOperationDataRequest? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseBulkOperationRequest? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CreatedEnum? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseCreatedBulkResultData? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseCreatedBulkResult? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReplacedEnum? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseReplacedBulkResultData? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseReplacedBulkResult? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DeletedEnum? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseDeletedBulkResultData? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseDeletedBulkResult? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseRejectedBulkResult? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseBulkResult? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuitesDeleteTestSuiteTestCaseResponse204? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigTypeEnum? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigDataRequest? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunPromptSandboxExecConfigTypeEnum? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunPromptSandboxExecConfigDataRequest? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigTypeEnum? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigDataRequest? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigTypeEnum? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigDataRequest? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowSandboxExecConfigTypeEnum? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowSandboxExecConfigDataRequest? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnum? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigDataRequest? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExternalTestCaseExecutionRequest? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExternalExecConfigDataRequest? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.ExternalTestCaseExecutionRequest>? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExternalExecConfigTypeEnum? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExternalExecConfigRequest? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecConfigRequest? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunCreateRequest? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunTestSuite? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunState? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigData? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigData? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigData? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigData? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseStringVariableValue? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseNumberVariableValue? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseJsonVariableValue? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseChatHistoryVariableValue? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseSearchResultsVariableValue? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseErrorVariableValue? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseFunctionCallVariableValue? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseArrayVariableValue? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseAudioVariableValue? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseVideoVariableValue? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseImageVariableValue? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseDocumentVariableValue? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseVariableValue? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExternalTestCaseExecution? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.NamedTestCaseVariableValue>? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExternalExecConfigData? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.ExternalTestCaseExecution>? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExternalExecConfig? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecConfig? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunProgress? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunRead? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionStringOutput? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionNumberOutput? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionJsonOutput? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionChatHistoryOutput? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionSearchResultsOutput? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionErrorOutput? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionFunctionCallOutput? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionArrayOutput? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionOutput? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricStringOutputTypeEnum? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricStringOutput? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricNumberOutputTypeEnum? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricNumberOutput? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricJSONOutputTypeEnum? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricJSONOutput? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricErrorOutputTypeEnum? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricErrorOutput? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricArrayOutputTypeEnum? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricArrayOutput? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricOutput? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionMetricDefinition? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionMetricResult? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.TestSuiteRunMetricOutput>? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecution? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.TestSuiteRunExecutionOutput>? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.TestSuiteRunExecutionMetricResult>? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PaginatedTestSuiteRunExecutionList? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.TestSuiteRunExecution>? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.AddEntityToFolderRequest? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntitiesAddEntityToFolderResponse200? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.V1FolderEntitiesGetParametersEntityStatus? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEnum? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityFolderData? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityFolder? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptSandboxEnum? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityPromptSandboxData? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityPromptSandbox? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowSandboxDisplayData? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityWorkflowSandboxData? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityWorkflowSandbox? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexEnum? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityDocumentIndexData? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityDocumentIndex? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteEnum? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityTestSuiteData? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityTestSuite? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DatasetEnum? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityDatasetData? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityDataset? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntity? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PaginatedFolderEntityList? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.FolderEntity>? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SecretTypeEnum? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkspaceSecretRead? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PatchedWorkspaceSecretUpdateRequest? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.UploadRequest? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PartialUpdateRequest? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.TestSuiteTestCaseBulkOperationRequest>? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.TestSuiteTestCaseBulkResult>? Type812 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.ArrayChatMessageContentItemRequest>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.ChatMessageRequest>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.PromptDeploymentInputRequest>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.PromptOutput>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.SubmitCompletionActualRequest>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.VellumValue>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.ArrayChatMessageContentItem>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.ChatMessage>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.SearchResult>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.VellumVariable>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.NamedScenarioInputRequest>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.ScenarioInput>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.SlimDeploymentRead>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.ReleaseReleaseTag>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.SlimReleaseReview>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.DeploymentReleaseTagRead>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.WorkflowRequestInputRequest>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.WorkflowOutput>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.WorkflowExecutionEventType>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.ExecutionVellumValue>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.NodeInputVariableCompiledValue>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.NodeOutputCompiledValue>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.SubmitWorkflowExecutionActualRequest>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.SpanLink>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.InvokedPort>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.CodeResourceDefinition>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.ExternalInputDescriptor>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.SlimWorkflowDeployment>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.WorkflowDependency>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.WorkflowDeploymentRelease>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.WorkflowReleaseTagRead>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.MLModelUsageWrapper>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.Price>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.WorkflowExecutionUsageResult>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.WorkflowExecutionViewOnlineEvalMetricResult>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.SlimWorkflowExecutionRead>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.VellumWorkflowExecutionEvent>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.VellumNodeExecutionEvent>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.VellumSpan>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.WorkflowEvent>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.MetadataFilterRuleRequest>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.VellumValueRequest>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.SearchResultRequest>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.VellumValueLogicalExpressionRequest>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.DocumentIndexRead>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.DocumentDocumentToDocumentIndex>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.SlimDocumentDocumentToDocumentIndex>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.SlimDocument>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.TestCaseVariableValue>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.TestSuiteTestCase>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.NamedTestCaseVariableValueRequest>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.ExternalTestCaseExecutionRequest>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.NamedTestCaseVariableValue>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.ExternalTestCaseExecution>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.TestSuiteRunMetricOutput>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.TestSuiteRunExecutionOutput>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.TestSuiteRunExecutionMetricResult>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.TestSuiteRunExecution>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.FolderEntity>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.TestSuiteTestCaseBulkOperationRequest>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.TestSuiteTestCaseBulkResult>? ListType62 { get; set; }
    }
}