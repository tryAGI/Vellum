
#nullable enable

namespace Vellum
{
    /// <summary>
    /// OpenAI vectorizer for text-embedding-3-small.
    /// </summary>
    public sealed partial class OpenAIVectorizerTextEmbedding3Small
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.TextEmbedding3SmallEnumJsonConverter))]
        public global::Vellum.TextEmbedding3SmallEnum ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIVectorizerTextEmbedding3Small" /> class.
        /// </summary>
        /// <param name="config">
        /// Configuration for using an OpenAI vectorizer.
        /// </param>
        /// <param name="modelName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIVectorizerTextEmbedding3Small(
            global::Vellum.OpenAIVectorizerConfig config,
            global::Vellum.TextEmbedding3SmallEnum modelName)
        {
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.ModelName = modelName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIVectorizerTextEmbedding3Small" /> class.
        /// </summary>
        public OpenAIVectorizerTextEmbedding3Small()
        {
        }
    }
}