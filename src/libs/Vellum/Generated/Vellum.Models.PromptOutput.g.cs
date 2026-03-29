#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PromptOutput : global::System.IEquatable<PromptOutput>
    {
        /// <summary>
        /// A value representing a string.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.StringVellumValue? StringVellumValue { get; init; }
#else
        public global::Vellum.StringVellumValue? StringVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StringVellumValue))]
#endif
        public bool IsStringVellumValue => StringVellumValue != null;

        /// <summary>
        /// A value representing a JSON object.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.JsonVellumValue? JsonVellumValue { get; init; }
#else
        public global::Vellum.JsonVellumValue? JsonVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonVellumValue))]
#endif
        public bool IsJsonVellumValue => JsonVellumValue != null;

        /// <summary>
        /// A value representing an Error.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ErrorVellumValue? ErrorVellumValue { get; init; }
#else
        public global::Vellum.ErrorVellumValue? ErrorVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ErrorVellumValue))]
#endif
        public bool IsErrorVellumValue => ErrorVellumValue != null;

        /// <summary>
        /// A value representing a Function Call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.FunctionCallVellumValue? FunctionCallVellumValue { get; init; }
#else
        public global::Vellum.FunctionCallVellumValue? FunctionCallVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallVellumValue))]
#endif
        public bool IsFunctionCallVellumValue => FunctionCallVellumValue != null;

        /// <summary>
        /// A value representing Thinking mode output.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ThinkingVellumValue? ThinkingVellumValue { get; init; }
#else
        public global::Vellum.ThinkingVellumValue? ThinkingVellumValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThinkingVellumValue))]
