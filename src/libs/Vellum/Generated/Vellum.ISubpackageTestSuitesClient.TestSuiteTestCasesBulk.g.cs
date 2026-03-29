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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::System.Collections.Generic.IList<global::Vellum.TestSuiteTestCaseBulkResult>> TestSuiteTestCasesBulkAsync(
            string id,

            global::System.Collections.Generic.IList<global::Vellum.TestSuiteTestCaseBulkOperationRequest> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}