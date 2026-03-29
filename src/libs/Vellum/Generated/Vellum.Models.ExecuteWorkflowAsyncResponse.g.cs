
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The response from an async Workflow Deployment execution.
    /// </summary>
    public sealed partial class ExecuteWorkflowAsyncResponse
    {
        /// <summary>
        /// The ID of the workflow execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExecutionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteWorkflowAsyncResponse" /> class.
        /// </summary>
        /// <param name="executionId">
        /// The ID of the workflow execution.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteWorkflowAsyncResponse(
            string executionId)
        {
            this.ExecutionId = executionId ?? throw new global::System.ArgumentNullException(nameof(executionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteWorkflowAsyncResponse" /> class.
        /// </summary>
        public ExecuteWorkflowAsyncResponse()
        {
        }
    }
}