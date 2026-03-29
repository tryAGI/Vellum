
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GoogleVertexAIVectorizerGeminiEmbedding001
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.GeminiEmbedding001EnumJsonConverter))]
        public global::Vellum.GeminiEmbedding001Enum ModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.GoogleVertexAIVectorizerConfig Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleVertexAIVectorizerGeminiEmbedding001" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="modelName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleVertexAIVectorizerGeminiEmbedding001(
            global::Vellum.GoogleVertexAIVectorizerConfig config,
            global::Vellum.GeminiEmbedding001Enum modelName)
        {
            this.ModelName = modelName;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleVertexAIVectorizerGeminiEmbedding001" /> class.
        /// </summary>
        public GoogleVertexAIVectorizerGeminiEmbedding001()
        {
        }
    }
}