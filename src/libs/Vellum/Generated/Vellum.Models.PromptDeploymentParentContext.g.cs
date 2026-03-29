
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptDeploymentParentContext
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ParentContext?, object>))]
        public global::Vellum.OneOf<global::Vellum.ParentContext?, object>? Parent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        public global::System.Collections.Generic.IList<global::Vellum.SpanLink>? Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.PromptReleaseTagEnumJsonConverter))]
        public global::Vellum.PromptReleaseTagEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SpanId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DeploymentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_history_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DeploymentHistoryItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_tag_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ReleaseTagId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_tag_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReleaseTagName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PromptVersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptDeploymentParentContext" /> class.
        /// </summary>
        /// <param name="spanId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="deploymentName"></param>
        /// <param name="deploymentHistoryItemId"></param>
        /// <param name="releaseTagId"></param>
        /// <param name="releaseTagName"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="parent"></param>
        /// <param name="links"></param>
        /// <param name="type"></param>
        /// <param name="externalId"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptDeploymentParentContext(
            global::System.Guid spanId,
            global::System.Guid deploymentId,
            string deploymentName,
            global::System.Guid deploymentHistoryItemId,
            global::System.Guid releaseTagId,
            string releaseTagName,
            global::System.Guid promptVersionId,
            global::Vellum.OneOf<global::Vellum.ParentContext?, object>? parent,
            global::System.Collections.Generic.IList<global::Vellum.SpanLink>? links,
            global::Vellum.PromptReleaseTagEnum type,
            string? externalId,
            object? metadata)
        {
            this.Parent = parent;
            this.Links = links;
            this.Type = type;
            this.SpanId = spanId;
            this.DeploymentId = deploymentId;
            this.DeploymentName = deploymentName ?? throw new global::System.ArgumentNullException(nameof(deploymentName));
            this.DeploymentHistoryItemId = deploymentHistoryItemId;
            this.ReleaseTagId = releaseTagId;
            this.ReleaseTagName = releaseTagName ?? throw new global::System.ArgumentNullException(nameof(releaseTagName));
            this.ExternalId = externalId;
            this.Metadata = metadata;
            this.PromptVersionId = promptVersionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptDeploymentParentContext" /> class.
        /// </summary>
        public PromptDeploymentParentContext()
        {
        }
    }
}