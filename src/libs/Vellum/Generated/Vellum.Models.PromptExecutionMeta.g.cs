
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The subset of the metadata tracked by Vellum during prompt execution that the request opted into with `expand_meta`.
    /// </summary>
    public sealed partial class PromptExecutionMeta
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FinishReasonEnum?, object>))]
        public global::Vellum.OneOf<global::Vellum.FinishReasonEnum?, object>? FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.MLModelUsage, object>))]
        public global::Vellum.OneOf<global::Vellum.MLModelUsage, object>? Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.Price, object>))]
        public global::Vellum.OneOf<global::Vellum.Price, object>? Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptExecutionMeta" /> class.
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="latency"></param>
        /// <param name="deploymentReleaseTag"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="finishReason"></param>
        /// <param name="usage"></param>
        /// <param name="cost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptExecutionMeta(
            string? modelName,
            int? latency,
            string? deploymentReleaseTag,
            string? promptVersionId,
            global::Vellum.OneOf<global::Vellum.FinishReasonEnum?, object>? finishReason,
            global::Vellum.OneOf<global::Vellum.MLModelUsage, object>? usage,
            global::Vellum.OneOf<global::Vellum.Price, object>? cost)
        {
            this.ModelName = modelName;
            this.Latency = latency;
            this.DeploymentReleaseTag = deploymentReleaseTag;
            this.PromptVersionId = promptVersionId;
            this.FinishReason = finishReason;
            this.Usage = usage;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptExecutionMeta" /> class.
        /// </summary>
        public PromptExecutionMeta()
        {
        }
    }
}