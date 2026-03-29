
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The definition of a resource defined in code.
    /// </summary>
    public sealed partial class CodeResourceDefinition
    {
        /// <summary>
        /// The name of the resource, typically a class name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The module that this resource is defined in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("module")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Module { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeResourceDefinition" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the resource, typically a class name.
        /// </param>
        /// <param name="module">
        /// The module that this resource is defined in.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeResourceDefinition(
            string name,
            global::System.Collections.Generic.IList<string> module)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Module = module ?? throw new global::System.ArgumentNullException(nameof(module));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeResourceDefinition" /> class.
        /// </summary>
        public CodeResourceDefinition()
        {
        }
    }
}