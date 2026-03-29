
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowEventError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowEventErrorRawData?, object>))]
        public global::Vellum.OneOf<global::Vellum.WorkflowEventErrorRawData?, object>? RawData { get; set; }

        /// <summary>
        /// * `WORKFLOW_INITIALIZATION` - WORKFLOW_INITIALIZATION<br/>
        /// * `WORKFLOW_CANCELLED` - WORKFLOW_CANCELLED<br/>
        /// * `WORKFLOW_TIMEOUT` - WORKFLOW_TIMEOUT<br/>
        /// * `PROVIDER_CREDENTIALS_UNAVAILABLE` - PROVIDER_CREDENTIALS_UNAVAILABLE<br/>
        /// * `INTEGRATION_CREDENTIALS_UNAVAILABLE` - INTEGRATION_CREDENTIALS_UNAVAILABLE<br/>
        /// * `NODE_EXECUTION_COUNT_LIMIT_REACHED` - NODE_EXECUTION_COUNT_LIMIT_REACHED<br/>
        /// * `INTERNAL_SERVER_ERROR` - INTERNAL_SERVER_ERROR<br/>
        /// * `NODE_EXECUTION` - NODE_EXECUTION<br/>
        /// * `NODE_CANCELLED` - NODE_CANCELLED<br/>
        /// * `NODE_TIMEOUT` - NODE_TIMEOUT<br/>
        /// * `LLM_PROVIDER` - LLM_PROVIDER<br/>
        /// * `INVALID_TEMPLATE` - INVALID_TEMPLATE<br/>
        /// * `INVALID_INPUTS` - INVALID_INPUTS<br/>
        /// * `PROVIDER_QUOTA_EXCEEDED` - PROVIDER_QUOTA_EXCEEDED<br/>
        /// * `USER_DEFINED_ERROR` - USER_DEFINED_ERROR
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.WorkflowExecutionEventErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.WorkflowExecutionEventErrorCode Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stacktrace")]
        public string? Stacktrace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowEventError" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="code">
        /// * `WORKFLOW_INITIALIZATION` - WORKFLOW_INITIALIZATION<br/>
        /// * `WORKFLOW_CANCELLED` - WORKFLOW_CANCELLED<br/>
        /// * `WORKFLOW_TIMEOUT` - WORKFLOW_TIMEOUT<br/>
        /// * `PROVIDER_CREDENTIALS_UNAVAILABLE` - PROVIDER_CREDENTIALS_UNAVAILABLE<br/>
        /// * `INTEGRATION_CREDENTIALS_UNAVAILABLE` - INTEGRATION_CREDENTIALS_UNAVAILABLE<br/>
        /// * `NODE_EXECUTION_COUNT_LIMIT_REACHED` - NODE_EXECUTION_COUNT_LIMIT_REACHED<br/>
        /// * `INTERNAL_SERVER_ERROR` - INTERNAL_SERVER_ERROR<br/>
        /// * `NODE_EXECUTION` - NODE_EXECUTION<br/>
        /// * `NODE_CANCELLED` - NODE_CANCELLED<br/>
        /// * `NODE_TIMEOUT` - NODE_TIMEOUT<br/>
        /// * `LLM_PROVIDER` - LLM_PROVIDER<br/>
        /// * `INVALID_TEMPLATE` - INVALID_TEMPLATE<br/>
        /// * `INVALID_INPUTS` - INVALID_INPUTS<br/>
        /// * `PROVIDER_QUOTA_EXCEEDED` - PROVIDER_QUOTA_EXCEEDED<br/>
        /// * `USER_DEFINED_ERROR` - USER_DEFINED_ERROR
        /// </param>
        /// <param name="rawData"></param>
        /// <param name="stacktrace"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowEventError(
            string message,
            global::Vellum.WorkflowExecutionEventErrorCode code,
            global::Vellum.OneOf<global::Vellum.WorkflowEventErrorRawData?, object>? rawData,
            string? stacktrace)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RawData = rawData;
            this.Code = code;
            this.Stacktrace = stacktrace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowEventError" /> class.
        /// </summary>
        public WorkflowEventError()
        {
        }
    }
}