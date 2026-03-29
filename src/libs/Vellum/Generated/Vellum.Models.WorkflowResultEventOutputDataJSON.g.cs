
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A JSON output streamed from a Workflow execution.
    /// </summary>
    public sealed partial class WorkflowResultEventOutputDataJSON
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// * `INITIATED` - INITIATED<br/>
        /// * `STREAMING` - STREAMING<br/>
        /// * `FULFILLED` - FULFILLED<br/>
        /// * `REJECTED` - REJECTED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.WorkflowNodeResultEventStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.WorkflowNodeResultEventState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// The newly output string value. Only relevant for string outputs with a state of STREAMING.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public string? Delta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.JsonEnumJsonConverter))]
        public global::Vellum.JsonEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowResultEventOutputDataJSON" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="state">
        /// * `INITIATED` - INITIATED<br/>
        /// * `STREAMING` - STREAMING<br/>
        /// * `FULFILLED` - FULFILLED<br/>
        /// * `REJECTED` - REJECTED
        /// </param>
        /// <param name="value"></param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="delta">
        /// The newly output string value. Only relevant for string outputs with a state of STREAMING.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowResultEventOutputDataJSON(
            string name,
            global::Vellum.WorkflowNodeResultEventState state,
            object value,
            global::System.Guid? id,
            string? nodeId,
            string? delta,
            global::Vellum.JsonEnum type)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.State = state;
            this.NodeId = nodeId;
            this.Delta = delta;
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowResultEventOutputDataJSON" /> class.
        /// </summary>
        public WorkflowResultEventOutputDataJSON()
        {
        }
    }
}