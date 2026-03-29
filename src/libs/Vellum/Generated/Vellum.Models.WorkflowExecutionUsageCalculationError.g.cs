
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecutionUsageCalculationError
    {
        /// <summary>
        /// * `UNKNOWN` - UNKNOWN<br/>
        /// * `DEPENDENCIES_FAILED` - DEPENDENCIES_FAILED<br/>
        /// * `NO_USAGE_CALCULATED` - NO_USAGE_CALCULATED<br/>
        /// * `INTERNAL_SERVER_ERROR` - INTERNAL_SERVER_ERROR
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.WorkflowExecutionUsageCalculationErrorCodeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.WorkflowExecutionUsageCalculationErrorCodeEnum Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionUsageCalculationError" /> class.
        /// </summary>
        /// <param name="code">
        /// * `UNKNOWN` - UNKNOWN<br/>
        /// * `DEPENDENCIES_FAILED` - DEPENDENCIES_FAILED<br/>
        /// * `NO_USAGE_CALCULATED` - NO_USAGE_CALCULATED<br/>
        /// * `INTERNAL_SERVER_ERROR` - INTERNAL_SERVER_ERROR
        /// </param>
        /// <param name="message"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionUsageCalculationError(
            global::Vellum.WorkflowExecutionUsageCalculationErrorCodeEnum code,
            string message)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionUsageCalculationError" /> class.
        /// </summary>
        public WorkflowExecutionUsageCalculationError()
        {
        }
    }
}