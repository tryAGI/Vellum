
#nullable enable

namespace Vellum
{
    /// <summary>
    /// Represents a file that has been uploaded to a Vellum Workspace.
    /// </summary>
    public sealed partial class UploadedFileRead
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// A signed URL to download the uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadedFileRead" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fileUrl">
        /// A signed URL to download the uploaded file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadedFileRead(
            global::System.Guid id,
            string? fileUrl)
        {
            this.Id = id;
            this.FileUrl = fileUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadedFileRead" /> class.
        /// </summary>
        public UploadedFileRead()
        {
        }
    }
}