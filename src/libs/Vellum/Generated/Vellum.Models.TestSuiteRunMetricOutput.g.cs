#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TestSuiteRunMetricOutput : global::System.IEquatable<TestSuiteRunMetricOutput>
    {
        /// <summary>
        /// Output for a test suite run metric that is of type STRING
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunMetricStringOutput? TestSuiteRunMetricStringOutput { get; init; }
#else
        public global::Vellum.TestSuiteRunMetricStringOutput? TestSuiteRunMetricStringOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunMetricStringOutput))]
#endif
        public bool IsTestSuiteRunMetricStringOutput => TestSuiteRunMetricStringOutput != null;

        /// <summary>
        /// Output for a test suite run metric that is of type NUMBER
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunMetricNumberOutput? TestSuiteRunMetricNumberOutput { get; init; }
#else
        public global::Vellum.TestSuiteRunMetricNumberOutput? TestSuiteRunMetricNumberOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunMetricNumberOutput))]
#endif
        public bool IsTestSuiteRunMetricNumberOutput => TestSuiteRunMetricNumberOutput != null;

        /// <summary>
        /// Output for a test suite run metric that is of type NUMBER
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunMetricJSONOutput? TestSuiteRunMetricJSONOutput { get; init; }
#else
        public global::Vellum.TestSuiteRunMetricJSONOutput? TestSuiteRunMetricJSONOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunMetricJSONOutput))]
#endif
        public bool IsTestSuiteRunMetricJSONOutput => TestSuiteRunMetricJSONOutput != null;

        /// <summary>
        /// Output for a test suite run metric that is of type ERROR
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunMetricErrorOutput? TestSuiteRunMetricErrorOutput { get; init; }
#else
        public global::Vellum.TestSuiteRunMetricErrorOutput? TestSuiteRunMetricErrorOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunMetricErrorOutput))]
#endif
        public bool IsTestSuiteRunMetricErrorOutput => TestSuiteRunMetricErrorOutput != null;

        /// <summary>
        /// Output for a test suite run metric that is of type ARRAY
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunMetricArrayOutput? TestSuiteRunMetricArrayOutput { get; init; }
#else
        public global::Vellum.TestSuiteRunMetricArrayOutput? TestSuiteRunMetricArrayOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunMetricArrayOutput))]
