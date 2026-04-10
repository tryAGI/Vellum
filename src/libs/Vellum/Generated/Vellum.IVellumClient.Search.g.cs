#nullable enable

namespace Vellum
{
    public partial interface IVellumClient
    {
        /// <summary>
        /// Search<br/>
        /// Perform a search against a document index.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.SearchResponse> SearchAsync(

            global::Vellum.SearchRequestBodyRequest request,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search<br/>
        /// Perform a search against a document index.
        /// </summary>
        /// <param name="indexId">
        /// The ID of the index to search against. Must provide either this, index_name or document_index.
        /// </param>
        /// <param name="indexName">
        /// The name of the index to search against. Must provide either this, index_id or document_index.
        /// </param>
        /// <param name="query">
        /// The query to search for.
        /// </param>
        /// <param name="options">
        /// Configuration options for the search.
        /// </param>
        /// <param name="documentIndex">
        /// Either the index name or index ID to search against. Must provide either this, index_id or index_name.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.SearchResponse> SearchAsync(
            string query,
            global::System.Guid? indexId = default,
            string? indexName = default,
            global::Vellum.OneOf<global::Vellum.SearchRequestOptionsRequest, object>? options = default,
            string? documentIndex = default,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}