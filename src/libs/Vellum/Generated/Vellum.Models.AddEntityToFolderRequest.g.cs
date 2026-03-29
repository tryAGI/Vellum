
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddEntityToFolderRequest
    {
        /// <summary>
        /// The ID of the entity you would like to move.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid EntityId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddEntityToFolderRequest" /> class.
        /// </summary>
        /// <param name="entityId">
        /// The ID of the entity you would like to move.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddEntityToFolderRequest(
            global::System.Guid entityId)
        {
            this.EntityId = entityId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddEntityToFolderRequest" /> class.
        /// </summary>
        public AddEntityToFolderRequest()
        {
        }
    }
}