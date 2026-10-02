
#nullable enable

namespace Vellum
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptExecConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ml_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MlModel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.VellumVariable> InputVariables { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.PromptParameters Parameters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Vellum.PromptSettings? Settings { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.PromptBlock> Blocks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functions")]
        public global::System.Collections.Generic.IList<global::Vellum.FunctionDefinition>? Functions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptExecConfig" /> class.
        /// </summary>
        /// <param name="mlModel"></param>
        /// <param name="inputVariables"></param>
        /// <param name="parameters"></param>
        /// <param name="blocks"></param>
        /// <param name="settings"></param>
        /// <param name="functions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptExecConfig(
            string mlModel,
            global::System.Collections.Generic.IList<global::Vellum.VellumVariable> inputVariables,
            global::Vellum.PromptParameters parameters,
            global::System.Collections.Generic.IList<global::Vellum.PromptBlock> blocks,
            global::Vellum.PromptSettings? settings,
            global::System.Collections.Generic.IList<global::Vellum.FunctionDefinition>? functions)
        {
            this.MlModel = mlModel ?? throw new global::System.ArgumentNullException(nameof(mlModel));
            this.InputVariables = inputVariables ?? throw new global::System.ArgumentNullException(nameof(inputVariables));
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.Settings = settings;
            this.Blocks = blocks ?? throw new global::System.ArgumentNullException(nameof(blocks));
            this.Functions = functions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptExecConfig" /> class.
        /// </summary>
        public PromptExecConfig()
        {
        }

    }
}