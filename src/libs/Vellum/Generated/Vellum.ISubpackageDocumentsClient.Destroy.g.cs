#nullable enable

namespace Vellum
{
    public partial interface ISubpackageDocumentsClient
    {
        /// <summary>
        /// Destroy<br/>
        /// Delete a Document, keying off of either its Vellum-generated ID or its external ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.DocumentsDestroyResponse204> DestroyAsync(
            string id,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}