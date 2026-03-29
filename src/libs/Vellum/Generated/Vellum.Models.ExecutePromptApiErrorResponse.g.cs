
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecutePromptApiErrorResponse
    {
        /// <summary>
        /// Details about why the request failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// The raw error data structure, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_data")]
        public object? RawData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutePromptApiErrorResponse" /> class.
        /// </summary>
        /// <param name="detail">
        /// Details about why the request failed.
        /// </param>
        /// <param name="rawData">
        /// The raw error data structure, if available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutePromptApiErrorResponse(
            string detail,
            object? rawData)
        {
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
            this.RawData = rawData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutePromptApiErrorResponse" /> class.
        /// </summary>
        public ExecutePromptApiErrorResponse()
        {
        }
    }
}