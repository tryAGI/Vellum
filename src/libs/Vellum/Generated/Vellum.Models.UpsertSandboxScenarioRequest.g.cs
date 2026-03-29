
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpsertSandboxScenarioRequest
    {
        /// <summary>
        /// Default Value: Untitled Scenario
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// The inputs for the scenario
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.NamedScenarioInputRequest> Inputs { get; set; }

        /// <summary>
        /// The id of the scenario to update. If none is provided, an id will be generated and a new scenario will be appended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenario_id")]
        public string? ScenarioId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertSandboxScenarioRequest" /> class.
        /// </summary>
        /// <param name="inputs">
        /// The inputs for the scenario
        /// </param>
        /// <param name="label">
        /// Default Value: Untitled Scenario
        /// </param>
        /// <param name="scenarioId">
        /// The id of the scenario to update. If none is provided, an id will be generated and a new scenario will be appended.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertSandboxScenarioRequest(
            global::System.Collections.Generic.IList<global::Vellum.NamedScenarioInputRequest> inputs,
            string? label,
            string? scenarioId)
        {
            this.Label = label;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.ScenarioId = scenarioId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertSandboxScenarioRequest" /> class.
        /// </summary>
        public UpsertSandboxScenarioRequest()
        {
        }
    }
}