#nullable enable

namespace Vellum
{
    public partial interface ISubpackageTestSuitesClient
    {
        /// <summary>
        /// Upsert Test Suite Test Case<br/>
        /// Upserts a new test case for a test suite, keying off of the optionally provided test case id.<br/>
        /// If an id is provided and has a match, the test case will be updated. If no id is provided or no match<br/>
        /// is found, a new test case will be appended to the end.<br/>
        /// Note that a full replacement of the test case is performed, so any fields not provided will be removed<br/>
        /// or overwritten with default values.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.TestSuiteTestCase> UpsertTestSuiteTestCaseAsync(
            string id,

            global::Vellum.UpsertTestSuiteTestCaseRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert Test Suite Test Case<br/>
        /// Upserts a new test case for a test suite, keying off of the optionally provided test case id.<br/>
        /// If an id is provided and has a match, the test case will be updated. If no id is provided or no match<br/>
        /// is found, a new test case will be appended to the end.<br/>
        /// Note that a full replacement of the test case is performed, so any fields not provided will be removed<br/>
        /// or overwritten with default values.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId">
        /// The Vellum-generated ID of an existing Test Case whose data you'd like to replace. If specified and no Test Case exists with this ID, a 404 will be returned.
        /// </param>
        /// <param name="externalId">
        /// An ID external to Vellum that uniquely identifies the Test Case that you'd like to create/update. If there's a match on a Test Case that was previously created with the same external_id, it will be updated. Otherwise, a new Test Case will be created with this value as its external_id. If no external_id is specified, then a new Test Case will always be created.
        /// </param>
        /// <param name="label">
        /// A human-readable label used to convey the intention of this Test Case
        /// </param>
        /// <param name="inputValues">
        /// Values for each of the Test Case's input variables
        /// </param>
        /// <param name="evaluationValues">
        /// Values for each of the Test Case's evaluation variables
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.TestSuiteTestCase> UpsertTestSuiteTestCaseAsync(
            string id,
            global::System.Collections.Generic.IList<global::Vellum.NamedTestCaseVariableValueRequest> inputValues,
            global::System.Collections.Generic.IList<global::Vellum.NamedTestCaseVariableValueRequest> evaluationValues,
            global::System.Guid? requestId = default,
            string? externalId = default,
            string? label = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}