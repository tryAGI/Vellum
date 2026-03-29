
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowDeploymentParentContext
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.WorkflowReleaseTagEnumJsonConverter))]
        public global::Vellum.WorkflowReleaseTagEnum Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid WorkflowVersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowDeploymentParentContext" /> class.
        /// </summary>
        /// <param name="spanId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="deploymentName"></param>
        /// <param name="deploymentHistoryItemId"></param>
        /// <param name="releaseTagId"></param>
        /// <param name="releaseTagName"></param>
        /// <param name="workflowVersionId"></param>
        /// <param name="parent"></param>
        /// <param name="links"></param>
        /// <param name="type"></param>
        /// <param name="externalId"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowDeploymentParentContext(
            global::System.Guid spanId,
            global::System.Guid deploymentId,
            string deploymentName,
            global::System.Guid deploymentHistoryItemId,
            global::System.Guid releaseTagId,
            string releaseTagName,
            global::System.Guid workflowVersionId,
            global::Vellum.OneOf<global::Vellum.ParentContext?, object>? parent,
            global::System.Collections.Generic.IList<global::Vellum.SpanLink>? links,
            global::Vellum.WorkflowReleaseTagEnum type,
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
            this.WorkflowVersionId = workflowVersionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowDeploymentParentContext" /> class.
        /// </summary>
        public WorkflowDeploymentParentContext()
        {
        }
    }
}