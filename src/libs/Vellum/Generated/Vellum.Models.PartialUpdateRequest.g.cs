
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PartialUpdateRequest
    {
        /// <summary>
        /// A human-readable label for the document. Defaults to the originally uploaded file's file name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

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
        /// A JSON object containing any metadata associated with the document that you'd like to filter upon later.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialUpdateRequest" /> class.
        /// </summary>
        /// <param name="label">
        /// A human-readable label for the document. Defaults to the originally uploaded file's file name.
        /// </param>
        /// <param name="status">
        /// The current status of the document<br/>
        /// * `ACTIVE` - Active
        /// </param>
        /// <param name="keywords">
        /// A list of keywords that'll be associated with the document. Used as part of keyword search.
        /// </param>
        /// <param name="metadata">
        /// A JSON object containing any metadata associated with the document that you'd like to filter upon later.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartialUpdateRequest(
            string? label,
            global::Vellum.DocumentStatus? status,
            global::System.Collections.Generic.IList<string>? keywords,
            object? metadata)
        {
            this.Label = label;
            this.Status = status;
            this.Keywords = keywords;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartialUpdateRequest" /> class.
        /// </summary>
        public PartialUpdateRequest()
        {
        }
    }
}