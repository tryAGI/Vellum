
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Sandbox Scenario
    /// </summary>
    public sealed partial class SandboxScenario
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
        public required global::System.Collections.Generic.IList<global::Vellum.ScenarioInput> Inputs { get; set; }

        /// <summary>
        /// The id of the scenario
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxScenario" /> class.
        /// </summary>
        /// <param name="inputs">
        /// The inputs for the scenario
        /// </param>
        /// <param name="id">
        /// The id of the scenario
        /// </param>
        /// <param name="label">
        /// Default Value: Untitled Scenario
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxScenario(
            global::System.Collections.Generic.IList<global::Vellum.ScenarioInput> inputs,
            string id,
            string? label)
        {
            this.Label = label;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxScenario" /> class.
        /// </summary>
        public SandboxScenario()
        {
        }
    }
}