
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeExecutionLogBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.VellumCodeResourceDefinition NodeDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// * `DEBUG` - DEBUG<br/>
        /// * `INFO` - INFO<br/>
        /// * `WARNING` - WARNING<br/>
        /// * `ERROR` - ERROR
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.SeverityEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.SeverityEnum Severity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeExecutionLogBody" /> class.
        /// </summary>
        /// <param name="nodeDefinition"></param>
        /// <param name="message"></param>
        /// <param name="severity">
        /// * `DEBUG` - DEBUG<br/>
        /// * `INFO` - INFO<br/>
        /// * `WARNING` - WARNING<br/>
        /// * `ERROR` - ERROR
        /// </param>
        /// <param name="attributes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeExecutionLogBody(
            global::Vellum.VellumCodeResourceDefinition nodeDefinition,
            string message,
            global::Vellum.SeverityEnum severity,
            object? attributes)
        {
            this.NodeDefinition = nodeDefinition ?? throw new global::System.ArgumentNullException(nameof(nodeDefinition));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Attributes = attributes;
            this.Severity = severity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeExecutionLogBody" /> class.
        /// </summary>
        public NodeExecutionLogBody()
        {
        }
    }
}