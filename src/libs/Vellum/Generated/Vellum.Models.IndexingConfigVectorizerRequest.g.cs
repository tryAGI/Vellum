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
            global::System.Func<global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest?, TResult>? openAIVectorizerTextEmbedding3SmallRequest = null,
            global::System.Func<global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest?, TResult>? openAIVectorizerTextEmbedding3LargeRequest = null,
            global::System.Func<global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request?, TResult>? openAIVectorizerTextEmbeddingAda002Request = null,
            global::System.Func<global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest?, TResult>? basicVectorizerIntfloatMultilingualE5LargeRequest = null,
            global::System.Func<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request?, TResult>? basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request = null,
            global::System.Func<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request?, TResult>? basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request = null,
            global::System.Func<global::Vellum.HkunlpInstructorXlVectorizerRequest?, TResult>? hkunlpInstructorXlVectorizerRequest = null,
            global::System.Func<global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request?, TResult>? googleVertexAIVectorizerTextEmbedding004Request = null,
            global::System.Func<global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request?, TResult>? googleVertexAIVectorizerTextMultilingualEmbedding002Request = null,
            global::System.Func<global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request?, TResult>? googleVertexAIVectorizerGeminiEmbedding001Request = null,
            global::System.Func<global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request?, TResult>? fastEmbedVectorizerBAAIBgeSmallEnV15Request = null,
            global::System.Func<global::Vellum.PrivateVectorizerRequest?, TResult>? privateVectorizerRequest = null,
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
            global::System.Action<global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest?>? openAIVectorizerTextEmbedding3SmallRequest = null,
            global::System.Action<global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest?>? openAIVectorizerTextEmbedding3LargeRequest = null,
            global::System.Action<global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request?>? openAIVectorizerTextEmbeddingAda002Request = null,
            global::System.Action<global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest?>? basicVectorizerIntfloatMultilingualE5LargeRequest = null,
            global::System.Action<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request?>? basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request = null,
            global::System.Action<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request?>? basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request = null,
            global::System.Action<global::Vellum.HkunlpInstructorXlVectorizerRequest?>? hkunlpInstructorXlVectorizerRequest = null,
            global::System.Action<global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request?>? googleVertexAIVectorizerTextEmbedding004Request = null,
            global::System.Action<global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request?>? googleVertexAIVectorizerTextMultilingualEmbedding002Request = null,
            global::System.Action<global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request?>? googleVertexAIVectorizerGeminiEmbedding001Request = null,
            global::System.Action<global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request?>? fastEmbedVectorizerBAAIBgeSmallEnV15Request = null,
            global::System.Action<global::Vellum.PrivateVectorizerRequest?>? privateVectorizerRequest = null,
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
