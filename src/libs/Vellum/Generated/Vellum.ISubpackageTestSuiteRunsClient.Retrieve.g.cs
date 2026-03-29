#nullable enable

namespace Vellum
{
    public partial interface ISubpackageTestSuiteRunsClient
    {
        /// <summary>
        /// Retrieve<br/>
        /// Retrieve a specific Test Suite Run by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.TestSuiteRunRead> RetrieveAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}