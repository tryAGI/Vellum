
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptDeploymentExpandMetaRequest
    {
        /// <summary>
        /// If enabled, the response will include the model identifier representing the ML Model invoked by the Prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public bool? ModelName { get; set; }

        /// <summary>
        /// If enabled, the response will include model host usage tracking. This may increase latency for some model hosts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public bool? Usage { get; set; }

        /// <summary>
        /// If enabled, the response will include model host cost tracking. This may increase latency for some model hosts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public bool? Cost { get; set; }

        /// <summary>
        /// If enabled, the response will include the reason provided by the model for why the execution finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        public bool? FinishReason { get; set; }

        /// <summary>
        /// If enabled, the response will include the time in nanoseconds it took to execute the Prompt Deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public bool? Latency { get; set; }

        /// <summary>
        /// If enabled, the response will include the release tag of the Prompt Deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_release_tag")]
        public bool? DeploymentReleaseTag { get; set; }

        /// <summary>
        /// If enabled, the response will include the ID of the Prompt Version backing the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version_id")]
        public bool? PromptVersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptDeploymentExpandMetaRequest" /> class.
        /// </summary>
        /// <param name="modelName">
        /// If enabled, the response will include the model identifier representing the ML Model invoked by the Prompt.
        /// </param>
        /// <param name="usage">
        /// If enabled, the response will include model host usage tracking. This may increase latency for some model hosts.
        /// </param>
        /// <param name="cost">
        /// If enabled, the response will include model host cost tracking. This may increase latency for some model hosts.
        /// </param>
        /// <param name="finishReason">
        /// If enabled, the response will include the reason provided by the model for why the execution finished.
        /// </param>
        /// <param name="latency">
        /// If enabled, the response will include the time in nanoseconds it took to execute the Prompt Deployment.
        /// </param>
        /// <param name="deploymentReleaseTag">
        /// If enabled, the response will include the release tag of the Prompt Deployment.
        /// </param>
        /// <param name="promptVersionId">
        /// If enabled, the response will include the ID of the Prompt Version backing the deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptDeploymentExpandMetaRequest(
            bool? modelName,
            bool? usage,
            bool? cost,
            bool? finishReason,
            bool? latency,
            bool? deploymentReleaseTag,
            bool? promptVersionId)
        {
            this.ModelName = modelName;
            this.Usage = usage;
            this.Cost = cost;
            this.FinishReason = finishReason;
            this.Latency = latency;
            this.DeploymentReleaseTag = deploymentReleaseTag;
            this.PromptVersionId = promptVersionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptDeploymentExpandMetaRequest" /> class.
        /// </summary>
        public PromptDeploymentExpandMetaRequest()
        {
        }
    }
}