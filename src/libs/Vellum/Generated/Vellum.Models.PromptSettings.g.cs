
#nullable enable

namespace Vellum
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptSettings
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_enabled")]
        public bool? StreamEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptSettings" /> class.
        /// </summary>
        /// <param name="timeout"></param>
        /// <param name="streamEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptSettings(
            double? timeout,
            bool? streamEnabled)
        {
            this.Timeout = timeout;
            this.StreamEnabled = streamEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptSettings" /> class.
        /// </summary>
        public PromptSettings()
        {
        }

    }
}