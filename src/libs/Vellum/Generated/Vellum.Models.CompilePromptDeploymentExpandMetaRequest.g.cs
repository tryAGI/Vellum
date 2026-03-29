
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompilePromptDeploymentExpandMetaRequest
    {
        /// <summary>
        /// If enabled, the response will include the model identifier representing the ML Model invoked by the Prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public bool? ModelName { get; set; }

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
        /// Initializes a new instance of the <see cref="CompilePromptDeploymentExpandMetaRequest" /> class.
        /// </summary>
        /// <param name="modelName">
        /// If enabled, the response will include the model identifier representing the ML Model invoked by the Prompt.
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
        public CompilePromptDeploymentExpandMetaRequest(
            bool? modelName,
            bool? deploymentReleaseTag,
            bool? promptVersionId)
        {
            this.ModelName = modelName;
            this.DeploymentReleaseTag = deploymentReleaseTag;
            this.PromptVersionId = promptVersionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompilePromptDeploymentExpandMetaRequest" /> class.
        /// </summary>
        public CompilePromptDeploymentExpandMetaRequest()
        {
        }
    }
}