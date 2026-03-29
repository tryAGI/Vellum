
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitWorkflowExecutionActualsRequest
    {
        /// <summary>
        /// Feedback regarding the quality of an output on a previously executed workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actuals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.SubmitWorkflowExecutionActualRequest> Actuals { get; set; }

        /// <summary>
        /// The Vellum-generated ID of a previously executed workflow. Must provide either this or external_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_id")]
        public global::System.Guid? ExecutionId { get; set; }

        /// <summary>
        /// The external ID that was originally provided by when executing the workflow, if applicable, that you'd now like to submit actuals for. Must provide either this or execution_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitWorkflowExecutionActualsRequest" /> class.
        /// </summary>
        /// <param name="actuals">
        /// Feedback regarding the quality of an output on a previously executed workflow.
        /// </param>
        /// <param name="executionId">
        /// The Vellum-generated ID of a previously executed workflow. Must provide either this or external_id.
        /// </param>
        /// <param name="externalId">
        /// The external ID that was originally provided by when executing the workflow, if applicable, that you'd now like to submit actuals for. Must provide either this or execution_id.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitWorkflowExecutionActualsRequest(
            global::System.Collections.Generic.IList<global::Vellum.SubmitWorkflowExecutionActualRequest> actuals,
            global::System.Guid? executionId,
            string? externalId)
        {
            this.Actuals = actuals ?? throw new global::System.ArgumentNullException(nameof(actuals));
            this.ExecutionId = executionId;
            this.ExternalId = externalId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitWorkflowExecutionActualsRequest" /> class.
        /// </summary>
        public SubmitWorkflowExecutionActualsRequest()
        {
        }
    }
}