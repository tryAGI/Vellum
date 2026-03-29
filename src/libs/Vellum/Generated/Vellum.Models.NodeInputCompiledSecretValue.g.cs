
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NodeInputCompiledSecretValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_input_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeInputId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.SecretEnumJsonConverter))]
        public global::Vellum.SecretEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.VellumSecret Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeInputCompiledSecretValue" /> class.
        /// </summary>
        /// <param name="nodeInputId"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NodeInputCompiledSecretValue(
            string nodeInputId,
            string key,
            global::Vellum.VellumSecret value,
            global::Vellum.SecretEnum type)
        {
            this.NodeInputId = nodeInputId ?? throw new global::System.ArgumentNullException(nameof(nodeInputId));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeInputCompiledSecretValue" /> class.
        /// </summary>
        public NodeInputCompiledSecretValue()
        {
        }
    }
}