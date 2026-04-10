#nullable enable

namespace Vellum
{
    public partial interface ISubpackageWorkflowSandboxesClient
    {
        /// <summary>
        /// Deploy Workflow
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.WorkflowDeploymentRead> DeployWorkflowAsync(
            global::System.Guid id,

            global::Vellum.DeploySandboxWorkflowRequest request,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deploy Workflow
        /// </summary>
        /// <param name="id"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.WorkflowDeploymentRead> DeployWorkflowAsync(
            global::System.Guid id,
            global::System.Guid? workflowDeploymentId = default,
            string? workflowDeploymentName = default,
            string? label = default,
            global::System.Collections.Generic.IList<string>? releaseTags = default,
            string? releaseDescription = default,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}