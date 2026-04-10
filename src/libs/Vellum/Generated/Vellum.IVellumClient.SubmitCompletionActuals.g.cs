#nullable enable

namespace Vellum
{
    public partial interface IVellumClient
    {
        /// <summary>
        /// Submit Completion Actuals<br/>
        /// Used to submit feedback regarding the quality of previously generated completions.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.SubmitCompletionActualsResponse200> SubmitCompletionActualsAsync(

            global::Vellum.SubmitCompletionActualsRequest request,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Completion Actuals<br/>
        /// Used to submit feedback regarding the quality of previously generated completions.
        /// </summary>
        /// <param name="deploymentId">
        /// The ID of the deployment. Must provide either this or deployment_name.
        /// </param>
        /// <param name="deploymentName">
        /// The name of the deployment. Must provide either this or deployment_id.
        /// </param>
        /// <param name="actuals">
        /// Feedback regarding the quality of previously generated completions
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.SubmitCompletionActualsResponse200> SubmitCompletionActualsAsync(
            global::System.Collections.Generic.IList<global::Vellum.SubmitCompletionActualRequest> actuals,
            global::System.Guid? deploymentId = default,
            string? deploymentName = default,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}