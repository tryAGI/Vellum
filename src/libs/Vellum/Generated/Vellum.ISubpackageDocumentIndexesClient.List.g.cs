#nullable enable

namespace Vellum
{
    public partial interface ISubpackageDocumentIndexesClient
    {
        /// <summary>
        /// List<br/>
        /// Used to retrieve a list of Document Indexes.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="ordering"></param>
        /// <param name="search"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.PaginatedDocumentIndexReadList> ListAsync(
            int? limit = default,
            int? offset = default,
            string? ordering = default,
            string? search = default,
            global::Vellum.V1DocumentIndexesGetParametersStatus? status = default,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}