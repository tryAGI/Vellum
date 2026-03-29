
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptDeploymentRelease
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
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.ReleaseEnvironment Environment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.ReleaseCreatedBy, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.OneOf<global::Vellum.ReleaseCreatedBy, object> CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.PromptDeploymentReleasePromptVersion PromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.PromptDeploymentReleasePromptDeployment Deployment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.ReleaseReleaseTag> ReleaseTags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviews")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.SlimReleaseReview> Reviews { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptDeploymentRelease" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="created"></param>
        /// <param name="environment"></param>
        /// <param name="createdBy"></param>
        /// <param name="promptVersion"></param>
        /// <param name="deployment"></param>
        /// <param name="releaseTags"></param>
        /// <param name="reviews"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptDeploymentRelease(
            global::System.Guid id,
            global::System.DateTime created,
            global::Vellum.ReleaseEnvironment environment,
            global::Vellum.OneOf<global::Vellum.ReleaseCreatedBy, object> createdBy,
            global::Vellum.PromptDeploymentReleasePromptVersion promptVersion,
            global::Vellum.PromptDeploymentReleasePromptDeployment deployment,
            global::System.Collections.Generic.IList<global::Vellum.ReleaseReleaseTag> releaseTags,
            global::System.Collections.Generic.IList<global::Vellum.SlimReleaseReview> reviews,
            string? description)
        {
            this.Id = id;
            this.Created = created;
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.CreatedBy = createdBy;
            this.PromptVersion = promptVersion ?? throw new global::System.ArgumentNullException(nameof(promptVersion));
            this.Deployment = deployment ?? throw new global::System.ArgumentNullException(nameof(deployment));
            this.Description = description;
            this.ReleaseTags = releaseTags ?? throw new global::System.ArgumentNullException(nameof(releaseTags));
            this.Reviews = reviews ?? throw new global::System.ArgumentNullException(nameof(reviews));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptDeploymentRelease" /> class.
        /// </summary>
        public PromptDeploymentRelease()
        {
        }
    }
}