#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TestSuiteRunExecConfigRequest : global::System.IEquatable<TestSuiteRunExecConfigRequest>
    {
        /// <summary>
        /// Execution configuration for running a Test Suite against a Prompt Deployment
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest? TestSuiteRunDeploymentReleaseTagExecConfigRequest { get; init; }
#else
        public global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest? TestSuiteRunDeploymentReleaseTagExecConfigRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunDeploymentReleaseTagExecConfigRequest))]
#endif
        public bool IsTestSuiteRunDeploymentReleaseTagExecConfigRequest => TestSuiteRunDeploymentReleaseTagExecConfigRequest != null;

        /// <summary>
        /// Execution configuration for running a Test Suite against a Prompt Sandbox
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest? TestSuiteRunPromptSandboxExecConfigRequest { get; init; }
#else
        public global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest? TestSuiteRunPromptSandboxExecConfigRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunPromptSandboxExecConfigRequest))]
#endif
        public bool IsTestSuiteRunPromptSandboxExecConfigRequest => TestSuiteRunPromptSandboxExecConfigRequest != null;

        /// <summary>
        /// Execution configuration for running a Test Suite against a Prompt Sandbox History Item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest? TestSuiteRunPromptSandboxHistoryItemExecConfigRequest { get; init; }
#else
        public global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest? TestSuiteRunPromptSandboxHistoryItemExecConfigRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunPromptSandboxHistoryItemExecConfigRequest))]
#endif
        public bool IsTestSuiteRunPromptSandboxHistoryItemExecConfigRequest => TestSuiteRunPromptSandboxHistoryItemExecConfigRequest != null;

        /// <summary>
        /// Execution configuration for running a Test Suite against a Workflow Deployment
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest? TestSuiteRunWorkflowReleaseTagExecConfigRequest { get; init; }
#else
        public global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest? TestSuiteRunWorkflowReleaseTagExecConfigRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunWorkflowReleaseTagExecConfigRequest))]
#endif
        public bool IsTestSuiteRunWorkflowReleaseTagExecConfigRequest => TestSuiteRunWorkflowReleaseTagExecConfigRequest != null;

        /// <summary>
        /// Execution configuration for running a Test Suite against a Workflow Sandbox
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest? TestSuiteRunWorkflowSandboxExecConfigRequest { get; init; }
#else
        public global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest? TestSuiteRunWorkflowSandboxExecConfigRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunWorkflowSandboxExecConfigRequest))]
#endif
        public bool IsTestSuiteRunWorkflowSandboxExecConfigRequest => TestSuiteRunWorkflowSandboxExecConfigRequest != null;

        /// <summary>
        /// Execution configuration for running a Test Suite against a Workflow Sandbox History Item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest? TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest { get; init; }
#else
        public global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest? TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest))]
#endif
        public bool IsTestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest => TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest != null;

        /// <summary>
        /// Execution configuration for running a Vellum Test Suite against an external callable
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunExternalExecConfigRequest? TestSuiteRunExternalExecConfigRequest { get; init; }
#else
        public global::Vellum.TestSuiteRunExternalExecConfigRequest? TestSuiteRunExternalExecConfigRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunExternalExecConfigRequest))]
