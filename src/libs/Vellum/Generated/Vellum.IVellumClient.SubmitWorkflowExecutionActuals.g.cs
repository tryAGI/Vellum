#nullable enable

namespace Vellum
{
    public partial interface IVellumClient
    {
        /// <summary>
        /// Submit Workflow Execution Actuals<br/>
        ///     Used to submit feedback regarding the quality of previous workflow execution and its outputs.<br/>
        ///     **Note:** Uses a base url of `https://predict.vellum.ai`.    
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.SubmitWorkflowExecutionActualsResponse200> SubmitWorkflowExecutionActualsAsync(

            global::Vellum.SubmitWorkflowExecutionActualsRequest request,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Workflow Execution Actuals<br/>
        ///     Used to submit feedback regarding the quality of previous workflow execution and its outputs.<br/>
        ///     **Note:** Uses a base url of `https://predict.vellum.ai`.    
        /// </summary>
        /// <param name="actuals">
        /// Feedback regarding the quality of an output on a previously executed workflow.
        /// </param>
        /// <param name="executionId">
        /// The Vellum-generated ID of a previously executed workflow. Must provide either this or external_id.
        /// </param>
        /// <param name="externalId">
        /// The external ID that was originally provided by when executing the workflow, if applicable, that you'd now like to submit actuals for. Must provide either this or execution_id.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.SubmitWorkflowExecutionActualsResponse200> SubmitWorkflowExecutionActualsAsync(
            global::System.Collections.Generic.IList<global::Vellum.SubmitWorkflowExecutionActualRequest> actuals,
            global::System.Guid? executionId = default,
            string? externalId = default,
            global::Vellum.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}