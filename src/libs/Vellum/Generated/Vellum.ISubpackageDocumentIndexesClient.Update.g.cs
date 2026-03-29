#nullable enable

namespace Vellum
{
    public partial interface ISubpackageDocumentIndexesClient
    {
        /// <summary>
        /// Update<br/>
        /// Used to fully update a Document Index given its ID or name.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.DocumentIndexRead> UpdateAsync(
            string id,

            global::Vellum.DocumentIndexUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update<br/>
        /// Used to fully update a Document Index given its ID or name.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="label">
        /// A human-readable label for the document index
        /// </param>
        /// <param name="status">
        /// The current status of the document index<br/>
        /// * `ACTIVE` - Active<br/>
        /// * `ARCHIVED` - Archived<br/>
        /// * `PENDING_DELETION` - Pending Deletion
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.DocumentIndexRead> UpdateAsync(
            string id,
            string label,
            global::Vellum.EntityStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}