
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploySandboxPromptRequest
    {
        /// <summary>
        /// The Vellum-generated ID of the Prompt Deployment you'd like to update. Cannot specify both this and prompt_deployment_name. Leave null to create a new Prompt Deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_deployment_id")]
        public global::System.Guid? PromptDeploymentId { get; set; }

        /// <summary>
        /// The unique name of the Prompt Deployment you'd like to either create or update. Cannot specify both this and prompt_deployment_id. If provided and matches an existing Prompt Deployment, that Prompt Deployment will be updated. Otherwise, a new Prompt Deployment will be created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_deployment_name")]
        public string? PromptDeploymentName { get; set; }

        /// <summary>
        /// In the event that a new Prompt Deployment is created, this will be the label it's given.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Optionally provide the release tags that you'd like to be associated with the latest release of the created/updated Prompt Deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_tags")]
        public global::System.Collections.Generic.IList<string>? ReleaseTags { get; set; }

        /// <summary>
        /// Optionally provide a description that details what's new in this Release.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_description")]
        public string? ReleaseDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploySandboxPromptRequest" /> class.
        /// </summary>
        /// <param name="promptDeploymentId">
        /// The Vellum-generated ID of the Prompt Deployment you'd like to update. Cannot specify both this and prompt_deployment_name. Leave null to create a new Prompt Deployment.
        /// </param>
        /// <param name="promptDeploymentName">
        /// The unique name of the Prompt Deployment you'd like to either create or update. Cannot specify both this and prompt_deployment_id. If provided and matches an existing Prompt Deployment, that Prompt Deployment will be updated. Otherwise, a new Prompt Deployment will be created.
        /// </param>
        /// <param name="label">
        /// In the event that a new Prompt Deployment is created, this will be the label it's given.
        /// </param>
        /// <param name="releaseTags">
        /// Optionally provide the release tags that you'd like to be associated with the latest release of the created/updated Prompt Deployment.
        /// </param>
        /// <param name="releaseDescription">
        /// Optionally provide a description that details what's new in this Release.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploySandboxPromptRequest(
            global::System.Guid? promptDeploymentId,
            string? promptDeploymentName,
            string? label,
            global::System.Collections.Generic.IList<string>? releaseTags,
            string? releaseDescription)
        {
            this.PromptDeploymentId = promptDeploymentId;
            this.PromptDeploymentName = promptDeploymentName;
            this.Label = label;
            this.ReleaseTags = releaseTags;
            this.ReleaseDescription = releaseDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploySandboxPromptRequest" /> class.
        /// </summary>
        public DeploySandboxPromptRequest()
        {
        }
    }
}