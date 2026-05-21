#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IndexingConfigVectorizerRequest : global::System.IEquatable<IndexingConfigVectorizerRequest>
    {
        /// <summary>
        /// OpenAI vectorizer for text-embedding-3-small.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest? OpenAIVectorizerTextEmbedding3SmallRequest { get; init; }
#else
        public global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest? OpenAIVectorizerTextEmbedding3SmallRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIVectorizerTextEmbedding3SmallRequest))]
#endif
        public bool IsOpenAIVectorizerTextEmbedding3SmallRequest => OpenAIVectorizerTextEmbedding3SmallRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenAIVectorizerTextEmbedding3SmallRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest? value)
        {
            value = OpenAIVectorizerTextEmbedding3SmallRequest;
            return IsOpenAIVectorizerTextEmbedding3SmallRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest PickOpenAIVectorizerTextEmbedding3SmallRequest() => IsOpenAIVectorizerTextEmbedding3SmallRequest
            ? OpenAIVectorizerTextEmbedding3SmallRequest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIVectorizerTextEmbedding3SmallRequest' but the value was {ToString()}.");

        /// <summary>
        /// OpenAI vectorizer for text-embedding-3-large.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest? OpenAIVectorizerTextEmbedding3LargeRequest { get; init; }
#else
        public global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest? OpenAIVectorizerTextEmbedding3LargeRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIVectorizerTextEmbedding3LargeRequest))]
#endif
        public bool IsOpenAIVectorizerTextEmbedding3LargeRequest => OpenAIVectorizerTextEmbedding3LargeRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenAIVectorizerTextEmbedding3LargeRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest? value)
        {
            value = OpenAIVectorizerTextEmbedding3LargeRequest;
            return IsOpenAIVectorizerTextEmbedding3LargeRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest PickOpenAIVectorizerTextEmbedding3LargeRequest() => IsOpenAIVectorizerTextEmbedding3LargeRequest
            ? OpenAIVectorizerTextEmbedding3LargeRequest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIVectorizerTextEmbedding3LargeRequest' but the value was {ToString()}.");

        /// <summary>
        /// OpenAI vectorizer for text-embedding-ada-002.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request? OpenAIVectorizerTextEmbeddingAda002Request { get; init; }
#else
        public global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request? OpenAIVectorizerTextEmbeddingAda002Request { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIVectorizerTextEmbeddingAda002Request))]
#endif
        public bool IsOpenAIVectorizerTextEmbeddingAda002Request => OpenAIVectorizerTextEmbeddingAda002Request != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenAIVectorizerTextEmbeddingAda002Request(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request? value)
        {
            value = OpenAIVectorizerTextEmbeddingAda002Request;
            return IsOpenAIVectorizerTextEmbeddingAda002Request;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request PickOpenAIVectorizerTextEmbeddingAda002Request() => IsOpenAIVectorizerTextEmbeddingAda002Request
            ? OpenAIVectorizerTextEmbeddingAda002Request!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIVectorizerTextEmbeddingAda002Request' but the value was {ToString()}.");

        /// <summary>
        /// Basic vectorizer for intfloat/multilingual-e5-large.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest? BasicVectorizerIntfloatMultilingualE5LargeRequest { get; init; }
#else
        public global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest? BasicVectorizerIntfloatMultilingualE5LargeRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BasicVectorizerIntfloatMultilingualE5LargeRequest))]
#endif
        public bool IsBasicVectorizerIntfloatMultilingualE5LargeRequest => BasicVectorizerIntfloatMultilingualE5LargeRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBasicVectorizerIntfloatMultilingualE5LargeRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest? value)
        {
            value = BasicVectorizerIntfloatMultilingualE5LargeRequest;
            return IsBasicVectorizerIntfloatMultilingualE5LargeRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest PickBasicVectorizerIntfloatMultilingualE5LargeRequest() => IsBasicVectorizerIntfloatMultilingualE5LargeRequest
            ? BasicVectorizerIntfloatMultilingualE5LargeRequest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BasicVectorizerIntfloatMultilingualE5LargeRequest' but the value was {ToString()}.");

        /// <summary>
        /// Basic vectorizer for sentence-transformers/multi-qa-mpnet-base-cos-v1.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request? BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request { get; init; }
#else
        public global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request? BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request))]
#endif
        public bool IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request => BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request? value)
        {
            value = BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request;
            return IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request PickBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request() => IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request
            ? BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request' but the value was {ToString()}.");

        /// <summary>
        /// Basic vectorizer for sentence-transformers/multi-qa-mpnet-base-dot-v1.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request? BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request { get; init; }
#else
        public global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request? BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request))]
#endif
        public bool IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request => BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request? value)
        {
            value = BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request;
            return IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request PickBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request() => IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request
            ? BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request' but the value was {ToString()}.");

        /// <summary>
        /// Vectorizer for hkunlp/instructor-xl.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.HkunlpInstructorXlVectorizerRequest? HkunlpInstructorXlVectorizerRequest { get; init; }
#else
        public global::Vellum.HkunlpInstructorXlVectorizerRequest? HkunlpInstructorXlVectorizerRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HkunlpInstructorXlVectorizerRequest))]
