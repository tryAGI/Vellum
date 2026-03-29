#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SearchResultMetaSource : global::System.IEquatable<SearchResultMetaSource>
    {
        /// <summary>
        /// The source of a search result from a PDF document.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.PdfSearchResultMetaSource? PdfSearchResultMetaSource { get; init; }
#else
        public global::Vellum.PdfSearchResultMetaSource? PdfSearchResultMetaSource { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PdfSearchResultMetaSource))]
#endif
        public bool IsPdfSearchResultMetaSource => PdfSearchResultMetaSource != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchResultMetaSource(global::Vellum.PdfSearchResultMetaSource value) => new SearchResultMetaSource((global::Vellum.PdfSearchResultMetaSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.PdfSearchResultMetaSource?(SearchResultMetaSource @this) => @this.PdfSearchResultMetaSource;

        /// <summary>
        /// 
        /// </summary>
        public SearchResultMetaSource(global::Vellum.PdfSearchResultMetaSource? value)
        {
            PdfSearchResultMetaSource = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PdfSearchResultMetaSource as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PdfSearchResultMetaSource?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPdfSearchResultMetaSource;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.PdfSearchResultMetaSource?, TResult>? pdfSearchResultMetaSource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPdfSearchResultMetaSource && pdfSearchResultMetaSource != null)
            {
                return pdfSearchResultMetaSource(PdfSearchResultMetaSource!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.PdfSearchResultMetaSource?>? pdfSearchResultMetaSource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPdfSearchResultMetaSource)
            {
                pdfSearchResultMetaSource?.Invoke(PdfSearchResultMetaSource!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PdfSearchResultMetaSource,
                typeof(global::Vellum.PdfSearchResultMetaSource),
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
        public bool Equals(SearchResultMetaSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.PdfSearchResultMetaSource?>.Default.Equals(PdfSearchResultMetaSource, other.PdfSearchResultMetaSource) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchResultMetaSource obj1, SearchResultMetaSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchResultMetaSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchResultMetaSource obj1, SearchResultMetaSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchResultMetaSource o && Equals(o);
        }
    }
}
