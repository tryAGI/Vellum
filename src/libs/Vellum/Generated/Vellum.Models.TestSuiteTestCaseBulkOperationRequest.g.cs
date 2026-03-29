#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TestSuiteTestCaseBulkOperationRequest : global::System.IEquatable<TestSuiteTestCaseBulkOperationRequest>
    {
        /// <summary>
        /// A bulk operation that represents the creation of a Test Case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest? TestSuiteTestCaseCreateBulkOperationRequest { get; init; }
#else
        public global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest? TestSuiteTestCaseCreateBulkOperationRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteTestCaseCreateBulkOperationRequest))]
#endif
        public bool IsTestSuiteTestCaseCreateBulkOperationRequest => TestSuiteTestCaseCreateBulkOperationRequest != null;

        /// <summary>
        /// A bulk operation that represents the replacing of a Test Case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest? TestSuiteTestCaseReplaceBulkOperationRequest { get; init; }
#else
        public global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest? TestSuiteTestCaseReplaceBulkOperationRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteTestCaseReplaceBulkOperationRequest))]
#endif
        public bool IsTestSuiteTestCaseReplaceBulkOperationRequest => TestSuiteTestCaseReplaceBulkOperationRequest != null;

        /// <summary>
        /// A bulk operation that represents the upserting of a Test Case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest? TestSuiteTestCaseUpsertBulkOperationRequest { get; init; }
#else
        public global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest? TestSuiteTestCaseUpsertBulkOperationRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteTestCaseUpsertBulkOperationRequest))]
#endif
        public bool IsTestSuiteTestCaseUpsertBulkOperationRequest => TestSuiteTestCaseUpsertBulkOperationRequest != null;

        /// <summary>
        /// A bulk operation that represents the deletion of a Test Case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest? TestSuiteTestCaseDeleteBulkOperationRequest { get; init; }
#else
        public global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest? TestSuiteTestCaseDeleteBulkOperationRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteTestCaseDeleteBulkOperationRequest))]
