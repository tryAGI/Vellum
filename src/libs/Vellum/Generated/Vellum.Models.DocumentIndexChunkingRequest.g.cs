#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DocumentIndexChunkingRequest : global::System.IEquatable<DocumentIndexChunkingRequest>
    {
        /// <summary>
        /// Reducto chunking
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ReductoChunkingRequest? ReductoChunkingRequest { get; init; }
#else
        public global::Vellum.ReductoChunkingRequest? ReductoChunkingRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReductoChunkingRequest))]
#endif
        public bool IsReductoChunkingRequest => ReductoChunkingRequest != null;

        /// <summary>
        /// Sentence chunking
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.SentenceChunkingRequest? SentenceChunkingRequest { get; init; }
#else
        public global::Vellum.SentenceChunkingRequest? SentenceChunkingRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SentenceChunkingRequest))]
#endif
        public bool IsSentenceChunkingRequest => SentenceChunkingRequest != null;

        /// <summary>
        /// Token overlapping window chunking
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TokenOverlappingWindowChunkingRequest? TokenOverlappingWindowChunkingRequest { get; init; }
#else
        public global::Vellum.TokenOverlappingWindowChunkingRequest? TokenOverlappingWindowChunkingRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TokenOverlappingWindowChunkingRequest))]
#endif
        public bool IsTokenOverlappingWindowChunkingRequest => TokenOverlappingWindowChunkingRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.DelimiterChunkingRequest? DelimiterChunkingRequest { get; init; }
#else
        public global::Vellum.DelimiterChunkingRequest? DelimiterChunkingRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DelimiterChunkingRequest))]
