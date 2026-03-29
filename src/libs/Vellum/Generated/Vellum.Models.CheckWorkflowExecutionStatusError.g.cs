
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckWorkflowExecutionStatusError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.WorkflowExecutionEventErrorCode?, object>))]
        public global::Vellum.OneOf<global::Vellum.WorkflowExecutionEventErrorCode?, object>? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckWorkflowExecutionStatusError" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckWorkflowExecutionStatusError(
            string? message,
            global::Vellum.OneOf<global::Vellum.WorkflowExecutionEventErrorCode?, object>? code)
        {
            this.Message = message;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckWorkflowExecutionStatusError" /> class.
        /// </summary>
        public CheckWorkflowExecutionStatusError()
        {
        }
    }
}