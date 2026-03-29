
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentIndexRead
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
        public required global::Vellum.DocumentIndexIndexingConfig IndexingConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentIndexRead" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="created"></param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentIndexRead(
            global::System.Guid id,
            global::System.DateTime created,
            string label,
            string name,
            global::Vellum.DocumentIndexIndexingConfig indexingConfig,
            global::Vellum.EntityStatus? status)
        {
            this.Id = id;
            this.Created = created;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.IndexingConfig = indexingConfig ?? throw new global::System.ArgumentNullException(nameof(indexingConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentIndexRead" /> class.
        /// </summary>
        public DocumentIndexRead()
        {
        }
    }
}