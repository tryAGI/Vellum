#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SearchResultMetaSourceRequest : global::System.IEquatable<SearchResultMetaSourceRequest>
    {
        /// <summary>
        /// The source of a search result from a PDF document.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.PdfSearchResultMetaSourceRequest? PdfSearchResultMetaSourceRequest { get; init; }
#else
        public global::Vellum.PdfSearchResultMetaSourceRequest? PdfSearchResultMetaSourceRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PdfSearchResultMetaSourceRequest))]
#endif
        public bool IsPdfSearchResultMetaSourceRequest => PdfSearchResultMetaSourceRequest != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SearchResultMetaSourceRequest(global::Vellum.PdfSearchResultMetaSourceRequest value) => new SearchResultMetaSourceRequest((global::Vellum.PdfSearchResultMetaSourceRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.PdfSearchResultMetaSourceRequest?(SearchResultMetaSourceRequest @this) => @this.PdfSearchResultMetaSourceRequest;

        /// <summary>
        /// 
        /// </summary>
        public SearchResultMetaSourceRequest(global::Vellum.PdfSearchResultMetaSourceRequest? value)
        {
            PdfSearchResultMetaSourceRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PdfSearchResultMetaSourceRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PdfSearchResultMetaSourceRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPdfSearchResultMetaSourceRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.PdfSearchResultMetaSourceRequest?, TResult>? pdfSearchResultMetaSourceRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPdfSearchResultMetaSourceRequest && pdfSearchResultMetaSourceRequest != null)
            {
                return pdfSearchResultMetaSourceRequest(PdfSearchResultMetaSourceRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.PdfSearchResultMetaSourceRequest?>? pdfSearchResultMetaSourceRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPdfSearchResultMetaSourceRequest)
            {
                pdfSearchResultMetaSourceRequest?.Invoke(PdfSearchResultMetaSourceRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PdfSearchResultMetaSourceRequest,
                typeof(global::Vellum.PdfSearchResultMetaSourceRequest),
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
        public bool Equals(SearchResultMetaSourceRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.PdfSearchResultMetaSourceRequest?>.Default.Equals(PdfSearchResultMetaSourceRequest, other.PdfSearchResultMetaSourceRequest) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SearchResultMetaSourceRequest obj1, SearchResultMetaSourceRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SearchResultMetaSourceRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SearchResultMetaSourceRequest obj1, SearchResultMetaSourceRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SearchResultMetaSourceRequest o && Equals(o);
        }
    }
}
