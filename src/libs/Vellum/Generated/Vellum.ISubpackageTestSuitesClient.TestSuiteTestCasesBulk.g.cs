#nullable enable

namespace Vellum
{
    public partial interface ISubpackageTestSuitesClient
    {
        /// <summary>
        /// Test Suite Test Cases Bulk<br/>
        /// Created, replace, and delete Test Cases within the specified Test Suite in bulk
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::Vellum.TestSuiteTestCaseBulkResult> TestSuiteTestCasesBulkAsync(
            string id,

            global::System.Collections.Generic.IList<global::Vellum.TestSuiteTestCaseBulkOperationRequest> request,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}