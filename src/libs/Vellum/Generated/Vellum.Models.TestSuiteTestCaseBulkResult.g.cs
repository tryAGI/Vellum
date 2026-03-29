#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TestSuiteTestCaseBulkResult : global::System.IEquatable<TestSuiteTestCaseBulkResult>
    {
        /// <summary>
        /// The result of a bulk operation that created a Test Case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteTestCaseCreatedBulkResult? TestSuiteTestCaseCreatedBulkResult { get; init; }
#else
        public global::Vellum.TestSuiteTestCaseCreatedBulkResult? TestSuiteTestCaseCreatedBulkResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteTestCaseCreatedBulkResult))]
#endif
        public bool IsTestSuiteTestCaseCreatedBulkResult => TestSuiteTestCaseCreatedBulkResult != null;

        /// <summary>
        /// The result of a bulk operation that replaced a Test Case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteTestCaseReplacedBulkResult? TestSuiteTestCaseReplacedBulkResult { get; init; }
#else
        public global::Vellum.TestSuiteTestCaseReplacedBulkResult? TestSuiteTestCaseReplacedBulkResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteTestCaseReplacedBulkResult))]
#endif
        public bool IsTestSuiteTestCaseReplacedBulkResult => TestSuiteTestCaseReplacedBulkResult != null;

        /// <summary>
        /// The result of a bulk operation that deleted a Test Case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteTestCaseDeletedBulkResult? TestSuiteTestCaseDeletedBulkResult { get; init; }
#else
        public global::Vellum.TestSuiteTestCaseDeletedBulkResult? TestSuiteTestCaseDeletedBulkResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteTestCaseDeletedBulkResult))]
#endif
        public bool IsTestSuiteTestCaseDeletedBulkResult => TestSuiteTestCaseDeletedBulkResult != null;

        /// <summary>
        /// The result of a bulk operation that failed to operate on a Test Case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteTestCaseRejectedBulkResult? TestSuiteTestCaseRejectedBulkResult { get; init; }
#else
        public global::Vellum.TestSuiteTestCaseRejectedBulkResult? TestSuiteTestCaseRejectedBulkResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteTestCaseRejectedBulkResult))]
