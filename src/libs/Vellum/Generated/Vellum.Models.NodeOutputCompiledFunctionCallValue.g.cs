
#nullable enable

namespace Vellum
{
    /// <summary>
    /// An output returned by a node that is of type FUNCTION_CALL.
    /// </summary>
    public sealed partial class NodeOutputCompiledFunctionCallValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.FunctionCallEnumJsonConverter))]
        public global::Vellum.FunctionCallEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FunctionCall, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.OneOf<global::Vellum.FunctionCall, object> Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_output_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeOutputId { get; set; }

        /// <summary>
        /// * `INITIATED` - INITIATED<br/>
        /// * `STREAMING` - STREAMING<br/>
        /// * `FULFILLED` - FULFILLED<br/>
        /// * `REJECTED` - REJECTED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.WorkflowNodeResultEventStateJsonConverter))]
        public global::Vellum.WorkflowNodeResultEventState? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeOutputCompiledFunctionCallValue" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="nodeOutputId"></param>
        /// <param name="type"></param>
        /// <param name="state">
        /// * `INITIATED` - INITIATED<br/>
        /// * `STREAMING` - STREAMING<br/>
        /// * `FULFILLED` - FULFILLED<br/>
        /// * `REJECTED` - REJECTED
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeOutputCompiledFunctionCallValue(
            global::Vellum.OneOf<global::Vellum.FunctionCall, object> value,
            string nodeOutputId,
            global::Vellum.FunctionCallEnum type,
            global::Vellum.WorkflowNodeResultEventState? state)
        {
            this.Type = type;
            this.Value = value;
            this.NodeOutputId = nodeOutputId ?? throw new global::System.ArgumentNullException(nameof(nodeOutputId));
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeOutputCompiledFunctionCallValue" /> class.
        /// </summary>
        public NodeOutputCompiledFunctionCallValue()
        {
        }
    }
}