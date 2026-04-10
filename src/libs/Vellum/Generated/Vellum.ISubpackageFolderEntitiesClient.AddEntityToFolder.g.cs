#nullable enable

namespace Vellum
{
    public partial interface ISubpackageFolderEntitiesClient
    {
        /// <summary>
        /// Add Entity To Folder<br/>
        /// Add an entity to a specific folder or root directory.<br/>
        /// Adding an entity to a folder will remove it from any other folders it might have been a member of.
        /// </summary>
        /// <param name="folderId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.FolderEntitiesAddEntityToFolderResponse200> AddEntityToFolderAsync(
            string folderId,

            global::Vellum.AddEntityToFolderRequest request,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Entity To Folder<br/>
        /// Add an entity to a specific folder or root directory.<br/>
        /// Adding an entity to a folder will remove it from any other folders it might have been a member of.
        /// </summary>
        /// <param name="folderId"></param>
        /// <param name="entityId">
        /// The ID of the entity you would like to move.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.FolderEntitiesAddEntityToFolderResponse200> AddEntityToFolderAsync(
            string folderId,
            global::System.Guid entityId,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}