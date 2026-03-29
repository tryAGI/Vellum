
#nullable enable

namespace Vellum
{
    /// <summary>
    /// The source of a search result from a PDF document.
    /// </summary>
    public sealed partial class PdfSearchResultMetaSourceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.PdfEnumJsonConverter))]
        public global::Vellum.PdfEnum DocumentType { get; set; }

        /// <summary>
        /// The 1-indexed page number where the chunk starts in the document. Only available for supported chunking strategies and document types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_page_num")]
        public int? StartPageNum { get; set; }

        /// <summary>
        /// The 1-indexed page number where the chunk ends in the document. Only available for supported chunking strategies and document types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_page_num")]
        public int? EndPageNum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSearchResultMetaSourceRequest" /> class.
        /// </summary>
        /// <param name="documentType"></param>
        /// <param name="startPageNum">
        /// The 1-indexed page number where the chunk starts in the document. Only available for supported chunking strategies and document types.
        /// </param>
        /// <param name="endPageNum">
        /// The 1-indexed page number where the chunk ends in the document. Only available for supported chunking strategies and document types.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PdfSearchResultMetaSourceRequest(
            global::Vellum.PdfEnum documentType,
            int? startPageNum,
            int? endPageNum)
        {
            this.DocumentType = documentType;
            this.StartPageNum = startPageNum;
            this.EndPageNum = endPageNum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfSearchResultMetaSourceRequest" /> class.
        /// </summary>
        public PdfSearchResultMetaSourceRequest()
        {
        }
    }
}