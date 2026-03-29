#nullable enable

namespace Vellum
{
    public partial interface ISubpackageDeploymentsClient
    {
        /// <summary>
        /// Retrieve Provider Payload<br/>
        /// Given a set of input variable values, compile the exact payload that Vellum would send to the configured model provider<br/>
        /// for execution if the execute-prompt endpoint had been invoked. Note that this endpoint does not actually execute the<br/>
        /// prompt or make an API call to the model provider.<br/>
        /// This endpoint is useful if you don't want to proxy LLM provider requests through Vellum and prefer to send them directly<br/>
        /// to the provider yourself. Note that no guarantees are made on the format of this API's response schema, other than<br/>
        /// that it will be a valid payload for the configured model provider. It's not recommended that you try to parse or<br/>
        /// derive meaning from the response body and instead, should simply pass it directly to the model provider as is.<br/>
        /// We encourage you to seek advise from Vellum Support before integrating with this API for production use.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.DeploymentProviderPayloadResponse> RetrieveProviderPayloadAsync(

            global::Vellum.DeploymentProviderPayloadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve Provider Payload<br/>
        /// Given a set of input variable values, compile the exact payload that Vellum would send to the configured model provider<br/>
        /// for execution if the execute-prompt endpoint had been invoked. Note that this endpoint does not actually execute the<br/>
        /// prompt or make an API call to the model provider.<br/>
        /// This endpoint is useful if you don't want to proxy LLM provider requests through Vellum and prefer to send them directly<br/>
        /// to the provider yourself. Note that no guarantees are made on the format of this API's response schema, other than<br/>
        /// that it will be a valid payload for the configured model provider. It's not recommended that you try to parse or<br/>
        /// derive meaning from the response body and instead, should simply pass it directly to the model provider as is.<br/>
        /// We encourage you to seek advise from Vellum Support before integrating with this API for production use.
        /// </summary>
        /// <param name="deploymentId">
        /// The ID of the deployment. Must provide either this or deployment_name.
        /// </param>
        /// <param name="deploymentName">
        /// The name of the deployment. Must provide either this or deployment_id.
        /// </param>
        /// <param name="inputs">
        /// The list of inputs defined in the Prompt's deployment with their corresponding values.
        /// </param>
        /// <param name="releaseTag">
        /// Optionally specify a release tag if you want to pin to a specific release of the Workflow Deployment
        /// </param>
        /// <param name="expandMeta"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.DeploymentProviderPayloadResponse> RetrieveProviderPayloadAsync(
            global::System.Collections.Generic.IList<global::Vellum.PromptDeploymentInputRequest> inputs,
            global::System.Guid? deploymentId = default,
            string? deploymentName = default,
            string? releaseTag = default,
            global::Vellum.OneOf<global::Vellum.CompilePromptDeploymentExpandMetaRequest, object>? expandMeta = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}