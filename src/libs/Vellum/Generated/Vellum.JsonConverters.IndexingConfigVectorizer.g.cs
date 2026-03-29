#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class IndexingConfigVectorizerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.IndexingConfigVectorizer>
    {
        /// <inheritdoc />
        public override global::Vellum.IndexingConfigVectorizer Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("config")) __score0++;
            if (__jsonProps.Contains("model_name")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("config")) __score1++;
            if (__jsonProps.Contains("model_name")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("config")) __score2++;
            if (__jsonProps.Contains("model_name")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("config")) __score3++;
            if (__jsonProps.Contains("model_name")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("config")) __score4++;
            if (__jsonProps.Contains("model_name")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("config")) __score5++;
            if (__jsonProps.Contains("model_name")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("config")) __score6++;
            if (__jsonProps.Contains("model_name")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("config")) __score7++;
            if (__jsonProps.Contains("model_name")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("config")) __score8++;
            if (__jsonProps.Contains("model_name")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("config")) __score9++;
            if (__jsonProps.Contains("model_name")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("model_name")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("model_name")) __score11++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }

            global::Vellum.OpenAIVectorizerTextEmbedding3Small? openAIVectorizerTextEmbedding3Small = default;
            global::Vellum.OpenAIVectorizerTextEmbedding3Large? openAIVectorizerTextEmbedding3Large = default;
            global::Vellum.OpenAIVectorizerTextEmbeddingAda002? openAIVectorizerTextEmbeddingAda002 = default;
            global::Vellum.BasicVectorizerIntfloatMultilingualE5Large? basicVectorizerIntfloatMultilingualE5Large = default;
            global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1? basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 = default;
            global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1? basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 = default;
            global::Vellum.HkunlpInstructorXlVectorizer? hkunlpInstructorXlVectorizer = default;
            global::Vellum.GoogleVertexAIVectorizerTextEmbedding004? googleVertexAIVectorizerTextEmbedding004 = default;
            global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002? googleVertexAIVectorizerTextMultilingualEmbedding002 = default;
            global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001? googleVertexAIVectorizerGeminiEmbedding001 = default;
            global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15? fastEmbedVectorizerBAAIBgeSmallEnV15 = default;
            global::Vellum.PrivateVectorizer? privateVectorizer = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.OpenAIVectorizerTextEmbedding3Small), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.OpenAIVectorizerTextEmbedding3Small> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.OpenAIVectorizerTextEmbedding3Small).Name}");
                        openAIVectorizerTextEmbedding3Small = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.OpenAIVectorizerTextEmbedding3Large), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.OpenAIVectorizerTextEmbedding3Large> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.OpenAIVectorizerTextEmbedding3Large).Name}");
                        openAIVectorizerTextEmbedding3Large = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.OpenAIVectorizerTextEmbeddingAda002), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.OpenAIVectorizerTextEmbeddingAda002> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.OpenAIVectorizerTextEmbeddingAda002).Name}");
                        openAIVectorizerTextEmbeddingAda002 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.BasicVectorizerIntfloatMultilingualE5Large), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.BasicVectorizerIntfloatMultilingualE5Large> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.BasicVectorizerIntfloatMultilingualE5Large).Name}");
                        basicVectorizerIntfloatMultilingualE5Large = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1).Name}");
                        basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1).Name}");
                        basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.HkunlpInstructorXlVectorizer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.HkunlpInstructorXlVectorizer> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.HkunlpInstructorXlVectorizer).Name}");
                        hkunlpInstructorXlVectorizer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.GoogleVertexAIVectorizerTextEmbedding004> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004).Name}");
                        googleVertexAIVectorizerTextEmbedding004 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002).Name}");
                        googleVertexAIVectorizerTextMultilingualEmbedding002 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001).Name}");
                        googleVertexAIVectorizerGeminiEmbedding001 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15).Name}");
                        fastEmbedVectorizerBAAIBgeSmallEnV15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.PrivateVectorizer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.PrivateVectorizer> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.PrivateVectorizer).Name}");
                        privateVectorizer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (openAIVectorizerTextEmbedding3Small == null && openAIVectorizerTextEmbedding3Large == null && openAIVectorizerTextEmbeddingAda002 == null && basicVectorizerIntfloatMultilingualE5Large == null && basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 == null && basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 == null && hkunlpInstructorXlVectorizer == null && googleVertexAIVectorizerTextEmbedding004 == null && googleVertexAIVectorizerTextMultilingualEmbedding002 == null && googleVertexAIVectorizerGeminiEmbedding001 == null && fastEmbedVectorizerBAAIBgeSmallEnV15 == null && privateVectorizer == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.OpenAIVectorizerTextEmbedding3Small), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.OpenAIVectorizerTextEmbedding3Small> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.OpenAIVectorizerTextEmbedding3Small).Name}");
                    openAIVectorizerTextEmbedding3Small = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.OpenAIVectorizerTextEmbedding3Large), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.OpenAIVectorizerTextEmbedding3Large> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.OpenAIVectorizerTextEmbedding3Large).Name}");
                    openAIVectorizerTextEmbedding3Large = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.OpenAIVectorizerTextEmbeddingAda002), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.OpenAIVectorizerTextEmbeddingAda002> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.OpenAIVectorizerTextEmbeddingAda002).Name}");
                    openAIVectorizerTextEmbeddingAda002 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.BasicVectorizerIntfloatMultilingualE5Large), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.BasicVectorizerIntfloatMultilingualE5Large> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.BasicVectorizerIntfloatMultilingualE5Large).Name}");
                    basicVectorizerIntfloatMultilingualE5Large = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1).Name}");
                    basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1).Name}");
                    basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.HkunlpInstructorXlVectorizer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.HkunlpInstructorXlVectorizer> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.HkunlpInstructorXlVectorizer).Name}");
                    hkunlpInstructorXlVectorizer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.GoogleVertexAIVectorizerTextEmbedding004> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004).Name}");
                    googleVertexAIVectorizerTextEmbedding004 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002).Name}");
                    googleVertexAIVectorizerTextMultilingualEmbedding002 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001).Name}");
                    googleVertexAIVectorizerGeminiEmbedding001 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15).Name}");
                    fastEmbedVectorizerBAAIBgeSmallEnV15 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.PrivateVectorizer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.PrivateVectorizer> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.PrivateVectorizer).Name}");
                    privateVectorizer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.IndexingConfigVectorizer(
                openAIVectorizerTextEmbedding3Small,

                openAIVectorizerTextEmbedding3Large,

                openAIVectorizerTextEmbeddingAda002,

                basicVectorizerIntfloatMultilingualE5Large,

                basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1,

                basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1,

                hkunlpInstructorXlVectorizer,

                googleVertexAIVectorizerTextEmbedding004,

                googleVertexAIVectorizerTextMultilingualEmbedding002,

                googleVertexAIVectorizerGeminiEmbedding001,

                fastEmbedVectorizerBAAIBgeSmallEnV15,

                privateVectorizer
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.IndexingConfigVectorizer value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOpenAIVectorizerTextEmbedding3Small)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.OpenAIVectorizerTextEmbedding3Small), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.OpenAIVectorizerTextEmbedding3Small?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.OpenAIVectorizerTextEmbedding3Small).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAIVectorizerTextEmbedding3Small, typeInfo);
            }
            else if (value.IsOpenAIVectorizerTextEmbedding3Large)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.OpenAIVectorizerTextEmbedding3Large), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.OpenAIVectorizerTextEmbedding3Large?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.OpenAIVectorizerTextEmbedding3Large).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAIVectorizerTextEmbedding3Large, typeInfo);
            }
            else if (value.IsOpenAIVectorizerTextEmbeddingAda002)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.OpenAIVectorizerTextEmbeddingAda002), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.OpenAIVectorizerTextEmbeddingAda002?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.OpenAIVectorizerTextEmbeddingAda002).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAIVectorizerTextEmbeddingAda002, typeInfo);
            }
            else if (value.IsBasicVectorizerIntfloatMultilingualE5Large)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.BasicVectorizerIntfloatMultilingualE5Large), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.BasicVectorizerIntfloatMultilingualE5Large?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.BasicVectorizerIntfloatMultilingualE5Large).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BasicVectorizerIntfloatMultilingualE5Large, typeInfo);
            }
            else if (value.IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1, typeInfo);
            }
            else if (value.IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1, typeInfo);
            }
            else if (value.IsHkunlpInstructorXlVectorizer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.HkunlpInstructorXlVectorizer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.HkunlpInstructorXlVectorizer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.HkunlpInstructorXlVectorizer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HkunlpInstructorXlVectorizer, typeInfo);
            }
            else if (value.IsGoogleVertexAIVectorizerTextEmbedding004)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.GoogleVertexAIVectorizerTextEmbedding004?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleVertexAIVectorizerTextEmbedding004, typeInfo);
            }
            else if (value.IsGoogleVertexAIVectorizerTextMultilingualEmbedding002)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleVertexAIVectorizerTextMultilingualEmbedding002, typeInfo);
            }
            else if (value.IsGoogleVertexAIVectorizerGeminiEmbedding001)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleVertexAIVectorizerGeminiEmbedding001, typeInfo);
            }
            else if (value.IsFastEmbedVectorizerBAAIBgeSmallEnV15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FastEmbedVectorizerBAAIBgeSmallEnV15, typeInfo);
            }
            else if (value.IsPrivateVectorizer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.PrivateVectorizer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.PrivateVectorizer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.PrivateVectorizer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PrivateVectorizer, typeInfo);
            }
        }
    }
}