#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class DocumentIndexChunkingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.DocumentIndexChunking>
    {
        /// <inheritdoc />
        public override global::Vellum.DocumentIndexChunking Read(
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
            if (__jsonProps.Contains("chunker_config")) __score0++;
            if (__jsonProps.Contains("chunker_name")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("chunker_config")) __score1++;
            if (__jsonProps.Contains("chunker_name")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("chunker_config")) __score2++;
            if (__jsonProps.Contains("chunker_name")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("chunker_config")) __score3++;
            if (__jsonProps.Contains("chunker_name")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Vellum.ReductoChunking? reductoChunking = default;
            global::Vellum.SentenceChunking? sentenceChunking = default;
            global::Vellum.TokenOverlappingWindowChunking? tokenOverlappingWindowChunking = default;
            global::Vellum.DelimiterChunking? delimiterChunking = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ReductoChunking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ReductoChunking> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ReductoChunking).Name}");
                        reductoChunking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.SentenceChunking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.SentenceChunking> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.SentenceChunking).Name}");
                        sentenceChunking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TokenOverlappingWindowChunking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TokenOverlappingWindowChunking> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TokenOverlappingWindowChunking).Name}");
                        tokenOverlappingWindowChunking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DelimiterChunking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DelimiterChunking> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DelimiterChunking).Name}");
                        delimiterChunking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (reductoChunking == null && sentenceChunking == null && tokenOverlappingWindowChunking == null && delimiterChunking == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ReductoChunking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ReductoChunking> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ReductoChunking).Name}");
                    reductoChunking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.SentenceChunking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.SentenceChunking> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.SentenceChunking).Name}");
                    sentenceChunking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TokenOverlappingWindowChunking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TokenOverlappingWindowChunking> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TokenOverlappingWindowChunking).Name}");
                    tokenOverlappingWindowChunking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DelimiterChunking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DelimiterChunking> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DelimiterChunking).Name}");
                    delimiterChunking = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.DocumentIndexChunking(
                reductoChunking,

                sentenceChunking,

                tokenOverlappingWindowChunking,

                delimiterChunking
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.DocumentIndexChunking value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsReductoChunking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ReductoChunking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ReductoChunking?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ReductoChunking).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReductoChunking, typeInfo);
            }
            else if (value.IsSentenceChunking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.SentenceChunking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.SentenceChunking?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.SentenceChunking).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SentenceChunking, typeInfo);
            }
            else if (value.IsTokenOverlappingWindowChunking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TokenOverlappingWindowChunking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TokenOverlappingWindowChunking?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TokenOverlappingWindowChunking).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TokenOverlappingWindowChunking, typeInfo);
            }
            else if (value.IsDelimiterChunking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.DelimiterChunking), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.DelimiterChunking?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.DelimiterChunking).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DelimiterChunking, typeInfo);
            }
        }
    }
}