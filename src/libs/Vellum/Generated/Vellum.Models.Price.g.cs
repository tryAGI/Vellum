
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Price
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// * `USD` - USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.UnitEnumJsonConverter))]
        public global::Vellum.UnitEnum Unit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Price" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unit">
        /// * `USD` - USD
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Price(
            double value,
            global::Vellum.UnitEnum unit)
        {
            this.Value = value;
            this.Unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Price" /> class.
        /// </summary>
        public Price()
        {
        }
    }
}