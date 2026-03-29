
#nullable enable

namespace Vellum
{
    /// <summary>
    /// A basic condition comparing two Vellum values.
    /// </summary>
    public sealed partial class VellumValueLogicalConditionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.LogicalConditionEnumJsonConverter))]
        public global::Vellum.LogicalConditionEnum Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lhs_variable")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.VellumValueRequestJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.VellumValueRequest LhsVariable { get; set; }

        /// <summary>
        /// * `=` - EQUALS<br/>
        /// * `!=` - DOES_NOT_EQUAL<br/>
        /// * `&lt;` - LESS_THAN<br/>
        /// * `&gt;` - GREATER_THAN<br/>
        /// * `&lt;=` - LESS_THAN_OR_EQUAL_TO<br/>
        /// * `&gt;=` - GREATER_THAN_OR_EQUAL_TO<br/>
        /// * `contains` - CONTAINS<br/>
        /// * `beginsWith` - BEGINS_WITH<br/>
        /// * `endsWith` - ENDS_WITH<br/>
        /// * `doesNotContain` - DOES_NOT_CONTAIN<br/>
        /// * `doesNotBeginWith` - DOES_NOT_BEGIN_WITH<br/>
        /// * `doesNotEndWith` - DOES_NOT_END_WITH<br/>
        /// * `null` - NULL<br/>
        /// * `notNull` - NOT_NULL<br/>
        /// * `in` - IN<br/>
        /// * `notIn` - NOT_IN<br/>
        /// * `between` - BETWEEN<br/>
        /// * `notBetween` - NOT_BETWEEN<br/>
        /// * `concat` - CONCAT<br/>
        /// * `+` - ADD<br/>
        /// * `-` - MINUS<br/>
        /// * `blank` - BLANK<br/>
        /// * `notBlank` - NOT_BLANK<br/>
        /// * `coalesce` - COALESCE<br/>
        /// * `accessField` - ACCESS_FIELD<br/>
        /// * `parseJson` - PARSE_JSON<br/>
        /// * `and` - AND<br/>
        /// * `or` - OR<br/>
        /// * `isError` - IS_ERROR<br/>
        /// * `length` - LENGTH
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.LogicalOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.LogicalOperator Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rhs_variable")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.VellumValueRequestJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.VellumValueRequest RhsVariable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VellumValueLogicalConditionRequest" /> class.
        /// </summary>
        /// <param name="lhsVariable"></param>
        /// <param name="operator">
        /// * `=` - EQUALS<br/>
        /// * `!=` - DOES_NOT_EQUAL<br/>
        /// * `&lt;` - LESS_THAN<br/>
        /// * `&gt;` - GREATER_THAN<br/>
        /// * `&lt;=` - LESS_THAN_OR_EQUAL_TO<br/>
        /// * `&gt;=` - GREATER_THAN_OR_EQUAL_TO<br/>
        /// * `contains` - CONTAINS<br/>
        /// * `beginsWith` - BEGINS_WITH<br/>
        /// * `endsWith` - ENDS_WITH<br/>
        /// * `doesNotContain` - DOES_NOT_CONTAIN<br/>
        /// * `doesNotBeginWith` - DOES_NOT_BEGIN_WITH<br/>
        /// * `doesNotEndWith` - DOES_NOT_END_WITH<br/>
        /// * `null` - NULL<br/>
        /// * `notNull` - NOT_NULL<br/>
        /// * `in` - IN<br/>
        /// * `notIn` - NOT_IN<br/>
        /// * `between` - BETWEEN<br/>
        /// * `notBetween` - NOT_BETWEEN<br/>
        /// * `concat` - CONCAT<br/>
        /// * `+` - ADD<br/>
        /// * `-` - MINUS<br/>
        /// * `blank` - BLANK<br/>
        /// * `notBlank` - NOT_BLANK<br/>
        /// * `coalesce` - COALESCE<br/>
        /// * `accessField` - ACCESS_FIELD<br/>
        /// * `parseJson` - PARSE_JSON<br/>
        /// * `and` - AND<br/>
        /// * `or` - OR<br/>
        /// * `isError` - IS_ERROR<br/>
        /// * `length` - LENGTH
        /// </param>
        /// <param name="rhsVariable"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VellumValueLogicalConditionRequest(
            global::Vellum.VellumValueRequest lhsVariable,
            global::Vellum.LogicalOperator @operator,
            global::Vellum.VellumValueRequest rhsVariable,
            global::Vellum.LogicalConditionEnum type)
        {
            this.Type = type;
            this.LhsVariable = lhsVariable;
            this.Operator = @operator;
            this.RhsVariable = rhsVariable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VellumValueLogicalConditionRequest" /> class.
        /// </summary>
        public VellumValueLogicalConditionRequest()
        {
        }
    }
}