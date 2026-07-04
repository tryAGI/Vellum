#nullable enable

namespace Vellum
{
    public partial interface ITestSuitesClient
    {
        /// <summary>
        /// Delete Test Suite Test Case<br/>
        /// Deletes an existing test case for a test suite, keying off of the test case id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="testCaseId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.TestSuitesDeleteTestSuiteTestCaseResponse204> DeleteTestSuiteTestCaseAsync(
            string id,
            string testCaseId,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Test Suite Test Case<br/>
        /// Deletes an existing test case for a test suite, keying off of the test case id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="testCaseId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.AutoSDKHttpResponse<global::Vellum.TestSuitesDeleteTestSuiteTestCaseResponse204>> DeleteTestSuiteTestCaseAsResponseAsync(
            string id,
            string testCaseId,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}