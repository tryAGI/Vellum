
#nullable enable

namespace Vellum
{
    /// <summary>
    /// An image value for a variable in a Test Case.
    /// </summary>
    public sealed partial class TestCaseImageVariableValue
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variable_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VariableId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ImageEnumJsonConverter))]
        public global::Vellum.ImageEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumImage, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.OneOf<global::Vellum.VellumImage, object> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseImageVariableValue" /> class.
        /// </summary>
        /// <param name="variableId"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCaseImageVariableValue(
            string variableId,
            string name,
            global::Vellum.OneOf<global::Vellum.VellumImage, object> value,
            global::Vellum.ImageEnum type)
        {
            this.VariableId = variableId ?? throw new global::System.ArgumentNullException(nameof(variableId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCaseImageVariableValue" /> class.
        /// </summary>
        public TestCaseImageVariableValue()
        {
        }
    }
}