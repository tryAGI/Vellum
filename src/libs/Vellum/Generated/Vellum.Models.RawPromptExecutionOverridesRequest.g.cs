
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RawPromptExecutionOverridesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public object? Body { get; set; }

        /// <summary>
        /// The raw headers to send to the model host.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// The raw URL to send to the model host.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RawPromptExecutionOverridesRequest" /> class.
        /// </summary>
        /// <param name="body"></param>
        /// <param name="headers">
        /// The raw headers to send to the model host.
        /// </param>
        /// <param name="url">
        /// The raw URL to send to the model host.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RawPromptExecutionOverridesRequest(
            object? body,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            string? url)
        {
            this.Body = body;
            this.Headers = headers;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RawPromptExecutionOverridesRequest" /> class.
        /// </summary>
        public RawPromptExecutionOverridesRequest()
        {
        }
    }
}