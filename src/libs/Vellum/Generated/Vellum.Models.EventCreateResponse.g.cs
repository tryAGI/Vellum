
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Response serializer for successful event creation.
    /// </summary>
    public sealed partial class EventCreateResponse
    {
        /// <summary>
        /// Indicates whether the event was published successfully.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Number of events processed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventCreateResponse" /> class.
        /// </summary>
        /// <param name="count">
        /// Number of events processed
        /// </param>
        /// <param name="success">
        /// Indicates whether the event was published successfully.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EventCreateResponse(
            int count,
            bool? success)
        {
            this.Success = success;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventCreateResponse" /> class.
        /// </summary>
        public EventCreateResponse()
        {
        }
    }
}