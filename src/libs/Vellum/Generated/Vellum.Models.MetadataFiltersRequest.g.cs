#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MetadataFiltersRequest : global::System.IEquatable<MetadataFiltersRequest>
    {
        /// <summary>
        /// A deprecated pattern for filtering on metadata. Please use MetadataFilters instead.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.MetadataFilterConfigRequest? MetadataFilterConfigRequest { get; init; }
#else
        public global::Vellum.MetadataFilterConfigRequest? MetadataFilterConfigRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MetadataFilterConfigRequest))]
#endif
        public bool IsMetadataFilterConfigRequest => MetadataFilterConfigRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.VellumValueLogicalExpressionRequest? VellumValueLogicalExpressionRequest { get; init; }
#else
        public global::Vellum.VellumValueLogicalExpressionRequest? VellumValueLogicalExpressionRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VellumValueLogicalExpressionRequest))]
#endif
        public bool IsVellumValueLogicalExpressionRequest => VellumValueLogicalExpressionRequest != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetadataFiltersRequest(global::Vellum.MetadataFilterConfigRequest value) => new MetadataFiltersRequest((global::Vellum.MetadataFilterConfigRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.MetadataFilterConfigRequest?(MetadataFiltersRequest @this) => @this.MetadataFilterConfigRequest;

        /// <summary>
        /// 
        /// </summary>
        public MetadataFiltersRequest(global::Vellum.MetadataFilterConfigRequest? value)
        {
            MetadataFilterConfigRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MetadataFiltersRequest(global::Vellum.VellumValueLogicalExpressionRequest value) => new MetadataFiltersRequest((global::Vellum.VellumValueLogicalExpressionRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.VellumValueLogicalExpressionRequest?(MetadataFiltersRequest @this) => @this.VellumValueLogicalExpressionRequest;

        /// <summary>
        /// 
        /// </summary>
        public MetadataFiltersRequest(global::Vellum.VellumValueLogicalExpressionRequest? value)
        {
            VellumValueLogicalExpressionRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MetadataFiltersRequest(
            global::Vellum.MetadataFilterConfigRequest? metadataFilterConfigRequest,
            global::Vellum.VellumValueLogicalExpressionRequest? vellumValueLogicalExpressionRequest
            )
        {
            MetadataFilterConfigRequest = metadataFilterConfigRequest;
            VellumValueLogicalExpressionRequest = vellumValueLogicalExpressionRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VellumValueLogicalExpressionRequest as object ??
            MetadataFilterConfigRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MetadataFilterConfigRequest?.ToString() ??
            VellumValueLogicalExpressionRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMetadataFilterConfigRequest && !IsVellumValueLogicalExpressionRequest || !IsMetadataFilterConfigRequest && IsVellumValueLogicalExpressionRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.MetadataFilterConfigRequest?, TResult>? metadataFilterConfigRequest = null,
            global::System.Func<global::Vellum.VellumValueLogicalExpressionRequest?, TResult>? vellumValueLogicalExpressionRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMetadataFilterConfigRequest && metadataFilterConfigRequest != null)
            {
                return metadataFilterConfigRequest(MetadataFilterConfigRequest!);
            }
            else if (IsVellumValueLogicalExpressionRequest && vellumValueLogicalExpressionRequest != null)
            {
                return vellumValueLogicalExpressionRequest(VellumValueLogicalExpressionRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.MetadataFilterConfigRequest?>? metadataFilterConfigRequest = null,
            global::System.Action<global::Vellum.VellumValueLogicalExpressionRequest?>? vellumValueLogicalExpressionRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMetadataFilterConfigRequest)
            {
                metadataFilterConfigRequest?.Invoke(MetadataFilterConfigRequest!);
            }
            else if (IsVellumValueLogicalExpressionRequest)
            {
                vellumValueLogicalExpressionRequest?.Invoke(VellumValueLogicalExpressionRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MetadataFilterConfigRequest,
                typeof(global::Vellum.MetadataFilterConfigRequest),
                VellumValueLogicalExpressionRequest,
                typeof(global::Vellum.VellumValueLogicalExpressionRequest),
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
        public bool Equals(MetadataFiltersRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.MetadataFilterConfigRequest?>.Default.Equals(MetadataFilterConfigRequest, other.MetadataFilterConfigRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.VellumValueLogicalExpressionRequest?>.Default.Equals(VellumValueLogicalExpressionRequest, other.VellumValueLogicalExpressionRequest) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MetadataFiltersRequest obj1, MetadataFiltersRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MetadataFiltersRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MetadataFiltersRequest obj1, MetadataFiltersRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MetadataFiltersRequest o && Equals(o);
        }
    }
}
