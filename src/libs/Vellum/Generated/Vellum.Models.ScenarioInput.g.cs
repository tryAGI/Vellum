#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ScenarioInput : global::System.IEquatable<ScenarioInput>
    {
        /// <summary>
        /// Prompt Sandbox Scenario input value that is of type STRING
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ScenarioInputStringVariableValue? ScenarioInputStringVariableValue { get; init; }
#else
        public global::Vellum.ScenarioInputStringVariableValue? ScenarioInputStringVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScenarioInputStringVariableValue))]
#endif
        public bool IsScenarioInputStringVariableValue => ScenarioInputStringVariableValue != null;

        /// <summary>
        /// Prompt Sandbox Scenario input value that is of type JSON
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ScenarioInputJsonVariableValue? ScenarioInputJsonVariableValue { get; init; }
#else
        public global::Vellum.ScenarioInputJsonVariableValue? ScenarioInputJsonVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScenarioInputJsonVariableValue))]
#endif
        public bool IsScenarioInputJsonVariableValue => ScenarioInputJsonVariableValue != null;

        /// <summary>
        /// Prompt Sandbox Scenario input value that is of type CHAT_HISTORY
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ScenarioInputChatHistoryVariableValue? ScenarioInputChatHistoryVariableValue { get; init; }
#else
        public global::Vellum.ScenarioInputChatHistoryVariableValue? ScenarioInputChatHistoryVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScenarioInputChatHistoryVariableValue))]
#endif
        public bool IsScenarioInputChatHistoryVariableValue => ScenarioInputChatHistoryVariableValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ScenarioInputAudioVariableValue? ScenarioInputAudioVariableValue { get; init; }
#else
        public global::Vellum.ScenarioInputAudioVariableValue? ScenarioInputAudioVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScenarioInputAudioVariableValue))]
#endif
        public bool IsScenarioInputAudioVariableValue => ScenarioInputAudioVariableValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ScenarioInputVideoVariableValue? ScenarioInputVideoVariableValue { get; init; }
#else
        public global::Vellum.ScenarioInputVideoVariableValue? ScenarioInputVideoVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScenarioInputVideoVariableValue))]
#endif
        public bool IsScenarioInputVideoVariableValue => ScenarioInputVideoVariableValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ScenarioInputImageVariableValue? ScenarioInputImageVariableValue { get; init; }
#else
        public global::Vellum.ScenarioInputImageVariableValue? ScenarioInputImageVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScenarioInputImageVariableValue))]
#endif
        public bool IsScenarioInputImageVariableValue => ScenarioInputImageVariableValue != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ScenarioInputDocumentVariableValue? ScenarioInputDocumentVariableValue { get; init; }
#else
        public global::Vellum.ScenarioInputDocumentVariableValue? ScenarioInputDocumentVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScenarioInputDocumentVariableValue))]
