
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SlimReleaseReview
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
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.ReleaseReviewReviewer Reviewer { get; set; }

        /// <summary>
        /// * `APPROVED` - Approved<br/>
        /// * `CHANGES_REQUESTED` - Changes Requested<br/>
        /// * `COMMENTED` - Commented
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ReleaseReviewStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.ReleaseReviewState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlimReleaseReview" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="created"></param>
        /// <param name="reviewer"></param>
        /// <param name="state">
        /// * `APPROVED` - Approved<br/>
        /// * `CHANGES_REQUESTED` - Changes Requested<br/>
        /// * `COMMENTED` - Commented
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlimReleaseReview(
            global::System.Guid id,
            global::System.DateTime created,
            global::Vellum.ReleaseReviewReviewer reviewer,
            global::Vellum.ReleaseReviewState state)
        {
            this.Id = id;
            this.Created = created;
            this.Reviewer = reviewer ?? throw new global::System.ArgumentNullException(nameof(reviewer));
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlimReleaseReview" /> class.
        /// </summary>
        public SlimReleaseReview()
        {
        }
    }
}