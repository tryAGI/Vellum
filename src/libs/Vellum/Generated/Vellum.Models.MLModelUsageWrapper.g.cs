
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MLModelUsageWrapper
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ml_model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MlModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ml_model_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.MLModelUsage MlModelUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MLModelUsageWrapper" /> class.
        /// </summary>
        /// <param name="mlModelName"></param>
        /// <param name="mlModelUsage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MLModelUsageWrapper(
            string mlModelName,
            global::Vellum.MLModelUsage mlModelUsage)
        {
            this.MlModelName = mlModelName ?? throw new global::System.ArgumentNullException(nameof(mlModelName));
            this.MlModelUsage = mlModelUsage ?? throw new global::System.ArgumentNullException(nameof(mlModelUsage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MLModelUsageWrapper" /> class.
        /// </summary>
        public MLModelUsageWrapper()
        {
        }
    }
}