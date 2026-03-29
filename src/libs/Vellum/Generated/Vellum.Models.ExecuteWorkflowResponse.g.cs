
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecuteWorkflowResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExecutionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ExecuteWorkflowWorkflowResultEventJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.ExecuteWorkflowWorkflowResultEvent Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteWorkflowResponse" /> class.
        /// </summary>
        /// <param name="executionId"></param>
        /// <param name="data"></param>
        /// <param name="runId"></param>
        /// <param name="externalId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteWorkflowResponse(
            string executionId,
            global::Vellum.ExecuteWorkflowWorkflowResultEvent data,
            string? runId,
            string? externalId)
        {
            this.ExecutionId = executionId ?? throw new global::System.ArgumentNullException(nameof(executionId));
            this.RunId = runId;
            this.ExternalId = externalId;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteWorkflowResponse" /> class.
        /// </summary>
        public ExecuteWorkflowResponse()
        {
        }
    }
}