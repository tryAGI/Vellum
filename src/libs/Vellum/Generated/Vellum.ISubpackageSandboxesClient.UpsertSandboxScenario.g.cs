#nullable enable

namespace Vellum
{
    public partial interface ISubpackageSandboxesClient
    {
        /// <summary>
        /// Upsert Sandbox Scenario<br/>
        /// Upserts a new scenario for a sandbox, keying off of the optionally provided scenario id.<br/>
        /// If an id is provided and has a match, the scenario will be updated. If no id is provided or no match<br/>
        /// is found, a new scenario will be appended to the end.<br/>
        /// Note that a full replacement of the scenario is performed, so any fields not provided will be removed<br/>
        /// or overwritten with default values.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.SandboxScenario> UpsertSandboxScenarioAsync(
            global::System.Guid id,

            global::Vellum.UpsertSandboxScenarioRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert Sandbox Scenario<br/>
        /// Upserts a new scenario for a sandbox, keying off of the optionally provided scenario id.<br/>
        /// If an id is provided and has a match, the scenario will be updated. If no id is provided or no match<br/>
        /// is found, a new scenario will be appended to the end.<br/>
        /// Note that a full replacement of the scenario is performed, so any fields not provided will be removed<br/>
        /// or overwritten with default values.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="label">
        /// Default Value: Untitled Scenario
        /// </param>
        /// <param name="inputs">
        /// The inputs for the scenario
        /// </param>
        /// <param name="scenarioId">
        /// The id of the scenario to update. If none is provided, an id will be generated and a new scenario will be appended.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.SandboxScenario> UpsertSandboxScenarioAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<global::Vellum.NamedScenarioInputRequest> inputs,
            string? label = default,
            string? scenarioId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}