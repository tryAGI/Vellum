
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A slim representation of a Workflow Sandbox, as it exists within a Folder.
    /// </summary>
    public sealed partial class FolderEntityWorkflowSandbox
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.WorkflowSandboxEnumJsonConverter))]
        public global::Vellum.WorkflowSandboxEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.FolderEntityWorkflowSandboxData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderEntityWorkflowSandbox" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FolderEntityWorkflowSandbox(
            global::System.Guid id,
            global::Vellum.FolderEntityWorkflowSandboxData data,
            global::Vellum.WorkflowSandboxEnum type)
        {
            this.Id = id;
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderEntityWorkflowSandbox" /> class.
        /// </summary>
        public FolderEntityWorkflowSandbox()
        {
        }
    }
}