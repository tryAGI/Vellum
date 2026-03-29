
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FolderEntityFolderData
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
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Modified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_contents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasContents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderEntityFolderData" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="label"></param>
        /// <param name="created"></param>
        /// <param name="modified"></param>
        /// <param name="hasContents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FolderEntityFolderData(
            global::System.Guid id,
            string label,
            global::System.DateTime created,
            global::System.DateTime modified,
            bool hasContents)
        {
            this.Id = id;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Created = created;
            this.Modified = modified;
            this.HasContents = hasContents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderEntityFolderData" /> class.
        /// </summary>
        public FolderEntityFolderData()
        {
        }
    }
}