
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MapNodeResultData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ExecutionIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iteration_state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.IterationStateEnum?, object>))]
        public global::Vellum.OneOf<global::Vellum.IterationStateEnum?, object>? IterationState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MapNodeResultData" /> class.
        /// </summary>
        /// <param name="executionIds"></param>
        /// <param name="iterationState"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MapNodeResultData(
            global::System.Collections.Generic.IList<global::System.Guid> executionIds,
            global::Vellum.OneOf<global::Vellum.IterationStateEnum?, object>? iterationState)
        {
            this.ExecutionIds = executionIds ?? throw new global::System.ArgumentNullException(nameof(executionIds));
            this.IterationState = iterationState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MapNodeResultData" /> class.
        /// </summary>
        public MapNodeResultData()
        {
        }
    }
}