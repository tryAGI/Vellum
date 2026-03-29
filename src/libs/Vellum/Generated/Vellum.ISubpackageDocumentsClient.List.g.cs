#nullable enable

namespace Vellum
{
    public partial interface ISubpackageDocumentsClient
    {
        /// <summary>
        /// List<br/>
        /// Used to list documents. Optionally filter on supported fields.
        /// </summary>
        /// <param name="documentIndexId"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="ordering"></param>
        /// <param name="search"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.PaginatedSlimDocumentList> ListAsync(
            global::System.Guid? documentIndexId = default,
            int? limit = default,
            int? offset = default,
            string? ordering = default,
            string? search = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}