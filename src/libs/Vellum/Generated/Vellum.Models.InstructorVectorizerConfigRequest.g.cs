
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Configuration for using an Instructor vectorizer.
    /// </summary>
    public sealed partial class InstructorVectorizerConfigRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction_domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstructionDomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction_query_text_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstructionQueryTextType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction_document_text_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstructionDocumentTextType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InstructorVectorizerConfigRequest" /> class.
        /// </summary>
        /// <param name="instructionDomain"></param>
        /// <param name="instructionQueryTextType"></param>
        /// <param name="instructionDocumentTextType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InstructorVectorizerConfigRequest(
            string instructionDomain,
            string instructionQueryTextType,
            string instructionDocumentTextType)
        {
            this.InstructionDomain = instructionDomain ?? throw new global::System.ArgumentNullException(nameof(instructionDomain));
            this.InstructionQueryTextType = instructionQueryTextType ?? throw new global::System.ArgumentNullException(nameof(instructionQueryTextType));
            this.InstructionDocumentTextType = instructionDocumentTextType ?? throw new global::System.ArgumentNullException(nameof(instructionDocumentTextType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstructorVectorizerConfigRequest" /> class.
        /// </summary>
        public InstructorVectorizerConfigRequest()
        {
        }
    }
}