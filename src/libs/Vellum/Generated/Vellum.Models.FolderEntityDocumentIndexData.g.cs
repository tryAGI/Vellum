
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FolderEntityDocumentIndexData
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
        [global::System.Text.Json.Serialization.JsonPropertyName("indexing_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.DocumentIndexIndexingConfig IndexingConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderEntityDocumentIndexData" /> class.
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
        /// <param name="indexingConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FolderEntityDocumentIndexData(
            global::System.Guid id,
            string label,
            global::System.DateTime created,
            global::System.DateTime modified,
            global::Vellum.EntityStatus status,
            global::Vellum.DocumentIndexIndexingConfig indexingConfig)
        {
            this.Id = id;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Created = created;
            this.Modified = modified;
            this.Status = status;
            this.IndexingConfig = indexingConfig ?? throw new global::System.ArgumentNullException(nameof(indexingConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderEntityDocumentIndexData" /> class.
        /// </summary>
        public FolderEntityDocumentIndexData()
        {
        }
    }
}