#nullable enable

namespace Vellum
{
    public partial interface IVellumClient
    {
        /// <summary>
        /// Execute Prompt Stream<br/>
        /// Executes a deployed Prompt and streams back the results.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Vellum.ExecutePromptEvent> ExecutePromptStreamAsync(

            global::Vellum.ExecutePromptStreamRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute Prompt Stream<br/>
        /// Executes a deployed Prompt and streams back the results.
        /// </summary>
        /// <param name="inputs">
        /// A list consisting of the Prompt Deployment's input variables and their values.
        /// </param>
        /// <param name="promptDeploymentId">
        /// The ID of the Prompt Deployment. Must provide either this or prompt_deployment_name.
        /// </param>
        /// <param name="promptDeploymentName">
        /// The unique name of the Prompt Deployment. Must provide either this or prompt_deployment_id.
        /// </param>
        /// <param name="releaseTag">
        /// Optionally specify a release tag if you want to pin to a specific release of the Prompt Deployment
        /// </param>
        /// <param name="externalId">
        /// Optionally include a unique identifier for tracking purposes. Must be unique within a given Workspace.
        /// </param>
        /// <param name="expandMeta">
        /// An optionally specified configuration used to opt in to including additional metadata about this prompt execution in the API response. Corresponding values will be returned under the `meta` key of the API response.
        /// </param>
        /// <param name="rawOverrides">
        /// Overrides for the raw API request sent to the model host. Combined with `expand_raw`, it can be used to access new features from models.
        /// </param>
        /// <param name="expandRaw">
        /// A list of keys whose values you'd like to directly return from the JSON response of the model provider. Useful if you need lower-level info returned by model providers that Vellum would otherwise omit. Corresponding key/value pairs will be returned under the `raw` key of the API response.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary JSON metadata associated with this request. Can be used to capture additional monitoring data such as user id, session id, etc. for future analysis.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Vellum.ExecutePromptEvent> ExecutePromptStreamAsync(
            global::System.Collections.Generic.IList<global::Vellum.PromptDeploymentInputRequest> inputs,
            global::System.Guid? promptDeploymentId = default,
            string? promptDeploymentName = default,
            string? releaseTag = default,
            string? externalId = default,
            global::Vellum.OneOf<global::Vellum.PromptDeploymentExpandMetaRequest, object>? expandMeta = default,
            global::Vellum.OneOf<global::Vellum.RawPromptExecutionOverridesRequest, object>? rawOverrides = default,
            global::System.Collections.Generic.IList<string>? expandRaw = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}