#endif
        public bool IsTestSuiteTestCaseDeleteBulkOperationRequest => TestSuiteTestCaseDeleteBulkOperationRequest != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteTestCaseBulkOperationRequest(global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest value) => new TestSuiteTestCaseBulkOperationRequest((global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest?(TestSuiteTestCaseBulkOperationRequest @this) => @this.TestSuiteTestCaseCreateBulkOperationRequest;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteTestCaseBulkOperationRequest(global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest? value)
        {
            TestSuiteTestCaseCreateBulkOperationRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteTestCaseBulkOperationRequest(global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest value) => new TestSuiteTestCaseBulkOperationRequest((global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest?(TestSuiteTestCaseBulkOperationRequest @this) => @this.TestSuiteTestCaseReplaceBulkOperationRequest;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteTestCaseBulkOperationRequest(global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest? value)
        {
            TestSuiteTestCaseReplaceBulkOperationRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteTestCaseBulkOperationRequest(global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest value) => new TestSuiteTestCaseBulkOperationRequest((global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest?(TestSuiteTestCaseBulkOperationRequest @this) => @this.TestSuiteTestCaseUpsertBulkOperationRequest;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteTestCaseBulkOperationRequest(global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest? value)
        {
            TestSuiteTestCaseUpsertBulkOperationRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteTestCaseBulkOperationRequest(global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest value) => new TestSuiteTestCaseBulkOperationRequest((global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest?(TestSuiteTestCaseBulkOperationRequest @this) => @this.TestSuiteTestCaseDeleteBulkOperationRequest;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteTestCaseBulkOperationRequest(global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest? value)
        {
            TestSuiteTestCaseDeleteBulkOperationRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteTestCaseBulkOperationRequest(
            global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest? testSuiteTestCaseCreateBulkOperationRequest,
            global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest? testSuiteTestCaseReplaceBulkOperationRequest,
            global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest? testSuiteTestCaseUpsertBulkOperationRequest,
            global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest? testSuiteTestCaseDeleteBulkOperationRequest
            )
        {
            TestSuiteTestCaseCreateBulkOperationRequest = testSuiteTestCaseCreateBulkOperationRequest;
            TestSuiteTestCaseReplaceBulkOperationRequest = testSuiteTestCaseReplaceBulkOperationRequest;
            TestSuiteTestCaseUpsertBulkOperationRequest = testSuiteTestCaseUpsertBulkOperationRequest;
            TestSuiteTestCaseDeleteBulkOperationRequest = testSuiteTestCaseDeleteBulkOperationRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TestSuiteTestCaseDeleteBulkOperationRequest as object ??
            TestSuiteTestCaseUpsertBulkOperationRequest as object ??
            TestSuiteTestCaseReplaceBulkOperationRequest as object ??
            TestSuiteTestCaseCreateBulkOperationRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TestSuiteTestCaseCreateBulkOperationRequest?.ToString() ??
            TestSuiteTestCaseReplaceBulkOperationRequest?.ToString() ??
            TestSuiteTestCaseUpsertBulkOperationRequest?.ToString() ??
            TestSuiteTestCaseDeleteBulkOperationRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTestSuiteTestCaseCreateBulkOperationRequest && !IsTestSuiteTestCaseReplaceBulkOperationRequest && !IsTestSuiteTestCaseUpsertBulkOperationRequest && !IsTestSuiteTestCaseDeleteBulkOperationRequest || !IsTestSuiteTestCaseCreateBulkOperationRequest && IsTestSuiteTestCaseReplaceBulkOperationRequest && !IsTestSuiteTestCaseUpsertBulkOperationRequest && !IsTestSuiteTestCaseDeleteBulkOperationRequest || !IsTestSuiteTestCaseCreateBulkOperationRequest && !IsTestSuiteTestCaseReplaceBulkOperationRequest && IsTestSuiteTestCaseUpsertBulkOperationRequest && !IsTestSuiteTestCaseDeleteBulkOperationRequest || !IsTestSuiteTestCaseCreateBulkOperationRequest && !IsTestSuiteTestCaseReplaceBulkOperationRequest && !IsTestSuiteTestCaseUpsertBulkOperationRequest && IsTestSuiteTestCaseDeleteBulkOperationRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest?, TResult>? testSuiteTestCaseCreateBulkOperationRequest = null,
            global::System.Func<global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest?, TResult>? testSuiteTestCaseReplaceBulkOperationRequest = null,
            global::System.Func<global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest?, TResult>? testSuiteTestCaseUpsertBulkOperationRequest = null,
            global::System.Func<global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest?, TResult>? testSuiteTestCaseDeleteBulkOperationRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTestSuiteTestCaseCreateBulkOperationRequest && testSuiteTestCaseCreateBulkOperationRequest != null)
            {
                return testSuiteTestCaseCreateBulkOperationRequest(TestSuiteTestCaseCreateBulkOperationRequest!);
            }
            else if (IsTestSuiteTestCaseReplaceBulkOperationRequest && testSuiteTestCaseReplaceBulkOperationRequest != null)
            {
                return testSuiteTestCaseReplaceBulkOperationRequest(TestSuiteTestCaseReplaceBulkOperationRequest!);
            }
            else if (IsTestSuiteTestCaseUpsertBulkOperationRequest && testSuiteTestCaseUpsertBulkOperationRequest != null)
            {
                return testSuiteTestCaseUpsertBulkOperationRequest(TestSuiteTestCaseUpsertBulkOperationRequest!);
            }
            else if (IsTestSuiteTestCaseDeleteBulkOperationRequest && testSuiteTestCaseDeleteBulkOperationRequest != null)
            {
                return testSuiteTestCaseDeleteBulkOperationRequest(TestSuiteTestCaseDeleteBulkOperationRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest?>? testSuiteTestCaseCreateBulkOperationRequest = null,
            global::System.Action<global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest?>? testSuiteTestCaseReplaceBulkOperationRequest = null,
            global::System.Action<global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest?>? testSuiteTestCaseUpsertBulkOperationRequest = null,
            global::System.Action<global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest?>? testSuiteTestCaseDeleteBulkOperationRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTestSuiteTestCaseCreateBulkOperationRequest)
            {
                testSuiteTestCaseCreateBulkOperationRequest?.Invoke(TestSuiteTestCaseCreateBulkOperationRequest!);
            }
            else if (IsTestSuiteTestCaseReplaceBulkOperationRequest)
            {
                testSuiteTestCaseReplaceBulkOperationRequest?.Invoke(TestSuiteTestCaseReplaceBulkOperationRequest!);
            }
            else if (IsTestSuiteTestCaseUpsertBulkOperationRequest)
            {
                testSuiteTestCaseUpsertBulkOperationRequest?.Invoke(TestSuiteTestCaseUpsertBulkOperationRequest!);
            }
            else if (IsTestSuiteTestCaseDeleteBulkOperationRequest)
            {
                testSuiteTestCaseDeleteBulkOperationRequest?.Invoke(TestSuiteTestCaseDeleteBulkOperationRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TestSuiteTestCaseCreateBulkOperationRequest,
                typeof(global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest),
                TestSuiteTestCaseReplaceBulkOperationRequest,
                typeof(global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest),
                TestSuiteTestCaseUpsertBulkOperationRequest,
                typeof(global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest),
                TestSuiteTestCaseDeleteBulkOperationRequest,
                typeof(global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest),
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
        public bool Equals(TestSuiteTestCaseBulkOperationRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest?>.Default.Equals(TestSuiteTestCaseCreateBulkOperationRequest, other.TestSuiteTestCaseCreateBulkOperationRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest?>.Default.Equals(TestSuiteTestCaseReplaceBulkOperationRequest, other.TestSuiteTestCaseReplaceBulkOperationRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest?>.Default.Equals(TestSuiteTestCaseUpsertBulkOperationRequest, other.TestSuiteTestCaseUpsertBulkOperationRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest?>.Default.Equals(TestSuiteTestCaseDeleteBulkOperationRequest, other.TestSuiteTestCaseDeleteBulkOperationRequest) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TestSuiteTestCaseBulkOperationRequest obj1, TestSuiteTestCaseBulkOperationRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TestSuiteTestCaseBulkOperationRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TestSuiteTestCaseBulkOperationRequest obj1, TestSuiteTestCaseBulkOperationRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TestSuiteTestCaseBulkOperationRequest o && Equals(o);
        }
    }
}
