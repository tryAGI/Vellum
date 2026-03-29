#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct NamedScenarioInputRequest : global::System.IEquatable<NamedScenarioInputRequest>
    {
        /// <summary>
        /// Named Prompt Sandbox Scenario input value that is of type STRING
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedScenarioInputStringVariableValueRequest? NamedScenarioInputStringVariableValueRequest { get; init; }
#else
        public global::Vellum.NamedScenarioInputStringVariableValueRequest? NamedScenarioInputStringVariableValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedScenarioInputStringVariableValueRequest))]
#endif
        public bool IsNamedScenarioInputStringVariableValueRequest => NamedScenarioInputStringVariableValueRequest != null;

        /// <summary>
        /// Named Prompt Sandbox Scenario input value that is of type JSON
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedScenarioInputJsonVariableValueRequest? NamedScenarioInputJsonVariableValueRequest { get; init; }
#else
        public global::Vellum.NamedScenarioInputJsonVariableValueRequest? NamedScenarioInputJsonVariableValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedScenarioInputJsonVariableValueRequest))]
#endif
        public bool IsNamedScenarioInputJsonVariableValueRequest => NamedScenarioInputJsonVariableValueRequest != null;

        /// <summary>
        /// Named Prompt Sandbox Scenario input value that is of type CHAT_HISTORY
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest? NamedScenarioInputChatHistoryVariableValueRequest { get; init; }
#else
        public global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest? NamedScenarioInputChatHistoryVariableValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedScenarioInputChatHistoryVariableValueRequest))]
#endif
        public bool IsNamedScenarioInputChatHistoryVariableValueRequest => NamedScenarioInputChatHistoryVariableValueRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedScenarioInputAudioVariableValueRequest? NamedScenarioInputAudioVariableValueRequest { get; init; }
#else
        public global::Vellum.NamedScenarioInputAudioVariableValueRequest? NamedScenarioInputAudioVariableValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedScenarioInputAudioVariableValueRequest))]
#endif
        public bool IsNamedScenarioInputAudioVariableValueRequest => NamedScenarioInputAudioVariableValueRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedScenarioInputVideoVariableValueRequest? NamedScenarioInputVideoVariableValueRequest { get; init; }
#else
        public global::Vellum.NamedScenarioInputVideoVariableValueRequest? NamedScenarioInputVideoVariableValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedScenarioInputVideoVariableValueRequest))]
#endif
        public bool IsNamedScenarioInputVideoVariableValueRequest => NamedScenarioInputVideoVariableValueRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedScenarioInputImageVariableValueRequest? NamedScenarioInputImageVariableValueRequest { get; init; }
#else
        public global::Vellum.NamedScenarioInputImageVariableValueRequest? NamedScenarioInputImageVariableValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedScenarioInputImageVariableValueRequest))]
#endif
        public bool IsNamedScenarioInputImageVariableValueRequest => NamedScenarioInputImageVariableValueRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.NamedScenarioInputDocumentVariableValueRequest? NamedScenarioInputDocumentVariableValueRequest { get; init; }
#else
        public global::Vellum.NamedScenarioInputDocumentVariableValueRequest? NamedScenarioInputDocumentVariableValueRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamedScenarioInputDocumentVariableValueRequest))]
