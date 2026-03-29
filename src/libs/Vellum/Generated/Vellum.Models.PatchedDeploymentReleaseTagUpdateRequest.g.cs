
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedDeploymentReleaseTagUpdateRequest
    {
        /// <summary>
        /// The ID of the Release to tag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history_item_id")]
        public global::System.Guid? HistoryItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedDeploymentReleaseTagUpdateRequest" /> class.
        /// </summary>
        /// <param name="historyItemId">
        /// The ID of the Release to tag
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedDeploymentReleaseTagUpdateRequest(
            global::System.Guid? historyItemId)
        {
            this.HistoryItemId = historyItemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedDeploymentReleaseTagUpdateRequest" /> class.
        /// </summary>
        public PatchedDeploymentReleaseTagUpdateRequest()
        {
        }
    }
}