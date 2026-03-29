
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowModelProviderDependency
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ModelProviderEnumJsonConverter))]
        public global::Vellum.ModelProviderEnum Type { get; set; }

        /// <summary>
        /// * `ANTHROPIC` - Anthropic<br/>
        /// * `AWS_BEDROCK` - AWS Bedrock<br/>
        /// * `AZURE_AI_FOUNDRY` - Azure AI Foundry<br/>
        /// * `AZURE_OPENAI` - Azure OpenAI<br/>
        /// * `BASETEN` - BaseTen<br/>
        /// * `CEREBRAS` - Cerebras<br/>
        /// * `COHERE` - Cohere<br/>
        /// * `CUSTOM` - Custom<br/>
        /// * `DEEP_SEEK` - DeepSeek<br/>
        /// * `FIREWORKS_AI` - Fireworks AI<br/>
        /// * `GOOGLE` - Google<br/>
        /// * `GOOGLE_VERTEX_AI` - Google Vertex AI<br/>
        /// * `GROQ` - Groq<br/>
        /// * `HUGGINGFACE` - HuggingFace<br/>
        /// * `IBM_WATSONX` - IBM WatsonX<br/>
        /// * `MISTRAL_AI` - Mistral AI<br/>
        /// * `MOSAICML` - MosaicML<br/>
        /// * `MYSTIC` - Mystic<br/>
        /// * `NVIDIA` - NVIDIA<br/>
        /// * `OPENAI` - OpenAI<br/>
        /// * `OPEN_ROUTER` - Open Router<br/>
        /// * `OPENPIPE` - OpenPipe<br/>
        /// * `PERPLEXITY` - Perplexity<br/>
        /// * `PYQ` - Pyq<br/>
        /// * `REPLICATE` - Replicate<br/>
        /// * `SAMBANOVA` - SambaNova<br/>
        /// * `TOGETHER_AI` - Together AI<br/>
        /// * `X_AI` - xAI<br/>
        /// * `FASTWEB` - Fastweb<br/>
        /// * `SWISSCOM` - Swisscom
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.MLModelHostingInterfaceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.MLModelHostingInterface Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowModelProviderDependency" /> class.
        /// </summary>
        /// <param name="name">
        /// * `ANTHROPIC` - Anthropic<br/>
        /// * `AWS_BEDROCK` - AWS Bedrock<br/>
        /// * `AZURE_AI_FOUNDRY` - Azure AI Foundry<br/>
        /// * `AZURE_OPENAI` - Azure OpenAI<br/>
        /// * `BASETEN` - BaseTen<br/>
        /// * `CEREBRAS` - Cerebras<br/>
        /// * `COHERE` - Cohere<br/>
        /// * `CUSTOM` - Custom<br/>
        /// * `DEEP_SEEK` - DeepSeek<br/>
        /// * `FIREWORKS_AI` - Fireworks AI<br/>
        /// * `GOOGLE` - Google<br/>
        /// * `GOOGLE_VERTEX_AI` - Google Vertex AI<br/>
        /// * `GROQ` - Groq<br/>
        /// * `HUGGINGFACE` - HuggingFace<br/>
        /// * `IBM_WATSONX` - IBM WatsonX<br/>
        /// * `MISTRAL_AI` - Mistral AI<br/>
        /// * `MOSAICML` - MosaicML<br/>
        /// * `MYSTIC` - Mystic<br/>
        /// * `NVIDIA` - NVIDIA<br/>
        /// * `OPENAI` - OpenAI<br/>
        /// * `OPEN_ROUTER` - Open Router<br/>
        /// * `OPENPIPE` - OpenPipe<br/>
        /// * `PERPLEXITY` - Perplexity<br/>
        /// * `PYQ` - Pyq<br/>
        /// * `REPLICATE` - Replicate<br/>
        /// * `SAMBANOVA` - SambaNova<br/>
        /// * `TOGETHER_AI` - Together AI<br/>
        /// * `X_AI` - xAI<br/>
        /// * `FASTWEB` - Fastweb<br/>
        /// * `SWISSCOM` - Swisscom
        /// </param>
        /// <param name="modelName"></param>
        /// <param name="type"></param>
        /// <param name="label"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowModelProviderDependency(
            global::Vellum.MLModelHostingInterface name,
            string modelName,
            global::Vellum.ModelProviderEnum type,
            string? label)
        {
            this.Type = type;
            this.Name = name;
            this.Label = label;
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowModelProviderDependency" /> class.
        /// </summary>
        public WorkflowModelProviderDependency()
        {
        }
    }
}