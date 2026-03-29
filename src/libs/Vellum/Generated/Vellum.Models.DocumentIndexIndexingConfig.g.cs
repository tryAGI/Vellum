
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentIndexIndexingConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorizer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.IndexingConfigVectorizerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.IndexingConfigVectorizer Vectorizer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.DocumentIndexChunking?, object>))]
        public global::Vellum.OneOf<global::Vellum.DocumentIndexChunking?, object>? Chunking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentIndexIndexingConfig" /> class.
        /// </summary>
        /// <param name="vectorizer"></param>
        /// <param name="chunking"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentIndexIndexingConfig(
            global::Vellum.IndexingConfigVectorizer vectorizer,
            global::Vellum.OneOf<global::Vellum.DocumentIndexChunking?, object>? chunking)
        {
            this.Vectorizer = vectorizer;
            this.Chunking = chunking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentIndexIndexingConfig" /> class.
        /// </summary>
        public DocumentIndexIndexingConfig()
        {
        }
    }
}