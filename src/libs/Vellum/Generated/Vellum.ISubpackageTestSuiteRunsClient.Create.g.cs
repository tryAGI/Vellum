#nullable enable

namespace Vellum
{
    public partial interface ISubpackageTestSuiteRunsClient
    {
        /// <summary>
        /// Create<br/>
        /// Trigger a Test Suite and create a new Test Suite Run
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.TestSuiteRunRead> CreateAsync(

            global::Vellum.TestSuiteRunCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create<br/>
        /// Trigger a Test Suite and create a new Test Suite Run
        /// </summary>
        /// <param name="testSuiteId">
        /// The ID of the Test Suite to run. Must provide either this or test_suite_id.
        /// </param>
        /// <param name="testSuiteName">
        /// The name of the Test Suite to run. Must provide either this or test_suite_id.
        /// </param>
        /// <param name="execConfig">
        /// Configuration that defines how the Test Suite should be run
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.TestSuiteRunRead> CreateAsync(
            global::Vellum.TestSuiteRunExecConfigRequest execConfig,
            global::System.Guid? testSuiteId = default,
            string? testSuiteName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}