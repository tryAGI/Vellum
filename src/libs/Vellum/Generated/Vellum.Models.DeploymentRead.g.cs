
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A Prompt Deployment's full details.
    /// </summary>
    public sealed partial class DeploymentRead
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// A human-readable label for the deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// A name that uniquely identifies this deployment within its workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The current status of the deployment<br/>
        /// * `ACTIVE` - Active<br/>
        /// * `ARCHIVED` - Archived<br/>
        /// * `PENDING_DELETION` - Pending Deletion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.EntityStatusJsonConverter))]
        public global::Vellum.EntityStatus? Status { get; set; }

        /// <summary>
        /// Deprecated. The value returned will always be 'PRODUCTION'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.EnvironmentEnum?, object>))]
        public global::Vellum.OneOf<global::Vellum.EnvironmentEnum?, object>? Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_deployed_on")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastDeployedOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.VellumVariable> InputVariables { get; set; }

        /// <summary>
        /// A human-readable description of the deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Deprecated. This now always returns an empty array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_model_version_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ActiveModelVersionIds { get; set; }

        /// <summary>
        /// The ID of the history item associated with this Deployment's LATEST Release Tag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_deployed_history_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid LastDeployedHistoryItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentRead" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="created"></param>
        /// <param name="label">
        /// A human-readable label for the deployment
        /// </param>
        /// <param name="name">
        /// A name that uniquely identifies this deployment within its workspace
        /// </param>
        /// <param name="lastDeployedOn"></param>
        /// <param name="inputVariables"></param>
        /// <param name="lastDeployedHistoryItemId">
        /// The ID of the history item associated with this Deployment's LATEST Release Tag
        /// </param>
        /// <param name="status">
        /// The current status of the deployment<br/>
        /// * `ACTIVE` - Active<br/>
        /// * `ARCHIVED` - Archived<br/>
        /// * `PENDING_DELETION` - Pending Deletion
        /// </param>
        /// <param name="environment">
        /// Deprecated. The value returned will always be 'PRODUCTION'.
        /// </param>
        /// <param name="description">
        /// A human-readable description of the deployment
        /// </param>
        /// <param name="activeModelVersionIds">
        /// Deprecated. This now always returns an empty array.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentRead(
            global::System.Guid id,
            global::System.DateTime created,
            string label,
            string name,
            global::System.DateTime lastDeployedOn,
            global::System.Collections.Generic.IList<global::Vellum.VellumVariable> inputVariables,
            global::System.Guid lastDeployedHistoryItemId,
            global::Vellum.EntityStatus? status,
            global::Vellum.OneOf<global::Vellum.EnvironmentEnum?, object>? environment,
            string? description,
            global::System.Collections.Generic.IList<global::System.Guid>? activeModelVersionIds)
        {
            this.Id = id;
            this.Created = created;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.Environment = environment;
            this.LastDeployedOn = lastDeployedOn;
            this.InputVariables = inputVariables ?? throw new global::System.ArgumentNullException(nameof(inputVariables));
            this.Description = description;
            this.ActiveModelVersionIds = activeModelVersionIds;
            this.LastDeployedHistoryItemId = lastDeployedHistoryItemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentRead" /> class.
        /// </summary>
        public DeploymentRead()
        {
        }
    }
}