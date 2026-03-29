
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A Node Result Event emitted from a Map Node.
    /// </summary>
    public sealed partial class MapNodeResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.MapEnumJsonConverter))]
        public global::Vellum.MapEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Vellum.MapNodeResultData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MapNodeResult" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MapNodeResult(
            global::Vellum.MapEnum type,
            global::Vellum.MapNodeResultData? data)
        {
            this.Type = type;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MapNodeResult" /> class.
        /// </summary>
        public MapNodeResult()
        {
        }
    }
}