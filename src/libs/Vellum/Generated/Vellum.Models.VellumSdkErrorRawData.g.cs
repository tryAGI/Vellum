#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VellumSdkErrorRawData : global::System.IEquatable<VellumSdkErrorRawData>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? VellumSdkErrorRawDataVariant1 { get; init; }
#else
        public object? VellumSdkErrorRawDataVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VellumSdkErrorRawDataVariant1))]
#endif
        public bool IsVellumSdkErrorRawDataVariant1 => VellumSdkErrorRawDataVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? VellumSdkErrorRawDataVariant2 { get; init; }
#else
        public string? VellumSdkErrorRawDataVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VellumSdkErrorRawDataVariant2))]
#endif
        public bool IsVellumSdkErrorRawDataVariant2 => VellumSdkErrorRawDataVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumSdkErrorRawData(string value) => new VellumSdkErrorRawData((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(VellumSdkErrorRawData @this) => @this.VellumSdkErrorRawDataVariant2;

        /// <summary>
        /// 
        /// </summary>
        public VellumSdkErrorRawData(string? value)
        {
            VellumSdkErrorRawDataVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VellumSdkErrorRawData(
            object? vellumSdkErrorRawDataVariant1,
            string? vellumSdkErrorRawDataVariant2
            )
        {
            VellumSdkErrorRawDataVariant1 = vellumSdkErrorRawDataVariant1;
            VellumSdkErrorRawDataVariant2 = vellumSdkErrorRawDataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VellumSdkErrorRawDataVariant2 as object ??
            VellumSdkErrorRawDataVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VellumSdkErrorRawDataVariant1?.ToString() ??
            VellumSdkErrorRawDataVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVellumSdkErrorRawDataVariant1 && !IsVellumSdkErrorRawDataVariant2 || !IsVellumSdkErrorRawDataVariant1 && IsVellumSdkErrorRawDataVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<object?, TResult>? vellumSdkErrorRawDataVariant1 = null,
            global::System.Func<string?, TResult>? vellumSdkErrorRawDataVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVellumSdkErrorRawDataVariant1 && vellumSdkErrorRawDataVariant1 != null)
            {
                return vellumSdkErrorRawDataVariant1(VellumSdkErrorRawDataVariant1!);
            }
            else if (IsVellumSdkErrorRawDataVariant2 && vellumSdkErrorRawDataVariant2 != null)
            {
                return vellumSdkErrorRawDataVariant2(VellumSdkErrorRawDataVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<object?>? vellumSdkErrorRawDataVariant1 = null,
            global::System.Action<string?>? vellumSdkErrorRawDataVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVellumSdkErrorRawDataVariant1)
            {
                vellumSdkErrorRawDataVariant1?.Invoke(VellumSdkErrorRawDataVariant1!);
            }
            else if (IsVellumSdkErrorRawDataVariant2)
            {
                vellumSdkErrorRawDataVariant2?.Invoke(VellumSdkErrorRawDataVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VellumSdkErrorRawDataVariant1,
                typeof(object),
                VellumSdkErrorRawDataVariant2,
                typeof(string),
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
        public bool Equals(VellumSdkErrorRawData other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(VellumSdkErrorRawDataVariant1, other.VellumSdkErrorRawDataVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(VellumSdkErrorRawDataVariant2, other.VellumSdkErrorRawDataVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VellumSdkErrorRawData obj1, VellumSdkErrorRawData obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VellumSdkErrorRawData>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VellumSdkErrorRawData obj1, VellumSdkErrorRawData obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VellumSdkErrorRawData o && Equals(o);
        }
    }
}
