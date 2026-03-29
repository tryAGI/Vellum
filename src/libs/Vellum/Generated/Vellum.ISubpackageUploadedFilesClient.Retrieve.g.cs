#nullable enable

namespace Vellum
{
    public partial interface ISubpackageUploadedFilesClient
    {
        /// <summary>
        /// Retrieve<br/>
        /// Retrieve a previously uploaded file by its ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expirySeconds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.UploadedFileRead> RetrieveAsync(
            global::System.Guid id,
            int? expirySeconds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}