
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentIndexCreateRequest
    {
        /// <summary>
        /// A human-readable label for the document index
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// A name that uniquely identifies this index within its workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The current status of the document index<br/>
        /// * `ACTIVE` - Active<br/>
        /// * `ARCHIVED` - Archived<br/>
        /// * `PENDING_DELETION` - Pending Deletion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.EntityStatusJsonConverter))]
        public global::Vellum.EntityStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexing_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.DocumentIndexIndexingConfigRequest IndexingConfig { get; set; }

        /// <summary>
        /// Optionally specify the id of a document index from which you'd like to copy and re-index its documents into this newly created index
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copy_documents_from_index_id")]
        public global::System.Guid? CopyDocumentsFromIndexId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentIndexCreateRequest" /> class.
        /// </summary>
        /// <param name="label">
        /// A human-readable label for the document index
        /// </param>
        /// <param name="name">
        /// A name that uniquely identifies this index within its workspace
        /// </param>
        /// <param name="indexingConfig"></param>
        /// <param name="status">
        /// The current status of the document index<br/>
        /// * `ACTIVE` - Active<br/>
        /// * `ARCHIVED` - Archived<br/>
        /// * `PENDING_DELETION` - Pending Deletion
        /// </param>
        /// <param name="copyDocumentsFromIndexId">
        /// Optionally specify the id of a document index from which you'd like to copy and re-index its documents into this newly created index
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentIndexCreateRequest(
            string label,
            string name,
            global::Vellum.DocumentIndexIndexingConfigRequest indexingConfig,
            global::Vellum.EntityStatus? status,
            global::System.Guid? copyDocumentsFromIndexId)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.IndexingConfig = indexingConfig ?? throw new global::System.ArgumentNullException(nameof(indexingConfig));
            this.CopyDocumentsFromIndexId = copyDocumentsFromIndexId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentIndexCreateRequest" /> class.
        /// </summary>
        public DocumentIndexCreateRequest()
        {
        }
    }
}