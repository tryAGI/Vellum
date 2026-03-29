
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FolderEntityPromptSandboxData
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
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Modified { get; set; }

        /// <summary>
        /// * `ACTIVE` - Active<br/>
        /// * `ARCHIVED` - Archived<br/>
        /// * `PENDING_DELETION` - Pending Deletion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.EntityStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.EntityStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_deployed_on")]
        public global::System.DateTime? LastDeployedOn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderEntityPromptSandboxData" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="label"></param>
        /// <param name="created"></param>
        /// <param name="modified"></param>
        /// <param name="status">
        /// * `ACTIVE` - Active<br/>
        /// * `ARCHIVED` - Archived<br/>
        /// * `PENDING_DELETION` - Pending Deletion
        /// </param>
        /// <param name="description"></param>
        /// <param name="lastDeployedOn"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FolderEntityPromptSandboxData(
            global::System.Guid id,
            string label,
            global::System.DateTime created,
            global::System.DateTime modified,
            global::Vellum.EntityStatus status,
            string? description,
            global::System.DateTime? lastDeployedOn)
        {
            this.Id = id;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Created = created;
            this.Modified = modified;
            this.Status = status;
            this.Description = description;
            this.LastDeployedOn = lastDeployedOn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderEntityPromptSandboxData" /> class.
        /// </summary>
        public FolderEntityPromptSandboxData()
        {
        }
    }
}