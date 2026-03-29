
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptNodeResultData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_meta")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.PromptNodeExecutionMeta, object>))]
        public global::Vellum.OneOf<global::Vellum.PromptNodeExecutionMeta, object>? ExecutionMeta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutputId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("array_output_id")]
        public string? ArrayOutputId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        public string? ExecutionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public string? Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptNodeResultData" /> class.
        /// </summary>
        /// <param name="outputId"></param>
        /// <param name="executionMeta"></param>
        /// <param name="arrayOutputId"></param>
        /// <param name="executionId"></param>
        /// <param name="text"></param>
        /// <param name="delta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptNodeResultData(
            string outputId,
            global::Vellum.OneOf<global::Vellum.PromptNodeExecutionMeta, object>? executionMeta,
            string? arrayOutputId,
            string? executionId,
            string? text,
            string? delta)
        {
            this.ExecutionMeta = executionMeta;
            this.OutputId = outputId ?? throw new global::System.ArgumentNullException(nameof(outputId));
            this.ArrayOutputId = arrayOutputId;
            this.ExecutionId = executionId;
            this.Text = text;
            this.Delta = delta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptNodeResultData" /> class.
        /// </summary>
        public PromptNodeResultData()
        {
        }
    }
}