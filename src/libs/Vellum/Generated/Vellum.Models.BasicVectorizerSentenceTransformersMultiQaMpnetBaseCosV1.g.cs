
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Basic vectorizer for sentence-transformers/multi-qa-mpnet-base-cos-v1.
    /// </summary>
    public sealed partial class BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public object? Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.SentenceTransformersMultiQaMpnetBaseCosV1EnumJsonConverter))]
        public global::Vellum.SentenceTransformersMultiQaMpnetBaseCosV1Enum ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="modelName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1(
            object? config,
            global::Vellum.SentenceTransformersMultiQaMpnetBaseCosV1Enum modelName)
        {
            this.Config = config;
            this.ModelName = modelName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1" /> class.
        /// </summary>
        public BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1()
        {
        }
    }
}