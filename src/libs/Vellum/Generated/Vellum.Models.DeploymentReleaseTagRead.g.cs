
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentReleaseTagRead
    {
        /// <summary>
        /// The name of the Release Tag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The source of how the Release Tag was originally created<br/>
        /// * `SYSTEM` - System<br/>
        /// * `USER` - User
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ReleaseTagSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.ReleaseTagSource Source { get; set; }

        /// <summary>
        /// Deprecated. Reference the `release` field instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history_item")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.DeploymentReleaseTagDeploymentHistoryItem HistoryItem { get; set; }

        /// <summary>
        /// The Release that this Release Tag points to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.ReleaseTagRelease Release { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentReleaseTagRead" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the Release Tag
        /// </param>
        /// <param name="source">
        /// The source of how the Release Tag was originally created<br/>
        /// * `SYSTEM` - System<br/>
        /// * `USER` - User
        /// </param>
        /// <param name="historyItem">
        /// Deprecated. Reference the `release` field instead.
        /// </param>
        /// <param name="release">
        /// The Release that this Release Tag points to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentReleaseTagRead(
            string name,
            global::Vellum.ReleaseTagSource source,
            global::Vellum.DeploymentReleaseTagDeploymentHistoryItem historyItem,
            global::Vellum.ReleaseTagRelease release)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Source = source;
            this.HistoryItem = historyItem ?? throw new global::System.ArgumentNullException(nameof(historyItem));
            this.Release = release ?? throw new global::System.ArgumentNullException(nameof(release));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentReleaseTagRead" /> class.
        /// </summary>
        public DeploymentReleaseTagRead()
        {
        }
    }
}