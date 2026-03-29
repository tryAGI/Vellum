
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Configuration for Reducto chunking
    /// </summary>
    public sealed partial class ReductoChunkerConfig
    {
        /// <summary>
        /// Default Value: 1000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_limit")]
        public int? CharacterLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReductoChunkerConfig" /> class.
        /// </summary>
        /// <param name="characterLimit">
        /// Default Value: 1000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReductoChunkerConfig(
            int? characterLimit)
        {
            this.CharacterLimit = characterLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReductoChunkerConfig" /> class.
        /// </summary>
        public ReductoChunkerConfig()
        {
        }
    }
}