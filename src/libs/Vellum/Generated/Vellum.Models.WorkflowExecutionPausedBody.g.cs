
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecutionPausedBody
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
        [global::System.Text.Json.Serialization.JsonPropertyName("external_inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.ExternalInputDescriptor> ExternalInputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionPausedBody" /> class.
        /// </summary>
        /// <param name="workflowDefinition"></param>
        /// <param name="externalInputs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionPausedBody(
            global::Vellum.VellumCodeResourceDefinition workflowDefinition,
            global::System.Collections.Generic.IList<global::Vellum.ExternalInputDescriptor> externalInputs)
        {
            this.WorkflowDefinition = workflowDefinition ?? throw new global::System.ArgumentNullException(nameof(workflowDefinition));
            this.ExternalInputs = externalInputs ?? throw new global::System.ArgumentNullException(nameof(externalInputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionPausedBody" /> class.
        /// </summary>
        public WorkflowExecutionPausedBody()
        {
        }
    }
}