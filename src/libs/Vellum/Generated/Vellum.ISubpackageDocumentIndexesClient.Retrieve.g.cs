#nullable enable

namespace Vellum
{
    public partial interface ISubpackageDocumentIndexesClient
    {
        /// <summary>
        /// Retrieve<br/>
        /// Used to retrieve a Document Index given its ID or name.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="maskIndexingConfig"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.DocumentIndexRead> RetrieveAsync(
            string id,
            bool? maskIndexingConfig = default,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}