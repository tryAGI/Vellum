
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentRead
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The unique id of this document as it exists in the user's system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_uploaded_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastUploadedAt { get; set; }

        /// <summary>
        /// A human-readable label for the document. Defaults to the originally uploaded file's file name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// * `QUEUED` - Queued<br/>
        /// * `PROCESSING` - Processing<br/>
        /// * `PROCESSED` - Processed<br/>
        /// * `FAILED` - Failed<br/>
        /// * `UNKNOWN` - Unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.DocumentProcessingStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.DocumentProcessingState ProcessingState { get; set; }

        /// <summary>
        /// The current status of the document<br/>
        /// * `ACTIVE` - Active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.DocumentStatusJsonConverter))]
        public global::Vellum.DocumentStatus? Status { get; set; }

        /// <summary>
        /// A list of keywords that'll be associated with the document. Used as part of keyword search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        public global::System.Collections.Generic.IList<string>? Keywords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_file_url")]
        public string? OriginalFileUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_to_document_indexes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.DocumentDocumentToDocumentIndex> DocumentToDocumentIndexes { get; set; }

        /// <summary>
        /// A previously supplied JSON object containing metadata that can be filtered on when searching.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentRead" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="lastUploadedAt"></param>
        /// <param name="label">
        /// A human-readable label for the document. Defaults to the originally uploaded file's file name.
        /// </param>
        /// <param name="processingState">
        /// * `QUEUED` - Queued<br/>
        /// * `PROCESSING` - Processing<br/>
        /// * `PROCESSED` - Processed<br/>
        /// * `FAILED` - Failed<br/>
        /// * `UNKNOWN` - Unknown
        /// </param>
        /// <param name="documentToDocumentIndexes"></param>
        /// <param name="externalId">
        /// The unique id of this document as it exists in the user's system.
        /// </param>
        /// <param name="status">
        /// The current status of the document<br/>
        /// * `ACTIVE` - Active
        /// </param>
        /// <param name="keywords">
        /// A list of keywords that'll be associated with the document. Used as part of keyword search.
        /// </param>
        /// <param name="originalFileUrl"></param>
        /// <param name="metadata">
        /// A previously supplied JSON object containing metadata that can be filtered on when searching.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentRead(
            global::System.Guid id,
            global::System.DateTime lastUploadedAt,
            string label,
            global::Vellum.DocumentProcessingState processingState,
            global::System.Collections.Generic.IList<global::Vellum.DocumentDocumentToDocumentIndex> documentToDocumentIndexes,
            string? externalId,
            global::Vellum.DocumentStatus? status,
            global::System.Collections.Generic.IList<string>? keywords,
            string? originalFileUrl,
            object? metadata)
        {
            this.Id = id;
            this.ExternalId = externalId;
            this.LastUploadedAt = lastUploadedAt;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.ProcessingState = processingState;
            this.Status = status;
            this.Keywords = keywords;
            this.OriginalFileUrl = originalFileUrl;
            this.DocumentToDocumentIndexes = documentToDocumentIndexes ?? throw new global::System.ArgumentNullException(nameof(documentToDocumentIndexes));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentRead" /> class.
        /// </summary>
        public DocumentRead()
        {
        }
    }
}