#endif
        public bool IsTestSuiteRunExternalExecConfigRequest => TestSuiteRunExternalExecConfigRequest != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunExecConfigRequest(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest value) => new TestSuiteRunExecConfigRequest((global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest?(TestSuiteRunExecConfigRequest @this) => @this.TestSuiteRunDeploymentReleaseTagExecConfigRequest;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecConfigRequest(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest? value)
        {
            TestSuiteRunDeploymentReleaseTagExecConfigRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunExecConfigRequest(global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest value) => new TestSuiteRunExecConfigRequest((global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest?(TestSuiteRunExecConfigRequest @this) => @this.TestSuiteRunPromptSandboxExecConfigRequest;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecConfigRequest(global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest? value)
        {
            TestSuiteRunPromptSandboxExecConfigRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunExecConfigRequest(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest value) => new TestSuiteRunExecConfigRequest((global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest?(TestSuiteRunExecConfigRequest @this) => @this.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecConfigRequest(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest? value)
        {
            TestSuiteRunPromptSandboxHistoryItemExecConfigRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunExecConfigRequest(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest value) => new TestSuiteRunExecConfigRequest((global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest?(TestSuiteRunExecConfigRequest @this) => @this.TestSuiteRunWorkflowReleaseTagExecConfigRequest;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecConfigRequest(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest? value)
        {
            TestSuiteRunWorkflowReleaseTagExecConfigRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunExecConfigRequest(global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest value) => new TestSuiteRunExecConfigRequest((global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest?(TestSuiteRunExecConfigRequest @this) => @this.TestSuiteRunWorkflowSandboxExecConfigRequest;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecConfigRequest(global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest? value)
        {
            TestSuiteRunWorkflowSandboxExecConfigRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunExecConfigRequest(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest value) => new TestSuiteRunExecConfigRequest((global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest?(TestSuiteRunExecConfigRequest @this) => @this.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecConfigRequest(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest? value)
        {
            TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunExecConfigRequest(global::Vellum.TestSuiteRunExternalExecConfigRequest value) => new TestSuiteRunExecConfigRequest((global::Vellum.TestSuiteRunExternalExecConfigRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunExternalExecConfigRequest?(TestSuiteRunExecConfigRequest @this) => @this.TestSuiteRunExternalExecConfigRequest;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecConfigRequest(global::Vellum.TestSuiteRunExternalExecConfigRequest? value)
        {
            TestSuiteRunExternalExecConfigRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecConfigRequest(
            global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest? testSuiteRunDeploymentReleaseTagExecConfigRequest,
            global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest? testSuiteRunPromptSandboxExecConfigRequest,
            global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest? testSuiteRunPromptSandboxHistoryItemExecConfigRequest,
            global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest? testSuiteRunWorkflowReleaseTagExecConfigRequest,
            global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest? testSuiteRunWorkflowSandboxExecConfigRequest,
            global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest? testSuiteRunWorkflowSandboxHistoryItemExecConfigRequest,
            global::Vellum.TestSuiteRunExternalExecConfigRequest? testSuiteRunExternalExecConfigRequest
            )
        {
            TestSuiteRunDeploymentReleaseTagExecConfigRequest = testSuiteRunDeploymentReleaseTagExecConfigRequest;
            TestSuiteRunPromptSandboxExecConfigRequest = testSuiteRunPromptSandboxExecConfigRequest;
            TestSuiteRunPromptSandboxHistoryItemExecConfigRequest = testSuiteRunPromptSandboxHistoryItemExecConfigRequest;
            TestSuiteRunWorkflowReleaseTagExecConfigRequest = testSuiteRunWorkflowReleaseTagExecConfigRequest;
            TestSuiteRunWorkflowSandboxExecConfigRequest = testSuiteRunWorkflowSandboxExecConfigRequest;
            TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest = testSuiteRunWorkflowSandboxHistoryItemExecConfigRequest;
            TestSuiteRunExternalExecConfigRequest = testSuiteRunExternalExecConfigRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TestSuiteRunExternalExecConfigRequest as object ??
            TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest as object ??
            TestSuiteRunWorkflowSandboxExecConfigRequest as object ??
            TestSuiteRunWorkflowReleaseTagExecConfigRequest as object ??
            TestSuiteRunPromptSandboxHistoryItemExecConfigRequest as object ??
            TestSuiteRunPromptSandboxExecConfigRequest as object ??
            TestSuiteRunDeploymentReleaseTagExecConfigRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TestSuiteRunDeploymentReleaseTagExecConfigRequest?.ToString() ??
            TestSuiteRunPromptSandboxExecConfigRequest?.ToString() ??
            TestSuiteRunPromptSandboxHistoryItemExecConfigRequest?.ToString() ??
            TestSuiteRunWorkflowReleaseTagExecConfigRequest?.ToString() ??
            TestSuiteRunWorkflowSandboxExecConfigRequest?.ToString() ??
            TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest?.ToString() ??
            TestSuiteRunExternalExecConfigRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTestSuiteRunDeploymentReleaseTagExecConfigRequest && !IsTestSuiteRunPromptSandboxExecConfigRequest && !IsTestSuiteRunPromptSandboxHistoryItemExecConfigRequest && !IsTestSuiteRunWorkflowReleaseTagExecConfigRequest && !IsTestSuiteRunWorkflowSandboxExecConfigRequest && !IsTestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest && !IsTestSuiteRunExternalExecConfigRequest || !IsTestSuiteRunDeploymentReleaseTagExecConfigRequest && IsTestSuiteRunPromptSandboxExecConfigRequest && !IsTestSuiteRunPromptSandboxHistoryItemExecConfigRequest && !IsTestSuiteRunWorkflowReleaseTagExecConfigRequest && !IsTestSuiteRunWorkflowSandboxExecConfigRequest && !IsTestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest && !IsTestSuiteRunExternalExecConfigRequest || !IsTestSuiteRunDeploymentReleaseTagExecConfigRequest && !IsTestSuiteRunPromptSandboxExecConfigRequest && IsTestSuiteRunPromptSandboxHistoryItemExecConfigRequest && !IsTestSuiteRunWorkflowReleaseTagExecConfigRequest && !IsTestSuiteRunWorkflowSandboxExecConfigRequest && !IsTestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest && !IsTestSuiteRunExternalExecConfigRequest || !IsTestSuiteRunDeploymentReleaseTagExecConfigRequest && !IsTestSuiteRunPromptSandboxExecConfigRequest && !IsTestSuiteRunPromptSandboxHistoryItemExecConfigRequest && IsTestSuiteRunWorkflowReleaseTagExecConfigRequest && !IsTestSuiteRunWorkflowSandboxExecConfigRequest && !IsTestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest && !IsTestSuiteRunExternalExecConfigRequest || !IsTestSuiteRunDeploymentReleaseTagExecConfigRequest && !IsTestSuiteRunPromptSandboxExecConfigRequest && !IsTestSuiteRunPromptSandboxHistoryItemExecConfigRequest && !IsTestSuiteRunWorkflowReleaseTagExecConfigRequest && IsTestSuiteRunWorkflowSandboxExecConfigRequest && !IsTestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest && !IsTestSuiteRunExternalExecConfigRequest || !IsTestSuiteRunDeploymentReleaseTagExecConfigRequest && !IsTestSuiteRunPromptSandboxExecConfigRequest && !IsTestSuiteRunPromptSandboxHistoryItemExecConfigRequest && !IsTestSuiteRunWorkflowReleaseTagExecConfigRequest && !IsTestSuiteRunWorkflowSandboxExecConfigRequest && IsTestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest && !IsTestSuiteRunExternalExecConfigRequest || !IsTestSuiteRunDeploymentReleaseTagExecConfigRequest && !IsTestSuiteRunPromptSandboxExecConfigRequest && !IsTestSuiteRunPromptSandboxHistoryItemExecConfigRequest && !IsTestSuiteRunWorkflowReleaseTagExecConfigRequest && !IsTestSuiteRunWorkflowSandboxExecConfigRequest && !IsTestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest && IsTestSuiteRunExternalExecConfigRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest?, TResult>? testSuiteRunDeploymentReleaseTagExecConfigRequest = null,
            global::System.Func<global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest?, TResult>? testSuiteRunPromptSandboxExecConfigRequest = null,
            global::System.Func<global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest?, TResult>? testSuiteRunPromptSandboxHistoryItemExecConfigRequest = null,
            global::System.Func<global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest?, TResult>? testSuiteRunWorkflowReleaseTagExecConfigRequest = null,
            global::System.Func<global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest?, TResult>? testSuiteRunWorkflowSandboxExecConfigRequest = null,
            global::System.Func<global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest?, TResult>? testSuiteRunWorkflowSandboxHistoryItemExecConfigRequest = null,
            global::System.Func<global::Vellum.TestSuiteRunExternalExecConfigRequest?, TResult>? testSuiteRunExternalExecConfigRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTestSuiteRunDeploymentReleaseTagExecConfigRequest && testSuiteRunDeploymentReleaseTagExecConfigRequest != null)
            {
                return testSuiteRunDeploymentReleaseTagExecConfigRequest(TestSuiteRunDeploymentReleaseTagExecConfigRequest!);
            }
            else if (IsTestSuiteRunPromptSandboxExecConfigRequest && testSuiteRunPromptSandboxExecConfigRequest != null)
            {
                return testSuiteRunPromptSandboxExecConfigRequest(TestSuiteRunPromptSandboxExecConfigRequest!);
            }
            else if (IsTestSuiteRunPromptSandboxHistoryItemExecConfigRequest && testSuiteRunPromptSandboxHistoryItemExecConfigRequest != null)
            {
                return testSuiteRunPromptSandboxHistoryItemExecConfigRequest(TestSuiteRunPromptSandboxHistoryItemExecConfigRequest!);
            }
            else if (IsTestSuiteRunWorkflowReleaseTagExecConfigRequest && testSuiteRunWorkflowReleaseTagExecConfigRequest != null)
            {
                return testSuiteRunWorkflowReleaseTagExecConfigRequest(TestSuiteRunWorkflowReleaseTagExecConfigRequest!);
            }
            else if (IsTestSuiteRunWorkflowSandboxExecConfigRequest && testSuiteRunWorkflowSandboxExecConfigRequest != null)
            {
                return testSuiteRunWorkflowSandboxExecConfigRequest(TestSuiteRunWorkflowSandboxExecConfigRequest!);
            }
            else if (IsTestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest && testSuiteRunWorkflowSandboxHistoryItemExecConfigRequest != null)
            {
                return testSuiteRunWorkflowSandboxHistoryItemExecConfigRequest(TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest!);
            }
            else if (IsTestSuiteRunExternalExecConfigRequest && testSuiteRunExternalExecConfigRequest != null)
            {
                return testSuiteRunExternalExecConfigRequest(TestSuiteRunExternalExecConfigRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest?>? testSuiteRunDeploymentReleaseTagExecConfigRequest = null,
            global::System.Action<global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest?>? testSuiteRunPromptSandboxExecConfigRequest = null,
            global::System.Action<global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest?>? testSuiteRunPromptSandboxHistoryItemExecConfigRequest = null,
            global::System.Action<global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest?>? testSuiteRunWorkflowReleaseTagExecConfigRequest = null,
            global::System.Action<global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest?>? testSuiteRunWorkflowSandboxExecConfigRequest = null,
            global::System.Action<global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest?>? testSuiteRunWorkflowSandboxHistoryItemExecConfigRequest = null,
            global::System.Action<global::Vellum.TestSuiteRunExternalExecConfigRequest?>? testSuiteRunExternalExecConfigRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTestSuiteRunDeploymentReleaseTagExecConfigRequest)
            {
                testSuiteRunDeploymentReleaseTagExecConfigRequest?.Invoke(TestSuiteRunDeploymentReleaseTagExecConfigRequest!);
            }
            else if (IsTestSuiteRunPromptSandboxExecConfigRequest)
            {
                testSuiteRunPromptSandboxExecConfigRequest?.Invoke(TestSuiteRunPromptSandboxExecConfigRequest!);
            }
            else if (IsTestSuiteRunPromptSandboxHistoryItemExecConfigRequest)
            {
                testSuiteRunPromptSandboxHistoryItemExecConfigRequest?.Invoke(TestSuiteRunPromptSandboxHistoryItemExecConfigRequest!);
            }
            else if (IsTestSuiteRunWorkflowReleaseTagExecConfigRequest)
            {
                testSuiteRunWorkflowReleaseTagExecConfigRequest?.Invoke(TestSuiteRunWorkflowReleaseTagExecConfigRequest!);
            }
            else if (IsTestSuiteRunWorkflowSandboxExecConfigRequest)
            {
                testSuiteRunWorkflowSandboxExecConfigRequest?.Invoke(TestSuiteRunWorkflowSandboxExecConfigRequest!);
            }
            else if (IsTestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest)
            {
                testSuiteRunWorkflowSandboxHistoryItemExecConfigRequest?.Invoke(TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest!);
            }
            else if (IsTestSuiteRunExternalExecConfigRequest)
            {
                testSuiteRunExternalExecConfigRequest?.Invoke(TestSuiteRunExternalExecConfigRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TestSuiteRunDeploymentReleaseTagExecConfigRequest,
                typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest),
                TestSuiteRunPromptSandboxExecConfigRequest,
                typeof(global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest),
                TestSuiteRunPromptSandboxHistoryItemExecConfigRequest,
                typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest),
                TestSuiteRunWorkflowReleaseTagExecConfigRequest,
                typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest),
                TestSuiteRunWorkflowSandboxExecConfigRequest,
                typeof(global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest),
                TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest,
                typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest),
                TestSuiteRunExternalExecConfigRequest,
                typeof(global::Vellum.TestSuiteRunExternalExecConfigRequest),
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
        public bool Equals(TestSuiteRunExecConfigRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest?>.Default.Equals(TestSuiteRunDeploymentReleaseTagExecConfigRequest, other.TestSuiteRunDeploymentReleaseTagExecConfigRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest?>.Default.Equals(TestSuiteRunPromptSandboxExecConfigRequest, other.TestSuiteRunPromptSandboxExecConfigRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest?>.Default.Equals(TestSuiteRunPromptSandboxHistoryItemExecConfigRequest, other.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest?>.Default.Equals(TestSuiteRunWorkflowReleaseTagExecConfigRequest, other.TestSuiteRunWorkflowReleaseTagExecConfigRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest?>.Default.Equals(TestSuiteRunWorkflowSandboxExecConfigRequest, other.TestSuiteRunWorkflowSandboxExecConfigRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest?>.Default.Equals(TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest, other.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunExternalExecConfigRequest?>.Default.Equals(TestSuiteRunExternalExecConfigRequest, other.TestSuiteRunExternalExecConfigRequest) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TestSuiteRunExecConfigRequest obj1, TestSuiteRunExecConfigRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TestSuiteRunExecConfigRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TestSuiteRunExecConfigRequest obj1, TestSuiteRunExecConfigRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TestSuiteRunExecConfigRequest o && Equals(o);
        }
    }
}