#endif
        public bool IsTestSuiteTestCaseRejectedBulkResult => TestSuiteTestCaseRejectedBulkResult != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteTestCaseBulkResult(global::Vellum.TestSuiteTestCaseCreatedBulkResult value) => new TestSuiteTestCaseBulkResult((global::Vellum.TestSuiteTestCaseCreatedBulkResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteTestCaseCreatedBulkResult?(TestSuiteTestCaseBulkResult @this) => @this.TestSuiteTestCaseCreatedBulkResult;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteTestCaseBulkResult(global::Vellum.TestSuiteTestCaseCreatedBulkResult? value)
        {
            TestSuiteTestCaseCreatedBulkResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteTestCaseBulkResult(global::Vellum.TestSuiteTestCaseReplacedBulkResult value) => new TestSuiteTestCaseBulkResult((global::Vellum.TestSuiteTestCaseReplacedBulkResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteTestCaseReplacedBulkResult?(TestSuiteTestCaseBulkResult @this) => @this.TestSuiteTestCaseReplacedBulkResult;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteTestCaseBulkResult(global::Vellum.TestSuiteTestCaseReplacedBulkResult? value)
        {
            TestSuiteTestCaseReplacedBulkResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteTestCaseBulkResult(global::Vellum.TestSuiteTestCaseDeletedBulkResult value) => new TestSuiteTestCaseBulkResult((global::Vellum.TestSuiteTestCaseDeletedBulkResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteTestCaseDeletedBulkResult?(TestSuiteTestCaseBulkResult @this) => @this.TestSuiteTestCaseDeletedBulkResult;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteTestCaseBulkResult(global::Vellum.TestSuiteTestCaseDeletedBulkResult? value)
        {
            TestSuiteTestCaseDeletedBulkResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteTestCaseBulkResult(global::Vellum.TestSuiteTestCaseRejectedBulkResult value) => new TestSuiteTestCaseBulkResult((global::Vellum.TestSuiteTestCaseRejectedBulkResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteTestCaseRejectedBulkResult?(TestSuiteTestCaseBulkResult @this) => @this.TestSuiteTestCaseRejectedBulkResult;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteTestCaseBulkResult(global::Vellum.TestSuiteTestCaseRejectedBulkResult? value)
        {
            TestSuiteTestCaseRejectedBulkResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteTestCaseBulkResult(
            global::Vellum.TestSuiteTestCaseCreatedBulkResult? testSuiteTestCaseCreatedBulkResult,
            global::Vellum.TestSuiteTestCaseReplacedBulkResult? testSuiteTestCaseReplacedBulkResult,
            global::Vellum.TestSuiteTestCaseDeletedBulkResult? testSuiteTestCaseDeletedBulkResult,
            global::Vellum.TestSuiteTestCaseRejectedBulkResult? testSuiteTestCaseRejectedBulkResult
            )
        {
            TestSuiteTestCaseCreatedBulkResult = testSuiteTestCaseCreatedBulkResult;
            TestSuiteTestCaseReplacedBulkResult = testSuiteTestCaseReplacedBulkResult;
            TestSuiteTestCaseDeletedBulkResult = testSuiteTestCaseDeletedBulkResult;
            TestSuiteTestCaseRejectedBulkResult = testSuiteTestCaseRejectedBulkResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TestSuiteTestCaseRejectedBulkResult as object ??
            TestSuiteTestCaseDeletedBulkResult as object ??
            TestSuiteTestCaseReplacedBulkResult as object ??
            TestSuiteTestCaseCreatedBulkResult as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TestSuiteTestCaseCreatedBulkResult?.ToString() ??
            TestSuiteTestCaseReplacedBulkResult?.ToString() ??
            TestSuiteTestCaseDeletedBulkResult?.ToString() ??
            TestSuiteTestCaseRejectedBulkResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTestSuiteTestCaseCreatedBulkResult && !IsTestSuiteTestCaseReplacedBulkResult && !IsTestSuiteTestCaseDeletedBulkResult && !IsTestSuiteTestCaseRejectedBulkResult || !IsTestSuiteTestCaseCreatedBulkResult && IsTestSuiteTestCaseReplacedBulkResult && !IsTestSuiteTestCaseDeletedBulkResult && !IsTestSuiteTestCaseRejectedBulkResult || !IsTestSuiteTestCaseCreatedBulkResult && !IsTestSuiteTestCaseReplacedBulkResult && IsTestSuiteTestCaseDeletedBulkResult && !IsTestSuiteTestCaseRejectedBulkResult || !IsTestSuiteTestCaseCreatedBulkResult && !IsTestSuiteTestCaseReplacedBulkResult && !IsTestSuiteTestCaseDeletedBulkResult && IsTestSuiteTestCaseRejectedBulkResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.TestSuiteTestCaseCreatedBulkResult?, TResult>? testSuiteTestCaseCreatedBulkResult = null,
            global::System.Func<global::Vellum.TestSuiteTestCaseReplacedBulkResult?, TResult>? testSuiteTestCaseReplacedBulkResult = null,
            global::System.Func<global::Vellum.TestSuiteTestCaseDeletedBulkResult?, TResult>? testSuiteTestCaseDeletedBulkResult = null,
            global::System.Func<global::Vellum.TestSuiteTestCaseRejectedBulkResult?, TResult>? testSuiteTestCaseRejectedBulkResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTestSuiteTestCaseCreatedBulkResult && testSuiteTestCaseCreatedBulkResult != null)
            {
                return testSuiteTestCaseCreatedBulkResult(TestSuiteTestCaseCreatedBulkResult!);
            }
            else if (IsTestSuiteTestCaseReplacedBulkResult && testSuiteTestCaseReplacedBulkResult != null)
            {
                return testSuiteTestCaseReplacedBulkResult(TestSuiteTestCaseReplacedBulkResult!);
            }
            else if (IsTestSuiteTestCaseDeletedBulkResult && testSuiteTestCaseDeletedBulkResult != null)
            {
                return testSuiteTestCaseDeletedBulkResult(TestSuiteTestCaseDeletedBulkResult!);
            }
            else if (IsTestSuiteTestCaseRejectedBulkResult && testSuiteTestCaseRejectedBulkResult != null)
            {
                return testSuiteTestCaseRejectedBulkResult(TestSuiteTestCaseRejectedBulkResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.TestSuiteTestCaseCreatedBulkResult?>? testSuiteTestCaseCreatedBulkResult = null,
            global::System.Action<global::Vellum.TestSuiteTestCaseReplacedBulkResult?>? testSuiteTestCaseReplacedBulkResult = null,
            global::System.Action<global::Vellum.TestSuiteTestCaseDeletedBulkResult?>? testSuiteTestCaseDeletedBulkResult = null,
            global::System.Action<global::Vellum.TestSuiteTestCaseRejectedBulkResult?>? testSuiteTestCaseRejectedBulkResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTestSuiteTestCaseCreatedBulkResult)
            {
                testSuiteTestCaseCreatedBulkResult?.Invoke(TestSuiteTestCaseCreatedBulkResult!);
            }
            else if (IsTestSuiteTestCaseReplacedBulkResult)
            {
                testSuiteTestCaseReplacedBulkResult?.Invoke(TestSuiteTestCaseReplacedBulkResult!);
            }
            else if (IsTestSuiteTestCaseDeletedBulkResult)
            {
                testSuiteTestCaseDeletedBulkResult?.Invoke(TestSuiteTestCaseDeletedBulkResult!);
            }
            else if (IsTestSuiteTestCaseRejectedBulkResult)
            {
                testSuiteTestCaseRejectedBulkResult?.Invoke(TestSuiteTestCaseRejectedBulkResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TestSuiteTestCaseCreatedBulkResult,
                typeof(global::Vellum.TestSuiteTestCaseCreatedBulkResult),
                TestSuiteTestCaseReplacedBulkResult,
                typeof(global::Vellum.TestSuiteTestCaseReplacedBulkResult),
                TestSuiteTestCaseDeletedBulkResult,
                typeof(global::Vellum.TestSuiteTestCaseDeletedBulkResult),
                TestSuiteTestCaseRejectedBulkResult,
                typeof(global::Vellum.TestSuiteTestCaseRejectedBulkResult),
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
        public bool Equals(TestSuiteTestCaseBulkResult other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteTestCaseCreatedBulkResult?>.Default.Equals(TestSuiteTestCaseCreatedBulkResult, other.TestSuiteTestCaseCreatedBulkResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteTestCaseReplacedBulkResult?>.Default.Equals(TestSuiteTestCaseReplacedBulkResult, other.TestSuiteTestCaseReplacedBulkResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteTestCaseDeletedBulkResult?>.Default.Equals(TestSuiteTestCaseDeletedBulkResult, other.TestSuiteTestCaseDeletedBulkResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteTestCaseRejectedBulkResult?>.Default.Equals(TestSuiteTestCaseRejectedBulkResult, other.TestSuiteTestCaseRejectedBulkResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TestSuiteTestCaseBulkResult obj1, TestSuiteTestCaseBulkResult obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TestSuiteTestCaseBulkResult>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TestSuiteTestCaseBulkResult obj1, TestSuiteTestCaseBulkResult obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TestSuiteTestCaseBulkResult o && Equals(o);
        }
    }
}