#endif
        public bool IsTestSuiteRunMetricArrayOutput => TestSuiteRunMetricArrayOutput != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunMetricOutput(global::Vellum.TestSuiteRunMetricStringOutput value) => new TestSuiteRunMetricOutput((global::Vellum.TestSuiteRunMetricStringOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunMetricStringOutput?(TestSuiteRunMetricOutput @this) => @this.TestSuiteRunMetricStringOutput;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunMetricOutput(global::Vellum.TestSuiteRunMetricStringOutput? value)
        {
            TestSuiteRunMetricStringOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunMetricOutput(global::Vellum.TestSuiteRunMetricNumberOutput value) => new TestSuiteRunMetricOutput((global::Vellum.TestSuiteRunMetricNumberOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunMetricNumberOutput?(TestSuiteRunMetricOutput @this) => @this.TestSuiteRunMetricNumberOutput;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunMetricOutput(global::Vellum.TestSuiteRunMetricNumberOutput? value)
        {
            TestSuiteRunMetricNumberOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunMetricOutput(global::Vellum.TestSuiteRunMetricJSONOutput value) => new TestSuiteRunMetricOutput((global::Vellum.TestSuiteRunMetricJSONOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunMetricJSONOutput?(TestSuiteRunMetricOutput @this) => @this.TestSuiteRunMetricJSONOutput;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunMetricOutput(global::Vellum.TestSuiteRunMetricJSONOutput? value)
        {
            TestSuiteRunMetricJSONOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunMetricOutput(global::Vellum.TestSuiteRunMetricErrorOutput value) => new TestSuiteRunMetricOutput((global::Vellum.TestSuiteRunMetricErrorOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunMetricErrorOutput?(TestSuiteRunMetricOutput @this) => @this.TestSuiteRunMetricErrorOutput;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunMetricOutput(global::Vellum.TestSuiteRunMetricErrorOutput? value)
        {
            TestSuiteRunMetricErrorOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunMetricOutput(global::Vellum.TestSuiteRunMetricArrayOutput value) => new TestSuiteRunMetricOutput((global::Vellum.TestSuiteRunMetricArrayOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunMetricArrayOutput?(TestSuiteRunMetricOutput @this) => @this.TestSuiteRunMetricArrayOutput;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunMetricOutput(global::Vellum.TestSuiteRunMetricArrayOutput? value)
        {
            TestSuiteRunMetricArrayOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunMetricOutput(
            global::Vellum.TestSuiteRunMetricStringOutput? testSuiteRunMetricStringOutput,
            global::Vellum.TestSuiteRunMetricNumberOutput? testSuiteRunMetricNumberOutput,
            global::Vellum.TestSuiteRunMetricJSONOutput? testSuiteRunMetricJSONOutput,
            global::Vellum.TestSuiteRunMetricErrorOutput? testSuiteRunMetricErrorOutput,
            global::Vellum.TestSuiteRunMetricArrayOutput? testSuiteRunMetricArrayOutput
            )
        {
            TestSuiteRunMetricStringOutput = testSuiteRunMetricStringOutput;
            TestSuiteRunMetricNumberOutput = testSuiteRunMetricNumberOutput;
            TestSuiteRunMetricJSONOutput = testSuiteRunMetricJSONOutput;
            TestSuiteRunMetricErrorOutput = testSuiteRunMetricErrorOutput;
            TestSuiteRunMetricArrayOutput = testSuiteRunMetricArrayOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TestSuiteRunMetricArrayOutput as object ??
            TestSuiteRunMetricErrorOutput as object ??
            TestSuiteRunMetricJSONOutput as object ??
            TestSuiteRunMetricNumberOutput as object ??
            TestSuiteRunMetricStringOutput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TestSuiteRunMetricStringOutput?.ToString() ??
            TestSuiteRunMetricNumberOutput?.ToString() ??
            TestSuiteRunMetricJSONOutput?.ToString() ??
            TestSuiteRunMetricErrorOutput?.ToString() ??
            TestSuiteRunMetricArrayOutput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTestSuiteRunMetricStringOutput && !IsTestSuiteRunMetricNumberOutput && !IsTestSuiteRunMetricJSONOutput && !IsTestSuiteRunMetricErrorOutput && !IsTestSuiteRunMetricArrayOutput || !IsTestSuiteRunMetricStringOutput && IsTestSuiteRunMetricNumberOutput && !IsTestSuiteRunMetricJSONOutput && !IsTestSuiteRunMetricErrorOutput && !IsTestSuiteRunMetricArrayOutput || !IsTestSuiteRunMetricStringOutput && !IsTestSuiteRunMetricNumberOutput && IsTestSuiteRunMetricJSONOutput && !IsTestSuiteRunMetricErrorOutput && !IsTestSuiteRunMetricArrayOutput || !IsTestSuiteRunMetricStringOutput && !IsTestSuiteRunMetricNumberOutput && !IsTestSuiteRunMetricJSONOutput && IsTestSuiteRunMetricErrorOutput && !IsTestSuiteRunMetricArrayOutput || !IsTestSuiteRunMetricStringOutput && !IsTestSuiteRunMetricNumberOutput && !IsTestSuiteRunMetricJSONOutput && !IsTestSuiteRunMetricErrorOutput && IsTestSuiteRunMetricArrayOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.TestSuiteRunMetricStringOutput?, TResult>? testSuiteRunMetricStringOutput = null,
            global::System.Func<global::Vellum.TestSuiteRunMetricNumberOutput?, TResult>? testSuiteRunMetricNumberOutput = null,
            global::System.Func<global::Vellum.TestSuiteRunMetricJSONOutput?, TResult>? testSuiteRunMetricJSONOutput = null,
            global::System.Func<global::Vellum.TestSuiteRunMetricErrorOutput?, TResult>? testSuiteRunMetricErrorOutput = null,
            global::System.Func<global::Vellum.TestSuiteRunMetricArrayOutput?, TResult>? testSuiteRunMetricArrayOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTestSuiteRunMetricStringOutput && testSuiteRunMetricStringOutput != null)
            {
                return testSuiteRunMetricStringOutput(TestSuiteRunMetricStringOutput!);
            }
            else if (IsTestSuiteRunMetricNumberOutput && testSuiteRunMetricNumberOutput != null)
            {
                return testSuiteRunMetricNumberOutput(TestSuiteRunMetricNumberOutput!);
            }
            else if (IsTestSuiteRunMetricJSONOutput && testSuiteRunMetricJSONOutput != null)
            {
                return testSuiteRunMetricJSONOutput(TestSuiteRunMetricJSONOutput!);
            }
            else if (IsTestSuiteRunMetricErrorOutput && testSuiteRunMetricErrorOutput != null)
            {
                return testSuiteRunMetricErrorOutput(TestSuiteRunMetricErrorOutput!);
            }
            else if (IsTestSuiteRunMetricArrayOutput && testSuiteRunMetricArrayOutput != null)
            {
                return testSuiteRunMetricArrayOutput(TestSuiteRunMetricArrayOutput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.TestSuiteRunMetricStringOutput?>? testSuiteRunMetricStringOutput = null,
            global::System.Action<global::Vellum.TestSuiteRunMetricNumberOutput?>? testSuiteRunMetricNumberOutput = null,
            global::System.Action<global::Vellum.TestSuiteRunMetricJSONOutput?>? testSuiteRunMetricJSONOutput = null,
            global::System.Action<global::Vellum.TestSuiteRunMetricErrorOutput?>? testSuiteRunMetricErrorOutput = null,
            global::System.Action<global::Vellum.TestSuiteRunMetricArrayOutput?>? testSuiteRunMetricArrayOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTestSuiteRunMetricStringOutput)
            {
                testSuiteRunMetricStringOutput?.Invoke(TestSuiteRunMetricStringOutput!);
            }
            else if (IsTestSuiteRunMetricNumberOutput)
            {
                testSuiteRunMetricNumberOutput?.Invoke(TestSuiteRunMetricNumberOutput!);
            }
            else if (IsTestSuiteRunMetricJSONOutput)
            {
                testSuiteRunMetricJSONOutput?.Invoke(TestSuiteRunMetricJSONOutput!);
            }
            else if (IsTestSuiteRunMetricErrorOutput)
            {
                testSuiteRunMetricErrorOutput?.Invoke(TestSuiteRunMetricErrorOutput!);
            }
            else if (IsTestSuiteRunMetricArrayOutput)
            {
                testSuiteRunMetricArrayOutput?.Invoke(TestSuiteRunMetricArrayOutput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TestSuiteRunMetricStringOutput,
                typeof(global::Vellum.TestSuiteRunMetricStringOutput),
                TestSuiteRunMetricNumberOutput,
                typeof(global::Vellum.TestSuiteRunMetricNumberOutput),
                TestSuiteRunMetricJSONOutput,
                typeof(global::Vellum.TestSuiteRunMetricJSONOutput),
                TestSuiteRunMetricErrorOutput,
                typeof(global::Vellum.TestSuiteRunMetricErrorOutput),
                TestSuiteRunMetricArrayOutput,
                typeof(global::Vellum.TestSuiteRunMetricArrayOutput),
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
        public bool Equals(TestSuiteRunMetricOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunMetricStringOutput?>.Default.Equals(TestSuiteRunMetricStringOutput, other.TestSuiteRunMetricStringOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunMetricNumberOutput?>.Default.Equals(TestSuiteRunMetricNumberOutput, other.TestSuiteRunMetricNumberOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunMetricJSONOutput?>.Default.Equals(TestSuiteRunMetricJSONOutput, other.TestSuiteRunMetricJSONOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunMetricErrorOutput?>.Default.Equals(TestSuiteRunMetricErrorOutput, other.TestSuiteRunMetricErrorOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunMetricArrayOutput?>.Default.Equals(TestSuiteRunMetricArrayOutput, other.TestSuiteRunMetricArrayOutput) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TestSuiteRunMetricOutput obj1, TestSuiteRunMetricOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TestSuiteRunMetricOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TestSuiteRunMetricOutput obj1, TestSuiteRunMetricOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TestSuiteRunMetricOutput o && Equals(o);
        }
    }
}
