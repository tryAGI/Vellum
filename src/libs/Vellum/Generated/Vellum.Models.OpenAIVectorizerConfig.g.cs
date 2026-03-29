
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Configuration for using an OpenAI vectorizer.
    /// </summary>
    public sealed partial class OpenAIVectorizerConfig
    {
        /// <summary>
        /// * `True` - True
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_openai_api_key")]
        public bool? AddOpenaiApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIVectorizerConfig" /> class.
        /// </summary>
        /// <param name="addOpenaiApiKey">
        /// * `True` - True
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIVectorizerConfig(
            bool? addOpenaiApiKey)
        {
            this.AddOpenaiApiKey = addOpenaiApiKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIVectorizerConfig" /> class.
        /// </summary>
        public OpenAIVectorizerConfig()
        {
        }
    }
}