
#nullable enable

namespace Vellum
{
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
    public enum LogicalOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Neq,
        /// <summary>
        /// 
        /// </summary>
        Plus,
        /// <summary>
        /// 
        /// </summary>
        Minus,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        AccessField,
        /// <summary>
        /// 
        /// </summary>
        And,
        /// <summary>
        /// 
        /// </summary>
        BeginsWith,
        /// <summary>
        /// 
        /// </summary>
        Between,
        /// <summary>
        /// 
        /// </summary>
        Blank,
        /// <summary>
        /// 
        /// </summary>
        Coalesce,
        /// <summary>
        /// 
        /// </summary>
        Concat,
        /// <summary>
        /// 
        /// </summary>
        Contains,
        /// <summary>
        /// 
        /// </summary>
        DoesNotBeginWith,
        /// <summary>
        /// 
        /// </summary>
        DoesNotContain,
        /// <summary>
        /// 
        /// </summary>
        DoesNotEndWith,
        /// <summary>
        /// 
        /// </summary>
        EndsWith,
        /// <summary>
        /// 
        /// </summary>
        In,
        /// <summary>
        /// 
        /// </summary>
        IsError,
        /// <summary>
        /// 
        /// </summary>
        Length,
        /// <summary>
        /// 
        /// </summary>
        NotBetween,
        /// <summary>
        /// 
        /// </summary>
        NotBlank,
        /// <summary>
        /// 
        /// </summary>
        NotIn,
        /// <summary>
        /// 
        /// </summary>
        NotNull,
        /// <summary>
        /// 
        /// </summary>
        Null,
        /// <summary>
        /// 
        /// </summary>
        Or,
        /// <summary>
        /// 
        /// </summary>
        ParseJson,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LogicalOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogicalOperator value)
        {
            return value switch
            {
                LogicalOperator.Neq => "!=",
                LogicalOperator.Plus => "+",
                LogicalOperator.Minus => "-",
                LogicalOperator.Lt => "<",
                LogicalOperator.Lte => "<=",
                LogicalOperator.Eq => "=",
                LogicalOperator.Gt => ">",
                LogicalOperator.Gte => ">=",
                LogicalOperator.AccessField => "accessField",
                LogicalOperator.And => "and",
                LogicalOperator.BeginsWith => "beginsWith",
                LogicalOperator.Between => "between",
                LogicalOperator.Blank => "blank",
                LogicalOperator.Coalesce => "coalesce",
                LogicalOperator.Concat => "concat",
                LogicalOperator.Contains => "contains",
                LogicalOperator.DoesNotBeginWith => "doesNotBeginWith",
                LogicalOperator.DoesNotContain => "doesNotContain",
                LogicalOperator.DoesNotEndWith => "doesNotEndWith",
                LogicalOperator.EndsWith => "endsWith",
                LogicalOperator.In => "in",
                LogicalOperator.IsError => "isError",
                LogicalOperator.Length => "length",
                LogicalOperator.NotBetween => "notBetween",
                LogicalOperator.NotBlank => "notBlank",
                LogicalOperator.NotIn => "notIn",
                LogicalOperator.NotNull => "notNull",
                LogicalOperator.Null => "null",
                LogicalOperator.Or => "or",
                LogicalOperator.ParseJson => "parseJson",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogicalOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => LogicalOperator.Neq,
                "+" => LogicalOperator.Plus,
                "-" => LogicalOperator.Minus,
                "<" => LogicalOperator.Lt,
                "<=" => LogicalOperator.Lte,
                "=" => LogicalOperator.Eq,
                ">" => LogicalOperator.Gt,
                ">=" => LogicalOperator.Gte,
                "accessField" => LogicalOperator.AccessField,
                "and" => LogicalOperator.And,
                "beginsWith" => LogicalOperator.BeginsWith,
                "between" => LogicalOperator.Between,
                "blank" => LogicalOperator.Blank,
                "coalesce" => LogicalOperator.Coalesce,
                "concat" => LogicalOperator.Concat,
                "contains" => LogicalOperator.Contains,
                "doesNotBeginWith" => LogicalOperator.DoesNotBeginWith,
                "doesNotContain" => LogicalOperator.DoesNotContain,
                "doesNotEndWith" => LogicalOperator.DoesNotEndWith,
                "endsWith" => LogicalOperator.EndsWith,
                "in" => LogicalOperator.In,
                "isError" => LogicalOperator.IsError,
                "length" => LogicalOperator.Length,
                "notBetween" => LogicalOperator.NotBetween,
                "notBlank" => LogicalOperator.NotBlank,
                "notIn" => LogicalOperator.NotIn,
                "notNull" => LogicalOperator.NotNull,
                "null" => LogicalOperator.Null,
                "or" => LogicalOperator.Or,
                "parseJson" => LogicalOperator.ParseJson,
                _ => null,
            };
        }
    }
}