#endif
        public bool IsThinkingVellumValue => ThinkingVellumValue != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptOutput(global::Vellum.StringVellumValue value) => new PromptOutput((global::Vellum.StringVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.StringVellumValue?(PromptOutput @this) => @this.StringVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public PromptOutput(global::Vellum.StringVellumValue? value)
        {
            StringVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptOutput(global::Vellum.JsonVellumValue value) => new PromptOutput((global::Vellum.JsonVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.JsonVellumValue?(PromptOutput @this) => @this.JsonVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public PromptOutput(global::Vellum.JsonVellumValue? value)
        {
            JsonVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptOutput(global::Vellum.ErrorVellumValue value) => new PromptOutput((global::Vellum.ErrorVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ErrorVellumValue?(PromptOutput @this) => @this.ErrorVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public PromptOutput(global::Vellum.ErrorVellumValue? value)
        {
            ErrorVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptOutput(global::Vellum.FunctionCallVellumValue value) => new PromptOutput((global::Vellum.FunctionCallVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.FunctionCallVellumValue?(PromptOutput @this) => @this.FunctionCallVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public PromptOutput(global::Vellum.FunctionCallVellumValue? value)
        {
            FunctionCallVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptOutput(global::Vellum.ThinkingVellumValue value) => new PromptOutput((global::Vellum.ThinkingVellumValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ThinkingVellumValue?(PromptOutput @this) => @this.ThinkingVellumValue;

        /// <summary>
        /// 
        /// </summary>
        public PromptOutput(global::Vellum.ThinkingVellumValue? value)
        {
            ThinkingVellumValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PromptOutput(
            global::Vellum.StringVellumValue? stringVellumValue,
            global::Vellum.JsonVellumValue? jsonVellumValue,
            global::Vellum.ErrorVellumValue? errorVellumValue,
            global::Vellum.FunctionCallVellumValue? functionCallVellumValue,
            global::Vellum.ThinkingVellumValue? thinkingVellumValue
            )
        {
            StringVellumValue = stringVellumValue;
            JsonVellumValue = jsonVellumValue;
            ErrorVellumValue = errorVellumValue;
            FunctionCallVellumValue = functionCallVellumValue;
            ThinkingVellumValue = thinkingVellumValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ThinkingVellumValue as object ??
            FunctionCallVellumValue as object ??
            ErrorVellumValue as object ??
            JsonVellumValue as object ??
            StringVellumValue as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StringVellumValue?.ToString() ??
            JsonVellumValue?.ToString() ??
            ErrorVellumValue?.ToString() ??
            FunctionCallVellumValue?.ToString() ??
            ThinkingVellumValue?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStringVellumValue && !IsJsonVellumValue && !IsErrorVellumValue && !IsFunctionCallVellumValue && !IsThinkingVellumValue || !IsStringVellumValue && IsJsonVellumValue && !IsErrorVellumValue && !IsFunctionCallVellumValue && !IsThinkingVellumValue || !IsStringVellumValue && !IsJsonVellumValue && IsErrorVellumValue && !IsFunctionCallVellumValue && !IsThinkingVellumValue || !IsStringVellumValue && !IsJsonVellumValue && !IsErrorVellumValue && IsFunctionCallVellumValue && !IsThinkingVellumValue || !IsStringVellumValue && !IsJsonVellumValue && !IsErrorVellumValue && !IsFunctionCallVellumValue && IsThinkingVellumValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.StringVellumValue?, TResult>? stringVellumValue = null,
            global::System.Func<global::Vellum.JsonVellumValue?, TResult>? jsonVellumValue = null,
            global::System.Func<global::Vellum.ErrorVellumValue?, TResult>? errorVellumValue = null,
            global::System.Func<global::Vellum.FunctionCallVellumValue?, TResult>? functionCallVellumValue = null,
            global::System.Func<global::Vellum.ThinkingVellumValue?, TResult>? thinkingVellumValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringVellumValue && stringVellumValue != null)
            {
                return stringVellumValue(StringVellumValue!);
            }
            else if (IsJsonVellumValue && jsonVellumValue != null)
            {
                return jsonVellumValue(JsonVellumValue!);
            }
            else if (IsErrorVellumValue && errorVellumValue != null)
            {
                return errorVellumValue(ErrorVellumValue!);
            }
            else if (IsFunctionCallVellumValue && functionCallVellumValue != null)
            {
                return functionCallVellumValue(FunctionCallVellumValue!);
            }
            else if (IsThinkingVellumValue && thinkingVellumValue != null)
            {
                return thinkingVellumValue(ThinkingVellumValue!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.StringVellumValue?>? stringVellumValue = null,
            global::System.Action<global::Vellum.JsonVellumValue?>? jsonVellumValue = null,
            global::System.Action<global::Vellum.ErrorVellumValue?>? errorVellumValue = null,
            global::System.Action<global::Vellum.FunctionCallVellumValue?>? functionCallVellumValue = null,
            global::System.Action<global::Vellum.ThinkingVellumValue?>? thinkingVellumValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringVellumValue)
            {
                stringVellumValue?.Invoke(StringVellumValue!);
            }
            else if (IsJsonVellumValue)
            {
                jsonVellumValue?.Invoke(JsonVellumValue!);
            }
            else if (IsErrorVellumValue)
            {
                errorVellumValue?.Invoke(ErrorVellumValue!);
            }
            else if (IsFunctionCallVellumValue)
            {
                functionCallVellumValue?.Invoke(FunctionCallVellumValue!);
            }
            else if (IsThinkingVellumValue)
            {
                thinkingVellumValue?.Invoke(ThinkingVellumValue!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StringVellumValue,
                typeof(global::Vellum.StringVellumValue),
                JsonVellumValue,
                typeof(global::Vellum.JsonVellumValue),
                ErrorVellumValue,
                typeof(global::Vellum.ErrorVellumValue),
                FunctionCallVellumValue,
                typeof(global::Vellum.FunctionCallVellumValue),
                ThinkingVellumValue,
                typeof(global::Vellum.ThinkingVellumValue),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(PromptOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.StringVellumValue?>.Default.Equals(StringVellumValue, other.StringVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.JsonVellumValue?>.Default.Equals(JsonVellumValue, other.JsonVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ErrorVellumValue?>.Default.Equals(ErrorVellumValue, other.ErrorVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.FunctionCallVellumValue?>.Default.Equals(FunctionCallVellumValue, other.FunctionCallVellumValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ThinkingVellumValue?>.Default.Equals(ThinkingVellumValue, other.ThinkingVellumValue) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PromptOutput obj1, PromptOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PromptOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PromptOutput obj1, PromptOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PromptOutput o && Equals(o);
        }
    }
}
