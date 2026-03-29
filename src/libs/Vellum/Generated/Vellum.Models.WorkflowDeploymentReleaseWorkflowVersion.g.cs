
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The workflow version associated with a workflow deployment release.
    /// </summary>
    public sealed partial class WorkflowDeploymentReleaseWorkflowVersion
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowDependency>? Dependencies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowDeploymentReleaseWorkflowVersion" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="inputVariables"></param>
        /// <param name="outputVariables"></param>
        /// <param name="dependencies"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowDeploymentReleaseWorkflowVersion(
            global::System.Guid id,
            global::System.Collections.Generic.IList<global::Vellum.VellumVariable> inputVariables,
            global::System.Collections.Generic.IList<global::Vellum.VellumVariable> outputVariables,
            global::System.Collections.Generic.IList<global::Vellum.WorkflowDependency>? dependencies)
        {
            this.Id = id;
            this.InputVariables = inputVariables ?? throw new global::System.ArgumentNullException(nameof(inputVariables));
            this.OutputVariables = outputVariables ?? throw new global::System.ArgumentNullException(nameof(outputVariables));
            this.Dependencies = dependencies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowDeploymentReleaseWorkflowVersion" /> class.
        /// </summary>
        public WorkflowDeploymentReleaseWorkflowVersion()
        {
        }
    }
}