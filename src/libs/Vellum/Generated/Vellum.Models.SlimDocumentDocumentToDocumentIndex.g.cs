
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A slim representation of the link between a Document and a Document Index it's a member of.
    /// </summary>
    public sealed partial class SlimDocumentDocumentToDocumentIndex
    {
        /// <summary>
        /// Vellum-generated ID that uniquely identifies this link.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Vellum-generated ID that uniquely identifies the environment index this document is included in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_document_index_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid EnvironmentDocumentIndexId { get; set; }

        /// <summary>
        /// Vellum-generated ID that uniquely identifies the index this document is included in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_index_id")]
        public global::System.Guid? DocumentIndexId { get; set; }

        /// <summary>
        /// An enum value representing where this document is along its indexing lifecycle for this index.<br/>
        /// * `AWAITING_PROCESSING` - Awaiting Processing<br/>
        /// * `QUEUED` - Queued<br/>
        /// * `INDEXING` - Indexing<br/>
        /// * `INDEXED` - Indexed<br/>
        /// * `FAILED` - Failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexing_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.IndexingStateEnumJsonConverter))]
        public global::Vellum.IndexingStateEnum? IndexingState { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_state")]
        public string? ProcessingState { get; set; }

        /// <summary>
        /// An enum value representing why the document could not be processed for this index. Is null unless processing_state is FAILED.<br/>
        /// * `EXCEEDED_CHARACTER_LIMIT` - Exceeded Character Limit<br/>
        /// * `INVALID_FILE` - Invalid File<br/>
        /// * `INVALID_CREDENTIALS` - Invalid Credentials
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_failure_reason")]
        public global::Vellum.ProcessingFailureReasonEnum? ProcessingFailureReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlimDocumentDocumentToDocumentIndex" /> class.
        /// </summary>
        /// <param name="id">
        /// Vellum-generated ID that uniquely identifies this link.
        /// </param>
        /// <param name="environmentDocumentIndexId">
        /// Vellum-generated ID that uniquely identifies the environment index this document is included in.
        /// </param>
        /// <param name="documentIndexId">
        /// Vellum-generated ID that uniquely identifies the index this document is included in.
        /// </param>
        /// <param name="indexingState">
        /// An enum value representing where this document is along its indexing lifecycle for this index.<br/>
        /// * `AWAITING_PROCESSING` - Awaiting Processing<br/>
        /// * `QUEUED` - Queued<br/>
        /// * `INDEXING` - Indexing<br/>
        /// * `INDEXED` - Indexed<br/>
        /// * `FAILED` - Failed
        /// </param>
        /// <param name="processingState"></param>
        /// <param name="processingFailureReason">
        /// An enum value representing why the document could not be processed for this index. Is null unless processing_state is FAILED.<br/>
        /// * `EXCEEDED_CHARACTER_LIMIT` - Exceeded Character Limit<br/>
        /// * `INVALID_FILE` - Invalid File<br/>
        /// * `INVALID_CREDENTIALS` - Invalid Credentials
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlimDocumentDocumentToDocumentIndex(
            global::System.Guid id,
            global::System.Guid environmentDocumentIndexId,
            global::System.Guid? documentIndexId,
            global::Vellum.IndexingStateEnum? indexingState,
            string? processingState,
            global::Vellum.ProcessingFailureReasonEnum? processingFailureReason)
        {
            this.Id = id;
            this.EnvironmentDocumentIndexId = environmentDocumentIndexId;
            this.DocumentIndexId = documentIndexId;
            this.IndexingState = indexingState;
            this.ProcessingState = processingState;
            this.ProcessingFailureReason = processingFailureReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlimDocumentDocumentToDocumentIndex" /> class.
        /// </summary>
        public SlimDocumentDocumentToDocumentIndex()
        {
        }

    }
}