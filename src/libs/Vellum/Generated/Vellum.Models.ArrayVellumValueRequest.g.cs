
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A value representing an array of Vellum variable values.
    /// </summary>
    public sealed partial class ArrayVellumValueRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ArrayEnumJsonConverter))]
        public global::Vellum.ArrayEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::System.Collections.Generic.IList<global::Vellum.VellumValueRequest>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayVellumValueRequest" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArrayVellumValueRequest(
            global::Vellum.ArrayEnum type,
            global::System.Collections.Generic.IList<global::Vellum.VellumValueRequest>? value)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayVellumValueRequest" /> class.
        /// </summary>
        public ArrayVellumValueRequest()
        {
        }
    }
}