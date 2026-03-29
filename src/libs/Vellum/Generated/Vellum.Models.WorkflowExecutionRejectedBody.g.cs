
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecutionRejectedBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.VellumCodeResourceDefinition WorkflowDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.VellumSdkError Error { get; set; }

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
        /// Initializes a new instance of the <see cref="WorkflowExecutionRejectedBody" /> class.
        /// </summary>
        /// <param name="workflowDefinition"></param>
        /// <param name="error"></param>
        /// <param name="stacktrace"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionRejectedBody(
            global::Vellum.VellumCodeResourceDefinition workflowDefinition,
            global::Vellum.VellumSdkError error,
            string? stacktrace)
        {
            this.WorkflowDefinition = workflowDefinition ?? throw new global::System.ArgumentNullException(nameof(workflowDefinition));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Stacktrace = stacktrace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionRejectedBody" /> class.
        /// </summary>
        public WorkflowExecutionRejectedBody()
        {
        }
    }
}