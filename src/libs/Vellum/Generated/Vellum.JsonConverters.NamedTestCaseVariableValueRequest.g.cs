#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class NamedTestCaseVariableValueRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.NamedTestCaseVariableValueRequest>
    {
        /// <inheritdoc />
        public override global::Vellum.NamedTestCaseVariableValueRequest Read(
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
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("value")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("value")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("value")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("value")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("name")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("value")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("name")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            if (__jsonProps.Contains("value")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("name")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            if (__jsonProps.Contains("value")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("name")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            if (__jsonProps.Contains("value")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("name")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            if (__jsonProps.Contains("value")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("name")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            if (__jsonProps.Contains("value")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("name")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            if (__jsonProps.Contains("value")) __score11++;
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

            global::Vellum.NamedTestCaseStringVariableValueRequest? namedTestCaseStringVariableValueRequest = default;
            global::Vellum.NamedTestCaseNumberVariableValueRequest? namedTestCaseNumberVariableValueRequest = default;
            global::Vellum.NamedTestCaseJsonVariableValueRequest? namedTestCaseJsonVariableValueRequest = default;
            global::Vellum.NamedTestCaseChatHistoryVariableValueRequest? namedTestCaseChatHistoryVariableValueRequest = default;
            global::Vellum.NamedTestCaseSearchResultsVariableValueRequest? namedTestCaseSearchResultsVariableValueRequest = default;
            global::Vellum.NamedTestCaseErrorVariableValueRequest? namedTestCaseErrorVariableValueRequest = default;
            global::Vellum.NamedTestCaseFunctionCallVariableValueRequest? namedTestCaseFunctionCallVariableValueRequest = default;
            global::Vellum.NamedTestCaseArrayVariableValueRequest? namedTestCaseArrayVariableValueRequest = default;
            global::Vellum.NamedTestCaseAudioVariableValueRequest? namedTestCaseAudioVariableValueRequest = default;
            global::Vellum.NamedTestCaseVideoVariableValueRequest? namedTestCaseVideoVariableValueRequest = default;
            global::Vellum.NamedTestCaseImageVariableValueRequest? namedTestCaseImageVariableValueRequest = default;
            global::Vellum.NamedTestCaseDocumentVariableValueRequest? namedTestCaseDocumentVariableValueRequest = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseStringVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseStringVariableValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseStringVariableValueRequest).Name}");
                        namedTestCaseStringVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseNumberVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseNumberVariableValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseNumberVariableValueRequest).Name}");
                        namedTestCaseNumberVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseJsonVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseJsonVariableValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseJsonVariableValueRequest).Name}");
                        namedTestCaseJsonVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseChatHistoryVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseChatHistoryVariableValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseChatHistoryVariableValueRequest).Name}");
                        namedTestCaseChatHistoryVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseSearchResultsVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseSearchResultsVariableValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseSearchResultsVariableValueRequest).Name}");
                        namedTestCaseSearchResultsVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseErrorVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseErrorVariableValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseErrorVariableValueRequest).Name}");
                        namedTestCaseErrorVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseFunctionCallVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseFunctionCallVariableValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseFunctionCallVariableValueRequest).Name}");
                        namedTestCaseFunctionCallVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseArrayVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseArrayVariableValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseArrayVariableValueRequest).Name}");
                        namedTestCaseArrayVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseAudioVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseAudioVariableValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseAudioVariableValueRequest).Name}");
                        namedTestCaseAudioVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseVideoVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseVideoVariableValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseVideoVariableValueRequest).Name}");
                        namedTestCaseVideoVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseImageVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseImageVariableValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseImageVariableValueRequest).Name}");
                        namedTestCaseImageVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseDocumentVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseDocumentVariableValueRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseDocumentVariableValueRequest).Name}");
                        namedTestCaseDocumentVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (namedTestCaseStringVariableValueRequest == null && namedTestCaseNumberVariableValueRequest == null && namedTestCaseJsonVariableValueRequest == null && namedTestCaseChatHistoryVariableValueRequest == null && namedTestCaseSearchResultsVariableValueRequest == null && namedTestCaseErrorVariableValueRequest == null && namedTestCaseFunctionCallVariableValueRequest == null && namedTestCaseArrayVariableValueRequest == null && namedTestCaseAudioVariableValueRequest == null && namedTestCaseVideoVariableValueRequest == null && namedTestCaseImageVariableValueRequest == null && namedTestCaseDocumentVariableValueRequest == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseStringVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseStringVariableValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseStringVariableValueRequest).Name}");
                    namedTestCaseStringVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseNumberVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseNumberVariableValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseNumberVariableValueRequest).Name}");
                    namedTestCaseNumberVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseJsonVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseJsonVariableValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseJsonVariableValueRequest).Name}");
                    namedTestCaseJsonVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseChatHistoryVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseChatHistoryVariableValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseChatHistoryVariableValueRequest).Name}");
                    namedTestCaseChatHistoryVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseSearchResultsVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseSearchResultsVariableValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseSearchResultsVariableValueRequest).Name}");
                    namedTestCaseSearchResultsVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseErrorVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseErrorVariableValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseErrorVariableValueRequest).Name}");
                    namedTestCaseErrorVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseFunctionCallVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseFunctionCallVariableValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseFunctionCallVariableValueRequest).Name}");
                    namedTestCaseFunctionCallVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseArrayVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseArrayVariableValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseArrayVariableValueRequest).Name}");
                    namedTestCaseArrayVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseAudioVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseAudioVariableValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseAudioVariableValueRequest).Name}");
                    namedTestCaseAudioVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseVideoVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseVideoVariableValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseVideoVariableValueRequest).Name}");
                    namedTestCaseVideoVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseImageVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseImageVariableValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseImageVariableValueRequest).Name}");
                    namedTestCaseImageVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseDocumentVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseDocumentVariableValueRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseDocumentVariableValueRequest).Name}");
                    namedTestCaseDocumentVariableValueRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.NamedTestCaseVariableValueRequest(
                namedTestCaseStringVariableValueRequest,

                namedTestCaseNumberVariableValueRequest,

                namedTestCaseJsonVariableValueRequest,

                namedTestCaseChatHistoryVariableValueRequest,

                namedTestCaseSearchResultsVariableValueRequest,

                namedTestCaseErrorVariableValueRequest,

                namedTestCaseFunctionCallVariableValueRequest,

                namedTestCaseArrayVariableValueRequest,

                namedTestCaseAudioVariableValueRequest,

                namedTestCaseVideoVariableValueRequest,

                namedTestCaseImageVariableValueRequest,

                namedTestCaseDocumentVariableValueRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.NamedTestCaseVariableValueRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNamedTestCaseStringVariableValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseStringVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseStringVariableValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseStringVariableValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseStringVariableValueRequest!, typeInfo);
            }
            else if (value.IsNamedTestCaseNumberVariableValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseNumberVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseNumberVariableValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseNumberVariableValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseNumberVariableValueRequest!, typeInfo);
            }
            else if (value.IsNamedTestCaseJsonVariableValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseJsonVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseJsonVariableValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseJsonVariableValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseJsonVariableValueRequest!, typeInfo);
            }
            else if (value.IsNamedTestCaseChatHistoryVariableValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseChatHistoryVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseChatHistoryVariableValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseChatHistoryVariableValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseChatHistoryVariableValueRequest!, typeInfo);
            }
            else if (value.IsNamedTestCaseSearchResultsVariableValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseSearchResultsVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseSearchResultsVariableValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseSearchResultsVariableValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseSearchResultsVariableValueRequest!, typeInfo);
            }
            else if (value.IsNamedTestCaseErrorVariableValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseErrorVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseErrorVariableValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseErrorVariableValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseErrorVariableValueRequest!, typeInfo);
            }
            else if (value.IsNamedTestCaseFunctionCallVariableValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseFunctionCallVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseFunctionCallVariableValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseFunctionCallVariableValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseFunctionCallVariableValueRequest!, typeInfo);
            }
            else if (value.IsNamedTestCaseArrayVariableValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseArrayVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseArrayVariableValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseArrayVariableValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseArrayVariableValueRequest!, typeInfo);
            }
            else if (value.IsNamedTestCaseAudioVariableValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseAudioVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseAudioVariableValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseAudioVariableValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseAudioVariableValueRequest!, typeInfo);
            }
            else if (value.IsNamedTestCaseVideoVariableValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseVideoVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseVideoVariableValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseVideoVariableValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseVideoVariableValueRequest!, typeInfo);
            }
            else if (value.IsNamedTestCaseImageVariableValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseImageVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseImageVariableValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseImageVariableValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseImageVariableValueRequest!, typeInfo);
            }
            else if (value.IsNamedTestCaseDocumentVariableValueRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseDocumentVariableValueRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseDocumentVariableValueRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseDocumentVariableValueRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseDocumentVariableValueRequest!, typeInfo);
            }
        }
    }
}