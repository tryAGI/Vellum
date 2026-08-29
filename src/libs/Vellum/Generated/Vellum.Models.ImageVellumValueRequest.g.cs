
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A base Vellum primitive value representing an image.
    /// </summary>
    public sealed partial class ImageVellumValueRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ImageEnumJsonConverter))]
        public global::Vellum.ImageEnum Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::Vellum.VellumImageRequest? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageVellumValueRequest" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageVellumValueRequest(
            global::Vellum.ImageEnum type,
            global::Vellum.VellumImageRequest? value)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageVellumValueRequest" /> class.
        /// </summary>
        public ImageVellumValueRequest()
        {
        }

    }
}