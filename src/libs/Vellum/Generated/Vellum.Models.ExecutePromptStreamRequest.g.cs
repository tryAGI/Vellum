
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExecutePromptStreamRequest
    {
        /// <summary>
        /// A list consisting of the Prompt Deployment's input variables and their values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.PromptDeploymentInputRequest> Inputs { get; set; }

        /// <summary>
        /// The ID of the Prompt Deployment. Must provide either this or prompt_deployment_name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_deployment_id")]
        public global::System.Guid? PromptDeploymentId { get; set; }

        /// <summary>
        /// The unique name of the Prompt Deployment. Must provide either this or prompt_deployment_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_deployment_name")]
        public string? PromptDeploymentName { get; set; }

        /// <summary>
        /// Optionally specify a release tag if you want to pin to a specific release of the Prompt Deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_tag")]
        public string? ReleaseTag { get; set; }

        /// <summary>
        /// Optionally include a unique identifier for tracking purposes. Must be unique within a given Workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// An optionally specified configuration used to opt in to including additional metadata about this prompt execution in the API response. Corresponding values will be returned under the `meta` key of the API response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expand_meta")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.PromptDeploymentExpandMetaRequest, object>))]
        public global::Vellum.OneOf<global::Vellum.PromptDeploymentExpandMetaRequest, object>? ExpandMeta { get; set; }

        /// <summary>
        /// Overrides for the raw API request sent to the model host. Combined with `expand_raw`, it can be used to access new features from models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_overrides")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.RawPromptExecutionOverridesRequest, object>))]
        public global::Vellum.OneOf<global::Vellum.RawPromptExecutionOverridesRequest, object>? RawOverrides { get; set; }

        /// <summary>
        /// A list of keys whose values you'd like to directly return from the JSON response of the model provider. Useful if you need lower-level info returned by model providers that Vellum would otherwise omit. Corresponding key/value pairs will be returned under the `raw` key of the API response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expand_raw")]
        public global::System.Collections.Generic.IList<string>? ExpandRaw { get; set; }

        /// <summary>
        /// Arbitrary JSON metadata associated with this request. Can be used to capture additional monitoring data such as user id, session id, etc. for future analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutePromptStreamRequest" /> class.
        /// </summary>
        /// <param name="inputs">
        /// A list consisting of the Prompt Deployment's input variables and their values.
        /// </param>
        /// <param name="promptDeploymentId">
        /// The ID of the Prompt Deployment. Must provide either this or prompt_deployment_name.
        /// </param>
        /// <param name="promptDeploymentName">
        /// The unique name of the Prompt Deployment. Must provide either this or prompt_deployment_id.
        /// </param>
        /// <param name="releaseTag">
        /// Optionally specify a release tag if you want to pin to a specific release of the Prompt Deployment
        /// </param>
        /// <param name="externalId">
        /// Optionally include a unique identifier for tracking purposes. Must be unique within a given Workspace.
        /// </param>
        /// <param name="expandMeta">
        /// An optionally specified configuration used to opt in to including additional metadata about this prompt execution in the API response. Corresponding values will be returned under the `meta` key of the API response.
        /// </param>
        /// <param name="rawOverrides">
        /// Overrides for the raw API request sent to the model host. Combined with `expand_raw`, it can be used to access new features from models.
        /// </param>
        /// <param name="expandRaw">
        /// A list of keys whose values you'd like to directly return from the JSON response of the model provider. Useful if you need lower-level info returned by model providers that Vellum would otherwise omit. Corresponding key/value pairs will be returned under the `raw` key of the API response.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary JSON metadata associated with this request. Can be used to capture additional monitoring data such as user id, session id, etc. for future analysis.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecutePromptStreamRequest(
            global::System.Collections.Generic.IList<global::Vellum.PromptDeploymentInputRequest> inputs,
            global::System.Guid? promptDeploymentId,
            string? promptDeploymentName,
            string? releaseTag,
            string? externalId,
            global::Vellum.OneOf<global::Vellum.PromptDeploymentExpandMetaRequest, object>? expandMeta,
            global::Vellum.OneOf<global::Vellum.RawPromptExecutionOverridesRequest, object>? rawOverrides,
            global::System.Collections.Generic.IList<string>? expandRaw,
            object? metadata)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.PromptDeploymentId = promptDeploymentId;
            this.PromptDeploymentName = promptDeploymentName;
            this.ReleaseTag = releaseTag;
            this.ExternalId = externalId;
            this.ExpandMeta = expandMeta;
            this.RawOverrides = rawOverrides;
            this.ExpandRaw = expandRaw;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecutePromptStreamRequest" /> class.
        /// </summary>
        public ExecutePromptStreamRequest()
        {
        }
    }
}