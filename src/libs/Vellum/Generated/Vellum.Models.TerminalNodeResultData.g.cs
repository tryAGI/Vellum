
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TerminalNodeResultData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.TerminalNodeResultOutputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.TerminalNodeResultOutput Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalNodeResultData" /> class.
        /// </summary>
        /// <param name="output"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TerminalNodeResultData(
            global::Vellum.TerminalNodeResultOutput output)
        {
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalNodeResultData" /> class.
        /// </summary>
        public TerminalNodeResultData()
        {
        }
    }
}