#endif
        public bool IsHkunlpInstructorXlVectorizerRequest => HkunlpInstructorXlVectorizerRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickHkunlpInstructorXlVectorizerRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.HkunlpInstructorXlVectorizerRequest? value)
        {
            value = HkunlpInstructorXlVectorizerRequest;
            return IsHkunlpInstructorXlVectorizerRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.HkunlpInstructorXlVectorizerRequest PickHkunlpInstructorXlVectorizerRequest() => IsHkunlpInstructorXlVectorizerRequest
            ? HkunlpInstructorXlVectorizerRequest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'HkunlpInstructorXlVectorizerRequest' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request? GoogleVertexAIVectorizerTextEmbedding004Request { get; init; }
#else
        public global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request? GoogleVertexAIVectorizerTextEmbedding004Request { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleVertexAIVectorizerTextEmbedding004Request))]
#endif
        public bool IsGoogleVertexAIVectorizerTextEmbedding004Request => GoogleVertexAIVectorizerTextEmbedding004Request != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGoogleVertexAIVectorizerTextEmbedding004Request(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request? value)
        {
            value = GoogleVertexAIVectorizerTextEmbedding004Request;
            return IsGoogleVertexAIVectorizerTextEmbedding004Request;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request PickGoogleVertexAIVectorizerTextEmbedding004Request() => IsGoogleVertexAIVectorizerTextEmbedding004Request
            ? GoogleVertexAIVectorizerTextEmbedding004Request!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleVertexAIVectorizerTextEmbedding004Request' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request? GoogleVertexAIVectorizerTextMultilingualEmbedding002Request { get; init; }
#else
        public global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request? GoogleVertexAIVectorizerTextMultilingualEmbedding002Request { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleVertexAIVectorizerTextMultilingualEmbedding002Request))]
#endif
        public bool IsGoogleVertexAIVectorizerTextMultilingualEmbedding002Request => GoogleVertexAIVectorizerTextMultilingualEmbedding002Request != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGoogleVertexAIVectorizerTextMultilingualEmbedding002Request(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request? value)
        {
            value = GoogleVertexAIVectorizerTextMultilingualEmbedding002Request;
            return IsGoogleVertexAIVectorizerTextMultilingualEmbedding002Request;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request PickGoogleVertexAIVectorizerTextMultilingualEmbedding002Request() => IsGoogleVertexAIVectorizerTextMultilingualEmbedding002Request
            ? GoogleVertexAIVectorizerTextMultilingualEmbedding002Request!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleVertexAIVectorizerTextMultilingualEmbedding002Request' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request? GoogleVertexAIVectorizerGeminiEmbedding001Request { get; init; }
#else
        public global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request? GoogleVertexAIVectorizerGeminiEmbedding001Request { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleVertexAIVectorizerGeminiEmbedding001Request))]
#endif
        public bool IsGoogleVertexAIVectorizerGeminiEmbedding001Request => GoogleVertexAIVectorizerGeminiEmbedding001Request != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGoogleVertexAIVectorizerGeminiEmbedding001Request(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request? value)
        {
            value = GoogleVertexAIVectorizerGeminiEmbedding001Request;
            return IsGoogleVertexAIVectorizerGeminiEmbedding001Request;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request PickGoogleVertexAIVectorizerGeminiEmbedding001Request() => IsGoogleVertexAIVectorizerGeminiEmbedding001Request
            ? GoogleVertexAIVectorizerGeminiEmbedding001Request!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleVertexAIVectorizerGeminiEmbedding001Request' but the value was {ToString()}.");

        /// <summary>
        /// FastEmbed vectorizer for BAAI/bge-small-en-v1.5.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request? FastEmbedVectorizerBAAIBgeSmallEnV15Request { get; init; }
#else
        public global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request? FastEmbedVectorizerBAAIBgeSmallEnV15Request { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FastEmbedVectorizerBAAIBgeSmallEnV15Request))]
#endif
        public bool IsFastEmbedVectorizerBAAIBgeSmallEnV15Request => FastEmbedVectorizerBAAIBgeSmallEnV15Request != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFastEmbedVectorizerBAAIBgeSmallEnV15Request(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request? value)
        {
            value = FastEmbedVectorizerBAAIBgeSmallEnV15Request;
            return IsFastEmbedVectorizerBAAIBgeSmallEnV15Request;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request PickFastEmbedVectorizerBAAIBgeSmallEnV15Request() => IsFastEmbedVectorizerBAAIBgeSmallEnV15Request
            ? FastEmbedVectorizerBAAIBgeSmallEnV15Request!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FastEmbedVectorizerBAAIBgeSmallEnV15Request' but the value was {ToString()}.");

        /// <summary>
        /// Serializer for private vectorizer.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.PrivateVectorizerRequest? PrivateVectorizerRequest { get; init; }
#else
        public global::Vellum.PrivateVectorizerRequest? PrivateVectorizerRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PrivateVectorizerRequest))]
