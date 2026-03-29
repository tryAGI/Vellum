
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A subset of a Workflow Deployment's full details.
    /// </summary>
    public sealed partial class SlimWorkflowDeployment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// A name that uniquely identifies this workflow deployment within its workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A human-readable label for the workflow deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// The current status of the workflow deployment<br/>
        /// * `ACTIVE` - Active<br/>
        /// * `ARCHIVED` - Archived<br/>
        /// * `PENDING_DELETION` - Pending Deletion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.EntityStatusJsonConverter))]
        public global::Vellum.EntityStatus? Status { get; set; }

        /// <summary>
        /// Deprecated. The value returned will always be 'PRODUCTION'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.EnvironmentEnum?, object>))]
        public global::Vellum.OneOf<global::Vellum.EnvironmentEnum?, object>? Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_deployed_on")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastDeployedOn { get; set; }

        /// <summary>
        /// The input variables this Workflow Deployment expects to receive values for when it is executed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.VellumVariable> InputVariables { get; set; }

        /// <summary>
        /// The output variables this Workflow Deployment will produce when it is executed.
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
        /// Initializes a new instance of the <see cref="SlimWorkflowDeployment" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// A name that uniquely identifies this workflow deployment within its workspace
        /// </param>
        /// <param name="label">
        /// A human-readable label for the workflow deployment
        /// </param>
        /// <param name="created"></param>
        /// <param name="lastDeployedOn"></param>
        /// <param name="inputVariables">
        /// The input variables this Workflow Deployment expects to receive values for when it is executed.
        /// </param>
        /// <param name="outputVariables">
        /// The output variables this Workflow Deployment will produce when it is executed.
        /// </param>
        /// <param name="status">
        /// The current status of the workflow deployment<br/>
        /// * `ACTIVE` - Active<br/>
        /// * `ARCHIVED` - Archived<br/>
        /// * `PENDING_DELETION` - Pending Deletion
        /// </param>
        /// <param name="environment">
        /// Deprecated. The value returned will always be 'PRODUCTION'.
        /// </param>
        /// <param name="description">
        /// A human-readable description of the workflow deployment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlimWorkflowDeployment(
            global::System.Guid id,
            string name,
            string label,
            global::System.DateTime created,
            global::System.DateTime lastDeployedOn,
            global::System.Collections.Generic.IList<global::Vellum.VellumVariable> inputVariables,
            global::System.Collections.Generic.IList<global::Vellum.VellumVariable> outputVariables,
            global::Vellum.EntityStatus? status,
            global::Vellum.OneOf<global::Vellum.EnvironmentEnum?, object>? environment,
            string? description)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Status = status;
            this.Environment = environment;
            this.Created = created;
            this.LastDeployedOn = lastDeployedOn;
            this.InputVariables = inputVariables ?? throw new global::System.ArgumentNullException(nameof(inputVariables));
            this.OutputVariables = outputVariables ?? throw new global::System.ArgumentNullException(nameof(outputVariables));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlimWorkflowDeployment" /> class.
        /// </summary>
        public SlimWorkflowDeployment()
        {
        }
    }
}