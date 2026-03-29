
#nullable enable

namespace Vellum
{
    /// <summary>
    /// FastEmbed vectorizer for BAAI/bge-small-en-v1.5.
    /// </summary>
    public sealed partial class FastEmbedVectorizerBAAIBgeSmallEnV15Request
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.BaaiBgeSmallEnV15EnumJsonConverter))]
        public global::Vellum.BaaiBgeSmallEnV15Enum ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FastEmbedVectorizerBAAIBgeSmallEnV15Request" /> class.
        /// </summary>
        /// <param name="modelName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FastEmbedVectorizerBAAIBgeSmallEnV15Request(
            global::Vellum.BaaiBgeSmallEnV15Enum modelName)
        {
            this.ModelName = modelName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FastEmbedVectorizerBAAIBgeSmallEnV15Request" /> class.
        /// </summary>
        public FastEmbedVectorizerBAAIBgeSmallEnV15Request()
        {
        }
    }
}