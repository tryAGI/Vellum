
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The unsuccessful response from the Workflow execution containing an error specifying what went wrong.
    /// </summary>
    public sealed partial class RejectedExecuteWorkflowWorkflowResultEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.RejectedEnumJsonConverter))]
        public global::Vellum.RejectedEnum State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Ts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.WorkflowEventError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RejectedExecuteWorkflowWorkflowResultEvent" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ts"></param>
        /// <param name="error"></param>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RejectedExecuteWorkflowWorkflowResultEvent(
            string id,
            global::System.DateTime ts,
            global::Vellum.WorkflowEventError error,
            global::Vellum.RejectedEnum state)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.State = state;
            this.Ts = ts;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RejectedExecuteWorkflowWorkflowResultEvent" /> class.
        /// </summary>
        public RejectedExecuteWorkflowWorkflowResultEvent()
        {
        }
    }
}