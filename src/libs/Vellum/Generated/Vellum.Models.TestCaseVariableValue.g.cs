#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TestCaseVariableValue : global::System.IEquatable<TestCaseVariableValue>
    {
        /// <summary>
        /// A string value for a variable in a Test Case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestCaseStringVariableValue? TestCaseStringVariableValue { get; init; }
#else
        public global::Vellum.TestCaseStringVariableValue? TestCaseStringVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseStringVariableValue))]
#endif
        public bool IsTestCaseStringVariableValue => TestCaseStringVariableValue != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTestCaseStringVariableValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.TestCaseStringVariableValue? value)
        {
            value = TestCaseStringVariableValue;
            return IsTestCaseStringVariableValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.TestCaseStringVariableValue PickTestCaseStringVariableValue() => IsTestCaseStringVariableValue
            ? TestCaseStringVariableValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseStringVariableValue' but the value was {ToString()}.");

        /// <summary>
        /// A numerical value for a variable in a Test Case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestCaseNumberVariableValue? TestCaseNumberVariableValue { get; init; }
#else
        public global::Vellum.TestCaseNumberVariableValue? TestCaseNumberVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseNumberVariableValue))]
#endif
        public bool IsTestCaseNumberVariableValue => TestCaseNumberVariableValue != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTestCaseNumberVariableValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.TestCaseNumberVariableValue? value)
        {
            value = TestCaseNumberVariableValue;
            return IsTestCaseNumberVariableValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.TestCaseNumberVariableValue PickTestCaseNumberVariableValue() => IsTestCaseNumberVariableValue
            ? TestCaseNumberVariableValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseNumberVariableValue' but the value was {ToString()}.");

        /// <summary>
        /// A JSON value for a variable in a Test Case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestCaseJsonVariableValue? TestCaseJsonVariableValue { get; init; }
#else
        public global::Vellum.TestCaseJsonVariableValue? TestCaseJsonVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseJsonVariableValue))]
#endif
        public bool IsTestCaseJsonVariableValue => TestCaseJsonVariableValue != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTestCaseJsonVariableValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.TestCaseJsonVariableValue? value)
        {
            value = TestCaseJsonVariableValue;
            return IsTestCaseJsonVariableValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.TestCaseJsonVariableValue PickTestCaseJsonVariableValue() => IsTestCaseJsonVariableValue
            ? TestCaseJsonVariableValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseJsonVariableValue' but the value was {ToString()}.");

        /// <summary>
        /// A chat history value for a variable in a Test Case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestCaseChatHistoryVariableValue? TestCaseChatHistoryVariableValue { get; init; }
#else
        public global::Vellum.TestCaseChatHistoryVariableValue? TestCaseChatHistoryVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseChatHistoryVariableValue))]
#endif
        public bool IsTestCaseChatHistoryVariableValue => TestCaseChatHistoryVariableValue != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTestCaseChatHistoryVariableValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.TestCaseChatHistoryVariableValue? value)
        {
            value = TestCaseChatHistoryVariableValue;
            return IsTestCaseChatHistoryVariableValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.TestCaseChatHistoryVariableValue PickTestCaseChatHistoryVariableValue() => IsTestCaseChatHistoryVariableValue
            ? TestCaseChatHistoryVariableValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseChatHistoryVariableValue' but the value was {ToString()}.");

        /// <summary>
        /// A search results value for a variable in a Test Case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestCaseSearchResultsVariableValue? TestCaseSearchResultsVariableValue { get; init; }
#else
        public global::Vellum.TestCaseSearchResultsVariableValue? TestCaseSearchResultsVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseSearchResultsVariableValue))]
#endif
        public bool IsTestCaseSearchResultsVariableValue => TestCaseSearchResultsVariableValue != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTestCaseSearchResultsVariableValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.TestCaseSearchResultsVariableValue? value)
        {
            value = TestCaseSearchResultsVariableValue;
            return IsTestCaseSearchResultsVariableValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.TestCaseSearchResultsVariableValue PickTestCaseSearchResultsVariableValue() => IsTestCaseSearchResultsVariableValue
            ? TestCaseSearchResultsVariableValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseSearchResultsVariableValue' but the value was {ToString()}.");

        /// <summary>
        /// An error value for a variable in a Test Case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestCaseErrorVariableValue? TestCaseErrorVariableValue { get; init; }
#else
        public global::Vellum.TestCaseErrorVariableValue? TestCaseErrorVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseErrorVariableValue))]
#endif
        public bool IsTestCaseErrorVariableValue => TestCaseErrorVariableValue != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTestCaseErrorVariableValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.TestCaseErrorVariableValue? value)
        {
            value = TestCaseErrorVariableValue;
            return IsTestCaseErrorVariableValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.TestCaseErrorVariableValue PickTestCaseErrorVariableValue() => IsTestCaseErrorVariableValue
            ? TestCaseErrorVariableValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseErrorVariableValue' but the value was {ToString()}.");

        /// <summary>
        /// A function call value for a variable in a Test Case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestCaseFunctionCallVariableValue? TestCaseFunctionCallVariableValue { get; init; }
#else
        public global::Vellum.TestCaseFunctionCallVariableValue? TestCaseFunctionCallVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseFunctionCallVariableValue))]
