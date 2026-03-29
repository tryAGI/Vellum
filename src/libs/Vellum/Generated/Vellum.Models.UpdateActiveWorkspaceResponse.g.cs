
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateActiveWorkspaceResponse
    {
        /// <summary>
        /// The id of the workspace that the user should update to, or null if no workspace change needed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_active_workspace_id")]
        public global::System.Guid? UpdateActiveWorkspaceId { get; set; }

        /// <summary>
        /// The id of the environment that the user should update to, or null if no environment change needed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_active_environment_id")]
        public global::System.Guid? UpdateActiveEnvironmentId { get; set; }

        /// <summary>
        /// Whether or not the user is a staff member of Vellum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_staff")]
        public bool? IsStaff { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateActiveWorkspaceResponse" /> class.
        /// </summary>
        /// <param name="updateActiveWorkspaceId">
        /// The id of the workspace that the user should update to, or null if no workspace change needed.
        /// </param>
        /// <param name="updateActiveEnvironmentId">
        /// The id of the environment that the user should update to, or null if no environment change needed.
        /// </param>
        /// <param name="isStaff">
        /// Whether or not the user is a staff member of Vellum.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateActiveWorkspaceResponse(
            global::System.Guid? updateActiveWorkspaceId,
            global::System.Guid? updateActiveEnvironmentId,
            bool? isStaff)
        {
            this.UpdateActiveWorkspaceId = updateActiveWorkspaceId;
            this.UpdateActiveEnvironmentId = updateActiveEnvironmentId;
            this.IsStaff = isStaff;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateActiveWorkspaceResponse" /> class.
        /// </summary>
        public UpdateActiveWorkspaceResponse()
        {
        }
    }
}