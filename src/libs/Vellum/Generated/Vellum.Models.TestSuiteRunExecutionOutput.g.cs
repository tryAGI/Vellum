#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TestSuiteRunExecutionOutput : global::System.IEquatable<TestSuiteRunExecutionOutput>
    {
        /// <summary>
        /// Execution output of an entity evaluated during a Test Suite Run that is of type STRING
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunExecutionStringOutput? TestSuiteRunExecutionStringOutput { get; init; }
#else
        public global::Vellum.TestSuiteRunExecutionStringOutput? TestSuiteRunExecutionStringOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunExecutionStringOutput))]
#endif
        public bool IsTestSuiteRunExecutionStringOutput => TestSuiteRunExecutionStringOutput != null;

        /// <summary>
        /// Execution output of an entity evaluated during a Test Suite Run that is of type NUMBER
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunExecutionNumberOutput? TestSuiteRunExecutionNumberOutput { get; init; }
#else
        public global::Vellum.TestSuiteRunExecutionNumberOutput? TestSuiteRunExecutionNumberOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunExecutionNumberOutput))]
#endif
        public bool IsTestSuiteRunExecutionNumberOutput => TestSuiteRunExecutionNumberOutput != null;

        /// <summary>
        /// Execution output of an entity evaluated during a Test Suite Run that is of type JSON
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunExecutionJsonOutput? TestSuiteRunExecutionJsonOutput { get; init; }
#else
        public global::Vellum.TestSuiteRunExecutionJsonOutput? TestSuiteRunExecutionJsonOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunExecutionJsonOutput))]
#endif
        public bool IsTestSuiteRunExecutionJsonOutput => TestSuiteRunExecutionJsonOutput != null;

        /// <summary>
        /// Execution output of an entity evaluated during a Test Suite Run that is of type CHAT_HISTORY
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunExecutionChatHistoryOutput? TestSuiteRunExecutionChatHistoryOutput { get; init; }
#else
        public global::Vellum.TestSuiteRunExecutionChatHistoryOutput? TestSuiteRunExecutionChatHistoryOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunExecutionChatHistoryOutput))]
#endif
        public bool IsTestSuiteRunExecutionChatHistoryOutput => TestSuiteRunExecutionChatHistoryOutput != null;

        /// <summary>
        /// Execution output of an entity evaluated during a Test Suite Run that is of type SEARCH_RESULTS
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunExecutionSearchResultsOutput? TestSuiteRunExecutionSearchResultsOutput { get; init; }
#else
        public global::Vellum.TestSuiteRunExecutionSearchResultsOutput? TestSuiteRunExecutionSearchResultsOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunExecutionSearchResultsOutput))]
#endif
        public bool IsTestSuiteRunExecutionSearchResultsOutput => TestSuiteRunExecutionSearchResultsOutput != null;

        /// <summary>
        /// Execution output of an entity evaluated during a Test Suite Run that is of type ERROR
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunExecutionErrorOutput? TestSuiteRunExecutionErrorOutput { get; init; }
#else
        public global::Vellum.TestSuiteRunExecutionErrorOutput? TestSuiteRunExecutionErrorOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunExecutionErrorOutput))]
#endif
        public bool IsTestSuiteRunExecutionErrorOutput => TestSuiteRunExecutionErrorOutput != null;

        /// <summary>
        /// Execution output of an entity evaluated during a Test Suite Run that is of type FUNCTION_CALL
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunExecutionFunctionCallOutput? TestSuiteRunExecutionFunctionCallOutput { get; init; }
#else
        public global::Vellum.TestSuiteRunExecutionFunctionCallOutput? TestSuiteRunExecutionFunctionCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunExecutionFunctionCallOutput))]
