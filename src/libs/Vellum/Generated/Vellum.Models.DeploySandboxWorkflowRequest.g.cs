
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploySandboxWorkflowRequest
    {
        /// <summary>
        /// The Vellum-generated ID of the Workflow Deployment you'd like to update. Cannot specify both this and workflow_deployment_name. Leave null to create a new Workflow Deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_deployment_id")]
        public global::System.Guid? WorkflowDeploymentId { get; set; }

        /// <summary>
        /// The unique name of the Workflow Deployment you'd like to either create or update. Cannot specify both this and workflow_deployment_id. If provided and matches an existing Workflow Deployment, that Workflow Deployment will be updated. Otherwise, a new Prompt Deployment will be created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_deployment_name")]
        public string? WorkflowDeploymentName { get; set; }

        /// <summary>
        /// In the event that a new Workflow Deployment is created, this will be the label it's given.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Optionally provide the release tags that you'd like to be associated with the latest release of the created/updated Prompt Deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_tags")]
        public global::System.Collections.Generic.IList<string>? ReleaseTags { get; set; }

        /// <summary>
        /// Optionally provide a description that details what's new in this Release.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_description")]
        public string? ReleaseDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploySandboxWorkflowRequest" /> class.
        /// </summary>
        /// <param name="workflowDeploymentId">
        /// The Vellum-generated ID of the Workflow Deployment you'd like to update. Cannot specify both this and workflow_deployment_name. Leave null to create a new Workflow Deployment.
        /// </param>
        /// <param name="workflowDeploymentName">
        /// The unique name of the Workflow Deployment you'd like to either create or update. Cannot specify both this and workflow_deployment_id. If provided and matches an existing Workflow Deployment, that Workflow Deployment will be updated. Otherwise, a new Prompt Deployment will be created.
        /// </param>
        /// <param name="label">
        /// In the event that a new Workflow Deployment is created, this will be the label it's given.
        /// </param>
        /// <param name="releaseTags">
        /// Optionally provide the release tags that you'd like to be associated with the latest release of the created/updated Prompt Deployment.
        /// </param>
        /// <param name="releaseDescription">
        /// Optionally provide a description that details what's new in this Release.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploySandboxWorkflowRequest(
            global::System.Guid? workflowDeploymentId,
            string? workflowDeploymentName,
            string? label,
            global::System.Collections.Generic.IList<string>? releaseTags,
            string? releaseDescription)
        {
            this.WorkflowDeploymentId = workflowDeploymentId;
            this.WorkflowDeploymentName = workflowDeploymentName;
            this.Label = label;
            this.ReleaseTags = releaseTags;
            this.ReleaseDescription = releaseDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploySandboxWorkflowRequest" /> class.
        /// </summary>
        public DeploySandboxWorkflowRequest()
        {
        }
    }
}