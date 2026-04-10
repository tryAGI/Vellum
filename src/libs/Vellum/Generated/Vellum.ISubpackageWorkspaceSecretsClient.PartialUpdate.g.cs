#nullable enable

namespace Vellum
{
    public partial interface ISubpackageWorkspaceSecretsClient
    {
        /// <summary>
        /// Partial Update<br/>
        /// Used to update a Workspace Secret given its ID or name.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.WorkspaceSecretRead> PartialUpdateAsync(
            string id,

            global::Vellum.PatchedWorkspaceSecretUpdateRequest request,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partial Update<br/>
        /// Used to update a Workspace Secret given its ID or name.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="label"></param>
        /// <param name="value"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.WorkspaceSecretRead> PartialUpdateAsync(
            string id,
            string? label = default,
            string? value = default,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}