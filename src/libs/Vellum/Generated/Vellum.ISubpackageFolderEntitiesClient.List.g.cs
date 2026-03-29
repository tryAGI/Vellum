#nullable enable

namespace Vellum
{
    public partial interface ISubpackageFolderEntitiesClient
    {
        /// <summary>
        /// List<br/>
        /// List all folder entities within a specified folder.
        /// </summary>
        /// <param name="entityStatus"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="ordering"></param>
        /// <param name="parentFolderId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.PaginatedFolderEntityList> ListAsync(
            string parentFolderId,
            global::Vellum.V1FolderEntitiesGetParametersEntityStatus? entityStatus = default,
            int? limit = default,
            int? offset = default,
            string? ordering = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}