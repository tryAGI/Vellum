
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The final resolved function call value.
    /// </summary>
    public sealed partial class FunctionCallChatMessageContentValueRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Arguments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallChatMessageContentValueRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="arguments"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionCallChatMessageContentValueRequest(
            string name,
            object arguments,
            string? id)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallChatMessageContentValueRequest" /> class.
        /// </summary>
        public FunctionCallChatMessageContentValueRequest()
        {
        }
    }
}