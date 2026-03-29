
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentProviderPayloadResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.DeploymentProviderPayloadResponsePayloadJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.DeploymentProviderPayloadResponsePayload Payload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.CompilePromptMeta, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.OneOf<global::Vellum.CompilePromptMeta, object> Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentProviderPayloadResponse" /> class.
        /// </summary>
        /// <param name="payload"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentProviderPayloadResponse(
            global::Vellum.DeploymentProviderPayloadResponsePayload payload,
            global::Vellum.OneOf<global::Vellum.CompilePromptMeta, object> meta)
        {
            this.Payload = payload;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentProviderPayloadResponse" /> class.
        /// </summary>
        public DeploymentProviderPayloadResponse()
        {
        }
    }
}