
#nullable enable

namespace Vellum
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MetadataFilterRuleRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("combinator")]
        public global::Vellum.MetadataFilterRuleCombinator? Combinator { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negated")]
        public bool? Negated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::Vellum.MetadataFilterRuleRequest>? Rules { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        public string? Field { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        public global::Vellum.LogicalOperator? Operator { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataFilterRuleRequest" /> class.
        /// </summary>
        /// <param name="combinator"></param>
        /// <param name="negated"></param>
        /// <param name="rules"></param>
        /// <param name="field"></param>
        /// <param name="operator"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataFilterRuleRequest(
            global::Vellum.MetadataFilterRuleCombinator? combinator,
            bool? negated,
            global::System.Collections.Generic.IList<global::Vellum.MetadataFilterRuleRequest>? rules,
            string? field,
            global::Vellum.LogicalOperator? @operator,
            string? value)
        {
            this.Combinator = combinator;
            this.Negated = negated;
            this.Rules = rules;
            this.Field = field;
            this.Operator = @operator;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataFilterRuleRequest" /> class.
        /// </summary>
        public MetadataFilterRuleRequest()
        {
        }

    }
}