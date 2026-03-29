#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class IndexingConfigVectorizerRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.IndexingConfigVectorizerRequest>
    {
        /// <inheritdoc />
        public override global::Vellum.IndexingConfigVectorizerRequest Read(
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

            global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest? openAIVectorizerTextEmbedding3SmallRequest = default;
            global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest? openAIVectorizerTextEmbedding3LargeRequest = default;
            global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request? openAIVectorizerTextEmbeddingAda002Request = default;
            global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest? basicVectorizerIntfloatMultilingualE5LargeRequest = default;
            global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request? basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request = default;
            global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request? basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request = default;
            global::Vellum.HkunlpInstructorXlVectorizerRequest? hkunlpInstructorXlVectorizerRequest = default;
            global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request? googleVertexAIVectorizerTextEmbedding004Request = default;
            global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request? googleVertexAIVectorizerTextMultilingualEmbedding002Request = default;
            global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request? googleVertexAIVectorizerGeminiEmbedding001Request = default;
            global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request? fastEmbedVectorizerBAAIBgeSmallEnV15Request = default;
            global::Vellum.PrivateVectorizerRequest? privateVectorizerRequest = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest).Name}");
                        openAIVectorizerTextEmbedding3SmallRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest).Name}");
                        openAIVectorizerTextEmbedding3LargeRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request).Name}");
                        openAIVectorizerTextEmbeddingAda002Request = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest).Name}");
                        basicVectorizerIntfloatMultilingualE5LargeRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request).Name}");
                        basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request).Name}");
                        basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.HkunlpInstructorXlVectorizerRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.HkunlpInstructorXlVectorizerRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.HkunlpInstructorXlVectorizerRequest).Name}");
                        hkunlpInstructorXlVectorizerRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request).Name}");
                        googleVertexAIVectorizerTextEmbedding004Request = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request).Name}");
                        googleVertexAIVectorizerTextMultilingualEmbedding002Request = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request).Name}");
                        googleVertexAIVectorizerGeminiEmbedding001Request = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request).Name}");
                        fastEmbedVectorizerBAAIBgeSmallEnV15Request = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.PrivateVectorizerRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.PrivateVectorizerRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.PrivateVectorizerRequest).Name}");
                        privateVectorizerRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (openAIVectorizerTextEmbedding3SmallRequest == null && openAIVectorizerTextEmbedding3LargeRequest == null && openAIVectorizerTextEmbeddingAda002Request == null && basicVectorizerIntfloatMultilingualE5LargeRequest == null && basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request == null && basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request == null && hkunlpInstructorXlVectorizerRequest == null && googleVertexAIVectorizerTextEmbedding004Request == null && googleVertexAIVectorizerTextMultilingualEmbedding002Request == null && googleVertexAIVectorizerGeminiEmbedding001Request == null && fastEmbedVectorizerBAAIBgeSmallEnV15Request == null && privateVectorizerRequest == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest).Name}");
                    openAIVectorizerTextEmbedding3SmallRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest).Name}");
                    openAIVectorizerTextEmbedding3LargeRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request).Name}");
                    openAIVectorizerTextEmbeddingAda002Request = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest).Name}");
                    basicVectorizerIntfloatMultilingualE5LargeRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request).Name}");
                    basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request).Name}");
                    basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.HkunlpInstructorXlVectorizerRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.HkunlpInstructorXlVectorizerRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.HkunlpInstructorXlVectorizerRequest).Name}");
                    hkunlpInstructorXlVectorizerRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request).Name}");
                    googleVertexAIVectorizerTextEmbedding004Request = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request).Name}");
                    googleVertexAIVectorizerTextMultilingualEmbedding002Request = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request).Name}");
                    googleVertexAIVectorizerGeminiEmbedding001Request = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request).Name}");
                    fastEmbedVectorizerBAAIBgeSmallEnV15Request = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.PrivateVectorizerRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.PrivateVectorizerRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.PrivateVectorizerRequest).Name}");
                    privateVectorizerRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.IndexingConfigVectorizerRequest(
                openAIVectorizerTextEmbedding3SmallRequest,

                openAIVectorizerTextEmbedding3LargeRequest,

                openAIVectorizerTextEmbeddingAda002Request,

                basicVectorizerIntfloatMultilingualE5LargeRequest,

                basicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request,

                basicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request,

                hkunlpInstructorXlVectorizerRequest,

                googleVertexAIVectorizerTextEmbedding004Request,

                googleVertexAIVectorizerTextMultilingualEmbedding002Request,

                googleVertexAIVectorizerGeminiEmbedding001Request,

                fastEmbedVectorizerBAAIBgeSmallEnV15Request,

                privateVectorizerRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.IndexingConfigVectorizerRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOpenAIVectorizerTextEmbedding3SmallRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.OpenAIVectorizerTextEmbedding3SmallRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAIVectorizerTextEmbedding3SmallRequest, typeInfo);
            }
            else if (value.IsOpenAIVectorizerTextEmbedding3LargeRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.OpenAIVectorizerTextEmbedding3LargeRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAIVectorizerTextEmbedding3LargeRequest, typeInfo);
            }
            else if (value.IsOpenAIVectorizerTextEmbeddingAda002Request)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.OpenAIVectorizerTextEmbeddingAda002Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAIVectorizerTextEmbeddingAda002Request, typeInfo);
            }
            else if (value.IsBasicVectorizerIntfloatMultilingualE5LargeRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.BasicVectorizerIntfloatMultilingualE5LargeRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BasicVectorizerIntfloatMultilingualE5LargeRequest, typeInfo);
            }
            else if (value.IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BasicVectorizerSentenceTransformersMultiQaMpnetBaseCosV1Request, typeInfo);
            }
            else if (value.IsBasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BasicVectorizerSentenceTransformersMultiQaMpnetBaseDotV1Request, typeInfo);
            }
            else if (value.IsHkunlpInstructorXlVectorizerRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.HkunlpInstructorXlVectorizerRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.HkunlpInstructorXlVectorizerRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.HkunlpInstructorXlVectorizerRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HkunlpInstructorXlVectorizerRequest, typeInfo);
            }
            else if (value.IsGoogleVertexAIVectorizerTextEmbedding004Request)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.GoogleVertexAIVectorizerTextEmbedding004Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleVertexAIVectorizerTextEmbedding004Request, typeInfo);
            }
            else if (value.IsGoogleVertexAIVectorizerTextMultilingualEmbedding002Request)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleVertexAIVectorizerTextMultilingualEmbedding002Request, typeInfo);
            }
            else if (value.IsGoogleVertexAIVectorizerGeminiEmbedding001Request)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.GoogleVertexAIVectorizerGeminiEmbedding001Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleVertexAIVectorizerGeminiEmbedding001Request, typeInfo);
            }
            else if (value.IsFastEmbedVectorizerBAAIBgeSmallEnV15Request)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FastEmbedVectorizerBAAIBgeSmallEnV15Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FastEmbedVectorizerBAAIBgeSmallEnV15Request, typeInfo);
            }
            else if (value.IsPrivateVectorizerRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.PrivateVectorizerRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.PrivateVectorizerRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.PrivateVectorizerRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PrivateVectorizerRequest, typeInfo);
            }
        }
    }
}