#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PromptVersionBuildConfig : global::System.IEquatable<PromptVersionBuildConfig>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.PromptVersionBuildConfigSandbox? PromptVersionBuildConfigSandbox { get; init; }
#else
        public global::Vellum.PromptVersionBuildConfigSandbox? PromptVersionBuildConfigSandbox { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PromptVersionBuildConfigSandbox))]
#endif
        public bool IsPromptVersionBuildConfigSandbox => PromptVersionBuildConfigSandbox != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptVersionBuildConfig(global::Vellum.PromptVersionBuildConfigSandbox value) => new PromptVersionBuildConfig((global::Vellum.PromptVersionBuildConfigSandbox?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.PromptVersionBuildConfigSandbox?(PromptVersionBuildConfig @this) => @this.PromptVersionBuildConfigSandbox;

        /// <summary>
        /// 
        /// </summary>
        public PromptVersionBuildConfig(global::Vellum.PromptVersionBuildConfigSandbox? value)
        {
            PromptVersionBuildConfigSandbox = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PromptVersionBuildConfigSandbox as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PromptVersionBuildConfigSandbox?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPromptVersionBuildConfigSandbox;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.PromptVersionBuildConfigSandbox?, TResult>? promptVersionBuildConfigSandbox = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPromptVersionBuildConfigSandbox && promptVersionBuildConfigSandbox != null)
            {
                return promptVersionBuildConfigSandbox(PromptVersionBuildConfigSandbox!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.PromptVersionBuildConfigSandbox?>? promptVersionBuildConfigSandbox = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPromptVersionBuildConfigSandbox)
            {
                promptVersionBuildConfigSandbox?.Invoke(PromptVersionBuildConfigSandbox!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PromptVersionBuildConfigSandbox,
                typeof(global::Vellum.PromptVersionBuildConfigSandbox),
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
        public bool Equals(PromptVersionBuildConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.PromptVersionBuildConfigSandbox?>.Default.Equals(PromptVersionBuildConfigSandbox, other.PromptVersionBuildConfigSandbox) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PromptVersionBuildConfig obj1, PromptVersionBuildConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PromptVersionBuildConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PromptVersionBuildConfig obj1, PromptVersionBuildConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PromptVersionBuildConfig o && Equals(o);
        }
    }
}
