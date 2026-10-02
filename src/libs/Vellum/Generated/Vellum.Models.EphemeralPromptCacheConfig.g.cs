
#nullable enable

namespace Vellum
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EphemeralPromptCacheConfig
    {
        /// <summary>
        /// * `EPHEMERAL` - EPHEMERAL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.EphemeralPromptCacheConfigTypeEnumJsonConverter))]
        public global::Vellum.EphemeralPromptCacheConfigTypeEnum? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EphemeralPromptCacheConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// * `EPHEMERAL` - EPHEMERAL
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EphemeralPromptCacheConfig(
            global::Vellum.EphemeralPromptCacheConfigTypeEnum? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EphemeralPromptCacheConfig" /> class.
        /// </summary>
        public EphemeralPromptCacheConfig()
        {
        }

    }
}