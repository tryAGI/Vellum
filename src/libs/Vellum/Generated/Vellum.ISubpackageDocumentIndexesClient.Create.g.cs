#nullable enable

namespace Vellum
{
    public partial interface ISubpackageDocumentIndexesClient
    {
        /// <summary>
        /// Create<br/>
        /// Creates a new document index.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.DocumentIndexRead> CreateAsync(

            global::Vellum.DocumentIndexCreateRequest request,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create<br/>
        /// Creates a new document index.
        /// </summary>
        /// <param name="label">
        /// A human-readable label for the document index
        /// </param>
        /// <param name="name">
        /// A name that uniquely identifies this index within its workspace
        /// </param>
        /// <param name="status">
        /// The current status of the document index<br/>
        /// * `ACTIVE` - Active<br/>
        /// * `ARCHIVED` - Archived<br/>
        /// * `PENDING_DELETION` - Pending Deletion
        /// </param>
        /// <param name="indexingConfig"></param>
        /// <param name="copyDocumentsFromIndexId">
        /// Optionally specify the id of a document index from which you'd like to copy and re-index its documents into this newly created index
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.DocumentIndexRead> CreateAsync(
            string label,
            string name,
            global::Vellum.DocumentIndexIndexingConfigRequest indexingConfig,
            global::Vellum.EntityStatus? status = default,
            global::System.Guid? copyDocumentsFromIndexId = default,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}