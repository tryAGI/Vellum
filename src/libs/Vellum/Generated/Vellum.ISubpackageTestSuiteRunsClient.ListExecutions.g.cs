#nullable enable

namespace Vellum
{
    public partial interface ISubpackageTestSuiteRunsClient
    {
        /// <summary>
        /// List Executions
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expand"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.PaginatedTestSuiteRunExecutionList> ListExecutionsAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<string>? expand = default,
            int? limit = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}