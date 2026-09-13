
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Vellum
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.EntityStatus), TypeInfoPropertyName = "EntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowDisplayIcon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowSandboxEnum), TypeInfoPropertyName = "WorkflowSandboxEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TextEmbedding3SmallEnum), TypeInfoPropertyName = "TextEmbedding3SmallEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TextEmbedding3LargeEnum), TypeInfoPropertyName = "TextEmbedding3LargeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TextEmbeddingAda002Enum), TypeInfoPropertyName = "TextEmbeddingAda002Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.IntfloatMultilingualE5LargeEnum), TypeInfoPropertyName = "IntfloatMultilingualE5LargeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseCosV1Enum), TypeInfoPropertyName = "SentenceTransformersMultiQaMpnetBaseCosV1Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseDotV1Enum), TypeInfoPropertyName = "SentenceTransformersMultiQaMpnetBaseDotV1Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.HkunlpInstructorXlEnum), TypeInfoPropertyName = "HkunlpInstructorXlEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TextEmbedding004Enum), TypeInfoPropertyName = "TextEmbedding004Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TextMultilingualEmbedding002Enum), TypeInfoPropertyName = "TextMultilingualEmbedding002Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.GeminiEmbedding001Enum), TypeInfoPropertyName = "GeminiEmbedding001Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.BaaiBgeSmallEnV15Enum), TypeInfoPropertyName = "BaaiBgeSmallEnV15Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PrivateVectorizerEnum), TypeInfoPropertyName = "PrivateVectorizerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReductoChunkerEnum), TypeInfoPropertyName = "ReductoChunkerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SentenceChunkerEnum), TypeInfoPropertyName = "SentenceChunkerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TokenOverlappingWindowChunkerEnum), TypeInfoPropertyName = "TokenOverlappingWindowChunkerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DelimiterChunkerEnum), TypeInfoPropertyName = "DelimiterChunkerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OpenAIVectorizerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OpenAIVectorizerTextEmbedding3Small))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OpenAIVectorizerTextEmbedding3Large))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.OpenAIVectorizerTextEmbeddingAda002))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.BasicVectorizerIntfloatMultilingualE5Large))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.InstructorVectorizerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.HkunlpInstructorXlVectorizer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.GoogleVertexAIVectorizerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PrivateVectorizer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.IndexingConfigVectorizer), TypeInfoPropertyName = "IndexingConfigVectorizer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReductoChunkerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReductoChunking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SentenceChunkerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SentenceChunking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TokenOverlappingWindowChunkerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TokenOverlappingWindowChunking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DelimiterChunkerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DelimiterChunking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentIndexChunking), TypeInfoPropertyName = "DocumentIndexChunking2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentIndexIndexingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.AddEntityToFolderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntitiesAddEntityToFolderResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.V1FolderEntitiesGetParametersEntityStatus), TypeInfoPropertyName = "V1FolderEntitiesGetParametersEntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEnum), TypeInfoPropertyName = "FolderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityFolderData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityFolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptSandboxEnum), TypeInfoPropertyName = "PromptSandboxEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityPromptSandboxData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityPromptSandbox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowSandboxDisplayData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityWorkflowSandboxData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityWorkflowSandbox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentIndexEnum), TypeInfoPropertyName = "DocumentIndexEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityDocumentIndexData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityDocumentIndex))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteEnum), TypeInfoPropertyName = "TestSuiteEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityTestSuiteData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityTestSuite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DatasetEnum), TypeInfoPropertyName = "DatasetEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityDatasetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntityDataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntity), TypeInfoPropertyName = "FolderEntity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PaginatedFolderEntityList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vellum.FolderEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.EntityStatus?), TypeInfoPropertyName = "NullableEntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.WorkflowSandboxEnum?), TypeInfoPropertyName = "NullableWorkflowSandboxEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TextEmbedding3SmallEnum?), TypeInfoPropertyName = "NullableTextEmbedding3SmallEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TextEmbedding3LargeEnum?), TypeInfoPropertyName = "NullableTextEmbedding3LargeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TextEmbeddingAda002Enum?), TypeInfoPropertyName = "NullableTextEmbeddingAda002Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.IntfloatMultilingualE5LargeEnum?), TypeInfoPropertyName = "NullableIntfloatMultilingualE5LargeEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseCosV1Enum?), TypeInfoPropertyName = "NullableSentenceTransformersMultiQaMpnetBaseCosV1Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseDotV1Enum?), TypeInfoPropertyName = "NullableSentenceTransformersMultiQaMpnetBaseDotV1Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.HkunlpInstructorXlEnum?), TypeInfoPropertyName = "NullableHkunlpInstructorXlEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TextEmbedding004Enum?), TypeInfoPropertyName = "NullableTextEmbedding004Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TextMultilingualEmbedding002Enum?), TypeInfoPropertyName = "NullableTextMultilingualEmbedding002Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.GeminiEmbedding001Enum?), TypeInfoPropertyName = "NullableGeminiEmbedding001Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.BaaiBgeSmallEnV15Enum?), TypeInfoPropertyName = "NullableBaaiBgeSmallEnV15Enum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PrivateVectorizerEnum?), TypeInfoPropertyName = "NullablePrivateVectorizerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.ReductoChunkerEnum?), TypeInfoPropertyName = "NullableReductoChunkerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.SentenceChunkerEnum?), TypeInfoPropertyName = "NullableSentenceChunkerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TokenOverlappingWindowChunkerEnum?), TypeInfoPropertyName = "NullableTokenOverlappingWindowChunkerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DelimiterChunkerEnum?), TypeInfoPropertyName = "NullableDelimiterChunkerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.IndexingConfigVectorizer?), TypeInfoPropertyName = "NullableIndexingConfigVectorizer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentIndexChunking?), TypeInfoPropertyName = "NullableDocumentIndexChunking2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.V1FolderEntitiesGetParametersEntityStatus?), TypeInfoPropertyName = "NullableV1FolderEntitiesGetParametersEntityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEnum?), TypeInfoPropertyName = "NullableFolderEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.PromptSandboxEnum?), TypeInfoPropertyName = "NullablePromptSandboxEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DocumentIndexEnum?), TypeInfoPropertyName = "NullableDocumentIndexEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.TestSuiteEnum?), TypeInfoPropertyName = "NullableTestSuiteEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.DatasetEnum?), TypeInfoPropertyName = "NullableDatasetEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vellum.FolderEntity?), TypeInfoPropertyName = "NullableFolderEntity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vellum.FolderEntity>))]
    internal sealed partial class FolderEntitiesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FolderEntitiesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static FolderEntitiesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private FolderEntitiesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Vellum.JsonConverters.IndexingConfigVectorizerJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.DocumentIndexChunkingJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.FolderEntityJsonConverter());
            options.Converters.Add(new global::Vellum.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Vellum.EntityStatus)

                    || typeToConvert == typeof(global::Vellum.EntityStatus?)

                    || typeToConvert == typeof(global::Vellum.WorkflowSandboxEnum)

                    || typeToConvert == typeof(global::Vellum.WorkflowSandboxEnum?)

                    || typeToConvert == typeof(global::Vellum.TextEmbedding3SmallEnum)

                    || typeToConvert == typeof(global::Vellum.TextEmbedding3SmallEnum?)

                    || typeToConvert == typeof(global::Vellum.TextEmbedding3LargeEnum)

                    || typeToConvert == typeof(global::Vellum.TextEmbedding3LargeEnum?)

                    || typeToConvert == typeof(global::Vellum.TextEmbeddingAda002Enum)

                    || typeToConvert == typeof(global::Vellum.TextEmbeddingAda002Enum?)

                    || typeToConvert == typeof(global::Vellum.IntfloatMultilingualE5LargeEnum)

                    || typeToConvert == typeof(global::Vellum.IntfloatMultilingualE5LargeEnum?)

                    || typeToConvert == typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseCosV1Enum)

                    || typeToConvert == typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseCosV1Enum?)

                    || typeToConvert == typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseDotV1Enum)

                    || typeToConvert == typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseDotV1Enum?)

                    || typeToConvert == typeof(global::Vellum.HkunlpInstructorXlEnum)

                    || typeToConvert == typeof(global::Vellum.HkunlpInstructorXlEnum?)

                    || typeToConvert == typeof(global::Vellum.TextEmbedding004Enum)

                    || typeToConvert == typeof(global::Vellum.TextEmbedding004Enum?)

                    || typeToConvert == typeof(global::Vellum.TextMultilingualEmbedding002Enum)

                    || typeToConvert == typeof(global::Vellum.TextMultilingualEmbedding002Enum?)

                    || typeToConvert == typeof(global::Vellum.GeminiEmbedding001Enum)

                    || typeToConvert == typeof(global::Vellum.GeminiEmbedding001Enum?)

                    || typeToConvert == typeof(global::Vellum.BaaiBgeSmallEnV15Enum)

                    || typeToConvert == typeof(global::Vellum.BaaiBgeSmallEnV15Enum?)

                    || typeToConvert == typeof(global::Vellum.PrivateVectorizerEnum)

                    || typeToConvert == typeof(global::Vellum.PrivateVectorizerEnum?)

                    || typeToConvert == typeof(global::Vellum.ReductoChunkerEnum)

                    || typeToConvert == typeof(global::Vellum.ReductoChunkerEnum?)

                    || typeToConvert == typeof(global::Vellum.SentenceChunkerEnum)

                    || typeToConvert == typeof(global::Vellum.SentenceChunkerEnum?)

                    || typeToConvert == typeof(global::Vellum.TokenOverlappingWindowChunkerEnum)

                    || typeToConvert == typeof(global::Vellum.TokenOverlappingWindowChunkerEnum?)

                    || typeToConvert == typeof(global::Vellum.DelimiterChunkerEnum)

                    || typeToConvert == typeof(global::Vellum.DelimiterChunkerEnum?)

                    || typeToConvert == typeof(global::Vellum.V1FolderEntitiesGetParametersEntityStatus)

                    || typeToConvert == typeof(global::Vellum.V1FolderEntitiesGetParametersEntityStatus?)

                    || typeToConvert == typeof(global::Vellum.FolderEnum)

                    || typeToConvert == typeof(global::Vellum.FolderEnum?)

                    || typeToConvert == typeof(global::Vellum.PromptSandboxEnum)

                    || typeToConvert == typeof(global::Vellum.PromptSandboxEnum?)

                    || typeToConvert == typeof(global::Vellum.DocumentIndexEnum)

                    || typeToConvert == typeof(global::Vellum.DocumentIndexEnum?)

                    || typeToConvert == typeof(global::Vellum.TestSuiteEnum)

                    || typeToConvert == typeof(global::Vellum.TestSuiteEnum?)

                    || typeToConvert == typeof(global::Vellum.DatasetEnum)

                    || typeToConvert == typeof(global::Vellum.DatasetEnum?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vellum.EntityStatus))
                {
                    return new global::Vellum.JsonConverters.EntityStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.EntityStatus?))
                {
                    return new global::Vellum.JsonConverters.EntityStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowSandboxEnum))
                {
                    return new global::Vellum.JsonConverters.WorkflowSandboxEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.WorkflowSandboxEnum?))
                {
                    return new global::Vellum.JsonConverters.WorkflowSandboxEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TextEmbedding3SmallEnum))
                {
                    return new global::Vellum.JsonConverters.TextEmbedding3SmallEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TextEmbedding3SmallEnum?))
                {
                    return new global::Vellum.JsonConverters.TextEmbedding3SmallEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TextEmbedding3LargeEnum))
                {
                    return new global::Vellum.JsonConverters.TextEmbedding3LargeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TextEmbedding3LargeEnum?))
                {
                    return new global::Vellum.JsonConverters.TextEmbedding3LargeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TextEmbeddingAda002Enum))
                {
                    return new global::Vellum.JsonConverters.TextEmbeddingAda002EnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TextEmbeddingAda002Enum?))
                {
                    return new global::Vellum.JsonConverters.TextEmbeddingAda002EnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.IntfloatMultilingualE5LargeEnum))
                {
                    return new global::Vellum.JsonConverters.IntfloatMultilingualE5LargeEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.IntfloatMultilingualE5LargeEnum?))
                {
                    return new global::Vellum.JsonConverters.IntfloatMultilingualE5LargeEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseCosV1Enum))
                {
                    return new global::Vellum.JsonConverters.SentenceTransformersMultiQaMpnetBaseCosV1EnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseCosV1Enum?))
                {
                    return new global::Vellum.JsonConverters.SentenceTransformersMultiQaMpnetBaseCosV1EnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseDotV1Enum))
                {
                    return new global::Vellum.JsonConverters.SentenceTransformersMultiQaMpnetBaseDotV1EnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SentenceTransformersMultiQaMpnetBaseDotV1Enum?))
                {
                    return new global::Vellum.JsonConverters.SentenceTransformersMultiQaMpnetBaseDotV1EnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.HkunlpInstructorXlEnum))
                {
                    return new global::Vellum.JsonConverters.HkunlpInstructorXlEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.HkunlpInstructorXlEnum?))
                {
                    return new global::Vellum.JsonConverters.HkunlpInstructorXlEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TextEmbedding004Enum))
                {
                    return new global::Vellum.JsonConverters.TextEmbedding004EnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TextEmbedding004Enum?))
                {
                    return new global::Vellum.JsonConverters.TextEmbedding004EnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TextMultilingualEmbedding002Enum))
                {
                    return new global::Vellum.JsonConverters.TextMultilingualEmbedding002EnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TextMultilingualEmbedding002Enum?))
                {
                    return new global::Vellum.JsonConverters.TextMultilingualEmbedding002EnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.GeminiEmbedding001Enum))
                {
                    return new global::Vellum.JsonConverters.GeminiEmbedding001EnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.GeminiEmbedding001Enum?))
                {
                    return new global::Vellum.JsonConverters.GeminiEmbedding001EnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.BaaiBgeSmallEnV15Enum))
                {
                    return new global::Vellum.JsonConverters.BaaiBgeSmallEnV15EnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.BaaiBgeSmallEnV15Enum?))
                {
                    return new global::Vellum.JsonConverters.BaaiBgeSmallEnV15EnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.PrivateVectorizerEnum))
                {
                    return new global::Vellum.JsonConverters.PrivateVectorizerEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.PrivateVectorizerEnum?))
                {
                    return new global::Vellum.JsonConverters.PrivateVectorizerEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ReductoChunkerEnum))
                {
                    return new global::Vellum.JsonConverters.ReductoChunkerEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.ReductoChunkerEnum?))
                {
                    return new global::Vellum.JsonConverters.ReductoChunkerEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SentenceChunkerEnum))
                {
                    return new global::Vellum.JsonConverters.SentenceChunkerEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.SentenceChunkerEnum?))
                {
                    return new global::Vellum.JsonConverters.SentenceChunkerEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TokenOverlappingWindowChunkerEnum))
                {
                    return new global::Vellum.JsonConverters.TokenOverlappingWindowChunkerEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TokenOverlappingWindowChunkerEnum?))
                {
                    return new global::Vellum.JsonConverters.TokenOverlappingWindowChunkerEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DelimiterChunkerEnum))
                {
                    return new global::Vellum.JsonConverters.DelimiterChunkerEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DelimiterChunkerEnum?))
                {
                    return new global::Vellum.JsonConverters.DelimiterChunkerEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.V1FolderEntitiesGetParametersEntityStatus))
                {
                    return new global::Vellum.JsonConverters.V1FolderEntitiesGetParametersEntityStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.V1FolderEntitiesGetParametersEntityStatus?))
                {
                    return new global::Vellum.JsonConverters.V1FolderEntitiesGetParametersEntityStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.FolderEnum))
                {
                    return new global::Vellum.JsonConverters.FolderEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.FolderEnum?))
                {
                    return new global::Vellum.JsonConverters.FolderEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.PromptSandboxEnum))
                {
                    return new global::Vellum.JsonConverters.PromptSandboxEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.PromptSandboxEnum?))
                {
                    return new global::Vellum.JsonConverters.PromptSandboxEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DocumentIndexEnum))
                {
                    return new global::Vellum.JsonConverters.DocumentIndexEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DocumentIndexEnum?))
                {
                    return new global::Vellum.JsonConverters.DocumentIndexEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteEnum))
                {
                    return new global::Vellum.JsonConverters.TestSuiteEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.TestSuiteEnum?))
                {
                    return new global::Vellum.JsonConverters.TestSuiteEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DatasetEnum))
                {
                    return new global::Vellum.JsonConverters.DatasetEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Vellum.DatasetEnum?))
                {
                    return new global::Vellum.JsonConverters.DatasetEnumNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new FolderEntitiesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}