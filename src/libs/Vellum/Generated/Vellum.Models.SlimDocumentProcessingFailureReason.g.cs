
#nullable enable

namespace Vellum
{
    /// <summary>
    /// An enum value representing why the document could not be processed. Is null unless processing_state is FAILED.<br/>
    /// * `EXCEEDED_CHARACTER_LIMIT` - Exceeded Character Limit<br/>
    /// * `INVALID_FILE` - Invalid File<br/>
    /// * `INVALID_CREDENTIALS` - Invalid Credentials
    /// </summary>
    public sealed partial class SlimDocumentProcessingFailureReason
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}