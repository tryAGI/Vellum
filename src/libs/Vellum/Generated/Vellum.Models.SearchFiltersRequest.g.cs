
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchFiltersRequest
    {
        /// <summary>
        /// The document external IDs to filter by
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_ids")]
        public global::System.Collections.Generic.IList<string>? ExternalIds { get; set; }

        /// <summary>
        /// The metadata filters to apply to the search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.MetadataFiltersRequest?, object>))]
        public global::Vellum.OneOf<global::Vellum.MetadataFiltersRequest?, object>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFiltersRequest" /> class.
        /// </summary>
        /// <param name="externalIds">
        /// The document external IDs to filter by
        /// </param>
        /// <param name="metadata">
        /// The metadata filters to apply to the search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchFiltersRequest(
            global::System.Collections.Generic.IList<string>? externalIds,
            global::Vellum.OneOf<global::Vellum.MetadataFiltersRequest?, object>? metadata)
        {
            this.ExternalIds = externalIds;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFiltersRequest" /> class.
        /// </summary>
        public SearchFiltersRequest()
        {
        }
    }
}