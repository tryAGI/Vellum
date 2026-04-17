#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class ExecutionVellumValueJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.ExecutionVellumValue>
    {
        /// <inheritdoc />
        public override global::Vellum.ExecutionVellumValue Read(
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
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("value")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("value")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("value")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("value")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("name")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("value")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("name")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            if (__jsonProps.Contains("value")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("id")) __score7++;
            if (__jsonProps.Contains("name")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            if (__jsonProps.Contains("value")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("id")) __score8++;
            if (__jsonProps.Contains("name")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            if (__jsonProps.Contains("value")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("id")) __score9++;
            if (__jsonProps.Contains("name")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            if (__jsonProps.Contains("value")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("id")) __score10++;
            if (__jsonProps.Contains("name")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            if (__jsonProps.Contains("value")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("id")) __score11++;
            if (__jsonProps.Contains("name")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            if (__jsonProps.Contains("value")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("id")) __score12++;
            if (__jsonProps.Contains("name")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            if (__jsonProps.Contains("value")) __score12++;
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
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }

            global::Vellum.ExecutionStringVellumValue? executionStringVellumValue = default;
            global::Vellum.ExecutionNumberVellumValue? executionNumberVellumValue = default;
            global::Vellum.ExecutionJsonVellumValue? executionJsonVellumValue = default;
            global::Vellum.ExecutionChatHistoryVellumValue? executionChatHistoryVellumValue = default;
            global::Vellum.ExecutionSearchResultsVellumValue? executionSearchResultsVellumValue = default;
            global::Vellum.ExecutionErrorVellumValue? executionErrorVellumValue = default;
            global::Vellum.ExecutionArrayVellumValue? executionArrayVellumValue = default;
            global::Vellum.ExecutionFunctionCallVellumValue? executionFunctionCallVellumValue = default;
            global::Vellum.ExecutionThinkingVellumValue? executionThinkingVellumValue = default;
            global::Vellum.ExecutionAudioVellumValue? executionAudioVellumValue = default;
            global::Vellum.ExecutionVideoVellumValue? executionVideoVellumValue = default;
            global::Vellum.ExecutionImageVellumValue? executionImageVellumValue = default;
            global::Vellum.ExecutionDocumentVellumValue? executionDocumentVellumValue = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionStringVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionStringVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionStringVellumValue).Name}");
                        executionStringVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionNumberVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionNumberVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionNumberVellumValue).Name}");
                        executionNumberVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionJsonVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionJsonVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionJsonVellumValue).Name}");
                        executionJsonVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionChatHistoryVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionChatHistoryVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionChatHistoryVellumValue).Name}");
                        executionChatHistoryVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionSearchResultsVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionSearchResultsVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionSearchResultsVellumValue).Name}");
                        executionSearchResultsVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionErrorVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionErrorVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionErrorVellumValue).Name}");
                        executionErrorVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionArrayVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionArrayVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionArrayVellumValue).Name}");
                        executionArrayVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionFunctionCallVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionFunctionCallVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionFunctionCallVellumValue).Name}");
                        executionFunctionCallVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionThinkingVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionThinkingVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionThinkingVellumValue).Name}");
                        executionThinkingVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionAudioVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionAudioVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionAudioVellumValue).Name}");
                        executionAudioVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionVideoVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionVideoVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionVideoVellumValue).Name}");
                        executionVideoVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionImageVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionImageVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionImageVellumValue).Name}");
                        executionImageVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionDocumentVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionDocumentVellumValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionDocumentVellumValue).Name}");
                        executionDocumentVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (executionStringVellumValue == null && executionNumberVellumValue == null && executionJsonVellumValue == null && executionChatHistoryVellumValue == null && executionSearchResultsVellumValue == null && executionErrorVellumValue == null && executionArrayVellumValue == null && executionFunctionCallVellumValue == null && executionThinkingVellumValue == null && executionAudioVellumValue == null && executionVideoVellumValue == null && executionImageVellumValue == null && executionDocumentVellumValue == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionStringVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionStringVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionStringVellumValue).Name}");
                    executionStringVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionNumberVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionNumberVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionNumberVellumValue).Name}");
                    executionNumberVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionJsonVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionJsonVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionJsonVellumValue).Name}");
                    executionJsonVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionChatHistoryVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionChatHistoryVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionChatHistoryVellumValue).Name}");
                    executionChatHistoryVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionSearchResultsVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionSearchResultsVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionSearchResultsVellumValue).Name}");
                    executionSearchResultsVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionErrorVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionErrorVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionErrorVellumValue).Name}");
                    executionErrorVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionArrayVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionArrayVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionArrayVellumValue).Name}");
                    executionArrayVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionFunctionCallVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionFunctionCallVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionFunctionCallVellumValue).Name}");
                    executionFunctionCallVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionThinkingVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionThinkingVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionThinkingVellumValue).Name}");
                    executionThinkingVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionAudioVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionAudioVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionAudioVellumValue).Name}");
                    executionAudioVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionVideoVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionVideoVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionVideoVellumValue).Name}");
                    executionVideoVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionImageVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionImageVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionImageVellumValue).Name}");
                    executionImageVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionDocumentVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionDocumentVellumValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionDocumentVellumValue).Name}");
                    executionDocumentVellumValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.ExecutionVellumValue(
                executionStringVellumValue,

                executionNumberVellumValue,

                executionJsonVellumValue,

                executionChatHistoryVellumValue,

                executionSearchResultsVellumValue,

                executionErrorVellumValue,

                executionArrayVellumValue,

                executionFunctionCallVellumValue,

                executionThinkingVellumValue,

                executionAudioVellumValue,

                executionVideoVellumValue,

                executionImageVellumValue,

                executionDocumentVellumValue
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.ExecutionVellumValue value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsExecutionStringVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionStringVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionStringVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionStringVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExecutionStringVellumValue!, typeInfo);
            }
            else if (value.IsExecutionNumberVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionNumberVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionNumberVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionNumberVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExecutionNumberVellumValue!, typeInfo);
            }
            else if (value.IsExecutionJsonVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionJsonVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionJsonVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionJsonVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExecutionJsonVellumValue!, typeInfo);
            }
            else if (value.IsExecutionChatHistoryVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionChatHistoryVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionChatHistoryVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionChatHistoryVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExecutionChatHistoryVellumValue!, typeInfo);
            }
            else if (value.IsExecutionSearchResultsVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionSearchResultsVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionSearchResultsVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionSearchResultsVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExecutionSearchResultsVellumValue!, typeInfo);
            }
            else if (value.IsExecutionErrorVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionErrorVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionErrorVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionErrorVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExecutionErrorVellumValue!, typeInfo);
            }
            else if (value.IsExecutionArrayVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionArrayVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionArrayVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionArrayVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExecutionArrayVellumValue!, typeInfo);
            }
            else if (value.IsExecutionFunctionCallVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionFunctionCallVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionFunctionCallVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionFunctionCallVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExecutionFunctionCallVellumValue!, typeInfo);
            }
            else if (value.IsExecutionThinkingVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionThinkingVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionThinkingVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionThinkingVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExecutionThinkingVellumValue!, typeInfo);
            }
            else if (value.IsExecutionAudioVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionAudioVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionAudioVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionAudioVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExecutionAudioVellumValue!, typeInfo);
            }
            else if (value.IsExecutionVideoVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionVideoVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionVideoVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionVideoVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExecutionVideoVellumValue!, typeInfo);
            }
            else if (value.IsExecutionImageVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionImageVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionImageVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionImageVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExecutionImageVellumValue!, typeInfo);
            }
            else if (value.IsExecutionDocumentVellumValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExecutionDocumentVellumValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExecutionDocumentVellumValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExecutionDocumentVellumValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExecutionDocumentVellumValue!, typeInfo);
            }
        }
    }
}