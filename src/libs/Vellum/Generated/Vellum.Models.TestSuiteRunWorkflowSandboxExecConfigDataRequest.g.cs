
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteRunWorkflowSandboxExecConfigDataRequest
    {
        /// <summary>
        /// The ID of the Workflow Sandbox to run the Test Suite against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_sandbox_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid WorkflowSandboxId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunWorkflowSandboxExecConfigDataRequest" /> class.
        /// </summary>
        /// <param name="workflowSandboxId">
        /// The ID of the Workflow Sandbox to run the Test Suite against.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunWorkflowSandboxExecConfigDataRequest(
            global::System.Guid workflowSandboxId)
        {
            this.WorkflowSandboxId = workflowSandboxId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunWorkflowSandboxExecConfigDataRequest" /> class.
        /// </summary>
        public TestSuiteRunWorkflowSandboxExecConfigDataRequest()
        {
        }
    }
}