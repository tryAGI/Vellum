
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Workflow Deployment display data
    /// </summary>
    public sealed partial class WorkflowDeploymentDisplayData
    {
        /// <summary>
        /// The icon associated with this Workflow Deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowDisplayIcon, object>))]
        public global::Vellum.OneOf<global::Vellum.WorkflowDisplayIcon, object>? Icon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowDeploymentDisplayData" /> class.
        /// </summary>
        /// <param name="icon">
        /// The icon associated with this Workflow Deployment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowDeploymentDisplayData(
            global::Vellum.OneOf<global::Vellum.WorkflowDisplayIcon, object>? icon)
        {
            this.Icon = icon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowDeploymentDisplayData" /> class.
        /// </summary>
        public WorkflowDeploymentDisplayData()
        {
        }
    }
}