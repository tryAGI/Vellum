
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
            typeof(global::Vellum.JsonConverters.StringEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.StringEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.JsonEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.JsonEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ChatHistoryEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.ChatHistoryEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ChatMessageRoleJsonConverter),

            typeof(global::Vellum.JsonConverters.ChatMessageRoleNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.FunctionCallEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.FunctionCallEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ArrayEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.ArrayEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.AudioEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.AudioEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.VideoEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.VideoEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ImageEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.ImageEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.DocumentEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.DocumentEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.FinishReasonEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.FinishReasonEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.UnitEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.UnitEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.FulfilledEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.FulfilledEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ErrorEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.ErrorEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.VellumErrorCodeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.VellumErrorCodeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ThinkingEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.ThinkingEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.RejectedEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.RejectedEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.InitiatedEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.InitiatedEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.StreamingEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.StreamingEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.EntityStatusJsonConverter),

            typeof(global::Vellum.JsonConverters.EntityStatusNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.EnvironmentEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.EnvironmentEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.VellumVariableTypeJsonConverter),

            typeof(global::Vellum.JsonConverters.VellumVariableTypeNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.NumberEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.NumberEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.SearchResultsEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.SearchResultsEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.PdfEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.PdfEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.V1DeploymentsGetParametersStatusJsonConverter),

            typeof(global::Vellum.JsonConverters.V1DeploymentsGetParametersStatusNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.SandboxEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.SandboxEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ReleaseTagSourceJsonConverter),

            typeof(global::Vellum.JsonConverters.ReleaseTagSourceNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ReleaseReviewStateJsonConverter),

            typeof(global::Vellum.JsonConverters.ReleaseReviewStateNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.V1DeploymentsIdReleaseTagsGetParametersSourceJsonConverter),

            typeof(global::Vellum.JsonConverters.V1DeploymentsIdReleaseTagsGetParametersSourceNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionEventErrorCodeJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionEventErrorCodeNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionEventTypeJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionEventTypeNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowResultEventStateJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowResultEventStateNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowNodeResultEventStateJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowNodeResultEventStateNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.NodeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.NodeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.PromptEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.PromptEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.SearchEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.SearchEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TemplatingEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TemplatingEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.CodeExecutionEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.CodeExecutionEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ConditionalEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.ConditionalEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ApiEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.ApiEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TerminalEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TerminalEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.MergeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.MergeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.SubworkflowEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.SubworkflowEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.MetricEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.MetricEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.MapEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.MapEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.IterationStateEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.IterationStateEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.SecretEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.SecretEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.SpanLinkTypeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.SpanLinkTypeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowNodeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowNodeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowReleaseTagEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowReleaseTagEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowSandboxEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowSandboxEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.PromptReleaseTagEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.PromptReleaseTagEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ApiRequestEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.ApiRequestEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ApiActorTypeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.ApiActorTypeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ExternalEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.ExternalEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ScheduledEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.ScheduledEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.IntegrationEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.IntegrationEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.NodeExecutionInitiatedEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.NodeExecutionInitiatedEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ApiVersionEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.ApiVersionEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.NodeExecutionStreamingEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.NodeExecutionStreamingEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.NodeExecutionFulfilledEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.NodeExecutionFulfilledEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.NodeExecutionRejectedEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.NodeExecutionRejectedEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.VellumSdkErrorCodeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.VellumSdkErrorCodeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.NodeExecutionPausedEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.NodeExecutionPausedEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.NodeExecutionResumedEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.NodeExecutionResumedEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.NodeExecutionLogEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.NodeExecutionLogEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.SeverityEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.SeverityEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionInitiatedEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionInitiatedEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionStreamingEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionStreamingEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionRejectedEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionRejectedEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionFulfilledEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionFulfilledEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionPausedEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionPausedEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionResumedEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionResumedEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionSnapshottedEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionSnapshottedEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.V1WorkflowDeploymentsGetParametersStatusJsonConverter),

            typeof(global::Vellum.JsonConverters.V1WorkflowDeploymentsGetParametersStatusNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.IntegrationNameJsonConverter),

            typeof(global::Vellum.JsonConverters.IntegrationNameNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ModelProviderEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.ModelProviderEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.MLModelHostingInterfaceJsonConverter),

            typeof(global::Vellum.JsonConverters.MLModelHostingInterfaceNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.V1WorkflowDeploymentsIdReleaseTagsGetParametersSourceJsonConverter),

            typeof(global::Vellum.JsonConverters.V1WorkflowDeploymentsIdReleaseTagsGetParametersSourceNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionUsageCalculationErrorCodeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionUsageCalculationErrorCodeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowExecutionEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.NodeExecutionEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.NodeExecutionEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.MetadataFilterRuleCombinatorJsonConverter),

            typeof(global::Vellum.JsonConverters.MetadataFilterRuleCombinatorNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.LogicalOperatorJsonConverter),

            typeof(global::Vellum.JsonConverters.LogicalOperatorNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.LogicalConditionEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.LogicalConditionEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.LogicalConditionGroupEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.LogicalConditionGroupEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ConditionCombinatorJsonConverter),

            typeof(global::Vellum.JsonConverters.ConditionCombinatorNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TextEmbedding3SmallEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TextEmbedding3SmallEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TextEmbedding3LargeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TextEmbedding3LargeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TextEmbeddingAda002EnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TextEmbeddingAda002EnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.IntfloatMultilingualE5LargeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.IntfloatMultilingualE5LargeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.SentenceTransformersMultiQaMpnetBaseCosV1EnumJsonConverter),

            typeof(global::Vellum.JsonConverters.SentenceTransformersMultiQaMpnetBaseCosV1EnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.SentenceTransformersMultiQaMpnetBaseDotV1EnumJsonConverter),

            typeof(global::Vellum.JsonConverters.SentenceTransformersMultiQaMpnetBaseDotV1EnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.HkunlpInstructorXlEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.HkunlpInstructorXlEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TextEmbedding004EnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TextEmbedding004EnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TextMultilingualEmbedding002EnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TextMultilingualEmbedding002EnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.GeminiEmbedding001EnumJsonConverter),

            typeof(global::Vellum.JsonConverters.GeminiEmbedding001EnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.BaaiBgeSmallEnV15EnumJsonConverter),

            typeof(global::Vellum.JsonConverters.BaaiBgeSmallEnV15EnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.PrivateVectorizerEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.PrivateVectorizerEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ReductoChunkerEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.ReductoChunkerEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.SentenceChunkerEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.SentenceChunkerEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TokenOverlappingWindowChunkerEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TokenOverlappingWindowChunkerEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.DelimiterChunkerEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.DelimiterChunkerEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.V1DocumentIndexesGetParametersStatusJsonConverter),

            typeof(global::Vellum.JsonConverters.V1DocumentIndexesGetParametersStatusNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.DocumentProcessingStateJsonConverter),

            typeof(global::Vellum.JsonConverters.DocumentProcessingStateNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.DocumentStatusJsonConverter),

            typeof(global::Vellum.JsonConverters.DocumentStatusNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.IndexingStateEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.IndexingStateEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ProcessingFailureReasonEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.ProcessingFailureReasonEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.CreateEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.CreateEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ReplaceEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.ReplaceEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.UpsertEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.UpsertEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.DeleteEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.DeleteEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.CreatedEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.CreatedEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ReplacedEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.ReplacedEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.DeletedEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.DeletedEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunDeploymentReleaseTagExecConfigTypeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunDeploymentReleaseTagExecConfigTypeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunPromptSandboxExecConfigTypeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunPromptSandboxExecConfigTypeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunPromptSandboxHistoryItemExecConfigTypeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunPromptSandboxHistoryItemExecConfigTypeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunWorkflowReleaseTagExecConfigTypeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunWorkflowReleaseTagExecConfigTypeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunWorkflowSandboxExecConfigTypeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunWorkflowSandboxExecConfigTypeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunWorkflowSandboxHistoryItemExecConfigTypeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunExternalExecConfigTypeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunExternalExecConfigTypeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunStateJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunStateNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunMetricStringOutputTypeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunMetricStringOutputTypeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunMetricNumberOutputTypeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunMetricNumberOutputTypeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunMetricJSONOutputTypeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunMetricJSONOutputTypeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunMetricErrorOutputTypeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunMetricErrorOutputTypeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunMetricArrayOutputTypeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunMetricArrayOutputTypeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.V1FolderEntitiesGetParametersEntityStatusJsonConverter),

            typeof(global::Vellum.JsonConverters.V1FolderEntitiesGetParametersEntityStatusNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.FolderEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.FolderEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.PromptSandboxEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.PromptSandboxEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.DocumentIndexEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.DocumentIndexEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.DatasetEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.DatasetEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.SecretTypeEnumJsonConverter),

            typeof(global::Vellum.JsonConverters.SecretTypeEnumNullableJsonConverter),

            typeof(global::Vellum.JsonConverters.ArrayChatMessageContentItemRequestJsonConverter),

            typeof(global::Vellum.JsonConverters.ChatMessageContentRequestJsonConverter),

            typeof(global::Vellum.JsonConverters.PromptDeploymentInputRequestJsonConverter),

            typeof(global::Vellum.JsonConverters.PromptOutputJsonConverter),

            typeof(global::Vellum.JsonConverters.ExecutePromptResponseJsonConverter),

            typeof(global::Vellum.JsonConverters.ExecutePromptEventJsonConverter),

            typeof(global::Vellum.JsonConverters.DeploymentProviderPayloadResponsePayloadJsonConverter),

            typeof(global::Vellum.JsonConverters.ArrayChatMessageContentItemJsonConverter),

            typeof(global::Vellum.JsonConverters.ChatMessageContentJsonConverter),

            typeof(global::Vellum.JsonConverters.SearchResultMetaSourceJsonConverter),

            typeof(global::Vellum.JsonConverters.VellumValueJsonConverter),

            typeof(global::Vellum.JsonConverters.NamedScenarioInputRequestJsonConverter),

            typeof(global::Vellum.JsonConverters.ScenarioInputJsonConverter),

            typeof(global::Vellum.JsonConverters.PromptVersionBuildConfigJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowRequestInputRequestJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowOutputJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowEventErrorRawDataJsonConverter),

            typeof(global::Vellum.JsonConverters.ExecuteWorkflowWorkflowResultEventJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowResultEventOutputDataJsonConverter),

            typeof(global::Vellum.JsonConverters.ExecutionVellumValueJsonConverter),

            typeof(global::Vellum.JsonConverters.TemplatingNodeResultOutputJsonConverter),

            typeof(global::Vellum.JsonConverters.CodeExecutionNodeResultOutputJsonConverter),

            typeof(global::Vellum.JsonConverters.TerminalNodeResultOutputJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowNodeResultDataJsonConverter),

            typeof(global::Vellum.JsonConverters.NodeInputVariableCompiledValueJsonConverter),

            typeof(global::Vellum.JsonConverters.NodeOutputCompiledValueJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowNodeResultEventJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowStreamEventJsonConverter),

            typeof(global::Vellum.JsonConverters.SubmitWorkflowExecutionActualRequestJsonConverter),

            typeof(global::Vellum.JsonConverters.ParentContextJsonConverter),

            typeof(global::Vellum.JsonConverters.VellumSdkErrorRawDataJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowEventJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowDependencyJsonConverter),

            typeof(global::Vellum.JsonConverters.WorkflowErrorJsonConverter),

            typeof(global::Vellum.JsonConverters.VellumWorkflowExecutionEventJsonConverter),

            typeof(global::Vellum.JsonConverters.VellumNodeExecutionEventJsonConverter),

            typeof(global::Vellum.JsonConverters.VellumSpanJsonConverter),

            typeof(global::Vellum.JsonConverters.CreateWorkflowEventRequestJsonConverter),

            typeof(global::Vellum.JsonConverters.SearchResultMetaSourceRequestJsonConverter),

            typeof(global::Vellum.JsonConverters.VellumValueRequestJsonConverter),

            typeof(global::Vellum.JsonConverters.VellumValueLogicalExpressionRequestJsonConverter),

            typeof(global::Vellum.JsonConverters.MetadataFiltersRequestJsonConverter),

            typeof(global::Vellum.JsonConverters.IndexingConfigVectorizerRequestJsonConverter),

            typeof(global::Vellum.JsonConverters.DocumentIndexChunkingRequestJsonConverter),

            typeof(global::Vellum.JsonConverters.IndexingConfigVectorizerJsonConverter),

            typeof(global::Vellum.JsonConverters.DocumentIndexChunkingJsonConverter),

            typeof(global::Vellum.JsonConverters.TestCaseVariableValueJsonConverter),

            typeof(global::Vellum.JsonConverters.NamedTestCaseVariableValueRequestJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteTestCaseBulkOperationRequestJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteTestCaseBulkResultJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunExecConfigRequestJsonConverter),

            typeof(global::Vellum.JsonConverters.NamedTestCaseVariableValueJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunExecConfigJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunExecutionOutputJsonConverter),

            typeof(global::Vellum.JsonConverters.TestSuiteRunMetricOutputJsonConverter),

            typeof(global::Vellum.JsonConverters.FolderEntityJsonConverter),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ChatMessageContentRequest?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.PromptDeploymentExpandMetaRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.RawPromptExecutionOverridesRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FinishReasonEnum?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.MLModelUsage, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.Price, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumError, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FunctionCall, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.StringVellumValue, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.PromptDeploymentExpandMetaRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.RawPromptExecutionOverridesRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FinishReasonEnum?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.MLModelUsage, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.Price, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FinishReasonEnum?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.CompilePromptDeploymentExpandMetaRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.CompilePromptMeta, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumAudio, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumVideo, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumImage, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumDocument, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ChatMessageContent?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.SearchResultMetaSource?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.SearchResultMeta, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumValue?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumVariableExtensions, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.EnvironmentEnum?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumAudio, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumVideo, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumImage, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumDocument, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.EnvironmentEnum?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ReleaseCreatedBy, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowExpandMetaRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumError, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FunctionCall, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumImage, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumAudio, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumVideo, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumDocument, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowEventErrorRawData?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowExpandMetaRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FunctionCall, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumError, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumError, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FunctionCall, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.StringVellumValue, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumAudio, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumVideo, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumImage, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumDocument, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowResultEventOutputData?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowEventError, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.MLModelUsage, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.Price, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.PromptNodeExecutionMeta, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumError, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FunctionCall, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumError, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FunctionCall, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumError, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FunctionCall, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.IterationStateEnum?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumError, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FunctionCall, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumAudio, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumVideo, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumImage, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumDocument, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowNodeResultData?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumError, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FunctionCall, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.StringVellumValue, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowNodeResultData?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.NodeOutputCompiledValue?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowNodeResultData?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowNodeResultData?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowExecutionEventErrorCode?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.CheckWorkflowExecutionStatusError, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowDisplayIcon, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.EnvironmentEnum?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowDeploymentDisplayData, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ApiActorTypeEnum?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumSdkErrorRawData?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumCodeResourceDefinition, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.CodeResourceDefinition, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumCodeResourceDefinition, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.EnvironmentEnum?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ReleaseCreatedBy, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowExecutionUsageCalculationError, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowError?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowDeploymentParentContext, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowExecutionActual, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowExecutionUsageCalculationFulfilledBody, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowExecutionUsageCalculationFulfilledBody, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowError?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowDeploymentParentContext, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowExecutionActual, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowError?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.MetadataFilterRuleCombinator?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.LogicalOperator?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.MetadataFilterRuleCombinator?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.LogicalOperator?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumAudioRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumVideoRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumImageRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumDocumentRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FunctionCallRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumErrorRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.SearchResultMetaSourceRequest?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.SearchResultMetaRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.StringVellumValueRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.MetadataFiltersRequest?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.SearchWeightsRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.SearchResultMergingRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.SearchFiltersRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.SearchRequestOptionsRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.DocumentIndexChunkingRequest?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.DocumentIndexChunking?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ProcessingFailureReasonEnum?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumError, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FunctionCall, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumAudio, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumImage, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumVideo, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumDocument, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumErrorRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FunctionCallRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumAudioRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumVideoRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumImageRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumDocumentRequest, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumError, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FunctionCall, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumAudio, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumVideo, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumImage, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumDocument, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.TestSuiteRunExecConfig?, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumError, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FunctionCall, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowDisplayIcon, object>),

            typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowSandboxDisplayData, object>),

            typeof(global::Vellum.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.JsonSerializerContextTypes))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.ChatMessageContentRequest?, object>), TypeInfoPropertyName = "OneOfChatMessageContentRequestObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecutePromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.PromptDeploymentInputRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.PromptDeploymentExpandMetaRequest, object>), TypeInfoPropertyName = "OneOfPromptDeploymentExpandMetaRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.RawPromptExecutionOverridesRequest, object>), TypeInfoPropertyName = "OneOfRawPromptExecutionOverridesRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FinishReasonEnum), TypeInfoPropertyName = "FinishReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MLModelUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.UnitEnum), TypeInfoPropertyName = "UnitEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.Price))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptExecutionMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.FinishReasonEnum?, object>), TypeInfoPropertyName = "OneOfFinishReasonEnumObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.MLModelUsage, object>), TypeInfoPropertyName = "OneOfMLModelUsageObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.Price, object>), TypeInfoPropertyName = "OneOfPriceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FulfilledEnum), TypeInfoPropertyName = "FulfilledEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.StringVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.JsonVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ErrorEnum), TypeInfoPropertyName = "ErrorEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumErrorCodeEnum), TypeInfoPropertyName = "VellumErrorCodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ErrorVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.VellumError, object>), TypeInfoPropertyName = "OneOfVellumErrorObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FunctionCallVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.FunctionCall, object>), TypeInfoPropertyName = "OneOfFunctionCallObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ThinkingEnum), TypeInfoPropertyName = "ThinkingEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ThinkingVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.StringVellumValue, object>), TypeInfoPropertyName = "OneOfStringVellumValueObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.CompilePromptDeploymentExpandMetaRequest, object>), TypeInfoPropertyName = "OneOfCompilePromptDeploymentExpandMetaRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeploymentProviderPayloadResponsePayload), TypeInfoPropertyName = "DeploymentProviderPayloadResponsePayload2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CompilePromptMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeploymentProviderPayloadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.CompilePromptMeta, object>), TypeInfoPropertyName = "OneOfCompilePromptMetaObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeploySandboxPromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.EntityStatus), TypeInfoPropertyName = "EntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.EnvironmentEnum), TypeInfoPropertyName = "EnvironmentEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumVariableType), TypeInfoPropertyName = "VellumVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NumberEnum), TypeInfoPropertyName = "NumberEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NumberVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.AudioVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.VellumAudio, object>), TypeInfoPropertyName = "OneOfVellumAudioObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VideoVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.VellumVideo, object>), TypeInfoPropertyName = "OneOfVellumVideoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ImageVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.VellumImage, object>), TypeInfoPropertyName = "OneOfVellumImageObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.VellumDocument, object>), TypeInfoPropertyName = "OneOfVellumDocumentObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.ChatMessageContent?, object>), TypeInfoPropertyName = "OneOfChatMessageContentObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ChatHistoryVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultsEnum), TypeInfoPropertyName = "SearchResultsEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PdfEnum), TypeInfoPropertyName = "PdfEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PdfSearchResultMetaSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultMetaSource), TypeInfoPropertyName = "SearchResultMetaSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.SearchResultMetaSource?, object>), TypeInfoPropertyName = "OneOfSearchResultMetaSourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.SearchResultMeta, object>), TypeInfoPropertyName = "OneOfSearchResultMetaObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultsVellumValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.SearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumVariableExtensions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.VellumValue?, object>), TypeInfoPropertyName = "OneOfVellumValueObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.VellumVariableExtensions, object>), TypeInfoPropertyName = "OneOfVellumVariableExtensionsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DeploymentRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.EnvironmentEnum?, object>), TypeInfoPropertyName = "OneOfEnvironmentEnumObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.ReleaseCreatedBy, object>), TypeInfoPropertyName = "OneOfReleaseCreatedByObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.WorkflowExpandMetaRequest, object>), TypeInfoPropertyName = "OneOfWorkflowExpandMetaRequestObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.WorkflowEventErrorRawData?, object>), TypeInfoPropertyName = "OneOfWorkflowEventErrorRawDataObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.WorkflowResultEventOutputData?, object>), TypeInfoPropertyName = "OneOfWorkflowResultEventOutputDataObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.WorkflowEventError, object>), TypeInfoPropertyName = "OneOfWorkflowEventErrorObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.ExecutionVellumValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionWorkflowResultEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeEnum), TypeInfoPropertyName = "NodeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptEnum), TypeInfoPropertyName = "PromptEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptNodeExecutionMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptNodeResultData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.PromptNodeExecutionMeta, object>), TypeInfoPropertyName = "OneOfPromptNodeExecutionMetaObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.IterationStateEnum?, object>), TypeInfoPropertyName = "OneOfIterationStateEnumObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.WorkflowNodeResultData?, object>), TypeInfoPropertyName = "OneOfWorkflowNodeResultDataObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.NodeOutputCompiledValue?, object>), TypeInfoPropertyName = "OneOfNodeOutputCompiledValueObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FulfilledWorkflowNodeResultEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.NodeOutputCompiledValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.RejectedWorkflowNodeResultEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowNodeResultEvent), TypeInfoPropertyName = "WorkflowNodeResultEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionNodeResultEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowStreamEvent), TypeInfoPropertyName = "WorkflowStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CheckWorkflowExecutionStatusError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.WorkflowExecutionEventErrorCode?, object>), TypeInfoPropertyName = "OneOfWorkflowExecutionEventErrorCodeObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.CheckWorkflowExecutionStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.CheckWorkflowExecutionStatusError, object>), TypeInfoPropertyName = "OneOfCheckWorkflowExecutionStatusErrorObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.WorkflowDisplayIcon, object>), TypeInfoPropertyName = "OneOfWorkflowDisplayIconObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowDeploymentRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.WorkflowDeploymentDisplayData, object>), TypeInfoPropertyName = "OneOfWorkflowDeploymentDisplayDataObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ExecuteWorkflowDeploymentStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SpanLinkTypeEnum), TypeInfoPropertyName = "SpanLinkTypeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SpanLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ParentContext), TypeInfoPropertyName = "ParentContext2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumCodeResourceDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowParentContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.ParentContext?, object>), TypeInfoPropertyName = "OneOfParentContextObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.ApiActorTypeEnum?, object>), TypeInfoPropertyName = "OneOfApiActorTypeEnumObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.VellumSdkErrorRawData?, object>), TypeInfoPropertyName = "OneOfVellumSdkErrorRawDataObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.VellumCodeResourceDefinition, object>), TypeInfoPropertyName = "OneOfVellumCodeResourceDefinitionObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.CodeResourceDefinition, object>), TypeInfoPropertyName = "OneOfCodeResourceDefinitionObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.WorkflowExecutionUsageCalculationError, object>), TypeInfoPropertyName = "OneOfWorkflowExecutionUsageCalculationErrorObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionActual))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionViewOnlineEvalMetricResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SlimWorkflowExecutionRead))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.WorkflowError?, object>), TypeInfoPropertyName = "OneOfWorkflowErrorObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.WorkflowExecutionUsageResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.WorkflowDeploymentParentContext, object>), TypeInfoPropertyName = "OneOfWorkflowDeploymentParentContextObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.WorkflowExecutionActual, object>), TypeInfoPropertyName = "OneOfWorkflowExecutionActualObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.WorkflowExecutionViewOnlineEvalMetricResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowDeploymentEventExecutionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.SlimWorkflowExecutionRead>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionEnum), TypeInfoPropertyName = "WorkflowExecutionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumWorkflowExecutionEvent), TypeInfoPropertyName = "VellumWorkflowExecutionEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionSpanAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionUsageCalculationFulfilledBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowExecutionSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.VellumWorkflowExecutionEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.WorkflowExecutionUsageCalculationFulfilledBody, object>), TypeInfoPropertyName = "OneOfWorkflowExecutionUsageCalculationFulfilledBodyObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionEnum), TypeInfoPropertyName = "NodeExecutionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumNodeExecutionEvent), TypeInfoPropertyName = "VellumNodeExecutionEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionSpanAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NodeExecutionSpan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.VellumNodeExecutionEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumSpan), TypeInfoPropertyName = "VellumSpan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowEventExecutionRead))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.MetadataFilterRuleCombinator?, object>), TypeInfoPropertyName = "OneOfMetadataFilterRuleCombinatorObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.MetadataFilterRuleRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.LogicalOperator?, object>), TypeInfoPropertyName = "OneOfLogicalOperatorObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MetadataFilterConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.LogicalConditionEnum), TypeInfoPropertyName = "LogicalConditionEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.StringVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.NumberVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.JsonVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.AudioVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.VellumAudioRequest, object>), TypeInfoPropertyName = "OneOfVellumAudioRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VideoVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.VellumVideoRequest, object>), TypeInfoPropertyName = "OneOfVellumVideoRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ImageVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.VellumImageRequest, object>), TypeInfoPropertyName = "OneOfVellumImageRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.VellumDocumentRequest, object>), TypeInfoPropertyName = "OneOfVellumDocumentRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FunctionCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FunctionCallVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.FunctionCallRequest, object>), TypeInfoPropertyName = "OneOfFunctionCallRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumErrorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ErrorVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.VellumErrorRequest, object>), TypeInfoPropertyName = "OneOfVellumErrorRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ArrayVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.VellumValueRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumValueRequest), TypeInfoPropertyName = "VellumValueRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ChatHistoryVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PdfSearchResultMetaSourceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultMetaSourceRequest), TypeInfoPropertyName = "SearchResultMetaSourceRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultMetaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.SearchResultMetaSourceRequest?, object>), TypeInfoPropertyName = "OneOfSearchResultMetaSourceRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.SearchResultMetaRequest, object>), TypeInfoPropertyName = "OneOfSearchResultMetaRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchResultsVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.SearchResultRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ThinkingVellumValueRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.StringVellumValueRequest, object>), TypeInfoPropertyName = "OneOfStringVellumValueRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumValueLogicalConditionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.LogicalConditionGroupEnum), TypeInfoPropertyName = "LogicalConditionGroupEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ConditionCombinator), TypeInfoPropertyName = "ConditionCombinator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumValueLogicalConditionGroupRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.VellumValueLogicalExpressionRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.VellumValueLogicalExpressionRequest), TypeInfoPropertyName = "VellumValueLogicalExpressionRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.MetadataFiltersRequest), TypeInfoPropertyName = "MetadataFiltersRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchFiltersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.MetadataFiltersRequest?, object>), TypeInfoPropertyName = "OneOfMetadataFiltersRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchRequestOptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.SearchWeightsRequest, object>), TypeInfoPropertyName = "OneOfSearchWeightsRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.SearchResultMergingRequest, object>), TypeInfoPropertyName = "OneOfSearchResultMergingRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.SearchFiltersRequest, object>), TypeInfoPropertyName = "OneOfSearchFiltersRequestObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SearchRequestBodyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.SearchRequestOptionsRequest, object>), TypeInfoPropertyName = "OneOfSearchRequestOptionsRequestObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.DocumentIndexChunkingRequest?, object>), TypeInfoPropertyName = "OneOfDocumentIndexChunkingRequestObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.DocumentIndexChunking?, object>), TypeInfoPropertyName = "OneOfDocumentIndexChunkingObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.ProcessingFailureReasonEnum?, object>), TypeInfoPropertyName = "OneOfProcessingFailureReasonEnumObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.TestSuiteRunExecConfig?, object>), TypeInfoPropertyName = "OneOfTestSuiteRunExecConfigObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OneOf<global::Vellum.WorkflowSandboxDisplayData, object>), TypeInfoPropertyName = "OneOfWorkflowSandboxDisplayDataObject2")]
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
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}