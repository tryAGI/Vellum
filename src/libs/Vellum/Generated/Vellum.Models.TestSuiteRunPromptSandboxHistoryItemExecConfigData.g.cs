
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteRunPromptSandboxHistoryItemExecConfigData
    {
        /// <summary>
        /// The ID of the Prompt Sandbox History Item that the Test Suite will run against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid HistoryItemId { get; set; }

        /// <summary>
        /// The ID of the Prompt Variant within the Prompt Sandbox History Item that you'd like to run the Test Suite against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_variant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PromptVariantId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunPromptSandboxHistoryItemExecConfigData" /> class.
        /// </summary>
        /// <param name="historyItemId">
        /// The ID of the Prompt Sandbox History Item that the Test Suite will run against.
        /// </param>
        /// <param name="promptVariantId">
        /// The ID of the Prompt Variant within the Prompt Sandbox History Item that you'd like to run the Test Suite against.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunPromptSandboxHistoryItemExecConfigData(
            global::System.Guid historyItemId,
            global::System.Guid promptVariantId)
        {
            this.HistoryItemId = historyItemId;
            this.PromptVariantId = promptVariantId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunPromptSandboxHistoryItemExecConfigData" /> class.
        /// </summary>
        public TestSuiteRunPromptSandboxHistoryItemExecConfigData()
        {
        }
    }
}