
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedDocumentIndexUpdateRequest
    {
        /// <summary>
        /// A human-readable label for the document index
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedDocumentIndexUpdateRequest" /> class.
        /// </summary>
        /// <param name="label">
        /// A human-readable label for the document index
        /// </param>
        /// <param name="status">
        /// The current status of the document index<br/>
        /// * `ACTIVE` - Active<br/>
        /// * `ARCHIVED` - Archived<br/>
        /// * `PENDING_DELETION` - Pending Deletion
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedDocumentIndexUpdateRequest(
            string? label,
            global::Vellum.EntityStatus? status)
        {
            this.Label = label;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedDocumentIndexUpdateRequest" /> class.
        /// </summary>
        public PatchedDocumentIndexUpdateRequest()
        {
        }
    }
}