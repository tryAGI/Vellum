
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeExecutionInitiatedBody
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
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Inputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeExecutionInitiatedBody" /> class.
        /// </summary>
        /// <param name="nodeDefinition"></param>
        /// <param name="inputs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeExecutionInitiatedBody(
            global::Vellum.VellumCodeResourceDefinition nodeDefinition,
            object inputs)
        {
            this.NodeDefinition = nodeDefinition ?? throw new global::System.ArgumentNullException(nameof(nodeDefinition));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeExecutionInitiatedBody" /> class.
        /// </summary>
        public NodeExecutionInitiatedBody()
        {
        }
    }
}