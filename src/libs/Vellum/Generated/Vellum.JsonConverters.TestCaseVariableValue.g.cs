#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class TestCaseVariableValueJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.TestCaseVariableValue>
    {
        /// <inheritdoc />
        public override global::Vellum.TestCaseVariableValue Read(
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
            if (__jsonProps.Contains("variable_id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("value")) __score1++;
            if (__jsonProps.Contains("variable_id")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("value")) __score2++;
            if (__jsonProps.Contains("variable_id")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("value")) __score3++;
            if (__jsonProps.Contains("variable_id")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("value")) __score4++;
            if (__jsonProps.Contains("variable_id")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("name")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("value")) __score5++;
            if (__jsonProps.Contains("variable_id")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("name")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            if (__jsonProps.Contains("value")) __score6++;
            if (__jsonProps.Contains("variable_id")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("name")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            if (__jsonProps.Contains("value")) __score7++;
            if (__jsonProps.Contains("variable_id")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("name")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            if (__jsonProps.Contains("value")) __score8++;
            if (__jsonProps.Contains("variable_id")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("name")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            if (__jsonProps.Contains("value")) __score9++;
            if (__jsonProps.Contains("variable_id")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("name")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            if (__jsonProps.Contains("value")) __score10++;
            if (__jsonProps.Contains("variable_id")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("name")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            if (__jsonProps.Contains("value")) __score11++;
            if (__jsonProps.Contains("variable_id")) __score11++;
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

            global::Vellum.TestCaseStringVariableValue? testCaseStringVariableValue = default;
            global::Vellum.TestCaseNumberVariableValue? testCaseNumberVariableValue = default;
            global::Vellum.TestCaseJsonVariableValue? testCaseJsonVariableValue = default;
            global::Vellum.TestCaseChatHistoryVariableValue? testCaseChatHistoryVariableValue = default;
            global::Vellum.TestCaseSearchResultsVariableValue? testCaseSearchResultsVariableValue = default;
            global::Vellum.TestCaseErrorVariableValue? testCaseErrorVariableValue = default;
            global::Vellum.TestCaseFunctionCallVariableValue? testCaseFunctionCallVariableValue = default;
            global::Vellum.TestCaseArrayVariableValue? testCaseArrayVariableValue = default;
            global::Vellum.TestCaseAudioVariableValue? testCaseAudioVariableValue = default;
            global::Vellum.TestCaseImageVariableValue? testCaseImageVariableValue = default;
            global::Vellum.TestCaseVideoVariableValue? testCaseVideoVariableValue = default;
            global::Vellum.TestCaseDocumentVariableValue? testCaseDocumentVariableValue = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseStringVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseStringVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseStringVariableValue).Name}");
                        testCaseStringVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseNumberVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseNumberVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseNumberVariableValue).Name}");
                        testCaseNumberVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseJsonVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseJsonVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseJsonVariableValue).Name}");
                        testCaseJsonVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseChatHistoryVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseChatHistoryVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseChatHistoryVariableValue).Name}");
                        testCaseChatHistoryVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseSearchResultsVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseSearchResultsVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseSearchResultsVariableValue).Name}");
                        testCaseSearchResultsVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseErrorVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseErrorVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseErrorVariableValue).Name}");
                        testCaseErrorVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseFunctionCallVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseFunctionCallVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseFunctionCallVariableValue).Name}");
                        testCaseFunctionCallVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseArrayVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseArrayVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseArrayVariableValue).Name}");
                        testCaseArrayVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseAudioVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseAudioVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseAudioVariableValue).Name}");
                        testCaseAudioVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseImageVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseImageVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseImageVariableValue).Name}");
                        testCaseImageVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseVideoVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseVideoVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseVideoVariableValue).Name}");
                        testCaseVideoVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseDocumentVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseDocumentVariableValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseDocumentVariableValue).Name}");
                        testCaseDocumentVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (testCaseStringVariableValue == null && testCaseNumberVariableValue == null && testCaseJsonVariableValue == null && testCaseChatHistoryVariableValue == null && testCaseSearchResultsVariableValue == null && testCaseErrorVariableValue == null && testCaseFunctionCallVariableValue == null && testCaseArrayVariableValue == null && testCaseAudioVariableValue == null && testCaseImageVariableValue == null && testCaseVideoVariableValue == null && testCaseDocumentVariableValue == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseStringVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseStringVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseStringVariableValue).Name}");
                    testCaseStringVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseNumberVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseNumberVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseNumberVariableValue).Name}");
                    testCaseNumberVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseJsonVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseJsonVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseJsonVariableValue).Name}");
                    testCaseJsonVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseChatHistoryVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseChatHistoryVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseChatHistoryVariableValue).Name}");
                    testCaseChatHistoryVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseSearchResultsVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseSearchResultsVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseSearchResultsVariableValue).Name}");
                    testCaseSearchResultsVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseErrorVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseErrorVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseErrorVariableValue).Name}");
                    testCaseErrorVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseFunctionCallVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseFunctionCallVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseFunctionCallVariableValue).Name}");
                    testCaseFunctionCallVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseArrayVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseArrayVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseArrayVariableValue).Name}");
                    testCaseArrayVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseAudioVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseAudioVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseAudioVariableValue).Name}");
                    testCaseAudioVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseImageVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseImageVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseImageVariableValue).Name}");
                    testCaseImageVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseVideoVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseVideoVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseVideoVariableValue).Name}");
                    testCaseVideoVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseDocumentVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseDocumentVariableValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseDocumentVariableValue).Name}");
                    testCaseDocumentVariableValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.TestCaseVariableValue(
                testCaseStringVariableValue,

                testCaseNumberVariableValue,

                testCaseJsonVariableValue,

                testCaseChatHistoryVariableValue,

                testCaseSearchResultsVariableValue,

                testCaseErrorVariableValue,

                testCaseFunctionCallVariableValue,

                testCaseArrayVariableValue,

                testCaseAudioVariableValue,

                testCaseImageVariableValue,

                testCaseVideoVariableValue,

                testCaseDocumentVariableValue
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.TestCaseVariableValue value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTestCaseStringVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseStringVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseStringVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseStringVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestCaseStringVariableValue!, typeInfo);
            }
            else if (value.IsTestCaseNumberVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseNumberVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseNumberVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseNumberVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestCaseNumberVariableValue!, typeInfo);
            }
            else if (value.IsTestCaseJsonVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseJsonVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseJsonVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseJsonVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestCaseJsonVariableValue!, typeInfo);
            }
            else if (value.IsTestCaseChatHistoryVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseChatHistoryVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseChatHistoryVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseChatHistoryVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestCaseChatHistoryVariableValue!, typeInfo);
            }
            else if (value.IsTestCaseSearchResultsVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseSearchResultsVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseSearchResultsVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseSearchResultsVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestCaseSearchResultsVariableValue!, typeInfo);
            }
            else if (value.IsTestCaseErrorVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseErrorVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseErrorVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseErrorVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestCaseErrorVariableValue!, typeInfo);
            }
            else if (value.IsTestCaseFunctionCallVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseFunctionCallVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseFunctionCallVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseFunctionCallVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestCaseFunctionCallVariableValue!, typeInfo);
            }
            else if (value.IsTestCaseArrayVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseArrayVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseArrayVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseArrayVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestCaseArrayVariableValue!, typeInfo);
            }
            else if (value.IsTestCaseAudioVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseAudioVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseAudioVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseAudioVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestCaseAudioVariableValue!, typeInfo);
            }
            else if (value.IsTestCaseImageVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseImageVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseImageVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseImageVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestCaseImageVariableValue!, typeInfo);
            }
            else if (value.IsTestCaseVideoVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseVideoVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseVideoVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseVideoVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestCaseVideoVariableValue!, typeInfo);
            }
            else if (value.IsTestCaseDocumentVariableValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestCaseDocumentVariableValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestCaseDocumentVariableValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestCaseDocumentVariableValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestCaseDocumentVariableValue!, typeInfo);
            }
        }
    }
}