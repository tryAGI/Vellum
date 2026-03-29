#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IndexingConfigVectorizer : global::System.IEquatable<IndexingConfigVectorizer>
    {
        /// <summary>
        /// OpenAI vectorizer for text-embedding-3-small.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.OpenAIVectorizerTextEmbedding3Small? OpenAIVectorizerTextEmbedding3Small { get; init; }
#else
        public global::Vellum.OpenAIVectorizerTextEmbedding3Small? OpenAIVectorizerTextEmbedding3Small { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIVectorizerTextEmbedding3Small))]
#endif
        public bool IsOpenAIVectorizerTextEmbedding3Small => OpenAIVectorizerTextEmbedding3Small != null;

        /// <summary>
        /// OpenAI vectorizer for text-embedding-3-large.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.OpenAIVectorizerTextEmbedding3Large? OpenAIVectorizerTextEmbedding3Large { get; init; }
#else
        public global::Vellum.OpenAIVectorizerTextEmbedding3Large? OpenAIVectorizerTextEmbedding3Large { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIVectorizerTextEmbedding3Large))]
#endif
        public bool IsOpenAIVectorizerTextEmbedding3Large => OpenAIVectorizerTextEmbedding3Large != null;

        /// <summary>
        /// OpenAI vectorizer for text-embedding-ada-002.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.OpenAIVectorizerTextEmbeddingAda002? OpenAIVectorizerTextEmbeddingAda002 { get; init; }
#else
        public global::Vellum.OpenAIVectorizerTextEmbeddingAda002? OpenAIVectorizerTextEmbeddingAda002 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIVectorizerTextEmbeddingAda002))]
#endif
        public bool IsOpenAIVectorizerTextEmbeddingAda002 => OpenAIVectorizerTextEmbeddingAda002 != null;

        /// <summary>
        /// Basic vectorizer for intfloat/multilingual-e5-large.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.BasicVectorizerIntfloatMultilingualE5Large? BasicVectorizerIntfloatMultilingualE5Large { get; init; }
#else
        public global::Vellum.BasicVectorizerIntfloatMultilingualE5Large? BasicVectorizerIntfloatMultilingualE5Large { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BasicVectorizerIntfloatMultilingualE5Large))]
#endif
        public bool IsBasicVectorizerIntfloatMultilingualE5Large => BasicVectorizerIntfloatMultilingualE5Large != null;

        /// <summary>
        /// Basic vectorizer for sentence-transformers/multi-qa-mpnet-base-cos-v1.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1? BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 { get; init; }
#else
        public global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1? BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1))]
#endif
        public bool IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 => BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 != null;

        /// <summary>
        /// Basic vectorizer for sentence-transformers/multi-qa-mpnet-base-dot-v1.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1? BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 { get; init; }
#else
        public global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1? BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1))]
#endif
        public bool IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 => BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 != null;

        /// <summary>
        /// Vectorizer for hkunlp/instructor-xl.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.HkunlpInstructorXlVectorizer? HkunlpInstructorXlVectorizer { get; init; }
#else
        public global::Vellum.HkunlpInstructorXlVectorizer? HkunlpInstructorXlVectorizer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HkunlpInstructorXlVectorizer))]
#endif
        public bool IsHkunlpInstructorXlVectorizer => HkunlpInstructorXlVectorizer != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.GoogleVertexAIVectorizerTextEmbedding004? GoogleVertexAIVectorizerTextEmbedding004 { get; init; }
#else
        public global::Vellum.GoogleVertexAIVectorizerTextEmbedding004? GoogleVertexAIVectorizerTextEmbedding004 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleVertexAIVectorizerTextEmbedding004))]
#endif
        public bool IsGoogleVertexAIVectorizerTextEmbedding004 => GoogleVertexAIVectorizerTextEmbedding004 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002? GoogleVertexAIVectorizerTextMultilingualEmbedding002 { get; init; }
#else
        public global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002? GoogleVertexAIVectorizerTextMultilingualEmbedding002 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleVertexAIVectorizerTextMultilingualEmbedding002))]
