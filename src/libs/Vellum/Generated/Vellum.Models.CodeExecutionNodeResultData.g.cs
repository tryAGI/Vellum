
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeExecutionNodeResultData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.CodeExecutionNodeResultOutputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.CodeExecutionNodeResultOutput Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_output_id")]
        public string? LogOutputId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeExecutionNodeResultData" /> class.
        /// </summary>
        /// <param name="output"></param>
        /// <param name="logOutputId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeExecutionNodeResultData(
            global::Vellum.CodeExecutionNodeResultOutput output,
            string? logOutputId)
        {
            this.Output = output;
            this.LogOutputId = logOutputId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeExecutionNodeResultData" /> class.
        /// </summary>
        public CodeExecutionNodeResultData()
        {
        }
    }
}