#endif
        public bool IsTestSuiteRunExecutionFunctionCallOutput => TestSuiteRunExecutionFunctionCallOutput != null;

        /// <summary>
        /// Execution output of an entity evaluated during a Test Suite Run that is of type ARRAY
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestSuiteRunExecutionArrayOutput? TestSuiteRunExecutionArrayOutput { get; init; }
#else
        public global::Vellum.TestSuiteRunExecutionArrayOutput? TestSuiteRunExecutionArrayOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestSuiteRunExecutionArrayOutput))]
#endif
        public bool IsTestSuiteRunExecutionArrayOutput => TestSuiteRunExecutionArrayOutput != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunExecutionOutput(global::Vellum.TestSuiteRunExecutionStringOutput value) => new TestSuiteRunExecutionOutput((global::Vellum.TestSuiteRunExecutionStringOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunExecutionStringOutput?(TestSuiteRunExecutionOutput @this) => @this.TestSuiteRunExecutionStringOutput;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecutionOutput(global::Vellum.TestSuiteRunExecutionStringOutput? value)
        {
            TestSuiteRunExecutionStringOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunExecutionOutput(global::Vellum.TestSuiteRunExecutionNumberOutput value) => new TestSuiteRunExecutionOutput((global::Vellum.TestSuiteRunExecutionNumberOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunExecutionNumberOutput?(TestSuiteRunExecutionOutput @this) => @this.TestSuiteRunExecutionNumberOutput;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecutionOutput(global::Vellum.TestSuiteRunExecutionNumberOutput? value)
        {
            TestSuiteRunExecutionNumberOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunExecutionOutput(global::Vellum.TestSuiteRunExecutionJsonOutput value) => new TestSuiteRunExecutionOutput((global::Vellum.TestSuiteRunExecutionJsonOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunExecutionJsonOutput?(TestSuiteRunExecutionOutput @this) => @this.TestSuiteRunExecutionJsonOutput;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecutionOutput(global::Vellum.TestSuiteRunExecutionJsonOutput? value)
        {
            TestSuiteRunExecutionJsonOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunExecutionOutput(global::Vellum.TestSuiteRunExecutionChatHistoryOutput value) => new TestSuiteRunExecutionOutput((global::Vellum.TestSuiteRunExecutionChatHistoryOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunExecutionChatHistoryOutput?(TestSuiteRunExecutionOutput @this) => @this.TestSuiteRunExecutionChatHistoryOutput;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecutionOutput(global::Vellum.TestSuiteRunExecutionChatHistoryOutput? value)
        {
            TestSuiteRunExecutionChatHistoryOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunExecutionOutput(global::Vellum.TestSuiteRunExecutionSearchResultsOutput value) => new TestSuiteRunExecutionOutput((global::Vellum.TestSuiteRunExecutionSearchResultsOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunExecutionSearchResultsOutput?(TestSuiteRunExecutionOutput @this) => @this.TestSuiteRunExecutionSearchResultsOutput;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecutionOutput(global::Vellum.TestSuiteRunExecutionSearchResultsOutput? value)
        {
            TestSuiteRunExecutionSearchResultsOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunExecutionOutput(global::Vellum.TestSuiteRunExecutionErrorOutput value) => new TestSuiteRunExecutionOutput((global::Vellum.TestSuiteRunExecutionErrorOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunExecutionErrorOutput?(TestSuiteRunExecutionOutput @this) => @this.TestSuiteRunExecutionErrorOutput;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecutionOutput(global::Vellum.TestSuiteRunExecutionErrorOutput? value)
        {
            TestSuiteRunExecutionErrorOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunExecutionOutput(global::Vellum.TestSuiteRunExecutionFunctionCallOutput value) => new TestSuiteRunExecutionOutput((global::Vellum.TestSuiteRunExecutionFunctionCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunExecutionFunctionCallOutput?(TestSuiteRunExecutionOutput @this) => @this.TestSuiteRunExecutionFunctionCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecutionOutput(global::Vellum.TestSuiteRunExecutionFunctionCallOutput? value)
        {
            TestSuiteRunExecutionFunctionCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestSuiteRunExecutionOutput(global::Vellum.TestSuiteRunExecutionArrayOutput value) => new TestSuiteRunExecutionOutput((global::Vellum.TestSuiteRunExecutionArrayOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestSuiteRunExecutionArrayOutput?(TestSuiteRunExecutionOutput @this) => @this.TestSuiteRunExecutionArrayOutput;

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecutionOutput(global::Vellum.TestSuiteRunExecutionArrayOutput? value)
        {
            TestSuiteRunExecutionArrayOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TestSuiteRunExecutionOutput(
            global::Vellum.TestSuiteRunExecutionStringOutput? testSuiteRunExecutionStringOutput,
            global::Vellum.TestSuiteRunExecutionNumberOutput? testSuiteRunExecutionNumberOutput,
            global::Vellum.TestSuiteRunExecutionJsonOutput? testSuiteRunExecutionJsonOutput,
            global::Vellum.TestSuiteRunExecutionChatHistoryOutput? testSuiteRunExecutionChatHistoryOutput,
            global::Vellum.TestSuiteRunExecutionSearchResultsOutput? testSuiteRunExecutionSearchResultsOutput,
            global::Vellum.TestSuiteRunExecutionErrorOutput? testSuiteRunExecutionErrorOutput,
            global::Vellum.TestSuiteRunExecutionFunctionCallOutput? testSuiteRunExecutionFunctionCallOutput,
            global::Vellum.TestSuiteRunExecutionArrayOutput? testSuiteRunExecutionArrayOutput
            )
        {
            TestSuiteRunExecutionStringOutput = testSuiteRunExecutionStringOutput;
            TestSuiteRunExecutionNumberOutput = testSuiteRunExecutionNumberOutput;
            TestSuiteRunExecutionJsonOutput = testSuiteRunExecutionJsonOutput;
            TestSuiteRunExecutionChatHistoryOutput = testSuiteRunExecutionChatHistoryOutput;
            TestSuiteRunExecutionSearchResultsOutput = testSuiteRunExecutionSearchResultsOutput;
            TestSuiteRunExecutionErrorOutput = testSuiteRunExecutionErrorOutput;
            TestSuiteRunExecutionFunctionCallOutput = testSuiteRunExecutionFunctionCallOutput;
            TestSuiteRunExecutionArrayOutput = testSuiteRunExecutionArrayOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TestSuiteRunExecutionArrayOutput as object ??
            TestSuiteRunExecutionFunctionCallOutput as object ??
            TestSuiteRunExecutionErrorOutput as object ??
            TestSuiteRunExecutionSearchResultsOutput as object ??
            TestSuiteRunExecutionChatHistoryOutput as object ??
            TestSuiteRunExecutionJsonOutput as object ??
            TestSuiteRunExecutionNumberOutput as object ??
            TestSuiteRunExecutionStringOutput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TestSuiteRunExecutionStringOutput?.ToString() ??
            TestSuiteRunExecutionNumberOutput?.ToString() ??
            TestSuiteRunExecutionJsonOutput?.ToString() ??
            TestSuiteRunExecutionChatHistoryOutput?.ToString() ??
            TestSuiteRunExecutionSearchResultsOutput?.ToString() ??
            TestSuiteRunExecutionErrorOutput?.ToString() ??
            TestSuiteRunExecutionFunctionCallOutput?.ToString() ??
            TestSuiteRunExecutionArrayOutput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTestSuiteRunExecutionStringOutput && !IsTestSuiteRunExecutionNumberOutput && !IsTestSuiteRunExecutionJsonOutput && !IsTestSuiteRunExecutionChatHistoryOutput && !IsTestSuiteRunExecutionSearchResultsOutput && !IsTestSuiteRunExecutionErrorOutput && !IsTestSuiteRunExecutionFunctionCallOutput && !IsTestSuiteRunExecutionArrayOutput || !IsTestSuiteRunExecutionStringOutput && IsTestSuiteRunExecutionNumberOutput && !IsTestSuiteRunExecutionJsonOutput && !IsTestSuiteRunExecutionChatHistoryOutput && !IsTestSuiteRunExecutionSearchResultsOutput && !IsTestSuiteRunExecutionErrorOutput && !IsTestSuiteRunExecutionFunctionCallOutput && !IsTestSuiteRunExecutionArrayOutput || !IsTestSuiteRunExecutionStringOutput && !IsTestSuiteRunExecutionNumberOutput && IsTestSuiteRunExecutionJsonOutput && !IsTestSuiteRunExecutionChatHistoryOutput && !IsTestSuiteRunExecutionSearchResultsOutput && !IsTestSuiteRunExecutionErrorOutput && !IsTestSuiteRunExecutionFunctionCallOutput && !IsTestSuiteRunExecutionArrayOutput || !IsTestSuiteRunExecutionStringOutput && !IsTestSuiteRunExecutionNumberOutput && !IsTestSuiteRunExecutionJsonOutput && IsTestSuiteRunExecutionChatHistoryOutput && !IsTestSuiteRunExecutionSearchResultsOutput && !IsTestSuiteRunExecutionErrorOutput && !IsTestSuiteRunExecutionFunctionCallOutput && !IsTestSuiteRunExecutionArrayOutput || !IsTestSuiteRunExecutionStringOutput && !IsTestSuiteRunExecutionNumberOutput && !IsTestSuiteRunExecutionJsonOutput && !IsTestSuiteRunExecutionChatHistoryOutput && IsTestSuiteRunExecutionSearchResultsOutput && !IsTestSuiteRunExecutionErrorOutput && !IsTestSuiteRunExecutionFunctionCallOutput && !IsTestSuiteRunExecutionArrayOutput || !IsTestSuiteRunExecutionStringOutput && !IsTestSuiteRunExecutionNumberOutput && !IsTestSuiteRunExecutionJsonOutput && !IsTestSuiteRunExecutionChatHistoryOutput && !IsTestSuiteRunExecutionSearchResultsOutput && IsTestSuiteRunExecutionErrorOutput && !IsTestSuiteRunExecutionFunctionCallOutput && !IsTestSuiteRunExecutionArrayOutput || !IsTestSuiteRunExecutionStringOutput && !IsTestSuiteRunExecutionNumberOutput && !IsTestSuiteRunExecutionJsonOutput && !IsTestSuiteRunExecutionChatHistoryOutput && !IsTestSuiteRunExecutionSearchResultsOutput && !IsTestSuiteRunExecutionErrorOutput && IsTestSuiteRunExecutionFunctionCallOutput && !IsTestSuiteRunExecutionArrayOutput || !IsTestSuiteRunExecutionStringOutput && !IsTestSuiteRunExecutionNumberOutput && !IsTestSuiteRunExecutionJsonOutput && !IsTestSuiteRunExecutionChatHistoryOutput && !IsTestSuiteRunExecutionSearchResultsOutput && !IsTestSuiteRunExecutionErrorOutput && !IsTestSuiteRunExecutionFunctionCallOutput && IsTestSuiteRunExecutionArrayOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.TestSuiteRunExecutionStringOutput?, TResult>? testSuiteRunExecutionStringOutput = null,
            global::System.Func<global::Vellum.TestSuiteRunExecutionNumberOutput?, TResult>? testSuiteRunExecutionNumberOutput = null,
            global::System.Func<global::Vellum.TestSuiteRunExecutionJsonOutput?, TResult>? testSuiteRunExecutionJsonOutput = null,
            global::System.Func<global::Vellum.TestSuiteRunExecutionChatHistoryOutput?, TResult>? testSuiteRunExecutionChatHistoryOutput = null,
            global::System.Func<global::Vellum.TestSuiteRunExecutionSearchResultsOutput?, TResult>? testSuiteRunExecutionSearchResultsOutput = null,
            global::System.Func<global::Vellum.TestSuiteRunExecutionErrorOutput?, TResult>? testSuiteRunExecutionErrorOutput = null,
            global::System.Func<global::Vellum.TestSuiteRunExecutionFunctionCallOutput?, TResult>? testSuiteRunExecutionFunctionCallOutput = null,
            global::System.Func<global::Vellum.TestSuiteRunExecutionArrayOutput?, TResult>? testSuiteRunExecutionArrayOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTestSuiteRunExecutionStringOutput && testSuiteRunExecutionStringOutput != null)
            {
                return testSuiteRunExecutionStringOutput(TestSuiteRunExecutionStringOutput!);
            }
            else if (IsTestSuiteRunExecutionNumberOutput && testSuiteRunExecutionNumberOutput != null)
            {
                return testSuiteRunExecutionNumberOutput(TestSuiteRunExecutionNumberOutput!);
            }
            else if (IsTestSuiteRunExecutionJsonOutput && testSuiteRunExecutionJsonOutput != null)
            {
                return testSuiteRunExecutionJsonOutput(TestSuiteRunExecutionJsonOutput!);
            }
            else if (IsTestSuiteRunExecutionChatHistoryOutput && testSuiteRunExecutionChatHistoryOutput != null)
            {
                return testSuiteRunExecutionChatHistoryOutput(TestSuiteRunExecutionChatHistoryOutput!);
            }
            else if (IsTestSuiteRunExecutionSearchResultsOutput && testSuiteRunExecutionSearchResultsOutput != null)
            {
                return testSuiteRunExecutionSearchResultsOutput(TestSuiteRunExecutionSearchResultsOutput!);
            }
            else if (IsTestSuiteRunExecutionErrorOutput && testSuiteRunExecutionErrorOutput != null)
            {
                return testSuiteRunExecutionErrorOutput(TestSuiteRunExecutionErrorOutput!);
            }
            else if (IsTestSuiteRunExecutionFunctionCallOutput && testSuiteRunExecutionFunctionCallOutput != null)
            {
                return testSuiteRunExecutionFunctionCallOutput(TestSuiteRunExecutionFunctionCallOutput!);
            }
            else if (IsTestSuiteRunExecutionArrayOutput && testSuiteRunExecutionArrayOutput != null)
            {
                return testSuiteRunExecutionArrayOutput(TestSuiteRunExecutionArrayOutput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.TestSuiteRunExecutionStringOutput?>? testSuiteRunExecutionStringOutput = null,
            global::System.Action<global::Vellum.TestSuiteRunExecutionNumberOutput?>? testSuiteRunExecutionNumberOutput = null,
            global::System.Action<global::Vellum.TestSuiteRunExecutionJsonOutput?>? testSuiteRunExecutionJsonOutput = null,
            global::System.Action<global::Vellum.TestSuiteRunExecutionChatHistoryOutput?>? testSuiteRunExecutionChatHistoryOutput = null,
            global::System.Action<global::Vellum.TestSuiteRunExecutionSearchResultsOutput?>? testSuiteRunExecutionSearchResultsOutput = null,
            global::System.Action<global::Vellum.TestSuiteRunExecutionErrorOutput?>? testSuiteRunExecutionErrorOutput = null,
            global::System.Action<global::Vellum.TestSuiteRunExecutionFunctionCallOutput?>? testSuiteRunExecutionFunctionCallOutput = null,
            global::System.Action<global::Vellum.TestSuiteRunExecutionArrayOutput?>? testSuiteRunExecutionArrayOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTestSuiteRunExecutionStringOutput)
            {
                testSuiteRunExecutionStringOutput?.Invoke(TestSuiteRunExecutionStringOutput!);
            }
            else if (IsTestSuiteRunExecutionNumberOutput)
            {
                testSuiteRunExecutionNumberOutput?.Invoke(TestSuiteRunExecutionNumberOutput!);
            }
            else if (IsTestSuiteRunExecutionJsonOutput)
            {
                testSuiteRunExecutionJsonOutput?.Invoke(TestSuiteRunExecutionJsonOutput!);
            }
            else if (IsTestSuiteRunExecutionChatHistoryOutput)
            {
                testSuiteRunExecutionChatHistoryOutput?.Invoke(TestSuiteRunExecutionChatHistoryOutput!);
            }
            else if (IsTestSuiteRunExecutionSearchResultsOutput)
            {
                testSuiteRunExecutionSearchResultsOutput?.Invoke(TestSuiteRunExecutionSearchResultsOutput!);
            }
            else if (IsTestSuiteRunExecutionErrorOutput)
            {
                testSuiteRunExecutionErrorOutput?.Invoke(TestSuiteRunExecutionErrorOutput!);
            }
            else if (IsTestSuiteRunExecutionFunctionCallOutput)
            {
                testSuiteRunExecutionFunctionCallOutput?.Invoke(TestSuiteRunExecutionFunctionCallOutput!);
            }
            else if (IsTestSuiteRunExecutionArrayOutput)
            {
                testSuiteRunExecutionArrayOutput?.Invoke(TestSuiteRunExecutionArrayOutput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TestSuiteRunExecutionStringOutput,
                typeof(global::Vellum.TestSuiteRunExecutionStringOutput),
                TestSuiteRunExecutionNumberOutput,
                typeof(global::Vellum.TestSuiteRunExecutionNumberOutput),
                TestSuiteRunExecutionJsonOutput,
                typeof(global::Vellum.TestSuiteRunExecutionJsonOutput),
                TestSuiteRunExecutionChatHistoryOutput,
                typeof(global::Vellum.TestSuiteRunExecutionChatHistoryOutput),
                TestSuiteRunExecutionSearchResultsOutput,
                typeof(global::Vellum.TestSuiteRunExecutionSearchResultsOutput),
                TestSuiteRunExecutionErrorOutput,
                typeof(global::Vellum.TestSuiteRunExecutionErrorOutput),
                TestSuiteRunExecutionFunctionCallOutput,
                typeof(global::Vellum.TestSuiteRunExecutionFunctionCallOutput),
                TestSuiteRunExecutionArrayOutput,
                typeof(global::Vellum.TestSuiteRunExecutionArrayOutput),
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
        public bool Equals(TestSuiteRunExecutionOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunExecutionStringOutput?>.Default.Equals(TestSuiteRunExecutionStringOutput, other.TestSuiteRunExecutionStringOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunExecutionNumberOutput?>.Default.Equals(TestSuiteRunExecutionNumberOutput, other.TestSuiteRunExecutionNumberOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunExecutionJsonOutput?>.Default.Equals(TestSuiteRunExecutionJsonOutput, other.TestSuiteRunExecutionJsonOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunExecutionChatHistoryOutput?>.Default.Equals(TestSuiteRunExecutionChatHistoryOutput, other.TestSuiteRunExecutionChatHistoryOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunExecutionSearchResultsOutput?>.Default.Equals(TestSuiteRunExecutionSearchResultsOutput, other.TestSuiteRunExecutionSearchResultsOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunExecutionErrorOutput?>.Default.Equals(TestSuiteRunExecutionErrorOutput, other.TestSuiteRunExecutionErrorOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunExecutionFunctionCallOutput?>.Default.Equals(TestSuiteRunExecutionFunctionCallOutput, other.TestSuiteRunExecutionFunctionCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestSuiteRunExecutionArrayOutput?>.Default.Equals(TestSuiteRunExecutionArrayOutput, other.TestSuiteRunExecutionArrayOutput) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TestSuiteRunExecutionOutput obj1, TestSuiteRunExecutionOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TestSuiteRunExecutionOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TestSuiteRunExecutionOutput obj1, TestSuiteRunExecutionOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TestSuiteRunExecutionOutput o && Equals(o);
        }
    }
}
