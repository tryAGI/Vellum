
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SlimDocument
    {
        /// <summary>
        /// Vellum-generated ID that uniquely identifies this document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The external ID that was originally provided when uploading the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// A timestamp representing when this document was most recently uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_uploaded_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastUploadedAt { get; set; }

        /// <summary>
        /// Human-friendly name for this document.
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
        /// An enum value representing why the document could not be processed. Is null unless processing_state is FAILED.<br/>
        /// * `EXCEEDED_CHARACTER_LIMIT` - Exceeded Character Limit<br/>
        /// * `INVALID_FILE` - Invalid File<br/>
        /// * `INVALID_CREDENTIALS` - Invalid Credentials
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_failure_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ProcessingFailureReasonEnum?, object>))]
        public global::Vellum.OneOf<global::Vellum.ProcessingFailureReasonEnum?, object>? ProcessingFailureReason { get; set; }

        /// <summary>
        /// The document's current status.<br/>
        /// * `ACTIVE` - Active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.DocumentStatusJsonConverter))]
        public global::Vellum.DocumentStatus? Status { get; set; }

        /// <summary>
        /// A list of keywords associated with this document. Originally provided when uploading the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        public global::System.Collections.Generic.IList<string>? Keywords { get; set; }

        /// <summary>
        /// A previously supplied JSON object containing metadata that can be filtered on when searching.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_to_document_indexes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.SlimDocumentDocumentToDocumentIndex> DocumentToDocumentIndexes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlimDocument" /> class.
        /// </summary>
        /// <param name="id">
        /// Vellum-generated ID that uniquely identifies this document.
        /// </param>
        /// <param name="lastUploadedAt">
        /// A timestamp representing when this document was most recently uploaded.
        /// </param>
        /// <param name="label">
        /// Human-friendly name for this document.
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
        /// The external ID that was originally provided when uploading the document.
        /// </param>
        /// <param name="processingFailureReason">
        /// An enum value representing why the document could not be processed. Is null unless processing_state is FAILED.<br/>
        /// * `EXCEEDED_CHARACTER_LIMIT` - Exceeded Character Limit<br/>
        /// * `INVALID_FILE` - Invalid File<br/>
        /// * `INVALID_CREDENTIALS` - Invalid Credentials
        /// </param>
        /// <param name="status">
        /// The document's current status.<br/>
        /// * `ACTIVE` - Active
        /// </param>
        /// <param name="keywords">
        /// A list of keywords associated with this document. Originally provided when uploading the document.
        /// </param>
        /// <param name="metadata">
        /// A previously supplied JSON object containing metadata that can be filtered on when searching.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlimDocument(
            global::System.Guid id,
            global::System.DateTime lastUploadedAt,
            string label,
            global::Vellum.DocumentProcessingState processingState,
            global::System.Collections.Generic.IList<global::Vellum.SlimDocumentDocumentToDocumentIndex> documentToDocumentIndexes,
            string? externalId,
            global::Vellum.OneOf<global::Vellum.ProcessingFailureReasonEnum?, object>? processingFailureReason,
            global::Vellum.DocumentStatus? status,
            global::System.Collections.Generic.IList<string>? keywords,
            object? metadata)
        {
            this.Id = id;
            this.ExternalId = externalId;
            this.LastUploadedAt = lastUploadedAt;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.ProcessingState = processingState;
            this.ProcessingFailureReason = processingFailureReason;
            this.Status = status;
            this.Keywords = keywords;
            this.Metadata = metadata;
            this.DocumentToDocumentIndexes = documentToDocumentIndexes ?? throw new global::System.ArgumentNullException(nameof(documentToDocumentIndexes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlimDocument" /> class.
        /// </summary>
        public SlimDocument()
        {
        }
    }
}