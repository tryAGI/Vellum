
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteRunWorkflowReleaseTagExecConfigData
    {
        /// <summary>
        /// The ID of the Workflow Deployment to run the Test Suite against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid WorkflowDeploymentId { get; set; }

        /// <summary>
        /// A tag identifying which release of the Workflow Deployment to run the Test Suite against. Useful for testing past versions of the Workflow Deployment<br/>
        /// Default Value: LATEST
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunWorkflowReleaseTagExecConfigData" /> class.
        /// </summary>
        /// <param name="workflowDeploymentId">
        /// The ID of the Workflow Deployment to run the Test Suite against.
        /// </param>
        /// <param name="tag">
        /// A tag identifying which release of the Workflow Deployment to run the Test Suite against. Useful for testing past versions of the Workflow Deployment<br/>
        /// Default Value: LATEST
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunWorkflowReleaseTagExecConfigData(
            global::System.Guid workflowDeploymentId,
            string? tag)
        {
            this.WorkflowDeploymentId = workflowDeploymentId;
            this.Tag = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunWorkflowReleaseTagExecConfigData" /> class.
        /// </summary>
        public TestSuiteRunWorkflowReleaseTagExecConfigData()
        {
        }
    }
}