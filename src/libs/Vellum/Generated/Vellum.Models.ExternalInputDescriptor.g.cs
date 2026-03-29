
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExternalInputDescriptor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.CodeResourceDefinition> Types { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs_class")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.CodeResourceDefinition, object>))]
        public global::Vellum.OneOf<global::Vellum.CodeResourceDefinition, object>? InputsClass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance")]
        public object? Instance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalInputDescriptor" /> class.
        /// </summary>
        /// <param name="types"></param>
        /// <param name="name"></param>
        /// <param name="inputsClass"></param>
        /// <param name="instance"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExternalInputDescriptor(
            global::System.Collections.Generic.IList<global::Vellum.CodeResourceDefinition> types,
            string name,
            global::Vellum.OneOf<global::Vellum.CodeResourceDefinition, object>? inputsClass,
            object? instance)
        {
            this.Types = types ?? throw new global::System.ArgumentNullException(nameof(types));
            this.InputsClass = inputsClass;
            this.Instance = instance;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalInputDescriptor" /> class.
        /// </summary>
        public ExternalInputDescriptor()
        {
        }
    }
}