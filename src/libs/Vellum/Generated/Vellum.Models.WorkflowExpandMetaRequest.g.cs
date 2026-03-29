
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExpandMetaRequest
    {
        /// <summary>
        /// If enabled, the Prompt Node FULFILLED events will include model host usage tracking. This may increase latency for some model hosts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public bool? Usage { get; set; }

        /// <summary>
        /// If enabled, the Prompt Node FULFILLED events will include model host cost tracking. This may increase latency for some model hosts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public bool? Cost { get; set; }

        /// <summary>
        /// If enabled, the Prompt Node FULFILLED events will include model host name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public bool? ModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExpandMetaRequest" /> class.
        /// </summary>
        /// <param name="usage">
        /// If enabled, the Prompt Node FULFILLED events will include model host usage tracking. This may increase latency for some model hosts.
        /// </param>
        /// <param name="cost">
        /// If enabled, the Prompt Node FULFILLED events will include model host cost tracking. This may increase latency for some model hosts.
        /// </param>
        /// <param name="modelName">
        /// If enabled, the Prompt Node FULFILLED events will include model host name
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExpandMetaRequest(
            bool? usage,
            bool? cost,
            bool? modelName)
        {
            this.Usage = usage;
            this.Cost = cost;
            this.ModelName = modelName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExpandMetaRequest" /> class.
        /// </summary>
        public WorkflowExpandMetaRequest()
        {
        }
    }
}