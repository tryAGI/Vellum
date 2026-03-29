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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.SandboxesDeleteSandboxScenarioResponse204> DeleteSandboxScenarioAsync(
            global::System.Guid id,
            string scenarioId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}