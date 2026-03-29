
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiNodeResultData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json")]
        public object? Json { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_output_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TextOutputId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_output_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JsonOutputId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code_output_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StatusCodeOutputId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiNodeResultData" /> class.
        /// </summary>
        /// <param name="textOutputId"></param>
        /// <param name="jsonOutputId"></param>
        /// <param name="statusCodeOutputId"></param>
        /// <param name="statusCode"></param>
        /// <param name="json"></param>
        /// <param name="text"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiNodeResultData(
            string textOutputId,
            string jsonOutputId,
            string statusCodeOutputId,
            int statusCode,
            object? json,
            string? text)
        {
            this.Json = json;
            this.TextOutputId = textOutputId ?? throw new global::System.ArgumentNullException(nameof(textOutputId));
            this.Text = text;
            this.JsonOutputId = jsonOutputId ?? throw new global::System.ArgumentNullException(nameof(jsonOutputId));
            this.StatusCodeOutputId = statusCodeOutputId ?? throw new global::System.ArgumentNullException(nameof(statusCodeOutputId));
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiNodeResultData" /> class.
        /// </summary>
        public ApiNodeResultData()
        {
        }
    }
}