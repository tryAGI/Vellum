#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class DocumentIndexChunkingRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.DocumentIndexChunkingRequest>
    {
        /// <inheritdoc />
        public override global::Vellum.DocumentIndexChunkingRequest Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("chunker_config")) __score0++;
            if (__jsonProps.Contains("chunker_config.character_limit")) __score0++;
            if (__jsonProps.Contains("chunker_name")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("chunker_config")) __score1++;
            if (__jsonProps.Contains("chunker_config.character_limit")) __score1++;
            if (__jsonProps.Contains("chunker_config.min_overlap_ratio")) __score1++;
            if (__jsonProps.Contains("chunker_name")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("chunker_config")) __score2++;
            if (__jsonProps.Contains("chunker_config.overlap_ratio")) __score2++;
            if (__jsonProps.Contains("chunker_config.token_limit")) __score2++;
            if (__jsonProps.Contains("chunker_name")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("chunker_config")) __score3++;
            if (__jsonProps.Contains("chunker_config.delimiter")) __score3++;
            if (__jsonProps.Contains("chunker_config.is_regex")) __score3++;
            if (__jsonProps.Contains("chunker_name")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Vellum.ReductoChunkingRequest? reductoChunkingRequest = default;
            global::Vellum.SentenceChunkingRequest? sentenceChunkingRequest = default;
            global::Vellum.TokenOverlappingWindowChunkingRequest? tokenOverlappingWindowChunkingRequest = default;
            global::Vellum.DelimiterChunkingRequest? delimiterChunkingRequest = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ReductoChunkingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ReductoChunkingRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ReductoChunkingRequest).Name}");
                        reductoChunkingRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.SentenceChunkingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.SentenceChunkingRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.SentenceChunkingRequest).Name}");
                        sentenceChunkingRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TokenOverlappingWindowChunkingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TokenOverlappingWindowChunkingRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TokenOverlappingWindowChunkingRequest).Name}");
                        tokenOverlappingWindowChunkingRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DelimiterChunkingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DelimiterChunkingRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DelimiterChunkingRequest).Name}");
                        delimiterChunkingRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (reductoChunkingRequest == null && sentenceChunkingRequest == null && tokenOverlappingWindowChunkingRequest == null && delimiterChunkingRequest == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ReductoChunkingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ReductoChunkingRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ReductoChunkingRequest).Name}");
                    reductoChunkingRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.SentenceChunkingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.SentenceChunkingRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.SentenceChunkingRequest).Name}");
                    sentenceChunkingRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TokenOverlappingWindowChunkingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TokenOverlappingWindowChunkingRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TokenOverlappingWindowChunkingRequest).Name}");
                    tokenOverlappingWindowChunkingRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DelimiterChunkingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DelimiterChunkingRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DelimiterChunkingRequest).Name}");
                    delimiterChunkingRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.DocumentIndexChunkingRequest(
                reductoChunkingRequest,

                sentenceChunkingRequest,

                tokenOverlappingWindowChunkingRequest,

                delimiterChunkingRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.DocumentIndexChunkingRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsReductoChunkingRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ReductoChunkingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ReductoChunkingRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ReductoChunkingRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReductoChunkingRequest!, typeInfo);
            }
            else if (value.IsSentenceChunkingRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.SentenceChunkingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.SentenceChunkingRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.SentenceChunkingRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SentenceChunkingRequest!, typeInfo);
            }
            else if (value.IsTokenOverlappingWindowChunkingRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TokenOverlappingWindowChunkingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TokenOverlappingWindowChunkingRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TokenOverlappingWindowChunkingRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TokenOverlappingWindowChunkingRequest!, typeInfo);
            }
            else if (value.IsDelimiterChunkingRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DelimiterChunkingRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DelimiterChunkingRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DelimiterChunkingRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DelimiterChunkingRequest!, typeInfo);
            }
        }
    }
}