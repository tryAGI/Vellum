
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptDeploymentReleasePromptVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ml_model_to_workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid MlModelToWorkspaceId { get; set; }

        /// <summary>
        /// Configuration used to build this prompt version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("build_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.PromptVersionBuildConfigSandbox BuildConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptDeploymentReleasePromptVersion" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mlModelToWorkspaceId"></param>
        /// <param name="buildConfig">
        /// Configuration used to build this prompt version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptDeploymentReleasePromptVersion(
            global::System.Guid id,
            global::System.Guid mlModelToWorkspaceId,
            global::Vellum.PromptVersionBuildConfigSandbox buildConfig)
        {
            this.Id = id;
            this.MlModelToWorkspaceId = mlModelToWorkspaceId;
            this.BuildConfig = buildConfig ?? throw new global::System.ArgumentNullException(nameof(buildConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptDeploymentReleasePromptVersion" /> class.
        /// </summary>
        public PromptDeploymentReleasePromptVersion()
        {
        }
    }
}