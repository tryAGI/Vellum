
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowResultEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// * `INITIATED` - Initiated<br/>
        /// * `STREAMING` - Streaming<br/>
        /// * `FULFILLED` - Fulfilled<br/>
        /// * `REJECTED` - Rejected<br/>
        /// * `PENDING` - Pending
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.WorkflowResultEventStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.WorkflowResultEventState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Ts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowResultEventOutputData?, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.OneOf<global::Vellum.WorkflowResultEventOutputData?, object> Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowEventError, object>))]
        public global::Vellum.OneOf<global::Vellum.WorkflowEventError, object>? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.IList<global::Vellum.WorkflowOutput>? Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public global::System.Collections.Generic.IList<global::Vellum.ExecutionVellumValue>? Inputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowResultEvent" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="state">
        /// * `INITIATED` - Initiated<br/>
        /// * `STREAMING` - Streaming<br/>
        /// * `FULFILLED` - Fulfilled<br/>
        /// * `REJECTED` - Rejected<br/>
        /// * `PENDING` - Pending
        /// </param>
        /// <param name="ts"></param>
        /// <param name="output"></param>
        /// <param name="error"></param>
        /// <param name="outputs"></param>
        /// <param name="inputs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowResultEvent(
            string id,
            global::Vellum.WorkflowResultEventState state,
            global::System.DateTime ts,
            global::Vellum.OneOf<global::Vellum.WorkflowResultEventOutputData?, object> output,
            global::Vellum.OneOf<global::Vellum.WorkflowEventError, object>? error,
            global::System.Collections.Generic.IList<global::Vellum.WorkflowOutput>? outputs,
            global::System.Collections.Generic.IList<global::Vellum.ExecutionVellumValue>? inputs)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.State = state;
            this.Ts = ts;
            this.Output = output;
            this.Error = error;
            this.Outputs = outputs;
            this.Inputs = inputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowResultEvent" /> class.
        /// </summary>
        public WorkflowResultEvent()
        {
        }
    }
}