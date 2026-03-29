#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DocumentIndexChunking : global::System.IEquatable<DocumentIndexChunking>
    {
        /// <summary>
        /// Reducto chunking
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ReductoChunking? ReductoChunking { get; init; }
#else
        public global::Vellum.ReductoChunking? ReductoChunking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReductoChunking))]
#endif
        public bool IsReductoChunking => ReductoChunking != null;

        /// <summary>
        /// Sentence chunking
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.SentenceChunking? SentenceChunking { get; init; }
#else
        public global::Vellum.SentenceChunking? SentenceChunking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SentenceChunking))]
#endif
        public bool IsSentenceChunking => SentenceChunking != null;

        /// <summary>
        /// Token overlapping window chunking
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TokenOverlappingWindowChunking? TokenOverlappingWindowChunking { get; init; }
#else
        public global::Vellum.TokenOverlappingWindowChunking? TokenOverlappingWindowChunking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TokenOverlappingWindowChunking))]
#endif
        public bool IsTokenOverlappingWindowChunking => TokenOverlappingWindowChunking != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.DelimiterChunking? DelimiterChunking { get; init; }
#else
        public global::Vellum.DelimiterChunking? DelimiterChunking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DelimiterChunking))]
#endif
        public bool IsDelimiterChunking => DelimiterChunking != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DocumentIndexChunking(global::Vellum.ReductoChunking value) => new DocumentIndexChunking((global::Vellum.ReductoChunking?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.ReductoChunking?(DocumentIndexChunking @this) => @this.ReductoChunking;

        /// <summary>
        /// 
        /// </summary>
        public DocumentIndexChunking(global::Vellum.ReductoChunking? value)
        {
            ReductoChunking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DocumentIndexChunking(global::Vellum.SentenceChunking value) => new DocumentIndexChunking((global::Vellum.SentenceChunking?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.SentenceChunking?(DocumentIndexChunking @this) => @this.SentenceChunking;

        /// <summary>
        /// 
        /// </summary>
        public DocumentIndexChunking(global::Vellum.SentenceChunking? value)
        {
            SentenceChunking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DocumentIndexChunking(global::Vellum.TokenOverlappingWindowChunking value) => new DocumentIndexChunking((global::Vellum.TokenOverlappingWindowChunking?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TokenOverlappingWindowChunking?(DocumentIndexChunking @this) => @this.TokenOverlappingWindowChunking;

        /// <summary>
        /// 
        /// </summary>
        public DocumentIndexChunking(global::Vellum.TokenOverlappingWindowChunking? value)
        {
            TokenOverlappingWindowChunking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DocumentIndexChunking(global::Vellum.DelimiterChunking value) => new DocumentIndexChunking((global::Vellum.DelimiterChunking?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.DelimiterChunking?(DocumentIndexChunking @this) => @this.DelimiterChunking;

        /// <summary>
        /// 
        /// </summary>
        public DocumentIndexChunking(global::Vellum.DelimiterChunking? value)
        {
            DelimiterChunking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DocumentIndexChunking(
            global::Vellum.ReductoChunking? reductoChunking,
            global::Vellum.SentenceChunking? sentenceChunking,
            global::Vellum.TokenOverlappingWindowChunking? tokenOverlappingWindowChunking,
            global::Vellum.DelimiterChunking? delimiterChunking
            )
        {
            ReductoChunking = reductoChunking;
            SentenceChunking = sentenceChunking;
            TokenOverlappingWindowChunking = tokenOverlappingWindowChunking;
            DelimiterChunking = delimiterChunking;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DelimiterChunking as object ??
            TokenOverlappingWindowChunking as object ??
            SentenceChunking as object ??
            ReductoChunking as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ReductoChunking?.ToString() ??
            SentenceChunking?.ToString() ??
            TokenOverlappingWindowChunking?.ToString() ??
            DelimiterChunking?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsReductoChunking && !IsSentenceChunking && !IsTokenOverlappingWindowChunking && !IsDelimiterChunking || !IsReductoChunking && IsSentenceChunking && !IsTokenOverlappingWindowChunking && !IsDelimiterChunking || !IsReductoChunking && !IsSentenceChunking && IsTokenOverlappingWindowChunking && !IsDelimiterChunking || !IsReductoChunking && !IsSentenceChunking && !IsTokenOverlappingWindowChunking && IsDelimiterChunking;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.ReductoChunking?, TResult>? reductoChunking = null,
            global::System.Func<global::Vellum.SentenceChunking?, TResult>? sentenceChunking = null,
            global::System.Func<global::Vellum.TokenOverlappingWindowChunking?, TResult>? tokenOverlappingWindowChunking = null,
            global::System.Func<global::Vellum.DelimiterChunking?, TResult>? delimiterChunking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReductoChunking && reductoChunking != null)
            {
                return reductoChunking(ReductoChunking!);
            }
            else if (IsSentenceChunking && sentenceChunking != null)
            {
                return sentenceChunking(SentenceChunking!);
            }
            else if (IsTokenOverlappingWindowChunking && tokenOverlappingWindowChunking != null)
            {
                return tokenOverlappingWindowChunking(TokenOverlappingWindowChunking!);
            }
            else if (IsDelimiterChunking && delimiterChunking != null)
            {
                return delimiterChunking(DelimiterChunking!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.ReductoChunking?>? reductoChunking = null,
            global::System.Action<global::Vellum.SentenceChunking?>? sentenceChunking = null,
            global::System.Action<global::Vellum.TokenOverlappingWindowChunking?>? tokenOverlappingWindowChunking = null,
            global::System.Action<global::Vellum.DelimiterChunking?>? delimiterChunking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReductoChunking)
            {
                reductoChunking?.Invoke(ReductoChunking!);
            }
            else if (IsSentenceChunking)
            {
                sentenceChunking?.Invoke(SentenceChunking!);
            }
            else if (IsTokenOverlappingWindowChunking)
            {
                tokenOverlappingWindowChunking?.Invoke(TokenOverlappingWindowChunking!);
            }
            else if (IsDelimiterChunking)
            {
                delimiterChunking?.Invoke(DelimiterChunking!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ReductoChunking,
                typeof(global::Vellum.ReductoChunking),
                SentenceChunking,
                typeof(global::Vellum.SentenceChunking),
                TokenOverlappingWindowChunking,
                typeof(global::Vellum.TokenOverlappingWindowChunking),
                DelimiterChunking,
                typeof(global::Vellum.DelimiterChunking),
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
        public bool Equals(DocumentIndexChunking other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ReductoChunking?>.Default.Equals(ReductoChunking, other.ReductoChunking) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.SentenceChunking?>.Default.Equals(SentenceChunking, other.SentenceChunking) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TokenOverlappingWindowChunking?>.Default.Equals(TokenOverlappingWindowChunking, other.TokenOverlappingWindowChunking) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.DelimiterChunking?>.Default.Equals(DelimiterChunking, other.DelimiterChunking) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DocumentIndexChunking obj1, DocumentIndexChunking obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DocumentIndexChunking>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DocumentIndexChunking obj1, DocumentIndexChunking obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DocumentIndexChunking o && Equals(o);
        }
    }
}
