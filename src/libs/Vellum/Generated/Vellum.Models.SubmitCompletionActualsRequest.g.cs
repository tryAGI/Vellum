
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubmitCompletionActualsRequest
    {
        /// <summary>
        /// The ID of the deployment. Must provide either this or deployment_name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        public global::System.Guid? DeploymentId { get; set; }

        /// <summary>
        /// The name of the deployment. Must provide either this or deployment_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_name")]
        public string? DeploymentName { get; set; }

        /// <summary>
        /// Feedback regarding the quality of previously generated completions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actuals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.SubmitCompletionActualRequest> Actuals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitCompletionActualsRequest" /> class.
        /// </summary>
        /// <param name="actuals">
        /// Feedback regarding the quality of previously generated completions
        /// </param>
        /// <param name="deploymentId">
        /// The ID of the deployment. Must provide either this or deployment_name.
        /// </param>
        /// <param name="deploymentName">
        /// The name of the deployment. Must provide either this or deployment_id.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitCompletionActualsRequest(
            global::System.Collections.Generic.IList<global::Vellum.SubmitCompletionActualRequest> actuals,
            global::System.Guid? deploymentId,
            string? deploymentName)
        {
            this.DeploymentId = deploymentId;
            this.DeploymentName = deploymentName;
            this.Actuals = actuals ?? throw new global::System.ArgumentNullException(nameof(actuals));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitCompletionActualsRequest" /> class.
        /// </summary>
        public SubmitCompletionActualsRequest()
        {
        }
    }
}