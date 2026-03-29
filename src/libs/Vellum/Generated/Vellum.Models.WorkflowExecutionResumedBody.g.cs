
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecutionResumedBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.VellumCodeResourceDefinition WorkflowDefinition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionResumedBody" /> class.
        /// </summary>
        /// <param name="workflowDefinition"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionResumedBody(
            global::Vellum.VellumCodeResourceDefinition workflowDefinition)
        {
            this.WorkflowDefinition = workflowDefinition ?? throw new global::System.ArgumentNullException(nameof(workflowDefinition));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionResumedBody" /> class.
        /// </summary>
        public WorkflowExecutionResumedBody()
        {
        }
    }
}