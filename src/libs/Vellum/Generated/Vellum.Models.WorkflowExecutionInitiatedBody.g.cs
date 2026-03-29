
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecutionInitiatedBody
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
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Inputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumCodeResourceDefinition, object>))]
        public global::Vellum.OneOf<global::Vellum.VellumCodeResourceDefinition, object>? Trigger { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionInitiatedBody" /> class.
        /// </summary>
        /// <param name="workflowDefinition"></param>
        /// <param name="inputs"></param>
        /// <param name="trigger"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecutionInitiatedBody(
            global::Vellum.VellumCodeResourceDefinition workflowDefinition,
            object inputs,
            global::Vellum.OneOf<global::Vellum.VellumCodeResourceDefinition, object>? trigger)
        {
            this.WorkflowDefinition = workflowDefinition ?? throw new global::System.ArgumentNullException(nameof(workflowDefinition));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Trigger = trigger;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionInitiatedBody" /> class.
        /// </summary>
        public WorkflowExecutionInitiatedBody()
        {
        }
    }
}