#endif
        public bool IsTestCaseFunctionCallVariableValue => TestCaseFunctionCallVariableValue != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTestCaseFunctionCallVariableValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.TestCaseFunctionCallVariableValue? value)
        {
            value = TestCaseFunctionCallVariableValue;
            return IsTestCaseFunctionCallVariableValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.TestCaseFunctionCallVariableValue PickTestCaseFunctionCallVariableValue() => IsTestCaseFunctionCallVariableValue
            ? TestCaseFunctionCallVariableValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseFunctionCallVariableValue' but the value was {ToString()}.");

        /// <summary>
        /// An Array value for a variable in a Test Case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestCaseArrayVariableValue? TestCaseArrayVariableValue { get; init; }
#else
        public global::Vellum.TestCaseArrayVariableValue? TestCaseArrayVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseArrayVariableValue))]
#endif
        public bool IsTestCaseArrayVariableValue => TestCaseArrayVariableValue != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTestCaseArrayVariableValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.TestCaseArrayVariableValue? value)
        {
            value = TestCaseArrayVariableValue;
            return IsTestCaseArrayVariableValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.TestCaseArrayVariableValue PickTestCaseArrayVariableValue() => IsTestCaseArrayVariableValue
            ? TestCaseArrayVariableValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseArrayVariableValue' but the value was {ToString()}.");

        /// <summary>
        /// An audio value for a variable in a Test Case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestCaseAudioVariableValue? TestCaseAudioVariableValue { get; init; }
#else
        public global::Vellum.TestCaseAudioVariableValue? TestCaseAudioVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseAudioVariableValue))]
#endif
        public bool IsTestCaseAudioVariableValue => TestCaseAudioVariableValue != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTestCaseAudioVariableValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.TestCaseAudioVariableValue? value)
        {
            value = TestCaseAudioVariableValue;
            return IsTestCaseAudioVariableValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.TestCaseAudioVariableValue PickTestCaseAudioVariableValue() => IsTestCaseAudioVariableValue
            ? TestCaseAudioVariableValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseAudioVariableValue' but the value was {ToString()}.");

        /// <summary>
        /// An image value for a variable in a Test Case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestCaseImageVariableValue? TestCaseImageVariableValue { get; init; }
#else
        public global::Vellum.TestCaseImageVariableValue? TestCaseImageVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseImageVariableValue))]
#endif
        public bool IsTestCaseImageVariableValue => TestCaseImageVariableValue != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTestCaseImageVariableValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.TestCaseImageVariableValue? value)
        {
            value = TestCaseImageVariableValue;
            return IsTestCaseImageVariableValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.TestCaseImageVariableValue PickTestCaseImageVariableValue() => IsTestCaseImageVariableValue
            ? TestCaseImageVariableValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseImageVariableValue' but the value was {ToString()}.");

        /// <summary>
        /// A video value for a variable in a Test Case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestCaseVideoVariableValue? TestCaseVideoVariableValue { get; init; }
#else
        public global::Vellum.TestCaseVideoVariableValue? TestCaseVideoVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseVideoVariableValue))]
#endif
        public bool IsTestCaseVideoVariableValue => TestCaseVideoVariableValue != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTestCaseVideoVariableValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.TestCaseVideoVariableValue? value)
        {
            value = TestCaseVideoVariableValue;
            return IsTestCaseVideoVariableValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.TestCaseVideoVariableValue PickTestCaseVideoVariableValue() => IsTestCaseVideoVariableValue
            ? TestCaseVideoVariableValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseVideoVariableValue' but the value was {ToString()}.");

        /// <summary>
        /// A document value for a variable in a Test Case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.TestCaseDocumentVariableValue? TestCaseDocumentVariableValue { get; init; }
#else
        public global::Vellum.TestCaseDocumentVariableValue? TestCaseDocumentVariableValue { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TestCaseDocumentVariableValue))]
