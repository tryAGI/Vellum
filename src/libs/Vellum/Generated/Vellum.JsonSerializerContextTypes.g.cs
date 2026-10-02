
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
        public global::Vellum.VellumVariableType? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NumberEnum? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NumberVellumValue? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumAudio? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.AudioVellumValue? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumVideo? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VideoVellumValue? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumImage? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ImageVellumValue? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumDocument? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentVellumValue? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ArrayVellumValue? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.VellumValue>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumValue? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.StringChatMessageContent? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FunctionCallChatMessageContentValue? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FunctionCallChatMessageContent? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.AudioChatMessageContent? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VideoChatMessageContent? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ImageChatMessageContent? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentChatMessageContent? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ArrayChatMessageContentItem? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ArrayChatMessageContent? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.ArrayChatMessageContentItem>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ChatMessageContent? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ChatMessage? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ChatHistoryVellumValue? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.ChatMessage>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultsEnum? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultDocument? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PdfEnum? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PdfSearchResultMetaSource? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultMetaSource? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultMeta? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResult? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultsVellumValue? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SearchResult>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumVariableExtensions? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumVariable? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptParameters? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptSettings? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.JinjaEnum? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptBlockState? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.EphemeralPromptCacheConfigTypeEnum? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.EphemeralPromptCacheConfig? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.JinjaPromptBlock? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ChatMessageEnum? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ChatMessagePromptBlock? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.PromptBlock>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptBlock? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VariableEnum? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VariablePromptBlock? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.RichTextEnum? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PlainTextEnum? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PlainTextPromptBlock? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.RichTextChildBlock? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.RichTextPromptBlock? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.RichTextChildBlock>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FunctionCallPromptBlock? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.AudioPromptBlock? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VideoPromptBlock? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ImagePromptBlock? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentPromptBlock? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FunctionDefinition? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptExecConfig? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.VellumVariable>? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.FunctionDefinition>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DeploySandboxPromptRequest? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.EntityStatus? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.EnvironmentEnum? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DeploymentRead? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedScenarioInputStringVariableValueRequest? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedScenarioInputJsonVariableValueRequest? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedScenarioInputAudioVariableValueRequest? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedScenarioInputVideoVariableValueRequest? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedScenarioInputImageVariableValueRequest? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedScenarioInputDocumentVariableValueRequest? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedScenarioInputRequest? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.UpsertSandboxScenarioRequest? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.NamedScenarioInputRequest>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ScenarioInputStringVariableValue? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ScenarioInputJsonVariableValue? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ScenarioInputChatHistoryVariableValue? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ScenarioInputAudioVariableValue? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ScenarioInputVideoVariableValue? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ScenarioInputImageVariableValue? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ScenarioInputDocumentVariableValue? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ScenarioInput? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SandboxScenario? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.ScenarioInput>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SandboxesDeleteSandboxScenarioResponse204? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.V1DeploymentsGetParametersStatus? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SlimDeploymentRead? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PaginatedSlimDeploymentReadList? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SlimDeploymentRead>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReleaseEnvironment? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReleaseCreatedBy? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SandboxEnum? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptVersionBuildConfigSandbox? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptVersionBuildConfig? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptDeploymentReleasePromptVersion? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptDeploymentReleasePromptDeployment? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReleaseTagSource? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReleaseReleaseTag? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReleaseReviewReviewer? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReleaseReviewState? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SlimReleaseReview? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptDeploymentRelease? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.ReleaseReleaseTag>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SlimReleaseReview>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DeploymentReleaseTagDeploymentHistoryItem? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReleaseTagRelease? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DeploymentReleaseTagRead? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.V1DeploymentsIdReleaseTagsGetParametersSource? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PaginatedDeploymentReleaseTagReadList? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.DeploymentReleaseTagRead>? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PatchedDeploymentReleaseTagUpdateRequest? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DeploymentHistoryItem? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestStringInputRequest? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestJSONInputRequest? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestChatHistoryInputRequest? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestNumberInputRequest? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestAudioInputRequest? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestVideoInputRequest? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestImageInputRequest? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestDocumentInputRequest? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowRequestInputRequest? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExpandMetaRequest? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecuteWorkflowRequest? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowRequestInputRequest>? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputString? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputNumber? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputJSON? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputChatHistory? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputSearchResults? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputArray? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputError? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputFunctionCall? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputImage? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputAudio? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputVideo? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutputDocument? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowOutput? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FulfilledExecuteWorkflowWorkflowResultEvent? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowOutput>? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowEventErrorRawData? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionEventErrorCode? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowEventError? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.RejectedExecuteWorkflowWorkflowResultEvent? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecuteWorkflowWorkflowResultEvent? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecuteWorkflowResponse? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecuteWorkflowErrorResponse? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecuteWorkflowAsyncRequest? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecuteWorkflowAsyncResponse? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecuteWorkflowStreamErrorResponse? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionEventType? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecuteWorkflowStreamRequest? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowExecutionEventType>? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowEnum? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEventState? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowNodeResultEventState? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEventOutputDataString? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEventOutputDataNumber? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEventOutputDataJSON? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEventOutputDataChatHistory? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEventOutputDataSearchResults? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEventOutputDataArray? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEventOutputDataFunctionCall? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEventOutputDataError? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEventOutputData? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionStringVellumValue? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionNumberVellumValue? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionJsonVellumValue? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionChatHistoryVellumValue? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionSearchResultsVellumValue? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionErrorVellumValue? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionArrayVellumValue? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionFunctionCallVellumValue? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionThinkingVellumValue? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionAudioVellumValue? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionVideoVellumValue? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionImageVellumValue? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionDocumentVellumValue? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecutionVellumValue? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowResultEvent? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.ExecutionVellumValue>? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionWorkflowResultEvent? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeEnum? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptEnum? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptNodeExecutionMeta? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptNodeResultData? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptNodeResult? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchEnum? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchNodeResultData? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchNodeResult? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingEnum? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeStringResult? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeNumberResult? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeJsonResult? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeChatHistoryResult? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeSearchResultsResult? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeErrorResult? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeArrayResult? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeFunctionCallResult? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeResultOutput? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeResultData? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TemplatingNodeResult? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionEnum? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeStringResult? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeNumberResult? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeJsonResult? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeChatHistoryResult? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeSearchResultsResult? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeErrorResult? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeArrayResult? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeFunctionCallResult? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeResultOutput? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeResultData? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeExecutionNodeResult? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ConditionalEnum? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ConditionalNodeResultData? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ConditionalNodeResult? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ApiEnum? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ApiNodeResultData? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ApiNodeResult? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalEnum? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeStringResult? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeNumberResult? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeJsonResult? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeChatHistoryResult? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeSearchResultsResult? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeErrorResult? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeArrayResult? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeFunctionCallResult? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeResultOutput? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeResultData? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TerminalNodeResult? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MergeEnum? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MergeNodeResultData? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MergeNodeResult? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SubworkflowEnum? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SubworkflowNodeResultData? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SubworkflowNodeResult? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MetricEnum? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MetricNodeResult? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MapEnum? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.IterationStateEnum? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MapNodeResultData? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MapNodeResult? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowNodeResultData? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledStringValue? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledNumberValue? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledJsonValue? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledChatHistoryValue? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledSearchResultsValue? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledErrorValue? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledArrayValue? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledFunctionCallValue? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SecretEnum? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumSecret? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledSecretValue? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledAudioValue? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledVideoValue? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledImageValue? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputCompiledDocumentValue? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeInputVariableCompiledValue? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.InitiatedWorkflowNodeResultEvent? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.NodeInputVariableCompiledValue>? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeOutputCompiledStringValue? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeOutputCompiledNumberValue? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeOutputCompiledJsonValue? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeOutputCompiledChatHistoryValue? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeOutputCompiledSearchResultsValue? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeOutputCompiledErrorValue? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeOutputCompiledArrayValue? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeOutputCompiledFunctionCallValue? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeOutputCompiledThinkingValue? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeOutputCompiledValue? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.StreamingWorkflowNodeResultEvent? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FulfilledWorkflowNodeResultEvent? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.NodeOutputCompiledValue>? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.RejectedWorkflowNodeResultEvent? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowNodeResultEvent? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionNodeResultEvent? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowStreamEvent? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CheckWorkflowExecutionStatusError? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CheckWorkflowExecutionStatusResponse? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CheckWorkflowExecutionStatusErrorResponse? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionActualStringRequest? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionActualJsonRequest? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionActualChatHistoryRequest? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SubmitWorkflowExecutionActualRequest? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SubmitWorkflowExecutionActualsRequest? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SubmitWorkflowExecutionActualRequest>? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SubmitWorkflowExecutionActualsResponse200? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DeploySandboxWorkflowRequest? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowDisplayIcon? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowDeploymentDisplayData? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowDeploymentRead? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExecuteWorkflowDeploymentStreamRequest? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SpanLinkTypeEnum? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SpanLink? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ParentContext? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumCodeResourceDefinition? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowParentContext? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SpanLink>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowNodeEnum? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeParentContext? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowReleaseTagEnum? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowDeploymentParentContext? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowSandboxEnum? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowSandboxParentContext? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptReleaseTagEnum? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptDeploymentParentContext? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ApiRequestEnum? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ApiActorTypeEnum? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.APIRequestParentContext? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExternalEnum? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExternalParentContext? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ScheduledEnum? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ScheduledTriggerContext? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.IntegrationEnum? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.IntegrationTriggerContext? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionInitiatedEnum? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionInitiatedBody? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ApiVersionEnum? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionInitiatedEvent? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionStreamingEnum? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.BaseOutput? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionStreamingBody? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionStreamingEvent? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionFulfilledEnum? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.InvokedPort? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionFulfilledBody? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.InvokedPort>? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionFulfilledEvent? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionRejectedEnum? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumSdkErrorRawData? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumSdkErrorCodeEnum? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumSdkError? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionRejectedBody? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionRejectedEvent? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionPausedEnum? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionPausedBody? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionPausedEvent? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionResumedEnum? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionResumedBody? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionResumedEvent? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionLogEnum? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SeverityEnum? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionLogBody? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionLogEvent? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionInitiatedEnum? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionInitiatedBody? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionInitiatedEvent? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionStreamingEnum? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionStreamingBody? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionStreamingEvent? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionRejectedEnum? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionRejectedBody? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionRejectedEvent? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionFulfilledEnum? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionFulfilledBody? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionFulfilledEvent? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionPausedEnum? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CodeResourceDefinition? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExternalInputDescriptor? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.CodeResourceDefinition>? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionPausedBody? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.ExternalInputDescriptor>? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionPausedEvent? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionResumedEnum? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionResumedBody? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionResumedEvent? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionSnapshottedEnum? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionSnapshottedBody? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionSnapshottedEvent? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowEvent? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.V1WorkflowDeploymentsGetParametersStatus? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SlimWorkflowDeployment? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PaginatedSlimWorkflowDeploymentList? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SlimWorkflowDeployment>? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.IntegrationName? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowIntegrationDependency? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ModelProviderEnum? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MLModelHostingInterface? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowModelProviderDependency? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowDependency? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowDeploymentReleaseWorkflowVersion? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowDependency>? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowDeploymentReleaseWorkflowDeployment? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowDeploymentRelease? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PaginatedWorkflowDeploymentReleaseList? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowDeploymentRelease>? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowReleaseTagWorkflowDeploymentHistoryItem? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowReleaseTagRead? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.V1WorkflowDeploymentsIdReleaseTagsGetParametersSource? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PaginatedWorkflowReleaseTagReadList? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowReleaseTagRead>? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PatchedWorkflowReleaseTagUpdateRequest? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowDeploymentHistoryItem? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowInitializationError? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowError? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MLModelUsageWrapper? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionUsageCalculationErrorCodeEnum? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionUsageCalculationError? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionUsageResult? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.MLModelUsageWrapper>? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.Price>? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionActual? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionViewOnlineEvalMetricResult? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SlimWorkflowExecutionRead? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowExecutionUsageResult>? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowExecutionViewOnlineEvalMetricResult>? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowDeploymentEventExecutionsResponse? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SlimWorkflowExecutionRead>? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionEnum? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumWorkflowExecutionEvent? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionSpanAttributes? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionUsageCalculationFulfilledBody? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionSpan? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.VellumWorkflowExecutionEvent>? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionEnum? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumNodeExecutionEvent? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionSpanAttributes? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NodeExecutionSpan? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.VellumNodeExecutionEvent>? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumSpan? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowEventExecutionRead? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.VellumSpan>? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ErrorDetailResponse? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.UpdateActiveWorkspaceResponse? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowExecutionDetail? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowEvent>? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CreateWorkflowEventRequest? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.EventCreateResponse? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchWeightsRequest? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultMergingRequest? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MetadataFilterRuleCombinator? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.LogicalOperator? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MetadataFilterRuleRequest? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.MetadataFilterRuleRequest>? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MetadataFilterConfigRequest? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.LogicalConditionEnum? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.StringVellumValueRequest? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NumberVellumValueRequest? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.JsonVellumValueRequest? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.AudioVellumValueRequest? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VideoVellumValueRequest? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ImageVellumValueRequest? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentVellumValueRequest? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FunctionCallRequest? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FunctionCallVellumValueRequest? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumErrorRequest? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ErrorVellumValueRequest? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ArrayVellumValueRequest? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.VellumValueRequest>? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumValueRequest? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ChatHistoryVellumValueRequest? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultDocumentRequest? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PdfSearchResultMetaSourceRequest? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultMetaSourceRequest? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultMetaRequest? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultRequest? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResultsVellumValueRequest? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SearchResultRequest>? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ThinkingVellumValueRequest? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumValueLogicalConditionRequest? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.LogicalConditionGroupEnum? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ConditionCombinator? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumValueLogicalConditionGroupRequest? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.VellumValueLogicalExpressionRequest>? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VellumValueLogicalExpressionRequest? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.MetadataFiltersRequest? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchFiltersRequest? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchRequestOptionsRequest? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchRequestBodyRequest? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchResponse? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SearchErrorResponse? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexesAddDocumentResponse204? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.OpenAIVectorizerConfigRequest? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TextEmbedding3SmallEnum? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TextEmbedding3LargeEnum? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TextEmbeddingAda002Enum? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.IntfloatMultilingualE5LargeEnum? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SentenceTransformersMultiQaMpnetBaseCosV1Enum? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SentenceTransformersMultiQaMpnetBaseDotV1Enum? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.HkunlpInstructorXlEnum? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.InstructorVectorizerConfigRequest? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.HkunlpInstructorXlVectorizerRequest? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TextEmbedding004Enum? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.GoogleVertexAIVectorizerConfigRequest? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TextMultilingualEmbedding002Enum? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.GeminiEmbedding001Enum? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.BaaiBgeSmallEnV15Enum? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PrivateVectorizerEnum? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PrivateVectorizerRequest? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.IndexingConfigVectorizerRequest? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReductoChunkerEnum? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReductoChunkerConfigRequest? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReductoChunkingRequest? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SentenceChunkerEnum? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SentenceChunkerConfigRequest? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SentenceChunkingRequest? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TokenOverlappingWindowChunkerEnum? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TokenOverlappingWindowChunkerConfigRequest? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TokenOverlappingWindowChunkingRequest? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DelimiterChunkerEnum? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DelimiterChunkerConfigRequest? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DelimiterChunkingRequest? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexChunkingRequest? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexIndexingConfigRequest? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexCreateRequest? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.OpenAIVectorizerConfig? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.OpenAIVectorizerTextEmbedding3Small? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.OpenAIVectorizerTextEmbedding3Large? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.OpenAIVectorizerTextEmbeddingAda002? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.BasicVectorizerIntfloatMultilingualE5Large? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.InstructorVectorizerConfig? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.HkunlpInstructorXlVectorizer? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.GoogleVertexAIVectorizerConfig? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.GoogleVertexAIVectorizerTextEmbedding004? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PrivateVectorizer? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.IndexingConfigVectorizer? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReductoChunkerConfig? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReductoChunking? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SentenceChunkerConfig? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SentenceChunking? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TokenOverlappingWindowChunkerConfig? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TokenOverlappingWindowChunking? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DelimiterChunkerConfig? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DelimiterChunking? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexChunking? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexIndexingConfig? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexRead? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.V1DocumentIndexesGetParametersStatus? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PaginatedDocumentIndexReadList? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.DocumentIndexRead>? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PatchedDocumentIndexUpdateRequest? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexUpdateRequest? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexesDestroyResponse204? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexesRemoveDocumentResponse204? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.UploadDocumentResponse? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.UploadDocumentErrorResponse? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentProcessingState? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentStatus? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.IndexingStateEnum? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ProcessingFailureReasonEnum? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentDocumentToDocumentIndex? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentRead? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.DocumentDocumentToDocumentIndex>? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SlimDocumentDocumentToDocumentIndex? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SlimDocument? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SlimDocumentDocumentToDocumentIndex>? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PaginatedSlimDocumentList? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.SlimDocument>? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentsDestroyResponse204? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.UploadedFileRead? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseStringVariableValue? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseNumberVariableValue? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseJsonVariableValue? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseChatHistoryVariableValue? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseSearchResultsVariableValue? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseErrorVariableValue? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseFunctionCallVariableValue? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseArrayVariableValue? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseAudioVariableValue? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseImageVariableValue? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseVideoVariableValue? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseDocumentVariableValue? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestCaseVariableValue? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCase? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.TestCaseVariableValue>? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PaginatedTestSuiteTestCaseList? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.TestSuiteTestCase>? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseStringVariableValueRequest? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseNumberVariableValueRequest? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseJsonVariableValueRequest? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseChatHistoryVariableValueRequest? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseSearchResultsVariableValueRequest? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseErrorVariableValueRequest? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseFunctionCallVariableValueRequest? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseArrayVariableValueRequest? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseAudioVariableValueRequest? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseVideoVariableValueRequest? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseImageVariableValueRequest? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseDocumentVariableValueRequest? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseVariableValueRequest? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.UpsertTestSuiteTestCaseRequest? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.NamedTestCaseVariableValueRequest>? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CreateEnum? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CreateTestSuiteTestCaseRequest? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReplaceEnum? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReplaceTestSuiteTestCaseRequest? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.UpsertEnum? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DeleteEnum? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseDeleteBulkOperationDataRequest? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseBulkOperationRequest? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.CreatedEnum? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseCreatedBulkResultData? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseCreatedBulkResult? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ReplacedEnum? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseReplacedBulkResultData? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseReplacedBulkResult? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DeletedEnum? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseDeletedBulkResultData? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseDeletedBulkResult? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseRejectedBulkResult? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteTestCaseBulkResult? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuitesDeleteTestSuiteTestCaseResponse204? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigTypeEnum? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigDataRequest? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunPromptSandboxExecConfigTypeEnum? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunPromptSandboxExecConfigDataRequest? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigTypeEnum? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigDataRequest? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigTypeEnum? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigDataRequest? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowSandboxExecConfigTypeEnum? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowSandboxExecConfigDataRequest? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnum? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigDataRequest? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExternalTestCaseExecutionRequest? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExternalExecConfigDataRequest? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.ExternalTestCaseExecutionRequest>? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExternalExecConfigTypeEnum? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExternalExecConfigRequest? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecConfigRequest? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunCreateRequest? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunTestSuite? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunState? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigData? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigData? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigData? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigData? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseStringVariableValue? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseNumberVariableValue? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseJsonVariableValue? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseChatHistoryVariableValue? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseSearchResultsVariableValue? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseErrorVariableValue? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseFunctionCallVariableValue? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseArrayVariableValue? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseAudioVariableValue? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseVideoVariableValue? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseImageVariableValue? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseDocumentVariableValue? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.NamedTestCaseVariableValue? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ExternalTestCaseExecution? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.NamedTestCaseVariableValue>? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExternalExecConfigData? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.ExternalTestCaseExecution>? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExternalExecConfig? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecConfig? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunProgress? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunRead? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionStringOutput? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionNumberOutput? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionJsonOutput? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionChatHistoryOutput? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionSearchResultsOutput? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionErrorOutput? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionFunctionCallOutput? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionArrayOutput? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionOutput? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricStringOutputTypeEnum? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricStringOutput? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricNumberOutputTypeEnum? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricNumberOutput? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricJSONOutputTypeEnum? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricJSONOutput? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricErrorOutputTypeEnum? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricErrorOutput? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricArrayOutputTypeEnum? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricArrayOutput? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunMetricOutput? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionMetricDefinition? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecutionMetricResult? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.TestSuiteRunMetricOutput>? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteRunExecution? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.TestSuiteRunExecutionOutput>? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.TestSuiteRunExecutionMetricResult>? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PaginatedTestSuiteRunExecutionList? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.TestSuiteRunExecution>? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.AddEntityToFolderRequest? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntitiesAddEntityToFolderResponse200? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.V1FolderEntitiesGetParametersEntityStatus? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEnum? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityFolderData? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityFolder? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PromptSandboxEnum? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityPromptSandboxData? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityPromptSandbox? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkflowSandboxDisplayData? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityWorkflowSandboxData? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityWorkflowSandbox? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentIndexEnum? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityDocumentIndexData? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityDocumentIndex? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.TestSuiteEnum? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityTestSuiteData? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityTestSuite? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DatasetEnum? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityDatasetData? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntityDataset? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FolderEntity? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PaginatedFolderEntityList? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.FolderEntity>? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.SecretTypeEnum? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.WorkspaceSecretRead? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PatchedWorkspaceSecretUpdateRequest? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.UploadRequest? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PartialUpdateRequest? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.TestSuiteTestCaseBulkOperationRequest>? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Vellum.TestSuiteTestCaseBulkResult>? Type840 { get; set; }

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
        public global::System.Collections.Generic.List<global::Vellum.PromptBlock>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.RichTextChildBlock>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.VellumVariable>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.FunctionDefinition>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.NamedScenarioInputRequest>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.ScenarioInput>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.SlimDeploymentRead>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.ReleaseReleaseTag>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.SlimReleaseReview>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.DeploymentReleaseTagRead>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.WorkflowRequestInputRequest>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.WorkflowOutput>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.WorkflowExecutionEventType>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.ExecutionVellumValue>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.NodeInputVariableCompiledValue>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.NodeOutputCompiledValue>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.SubmitWorkflowExecutionActualRequest>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.SpanLink>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.InvokedPort>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.CodeResourceDefinition>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.ExternalInputDescriptor>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.SlimWorkflowDeployment>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.WorkflowDependency>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.WorkflowDeploymentRelease>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.WorkflowReleaseTagRead>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.MLModelUsageWrapper>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.Price>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.WorkflowExecutionUsageResult>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.WorkflowExecutionViewOnlineEvalMetricResult>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.SlimWorkflowExecutionRead>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.VellumWorkflowExecutionEvent>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.VellumNodeExecutionEvent>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.VellumSpan>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.WorkflowEvent>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.MetadataFilterRuleRequest>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.VellumValueRequest>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.SearchResultRequest>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.VellumValueLogicalExpressionRequest>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.DocumentIndexRead>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.DocumentDocumentToDocumentIndex>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.SlimDocumentDocumentToDocumentIndex>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.SlimDocument>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.TestCaseVariableValue>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.TestSuiteTestCase>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.NamedTestCaseVariableValueRequest>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.ExternalTestCaseExecutionRequest>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.NamedTestCaseVariableValue>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.ExternalTestCaseExecution>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.TestSuiteRunMetricOutput>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.TestSuiteRunExecutionOutput>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.TestSuiteRunExecutionMetricResult>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.TestSuiteRunExecution>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.FolderEntity>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.TestSuiteTestCaseBulkOperationRequest>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Vellum.TestSuiteTestCaseBulkResult>? ListType65 { get; set; }
    }
}