
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The definition of a Function (aka "Tool Call") that a Prompt/Model has access to.
    /// </summary>
    public sealed partial class FunctionDefinition
    {
        /// <summary>
        /// * `ENABLED` - Enabled<br/>
        /// * `DISABLED` - Disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.PromptBlockStateJsonConverter))]
        public global::Vellum.PromptBlockState? State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_config")]
        public global::Vellum.EphemeralPromptCacheConfig? CacheConfig { get; set; }

        /// <summary>
        /// The name identifying the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description to help guide the model when to invoke this function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// An OpenAPI specification of parameters that are supported by this function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Optional user defined input mappings for this function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// Set this option to true to force the model to return a function call of this function.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("forced")]
        public bool? Forced { get; set; }

        /// <summary>
        /// Set this option to use strict schema decoding when available.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDefinition" /> class.
        /// </summary>
        /// <param name="state">
        /// * `ENABLED` - Enabled<br/>
        /// * `DISABLED` - Disabled
        /// </param>
        /// <param name="cacheConfig"></param>
        /// <param name="name">
        /// The name identifying the function.
        /// </param>
        /// <param name="description">
        /// A description to help guide the model when to invoke this function.
        /// </param>
        /// <param name="parameters">
        /// An OpenAPI specification of parameters that are supported by this function.
        /// </param>
        /// <param name="inputs">
        /// Optional user defined input mappings for this function.
        /// </param>
        /// <param name="forced">
        /// Set this option to true to force the model to return a function call of this function.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="strict">
        /// Set this option to use strict schema decoding when available.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionDefinition(
            global::Vellum.PromptBlockState? state,
            global::Vellum.EphemeralPromptCacheConfig? cacheConfig,
            string? name,
            string? description,
            object? parameters,
            object? inputs,
            bool? forced,
            bool? strict)
        {
            this.State = state;
            this.CacheConfig = cacheConfig;
            this.Name = name;
            this.Description = description;
            this.Parameters = parameters;
            this.Inputs = inputs;
            this.Forced = forced;
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDefinition" /> class.
        /// </summary>
        public FunctionDefinition()
        {
        }

    }
}