#endif
        public bool IsGoogleVertexAIVectorizerTextMultilingualEmbedding002 => GoogleVertexAIVectorizerTextMultilingualEmbedding002 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001? GoogleVertexAIVectorizerGeminiEmbedding001 { get; init; }
#else
        public global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001? GoogleVertexAIVectorizerGeminiEmbedding001 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleVertexAIVectorizerGeminiEmbedding001))]
#endif
        public bool IsGoogleVertexAIVectorizerGeminiEmbedding001 => GoogleVertexAIVectorizerGeminiEmbedding001 != null;

        /// <summary>
        /// FastEmbed vectorizer for BAAI/bge-small-en-v1.5.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15? FastEmbedVectorizerBAAIBgeSmallEnV15 { get; init; }
#else
        public global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15? FastEmbedVectorizerBAAIBgeSmallEnV15 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FastEmbedVectorizerBAAIBgeSmallEnV15))]
#endif
        public bool IsFastEmbedVectorizerBAAIBgeSmallEnV15 => FastEmbedVectorizerBAAIBgeSmallEnV15 != null;

        /// <summary>
        /// Serializer for private vectorizer.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.PrivateVectorizer? PrivateVectorizer { get; init; }
#else
        public global::Vellum.PrivateVectorizer? PrivateVectorizer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PrivateVectorizer))]
