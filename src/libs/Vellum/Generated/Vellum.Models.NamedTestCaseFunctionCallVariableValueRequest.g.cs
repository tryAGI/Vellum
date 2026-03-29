
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Named Test Case value that is of type FUNCTION_CALL
    /// </summary>
    public sealed partial class NamedTestCaseFunctionCallVariableValueRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.FunctionCallEnumJsonConverter))]
        public global::Vellum.FunctionCallEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.FunctionCallRequest, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.OneOf<global::Vellum.FunctionCallRequest, object> Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedTestCaseFunctionCallVariableValueRequest" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamedTestCaseFunctionCallVariableValueRequest(
            global::Vellum.OneOf<global::Vellum.FunctionCallRequest, object> value,
            string name,
            global::Vellum.FunctionCallEnum type)
        {
            this.Type = type;
            this.Value = value;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedTestCaseFunctionCallVariableValueRequest" /> class.
        /// </summary>
        public NamedTestCaseFunctionCallVariableValueRequest()
        {
        }
    }
}