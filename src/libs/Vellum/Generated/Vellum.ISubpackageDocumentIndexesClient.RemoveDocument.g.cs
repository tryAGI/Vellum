#nullable enable

namespace Vellum
{
    public partial interface ISubpackageDocumentIndexesClient
    {
        /// <summary>
        /// Remove Document<br/>
        /// Removes a Document from a Document Index without deleting the Document itself.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.DocumentIndexesRemoveDocumentResponse204> RemoveDocumentAsync(
            string documentId,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}