
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Basic vectorizer for sentence-transformers/multi-qa-mpnet-base-dot-v1.
    /// </summary>
    public sealed partial class BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.SentenceTransformersMultiQaMpnetBaseDotV1EnumJsonConverter))]
        public global::Vellum.SentenceTransformersMultiQaMpnetBaseDotV1Enum ModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1" /> class.
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="config"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1(
            global::Vellum.SentenceTransformersMultiQaMpnetBaseDotV1Enum modelName,
            object? config)
        {
            this.ModelName = modelName;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1" /> class.
        /// </summary>
        public BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1()
        {
        }
    }
}