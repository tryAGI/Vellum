#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TestSuiteRunExecConfig : global::System.IEquatable<TestSuiteRunExecConfig>
    {
        /// <summary>
        /// Execution configuration for running a Test Suite against a Prompt Deployment
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig? TestSuiteRunDeploymentReleaseTagExecConfig { get; init; }
#else
        public global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig? TestSuiteRunDeploymentReleaseTagExecConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunDeploymentReleaseTagExecConfig))]
#endif
        public bool IsTestSuiteRunDeploymentReleaseTagExecConfig => TestSuiteRunDeploymentReleaseTagExecConfig != null;

        /// <summary>
        /// Execution configuration for running a Test Suite against a Prompt Sandbox History Item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig? TestSuiteRunPromptSandboxHistoryItemExecConfig { get; init; }
#else
        public global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig? TestSuiteRunPromptSandboxHistoryItemExecConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunPromptSandboxHistoryItemExecConfig))]
#endif
        public bool IsTestSuiteRunPromptSandboxHistoryItemExecConfig => TestSuiteRunPromptSandboxHistoryItemExecConfig != null;

        /// <summary>
        /// Execution configuration for running a Test Suite against a Workflow Deployment
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig? TestSuiteRunWorkflowReleaseTagExecConfig { get; init; }
#else
        public global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig? TestSuiteRunWorkflowReleaseTagExecConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunWorkflowReleaseTagExecConfig))]
#endif
        public bool IsTestSuiteRunWorkflowReleaseTagExecConfig => TestSuiteRunWorkflowReleaseTagExecConfig != null;

        /// <summary>
        /// Execution configuration for running a Test Suite against a Workflow Sandbox History Item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig? TestSuiteRunWorkflowSandboxHistoryItemExecConfig { get; init; }
#else
        public global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig? TestSuiteRunWorkflowSandboxHistoryItemExecConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunWorkflowSandboxHistoryItemExecConfig))]
#endif
        public bool IsTestSuiteRunWorkflowSandboxHistoryItemExecConfig => TestSuiteRunWorkflowSandboxHistoryItemExecConfig != null;

        /// <summary>
        /// Execution configuration for running a Vellum Test Suite against an external callable
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunExternalExecConfig? TestSuiteRunExternalExecConfig { get; init; }
#else
        public global::Vellum.TestSuiteRunExternalExecConfig? TestSuiteRunExternalExecConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunExternalExecConfig))]
