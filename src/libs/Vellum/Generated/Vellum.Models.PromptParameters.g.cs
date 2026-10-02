
#nullable enable

namespace Vellum
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptParameters
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public global::System.Collections.Generic.IList<string>? Stop { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public double? TopP { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public double? FrequencyPenalty { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public double? PresencePenalty { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logit_bias")]
        public global::System.Collections.Generic.Dictionary<string, double>? LogitBias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_parameters")]
        public object? CustomParameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptParameters" /> class.
        /// </summary>
        /// <param name="stop"></param>
        /// <param name="temperature"></param>
        /// <param name="maxTokens"></param>
        /// <param name="topP"></param>
        /// <param name="topK"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="logitBias"></param>
        /// <param name="customParameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptParameters(
            global::System.Collections.Generic.IList<string>? stop,
            double? temperature,
            int? maxTokens,
            double? topP,
            int? topK,
            double? frequencyPenalty,
            double? presencePenalty,
            global::System.Collections.Generic.Dictionary<string, double>? logitBias,
            object? customParameters)
        {
            this.Stop = stop;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
            this.TopP = topP;
            this.TopK = topK;
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
            this.LogitBias = logitBias;
            this.CustomParameters = customParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptParameters" /> class.
        /// </summary>
        public PromptParameters()
        {
        }

    }
}