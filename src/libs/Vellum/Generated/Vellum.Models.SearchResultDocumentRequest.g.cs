
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResultDocumentRequest
    {
        /// <summary>
        /// The ID of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The human-readable name for the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// The unique ID of the document as represented in an external system and specified when it was originally uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

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
        /// Initializes a new instance of the <see cref="SearchResultDocumentRequest" /> class.
        /// </summary>
        /// <param name="label">
        /// The human-readable name for the document.
        /// </param>
        /// <param name="id">
        /// The ID of the document.
        /// </param>
        /// <param name="externalId">
        /// The unique ID of the document as represented in an external system and specified when it was originally uploaded.
        /// </param>
        /// <param name="metadata">
        /// A previously supplied JSON object containing metadata that can be filtered on when searching.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultDocumentRequest(
            string label,
            global::System.Guid? id,
            string? externalId,
            object? metadata)
        {
            this.Id = id;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.ExternalId = externalId;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultDocumentRequest" /> class.
        /// </summary>
        public SearchResultDocumentRequest()
        {
        }
    }
}