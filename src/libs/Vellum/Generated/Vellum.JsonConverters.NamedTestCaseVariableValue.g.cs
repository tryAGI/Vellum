#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class NamedTestCaseVariableValueJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.NamedTestCaseVariableValue>
    {
        /// <inheritdoc />
        public override global::Vellum.NamedTestCaseVariableValue Read(
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

            global::Vellum.NamedTestCaseStringVariableValue? namedTestCaseStringVariableValue = default;
            global::Vellum.NamedTestCaseNumberVariableValue? namedTestCaseNumberVariableValue = default;
            global::Vellum.NamedTestCaseJsonVariableValue? namedTestCaseJsonVariableValue = default;
            global::Vellum.NamedTestCaseChatHistoryVariableValue? namedTestCaseChatHistoryVariableValue = default;
            global::Vellum.NamedTestCaseSearchResultsVariableValue? namedTestCaseSearchResultsVariableValue = default;
            global::Vellum.NamedTestCaseErrorVariableValue? namedTestCaseErrorVariableValue = default;
            global::Vellum.NamedTestCaseFunctionCallVariableValue? namedTestCaseFunctionCallVariableValue = default;
            global::Vellum.NamedTestCaseArrayVariableValue? namedTestCaseArrayVariableValue = default;
            global::Vellum.NamedTestCaseAudioVariableValue? namedTestCaseAudioVariableValue = default;
            global::Vellum.NamedTestCaseVideoVariableValue? namedTestCaseVideoVariableValue = default;
            global::Vellum.NamedTestCaseImageVariableValue? namedTestCaseImageVariableValue = default;
            global::Vellum.NamedTestCaseDocumentVariableValue? namedTestCaseDocumentVariableValue = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseStringVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseStringVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseStringVariableValue).Name}");
                        namedTestCaseStringVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseNumberVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseNumberVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseNumberVariableValue).Name}");
                        namedTestCaseNumberVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseJsonVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseJsonVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseJsonVariableValue).Name}");
                        namedTestCaseJsonVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseChatHistoryVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseChatHistoryVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseChatHistoryVariableValue).Name}");
                        namedTestCaseChatHistoryVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseSearchResultsVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseSearchResultsVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseSearchResultsVariableValue).Name}");
                        namedTestCaseSearchResultsVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseErrorVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseErrorVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseErrorVariableValue).Name}");
                        namedTestCaseErrorVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseFunctionCallVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseFunctionCallVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseFunctionCallVariableValue).Name}");
                        namedTestCaseFunctionCallVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseArrayVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseArrayVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseArrayVariableValue).Name}");
                        namedTestCaseArrayVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseAudioVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseAudioVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseAudioVariableValue).Name}");
                        namedTestCaseAudioVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseVideoVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseVideoVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseVideoVariableValue).Name}");
                        namedTestCaseVideoVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseImageVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseImageVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseImageVariableValue).Name}");
                        namedTestCaseImageVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseDocumentVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseDocumentVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseDocumentVariableValue).Name}");
                        namedTestCaseDocumentVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (namedTestCaseStringVariableValue == null && namedTestCaseNumberVariableValue == null && namedTestCaseJsonVariableValue == null && namedTestCaseChatHistoryVariableValue == null && namedTestCaseSearchResultsVariableValue == null && namedTestCaseErrorVariableValue == null && namedTestCaseFunctionCallVariableValue == null && namedTestCaseArrayVariableValue == null && namedTestCaseAudioVariableValue == null && namedTestCaseVideoVariableValue == null && namedTestCaseImageVariableValue == null && namedTestCaseDocumentVariableValue == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseStringVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseStringVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseStringVariableValue).Name}");
                    namedTestCaseStringVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseNumberVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseNumberVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseNumberVariableValue).Name}");
                    namedTestCaseNumberVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseJsonVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseJsonVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseJsonVariableValue).Name}");
                    namedTestCaseJsonVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseChatHistoryVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseChatHistoryVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseChatHistoryVariableValue).Name}");
                    namedTestCaseChatHistoryVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseSearchResultsVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseSearchResultsVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseSearchResultsVariableValue).Name}");
                    namedTestCaseSearchResultsVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseErrorVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseErrorVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseErrorVariableValue).Name}");
                    namedTestCaseErrorVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseFunctionCallVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseFunctionCallVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseFunctionCallVariableValue).Name}");
                    namedTestCaseFunctionCallVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseArrayVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseArrayVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseArrayVariableValue).Name}");
                    namedTestCaseArrayVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseAudioVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseAudioVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseAudioVariableValue).Name}");
                    namedTestCaseAudioVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseVideoVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseVideoVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseVideoVariableValue).Name}");
                    namedTestCaseVideoVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseImageVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseImageVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseImageVariableValue).Name}");
                    namedTestCaseImageVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseDocumentVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseDocumentVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseDocumentVariableValue).Name}");
                    namedTestCaseDocumentVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.NamedTestCaseVariableValue(
                namedTestCaseStringVariableValue,

                namedTestCaseNumberVariableValue,

                namedTestCaseJsonVariableValue,

                namedTestCaseChatHistoryVariableValue,

                namedTestCaseSearchResultsVariableValue,

                namedTestCaseErrorVariableValue,

                namedTestCaseFunctionCallVariableValue,

                namedTestCaseArrayVariableValue,

                namedTestCaseAudioVariableValue,

                namedTestCaseVideoVariableValue,

                namedTestCaseImageVariableValue,

                namedTestCaseDocumentVariableValue
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.NamedTestCaseVariableValue value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNamedTestCaseStringVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseStringVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseStringVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseStringVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseStringVariableValue!, typeInfo);
            }
            else if (value.IsNamedTestCaseNumberVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseNumberVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseNumberVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseNumberVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseNumberVariableValue!, typeInfo);
            }
            else if (value.IsNamedTestCaseJsonVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseJsonVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseJsonVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseJsonVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseJsonVariableValue!, typeInfo);
            }
            else if (value.IsNamedTestCaseChatHistoryVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseChatHistoryVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseChatHistoryVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseChatHistoryVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseChatHistoryVariableValue!, typeInfo);
            }
            else if (value.IsNamedTestCaseSearchResultsVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseSearchResultsVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseSearchResultsVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseSearchResultsVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseSearchResultsVariableValue!, typeInfo);
            }
            else if (value.IsNamedTestCaseErrorVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseErrorVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseErrorVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseErrorVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseErrorVariableValue!, typeInfo);
            }
            else if (value.IsNamedTestCaseFunctionCallVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseFunctionCallVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseFunctionCallVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseFunctionCallVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseFunctionCallVariableValue!, typeInfo);
            }
            else if (value.IsNamedTestCaseArrayVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseArrayVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseArrayVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseArrayVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseArrayVariableValue!, typeInfo);
            }
            else if (value.IsNamedTestCaseAudioVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseAudioVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseAudioVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseAudioVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseAudioVariableValue!, typeInfo);
            }
            else if (value.IsNamedTestCaseVideoVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseVideoVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseVideoVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseVideoVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseVideoVariableValue!, typeInfo);
            }
            else if (value.IsNamedTestCaseImageVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseImageVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseImageVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseImageVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseImageVariableValue!, typeInfo);
            }
            else if (value.IsNamedTestCaseDocumentVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NamedTestCaseDocumentVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NamedTestCaseDocumentVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NamedTestCaseDocumentVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NamedTestCaseDocumentVariableValue!, typeInfo);
            }
        }
    }
}