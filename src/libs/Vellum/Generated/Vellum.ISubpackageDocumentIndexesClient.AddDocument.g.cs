#nullable enable

namespace Vellum
{
    public partial interface ISubpackageDocumentIndexesClient
    {
        /// <summary>
        /// Add Document<br/>
        /// Adds a previously uploaded Document to the specified Document Index.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.DocumentIndexesAddDocumentResponse204> AddDocumentAsync(
            string documentId,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}