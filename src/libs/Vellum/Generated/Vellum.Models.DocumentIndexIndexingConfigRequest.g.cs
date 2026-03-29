
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentIndexIndexingConfigRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorizer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.IndexingConfigVectorizerRequestJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.IndexingConfigVectorizerRequest Vectorizer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.DocumentIndexChunkingRequest?, object>))]
        public global::Vellum.OneOf<global::Vellum.DocumentIndexChunkingRequest?, object>? Chunking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentIndexIndexingConfigRequest" /> class.
        /// </summary>
        /// <param name="vectorizer"></param>
        /// <param name="chunking"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentIndexIndexingConfigRequest(
            global::Vellum.IndexingConfigVectorizerRequest vectorizer,
            global::Vellum.OneOf<global::Vellum.DocumentIndexChunkingRequest?, object>? chunking)
        {
            this.Vectorizer = vectorizer;
            this.Chunking = chunking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentIndexIndexingConfigRequest" /> class.
        /// </summary>
        public DocumentIndexIndexingConfigRequest()
        {
        }
    }
}