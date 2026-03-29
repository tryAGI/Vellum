
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Icon to be used alongside a Workflow
    /// </summary>
    public sealed partial class WorkflowDisplayIcon
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        public string? Src { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowDisplayIcon" /> class.
        /// </summary>
        /// <param name="src"></param>
        /// <param name="color"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowDisplayIcon(
            string? src,
            string? color)
        {
            this.Src = src;
            this.Color = color;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowDisplayIcon" /> class.
        /// </summary>
        public WorkflowDisplayIcon()
        {
        }
    }
}