#endif
        public bool IsDelimiterChunkingRequest => DelimiterChunkingRequest != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DocumentIndexChunkingRequest(global::Vellum.ReductoChunkingRequest value) => new DocumentIndexChunkingRequest((global::Vellum.ReductoChunkingRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ReductoChunkingRequest?(DocumentIndexChunkingRequest @this) => @this.ReductoChunkingRequest;

        /// <summary>
        /// 
        /// </summary>
        public DocumentIndexChunkingRequest(global::Vellum.ReductoChunkingRequest? value)
        {
            ReductoChunkingRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DocumentIndexChunkingRequest(global::Vellum.SentenceChunkingRequest value) => new DocumentIndexChunkingRequest((global::Vellum.SentenceChunkingRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.SentenceChunkingRequest?(DocumentIndexChunkingRequest @this) => @this.SentenceChunkingRequest;

        /// <summary>
        /// 
        /// </summary>
        public DocumentIndexChunkingRequest(global::Vellum.SentenceChunkingRequest? value)
        {
            SentenceChunkingRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DocumentIndexChunkingRequest(global::Vellum.TokenOverlappingWindowChunkingRequest value) => new DocumentIndexChunkingRequest((global::Vellum.TokenOverlappingWindowChunkingRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TokenOverlappingWindowChunkingRequest?(DocumentIndexChunkingRequest @this) => @this.TokenOverlappingWindowChunkingRequest;

        /// <summary>
        /// 
        /// </summary>
        public DocumentIndexChunkingRequest(global::Vellum.TokenOverlappingWindowChunkingRequest? value)
        {
            TokenOverlappingWindowChunkingRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DocumentIndexChunkingRequest(global::Vellum.DelimiterChunkingRequest value) => new DocumentIndexChunkingRequest((global::Vellum.DelimiterChunkingRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.DelimiterChunkingRequest?(DocumentIndexChunkingRequest @this) => @this.DelimiterChunkingRequest;

        /// <summary>
        /// 
        /// </summary>
        public DocumentIndexChunkingRequest(global::Vellum.DelimiterChunkingRequest? value)
        {
            DelimiterChunkingRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DocumentIndexChunkingRequest(
            global::Vellum.ReductoChunkingRequest? reductoChunkingRequest,
            global::Vellum.SentenceChunkingRequest? sentenceChunkingRequest,
            global::Vellum.TokenOverlappingWindowChunkingRequest? tokenOverlappingWindowChunkingRequest,
            global::Vellum.DelimiterChunkingRequest? delimiterChunkingRequest
            )
        {
            ReductoChunkingRequest = reductoChunkingRequest;
            SentenceChunkingRequest = sentenceChunkingRequest;
            TokenOverlappingWindowChunkingRequest = tokenOverlappingWindowChunkingRequest;
            DelimiterChunkingRequest = delimiterChunkingRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DelimiterChunkingRequest as object ??
            TokenOverlappingWindowChunkingRequest as object ??
            SentenceChunkingRequest as object ??
            ReductoChunkingRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ReductoChunkingRequest?.ToString() ??
            SentenceChunkingRequest?.ToString() ??
            TokenOverlappingWindowChunkingRequest?.ToString() ??
            DelimiterChunkingRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsReductoChunkingRequest && !IsSentenceChunkingRequest && !IsTokenOverlappingWindowChunkingRequest && !IsDelimiterChunkingRequest || !IsReductoChunkingRequest && IsSentenceChunkingRequest && !IsTokenOverlappingWindowChunkingRequest && !IsDelimiterChunkingRequest || !IsReductoChunkingRequest && !IsSentenceChunkingRequest && IsTokenOverlappingWindowChunkingRequest && !IsDelimiterChunkingRequest || !IsReductoChunkingRequest && !IsSentenceChunkingRequest && !IsTokenOverlappingWindowChunkingRequest && IsDelimiterChunkingRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.ReductoChunkingRequest?, TResult>? reductoChunkingRequest = null,
            global::System.Func<global::Vellum.SentenceChunkingRequest?, TResult>? sentenceChunkingRequest = null,
            global::System.Func<global::Vellum.TokenOverlappingWindowChunkingRequest?, TResult>? tokenOverlappingWindowChunkingRequest = null,
            global::System.Func<global::Vellum.DelimiterChunkingRequest?, TResult>? delimiterChunkingRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReductoChunkingRequest && reductoChunkingRequest != null)
            {
                return reductoChunkingRequest(ReductoChunkingRequest!);
            }
            else if (IsSentenceChunkingRequest && sentenceChunkingRequest != null)
            {
                return sentenceChunkingRequest(SentenceChunkingRequest!);
            }
            else if (IsTokenOverlappingWindowChunkingRequest && tokenOverlappingWindowChunkingRequest != null)
            {
                return tokenOverlappingWindowChunkingRequest(TokenOverlappingWindowChunkingRequest!);
            }
            else if (IsDelimiterChunkingRequest && delimiterChunkingRequest != null)
            {
                return delimiterChunkingRequest(DelimiterChunkingRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.ReductoChunkingRequest?>? reductoChunkingRequest = null,
            global::System.Action<global::Vellum.SentenceChunkingRequest?>? sentenceChunkingRequest = null,
            global::System.Action<global::Vellum.TokenOverlappingWindowChunkingRequest?>? tokenOverlappingWindowChunkingRequest = null,
            global::System.Action<global::Vellum.DelimiterChunkingRequest?>? delimiterChunkingRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReductoChunkingRequest)
            {
                reductoChunkingRequest?.Invoke(ReductoChunkingRequest!);
            }
            else if (IsSentenceChunkingRequest)
            {
                sentenceChunkingRequest?.Invoke(SentenceChunkingRequest!);
            }
            else if (IsTokenOverlappingWindowChunkingRequest)
            {
                tokenOverlappingWindowChunkingRequest?.Invoke(TokenOverlappingWindowChunkingRequest!);
            }
            else if (IsDelimiterChunkingRequest)
            {
                delimiterChunkingRequest?.Invoke(DelimiterChunkingRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ReductoChunkingRequest,
                typeof(global::Vellum.ReductoChunkingRequest),
                SentenceChunkingRequest,
                typeof(global::Vellum.SentenceChunkingRequest),
                TokenOverlappingWindowChunkingRequest,
                typeof(global::Vellum.TokenOverlappingWindowChunkingRequest),
                DelimiterChunkingRequest,
                typeof(global::Vellum.DelimiterChunkingRequest),
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
        public bool Equals(DocumentIndexChunkingRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ReductoChunkingRequest?>.Default.Equals(ReductoChunkingRequest, other.ReductoChunkingRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.SentenceChunkingRequest?>.Default.Equals(SentenceChunkingRequest, other.SentenceChunkingRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TokenOverlappingWindowChunkingRequest?>.Default.Equals(TokenOverlappingWindowChunkingRequest, other.TokenOverlappingWindowChunkingRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.DelimiterChunkingRequest?>.Default.Equals(DelimiterChunkingRequest, other.DelimiterChunkingRequest) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DocumentIndexChunkingRequest obj1, DocumentIndexChunkingRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DocumentIndexChunkingRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DocumentIndexChunkingRequest obj1, DocumentIndexChunkingRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DocumentIndexChunkingRequest o && Equals(o);
        }
    }
}
