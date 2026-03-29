
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The successful response from the Workflow execution containing the produced outputs.
    /// </summary>
    public sealed partial class FulfilledExecuteWorkflowWorkflowResultEvent
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.FulfilledEnumJsonConverter))]
        public global::Vellum.FulfilledEnum State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Ts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.WorkflowOutput> Outputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FulfilledExecuteWorkflowWorkflowResultEvent" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ts"></param>
        /// <param name="outputs"></param>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FulfilledExecuteWorkflowWorkflowResultEvent(
            string id,
            global::System.DateTime ts,
            global::System.Collections.Generic.IList<global::Vellum.WorkflowOutput> outputs,
            global::Vellum.FulfilledEnum state)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.State = state;
            this.Ts = ts;
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FulfilledExecuteWorkflowWorkflowResultEvent" /> class.
        /// </summary>
        public FulfilledExecuteWorkflowWorkflowResultEvent()
        {
        }
    }
}