#nullable enable

namespace Vellum
{
    public partial interface ISubpackageTestSuitesClient
    {
        /// <summary>
        /// List Test Suite Test Cases<br/>
        /// List the Test Cases associated with a Test Suite
        /// </summary>
        /// <param name="id"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.PaginatedTestSuiteTestCaseList> ListTestSuiteTestCasesAsync(
            string id,
            int? limit = default,
            int? offset = default,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}