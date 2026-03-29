
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VellumCodeResourceDefinition
    {
        /// <summary>
        /// 
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
        /// Whether this node should be excluded from monitoring views.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_from_monitoring")]
        public bool? ExcludeFromMonitoring { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VellumCodeResourceDefinition" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="module">
        /// The module that this resource is defined in.
        /// </param>
        /// <param name="id"></param>
        /// <param name="excludeFromMonitoring">
        /// Whether this node should be excluded from monitoring views.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VellumCodeResourceDefinition(
            string name,
            global::System.Collections.Generic.IList<string> module,
            global::System.Guid id,
            bool? excludeFromMonitoring)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Module = module ?? throw new global::System.ArgumentNullException(nameof(module));
            this.ExcludeFromMonitoring = excludeFromMonitoring;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VellumCodeResourceDefinition" /> class.
        /// </summary>
        public VellumCodeResourceDefinition()
        {
        }
    }
}