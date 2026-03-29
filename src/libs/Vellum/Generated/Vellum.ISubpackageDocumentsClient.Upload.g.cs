#nullable enable

namespace Vellum
{
    public partial interface ISubpackageDocumentsClient
    {
        /// <summary>
        /// Upload<br/>
        /// Upload a document to be indexed and used for search.<br/>
        /// **Note:** Uses a base url of `https://documents.vellum.ai`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.UploadDocumentResponse> UploadAsync(

            global::Vellum.UploadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload<br/>
        /// Upload a document to be indexed and used for search.<br/>
        /// **Note:** Uses a base url of `https://documents.vellum.ai`.
        /// </summary>
        /// <param name="addToIndexNames">
        /// Optionally include the names of all indexes that you'd like this document to be included in
        /// </param>
        /// <param name="externalId">
        /// Optionally include an external ID for this document. This is useful if you want to re-upload the same document later when its contents change and would like it to be re-indexed.
        /// </param>
        /// <param name="label">
        /// A human-friendly name for this document. Typically the filename.
        /// </param>
        /// <param name="contents">
        /// The file contents of the document. Either contents or url must be provided.
        /// </param>
        /// <param name="contentsname">
        /// The file contents of the document. Either contents or url must be provided.
        /// </param>
        /// <param name="url">
        /// A URL from which the document can be downloaded. Either contents or url must be provided.
        /// </param>
        /// <param name="keywords">
        /// Optionally include a list of keywords that'll be associated with this document. Used when performing keyword searches.
        /// </param>
        /// <param name="metadata">
        /// A stringified JSON object containing any metadata associated with the document that you'd like to filter upon later.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.UploadDocumentResponse> UploadAsync(
            string label,
            global::System.Collections.Generic.IList<string>? addToIndexNames = default,
            string? externalId = default,
            byte[]? contents = default,
            string? contentsname = default,
            string? url = default,
            global::System.Collections.Generic.IList<string>? keywords = default,
            byte[]? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}