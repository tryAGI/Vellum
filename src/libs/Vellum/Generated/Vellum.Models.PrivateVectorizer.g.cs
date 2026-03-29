
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Serializer for private vectorizer.
    /// </summary>
    public sealed partial class PrivateVectorizer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.PrivateVectorizerEnumJsonConverter))]
        public global::Vellum.PrivateVectorizerEnum ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateVectorizer" /> class.
        /// </summary>
        /// <param name="modelName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateVectorizer(
            global::Vellum.PrivateVectorizerEnum modelName)
        {
            this.ModelName = modelName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateVectorizer" /> class.
        /// </summary>
        public PrivateVectorizer()
        {
        }
    }
}