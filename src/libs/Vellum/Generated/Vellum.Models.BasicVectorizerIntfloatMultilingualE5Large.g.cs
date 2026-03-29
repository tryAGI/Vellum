
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Basic vectorizer for intfloat/multilingual-e5-large.
    /// </summary>
    public sealed partial class BasicVectorizerIntfloatMultilingualE5Large
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.IntfloatMultilingualE5LargeEnumJsonConverter))]
        public global::Vellum.IntfloatMultilingualE5LargeEnum ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicVectorizerIntfloatMultilingualE5Large" /> class.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="modelName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BasicVectorizerIntfloatMultilingualE5Large(
            object? config,
            global::Vellum.IntfloatMultilingualE5LargeEnum modelName)
        {
            this.Config = config;
            this.ModelName = modelName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicVectorizerIntfloatMultilingualE5Large" /> class.
        /// </summary>
        public BasicVectorizerIntfloatMultilingualE5Large()
        {
        }
    }
}