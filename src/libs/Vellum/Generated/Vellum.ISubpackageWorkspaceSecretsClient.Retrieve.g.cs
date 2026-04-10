#nullable enable

namespace Vellum
{
    public partial interface ISubpackageWorkspaceSecretsClient
    {
        /// <summary>
        /// Retrieve<br/>
        /// Used to retrieve a Workspace Secret given its ID or name.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.WorkspaceSecretRead> RetrieveAsync(
            string id,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}