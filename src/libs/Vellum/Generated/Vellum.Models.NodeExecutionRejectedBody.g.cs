
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeExecutionRejectedBody
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
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.VellumSdkError Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stacktrace")]
        public string? Stacktrace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeExecutionRejectedBody" /> class.
        /// </summary>
        /// <param name="nodeDefinition"></param>
        /// <param name="error"></param>
        /// <param name="stacktrace"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeExecutionRejectedBody(
            global::Vellum.VellumCodeResourceDefinition nodeDefinition,
            global::Vellum.VellumSdkError error,
            string? stacktrace)
        {
            this.NodeDefinition = nodeDefinition ?? throw new global::System.ArgumentNullException(nameof(nodeDefinition));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Stacktrace = stacktrace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeExecutionRejectedBody" /> class.
        /// </summary>
        public NodeExecutionRejectedBody()
        {
        }
    }
}