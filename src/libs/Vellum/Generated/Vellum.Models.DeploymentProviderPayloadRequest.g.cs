
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentProviderPayloadRequest
    {
        /// <summary>
        /// The ID of the deployment. Must provide either this or deployment_name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        public global::System.Guid? DeploymentId { get; set; }

        /// <summary>
        /// The name of the deployment. Must provide either this or deployment_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_name")]
        public string? DeploymentName { get; set; }

        /// <summary>
        /// The list of inputs defined in the Prompt's deployment with their corresponding values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.PromptDeploymentInputRequest> Inputs { get; set; }

        /// <summary>
        /// Optionally specify a release tag if you want to pin to a specific release of the Workflow Deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_tag")]
        public string? ReleaseTag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expand_meta")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.CompilePromptDeploymentExpandMetaRequest, object>))]
        public global::Vellum.OneOf<global::Vellum.CompilePromptDeploymentExpandMetaRequest, object>? ExpandMeta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentProviderPayloadRequest" /> class.
        /// </summary>
        /// <param name="inputs">
        /// The list of inputs defined in the Prompt's deployment with their corresponding values.
        /// </param>
        /// <param name="deploymentId">
        /// The ID of the deployment. Must provide either this or deployment_name.
        /// </param>
        /// <param name="deploymentName">
        /// The name of the deployment. Must provide either this or deployment_id.
        /// </param>
        /// <param name="releaseTag">
        /// Optionally specify a release tag if you want to pin to a specific release of the Workflow Deployment
        /// </param>
        /// <param name="expandMeta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentProviderPayloadRequest(
            global::System.Collections.Generic.IList<global::Vellum.PromptDeploymentInputRequest> inputs,
            global::System.Guid? deploymentId,
            string? deploymentName,
            string? releaseTag,
            global::Vellum.OneOf<global::Vellum.CompilePromptDeploymentExpandMetaRequest, object>? expandMeta)
        {
            this.DeploymentId = deploymentId;
            this.DeploymentName = deploymentName;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.ReleaseTag = releaseTag;
            this.ExpandMeta = expandMeta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentProviderPayloadRequest" /> class.
        /// </summary>
        public DeploymentProviderPayloadRequest()
        {
        }
    }
}