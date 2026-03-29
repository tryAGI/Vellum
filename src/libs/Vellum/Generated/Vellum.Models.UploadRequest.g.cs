
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadRequest
    {
        /// <summary>
        /// Optionally include the names of all indexes that you'd like this document to be included in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_to_index_names")]
        public global::System.Collections.Generic.IList<string>? AddToIndexNames { get; set; }

        /// <summary>
        /// Optionally include an external ID for this document. This is useful if you want to re-upload the same document later when its contents change and would like it to be re-indexed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// A human-friendly name for this document. Typically the filename.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// The file contents of the document. Either contents or url must be provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        public byte[]? Contents { get; set; }

        /// <summary>
        /// The file contents of the document. Either contents or url must be provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentsname")]
        public string? Contentsname { get; set; }

        /// <summary>
        /// A URL from which the document can be downloaded. Either contents or url must be provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Optionally include a list of keywords that'll be associated with this document. Used when performing keyword searches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        public global::System.Collections.Generic.IList<string>? Keywords { get; set; }

        /// <summary>
        /// A stringified JSON object containing any metadata associated with the document that you'd like to filter upon later.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public byte[]? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadRequest" /> class.
        /// </summary>
        /// <param name="label">
        /// A human-friendly name for this document. Typically the filename.
        /// </param>
        /// <param name="addToIndexNames">
        /// Optionally include the names of all indexes that you'd like this document to be included in
        /// </param>
        /// <param name="externalId">
        /// Optionally include an external ID for this document. This is useful if you want to re-upload the same document later when its contents change and would like it to be re-indexed.
        /// </param>
        /// <param name="contents">
        /// The file contents of the document. Either contents or url must be provided.
        /// </param>
        /// <param name="contentsname">
        /// The file contents of the document. Either contents or url must be provided.
        /// </param>
        /// <param name="url">
        /// A URL from which the document can be downloaded. Either contents or url must be provided.
        /// </param>
        /// <param name="keywords">
        /// Optionally include a list of keywords that'll be associated with this document. Used when performing keyword searches.
        /// </param>
        /// <param name="metadata">
        /// A stringified JSON object containing any metadata associated with the document that you'd like to filter upon later.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadRequest(
            string label,
            global::System.Collections.Generic.IList<string>? addToIndexNames,
            string? externalId,
            byte[]? contents,
            string? contentsname,
            string? url,
            global::System.Collections.Generic.IList<string>? keywords,
            byte[]? metadata)
        {
            this.AddToIndexNames = addToIndexNames;
            this.ExternalId = externalId;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Contents = contents;
            this.Contentsname = contentsname;
            this.Url = url;
            this.Keywords = keywords;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadRequest" /> class.
        /// </summary>
        public UploadRequest()
        {
        }
    }
}