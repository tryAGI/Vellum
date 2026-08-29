
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Information used to display this Workflow Sandbox.
    /// </summary>
    public sealed partial class WorkflowSandboxDisplayData
    {
        /// <summary>
        /// The icon associated with this Workflow Sandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public global::Vellum.WorkflowDisplayIcon? Icon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowSandboxDisplayData" /> class.
        /// </summary>
        /// <param name="icon">
        /// The icon associated with this Workflow Sandbox.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowSandboxDisplayData(
            global::Vellum.WorkflowDisplayIcon? icon)
        {
            this.Icon = icon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowSandboxDisplayData" /> class.
        /// </summary>
        public WorkflowSandboxDisplayData()
        {
        }

    }
}