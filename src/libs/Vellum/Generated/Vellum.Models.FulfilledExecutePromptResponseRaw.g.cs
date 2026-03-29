
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The subset of the raw response from the model that the request opted into with `expand_raw`.
    /// </summary>
    public sealed partial class FulfilledExecutePromptResponseRaw
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}