
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A slim representation of a Document Index, as it exists within a Folder.
    /// </summary>
    public sealed partial class FolderEntityDocumentIndex
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.DocumentIndexEnumJsonConverter))]
        public global::Vellum.DocumentIndexEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.FolderEntityDocumentIndexData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderEntityDocumentIndex" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FolderEntityDocumentIndex(
            global::System.Guid id,
            global::Vellum.FolderEntityDocumentIndexData data,
            global::Vellum.DocumentIndexEnum type)
        {
            this.Id = id;
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderEntityDocumentIndex" /> class.
        /// </summary>
        public FolderEntityDocumentIndex()
        {
        }
    }
}