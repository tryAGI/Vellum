
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VellumVariable
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// * `STRING` - STRING<br/>
        /// * `NUMBER` - NUMBER<br/>
        /// * `JSON` - JSON<br/>
        /// * `CHAT_HISTORY` - CHAT_HISTORY<br/>
        /// * `SEARCH_RESULTS` - SEARCH_RESULTS<br/>
        /// * `ERROR` - ERROR<br/>
        /// * `ARRAY` - ARRAY<br/>
        /// * `FUNCTION_CALL` - FUNCTION_CALL<br/>
        /// * `AUDIO` - AUDIO<br/>
        /// * `VIDEO` - VIDEO<br/>
        /// * `IMAGE` - IMAGE<br/>
        /// * `DOCUMENT` - DOCUMENT<br/>
        /// * `NULL` - NULL<br/>
        /// * `THINKING` - THINKING<br/>
        /// * `REFERENCE` - REFERENCE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.VellumVariableTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.VellumVariableType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumValue?, object>))]
        public global::Vellum.OneOf<global::Vellum.VellumValue?, object>? Default { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extensions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.VellumVariableExtensions, object>))]
        public global::Vellum.OneOf<global::Vellum.VellumVariableExtensions, object>? Extensions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VellumVariable" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="key"></param>
        /// <param name="type">
        /// * `STRING` - STRING<br/>
        /// * `NUMBER` - NUMBER<br/>
        /// * `JSON` - JSON<br/>
        /// * `CHAT_HISTORY` - CHAT_HISTORY<br/>
        /// * `SEARCH_RESULTS` - SEARCH_RESULTS<br/>
        /// * `ERROR` - ERROR<br/>
        /// * `ARRAY` - ARRAY<br/>
        /// * `FUNCTION_CALL` - FUNCTION_CALL<br/>
        /// * `AUDIO` - AUDIO<br/>
        /// * `VIDEO` - VIDEO<br/>
        /// * `IMAGE` - IMAGE<br/>
        /// * `DOCUMENT` - DOCUMENT<br/>
        /// * `NULL` - NULL<br/>
        /// * `THINKING` - THINKING<br/>
        /// * `REFERENCE` - REFERENCE
        /// </param>
        /// <param name="required"></param>
        /// <param name="default"></param>
        /// <param name="extensions"></param>
        /// <param name="schema"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VellumVariable(
            string id,
            string key,
            global::Vellum.VellumVariableType type,
            bool? required,
            global::Vellum.OneOf<global::Vellum.VellumValue?, object>? @default,
            global::Vellum.OneOf<global::Vellum.VellumVariableExtensions, object>? extensions,
            object? schema)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Type = type;
            this.Required = required;
            this.Default = @default;
            this.Extensions = extensions;
            this.Schema = schema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VellumVariable" /> class.
        /// </summary>
        public VellumVariable()
        {
        }
    }
}