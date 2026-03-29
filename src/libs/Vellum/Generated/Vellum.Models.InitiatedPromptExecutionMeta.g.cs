
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The subset of the metadata tracked by Vellum during prompt execution that the request opted into with `expand_meta`.
    /// </summary>
    public sealed partial class InitiatedPromptExecutionMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public int? Latency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_release_tag")]
        public string? DeploymentReleaseTag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version_id")]
        public string? PromptVersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitiatedPromptExecutionMeta" /> class.
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="latency"></param>
        /// <param name="deploymentReleaseTag"></param>
        /// <param name="promptVersionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InitiatedPromptExecutionMeta(
            string? modelName,
            int? latency,
            string? deploymentReleaseTag,
            string? promptVersionId)
        {
            this.ModelName = modelName;
            this.Latency = latency;
            this.DeploymentReleaseTag = deploymentReleaseTag;
            this.PromptVersionId = promptVersionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitiatedPromptExecutionMeta" /> class.
        /// </summary>
        public InitiatedPromptExecutionMeta()
        {
        }
    }
}