#endif
        public bool IsNamedScenarioInputDocumentVariableValueRequest => NamedScenarioInputDocumentVariableValueRequest != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedScenarioInputRequest(global::Vellum.NamedScenarioInputStringVariableValueRequest value) => new NamedScenarioInputRequest((global::Vellum.NamedScenarioInputStringVariableValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedScenarioInputStringVariableValueRequest?(NamedScenarioInputRequest @this) => @this.NamedScenarioInputStringVariableValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public NamedScenarioInputRequest(global::Vellum.NamedScenarioInputStringVariableValueRequest? value)
        {
            NamedScenarioInputStringVariableValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedScenarioInputRequest(global::Vellum.NamedScenarioInputJsonVariableValueRequest value) => new NamedScenarioInputRequest((global::Vellum.NamedScenarioInputJsonVariableValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedScenarioInputJsonVariableValueRequest?(NamedScenarioInputRequest @this) => @this.NamedScenarioInputJsonVariableValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public NamedScenarioInputRequest(global::Vellum.NamedScenarioInputJsonVariableValueRequest? value)
        {
            NamedScenarioInputJsonVariableValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedScenarioInputRequest(global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest value) => new NamedScenarioInputRequest((global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest?(NamedScenarioInputRequest @this) => @this.NamedScenarioInputChatHistoryVariableValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public NamedScenarioInputRequest(global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest? value)
        {
            NamedScenarioInputChatHistoryVariableValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedScenarioInputRequest(global::Vellum.NamedScenarioInputAudioVariableValueRequest value) => new NamedScenarioInputRequest((global::Vellum.NamedScenarioInputAudioVariableValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedScenarioInputAudioVariableValueRequest?(NamedScenarioInputRequest @this) => @this.NamedScenarioInputAudioVariableValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public NamedScenarioInputRequest(global::Vellum.NamedScenarioInputAudioVariableValueRequest? value)
        {
            NamedScenarioInputAudioVariableValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedScenarioInputRequest(global::Vellum.NamedScenarioInputVideoVariableValueRequest value) => new NamedScenarioInputRequest((global::Vellum.NamedScenarioInputVideoVariableValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedScenarioInputVideoVariableValueRequest?(NamedScenarioInputRequest @this) => @this.NamedScenarioInputVideoVariableValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public NamedScenarioInputRequest(global::Vellum.NamedScenarioInputVideoVariableValueRequest? value)
        {
            NamedScenarioInputVideoVariableValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedScenarioInputRequest(global::Vellum.NamedScenarioInputImageVariableValueRequest value) => new NamedScenarioInputRequest((global::Vellum.NamedScenarioInputImageVariableValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedScenarioInputImageVariableValueRequest?(NamedScenarioInputRequest @this) => @this.NamedScenarioInputImageVariableValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public NamedScenarioInputRequest(global::Vellum.NamedScenarioInputImageVariableValueRequest? value)
        {
            NamedScenarioInputImageVariableValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NamedScenarioInputRequest(global::Vellum.NamedScenarioInputDocumentVariableValueRequest value) => new NamedScenarioInputRequest((global::Vellum.NamedScenarioInputDocumentVariableValueRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.NamedScenarioInputDocumentVariableValueRequest?(NamedScenarioInputRequest @this) => @this.NamedScenarioInputDocumentVariableValueRequest;

        /// <summary>
        /// 
        /// </summary>
        public NamedScenarioInputRequest(global::Vellum.NamedScenarioInputDocumentVariableValueRequest? value)
        {
            NamedScenarioInputDocumentVariableValueRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public NamedScenarioInputRequest(
            global::Vellum.NamedScenarioInputStringVariableValueRequest? namedScenarioInputStringVariableValueRequest,
            global::Vellum.NamedScenarioInputJsonVariableValueRequest? namedScenarioInputJsonVariableValueRequest,
            global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest? namedScenarioInputChatHistoryVariableValueRequest,
            global::Vellum.NamedScenarioInputAudioVariableValueRequest? namedScenarioInputAudioVariableValueRequest,
            global::Vellum.NamedScenarioInputVideoVariableValueRequest? namedScenarioInputVideoVariableValueRequest,
            global::Vellum.NamedScenarioInputImageVariableValueRequest? namedScenarioInputImageVariableValueRequest,
            global::Vellum.NamedScenarioInputDocumentVariableValueRequest? namedScenarioInputDocumentVariableValueRequest
            )
        {
            NamedScenarioInputStringVariableValueRequest = namedScenarioInputStringVariableValueRequest;
            NamedScenarioInputJsonVariableValueRequest = namedScenarioInputJsonVariableValueRequest;
            NamedScenarioInputChatHistoryVariableValueRequest = namedScenarioInputChatHistoryVariableValueRequest;
            NamedScenarioInputAudioVariableValueRequest = namedScenarioInputAudioVariableValueRequest;
            NamedScenarioInputVideoVariableValueRequest = namedScenarioInputVideoVariableValueRequest;
            NamedScenarioInputImageVariableValueRequest = namedScenarioInputImageVariableValueRequest;
            NamedScenarioInputDocumentVariableValueRequest = namedScenarioInputDocumentVariableValueRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            NamedScenarioInputDocumentVariableValueRequest as object ??
            NamedScenarioInputImageVariableValueRequest as object ??
            NamedScenarioInputVideoVariableValueRequest as object ??
            NamedScenarioInputAudioVariableValueRequest as object ??
            NamedScenarioInputChatHistoryVariableValueRequest as object ??
            NamedScenarioInputJsonVariableValueRequest as object ??
            NamedScenarioInputStringVariableValueRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            NamedScenarioInputStringVariableValueRequest?.ToString() ??
            NamedScenarioInputJsonVariableValueRequest?.ToString() ??
            NamedScenarioInputChatHistoryVariableValueRequest?.ToString() ??
            NamedScenarioInputAudioVariableValueRequest?.ToString() ??
            NamedScenarioInputVideoVariableValueRequest?.ToString() ??
            NamedScenarioInputImageVariableValueRequest?.ToString() ??
            NamedScenarioInputDocumentVariableValueRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNamedScenarioInputStringVariableValueRequest && !IsNamedScenarioInputJsonVariableValueRequest && !IsNamedScenarioInputChatHistoryVariableValueRequest && !IsNamedScenarioInputAudioVariableValueRequest && !IsNamedScenarioInputVideoVariableValueRequest && !IsNamedScenarioInputImageVariableValueRequest && !IsNamedScenarioInputDocumentVariableValueRequest || !IsNamedScenarioInputStringVariableValueRequest && IsNamedScenarioInputJsonVariableValueRequest && !IsNamedScenarioInputChatHistoryVariableValueRequest && !IsNamedScenarioInputAudioVariableValueRequest && !IsNamedScenarioInputVideoVariableValueRequest && !IsNamedScenarioInputImageVariableValueRequest && !IsNamedScenarioInputDocumentVariableValueRequest || !IsNamedScenarioInputStringVariableValueRequest && !IsNamedScenarioInputJsonVariableValueRequest && IsNamedScenarioInputChatHistoryVariableValueRequest && !IsNamedScenarioInputAudioVariableValueRequest && !IsNamedScenarioInputVideoVariableValueRequest && !IsNamedScenarioInputImageVariableValueRequest && !IsNamedScenarioInputDocumentVariableValueRequest || !IsNamedScenarioInputStringVariableValueRequest && !IsNamedScenarioInputJsonVariableValueRequest && !IsNamedScenarioInputChatHistoryVariableValueRequest && IsNamedScenarioInputAudioVariableValueRequest && !IsNamedScenarioInputVideoVariableValueRequest && !IsNamedScenarioInputImageVariableValueRequest && !IsNamedScenarioInputDocumentVariableValueRequest || !IsNamedScenarioInputStringVariableValueRequest && !IsNamedScenarioInputJsonVariableValueRequest && !IsNamedScenarioInputChatHistoryVariableValueRequest && !IsNamedScenarioInputAudioVariableValueRequest && IsNamedScenarioInputVideoVariableValueRequest && !IsNamedScenarioInputImageVariableValueRequest && !IsNamedScenarioInputDocumentVariableValueRequest || !IsNamedScenarioInputStringVariableValueRequest && !IsNamedScenarioInputJsonVariableValueRequest && !IsNamedScenarioInputChatHistoryVariableValueRequest && !IsNamedScenarioInputAudioVariableValueRequest && !IsNamedScenarioInputVideoVariableValueRequest && IsNamedScenarioInputImageVariableValueRequest && !IsNamedScenarioInputDocumentVariableValueRequest || !IsNamedScenarioInputStringVariableValueRequest && !IsNamedScenarioInputJsonVariableValueRequest && !IsNamedScenarioInputChatHistoryVariableValueRequest && !IsNamedScenarioInputAudioVariableValueRequest && !IsNamedScenarioInputVideoVariableValueRequest && !IsNamedScenarioInputImageVariableValueRequest && IsNamedScenarioInputDocumentVariableValueRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.NamedScenarioInputStringVariableValueRequest?, TResult>? namedScenarioInputStringVariableValueRequest = null,
            global::System.Func<global::Vellum.NamedScenarioInputJsonVariableValueRequest?, TResult>? namedScenarioInputJsonVariableValueRequest = null,
            global::System.Func<global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest?, TResult>? namedScenarioInputChatHistoryVariableValueRequest = null,
            global::System.Func<global::Vellum.NamedScenarioInputAudioVariableValueRequest?, TResult>? namedScenarioInputAudioVariableValueRequest = null,
            global::System.Func<global::Vellum.NamedScenarioInputVideoVariableValueRequest?, TResult>? namedScenarioInputVideoVariableValueRequest = null,
            global::System.Func<global::Vellum.NamedScenarioInputImageVariableValueRequest?, TResult>? namedScenarioInputImageVariableValueRequest = null,
            global::System.Func<global::Vellum.NamedScenarioInputDocumentVariableValueRequest?, TResult>? namedScenarioInputDocumentVariableValueRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNamedScenarioInputStringVariableValueRequest && namedScenarioInputStringVariableValueRequest != null)
            {
                return namedScenarioInputStringVariableValueRequest(NamedScenarioInputStringVariableValueRequest!);
            }
            else if (IsNamedScenarioInputJsonVariableValueRequest && namedScenarioInputJsonVariableValueRequest != null)
            {
                return namedScenarioInputJsonVariableValueRequest(NamedScenarioInputJsonVariableValueRequest!);
            }
            else if (IsNamedScenarioInputChatHistoryVariableValueRequest && namedScenarioInputChatHistoryVariableValueRequest != null)
            {
                return namedScenarioInputChatHistoryVariableValueRequest(NamedScenarioInputChatHistoryVariableValueRequest!);
            }
            else if (IsNamedScenarioInputAudioVariableValueRequest && namedScenarioInputAudioVariableValueRequest != null)
            {
                return namedScenarioInputAudioVariableValueRequest(NamedScenarioInputAudioVariableValueRequest!);
            }
            else if (IsNamedScenarioInputVideoVariableValueRequest && namedScenarioInputVideoVariableValueRequest != null)
            {
                return namedScenarioInputVideoVariableValueRequest(NamedScenarioInputVideoVariableValueRequest!);
            }
            else if (IsNamedScenarioInputImageVariableValueRequest && namedScenarioInputImageVariableValueRequest != null)
            {
                return namedScenarioInputImageVariableValueRequest(NamedScenarioInputImageVariableValueRequest!);
            }
            else if (IsNamedScenarioInputDocumentVariableValueRequest && namedScenarioInputDocumentVariableValueRequest != null)
            {
                return namedScenarioInputDocumentVariableValueRequest(NamedScenarioInputDocumentVariableValueRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.NamedScenarioInputStringVariableValueRequest?>? namedScenarioInputStringVariableValueRequest = null,
            global::System.Action<global::Vellum.NamedScenarioInputJsonVariableValueRequest?>? namedScenarioInputJsonVariableValueRequest = null,
            global::System.Action<global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest?>? namedScenarioInputChatHistoryVariableValueRequest = null,
            global::System.Action<global::Vellum.NamedScenarioInputAudioVariableValueRequest?>? namedScenarioInputAudioVariableValueRequest = null,
            global::System.Action<global::Vellum.NamedScenarioInputVideoVariableValueRequest?>? namedScenarioInputVideoVariableValueRequest = null,
            global::System.Action<global::Vellum.NamedScenarioInputImageVariableValueRequest?>? namedScenarioInputImageVariableValueRequest = null,
            global::System.Action<global::Vellum.NamedScenarioInputDocumentVariableValueRequest?>? namedScenarioInputDocumentVariableValueRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNamedScenarioInputStringVariableValueRequest)
            {
                namedScenarioInputStringVariableValueRequest?.Invoke(NamedScenarioInputStringVariableValueRequest!);
            }
            else if (IsNamedScenarioInputJsonVariableValueRequest)
            {
                namedScenarioInputJsonVariableValueRequest?.Invoke(NamedScenarioInputJsonVariableValueRequest!);
            }
            else if (IsNamedScenarioInputChatHistoryVariableValueRequest)
            {
                namedScenarioInputChatHistoryVariableValueRequest?.Invoke(NamedScenarioInputChatHistoryVariableValueRequest!);
            }
            else if (IsNamedScenarioInputAudioVariableValueRequest)
            {
                namedScenarioInputAudioVariableValueRequest?.Invoke(NamedScenarioInputAudioVariableValueRequest!);
            }
            else if (IsNamedScenarioInputVideoVariableValueRequest)
            {
                namedScenarioInputVideoVariableValueRequest?.Invoke(NamedScenarioInputVideoVariableValueRequest!);
            }
            else if (IsNamedScenarioInputImageVariableValueRequest)
            {
                namedScenarioInputImageVariableValueRequest?.Invoke(NamedScenarioInputImageVariableValueRequest!);
            }
            else if (IsNamedScenarioInputDocumentVariableValueRequest)
            {
                namedScenarioInputDocumentVariableValueRequest?.Invoke(NamedScenarioInputDocumentVariableValueRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                NamedScenarioInputStringVariableValueRequest,
                typeof(global::Vellum.NamedScenarioInputStringVariableValueRequest),
                NamedScenarioInputJsonVariableValueRequest,
                typeof(global::Vellum.NamedScenarioInputJsonVariableValueRequest),
                NamedScenarioInputChatHistoryVariableValueRequest,
                typeof(global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest),
                NamedScenarioInputAudioVariableValueRequest,
                typeof(global::Vellum.NamedScenarioInputAudioVariableValueRequest),
                NamedScenarioInputVideoVariableValueRequest,
                typeof(global::Vellum.NamedScenarioInputVideoVariableValueRequest),
                NamedScenarioInputImageVariableValueRequest,
                typeof(global::Vellum.NamedScenarioInputImageVariableValueRequest),
                NamedScenarioInputDocumentVariableValueRequest,
                typeof(global::Vellum.NamedScenarioInputDocumentVariableValueRequest),
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
        public bool Equals(NamedScenarioInputRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedScenarioInputStringVariableValueRequest?>.Default.Equals(NamedScenarioInputStringVariableValueRequest, other.NamedScenarioInputStringVariableValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedScenarioInputJsonVariableValueRequest?>.Default.Equals(NamedScenarioInputJsonVariableValueRequest, other.NamedScenarioInputJsonVariableValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedScenarioInputChatHistoryVariableValueRequest?>.Default.Equals(NamedScenarioInputChatHistoryVariableValueRequest, other.NamedScenarioInputChatHistoryVariableValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedScenarioInputAudioVariableValueRequest?>.Default.Equals(NamedScenarioInputAudioVariableValueRequest, other.NamedScenarioInputAudioVariableValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedScenarioInputVideoVariableValueRequest?>.Default.Equals(NamedScenarioInputVideoVariableValueRequest, other.NamedScenarioInputVideoVariableValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedScenarioInputImageVariableValueRequest?>.Default.Equals(NamedScenarioInputImageVariableValueRequest, other.NamedScenarioInputImageVariableValueRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.NamedScenarioInputDocumentVariableValueRequest?>.Default.Equals(NamedScenarioInputDocumentVariableValueRequest, other.NamedScenarioInputDocumentVariableValueRequest) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NamedScenarioInputRequest obj1, NamedScenarioInputRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NamedScenarioInputRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NamedScenarioInputRequest obj1, NamedScenarioInputRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NamedScenarioInputRequest o && Equals(o);
        }
    }
}