#endif
        public bool IsScenarioInputDocumentVariableValue => ScenarioInputDocumentVariableValue != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScenarioInput(global::Vellum.ScenarioInputStringVariableValue value) => new ScenarioInput((global::Vellum.ScenarioInputStringVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ScenarioInputStringVariableValue?(ScenarioInput @this) => @this.ScenarioInputStringVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public ScenarioInput(global::Vellum.ScenarioInputStringVariableValue? value)
        {
            ScenarioInputStringVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScenarioInput(global::Vellum.ScenarioInputJsonVariableValue value) => new ScenarioInput((global::Vellum.ScenarioInputJsonVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ScenarioInputJsonVariableValue?(ScenarioInput @this) => @this.ScenarioInputJsonVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public ScenarioInput(global::Vellum.ScenarioInputJsonVariableValue? value)
        {
            ScenarioInputJsonVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScenarioInput(global::Vellum.ScenarioInputChatHistoryVariableValue value) => new ScenarioInput((global::Vellum.ScenarioInputChatHistoryVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ScenarioInputChatHistoryVariableValue?(ScenarioInput @this) => @this.ScenarioInputChatHistoryVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public ScenarioInput(global::Vellum.ScenarioInputChatHistoryVariableValue? value)
        {
            ScenarioInputChatHistoryVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScenarioInput(global::Vellum.ScenarioInputAudioVariableValue value) => new ScenarioInput((global::Vellum.ScenarioInputAudioVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ScenarioInputAudioVariableValue?(ScenarioInput @this) => @this.ScenarioInputAudioVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public ScenarioInput(global::Vellum.ScenarioInputAudioVariableValue? value)
        {
            ScenarioInputAudioVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScenarioInput(global::Vellum.ScenarioInputVideoVariableValue value) => new ScenarioInput((global::Vellum.ScenarioInputVideoVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ScenarioInputVideoVariableValue?(ScenarioInput @this) => @this.ScenarioInputVideoVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public ScenarioInput(global::Vellum.ScenarioInputVideoVariableValue? value)
        {
            ScenarioInputVideoVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScenarioInput(global::Vellum.ScenarioInputImageVariableValue value) => new ScenarioInput((global::Vellum.ScenarioInputImageVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ScenarioInputImageVariableValue?(ScenarioInput @this) => @this.ScenarioInputImageVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public ScenarioInput(global::Vellum.ScenarioInputImageVariableValue? value)
        {
            ScenarioInputImageVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScenarioInput(global::Vellum.ScenarioInputDocumentVariableValue value) => new ScenarioInput((global::Vellum.ScenarioInputDocumentVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ScenarioInputDocumentVariableValue?(ScenarioInput @this) => @this.ScenarioInputDocumentVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public ScenarioInput(global::Vellum.ScenarioInputDocumentVariableValue? value)
        {
            ScenarioInputDocumentVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ScenarioInput(
            global::Vellum.ScenarioInputStringVariableValue? scenarioInputStringVariableValue,
            global::Vellum.ScenarioInputJsonVariableValue? scenarioInputJsonVariableValue,
            global::Vellum.ScenarioInputChatHistoryVariableValue? scenarioInputChatHistoryVariableValue,
            global::Vellum.ScenarioInputAudioVariableValue? scenarioInputAudioVariableValue,
            global::Vellum.ScenarioInputVideoVariableValue? scenarioInputVideoVariableValue,
            global::Vellum.ScenarioInputImageVariableValue? scenarioInputImageVariableValue,
            global::Vellum.ScenarioInputDocumentVariableValue? scenarioInputDocumentVariableValue
            )
        {
            ScenarioInputStringVariableValue = scenarioInputStringVariableValue;
            ScenarioInputJsonVariableValue = scenarioInputJsonVariableValue;
            ScenarioInputChatHistoryVariableValue = scenarioInputChatHistoryVariableValue;
            ScenarioInputAudioVariableValue = scenarioInputAudioVariableValue;
            ScenarioInputVideoVariableValue = scenarioInputVideoVariableValue;
            ScenarioInputImageVariableValue = scenarioInputImageVariableValue;
            ScenarioInputDocumentVariableValue = scenarioInputDocumentVariableValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ScenarioInputDocumentVariableValue as object ??
            ScenarioInputImageVariableValue as object ??
            ScenarioInputVideoVariableValue as object ??
            ScenarioInputAudioVariableValue as object ??
            ScenarioInputChatHistoryVariableValue as object ??
            ScenarioInputJsonVariableValue as object ??
            ScenarioInputStringVariableValue as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ScenarioInputStringVariableValue?.ToString() ??
            ScenarioInputJsonVariableValue?.ToString() ??
            ScenarioInputChatHistoryVariableValue?.ToString() ??
            ScenarioInputAudioVariableValue?.ToString() ??
            ScenarioInputVideoVariableValue?.ToString() ??
            ScenarioInputImageVariableValue?.ToString() ??
            ScenarioInputDocumentVariableValue?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsScenarioInputStringVariableValue && !IsScenarioInputJsonVariableValue && !IsScenarioInputChatHistoryVariableValue && !IsScenarioInputAudioVariableValue && !IsScenarioInputVideoVariableValue && !IsScenarioInputImageVariableValue && !IsScenarioInputDocumentVariableValue || !IsScenarioInputStringVariableValue && IsScenarioInputJsonVariableValue && !IsScenarioInputChatHistoryVariableValue && !IsScenarioInputAudioVariableValue && !IsScenarioInputVideoVariableValue && !IsScenarioInputImageVariableValue && !IsScenarioInputDocumentVariableValue || !IsScenarioInputStringVariableValue && !IsScenarioInputJsonVariableValue && IsScenarioInputChatHistoryVariableValue && !IsScenarioInputAudioVariableValue && !IsScenarioInputVideoVariableValue && !IsScenarioInputImageVariableValue && !IsScenarioInputDocumentVariableValue || !IsScenarioInputStringVariableValue && !IsScenarioInputJsonVariableValue && !IsScenarioInputChatHistoryVariableValue && IsScenarioInputAudioVariableValue && !IsScenarioInputVideoVariableValue && !IsScenarioInputImageVariableValue && !IsScenarioInputDocumentVariableValue || !IsScenarioInputStringVariableValue && !IsScenarioInputJsonVariableValue && !IsScenarioInputChatHistoryVariableValue && !IsScenarioInputAudioVariableValue && IsScenarioInputVideoVariableValue && !IsScenarioInputImageVariableValue && !IsScenarioInputDocumentVariableValue || !IsScenarioInputStringVariableValue && !IsScenarioInputJsonVariableValue && !IsScenarioInputChatHistoryVariableValue && !IsScenarioInputAudioVariableValue && !IsScenarioInputVideoVariableValue && IsScenarioInputImageVariableValue && !IsScenarioInputDocumentVariableValue || !IsScenarioInputStringVariableValue && !IsScenarioInputJsonVariableValue && !IsScenarioInputChatHistoryVariableValue && !IsScenarioInputAudioVariableValue && !IsScenarioInputVideoVariableValue && !IsScenarioInputImageVariableValue && IsScenarioInputDocumentVariableValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.ScenarioInputStringVariableValue?, TResult>? scenarioInputStringVariableValue = null,
            global::System.Func<global::Vellum.ScenarioInputJsonVariableValue?, TResult>? scenarioInputJsonVariableValue = null,
            global::System.Func<global::Vellum.ScenarioInputChatHistoryVariableValue?, TResult>? scenarioInputChatHistoryVariableValue = null,
            global::System.Func<global::Vellum.ScenarioInputAudioVariableValue?, TResult>? scenarioInputAudioVariableValue = null,
            global::System.Func<global::Vellum.ScenarioInputVideoVariableValue?, TResult>? scenarioInputVideoVariableValue = null,
            global::System.Func<global::Vellum.ScenarioInputImageVariableValue?, TResult>? scenarioInputImageVariableValue = null,
            global::System.Func<global::Vellum.ScenarioInputDocumentVariableValue?, TResult>? scenarioInputDocumentVariableValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScenarioInputStringVariableValue && scenarioInputStringVariableValue != null)
            {
                return scenarioInputStringVariableValue(ScenarioInputStringVariableValue!);
            }
            else if (IsScenarioInputJsonVariableValue && scenarioInputJsonVariableValue != null)
            {
                return scenarioInputJsonVariableValue(ScenarioInputJsonVariableValue!);
            }
            else if (IsScenarioInputChatHistoryVariableValue && scenarioInputChatHistoryVariableValue != null)
            {
                return scenarioInputChatHistoryVariableValue(ScenarioInputChatHistoryVariableValue!);
            }
            else if (IsScenarioInputAudioVariableValue && scenarioInputAudioVariableValue != null)
            {
                return scenarioInputAudioVariableValue(ScenarioInputAudioVariableValue!);
            }
            else if (IsScenarioInputVideoVariableValue && scenarioInputVideoVariableValue != null)
            {
                return scenarioInputVideoVariableValue(ScenarioInputVideoVariableValue!);
            }
            else if (IsScenarioInputImageVariableValue && scenarioInputImageVariableValue != null)
            {
                return scenarioInputImageVariableValue(ScenarioInputImageVariableValue!);
            }
            else if (IsScenarioInputDocumentVariableValue && scenarioInputDocumentVariableValue != null)
            {
                return scenarioInputDocumentVariableValue(ScenarioInputDocumentVariableValue!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.ScenarioInputStringVariableValue?>? scenarioInputStringVariableValue = null,
            global::System.Action<global::Vellum.ScenarioInputJsonVariableValue?>? scenarioInputJsonVariableValue = null,
            global::System.Action<global::Vellum.ScenarioInputChatHistoryVariableValue?>? scenarioInputChatHistoryVariableValue = null,
            global::System.Action<global::Vellum.ScenarioInputAudioVariableValue?>? scenarioInputAudioVariableValue = null,
            global::System.Action<global::Vellum.ScenarioInputVideoVariableValue?>? scenarioInputVideoVariableValue = null,
            global::System.Action<global::Vellum.ScenarioInputImageVariableValue?>? scenarioInputImageVariableValue = null,
            global::System.Action<global::Vellum.ScenarioInputDocumentVariableValue?>? scenarioInputDocumentVariableValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScenarioInputStringVariableValue)
            {
                scenarioInputStringVariableValue?.Invoke(ScenarioInputStringVariableValue!);
            }
            else if (IsScenarioInputJsonVariableValue)
            {
                scenarioInputJsonVariableValue?.Invoke(ScenarioInputJsonVariableValue!);
            }
            else if (IsScenarioInputChatHistoryVariableValue)
            {
                scenarioInputChatHistoryVariableValue?.Invoke(ScenarioInputChatHistoryVariableValue!);
            }
            else if (IsScenarioInputAudioVariableValue)
            {
                scenarioInputAudioVariableValue?.Invoke(ScenarioInputAudioVariableValue!);
            }
            else if (IsScenarioInputVideoVariableValue)
            {
                scenarioInputVideoVariableValue?.Invoke(ScenarioInputVideoVariableValue!);
            }
            else if (IsScenarioInputImageVariableValue)
            {
                scenarioInputImageVariableValue?.Invoke(ScenarioInputImageVariableValue!);
            }
            else if (IsScenarioInputDocumentVariableValue)
            {
                scenarioInputDocumentVariableValue?.Invoke(ScenarioInputDocumentVariableValue!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ScenarioInputStringVariableValue,
                typeof(global::Vellum.ScenarioInputStringVariableValue),
                ScenarioInputJsonVariableValue,
                typeof(global::Vellum.ScenarioInputJsonVariableValue),
                ScenarioInputChatHistoryVariableValue,
                typeof(global::Vellum.ScenarioInputChatHistoryVariableValue),
                ScenarioInputAudioVariableValue,
                typeof(global::Vellum.ScenarioInputAudioVariableValue),
                ScenarioInputVideoVariableValue,
                typeof(global::Vellum.ScenarioInputVideoVariableValue),
                ScenarioInputImageVariableValue,
                typeof(global::Vellum.ScenarioInputImageVariableValue),
                ScenarioInputDocumentVariableValue,
                typeof(global::Vellum.ScenarioInputDocumentVariableValue),
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
        public bool Equals(ScenarioInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ScenarioInputStringVariableValue?>.Default.Equals(ScenarioInputStringVariableValue, other.ScenarioInputStringVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ScenarioInputJsonVariableValue?>.Default.Equals(ScenarioInputJsonVariableValue, other.ScenarioInputJsonVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ScenarioInputChatHistoryVariableValue?>.Default.Equals(ScenarioInputChatHistoryVariableValue, other.ScenarioInputChatHistoryVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ScenarioInputAudioVariableValue?>.Default.Equals(ScenarioInputAudioVariableValue, other.ScenarioInputAudioVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ScenarioInputVideoVariableValue?>.Default.Equals(ScenarioInputVideoVariableValue, other.ScenarioInputVideoVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ScenarioInputImageVariableValue?>.Default.Equals(ScenarioInputImageVariableValue, other.ScenarioInputImageVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ScenarioInputDocumentVariableValue?>.Default.Equals(ScenarioInputDocumentVariableValue, other.ScenarioInputDocumentVariableValue) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ScenarioInput obj1, ScenarioInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ScenarioInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ScenarioInput obj1, ScenarioInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScenarioInput o && Equals(o);
        }
    }
}
