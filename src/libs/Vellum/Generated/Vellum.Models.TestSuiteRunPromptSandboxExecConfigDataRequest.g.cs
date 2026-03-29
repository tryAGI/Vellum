
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteRunPromptSandboxExecConfigDataRequest
    {
        /// <summary>
        /// The ID of the Prompt Sandbox to run the Test Suite against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_sandbox_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PromptSandboxId { get; set; }

        /// <summary>
        /// The ID of the Prompt Variant within the Prompt Sandbox that you'd like to run the Test Suite against.
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
        /// Initializes a new instance of the <see cref="TestSuiteRunPromptSandboxExecConfigDataRequest" /> class.
        /// </summary>
        /// <param name="promptSandboxId">
        /// The ID of the Prompt Sandbox to run the Test Suite against.
        /// </param>
        /// <param name="promptVariantId">
        /// The ID of the Prompt Variant within the Prompt Sandbox that you'd like to run the Test Suite against.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunPromptSandboxExecConfigDataRequest(
            global::System.Guid promptSandboxId,
            global::System.Guid promptVariantId)
        {
            this.PromptSandboxId = promptSandboxId;
            this.PromptVariantId = promptVariantId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunPromptSandboxExecConfigDataRequest" /> class.
        /// </summary>
        public TestSuiteRunPromptSandboxExecConfigDataRequest()
        {
        }
    }
}