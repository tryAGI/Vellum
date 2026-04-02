#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DeploymentProviderPayloadResponsePayload : global::System.IEquatable<DeploymentProviderPayloadResponsePayload>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? DeploymentProviderPayloadResponsePayloadVariant1 { get; init; }
#else
        public object? DeploymentProviderPayloadResponsePayloadVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeploymentProviderPayloadResponsePayloadVariant1))]
#endif
        public bool IsDeploymentProviderPayloadResponsePayloadVariant1 => DeploymentProviderPayloadResponsePayloadVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? DeploymentProviderPayloadResponsePayloadVariant2 { get; init; }
#else
        public string? DeploymentProviderPayloadResponsePayloadVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeploymentProviderPayloadResponsePayloadVariant2))]
#endif
        public bool IsDeploymentProviderPayloadResponsePayloadVariant2 => DeploymentProviderPayloadResponsePayloadVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DeploymentProviderPayloadResponsePayload(string value) => new DeploymentProviderPayloadResponsePayload((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(DeploymentProviderPayloadResponsePayload @this) => @this.DeploymentProviderPayloadResponsePayloadVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DeploymentProviderPayloadResponsePayload(string? value)
        {
            DeploymentProviderPayloadResponsePayloadVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DeploymentProviderPayloadResponsePayload(
            object? deploymentProviderPayloadResponsePayloadVariant1,
            string? deploymentProviderPayloadResponsePayloadVariant2
            )
        {
            DeploymentProviderPayloadResponsePayloadVariant1 = deploymentProviderPayloadResponsePayloadVariant1;
            DeploymentProviderPayloadResponsePayloadVariant2 = deploymentProviderPayloadResponsePayloadVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DeploymentProviderPayloadResponsePayloadVariant2 as object ??
            DeploymentProviderPayloadResponsePayloadVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            DeploymentProviderPayloadResponsePayloadVariant1?.ToString() ??
            DeploymentProviderPayloadResponsePayloadVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDeploymentProviderPayloadResponsePayloadVariant1 && !IsDeploymentProviderPayloadResponsePayloadVariant2 || !IsDeploymentProviderPayloadResponsePayloadVariant1 && IsDeploymentProviderPayloadResponsePayloadVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<object?, TResult>? deploymentProviderPayloadResponsePayloadVariant1 = null,
            global::System.Func<string?, TResult>? deploymentProviderPayloadResponsePayloadVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeploymentProviderPayloadResponsePayloadVariant1 && deploymentProviderPayloadResponsePayloadVariant1 != null)
            {
                return deploymentProviderPayloadResponsePayloadVariant1(DeploymentProviderPayloadResponsePayloadVariant1!);
            }
            else if (IsDeploymentProviderPayloadResponsePayloadVariant2 && deploymentProviderPayloadResponsePayloadVariant2 != null)
            {
                return deploymentProviderPayloadResponsePayloadVariant2(DeploymentProviderPayloadResponsePayloadVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<object?>? deploymentProviderPayloadResponsePayloadVariant1 = null,
            global::System.Action<string?>? deploymentProviderPayloadResponsePayloadVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDeploymentProviderPayloadResponsePayloadVariant1)
            {
                deploymentProviderPayloadResponsePayloadVariant1?.Invoke(DeploymentProviderPayloadResponsePayloadVariant1!);
            }
            else if (IsDeploymentProviderPayloadResponsePayloadVariant2)
            {
                deploymentProviderPayloadResponsePayloadVariant2?.Invoke(DeploymentProviderPayloadResponsePayloadVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DeploymentProviderPayloadResponsePayloadVariant1,
                typeof(object),
                DeploymentProviderPayloadResponsePayloadVariant2,
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
        public bool Equals(DeploymentProviderPayloadResponsePayload other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(DeploymentProviderPayloadResponsePayloadVariant1, other.DeploymentProviderPayloadResponsePayloadVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(DeploymentProviderPayloadResponsePayloadVariant2, other.DeploymentProviderPayloadResponsePayloadVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DeploymentProviderPayloadResponsePayload obj1, DeploymentProviderPayloadResponsePayload obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DeploymentProviderPayloadResponsePayload>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DeploymentProviderPayloadResponsePayload obj1, DeploymentProviderPayloadResponsePayload obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DeploymentProviderPayloadResponsePayload o && Equals(o);
        }
    }
}
