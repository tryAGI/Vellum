
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The input for a JSON variable in a Workflow.
    /// </summary>
    public sealed partial class WorkflowRequestJSONInputRequest
    {
        /// <summary>
        /// The variable's name, as defined in the Workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        /// Initializes a new instance of the <see cref="WorkflowRequestJSONInputRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The variable's name, as defined in the Workflow.
        /// </param>
        /// <param name="value"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowRequestJSONInputRequest(
            string name,
            object value,
            global::Vellum.JsonEnum type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRequestJSONInputRequest" /> class.
        /// </summary>
        public WorkflowRequestJSONInputRequest()
        {
        }
    }
}