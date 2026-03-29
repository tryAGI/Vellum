
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitCompletionActualRequest
    {
        /// <summary>
        /// The Vellum-generated ID of a previously generated completion. Must provide either this or external_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The external ID that was originally provided when generating the completion that you'd now like to submit actuals for. Must provide either this or id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Text representing what the completion _should_ have been.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// A number between 0 and 1 representing the quality of the completion. 0 is the worst, 1 is the best.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        public double? Quality { get; set; }

        /// <summary>
        /// Optionally provide the timestamp representing when this feedback was collected. Used for reporting purposes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Optionally provide additional metadata about the feedback submission.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitCompletionActualRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// The Vellum-generated ID of a previously generated completion. Must provide either this or external_id.
        /// </param>
        /// <param name="externalId">
        /// The external ID that was originally provided when generating the completion that you'd now like to submit actuals for. Must provide either this or id.
        /// </param>
        /// <param name="text">
        /// Text representing what the completion _should_ have been.
        /// </param>
        /// <param name="quality">
        /// A number between 0 and 1 representing the quality of the completion. 0 is the worst, 1 is the best.
        /// </param>
        /// <param name="timestamp">
        /// Optionally provide the timestamp representing when this feedback was collected. Used for reporting purposes.
        /// </param>
        /// <param name="metadata">
        /// Optionally provide additional metadata about the feedback submission.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitCompletionActualRequest(
            string? id,
            string? externalId,
            string? text,
            double? quality,
            global::System.DateTime? timestamp,
            object? metadata)
        {
            this.Id = id;
            this.ExternalId = externalId;
            this.Text = text;
            this.Quality = quality;
            this.Timestamp = timestamp;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitCompletionActualRequest" /> class.
        /// </summary>
        public SubmitCompletionActualRequest()
        {
        }
    }
}