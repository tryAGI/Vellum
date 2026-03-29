
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersionBuildConfigSandbox
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.SandboxEnumJsonConverter))]
        public global::Vellum.SandboxEnum Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SandboxId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox_snapshot_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SandboxSnapshotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionBuildConfigSandbox" /> class.
        /// </summary>
        /// <param name="sandboxId"></param>
        /// <param name="sandboxSnapshotId"></param>
        /// <param name="promptId"></param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersionBuildConfigSandbox(
            global::System.Guid sandboxId,
            global::System.Guid sandboxSnapshotId,
            string promptId,
            global::Vellum.SandboxEnum source)
        {
            this.Source = source;
            this.SandboxId = sandboxId;
            this.SandboxSnapshotId = sandboxSnapshotId;
            this.PromptId = promptId ?? throw new global::System.ArgumentNullException(nameof(promptId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionBuildConfigSandbox" /> class.
        /// </summary>
        public PromptVersionBuildConfigSandbox()
        {
        }
    }
}