
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VellumImageRequest
    {
        /// <summary>
        /// The reference to the source data. This can be one of the following formats:<br/>
        /// 1. A base64-encoded data URL (e.g., 'data:application/pdf;base64,JVBERi0xLjQKJcfs...').<br/>
        /// 2. A url pointing to a file accessible over HTTP or HTTPS.<br/>
        /// 3. A reference to a file that's been previously uploaded to Vellum, in the form of 'vellum:uploaded-file:{uploaded_file_id}'.<br/>
        ///     You can use the Uploaded Files API to retrieve the url of the uploaded file given its ID. See https://docs.vellum.ai/developers/client-sdk/uploaded-files/retrieve for details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Src { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VellumImageRequest" /> class.
        /// </summary>
        /// <param name="src">
        /// The reference to the source data. This can be one of the following formats:<br/>
        /// 1. A base64-encoded data URL (e.g., 'data:application/pdf;base64,JVBERi0xLjQKJcfs...').<br/>
        /// 2. A url pointing to a file accessible over HTTP or HTTPS.<br/>
        /// 3. A reference to a file that's been previously uploaded to Vellum, in the form of 'vellum:uploaded-file:{uploaded_file_id}'.<br/>
        ///     You can use the Uploaded Files API to retrieve the url of the uploaded file given its ID. See https://docs.vellum.ai/developers/client-sdk/uploaded-files/retrieve for details.
        /// </param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VellumImageRequest(
            string src,
            object? metadata)
        {
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VellumImageRequest" /> class.
        /// </summary>
        public VellumImageRequest()
        {
        }
    }
}