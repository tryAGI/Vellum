
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeExecutionFulfilledBody
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
        [global::System.Text.Json.Serialization.JsonPropertyName("invoked_ports")]
        public global::System.Collections.Generic.IList<global::Vellum.InvokedPort>? InvokedPorts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Outputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mocked")]
        public bool? Mocked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redacted")]
        public bool? Redacted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeExecutionFulfilledBody" /> class.
        /// </summary>
        /// <param name="nodeDefinition"></param>
        /// <param name="outputs"></param>
        /// <param name="invokedPorts"></param>
        /// <param name="mocked"></param>
        /// <param name="redacted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeExecutionFulfilledBody(
            global::Vellum.VellumCodeResourceDefinition nodeDefinition,
            object outputs,
            global::System.Collections.Generic.IList<global::Vellum.InvokedPort>? invokedPorts,
            bool? mocked,
            bool? redacted)
        {
            this.NodeDefinition = nodeDefinition ?? throw new global::System.ArgumentNullException(nameof(nodeDefinition));
            this.InvokedPorts = invokedPorts;
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
            this.Mocked = mocked;
            this.Redacted = redacted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeExecutionFulfilledBody" /> class.
        /// </summary>
        public NodeExecutionFulfilledBody()
        {
        }
    }
}