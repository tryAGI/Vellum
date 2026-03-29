#nullable enable

namespace Vellum
{
    public partial interface ISubpackageDocumentIndexesClient
    {
        /// <summary>
        /// Destroy<br/>
        /// Used to delete a Document Index given its ID or name.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.DocumentIndexesDestroyResponse204> DestroyAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}