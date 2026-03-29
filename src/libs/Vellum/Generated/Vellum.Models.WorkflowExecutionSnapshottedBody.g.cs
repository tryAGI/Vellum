
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecutionSnapshottedBody
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
        [global::System.Text.Json.Serialization.JsonPropertyName("edited_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumCodeResourceDefinition, object>))]
        public global::Vellum.OneOf<global::Vellum.VellumCodeResourceDefinition, object>? EditedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionSnapshottedBody" /> class.
        /// </summary>
        /// <param name="workflowDefinition"></param>
        /// <param name="state"></param>
        /// <param name="editedBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionSnapshottedBody(
            global::Vellum.VellumCodeResourceDefinition workflowDefinition,
            object state,
            global::Vellum.OneOf<global::Vellum.VellumCodeResourceDefinition, object>? editedBy)
        {
            this.WorkflowDefinition = workflowDefinition ?? throw new global::System.ArgumentNullException(nameof(workflowDefinition));
            this.EditedBy = editedBy;
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionSnapshottedBody" /> class.
        /// </summary>
        public WorkflowExecutionSnapshottedBody()
        {
        }
    }
}