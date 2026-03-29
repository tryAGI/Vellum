
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A higher-order condition that combines one or more basic conditions or other higher-order conditions.
    /// </summary>
    public sealed partial class VellumValueLogicalConditionGroupRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.LogicalConditionGroupEnumJsonConverter))]
        public global::Vellum.LogicalConditionGroupEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.VellumValueLogicalExpressionRequest> Conditions { get; set; }

        /// <summary>
        /// * `OR` - OR<br/>
        /// * `AND` - AND
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("combinator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.ConditionCombinatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.ConditionCombinator Combinator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Negated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VellumValueLogicalConditionGroupRequest" /> class.
        /// </summary>
        /// <param name="conditions"></param>
        /// <param name="combinator">
        /// * `OR` - OR<br/>
        /// * `AND` - AND
        /// </param>
        /// <param name="negated"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VellumValueLogicalConditionGroupRequest(
            global::System.Collections.Generic.IList<global::Vellum.VellumValueLogicalExpressionRequest> conditions,
            global::Vellum.ConditionCombinator combinator,
            bool negated,
            global::Vellum.LogicalConditionGroupEnum type)
        {
            this.Type = type;
            this.Conditions = conditions ?? throw new global::System.ArgumentNullException(nameof(conditions));
            this.Combinator = combinator;
            this.Negated = negated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VellumValueLogicalConditionGroupRequest" /> class.
        /// </summary>
        public VellumValueLogicalConditionGroupRequest()
        {
        }
    }
}