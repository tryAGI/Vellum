#nullable enable

namespace Vellum
{
    public partial interface ISubpackageEventsClient
    {
        /// <summary>
        /// Create<br/>
        /// Accept an event or list of events and publish them to ClickHouse for analytics processing.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vellum.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.EventCreateResponse> CreateAsync(

            global::Vellum.CreateWorkflowEventRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create<br/>
        /// Accept an event or list of events and publish them to ClickHouse for analytics processing.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vellum.EventCreateResponse> CreateAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}