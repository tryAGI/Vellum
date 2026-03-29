
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeExecutionSpanAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filepath")]
        public string? Filepath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid NodeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeExecutionSpanAttributes" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="nodeId"></param>
        /// <param name="filepath"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeExecutionSpanAttributes(
            string label,
            global::System.Guid nodeId,
            string? filepath)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Filepath = filepath;
            this.NodeId = nodeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeExecutionSpanAttributes" /> class.
        /// </summary>
        public NodeExecutionSpanAttributes()
        {
        }
    }
}