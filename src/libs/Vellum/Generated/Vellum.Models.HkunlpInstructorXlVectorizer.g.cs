
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Vectorizer for hkunlp/instructor-xl.
    /// </summary>
    public sealed partial class HkunlpInstructorXlVectorizer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.HkunlpInstructorXlEnumJsonConverter))]
        public global::Vellum.HkunlpInstructorXlEnum ModelName { get; set; }

        /// <summary>
        /// Configuration for using an Instructor vectorizer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.InstructorVectorizerConfig Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HkunlpInstructorXlVectorizer" /> class.
        /// </summary>
        /// <param name="config">
        /// Configuration for using an Instructor vectorizer.
        /// </param>
        /// <param name="modelName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HkunlpInstructorXlVectorizer(
            global::Vellum.InstructorVectorizerConfig config,
            global::Vellum.HkunlpInstructorXlEnum modelName)
        {
            this.ModelName = modelName;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HkunlpInstructorXlVectorizer" /> class.
        /// </summary>
        public HkunlpInstructorXlVectorizer()
        {
        }
    }
}