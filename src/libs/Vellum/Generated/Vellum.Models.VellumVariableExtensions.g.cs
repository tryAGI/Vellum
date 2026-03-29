
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A set of fields with additional properties for use in Vellum Variables.
    /// </summary>
    public sealed partial class VellumVariableExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VellumVariableExtensions" /> class.
        /// </summary>
        /// <param name="color"></param>
        /// <param name="description"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VellumVariableExtensions(
            string? color,
            string? description,
            string? title)
        {
            this.Color = color;
            this.Description = description;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VellumVariableExtensions" /> class.
        /// </summary>
        public VellumVariableExtensions()
        {
        }
    }
}