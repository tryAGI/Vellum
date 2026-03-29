
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowDeploymentHistoryItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid WorkflowDeploymentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// A human-readable label for the workflow deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// A name that uniquely identifies this workflow deployment within its workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.VellumVariable> InputVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.VellumVariable> OutputVariables { get; set; }

        /// <summary>
        /// A human-readable description of the workflow deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowDeploymentHistoryItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="workflowDeploymentId"></param>
        /// <param name="timestamp"></param>
        /// <param name="label">
        /// A human-readable label for the workflow deployment
        /// </param>
        /// <param name="name">
        /// A name that uniquely identifies this workflow deployment within its workspace
        /// </param>
        /// <param name="inputVariables"></param>
        /// <param name="outputVariables"></param>
        /// <param name="description">
        /// A human-readable description of the workflow deployment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowDeploymentHistoryItem(
            global::System.Guid id,
            global::System.Guid workflowDeploymentId,
            global::System.DateTime timestamp,
            string label,
            string name,
            global::System.Collections.Generic.IList<global::Vellum.VellumVariable> inputVariables,
            global::System.Collections.Generic.IList<global::Vellum.VellumVariable> outputVariables,
            string? description)
        {
            this.Id = id;
            this.WorkflowDeploymentId = workflowDeploymentId;
            this.Timestamp = timestamp;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.InputVariables = inputVariables ?? throw new global::System.ArgumentNullException(nameof(inputVariables));
            this.OutputVariables = outputVariables ?? throw new global::System.ArgumentNullException(nameof(outputVariables));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowDeploymentHistoryItem" /> class.
        /// </summary>
        public WorkflowDeploymentHistoryItem()
        {
        }
    }
}