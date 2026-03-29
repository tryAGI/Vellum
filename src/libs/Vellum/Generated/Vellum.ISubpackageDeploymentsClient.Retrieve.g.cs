#nullable enable

namespace Vellum
{
    public partial interface ISubpackageDeploymentsClient
    {
        /// <summary>
        /// Retrieve<br/>
        /// Used to retrieve a Prompt Deployment given its ID or name.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.DeploymentRead> RetrieveAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}