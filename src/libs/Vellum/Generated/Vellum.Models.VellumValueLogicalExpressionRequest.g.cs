#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VellumValueLogicalExpressionRequest : global::System.IEquatable<VellumValueLogicalExpressionRequest>
    {
        /// <summary>
        /// A basic condition comparing two Vellum values.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.VellumValueLogicalConditionRequest? VellumValueLogicalConditionRequest { get; init; }
#else
        public global::Vellum.VellumValueLogicalConditionRequest? VellumValueLogicalConditionRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VellumValueLogicalConditionRequest))]
#endif
        public bool IsVellumValueLogicalConditionRequest => VellumValueLogicalConditionRequest != null;

        /// <summary>
        /// A higher-order condition that combines one or more basic conditions or other higher-order conditions.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.VellumValueLogicalConditionGroupRequest? VellumValueLogicalConditionGroupRequest { get; init; }
#else
        public global::Vellum.VellumValueLogicalConditionGroupRequest? VellumValueLogicalConditionGroupRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VellumValueLogicalConditionGroupRequest))]
#endif
        public bool IsVellumValueLogicalConditionGroupRequest => VellumValueLogicalConditionGroupRequest != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValueLogicalExpressionRequest(global::Vellum.VellumValueLogicalConditionRequest value) => new VellumValueLogicalExpressionRequest((global::Vellum.VellumValueLogicalConditionRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.VellumValueLogicalConditionRequest?(VellumValueLogicalExpressionRequest @this) => @this.VellumValueLogicalConditionRequest;

        /// <summary>
        /// 
        /// </summary>
        public VellumValueLogicalExpressionRequest(global::Vellum.VellumValueLogicalConditionRequest? value)
        {
            VellumValueLogicalConditionRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VellumValueLogicalExpressionRequest(global::Vellum.VellumValueLogicalConditionGroupRequest value) => new VellumValueLogicalExpressionRequest((global::Vellum.VellumValueLogicalConditionGroupRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.VellumValueLogicalConditionGroupRequest?(VellumValueLogicalExpressionRequest @this) => @this.VellumValueLogicalConditionGroupRequest;

        /// <summary>
        /// 
        /// </summary>
        public VellumValueLogicalExpressionRequest(global::Vellum.VellumValueLogicalConditionGroupRequest? value)
        {
            VellumValueLogicalConditionGroupRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public VellumValueLogicalExpressionRequest(
            global::Vellum.VellumValueLogicalConditionRequest? vellumValueLogicalConditionRequest,
            global::Vellum.VellumValueLogicalConditionGroupRequest? vellumValueLogicalConditionGroupRequest
            )
        {
            VellumValueLogicalConditionRequest = vellumValueLogicalConditionRequest;
            VellumValueLogicalConditionGroupRequest = vellumValueLogicalConditionGroupRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VellumValueLogicalConditionGroupRequest as object ??
            VellumValueLogicalConditionRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VellumValueLogicalConditionRequest?.ToString() ??
            VellumValueLogicalConditionGroupRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVellumValueLogicalConditionRequest && !IsVellumValueLogicalConditionGroupRequest || !IsVellumValueLogicalConditionRequest && IsVellumValueLogicalConditionGroupRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.VellumValueLogicalConditionRequest?, TResult>? vellumValueLogicalConditionRequest = null,
            global::System.Func<global::Vellum.VellumValueLogicalConditionGroupRequest?, TResult>? vellumValueLogicalConditionGroupRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVellumValueLogicalConditionRequest && vellumValueLogicalConditionRequest != null)
            {
                return vellumValueLogicalConditionRequest(VellumValueLogicalConditionRequest!);
            }
            else if (IsVellumValueLogicalConditionGroupRequest && vellumValueLogicalConditionGroupRequest != null)
            {
                return vellumValueLogicalConditionGroupRequest(VellumValueLogicalConditionGroupRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.VellumValueLogicalConditionRequest?>? vellumValueLogicalConditionRequest = null,
            global::System.Action<global::Vellum.VellumValueLogicalConditionGroupRequest?>? vellumValueLogicalConditionGroupRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVellumValueLogicalConditionRequest)
            {
                vellumValueLogicalConditionRequest?.Invoke(VellumValueLogicalConditionRequest!);
            }
            else if (IsVellumValueLogicalConditionGroupRequest)
            {
                vellumValueLogicalConditionGroupRequest?.Invoke(VellumValueLogicalConditionGroupRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VellumValueLogicalConditionRequest,
                typeof(global::Vellum.VellumValueLogicalConditionRequest),
                VellumValueLogicalConditionGroupRequest,
                typeof(global::Vellum.VellumValueLogicalConditionGroupRequest),
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
        public bool Equals(VellumValueLogicalExpressionRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.VellumValueLogicalConditionRequest?>.Default.Equals(VellumValueLogicalConditionRequest, other.VellumValueLogicalConditionRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.VellumValueLogicalConditionGroupRequest?>.Default.Equals(VellumValueLogicalConditionGroupRequest, other.VellumValueLogicalConditionGroupRequest) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VellumValueLogicalExpressionRequest obj1, VellumValueLogicalExpressionRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VellumValueLogicalExpressionRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VellumValueLogicalExpressionRequest obj1, VellumValueLogicalExpressionRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VellumValueLogicalExpressionRequest o && Equals(o);
        }
    }
}