#endif
        public bool IsTestSuiteRunExternalExecConfig => TestSuiteRunExternalExecConfig != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunExecConfig(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig value) => new TestSuiteRunExecConfig((global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig?(TestSuiteRunExecConfig @this) => @this.TestSuiteRunDeploymentReleaseTagExecConfig;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecConfig(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig? value)
        {
            TestSuiteRunDeploymentReleaseTagExecConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunExecConfig(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig value) => new TestSuiteRunExecConfig((global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig?(TestSuiteRunExecConfig @this) => @this.TestSuiteRunPromptSandboxHistoryItemExecConfig;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecConfig(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig? value)
        {
            TestSuiteRunPromptSandboxHistoryItemExecConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunExecConfig(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig value) => new TestSuiteRunExecConfig((global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig?(TestSuiteRunExecConfig @this) => @this.TestSuiteRunWorkflowReleaseTagExecConfig;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecConfig(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig? value)
        {
            TestSuiteRunWorkflowReleaseTagExecConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunExecConfig(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig value) => new TestSuiteRunExecConfig((global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig?(TestSuiteRunExecConfig @this) => @this.TestSuiteRunWorkflowSandboxHistoryItemExecConfig;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecConfig(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig? value)
        {
            TestSuiteRunWorkflowSandboxHistoryItemExecConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunExecConfig(global::Vellum.TestSuiteRunExternalExecConfig value) => new TestSuiteRunExecConfig((global::Vellum.TestSuiteRunExternalExecConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunExternalExecConfig?(TestSuiteRunExecConfig @this) => @this.TestSuiteRunExternalExecConfig;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecConfig(global::Vellum.TestSuiteRunExternalExecConfig? value)
        {
            TestSuiteRunExternalExecConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecConfig(
            global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig? testSuiteRunDeploymentReleaseTagExecConfig,
            global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig? testSuiteRunPromptSandboxHistoryItemExecConfig,
            global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig? testSuiteRunWorkflowReleaseTagExecConfig,
            global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig? testSuiteRunWorkflowSandboxHistoryItemExecConfig,
            global::Vellum.TestSuiteRunExternalExecConfig? testSuiteRunExternalExecConfig
            )
        {
            TestSuiteRunDeploymentReleaseTagExecConfig = testSuiteRunDeploymentReleaseTagExecConfig;
            TestSuiteRunPromptSandboxHistoryItemExecConfig = testSuiteRunPromptSandboxHistoryItemExecConfig;
            TestSuiteRunWorkflowReleaseTagExecConfig = testSuiteRunWorkflowReleaseTagExecConfig;
            TestSuiteRunWorkflowSandboxHistoryItemExecConfig = testSuiteRunWorkflowSandboxHistoryItemExecConfig;
            TestSuiteRunExternalExecConfig = testSuiteRunExternalExecConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TestSuiteRunExternalExecConfig as object ??
            TestSuiteRunWorkflowSandboxHistoryItemExecConfig as object ??
            TestSuiteRunWorkflowReleaseTagExecConfig as object ??
            TestSuiteRunPromptSandboxHistoryItemExecConfig as object ??
            TestSuiteRunDeploymentReleaseTagExecConfig as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TestSuiteRunDeploymentReleaseTagExecConfig?.ToString() ??
            TestSuiteRunPromptSandboxHistoryItemExecConfig?.ToString() ??
            TestSuiteRunWorkflowReleaseTagExecConfig?.ToString() ??
            TestSuiteRunWorkflowSandboxHistoryItemExecConfig?.ToString() ??
            TestSuiteRunExternalExecConfig?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTestSuiteRunDeploymentReleaseTagExecConfig && !IsTestSuiteRunPromptSandboxHistoryItemExecConfig && !IsTestSuiteRunWorkflowReleaseTagExecConfig && !IsTestSuiteRunWorkflowSandboxHistoryItemExecConfig && !IsTestSuiteRunExternalExecConfig || !IsTestSuiteRunDeploymentReleaseTagExecConfig && IsTestSuiteRunPromptSandboxHistoryItemExecConfig && !IsTestSuiteRunWorkflowReleaseTagExecConfig && !IsTestSuiteRunWorkflowSandboxHistoryItemExecConfig && !IsTestSuiteRunExternalExecConfig || !IsTestSuiteRunDeploymentReleaseTagExecConfig && !IsTestSuiteRunPromptSandboxHistoryItemExecConfig && IsTestSuiteRunWorkflowReleaseTagExecConfig && !IsTestSuiteRunWorkflowSandboxHistoryItemExecConfig && !IsTestSuiteRunExternalExecConfig || !IsTestSuiteRunDeploymentReleaseTagExecConfig && !IsTestSuiteRunPromptSandboxHistoryItemExecConfig && !IsTestSuiteRunWorkflowReleaseTagExecConfig && IsTestSuiteRunWorkflowSandboxHistoryItemExecConfig && !IsTestSuiteRunExternalExecConfig || !IsTestSuiteRunDeploymentReleaseTagExecConfig && !IsTestSuiteRunPromptSandboxHistoryItemExecConfig && !IsTestSuiteRunWorkflowReleaseTagExecConfig && !IsTestSuiteRunWorkflowSandboxHistoryItemExecConfig && IsTestSuiteRunExternalExecConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig?, TResult>? testSuiteRunDeploymentReleaseTagExecConfig = null,
            global::System.Func<global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig?, TResult>? testSuiteRunPromptSandboxHistoryItemExecConfig = null,
            global::System.Func<global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig?, TResult>? testSuiteRunWorkflowReleaseTagExecConfig = null,
            global::System.Func<global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig?, TResult>? testSuiteRunWorkflowSandboxHistoryItemExecConfig = null,
            global::System.Func<global::Vellum.TestSuiteRunExternalExecConfig?, TResult>? testSuiteRunExternalExecConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTestSuiteRunDeploymentReleaseTagExecConfig && testSuiteRunDeploymentReleaseTagExecConfig != null)
            {
                return testSuiteRunDeploymentReleaseTagExecConfig(TestSuiteRunDeploymentReleaseTagExecConfig!);
            }
            else if (IsTestSuiteRunPromptSandboxHistoryItemExecConfig && testSuiteRunPromptSandboxHistoryItemExecConfig != null)
            {
                return testSuiteRunPromptSandboxHistoryItemExecConfig(TestSuiteRunPromptSandboxHistoryItemExecConfig!);
            }
            else if (IsTestSuiteRunWorkflowReleaseTagExecConfig && testSuiteRunWorkflowReleaseTagExecConfig != null)
            {
                return testSuiteRunWorkflowReleaseTagExecConfig(TestSuiteRunWorkflowReleaseTagExecConfig!);
            }
            else if (IsTestSuiteRunWorkflowSandboxHistoryItemExecConfig && testSuiteRunWorkflowSandboxHistoryItemExecConfig != null)
            {
                return testSuiteRunWorkflowSandboxHistoryItemExecConfig(TestSuiteRunWorkflowSandboxHistoryItemExecConfig!);
            }
            else if (IsTestSuiteRunExternalExecConfig && testSuiteRunExternalExecConfig != null)
            {
                return testSuiteRunExternalExecConfig(TestSuiteRunExternalExecConfig!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig?>? testSuiteRunDeploymentReleaseTagExecConfig = null,
            global::System.Action<global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig?>? testSuiteRunPromptSandboxHistoryItemExecConfig = null,
            global::System.Action<global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig?>? testSuiteRunWorkflowReleaseTagExecConfig = null,
            global::System.Action<global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig?>? testSuiteRunWorkflowSandboxHistoryItemExecConfig = null,
            global::System.Action<global::Vellum.TestSuiteRunExternalExecConfig?>? testSuiteRunExternalExecConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTestSuiteRunDeploymentReleaseTagExecConfig)
            {
                testSuiteRunDeploymentReleaseTagExecConfig?.Invoke(TestSuiteRunDeploymentReleaseTagExecConfig!);
            }
            else if (IsTestSuiteRunPromptSandboxHistoryItemExecConfig)
            {
                testSuiteRunPromptSandboxHistoryItemExecConfig?.Invoke(TestSuiteRunPromptSandboxHistoryItemExecConfig!);
            }
            else if (IsTestSuiteRunWorkflowReleaseTagExecConfig)
            {
                testSuiteRunWorkflowReleaseTagExecConfig?.Invoke(TestSuiteRunWorkflowReleaseTagExecConfig!);
            }
            else if (IsTestSuiteRunWorkflowSandboxHistoryItemExecConfig)
            {
                testSuiteRunWorkflowSandboxHistoryItemExecConfig?.Invoke(TestSuiteRunWorkflowSandboxHistoryItemExecConfig!);
            }
            else if (IsTestSuiteRunExternalExecConfig)
            {
                testSuiteRunExternalExecConfig?.Invoke(TestSuiteRunExternalExecConfig!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TestSuiteRunDeploymentReleaseTagExecConfig,
                typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig),
                TestSuiteRunPromptSandboxHistoryItemExecConfig,
                typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig),
                TestSuiteRunWorkflowReleaseTagExecConfig,
                typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig),
                TestSuiteRunWorkflowSandboxHistoryItemExecConfig,
                typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig),
                TestSuiteRunExternalExecConfig,
                typeof(global::Vellum.TestSuiteRunExternalExecConfig),
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
        public bool Equals(TestSuiteRunExecConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig?>.Default.Equals(TestSuiteRunDeploymentReleaseTagExecConfig, other.TestSuiteRunDeploymentReleaseTagExecConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig?>.Default.Equals(TestSuiteRunPromptSandboxHistoryItemExecConfig, other.TestSuiteRunPromptSandboxHistoryItemExecConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig?>.Default.Equals(TestSuiteRunWorkflowReleaseTagExecConfig, other.TestSuiteRunWorkflowReleaseTagExecConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig?>.Default.Equals(TestSuiteRunWorkflowSandboxHistoryItemExecConfig, other.TestSuiteRunWorkflowSandboxHistoryItemExecConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunExternalExecConfig?>.Default.Equals(TestSuiteRunExternalExecConfig, other.TestSuiteRunExternalExecConfig) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TestSuiteRunExecConfig obj1, TestSuiteRunExecConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TestSuiteRunExecConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TestSuiteRunExecConfig obj1, TestSuiteRunExecConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TestSuiteRunExecConfig o && Equals(o);
        }
    }
}
