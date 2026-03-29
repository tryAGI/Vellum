
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReleaseReleaseTag
    {
        /// <summary>
        /// The name of the Release Tag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The source of how the Release Tag was originally created<br/>
        /// * `SYSTEM` - System<br/>
        /// * `USER` - User
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ReleaseTagSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.ReleaseTagSource Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseReleaseTag" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the Release Tag
        /// </param>
        /// <param name="source">
        /// The source of how the Release Tag was originally created<br/>
        /// * `SYSTEM` - System<br/>
        /// * `USER` - User
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReleaseReleaseTag(
            string name,
            global::Vellum.ReleaseTagSource source)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseReleaseTag" /> class.
        /// </summary>
        public ReleaseReleaseTag()
        {
        }
    }
}