#endif
        public bool IsPrivateVectorizer => PrivateVectorizer != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizer(global::Vellum.OpenAIVectorizerTextEmbedding3Small value) => new IndexingConfigVectorizer((global::Vellum.OpenAIVectorizerTextEmbedding3Small?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.OpenAIVectorizerTextEmbedding3Small?(IndexingConfigVectorizer @this) => @this.OpenAIVectorizerTextEmbedding3Small;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizer(global::Vellum.OpenAIVectorizerTextEmbedding3Small? value)
        {
            OpenAIVectorizerTextEmbedding3Small = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizer(global::Vellum.OpenAIVectorizerTextEmbedding3Large value) => new IndexingConfigVectorizer((global::Vellum.OpenAIVectorizerTextEmbedding3Large?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.OpenAIVectorizerTextEmbedding3Large?(IndexingConfigVectorizer @this) => @this.OpenAIVectorizerTextEmbedding3Large;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizer(global::Vellum.OpenAIVectorizerTextEmbedding3Large? value)
        {
            OpenAIVectorizerTextEmbedding3Large = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizer(global::Vellum.OpenAIVectorizerTextEmbeddingAda002 value) => new IndexingConfigVectorizer((global::Vellum.OpenAIVectorizerTextEmbeddingAda002?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.OpenAIVectorizerTextEmbeddingAda002?(IndexingConfigVectorizer @this) => @this.OpenAIVectorizerTextEmbeddingAda002;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizer(global::Vellum.OpenAIVectorizerTextEmbeddingAda002? value)
        {
            OpenAIVectorizerTextEmbeddingAda002 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizer(global::Vellum.BasicVectorizerIntfloatMultilingualE5Large value) => new IndexingConfigVectorizer((global::Vellum.BasicVectorizerIntfloatMultilingualE5Large?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.BasicVectorizerIntfloatMultilingualE5Large?(IndexingConfigVectorizer @this) => @this.BasicVectorizerIntfloatMultilingualE5Large;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizer(global::Vellum.BasicVectorizerIntfloatMultilingualE5Large? value)
        {
            BasicVectorizerIntfloatMultilingualE5Large = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizer(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 value) => new IndexingConfigVectorizer((global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1?(IndexingConfigVectorizer @this) => @this.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizer(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1? value)
        {
            BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizer(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 value) => new IndexingConfigVectorizer((global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1?(IndexingConfigVectorizer @this) => @this.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizer(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1? value)
        {
            BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizer(global::Vellum.HkunlpInstructorXlVectorizer value) => new IndexingConfigVectorizer((global::Vellum.HkunlpInstructorXlVectorizer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.HkunlpInstructorXlVectorizer?(IndexingConfigVectorizer @this) => @this.HkunlpInstructorXlVectorizer;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizer(global::Vellum.HkunlpInstructorXlVectorizer? value)
        {
            HkunlpInstructorXlVectorizer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizer(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004 value) => new IndexingConfigVectorizer((global::Vellum.GoogleVertexAIVectorizerTextEmbedding004?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.GoogleVertexAIVectorizerTextEmbedding004?(IndexingConfigVectorizer @this) => @this.GoogleVertexAIVectorizerTextEmbedding004;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizer(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004? value)
        {
            GoogleVertexAIVectorizerTextEmbedding004 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizer(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002 value) => new IndexingConfigVectorizer((global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002?(IndexingConfigVectorizer @this) => @this.GoogleVertexAIVectorizerTextMultilingualEmbedding002;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizer(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002? value)
        {
            GoogleVertexAIVectorizerTextMultilingualEmbedding002 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizer(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001 value) => new IndexingConfigVectorizer((global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001?(IndexingConfigVectorizer @this) => @this.GoogleVertexAIVectorizerGeminiEmbedding001;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizer(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001? value)
        {
            GoogleVertexAIVectorizerGeminiEmbedding001 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizer(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15 value) => new IndexingConfigVectorizer((global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15?(IndexingConfigVectorizer @this) => @this.FastEmbedVectorizerBAAIBgeSmallEnV15;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizer(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15? value)
        {
            FastEmbedVectorizerBAAIBgeSmallEnV15 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IndexingConfigVectorizer(global::Vellum.PrivateVectorizer value) => new IndexingConfigVectorizer((global::Vellum.PrivateVectorizer?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.PrivateVectorizer?(IndexingConfigVectorizer @this) => @this.PrivateVectorizer;

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizer(global::Vellum.PrivateVectorizer? value)
        {
            PrivateVectorizer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public IndexingConfigVectorizer(
            global::Vellum.OpenAIVectorizerTextEmbedding3Small? openAIVectorizerTextEmbedding3Small,
            global::Vellum.OpenAIVectorizerTextEmbedding3Large? openAIVectorizerTextEmbedding3Large,
            global::Vellum.OpenAIVectorizerTextEmbeddingAda002? openAIVectorizerTextEmbeddingAda002,
            global::Vellum.BasicVectorizerIntfloatMultilingualE5Large? basicVectorizerIntfloatMultilingualE5Large,
            global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1? basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1,
            global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1? basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1,
            global::Vellum.HkunlpInstructorXlVectorizer? hkunlpInstructorXlVectorizer,
            global::Vellum.GoogleVertexAIVectorizerTextEmbedding004? googleVertexAIVectorizerTextEmbedding004,
            global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002? googleVertexAIVectorizerTextMultilingualEmbedding002,
            global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001? googleVertexAIVectorizerGeminiEmbedding001,
            global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15? fastEmbedVectorizerBAAIBgeSmallEnV15,
            global::Vellum.PrivateVectorizer? privateVectorizer
            )
        {
            OpenAIVectorizerTextEmbedding3Small = openAIVectorizerTextEmbedding3Small;
            OpenAIVectorizerTextEmbedding3Large = openAIVectorizerTextEmbedding3Large;
            OpenAIVectorizerTextEmbeddingAda002 = openAIVectorizerTextEmbeddingAda002;
            BasicVectorizerIntfloatMultilingualE5Large = basicVectorizerIntfloatMultilingualE5Large;
            BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 = basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1;
            BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 = basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1;
            HkunlpInstructorXlVectorizer = hkunlpInstructorXlVectorizer;
            GoogleVertexAIVectorizerTextEmbedding004 = googleVertexAIVectorizerTextEmbedding004;
            GoogleVertexAIVectorizerTextMultilingualEmbedding002 = googleVertexAIVectorizerTextMultilingualEmbedding002;
            GoogleVertexAIVectorizerGeminiEmbedding001 = googleVertexAIVectorizerGeminiEmbedding001;
            FastEmbedVectorizerBAAIBgeSmallEnV15 = fastEmbedVectorizerBAAIBgeSmallEnV15;
            PrivateVectorizer = privateVectorizer;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PrivateVectorizer as object ??
            FastEmbedVectorizerBAAIBgeSmallEnV15 as object ??
            GoogleVertexAIVectorizerGeminiEmbedding001 as object ??
            GoogleVertexAIVectorizerTextMultilingualEmbedding002 as object ??
            GoogleVertexAIVectorizerTextEmbedding004 as object ??
            HkunlpInstructorXlVectorizer as object ??
            BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 as object ??
            BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 as object ??
            BasicVectorizerIntfloatMultilingualE5Large as object ??
            OpenAIVectorizerTextEmbeddingAda002 as object ??
            OpenAIVectorizerTextEmbedding3Large as object ??
            OpenAIVectorizerTextEmbedding3Small as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenAIVectorizerTextEmbedding3Small?.ToString() ??
            OpenAIVectorizerTextEmbedding3Large?.ToString() ??
            OpenAIVectorizerTextEmbeddingAda002?.ToString() ??
            BasicVectorizerIntfloatMultilingualE5Large?.ToString() ??
            BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1?.ToString() ??
            BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1?.ToString() ??
            HkunlpInstructorXlVectorizer?.ToString() ??
            GoogleVertexAIVectorizerTextEmbedding004?.ToString() ??
            GoogleVertexAIVectorizerTextMultilingualEmbedding002?.ToString() ??
            GoogleVertexAIVectorizerGeminiEmbedding001?.ToString() ??
            FastEmbedVectorizerBAAIBgeSmallEnV15?.ToString() ??
            PrivateVectorizer?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIVectorizerTextEmbedding3Small && !IsOpenAIVectorizerTextEmbedding3Large && !IsOpenAIVectorizerTextEmbeddingAda002 && !IsBasicVectorizerIntfloatMultilingualE5Large && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 && !IsHkunlpInstructorXlVectorizer && !IsGoogleVertexAIVectorizerTextEmbedding004 && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002 && !IsGoogleVertexAIVectorizerGeminiEmbedding001 && !IsFastEmbedVectorizerBAAIBgeSmallEnV15 && !IsPrivateVectorizer || !IsOpenAIVectorizerTextEmbedding3Small && IsOpenAIVectorizerTextEmbedding3Large && !IsOpenAIVectorizerTextEmbeddingAda002 && !IsBasicVectorizerIntfloatMultilingualE5Large && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 && !IsHkunlpInstructorXlVectorizer && !IsGoogleVertexAIVectorizerTextEmbedding004 && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002 && !IsGoogleVertexAIVectorizerGeminiEmbedding001 && !IsFastEmbedVectorizerBAAIBgeSmallEnV15 && !IsPrivateVectorizer || !IsOpenAIVectorizerTextEmbedding3Small && !IsOpenAIVectorizerTextEmbedding3Large && IsOpenAIVectorizerTextEmbeddingAda002 && !IsBasicVectorizerIntfloatMultilingualE5Large && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 && !IsHkunlpInstructorXlVectorizer && !IsGoogleVertexAIVectorizerTextEmbedding004 && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002 && !IsGoogleVertexAIVectorizerGeminiEmbedding001 && !IsFastEmbedVectorizerBAAIBgeSmallEnV15 && !IsPrivateVectorizer || !IsOpenAIVectorizerTextEmbedding3Small && !IsOpenAIVectorizerTextEmbedding3Large && !IsOpenAIVectorizerTextEmbeddingAda002 && IsBasicVectorizerIntfloatMultilingualE5Large && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 && !IsHkunlpInstructorXlVectorizer && !IsGoogleVertexAIVectorizerTextEmbedding004 && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002 && !IsGoogleVertexAIVectorizerGeminiEmbedding001 && !IsFastEmbedVectorizerBAAIBgeSmallEnV15 && !IsPrivateVectorizer || !IsOpenAIVectorizerTextEmbedding3Small && !IsOpenAIVectorizerTextEmbedding3Large && !IsOpenAIVectorizerTextEmbeddingAda002 && !IsBasicVectorizerIntfloatMultilingualE5Large && IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 && !IsHkunlpInstructorXlVectorizer && !IsGoogleVertexAIVectorizerTextEmbedding004 && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002 && !IsGoogleVertexAIVectorizerGeminiEmbedding001 && !IsFastEmbedVectorizerBAAIBgeSmallEnV15 && !IsPrivateVectorizer || !IsOpenAIVectorizerTextEmbedding3Small && !IsOpenAIVectorizerTextEmbedding3Large && !IsOpenAIVectorizerTextEmbeddingAda002 && !IsBasicVectorizerIntfloatMultilingualE5Large && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 && IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 && !IsHkunlpInstructorXlVectorizer && !IsGoogleVertexAIVectorizerTextEmbedding004 && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002 && !IsGoogleVertexAIVectorizerGeminiEmbedding001 && !IsFastEmbedVectorizerBAAIBgeSmallEnV15 && !IsPrivateVectorizer || !IsOpenAIVectorizerTextEmbedding3Small && !IsOpenAIVectorizerTextEmbedding3Large && !IsOpenAIVectorizerTextEmbeddingAda002 && !IsBasicVectorizerIntfloatMultilingualE5Large && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 && IsHkunlpInstructorXlVectorizer && !IsGoogleVertexAIVectorizerTextEmbedding004 && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002 && !IsGoogleVertexAIVectorizerGeminiEmbedding001 && !IsFastEmbedVectorizerBAAIBgeSmallEnV15 && !IsPrivateVectorizer || !IsOpenAIVectorizerTextEmbedding3Small && !IsOpenAIVectorizerTextEmbedding3Large && !IsOpenAIVectorizerTextEmbeddingAda002 && !IsBasicVectorizerIntfloatMultilingualE5Large && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 && !IsHkunlpInstructorXlVectorizer && IsGoogleVertexAIVectorizerTextEmbedding004 && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002 && !IsGoogleVertexAIVectorizerGeminiEmbedding001 && !IsFastEmbedVectorizerBAAIBgeSmallEnV15 && !IsPrivateVectorizer || !IsOpenAIVectorizerTextEmbedding3Small && !IsOpenAIVectorizerTextEmbedding3Large && !IsOpenAIVectorizerTextEmbeddingAda002 && !IsBasicVectorizerIntfloatMultilingualE5Large && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 && !IsHkunlpInstructorXlVectorizer && !IsGoogleVertexAIVectorizerTextEmbedding004 && IsGoogleVertexAIVectorizerTextMultilingualEmbedding002 && !IsGoogleVertexAIVectorizerGeminiEmbedding001 && !IsFastEmbedVectorizerBAAIBgeSmallEnV15 && !IsPrivateVectorizer || !IsOpenAIVectorizerTextEmbedding3Small && !IsOpenAIVectorizerTextEmbedding3Large && !IsOpenAIVectorizerTextEmbeddingAda002 && !IsBasicVectorizerIntfloatMultilingualE5Large && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 && !IsHkunlpInstructorXlVectorizer && !IsGoogleVertexAIVectorizerTextEmbedding004 && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002 && IsGoogleVertexAIVectorizerGeminiEmbedding001 && !IsFastEmbedVectorizerBAAIBgeSmallEnV15 && !IsPrivateVectorizer || !IsOpenAIVectorizerTextEmbedding3Small && !IsOpenAIVectorizerTextEmbedding3Large && !IsOpenAIVectorizerTextEmbeddingAda002 && !IsBasicVectorizerIntfloatMultilingualE5Large && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 && !IsHkunlpInstructorXlVectorizer && !IsGoogleVertexAIVectorizerTextEmbedding004 && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002 && !IsGoogleVertexAIVectorizerGeminiEmbedding001 && IsFastEmbedVectorizerBAAIBgeSmallEnV15 && !IsPrivateVectorizer || !IsOpenAIVectorizerTextEmbedding3Small && !IsOpenAIVectorizerTextEmbedding3Large && !IsOpenAIVectorizerTextEmbeddingAda002 && !IsBasicVectorizerIntfloatMultilingualE5Large && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 && !IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 && !IsHkunlpInstructorXlVectorizer && !IsGoogleVertexAIVectorizerTextEmbedding004 && !IsGoogleVertexAIVectorizerTextMultilingualEmbedding002 && !IsGoogleVertexAIVectorizerGeminiEmbedding001 && !IsFastEmbedVectorizerBAAIBgeSmallEnV15 && IsPrivateVectorizer;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.OpenAIVectorizerTextEmbedding3Small?, TResult>? openAIVectorizerTextEmbedding3Small = null,
            global::System.Func<global::Vellum.OpenAIVectorizerTextEmbedding3Large?, TResult>? openAIVectorizerTextEmbedding3Large = null,
            global::System.Func<global::Vellum.OpenAIVectorizerTextEmbeddingAda002?, TResult>? openAIVectorizerTextEmbeddingAda002 = null,
            global::System.Func<global::Vellum.BasicVectorizerIntfloatMultilingualE5Large?, TResult>? basicVectorizerIntfloatMultilingualE5Large = null,
            global::System.Func<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1?, TResult>? basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 = null,
            global::System.Func<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1?, TResult>? basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 = null,
            global::System.Func<global::Vellum.HkunlpInstructorXlVectorizer?, TResult>? hkunlpInstructorXlVectorizer = null,
            global::System.Func<global::Vellum.GoogleVertexAIVectorizerTextEmbedding004?, TResult>? googleVertexAIVectorizerTextEmbedding004 = null,
            global::System.Func<global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002?, TResult>? googleVertexAIVectorizerTextMultilingualEmbedding002 = null,
            global::System.Func<global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001?, TResult>? googleVertexAIVectorizerGeminiEmbedding001 = null,
            global::System.Func<global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15?, TResult>? fastEmbedVectorizerBAAIBgeSmallEnV15 = null,
            global::System.Func<global::Vellum.PrivateVectorizer?, TResult>? privateVectorizer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAIVectorizerTextEmbedding3Small && openAIVectorizerTextEmbedding3Small != null)
            {
                return openAIVectorizerTextEmbedding3Small(OpenAIVectorizerTextEmbedding3Small!);
            }
            else if (IsOpenAIVectorizerTextEmbedding3Large && openAIVectorizerTextEmbedding3Large != null)
            {
                return openAIVectorizerTextEmbedding3Large(OpenAIVectorizerTextEmbedding3Large!);
            }
            else if (IsOpenAIVectorizerTextEmbeddingAda002 && openAIVectorizerTextEmbeddingAda002 != null)
            {
                return openAIVectorizerTextEmbeddingAda002(OpenAIVectorizerTextEmbeddingAda002!);
            }
            else if (IsBasicVectorizerIntfloatMultilingualE5Large && basicVectorizerIntfloatMultilingualE5Large != null)
            {
                return basicVectorizerIntfloatMultilingualE5Large(BasicVectorizerIntfloatMultilingualE5Large!);
            }
            else if (IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 && basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 != null)
            {
                return basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1(BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1!);
            }
            else if (IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 && basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 != null)
            {
                return basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1(BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1!);
            }
            else if (IsHkunlpInstructorXlVectorizer && hkunlpInstructorXlVectorizer != null)
            {
                return hkunlpInstructorXlVectorizer(HkunlpInstructorXlVectorizer!);
            }
            else if (IsGoogleVertexAIVectorizerTextEmbedding004 && googleVertexAIVectorizerTextEmbedding004 != null)
            {
                return googleVertexAIVectorizerTextEmbedding004(GoogleVertexAIVectorizerTextEmbedding004!);
            }
            else if (IsGoogleVertexAIVectorizerTextMultilingualEmbedding002 && googleVertexAIVectorizerTextMultilingualEmbedding002 != null)
            {
                return googleVertexAIVectorizerTextMultilingualEmbedding002(GoogleVertexAIVectorizerTextMultilingualEmbedding002!);
            }
            else if (IsGoogleVertexAIVectorizerGeminiEmbedding001 && googleVertexAIVectorizerGeminiEmbedding001 != null)
            {
                return googleVertexAIVectorizerGeminiEmbedding001(GoogleVertexAIVectorizerGeminiEmbedding001!);
            }
            else if (IsFastEmbedVectorizerBAAIBgeSmallEnV15 && fastEmbedVectorizerBAAIBgeSmallEnV15 != null)
            {
                return fastEmbedVectorizerBAAIBgeSmallEnV15(FastEmbedVectorizerBAAIBgeSmallEnV15!);
            }
            else if (IsPrivateVectorizer && privateVectorizer != null)
            {
                return privateVectorizer(PrivateVectorizer!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.OpenAIVectorizerTextEmbedding3Small?>? openAIVectorizerTextEmbedding3Small = null,
            global::System.Action<global::Vellum.OpenAIVectorizerTextEmbedding3Large?>? openAIVectorizerTextEmbedding3Large = null,
            global::System.Action<global::Vellum.OpenAIVectorizerTextEmbeddingAda002?>? openAIVectorizerTextEmbeddingAda002 = null,
            global::System.Action<global::Vellum.BasicVectorizerIntfloatMultilingualE5Large?>? basicVectorizerIntfloatMultilingualE5Large = null,
            global::System.Action<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1?>? basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 = null,
            global::System.Action<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1?>? basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 = null,
            global::System.Action<global::Vellum.HkunlpInstructorXlVectorizer?>? hkunlpInstructorXlVectorizer = null,
            global::System.Action<global::Vellum.GoogleVertexAIVectorizerTextEmbedding004?>? googleVertexAIVectorizerTextEmbedding004 = null,
            global::System.Action<global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002?>? googleVertexAIVectorizerTextMultilingualEmbedding002 = null,
            global::System.Action<global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001?>? googleVertexAIVectorizerGeminiEmbedding001 = null,
            global::System.Action<global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15?>? fastEmbedVectorizerBAAIBgeSmallEnV15 = null,
            global::System.Action<global::Vellum.PrivateVectorizer?>? privateVectorizer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenAIVectorizerTextEmbedding3Small)
            {
                openAIVectorizerTextEmbedding3Small?.Invoke(OpenAIVectorizerTextEmbedding3Small!);
            }
            else if (IsOpenAIVectorizerTextEmbedding3Large)
            {
                openAIVectorizerTextEmbedding3Large?.Invoke(OpenAIVectorizerTextEmbedding3Large!);
            }
            else if (IsOpenAIVectorizerTextEmbeddingAda002)
            {
                openAIVectorizerTextEmbeddingAda002?.Invoke(OpenAIVectorizerTextEmbeddingAda002!);
            }
            else if (IsBasicVectorizerIntfloatMultilingualE5Large)
            {
                basicVectorizerIntfloatMultilingualE5Large?.Invoke(BasicVectorizerIntfloatMultilingualE5Large!);
            }
            else if (IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1)
            {
                basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1?.Invoke(BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1!);
            }
            else if (IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1)
            {
                basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1?.Invoke(BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1!);
            }
            else if (IsHkunlpInstructorXlVectorizer)
            {
                hkunlpInstructorXlVectorizer?.Invoke(HkunlpInstructorXlVectorizer!);
            }
            else if (IsGoogleVertexAIVectorizerTextEmbedding004)
            {
                googleVertexAIVectorizerTextEmbedding004?.Invoke(GoogleVertexAIVectorizerTextEmbedding004!);
            }
            else if (IsGoogleVertexAIVectorizerTextMultilingualEmbedding002)
            {
                googleVertexAIVectorizerTextMultilingualEmbedding002?.Invoke(GoogleVertexAIVectorizerTextMultilingualEmbedding002!);
            }
            else if (IsGoogleVertexAIVectorizerGeminiEmbedding001)
            {
                googleVertexAIVectorizerGeminiEmbedding001?.Invoke(GoogleVertexAIVectorizerGeminiEmbedding001!);
            }
            else if (IsFastEmbedVectorizerBAAIBgeSmallEnV15)
            {
                fastEmbedVectorizerBAAIBgeSmallEnV15?.Invoke(FastEmbedVectorizerBAAIBgeSmallEnV15!);
            }
            else if (IsPrivateVectorizer)
            {
                privateVectorizer?.Invoke(PrivateVectorizer!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenAIVectorizerTextEmbedding3Small,
                typeof(global::Vellum.OpenAIVectorizerTextEmbedding3Small),
                OpenAIVectorizerTextEmbedding3Large,
                typeof(global::Vellum.OpenAIVectorizerTextEmbedding3Large),
                OpenAIVectorizerTextEmbeddingAda002,
                typeof(global::Vellum.OpenAIVectorizerTextEmbeddingAda002),
                BasicVectorizerIntfloatMultilingualE5Large,
                typeof(global::Vellum.BasicVectorizerIntfloatMultilingualE5Large),
                BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1,
                typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1),
                BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1,
                typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1),
                HkunlpInstructorXlVectorizer,
                typeof(global::Vellum.HkunlpInstructorXlVectorizer),
                GoogleVertexAIVectorizerTextEmbedding004,
                typeof(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004),
                GoogleVertexAIVectorizerTextMultilingualEmbedding002,
                typeof(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002),
                GoogleVertexAIVectorizerGeminiEmbedding001,
                typeof(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001),
                FastEmbedVectorizerBAAIBgeSmallEnV15,
                typeof(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15),
                PrivateVectorizer,
                typeof(global::Vellum.PrivateVectorizer),
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
        public bool Equals(IndexingConfigVectorizer other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.OpenAIVectorizerTextEmbedding3Small?>.Default.Equals(OpenAIVectorizerTextEmbedding3Small, other.OpenAIVectorizerTextEmbedding3Small) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.OpenAIVectorizerTextEmbedding3Large?>.Default.Equals(OpenAIVectorizerTextEmbedding3Large, other.OpenAIVectorizerTextEmbedding3Large) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.OpenAIVectorizerTextEmbeddingAda002?>.Default.Equals(OpenAIVectorizerTextEmbeddingAda002, other.OpenAIVectorizerTextEmbeddingAda002) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.BasicVectorizerIntfloatMultilingualE5Large?>.Default.Equals(BasicVectorizerIntfloatMultilingualE5Large, other.BasicVectorizerIntfloatMultilingualE5Large) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1?>.Default.Equals(BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1, other.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1?>.Default.Equals(BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1, other.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.HkunlpInstructorXlVectorizer?>.Default.Equals(HkunlpInstructorXlVectorizer, other.HkunlpInstructorXlVectorizer) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.GoogleVertexAIVectorizerTextEmbedding004?>.Default.Equals(GoogleVertexAIVectorizerTextEmbedding004, other.GoogleVertexAIVectorizerTextEmbedding004) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002?>.Default.Equals(GoogleVertexAIVectorizerTextMultilingualEmbedding002, other.GoogleVertexAIVectorizerTextMultilingualEmbedding002) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001?>.Default.Equals(GoogleVertexAIVectorizerGeminiEmbedding001, other.GoogleVertexAIVectorizerGeminiEmbedding001) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15?>.Default.Equals(FastEmbedVectorizerBAAIBgeSmallEnV15, other.FastEmbedVectorizerBAAIBgeSmallEnV15) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.PrivateVectorizer?>.Default.Equals(PrivateVectorizer, other.PrivateVectorizer) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IndexingConfigVectorizer obj1, IndexingConfigVectorizer obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IndexingConfigVectorizer>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IndexingConfigVectorizer obj1, IndexingConfigVectorizer obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IndexingConfigVectorizer o && Equals(o);
        }
    }
}
