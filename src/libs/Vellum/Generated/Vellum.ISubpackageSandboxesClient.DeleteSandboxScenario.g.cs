#nullable enable

namespace Vellum
{
    public partial interface ISubpackageSandboxesClient
    {
        /// <summary>
        /// Delete Sandbox Scenario<br/>
        /// Deletes an existing scenario from a sandbox, keying off of the provided scenario id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="scenarioId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.SandboxesDeleteSandboxScenarioResponse204> DeleteSandboxScenarioAsync(
            global::System.Guid id,
            string scenarioId,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}