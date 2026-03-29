
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadDocumentResponse
    {
        /// <summary>
        /// The ID of the newly created document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid DocumentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDocumentResponse" /> class.
        /// </summary>
        /// <param name="documentId">
        /// The ID of the newly created document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadDocumentResponse(
            global::System.Guid documentId)
        {
            this.DocumentId = documentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDocumentResponse" /> class.
        /// </summary>
        public UploadDocumentResponse()
        {
        }
    }
}