
#nullable enable

namespace Vellum
{
    /// <summary>
    /// OpenAI vectorizer for text-embedding-ada-002.
    /// </summary>
    public sealed partial class OpenAIVectorizerTextEmbeddingAda002
    {
        /// <summary>
        /// Configuration for using an OpenAI vectorizer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.OpenAIVectorizerConfig Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.TextEmbeddingAda002EnumJsonConverter))]
        public global::Vellum.TextEmbeddingAda002Enum ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIVectorizerTextEmbeddingAda002" /> class.
        /// </summary>
        /// <param name="config">
        /// Configuration for using an OpenAI vectorizer.
        /// </param>
        /// <param name="modelName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIVectorizerTextEmbeddingAda002(
            global::Vellum.OpenAIVectorizerConfig config,
            global::Vellum.TextEmbeddingAda002Enum modelName)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.ModelName = modelName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIVectorizerTextEmbeddingAda002" /> class.
        /// </summary>
        public OpenAIVectorizerTextEmbeddingAda002()
        {
        }
    }
}