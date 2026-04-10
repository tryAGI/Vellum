#nullable enable

namespace Vellum
{
    public partial interface ISubpackageDocumentsClient
    {
        /// <summary>
        /// Partial Update<br/>
        /// Update a Document, keying off of either its Vellum-generated ID or its external ID. Particularly useful for updating its metadata.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.DocumentRead> PartialUpdateAsync(
            string id,

            global::Vellum.PartialUpdateRequest request,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partial Update<br/>
        /// Update a Document, keying off of either its Vellum-generated ID or its external ID. Particularly useful for updating its metadata.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="label">
        /// A human-readable label for the document. Defaults to the originally uploaded file's file name.
        /// </param>
        /// <param name="status">
        /// The current status of the document<br/>
        /// * `ACTIVE` - Active
        /// </param>
        /// <param name="keywords">
        /// A list of keywords that'll be associated with the document. Used as part of keyword search.
        /// </param>
        /// <param name="metadata">
        /// A JSON object containing any metadata associated with the document that you'd like to filter upon later.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.DocumentRead> PartialUpdateAsync(
            string id,
            string? label = default,
            global::Vellum.DocumentStatus? status = default,
            global::System.Collections.Generic.IList<string>? keywords = default,
            object? metadata = default,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}