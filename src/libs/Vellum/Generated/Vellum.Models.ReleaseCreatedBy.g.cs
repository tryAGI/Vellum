
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReleaseCreatedBy
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
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseCreatedBy" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="email"></param>
        /// <param name="fullName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReleaseCreatedBy(
            global::System.Guid id,
            string email,
            string? fullName)
        {
            this.Id = id;
            this.FullName = fullName;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReleaseCreatedBy" /> class.
        /// </summary>
        public ReleaseCreatedBy()
        {
        }
    }
}