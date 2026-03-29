
#nullable enable

namespace Vellum
{
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
    public enum MLModelHostingInterface
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        AwsBedrock,
        /// <summary>
        /// 
        /// </summary>
        AzureAiFoundry,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        Baseten,
        /// <summary>
        /// 
        /// </summary>
        Cerebras,
        /// <summary>
        /// 
        /// </summary>
        Cohere,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        DeepSeek,
        /// <summary>
        /// 
        /// </summary>
        Fastweb,
        /// <summary>
        /// 
        /// </summary>
        FireworksAi,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        GoogleVertexAi,
        /// <summary>
        /// 
        /// </summary>
        Groq,
        /// <summary>
        /// 
        /// </summary>
        Huggingface,
        /// <summary>
        /// 
        /// </summary>
        IbmWatsonx,
        /// <summary>
        /// 
        /// </summary>
        MistralAi,
        /// <summary>
        /// 
        /// </summary>
        Mosaicml,
        /// <summary>
        /// 
        /// </summary>
        Mystic,
        /// <summary>
        /// 
        /// </summary>
        Nvidia,
        /// <summary>
        /// 
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        Openpipe,
        /// <summary>
        /// 
        /// </summary>
        OpenRouter,
        /// <summary>
        /// 
        /// </summary>
        Perplexity,
        /// <summary>
        /// 
        /// </summary>
        Pyq,
        /// <summary>
        /// 
        /// </summary>
        Replicate,
        /// <summary>
        /// 
        /// </summary>
        Sambanova,
        /// <summary>
        /// 
        /// </summary>
        Swisscom,
        /// <summary>
        /// 
        /// </summary>
        TogetherAi,
        /// <summary>
        /// 
        /// </summary>
        XAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MLModelHostingInterfaceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MLModelHostingInterface value)
        {
            return value switch
            {
                MLModelHostingInterface.Anthropic => "ANTHROPIC",
                MLModelHostingInterface.AwsBedrock => "AWS_BEDROCK",
                MLModelHostingInterface.AzureAiFoundry => "AZURE_AI_FOUNDRY",
                MLModelHostingInterface.AzureOpenai => "AZURE_OPENAI",
                MLModelHostingInterface.Baseten => "BASETEN",
                MLModelHostingInterface.Cerebras => "CEREBRAS",
                MLModelHostingInterface.Cohere => "COHERE",
                MLModelHostingInterface.Custom => "CUSTOM",
                MLModelHostingInterface.DeepSeek => "DEEP_SEEK",
                MLModelHostingInterface.Fastweb => "FASTWEB",
                MLModelHostingInterface.FireworksAi => "FIREWORKS_AI",
                MLModelHostingInterface.Google => "GOOGLE",
                MLModelHostingInterface.GoogleVertexAi => "GOOGLE_VERTEX_AI",
                MLModelHostingInterface.Groq => "GROQ",
                MLModelHostingInterface.Huggingface => "HUGGINGFACE",
                MLModelHostingInterface.IbmWatsonx => "IBM_WATSONX",
                MLModelHostingInterface.MistralAi => "MISTRAL_AI",
                MLModelHostingInterface.Mosaicml => "MOSAICML",
                MLModelHostingInterface.Mystic => "MYSTIC",
                MLModelHostingInterface.Nvidia => "NVIDIA",
                MLModelHostingInterface.Openai => "OPENAI",
                MLModelHostingInterface.Openpipe => "OPENPIPE",
                MLModelHostingInterface.OpenRouter => "OPEN_ROUTER",
                MLModelHostingInterface.Perplexity => "PERPLEXITY",
                MLModelHostingInterface.Pyq => "PYQ",
                MLModelHostingInterface.Replicate => "REPLICATE",
                MLModelHostingInterface.Sambanova => "SAMBANOVA",
                MLModelHostingInterface.Swisscom => "SWISSCOM",
                MLModelHostingInterface.TogetherAi => "TOGETHER_AI",
                MLModelHostingInterface.XAi => "X_AI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MLModelHostingInterface? ToEnum(string value)
        {
            return value switch
            {
                "ANTHROPIC" => MLModelHostingInterface.Anthropic,
                "AWS_BEDROCK" => MLModelHostingInterface.AwsBedrock,
                "AZURE_AI_FOUNDRY" => MLModelHostingInterface.AzureAiFoundry,
                "AZURE_OPENAI" => MLModelHostingInterface.AzureOpenai,
                "BASETEN" => MLModelHostingInterface.Baseten,
                "CEREBRAS" => MLModelHostingInterface.Cerebras,
                "COHERE" => MLModelHostingInterface.Cohere,
                "CUSTOM" => MLModelHostingInterface.Custom,
                "DEEP_SEEK" => MLModelHostingInterface.DeepSeek,
                "FASTWEB" => MLModelHostingInterface.Fastweb,
                "FIREWORKS_AI" => MLModelHostingInterface.FireworksAi,
                "GOOGLE" => MLModelHostingInterface.Google,
                "GOOGLE_VERTEX_AI" => MLModelHostingInterface.GoogleVertexAi,
                "GROQ" => MLModelHostingInterface.Groq,
                "HUGGINGFACE" => MLModelHostingInterface.Huggingface,
                "IBM_WATSONX" => MLModelHostingInterface.IbmWatsonx,
                "MISTRAL_AI" => MLModelHostingInterface.MistralAi,
                "MOSAICML" => MLModelHostingInterface.Mosaicml,
                "MYSTIC" => MLModelHostingInterface.Mystic,
                "NVIDIA" => MLModelHostingInterface.Nvidia,
                "OPENAI" => MLModelHostingInterface.Openai,
                "OPENPIPE" => MLModelHostingInterface.Openpipe,
                "OPEN_ROUTER" => MLModelHostingInterface.OpenRouter,
                "PERPLEXITY" => MLModelHostingInterface.Perplexity,
                "PYQ" => MLModelHostingInterface.Pyq,
                "REPLICATE" => MLModelHostingInterface.Replicate,
                "SAMBANOVA" => MLModelHostingInterface.Sambanova,
                "SWISSCOM" => MLModelHostingInterface.Swisscom,
                "TOGETHER_AI" => MLModelHostingInterface.TogetherAi,
                "X_AI" => MLModelHostingInterface.XAi,
                _ => null,
            };
        }
    }
}