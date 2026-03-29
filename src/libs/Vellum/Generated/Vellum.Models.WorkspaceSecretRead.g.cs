
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceSecretRead
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
        [global::System.Text.Json.Serialization.JsonPropertyName("modified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Modified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// * `USER_DEFINED` - User Defined<br/>
        /// * `HMAC` - Hmac<br/>
        /// * `INTERNAL_API_KEY` - Internal Api Key<br/>
        /// * `EXTERNALLY_PROVISIONED` - Externally Provisioned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.SecretTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.SecretTypeEnum SecretType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceSecretRead" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="modified"></param>
        /// <param name="name"></param>
        /// <param name="label"></param>
        /// <param name="secretType">
        /// * `USER_DEFINED` - User Defined<br/>
        /// * `HMAC` - Hmac<br/>
        /// * `INTERNAL_API_KEY` - Internal Api Key<br/>
        /// * `EXTERNALLY_PROVISIONED` - Externally Provisioned
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceSecretRead(
            global::System.Guid id,
            global::System.DateTime modified,
            string name,
            string label,
            global::Vellum.SecretTypeEnum secretType)
        {
            this.Id = id;
            this.Modified = modified;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.SecretType = secretType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceSecretRead" /> class.
        /// </summary>
        public WorkspaceSecretRead()
        {
        }
    }
}