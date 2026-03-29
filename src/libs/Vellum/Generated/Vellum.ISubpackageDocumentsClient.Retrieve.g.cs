#nullable enable

namespace Vellum
{
    public partial interface ISubpackageDocumentsClient
    {
        /// <summary>
        /// Retrieve<br/>
        /// Retrieve a Document, keying off of either its Vellum-generated ID or its external ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.DocumentRead> RetrieveAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}