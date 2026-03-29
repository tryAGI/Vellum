
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A JSON object containing any metadata associated with the document that you'd like to filter upon later.
    /// </summary>
    public sealed partial class PartialUpdateRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}