#endif
        public bool IsTestCaseDocumentVariableValue => TestCaseDocumentVariableValue != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTestCaseDocumentVariableValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.TestCaseDocumentVariableValue? value)
        {
            value = TestCaseDocumentVariableValue;
            return IsTestCaseDocumentVariableValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.TestCaseDocumentVariableValue PickTestCaseDocumentVariableValue() => IsTestCaseDocumentVariableValue
            ? TestCaseDocumentVariableValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TestCaseDocumentVariableValue' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestCaseVariableValue(global::Vellum.TestCaseStringVariableValue value) => new TestCaseVariableValue((global::Vellum.TestCaseStringVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestCaseStringVariableValue?(TestCaseVariableValue @this) => @this.TestCaseStringVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public TestCaseVariableValue(global::Vellum.TestCaseStringVariableValue? value)
        {
            TestCaseStringVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TestCaseVariableValue FromTestCaseStringVariableValue(global::Vellum.TestCaseStringVariableValue? value) => new TestCaseVariableValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestCaseVariableValue(global::Vellum.TestCaseNumberVariableValue value) => new TestCaseVariableValue((global::Vellum.TestCaseNumberVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestCaseNumberVariableValue?(TestCaseVariableValue @this) => @this.TestCaseNumberVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public TestCaseVariableValue(global::Vellum.TestCaseNumberVariableValue? value)
        {
            TestCaseNumberVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TestCaseVariableValue FromTestCaseNumberVariableValue(global::Vellum.TestCaseNumberVariableValue? value) => new TestCaseVariableValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestCaseVariableValue(global::Vellum.TestCaseJsonVariableValue value) => new TestCaseVariableValue((global::Vellum.TestCaseJsonVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestCaseJsonVariableValue?(TestCaseVariableValue @this) => @this.TestCaseJsonVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public TestCaseVariableValue(global::Vellum.TestCaseJsonVariableValue? value)
        {
            TestCaseJsonVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TestCaseVariableValue FromTestCaseJsonVariableValue(global::Vellum.TestCaseJsonVariableValue? value) => new TestCaseVariableValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestCaseVariableValue(global::Vellum.TestCaseChatHistoryVariableValue value) => new TestCaseVariableValue((global::Vellum.TestCaseChatHistoryVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestCaseChatHistoryVariableValue?(TestCaseVariableValue @this) => @this.TestCaseChatHistoryVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public TestCaseVariableValue(global::Vellum.TestCaseChatHistoryVariableValue? value)
        {
            TestCaseChatHistoryVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TestCaseVariableValue FromTestCaseChatHistoryVariableValue(global::Vellum.TestCaseChatHistoryVariableValue? value) => new TestCaseVariableValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestCaseVariableValue(global::Vellum.TestCaseSearchResultsVariableValue value) => new TestCaseVariableValue((global::Vellum.TestCaseSearchResultsVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestCaseSearchResultsVariableValue?(TestCaseVariableValue @this) => @this.TestCaseSearchResultsVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public TestCaseVariableValue(global::Vellum.TestCaseSearchResultsVariableValue? value)
        {
            TestCaseSearchResultsVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TestCaseVariableValue FromTestCaseSearchResultsVariableValue(global::Vellum.TestCaseSearchResultsVariableValue? value) => new TestCaseVariableValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestCaseVariableValue(global::Vellum.TestCaseErrorVariableValue value) => new TestCaseVariableValue((global::Vellum.TestCaseErrorVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestCaseErrorVariableValue?(TestCaseVariableValue @this) => @this.TestCaseErrorVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public TestCaseVariableValue(global::Vellum.TestCaseErrorVariableValue? value)
        {
            TestCaseErrorVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TestCaseVariableValue FromTestCaseErrorVariableValue(global::Vellum.TestCaseErrorVariableValue? value) => new TestCaseVariableValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestCaseVariableValue(global::Vellum.TestCaseFunctionCallVariableValue value) => new TestCaseVariableValue((global::Vellum.TestCaseFunctionCallVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestCaseFunctionCallVariableValue?(TestCaseVariableValue @this) => @this.TestCaseFunctionCallVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public TestCaseVariableValue(global::Vellum.TestCaseFunctionCallVariableValue? value)
        {
            TestCaseFunctionCallVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TestCaseVariableValue FromTestCaseFunctionCallVariableValue(global::Vellum.TestCaseFunctionCallVariableValue? value) => new TestCaseVariableValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestCaseVariableValue(global::Vellum.TestCaseArrayVariableValue value) => new TestCaseVariableValue((global::Vellum.TestCaseArrayVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestCaseArrayVariableValue?(TestCaseVariableValue @this) => @this.TestCaseArrayVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public TestCaseVariableValue(global::Vellum.TestCaseArrayVariableValue? value)
        {
            TestCaseArrayVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TestCaseVariableValue FromTestCaseArrayVariableValue(global::Vellum.TestCaseArrayVariableValue? value) => new TestCaseVariableValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestCaseVariableValue(global::Vellum.TestCaseAudioVariableValue value) => new TestCaseVariableValue((global::Vellum.TestCaseAudioVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestCaseAudioVariableValue?(TestCaseVariableValue @this) => @this.TestCaseAudioVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public TestCaseVariableValue(global::Vellum.TestCaseAudioVariableValue? value)
        {
            TestCaseAudioVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TestCaseVariableValue FromTestCaseAudioVariableValue(global::Vellum.TestCaseAudioVariableValue? value) => new TestCaseVariableValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestCaseVariableValue(global::Vellum.TestCaseImageVariableValue value) => new TestCaseVariableValue((global::Vellum.TestCaseImageVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestCaseImageVariableValue?(TestCaseVariableValue @this) => @this.TestCaseImageVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public TestCaseVariableValue(global::Vellum.TestCaseImageVariableValue? value)
        {
            TestCaseImageVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TestCaseVariableValue FromTestCaseImageVariableValue(global::Vellum.TestCaseImageVariableValue? value) => new TestCaseVariableValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestCaseVariableValue(global::Vellum.TestCaseVideoVariableValue value) => new TestCaseVariableValue((global::Vellum.TestCaseVideoVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestCaseVideoVariableValue?(TestCaseVariableValue @this) => @this.TestCaseVideoVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public TestCaseVariableValue(global::Vellum.TestCaseVideoVariableValue? value)
        {
            TestCaseVideoVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TestCaseVariableValue FromTestCaseVideoVariableValue(global::Vellum.TestCaseVideoVariableValue? value) => new TestCaseVariableValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TestCaseVariableValue(global::Vellum.TestCaseDocumentVariableValue value) => new TestCaseVariableValue((global::Vellum.TestCaseDocumentVariableValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.TestCaseDocumentVariableValue?(TestCaseVariableValue @this) => @this.TestCaseDocumentVariableValue;

        /// <summary>
        /// 
        /// </summary>
        public TestCaseVariableValue(global::Vellum.TestCaseDocumentVariableValue? value)
        {
            TestCaseDocumentVariableValue = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TestCaseVariableValue FromTestCaseDocumentVariableValue(global::Vellum.TestCaseDocumentVariableValue? value) => new TestCaseVariableValue(value);

        /// <summary>
        /// 
        /// </summary>
        public TestCaseVariableValue(
            global::Vellum.TestCaseStringVariableValue? testCaseStringVariableValue,
            global::Vellum.TestCaseNumberVariableValue? testCaseNumberVariableValue,
            global::Vellum.TestCaseJsonVariableValue? testCaseJsonVariableValue,
            global::Vellum.TestCaseChatHistoryVariableValue? testCaseChatHistoryVariableValue,
            global::Vellum.TestCaseSearchResultsVariableValue? testCaseSearchResultsVariableValue,
            global::Vellum.TestCaseErrorVariableValue? testCaseErrorVariableValue,
            global::Vellum.TestCaseFunctionCallVariableValue? testCaseFunctionCallVariableValue,
            global::Vellum.TestCaseArrayVariableValue? testCaseArrayVariableValue,
            global::Vellum.TestCaseAudioVariableValue? testCaseAudioVariableValue,
            global::Vellum.TestCaseImageVariableValue? testCaseImageVariableValue,
            global::Vellum.TestCaseVideoVariableValue? testCaseVideoVariableValue,
            global::Vellum.TestCaseDocumentVariableValue? testCaseDocumentVariableValue
            )
        {
            TestCaseStringVariableValue = testCaseStringVariableValue;
            TestCaseNumberVariableValue = testCaseNumberVariableValue;
            TestCaseJsonVariableValue = testCaseJsonVariableValue;
            TestCaseChatHistoryVariableValue = testCaseChatHistoryVariableValue;
            TestCaseSearchResultsVariableValue = testCaseSearchResultsVariableValue;
            TestCaseErrorVariableValue = testCaseErrorVariableValue;
            TestCaseFunctionCallVariableValue = testCaseFunctionCallVariableValue;
            TestCaseArrayVariableValue = testCaseArrayVariableValue;
            TestCaseAudioVariableValue = testCaseAudioVariableValue;
            TestCaseImageVariableValue = testCaseImageVariableValue;
            TestCaseVideoVariableValue = testCaseVideoVariableValue;
            TestCaseDocumentVariableValue = testCaseDocumentVariableValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TestCaseDocumentVariableValue as object ??
            TestCaseVideoVariableValue as object ??
            TestCaseImageVariableValue as object ??
            TestCaseAudioVariableValue as object ??
            TestCaseArrayVariableValue as object ??
            TestCaseFunctionCallVariableValue as object ??
            TestCaseErrorVariableValue as object ??
            TestCaseSearchResultsVariableValue as object ??
            TestCaseChatHistoryVariableValue as object ??
            TestCaseJsonVariableValue as object ??
            TestCaseNumberVariableValue as object ??
            TestCaseStringVariableValue as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TestCaseStringVariableValue?.ToString() ??
            TestCaseNumberVariableValue?.ToString() ??
            TestCaseJsonVariableValue?.ToString() ??
            TestCaseChatHistoryVariableValue?.ToString() ??
            TestCaseSearchResultsVariableValue?.ToString() ??
            TestCaseErrorVariableValue?.ToString() ??
            TestCaseFunctionCallVariableValue?.ToString() ??
            TestCaseArrayVariableValue?.ToString() ??
            TestCaseAudioVariableValue?.ToString() ??
            TestCaseImageVariableValue?.ToString() ??
            TestCaseVideoVariableValue?.ToString() ??
            TestCaseDocumentVariableValue?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTestCaseStringVariableValue && !IsTestCaseNumberVariableValue && !IsTestCaseJsonVariableValue && !IsTestCaseChatHistoryVariableValue && !IsTestCaseSearchResultsVariableValue && !IsTestCaseErrorVariableValue && !IsTestCaseFunctionCallVariableValue && !IsTestCaseArrayVariableValue && !IsTestCaseAudioVariableValue && !IsTestCaseImageVariableValue && !IsTestCaseVideoVariableValue && !IsTestCaseDocumentVariableValue || !IsTestCaseStringVariableValue && IsTestCaseNumberVariableValue && !IsTestCaseJsonVariableValue && !IsTestCaseChatHistoryVariableValue && !IsTestCaseSearchResultsVariableValue && !IsTestCaseErrorVariableValue && !IsTestCaseFunctionCallVariableValue && !IsTestCaseArrayVariableValue && !IsTestCaseAudioVariableValue && !IsTestCaseImageVariableValue && !IsTestCaseVideoVariableValue && !IsTestCaseDocumentVariableValue || !IsTestCaseStringVariableValue && !IsTestCaseNumberVariableValue && IsTestCaseJsonVariableValue && !IsTestCaseChatHistoryVariableValue && !IsTestCaseSearchResultsVariableValue && !IsTestCaseErrorVariableValue && !IsTestCaseFunctionCallVariableValue && !IsTestCaseArrayVariableValue && !IsTestCaseAudioVariableValue && !IsTestCaseImageVariableValue && !IsTestCaseVideoVariableValue && !IsTestCaseDocumentVariableValue || !IsTestCaseStringVariableValue && !IsTestCaseNumberVariableValue && !IsTestCaseJsonVariableValue && IsTestCaseChatHistoryVariableValue && !IsTestCaseSearchResultsVariableValue && !IsTestCaseErrorVariableValue && !IsTestCaseFunctionCallVariableValue && !IsTestCaseArrayVariableValue && !IsTestCaseAudioVariableValue && !IsTestCaseImageVariableValue && !IsTestCaseVideoVariableValue && !IsTestCaseDocumentVariableValue || !IsTestCaseStringVariableValue && !IsTestCaseNumberVariableValue && !IsTestCaseJsonVariableValue && !IsTestCaseChatHistoryVariableValue && IsTestCaseSearchResultsVariableValue && !IsTestCaseErrorVariableValue && !IsTestCaseFunctionCallVariableValue && !IsTestCaseArrayVariableValue && !IsTestCaseAudioVariableValue && !IsTestCaseImageVariableValue && !IsTestCaseVideoVariableValue && !IsTestCaseDocumentVariableValue || !IsTestCaseStringVariableValue && !IsTestCaseNumberVariableValue && !IsTestCaseJsonVariableValue && !IsTestCaseChatHistoryVariableValue && !IsTestCaseSearchResultsVariableValue && IsTestCaseErrorVariableValue && !IsTestCaseFunctionCallVariableValue && !IsTestCaseArrayVariableValue && !IsTestCaseAudioVariableValue && !IsTestCaseImageVariableValue && !IsTestCaseVideoVariableValue && !IsTestCaseDocumentVariableValue || !IsTestCaseStringVariableValue && !IsTestCaseNumberVariableValue && !IsTestCaseJsonVariableValue && !IsTestCaseChatHistoryVariableValue && !IsTestCaseSearchResultsVariableValue && !IsTestCaseErrorVariableValue && IsTestCaseFunctionCallVariableValue && !IsTestCaseArrayVariableValue && !IsTestCaseAudioVariableValue && !IsTestCaseImageVariableValue && !IsTestCaseVideoVariableValue && !IsTestCaseDocumentVariableValue || !IsTestCaseStringVariableValue && !IsTestCaseNumberVariableValue && !IsTestCaseJsonVariableValue && !IsTestCaseChatHistoryVariableValue && !IsTestCaseSearchResultsVariableValue && !IsTestCaseErrorVariableValue && !IsTestCaseFunctionCallVariableValue && IsTestCaseArrayVariableValue && !IsTestCaseAudioVariableValue && !IsTestCaseImageVariableValue && !IsTestCaseVideoVariableValue && !IsTestCaseDocumentVariableValue || !IsTestCaseStringVariableValue && !IsTestCaseNumberVariableValue && !IsTestCaseJsonVariableValue && !IsTestCaseChatHistoryVariableValue && !IsTestCaseSearchResultsVariableValue && !IsTestCaseErrorVariableValue && !IsTestCaseFunctionCallVariableValue && !IsTestCaseArrayVariableValue && IsTestCaseAudioVariableValue && !IsTestCaseImageVariableValue && !IsTestCaseVideoVariableValue && !IsTestCaseDocumentVariableValue || !IsTestCaseStringVariableValue && !IsTestCaseNumberVariableValue && !IsTestCaseJsonVariableValue && !IsTestCaseChatHistoryVariableValue && !IsTestCaseSearchResultsVariableValue && !IsTestCaseErrorVariableValue && !IsTestCaseFunctionCallVariableValue && !IsTestCaseArrayVariableValue && !IsTestCaseAudioVariableValue && IsTestCaseImageVariableValue && !IsTestCaseVideoVariableValue && !IsTestCaseDocumentVariableValue || !IsTestCaseStringVariableValue && !IsTestCaseNumberVariableValue && !IsTestCaseJsonVariableValue && !IsTestCaseChatHistoryVariableValue && !IsTestCaseSearchResultsVariableValue && !IsTestCaseErrorVariableValue && !IsTestCaseFunctionCallVariableValue && !IsTestCaseArrayVariableValue && !IsTestCaseAudioVariableValue && !IsTestCaseImageVariableValue && IsTestCaseVideoVariableValue && !IsTestCaseDocumentVariableValue || !IsTestCaseStringVariableValue && !IsTestCaseNumberVariableValue && !IsTestCaseJsonVariableValue && !IsTestCaseChatHistoryVariableValue && !IsTestCaseSearchResultsVariableValue && !IsTestCaseErrorVariableValue && !IsTestCaseFunctionCallVariableValue && !IsTestCaseArrayVariableValue && !IsTestCaseAudioVariableValue && !IsTestCaseImageVariableValue && !IsTestCaseVideoVariableValue && IsTestCaseDocumentVariableValue;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.TestCaseStringVariableValue, TResult>? testCaseStringVariableValue = null,
            global::System.Func<global::Vellum.TestCaseNumberVariableValue, TResult>? testCaseNumberVariableValue = null,
            global::System.Func<global::Vellum.TestCaseJsonVariableValue, TResult>? testCaseJsonVariableValue = null,
            global::System.Func<global::Vellum.TestCaseChatHistoryVariableValue, TResult>? testCaseChatHistoryVariableValue = null,
            global::System.Func<global::Vellum.TestCaseSearchResultsVariableValue, TResult>? testCaseSearchResultsVariableValue = null,
            global::System.Func<global::Vellum.TestCaseErrorVariableValue, TResult>? testCaseErrorVariableValue = null,
            global::System.Func<global::Vellum.TestCaseFunctionCallVariableValue, TResult>? testCaseFunctionCallVariableValue = null,
            global::System.Func<global::Vellum.TestCaseArrayVariableValue, TResult>? testCaseArrayVariableValue = null,
            global::System.Func<global::Vellum.TestCaseAudioVariableValue, TResult>? testCaseAudioVariableValue = null,
            global::System.Func<global::Vellum.TestCaseImageVariableValue, TResult>? testCaseImageVariableValue = null,
            global::System.Func<global::Vellum.TestCaseVideoVariableValue, TResult>? testCaseVideoVariableValue = null,
            global::System.Func<global::Vellum.TestCaseDocumentVariableValue, TResult>? testCaseDocumentVariableValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTestCaseStringVariableValue && testCaseStringVariableValue != null)
            {
                return testCaseStringVariableValue(TestCaseStringVariableValue!);
            }
            else if (IsTestCaseNumberVariableValue && testCaseNumberVariableValue != null)
            {
                return testCaseNumberVariableValue(TestCaseNumberVariableValue!);
            }
            else if (IsTestCaseJsonVariableValue && testCaseJsonVariableValue != null)
            {
                return testCaseJsonVariableValue(TestCaseJsonVariableValue!);
            }
            else if (IsTestCaseChatHistoryVariableValue && testCaseChatHistoryVariableValue != null)
            {
                return testCaseChatHistoryVariableValue(TestCaseChatHistoryVariableValue!);
            }
            else if (IsTestCaseSearchResultsVariableValue && testCaseSearchResultsVariableValue != null)
            {
                return testCaseSearchResultsVariableValue(TestCaseSearchResultsVariableValue!);
            }
            else if (IsTestCaseErrorVariableValue && testCaseErrorVariableValue != null)
            {
                return testCaseErrorVariableValue(TestCaseErrorVariableValue!);
            }
            else if (IsTestCaseFunctionCallVariableValue && testCaseFunctionCallVariableValue != null)
            {
                return testCaseFunctionCallVariableValue(TestCaseFunctionCallVariableValue!);
            }
            else if (IsTestCaseArrayVariableValue && testCaseArrayVariableValue != null)
            {
                return testCaseArrayVariableValue(TestCaseArrayVariableValue!);
            }
            else if (IsTestCaseAudioVariableValue && testCaseAudioVariableValue != null)
            {
                return testCaseAudioVariableValue(TestCaseAudioVariableValue!);
            }
            else if (IsTestCaseImageVariableValue && testCaseImageVariableValue != null)
            {
                return testCaseImageVariableValue(TestCaseImageVariableValue!);
            }
            else if (IsTestCaseVideoVariableValue && testCaseVideoVariableValue != null)
            {
                return testCaseVideoVariableValue(TestCaseVideoVariableValue!);
            }
            else if (IsTestCaseDocumentVariableValue && testCaseDocumentVariableValue != null)
            {
                return testCaseDocumentVariableValue(TestCaseDocumentVariableValue!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.TestCaseStringVariableValue>? testCaseStringVariableValue = null,

            global::System.Action<global::Vellum.TestCaseNumberVariableValue>? testCaseNumberVariableValue = null,

            global::System.Action<global::Vellum.TestCaseJsonVariableValue>? testCaseJsonVariableValue = null,

            global::System.Action<global::Vellum.TestCaseChatHistoryVariableValue>? testCaseChatHistoryVariableValue = null,

            global::System.Action<global::Vellum.TestCaseSearchResultsVariableValue>? testCaseSearchResultsVariableValue = null,

            global::System.Action<global::Vellum.TestCaseErrorVariableValue>? testCaseErrorVariableValue = null,

            global::System.Action<global::Vellum.TestCaseFunctionCallVariableValue>? testCaseFunctionCallVariableValue = null,

            global::System.Action<global::Vellum.TestCaseArrayVariableValue>? testCaseArrayVariableValue = null,

            global::System.Action<global::Vellum.TestCaseAudioVariableValue>? testCaseAudioVariableValue = null,

            global::System.Action<global::Vellum.TestCaseImageVariableValue>? testCaseImageVariableValue = null,

            global::System.Action<global::Vellum.TestCaseVideoVariableValue>? testCaseVideoVariableValue = null,

            global::System.Action<global::Vellum.TestCaseDocumentVariableValue>? testCaseDocumentVariableValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTestCaseStringVariableValue)
            {
                testCaseStringVariableValue?.Invoke(TestCaseStringVariableValue!);
            }
            else if (IsTestCaseNumberVariableValue)
            {
                testCaseNumberVariableValue?.Invoke(TestCaseNumberVariableValue!);
            }
            else if (IsTestCaseJsonVariableValue)
            {
                testCaseJsonVariableValue?.Invoke(TestCaseJsonVariableValue!);
            }
            else if (IsTestCaseChatHistoryVariableValue)
            {
                testCaseChatHistoryVariableValue?.Invoke(TestCaseChatHistoryVariableValue!);
            }
            else if (IsTestCaseSearchResultsVariableValue)
            {
                testCaseSearchResultsVariableValue?.Invoke(TestCaseSearchResultsVariableValue!);
            }
            else if (IsTestCaseErrorVariableValue)
            {
                testCaseErrorVariableValue?.Invoke(TestCaseErrorVariableValue!);
            }
            else if (IsTestCaseFunctionCallVariableValue)
            {
                testCaseFunctionCallVariableValue?.Invoke(TestCaseFunctionCallVariableValue!);
            }
            else if (IsTestCaseArrayVariableValue)
            {
                testCaseArrayVariableValue?.Invoke(TestCaseArrayVariableValue!);
            }
            else if (IsTestCaseAudioVariableValue)
            {
                testCaseAudioVariableValue?.Invoke(TestCaseAudioVariableValue!);
            }
            else if (IsTestCaseImageVariableValue)
            {
                testCaseImageVariableValue?.Invoke(TestCaseImageVariableValue!);
            }
            else if (IsTestCaseVideoVariableValue)
            {
                testCaseVideoVariableValue?.Invoke(TestCaseVideoVariableValue!);
            }
            else if (IsTestCaseDocumentVariableValue)
            {
                testCaseDocumentVariableValue?.Invoke(TestCaseDocumentVariableValue!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vellum.TestCaseStringVariableValue>? testCaseStringVariableValue = null,
            global::System.Action<global::Vellum.TestCaseNumberVariableValue>? testCaseNumberVariableValue = null,
            global::System.Action<global::Vellum.TestCaseJsonVariableValue>? testCaseJsonVariableValue = null,
            global::System.Action<global::Vellum.TestCaseChatHistoryVariableValue>? testCaseChatHistoryVariableValue = null,
            global::System.Action<global::Vellum.TestCaseSearchResultsVariableValue>? testCaseSearchResultsVariableValue = null,
            global::System.Action<global::Vellum.TestCaseErrorVariableValue>? testCaseErrorVariableValue = null,
            global::System.Action<global::Vellum.TestCaseFunctionCallVariableValue>? testCaseFunctionCallVariableValue = null,
            global::System.Action<global::Vellum.TestCaseArrayVariableValue>? testCaseArrayVariableValue = null,
            global::System.Action<global::Vellum.TestCaseAudioVariableValue>? testCaseAudioVariableValue = null,
            global::System.Action<global::Vellum.TestCaseImageVariableValue>? testCaseImageVariableValue = null,
            global::System.Action<global::Vellum.TestCaseVideoVariableValue>? testCaseVideoVariableValue = null,
            global::System.Action<global::Vellum.TestCaseDocumentVariableValue>? testCaseDocumentVariableValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTestCaseStringVariableValue)
            {
                testCaseStringVariableValue?.Invoke(TestCaseStringVariableValue!);
            }
            else if (IsTestCaseNumberVariableValue)
            {
                testCaseNumberVariableValue?.Invoke(TestCaseNumberVariableValue!);
            }
            else if (IsTestCaseJsonVariableValue)
            {
                testCaseJsonVariableValue?.Invoke(TestCaseJsonVariableValue!);
            }
            else if (IsTestCaseChatHistoryVariableValue)
            {
                testCaseChatHistoryVariableValue?.Invoke(TestCaseChatHistoryVariableValue!);
            }
            else if (IsTestCaseSearchResultsVariableValue)
            {
                testCaseSearchResultsVariableValue?.Invoke(TestCaseSearchResultsVariableValue!);
            }
            else if (IsTestCaseErrorVariableValue)
            {
                testCaseErrorVariableValue?.Invoke(TestCaseErrorVariableValue!);
            }
            else if (IsTestCaseFunctionCallVariableValue)
            {
                testCaseFunctionCallVariableValue?.Invoke(TestCaseFunctionCallVariableValue!);
            }
            else if (IsTestCaseArrayVariableValue)
            {
                testCaseArrayVariableValue?.Invoke(TestCaseArrayVariableValue!);
            }
            else if (IsTestCaseAudioVariableValue)
            {
                testCaseAudioVariableValue?.Invoke(TestCaseAudioVariableValue!);
            }
            else if (IsTestCaseImageVariableValue)
            {
                testCaseImageVariableValue?.Invoke(TestCaseImageVariableValue!);
            }
            else if (IsTestCaseVideoVariableValue)
            {
                testCaseVideoVariableValue?.Invoke(TestCaseVideoVariableValue!);
            }
            else if (IsTestCaseDocumentVariableValue)
            {
                testCaseDocumentVariableValue?.Invoke(TestCaseDocumentVariableValue!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TestCaseStringVariableValue,
                typeof(global::Vellum.TestCaseStringVariableValue),
                TestCaseNumberVariableValue,
                typeof(global::Vellum.TestCaseNumberVariableValue),
                TestCaseJsonVariableValue,
                typeof(global::Vellum.TestCaseJsonVariableValue),
                TestCaseChatHistoryVariableValue,
                typeof(global::Vellum.TestCaseChatHistoryVariableValue),
                TestCaseSearchResultsVariableValue,
                typeof(global::Vellum.TestCaseSearchResultsVariableValue),
                TestCaseErrorVariableValue,
                typeof(global::Vellum.TestCaseErrorVariableValue),
                TestCaseFunctionCallVariableValue,
                typeof(global::Vellum.TestCaseFunctionCallVariableValue),
                TestCaseArrayVariableValue,
                typeof(global::Vellum.TestCaseArrayVariableValue),
                TestCaseAudioVariableValue,
                typeof(global::Vellum.TestCaseAudioVariableValue),
                TestCaseImageVariableValue,
                typeof(global::Vellum.TestCaseImageVariableValue),
                TestCaseVideoVariableValue,
                typeof(global::Vellum.TestCaseVideoVariableValue),
                TestCaseDocumentVariableValue,
                typeof(global::Vellum.TestCaseDocumentVariableValue),
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
        public bool Equals(TestCaseVariableValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestCaseStringVariableValue?>.Default.Equals(TestCaseStringVariableValue, other.TestCaseStringVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestCaseNumberVariableValue?>.Default.Equals(TestCaseNumberVariableValue, other.TestCaseNumberVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestCaseJsonVariableValue?>.Default.Equals(TestCaseJsonVariableValue, other.TestCaseJsonVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestCaseChatHistoryVariableValue?>.Default.Equals(TestCaseChatHistoryVariableValue, other.TestCaseChatHistoryVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestCaseSearchResultsVariableValue?>.Default.Equals(TestCaseSearchResultsVariableValue, other.TestCaseSearchResultsVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestCaseErrorVariableValue?>.Default.Equals(TestCaseErrorVariableValue, other.TestCaseErrorVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestCaseFunctionCallVariableValue?>.Default.Equals(TestCaseFunctionCallVariableValue, other.TestCaseFunctionCallVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestCaseArrayVariableValue?>.Default.Equals(TestCaseArrayVariableValue, other.TestCaseArrayVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestCaseAudioVariableValue?>.Default.Equals(TestCaseAudioVariableValue, other.TestCaseAudioVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestCaseImageVariableValue?>.Default.Equals(TestCaseImageVariableValue, other.TestCaseImageVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestCaseVideoVariableValue?>.Default.Equals(TestCaseVideoVariableValue, other.TestCaseVideoVariableValue) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.TestCaseDocumentVariableValue?>.Default.Equals(TestCaseDocumentVariableValue, other.TestCaseDocumentVariableValue) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TestCaseVariableValue obj1, TestCaseVariableValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TestCaseVariableValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TestCaseVariableValue obj1, TestCaseVariableValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TestCaseVariableValue o && Equals(o);
        }
    }
}
