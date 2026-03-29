
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecutionActualJsonRequest
    {
        /// <summary>
        /// The Vellum-generated ID of a workflow output. Must provide either this or output_key. output_key is typically preferred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_id")]
        public global::System.Guid? OutputId { get; set; }

        /// <summary>
        /// The user-defined name of a workflow output. Must provide either this or output_id. Should correspond to the `Name` specified in a Final Output Node. Generally preferred over output_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_key")]
        public string? OutputKey { get; set; }

        /// <summary>
        /// Optionally provide a decimal number between 0.0 and 1.0 (inclusive) representing the quality of the output. 0 is the worst, 1 is the best.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public double? Quality { get; set; }

        /// <summary>
        /// Optionally provide additional metadata about the feedback submission.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Optionally provide the timestamp representing when this feedback was collected. Used for reporting purposes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// The variable type of the output that this actual is being submitted for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.JsonEnumJsonConverter))]
        public global::Vellum.JsonEnum OutputType { get; set; }

        /// <summary>
        /// Optionally provide the value that the output ideally should have been.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("desired_output_value")]
        public object? DesiredOutputValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionActualJsonRequest" /> class.
        /// </summary>
        /// <param name="outputId">
        /// The Vellum-generated ID of a workflow output. Must provide either this or output_key. output_key is typically preferred.
        /// </param>
        /// <param name="outputKey">
        /// The user-defined name of a workflow output. Must provide either this or output_id. Should correspond to the `Name` specified in a Final Output Node. Generally preferred over output_id.
        /// </param>
        /// <param name="quality">
        /// Optionally provide a decimal number between 0.0 and 1.0 (inclusive) representing the quality of the output. 0 is the worst, 1 is the best.
        /// </param>
        /// <param name="metadata">
        /// Optionally provide additional metadata about the feedback submission.
        /// </param>
        /// <param name="timestamp">
        /// Optionally provide the timestamp representing when this feedback was collected. Used for reporting purposes.
        /// </param>
        /// <param name="outputType">
        /// The variable type of the output that this actual is being submitted for.
        /// </param>
        /// <param name="desiredOutputValue">
        /// Optionally provide the value that the output ideally should have been.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionActualJsonRequest(
            global::System.Guid? outputId,
            string? outputKey,
            double? quality,
            object? metadata,
            double? timestamp,
            global::Vellum.JsonEnum outputType,
            object? desiredOutputValue)
        {
            this.OutputId = outputId;
            this.OutputKey = outputKey;
            this.Quality = quality;
            this.Metadata = metadata;
            this.Timestamp = timestamp;
            this.OutputType = outputType;
            this.DesiredOutputValue = desiredOutputValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionActualJsonRequest" /> class.
        /// </summary>
        public WorkflowExecutionActualJsonRequest()
        {
        }
    }
}