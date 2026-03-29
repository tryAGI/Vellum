
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecutionActual
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ExecutionVellumValueJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.ExecutionVellumValue Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public double? Quality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionActual" /> class.
        /// </summary>
        /// <param name="output"></param>
        /// <param name="timestamp"></param>
        /// <param name="quality"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionActual(
            global::Vellum.ExecutionVellumValue output,
            global::System.DateTime timestamp,
            double? quality,
            object? metadata)
        {
            this.Output = output;
            this.Timestamp = timestamp;
            this.Quality = quality;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionActual" /> class.
        /// </summary>
        public WorkflowExecutionActual()
        {
        }
    }
}