#endif
        public bool IsPrivateVectorizerRequest => PrivateVectorizerRequest != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPrivateVectorizerRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.PrivateVectorizerRequest? value)
        {
            value = PrivateVectorizerRequest;
            return IsPrivateVectorizerRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Vellum.PrivateVectorizerRequest PickPrivateVectorizerRequest() => IsPrivateVectorizerRequest
            ? PrivateVectorizerRequest!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PrivateVectorizerRequest' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizerRequest(global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest value) => new IndexingConfigVectorizerRequest((global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest?(IndexingConfigVectorizerRequest @this) => @this.OpenAIVectorizerTextEmbedding3SmallRequest;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizerRequest(global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest? value)
        {
            OpenAIVectorizerTextEmbedding3SmallRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IndexingConfigVectorizerRequest FromOpenAIVectorizerTextEmbedding3SmallRequest(global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest? value) => new IndexingConfigVectorizerRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizerRequest(global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest value) => new IndexingConfigVectorizerRequest((global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest?(IndexingConfigVectorizerRequest @this) => @this.OpenAIVectorizerTextEmbedding3LargeRequest;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizerRequest(global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest? value)
        {
            OpenAIVectorizerTextEmbedding3LargeRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IndexingConfigVectorizerRequest FromOpenAIVectorizerTextEmbedding3LargeRequest(global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest? value) => new IndexingConfigVectorizerRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizerRequest(global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request value) => new IndexingConfigVectorizerRequest((global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request?(IndexingConfigVectorizerRequest @this) => @this.OpenAIVectorizerTextEmbeddingAda002Request;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizerRequest(global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request? value)
        {
            OpenAIVectorizerTextEmbeddingAda002Request = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IndexingConfigVectorizerRequest FromOpenAIVectorizerTextEmbeddingAda002Request(global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request? value) => new IndexingConfigVectorizerRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizerRequest(global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest value) => new IndexingConfigVectorizerRequest((global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest?(IndexingConfigVectorizerRequest @this) => @this.BasicVectorizerIntfloatMultilingualE5LargeRequest;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizerRequest(global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest? value)
        {
            BasicVectorizerIntfloatMultilingualE5LargeRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IndexingConfigVectorizerRequest FromBasicVectorizerIntfloatMultilingualE5LargeRequest(global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest? value) => new IndexingConfigVectorizerRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizerRequest(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request value) => new IndexingConfigVectorizerRequest((global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request?(IndexingConfigVectorizerRequest @this) => @this.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizerRequest(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request? value)
        {
            BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IndexingConfigVectorizerRequest FromBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request? value) => new IndexingConfigVectorizerRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizerRequest(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request value) => new IndexingConfigVectorizerRequest((global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request?(IndexingConfigVectorizerRequest @this) => @this.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizerRequest(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request? value)
        {
            BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IndexingConfigVectorizerRequest FromBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request? value) => new IndexingConfigVectorizerRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizerRequest(global::Vellum.HkunlpInstructorXlVectorizerRequest value) => new IndexingConfigVectorizerRequest((global::Vellum.HkunlpInstructorXlVectorizerRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.HkunlpInstructorXlVectorizerRequest?(IndexingConfigVectorizerRequest @this) => @this.HkunlpInstructorXlVectorizerRequest;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizerRequest(global::Vellum.HkunlpInstructorXlVectorizerRequest? value)
        {
            HkunlpInstructorXlVectorizerRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IndexingConfigVectorizerRequest FromHkunlpInstructorXlVectorizerRequest(global::Vellum.HkunlpInstructorXlVectorizerRequest? value) => new IndexingConfigVectorizerRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizerRequest(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request value) => new IndexingConfigVectorizerRequest((global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request?(IndexingConfigVectorizerRequest @this) => @this.GoogleVertexAIVectorizerTextEmbedding004Request;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizerRequest(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request? value)
        {
            GoogleVertexAIVectorizerTextEmbedding004Request = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IndexingConfigVectorizerRequest FromGoogleVertexAIVectorizerTextEmbedding004Request(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request? value) => new IndexingConfigVectorizerRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizerRequest(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request value) => new IndexingConfigVectorizerRequest((global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request?(IndexingConfigVectorizerRequest @this) => @this.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizerRequest(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request? value)
        {
            GoogleVertexAIVectorizerTextMultilingualEmbedding002Request = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IndexingConfigVectorizerRequest FromGoogleVertexAIVectorizerTextMultilingualEmbedding002Request(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request? value) => new IndexingConfigVectorizerRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizerRequest(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request value) => new IndexingConfigVectorizerRequest((global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request?(IndexingConfigVectorizerRequest @this) => @this.GoogleVertexAIVectorizerGeminiEmbedding001Request;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizerRequest(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request? value)
        {
            GoogleVertexAIVectorizerGeminiEmbedding001Request = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IndexingConfigVectorizerRequest FromGoogleVertexAIVectorizerGeminiEmbedding001Request(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request? value) => new IndexingConfigVectorizerRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizerRequest(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request value) => new IndexingConfigVectorizerRequest((global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request?(IndexingConfigVectorizerRequest @this) => @this.FastEmbedVectorizerBAAIBgeSmallEnV15Request;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizerRequest(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request? value)
        {
            FastEmbedVectorizerBAAIBgeSmallEnV15Request = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IndexingConfigVectorizerRequest FromFastEmbedVectorizerBAAIBgeSmallEnV15Request(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request? value) => new IndexingConfigVectorizerRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizerRequest(global::Vellum.PrivateVectorizerRequest value) => new IndexingConfigVectorizerRequest((global::Vellum.PrivateVectorizerRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.PrivateVectorizerRequest?(IndexingConfigVectorizerRequest @this) => @this.PrivateVectorizerRequest;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizerRequest(global::Vellum.PrivateVectorizerRequest? value)
        {
            PrivateVectorizerRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IndexingConfigVectorizerRequest FromPrivateVectorizerRequest(global::Vellum.PrivateVectorizerRequest? value) => new IndexingConfigVectorizerRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizerRequest(
            global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest? openAIVectorizerTextEmbedding3SmallRequest,
            global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest? openAIVectorizerTextEmbedding3LargeRequest,
            global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request? openAIVectorizerTextEmbeddingAda002Request,
            global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest? basicVectorizerIntfloatMultilingualE5LargeRequest,
            global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request? basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request,
            global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request? basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request,
            global::Vellum.HkunlpInstructorXlVectorizerRequest? hkunlpInstructorXlVectorizerRequest,
            global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request? googleVertexAIVectorizerTextEmbedding004Request,
            global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request? googleVertexAIVectorizerTextMultilingualEmbedding002Request,
            global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request? googleVertexAIVectorizerGeminiEmbedding001Request,
            global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request? fastEmbedVectorizerBAAIBgeSmallEnV15Request,
            global::Vellum.PrivateVectorizerRequest? privateVectorizerRequest
            )
        {
            OpenAIVectorizerTextEmbedding3SmallRequest = openAIVectorizerTextEmbedding3SmallRequest;
            OpenAIVectorizerTextEmbedding3LargeRequest = openAIVectorizerTextEmbedding3LargeRequest;
            OpenAIVectorizerTextEmbeddingAda002Request = openAIVectorizerTextEmbeddingAda002Request;
            BasicVectorizerIntfloatMultilingualE5LargeRequest = basicVectorizerIntfloatMultilingualE5LargeRequest;
            BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request = basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request;
            BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request = basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request;
            HkunlpInstructorXlVectorizerRequest = hkunlpInstructorXlVectorizerRequest;
            GoogleVertexAIVectorizerTextEmbedding004Request = googleVertexAIVectorizerTextEmbedding004Request;
            GoogleVertexAIVectorizerTextMultilingualEmbedding002Request = googleVertexAIVectorizerTextMultilingualEmbedding002Request;
            GoogleVertexAIVectorizerGeminiEmbedding001Request = googleVertexAIVectorizerGeminiEmbedding001Request;
            FastEmbedVectorizerBAAIBgeSmallEnV15Request = fastEmbedVectorizerBAAIBgeSmallEnV15Request;
            PrivateVectorizerRequest = privateVectorizerRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PrivateVectorizerRequest as object ??
            FastEmbedVectorizerBAAIBgeSmallEnV15Request as object ??
            GoogleVertexAIVectorizerGeminiEmbedding001Request as object ??
            GoogleVertexAIVectorizerTextMultilingualEmbedding002Request as object ??
            GoogleVertexAIVectorizerTextEmbedding004Request as object ??
            HkunlpInstructorXlVectorizerRequest as object ??
            BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request as object ??
            BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request as object ??
            BasicVectorizerIntfloatMultilingualE5LargeRequest as object ??
            OpenAIVectorizerTextEmbeddingAda002Request as object ??
            OpenAIVectorizerTextEmbedding3LargeRequest as object ??
            OpenAIVectorizerTextEmbedding3SmallRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenAIVectorizerTextEmbedding3SmallRequest?.ToString() ??
            OpenAIVectorizerTextEmbedding3LargeRequest?.ToString() ??
            OpenAIVectorizerTextEmbeddingAda002Request?.ToString() ??
            BasicVectorizerIntfloatMultilingualE5LargeRequest?.ToString() ??
            BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request?.ToString() ??
            BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request?.ToString() ??
            HkunlpInstructorXlVectorizerRequest?.ToString() ??
            GoogleVertexAIVectorizerTextEmbedding004Request?.ToString() ??
            GoogleVertexAIVectorizerTextMultilingualEmbedding002Request?.ToString() ??
            GoogleVertexAIVectorizerGeminiEmbedding001Request?.ToString() ??
            FastEmbedVectorizerBAAIBgeSmallEnV15Request?.ToString() ??
            PrivateVectorizerRequest?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIVectorizerTextEmbedding3SmallRequest && !IsOpenAIVectorizerTextEmbedding3LargeRequest && !IsOpenAIVectorizerTextEmbeddingAda002Request && !IsBasicVectorizerIntfloatMultilingualE5LargeRequest && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request && !IsHkunlpInstructorXlVectorizerRequest && !IsGoogleVertexAIVectorizerTextEmbedding004Request && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002Request && !IsGoogleVertexAIVectorizerGeminiEmbedding001Request && !IsFastEmbedVectorizerBAAIBgeSmallEnV15Request && !IsPrivateVectorizerRequest || !IsOpenAIVectorizerTextEmbedding3SmallRequest && IsOpenAIVectorizerTextEmbedding3LargeRequest && !IsOpenAIVectorizerTextEmbeddingAda002Request && !IsBasicVectorizerIntfloatMultilingualE5LargeRequest && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request && !IsHkunlpInstructorXlVectorizerRequest && !IsGoogleVertexAIVectorizerTextEmbedding004Request && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002Request && !IsGoogleVertexAIVectorizerGeminiEmbedding001Request && !IsFastEmbedVectorizerBAAIBgeSmallEnV15Request && !IsPrivateVectorizerRequest || !IsOpenAIVectorizerTextEmbedding3SmallRequest && !IsOpenAIVectorizerTextEmbedding3LargeRequest && IsOpenAIVectorizerTextEmbeddingAda002Request && !IsBasicVectorizerIntfloatMultilingualE5LargeRequest && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request && !IsHkunlpInstructorXlVectorizerRequest && !IsGoogleVertexAIVectorizerTextEmbedding004Request && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002Request && !IsGoogleVertexAIVectorizerGeminiEmbedding001Request && !IsFastEmbedVectorizerBAAIBgeSmallEnV15Request && !IsPrivateVectorizerRequest || !IsOpenAIVectorizerTextEmbedding3SmallRequest && !IsOpenAIVectorizerTextEmbedding3LargeRequest && !IsOpenAIVectorizerTextEmbeddingAda002Request && IsBasicVectorizerIntfloatMultilingualE5LargeRequest && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request && !IsHkunlpInstructorXlVectorizerRequest && !IsGoogleVertexAIVectorizerTextEmbedding004Request && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002Request && !IsGoogleVertexAIVectorizerGeminiEmbedding001Request && !IsFastEmbedVectorizerBAAIBgeSmallEnV15Request && !IsPrivateVectorizerRequest || !IsOpenAIVectorizerTextEmbedding3SmallRequest && !IsOpenAIVectorizerTextEmbedding3LargeRequest && !IsOpenAIVectorizerTextEmbeddingAda002Request && !IsBasicVectorizerIntfloatMultilingualE5LargeRequest && IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request && !IsHkunlpInstructorXlVectorizerRequest && !IsGoogleVertexAIVectorizerTextEmbedding004Request && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002Request && !IsGoogleVertexAIVectorizerGeminiEmbedding001Request && !IsFastEmbedVectorizerBAAIBgeSmallEnV15Request && !IsPrivateVectorizerRequest || !IsOpenAIVectorizerTextEmbedding3SmallRequest && !IsOpenAIVectorizerTextEmbedding3LargeRequest && !IsOpenAIVectorizerTextEmbeddingAda002Request && !IsBasicVectorizerIntfloatMultilingualE5LargeRequest && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request && IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request && !IsHkunlpInstructorXlVectorizerRequest && !IsGoogleVertexAIVectorizerTextEmbedding004Request && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002Request && !IsGoogleVertexAIVectorizerGeminiEmbedding001Request && !IsFastEmbedVectorizerBAAIBgeSmallEnV15Request && !IsPrivateVectorizerRequest || !IsOpenAIVectorizerTextEmbedding3SmallRequest && !IsOpenAIVectorizerTextEmbedding3LargeRequest && !IsOpenAIVectorizerTextEmbeddingAda002Request && !IsBasicVectorizerIntfloatMultilingualE5LargeRequest && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request && IsHkunlpInstructorXlVectorizerRequest && !IsGoogleVertexAIVectorizerTextEmbedding004Request && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002Request && !IsGoogleVertexAIVectorizerGeminiEmbedding001Request && !IsFastEmbedVectorizerBAAIBgeSmallEnV15Request && !IsPrivateVectorizerRequest || !IsOpenAIVectorizerTextEmbedding3SmallRequest && !IsOpenAIVectorizerTextEmbedding3LargeRequest && !IsOpenAIVectorizerTextEmbeddingAda002Request && !IsBasicVectorizerIntfloatMultilingualE5LargeRequest && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request && !IsHkunlpInstructorXlVectorizerRequest && IsGoogleVertexAIVectorizerTextEmbedding004Request && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002Request && !IsGoogleVertexAIVectorizerGeminiEmbedding001Request && !IsFastEmbedVectorizerBAAIBgeSmallEnV15Request && !IsPrivateVectorizerRequest || !IsOpenAIVectorizerTextEmbedding3SmallRequest && !IsOpenAIVectorizerTextEmbedding3LargeRequest && !IsOpenAIVectorizerTextEmbeddingAda002Request && !IsBasicVectorizerIntfloatMultilingualE5LargeRequest && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request && !IsHkunlpInstructorXlVectorizerRequest && !IsGoogleVertexAIVectorizerTextEmbedding004Request && IsGoogleVertexAIVectorizerTextMultilingualEmbedding002Request && !IsGoogleVertexAIVectorizerGeminiEmbedding001Request && !IsFastEmbedVectorizerBAAIBgeSmallEnV15Request && !IsPrivateVectorizerRequest || !IsOpenAIVectorizerTextEmbedding3SmallRequest && !IsOpenAIVectorizerTextEmbedding3LargeRequest && !IsOpenAIVectorizerTextEmbeddingAda002Request && !IsBasicVectorizerIntfloatMultilingualE5LargeRequest && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request && !IsHkunlpInstructorXlVectorizerRequest && !IsGoogleVertexAIVectorizerTextEmbedding004Request && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002Request && IsGoogleVertexAIVectorizerGeminiEmbedding001Request && !IsFastEmbedVectorizerBAAIBgeSmallEnV15Request && !IsPrivateVectorizerRequest || !IsOpenAIVectorizerTextEmbedding3SmallRequest && !IsOpenAIVectorizerTextEmbedding3LargeRequest && !IsOpenAIVectorizerTextEmbeddingAda002Request && !IsBasicVectorizerIntfloatMultilingualE5LargeRequest && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request && !IsHkunlpInstructorXlVectorizerRequest && !IsGoogleVertexAIVectorizerTextEmbedding004Request && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002Request && !IsGoogleVertexAIVectorizerGeminiEmbedding001Request && IsFastEmbedVectorizerBAAIBgeSmallEnV15Request && !IsPrivateVectorizerRequest || !IsOpenAIVectorizerTextEmbedding3SmallRequest && !IsOpenAIVectorizerTextEmbedding3LargeRequest && !IsOpenAIVectorizerTextEmbeddingAda002Request && !IsBasicVectorizerIntfloatMultilingualE5LargeRequest && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request && !IsHkunlpInstructorXlVectorizerRequest && !IsGoogleVertexAIVectorizerTextEmbedding004Request && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002Request && !IsGoogleVertexAIVectorizerGeminiEmbedding001Request && !IsFastEmbedVectorizerBAAIBgeSmallEnV15Request && IsPrivateVectorizerRequest;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest, TResult>? openAIVectorizerTextEmbedding3SmallRequest = null,
            global::System.Func<global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest, TResult>? openAIVectorizerTextEmbedding3LargeRequest = null,
            global::System.Func<global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request, TResult>? openAIVectorizerTextEmbeddingAda002Request = null,
            global::System.Func<global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest, TResult>? basicVectorizerIntfloatMultilingualE5LargeRequest = null,
            global::System.Func<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request, TResult>? basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request = null,
            global::System.Func<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request, TResult>? basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request = null,
            global::System.Func<global::Vellum.HkunlpInstructorXlVectorizerRequest, TResult>? hkunlpInstructorXlVectorizerRequest = null,
            global::System.Func<global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request, TResult>? googleVertexAIVectorizerTextEmbedding004Request = null,
            global::System.Func<global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request, TResult>? googleVertexAIVectorizerTextMultilingualEmbedding002Request = null,
            global::System.Func<global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request, TResult>? googleVertexAIVectorizerGeminiEmbedding001Request = null,
            global::System.Func<global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request, TResult>? fastEmbedVectorizerBAAIBgeSmallEnV15Request = null,
            global::System.Func<global::Vellum.PrivateVectorizerRequest, TResult>? privateVectorizerRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAIVectorizerTextEmbedding3SmallRequest && openAIVectorizerTextEmbedding3SmallRequest != null)
            {
                return openAIVectorizerTextEmbedding3SmallRequest(OpenAIVectorizerTextEmbedding3SmallRequest!);
            }
            else if (IsOpenAIVectorizerTextEmbedding3LargeRequest && openAIVectorizerTextEmbedding3LargeRequest != null)
            {
                return openAIVectorizerTextEmbedding3LargeRequest(OpenAIVectorizerTextEmbedding3LargeRequest!);
            }
            else if (IsOpenAIVectorizerTextEmbeddingAda002Request && openAIVectorizerTextEmbeddingAda002Request != null)
            {
                return openAIVectorizerTextEmbeddingAda002Request(OpenAIVectorizerTextEmbeddingAda002Request!);
            }
            else if (IsBasicVectorizerIntfloatMultilingualE5LargeRequest && basicVectorizerIntfloatMultilingualE5LargeRequest != null)
            {
                return basicVectorizerIntfloatMultilingualE5LargeRequest(BasicVectorizerIntfloatMultilingualE5LargeRequest!);
            }
            else if (IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request && basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request != null)
            {
                return basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request(BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request!);
            }
            else if (IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request && basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request != null)
            {
                return basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request(BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request!);
            }
            else if (IsHkunlpInstructorXlVectorizerRequest && hkunlpInstructorXlVectorizerRequest != null)
            {
                return hkunlpInstructorXlVectorizerRequest(HkunlpInstructorXlVectorizerRequest!);
            }
            else if (IsGoogleVertexAIVectorizerTextEmbedding004Request && googleVertexAIVectorizerTextEmbedding004Request != null)
            {
                return googleVertexAIVectorizerTextEmbedding004Request(GoogleVertexAIVectorizerTextEmbedding004Request!);
            }
            else if (IsGoogleVertexAIVectorizerTextMultilingualEmbedding002Request && googleVertexAIVectorizerTextMultilingualEmbedding002Request != null)
            {
                return googleVertexAIVectorizerTextMultilingualEmbedding002Request(GoogleVertexAIVectorizerTextMultilingualEmbedding002Request!);
            }
            else if (IsGoogleVertexAIVectorizerGeminiEmbedding001Request && googleVertexAIVectorizerGeminiEmbedding001Request != null)
            {
                return googleVertexAIVectorizerGeminiEmbedding001Request(GoogleVertexAIVectorizerGeminiEmbedding001Request!);
            }
            else if (IsFastEmbedVectorizerBAAIBgeSmallEnV15Request && fastEmbedVectorizerBAAIBgeSmallEnV15Request != null)
            {
                return fastEmbedVectorizerBAAIBgeSmallEnV15Request(FastEmbedVectorizerBAAIBgeSmallEnV15Request!);
            }
            else if (IsPrivateVectorizerRequest && privateVectorizerRequest != null)
            {
                return privateVectorizerRequest(PrivateVectorizerRequest!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest>? openAIVectorizerTextEmbedding3SmallRequest = null,

            global::System.Action<global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest>? openAIVectorizerTextEmbedding3LargeRequest = null,

            global::System.Action<global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request>? openAIVectorizerTextEmbeddingAda002Request = null,

            global::System.Action<global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest>? basicVectorizerIntfloatMultilingualE5LargeRequest = null,

            global::System.Action<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request>? basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request = null,

            global::System.Action<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request>? basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request = null,

            global::System.Action<global::Vellum.HkunlpInstructorXlVectorizerRequest>? hkunlpInstructorXlVectorizerRequest = null,

            global::System.Action<global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request>? googleVertexAIVectorizerTextEmbedding004Request = null,

            global::System.Action<global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request>? googleVertexAIVectorizerTextMultilingualEmbedding002Request = null,

            global::System.Action<global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request>? googleVertexAIVectorizerGeminiEmbedding001Request = null,

            global::System.Action<global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request>? fastEmbedVectorizerBAAIBgeSmallEnV15Request = null,

            global::System.Action<global::Vellum.PrivateVectorizerRequest>? privateVectorizerRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAIVectorizerTextEmbedding3SmallRequest)
            {
                openAIVectorizerTextEmbedding3SmallRequest?.Invoke(OpenAIVectorizerTextEmbedding3SmallRequest!);
            }
            else if (IsOpenAIVectorizerTextEmbedding3LargeRequest)
            {
                openAIVectorizerTextEmbedding3LargeRequest?.Invoke(OpenAIVectorizerTextEmbedding3LargeRequest!);
            }
            else if (IsOpenAIVectorizerTextEmbeddingAda002Request)
            {
                openAIVectorizerTextEmbeddingAda002Request?.Invoke(OpenAIVectorizerTextEmbeddingAda002Request!);
            }
            else if (IsBasicVectorizerIntfloatMultilingualE5LargeRequest)
            {
                basicVectorizerIntfloatMultilingualE5LargeRequest?.Invoke(BasicVectorizerIntfloatMultilingualE5LargeRequest!);
            }
            else if (IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request)
            {
                basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request?.Invoke(BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request!);
            }
            else if (IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request)
            {
                basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request?.Invoke(BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request!);
            }
            else if (IsHkunlpInstructorXlVectorizerRequest)
            {
                hkunlpInstructorXlVectorizerRequest?.Invoke(HkunlpInstructorXlVectorizerRequest!);
            }
            else if (IsGoogleVertexAIVectorizerTextEmbedding004Request)
            {
                googleVertexAIVectorizerTextEmbedding004Request?.Invoke(GoogleVertexAIVectorizerTextEmbedding004Request!);
            }
            else if (IsGoogleVertexAIVectorizerTextMultilingualEmbedding002Request)
            {
                googleVertexAIVectorizerTextMultilingualEmbedding002Request?.Invoke(GoogleVertexAIVectorizerTextMultilingualEmbedding002Request!);
            }
            else if (IsGoogleVertexAIVectorizerGeminiEmbedding001Request)
            {
                googleVertexAIVectorizerGeminiEmbedding001Request?.Invoke(GoogleVertexAIVectorizerGeminiEmbedding001Request!);
            }
            else if (IsFastEmbedVectorizerBAAIBgeSmallEnV15Request)
            {
                fastEmbedVectorizerBAAIBgeSmallEnV15Request?.Invoke(FastEmbedVectorizerBAAIBgeSmallEnV15Request!);
            }
            else if (IsPrivateVectorizerRequest)
            {
                privateVectorizerRequest?.Invoke(PrivateVectorizerRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest>? openAIVectorizerTextEmbedding3SmallRequest = null,
            global::System.Action<global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest>? openAIVectorizerTextEmbedding3LargeRequest = null,
            global::System.Action<global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request>? openAIVectorizerTextEmbeddingAda002Request = null,
            global::System.Action<global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest>? basicVectorizerIntfloatMultilingualE5LargeRequest = null,
            global::System.Action<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request>? basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request = null,
            global::System.Action<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request>? basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request = null,
            global::System.Action<global::Vellum.HkunlpInstructorXlVectorizerRequest>? hkunlpInstructorXlVectorizerRequest = null,
            global::System.Action<global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request>? googleVertexAIVectorizerTextEmbedding004Request = null,
            global::System.Action<global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request>? googleVertexAIVectorizerTextMultilingualEmbedding002Request = null,
            global::System.Action<global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request>? googleVertexAIVectorizerGeminiEmbedding001Request = null,
            global::System.Action<global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request>? fastEmbedVectorizerBAAIBgeSmallEnV15Request = null,
            global::System.Action<global::Vellum.PrivateVectorizerRequest>? privateVectorizerRequest = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAIVectorizerTextEmbedding3SmallRequest)
            {
                openAIVectorizerTextEmbedding3SmallRequest?.Invoke(OpenAIVectorizerTextEmbedding3SmallRequest!);
            }
            else if (IsOpenAIVectorizerTextEmbedding3LargeRequest)
            {
                openAIVectorizerTextEmbedding3LargeRequest?.Invoke(OpenAIVectorizerTextEmbedding3LargeRequest!);
            }
            else if (IsOpenAIVectorizerTextEmbeddingAda002Request)
            {
                openAIVectorizerTextEmbeddingAda002Request?.Invoke(OpenAIVectorizerTextEmbeddingAda002Request!);
            }
            else if (IsBasicVectorizerIntfloatMultilingualE5LargeRequest)
            {
                basicVectorizerIntfloatMultilingualE5LargeRequest?.Invoke(BasicVectorizerIntfloatMultilingualE5LargeRequest!);
            }
            else if (IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request)
            {
                basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request?.Invoke(BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request!);
            }
            else if (IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request)
            {
                basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request?.Invoke(BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request!);
            }
            else if (IsHkunlpInstructorXlVectorizerRequest)
            {
                hkunlpInstructorXlVectorizerRequest?.Invoke(HkunlpInstructorXlVectorizerRequest!);
            }
            else if (IsGoogleVertexAIVectorizerTextEmbedding004Request)
            {
                googleVertexAIVectorizerTextEmbedding004Request?.Invoke(GoogleVertexAIVectorizerTextEmbedding004Request!);
            }
            else if (IsGoogleVertexAIVectorizerTextMultilingualEmbedding002Request)
            {
                googleVertexAIVectorizerTextMultilingualEmbedding002Request?.Invoke(GoogleVertexAIVectorizerTextMultilingualEmbedding002Request!);
            }
            else if (IsGoogleVertexAIVectorizerGeminiEmbedding001Request)
            {
                googleVertexAIVectorizerGeminiEmbedding001Request?.Invoke(GoogleVertexAIVectorizerGeminiEmbedding001Request!);
            }
            else if (IsFastEmbedVectorizerBAAIBgeSmallEnV15Request)
            {
                fastEmbedVectorizerBAAIBgeSmallEnV15Request?.Invoke(FastEmbedVectorizerBAAIBgeSmallEnV15Request!);
            }
            else if (IsPrivateVectorizerRequest)
            {
                privateVectorizerRequest?.Invoke(PrivateVectorizerRequest!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenAIVectorizerTextEmbedding3SmallRequest,
                typeof(global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest),
                OpenAIVectorizerTextEmbedding3LargeRequest,
                typeof(global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest),
                OpenAIVectorizerTextEmbeddingAda002Request,
                typeof(global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request),
                BasicVectorizerIntfloatMultilingualE5LargeRequest,
                typeof(global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest),
                BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request,
                typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request),
                BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request,
                typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request),
                HkunlpInstructorXlVectorizerRequest,
                typeof(global::Vellum.HkunlpInstructorXlVectorizerRequest),
                GoogleVertexAIVectorizerTextEmbedding004Request,
                typeof(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request),
                GoogleVertexAIVectorizerTextMultilingualEmbedding002Request,
                typeof(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request),
                GoogleVertexAIVectorizerGeminiEmbedding001Request,
                typeof(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request),
                FastEmbedVectorizerBAAIBgeSmallEnV15Request,
                typeof(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request),
                PrivateVectorizerRequest,
                typeof(global::Vellum.PrivateVectorizerRequest),
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
        public bool Equals(IndexingConfigVectorizerRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest?>.Default.Equals(OpenAIVectorizerTextEmbedding3SmallRequest, other.OpenAIVectorizerTextEmbedding3SmallRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest?>.Default.Equals(OpenAIVectorizerTextEmbedding3LargeRequest, other.OpenAIVectorizerTextEmbedding3LargeRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request?>.Default.Equals(OpenAIVectorizerTextEmbeddingAda002Request, other.OpenAIVectorizerTextEmbeddingAda002Request) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest?>.Default.Equals(BasicVectorizerIntfloatMultilingualE5LargeRequest, other.BasicVectorizerIntfloatMultilingualE5LargeRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request?>.Default.Equals(BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request, other.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request?>.Default.Equals(BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request, other.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.HkunlpInstructorXlVectorizerRequest?>.Default.Equals(HkunlpInstructorXlVectorizerRequest, other.HkunlpInstructorXlVectorizerRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request?>.Default.Equals(GoogleVertexAIVectorizerTextEmbedding004Request, other.GoogleVertexAIVectorizerTextEmbedding004Request) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request?>.Default.Equals(GoogleVertexAIVectorizerTextMultilingualEmbedding002Request, other.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request?>.Default.Equals(GoogleVertexAIVectorizerGeminiEmbedding001Request, other.GoogleVertexAIVectorizerGeminiEmbedding001Request) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request?>.Default.Equals(FastEmbedVectorizerBAAIBgeSmallEnV15Request, other.FastEmbedVectorizerBAAIBgeSmallEnV15Request) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.PrivateVectorizerRequest?>.Default.Equals(PrivateVectorizerRequest, other.PrivateVectorizerRequest) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IndexingConfigVectorizerRequest obj1, IndexingConfigVectorizerRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IndexingConfigVectorizerRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IndexingConfigVectorizerRequest obj1, IndexingConfigVectorizerRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IndexingConfigVectorizerRequest o && Equals(o);
        }
    }
}
