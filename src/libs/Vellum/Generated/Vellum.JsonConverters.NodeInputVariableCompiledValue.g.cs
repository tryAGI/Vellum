#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class NodeInputVariableCompiledValueJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.NodeInputVariableCompiledValue>
    {
        /// <inheritdoc />
        public override global::Vellum.NodeInputVariableCompiledValue Read(
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
            if (__jsonProps.Contains("key")) __score0++;
            if (__jsonProps.Contains("node_input_id")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("key")) __score1++;
            if (__jsonProps.Contains("node_input_id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("value")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("key")) __score2++;
            if (__jsonProps.Contains("node_input_id")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("value")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("key")) __score3++;
            if (__jsonProps.Contains("node_input_id")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("value")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("key")) __score4++;
            if (__jsonProps.Contains("node_input_id")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("value")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("key")) __score5++;
            if (__jsonProps.Contains("node_input_id")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("value")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("key")) __score6++;
            if (__jsonProps.Contains("node_input_id")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            if (__jsonProps.Contains("value")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("key")) __score7++;
            if (__jsonProps.Contains("node_input_id")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            if (__jsonProps.Contains("value")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("key")) __score8++;
            if (__jsonProps.Contains("node_input_id")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            if (__jsonProps.Contains("value")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("key")) __score9++;
            if (__jsonProps.Contains("node_input_id")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            if (__jsonProps.Contains("value")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("key")) __score10++;
            if (__jsonProps.Contains("node_input_id")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            if (__jsonProps.Contains("value")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("key")) __score11++;
            if (__jsonProps.Contains("node_input_id")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            if (__jsonProps.Contains("value")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("key")) __score12++;
            if (__jsonProps.Contains("node_input_id")) __score12++;
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

            global::Vellum.NodeInputCompiledStringValue? nodeInputCompiledStringValue = default;
            global::Vellum.NodeInputCompiledNumberValue? nodeInputCompiledNumberValue = default;
            global::Vellum.NodeInputCompiledJsonValue? nodeInputCompiledJsonValue = default;
            global::Vellum.NodeInputCompiledChatHistoryValue? nodeInputCompiledChatHistoryValue = default;
            global::Vellum.NodeInputCompiledSearchResultsValue? nodeInputCompiledSearchResultsValue = default;
            global::Vellum.NodeInputCompiledErrorValue? nodeInputCompiledErrorValue = default;
            global::Vellum.NodeInputCompiledArrayValue? nodeInputCompiledArrayValue = default;
            global::Vellum.NodeInputCompiledFunctionCallValue? nodeInputCompiledFunctionCallValue = default;
            global::Vellum.NodeInputCompiledSecretValue? nodeInputCompiledSecretValue = default;
            global::Vellum.NodeInputCompiledAudioValue? nodeInputCompiledAudioValue = default;
            global::Vellum.NodeInputCompiledVideoValue? nodeInputCompiledVideoValue = default;
            global::Vellum.NodeInputCompiledImageValue? nodeInputCompiledImageValue = default;
            global::Vellum.NodeInputCompiledDocumentValue? nodeInputCompiledDocumentValue = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledStringValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledStringValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledStringValue).Name}");
                        nodeInputCompiledStringValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledNumberValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledNumberValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledNumberValue).Name}");
                        nodeInputCompiledNumberValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledJsonValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledJsonValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledJsonValue).Name}");
                        nodeInputCompiledJsonValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledChatHistoryValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledChatHistoryValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledChatHistoryValue).Name}");
                        nodeInputCompiledChatHistoryValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledSearchResultsValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledSearchResultsValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledSearchResultsValue).Name}");
                        nodeInputCompiledSearchResultsValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledErrorValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledErrorValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledErrorValue).Name}");
                        nodeInputCompiledErrorValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledArrayValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledArrayValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledArrayValue).Name}");
                        nodeInputCompiledArrayValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledFunctionCallValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledFunctionCallValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledFunctionCallValue).Name}");
                        nodeInputCompiledFunctionCallValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledSecretValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledSecretValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledSecretValue).Name}");
                        nodeInputCompiledSecretValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledAudioValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledAudioValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledAudioValue).Name}");
                        nodeInputCompiledAudioValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledVideoValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledVideoValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledVideoValue).Name}");
                        nodeInputCompiledVideoValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledImageValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledImageValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledImageValue).Name}");
                        nodeInputCompiledImageValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledDocumentValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledDocumentValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledDocumentValue).Name}");
                        nodeInputCompiledDocumentValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (nodeInputCompiledStringValue == null && nodeInputCompiledNumberValue == null && nodeInputCompiledJsonValue == null && nodeInputCompiledChatHistoryValue == null && nodeInputCompiledSearchResultsValue == null && nodeInputCompiledErrorValue == null && nodeInputCompiledArrayValue == null && nodeInputCompiledFunctionCallValue == null && nodeInputCompiledSecretValue == null && nodeInputCompiledAudioValue == null && nodeInputCompiledVideoValue == null && nodeInputCompiledImageValue == null && nodeInputCompiledDocumentValue == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledStringValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledStringValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledStringValue).Name}");
                    nodeInputCompiledStringValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledNumberValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledNumberValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledNumberValue).Name}");
                    nodeInputCompiledNumberValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledJsonValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledJsonValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledJsonValue).Name}");
                    nodeInputCompiledJsonValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledChatHistoryValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledChatHistoryValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledChatHistoryValue).Name}");
                    nodeInputCompiledChatHistoryValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledSearchResultsValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledSearchResultsValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledSearchResultsValue).Name}");
                    nodeInputCompiledSearchResultsValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledErrorValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledErrorValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledErrorValue).Name}");
                    nodeInputCompiledErrorValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledArrayValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledArrayValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledArrayValue).Name}");
                    nodeInputCompiledArrayValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledFunctionCallValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledFunctionCallValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledFunctionCallValue).Name}");
                    nodeInputCompiledFunctionCallValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledSecretValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledSecretValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledSecretValue).Name}");
                    nodeInputCompiledSecretValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledAudioValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledAudioValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledAudioValue).Name}");
                    nodeInputCompiledAudioValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledVideoValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledVideoValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledVideoValue).Name}");
                    nodeInputCompiledVideoValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledImageValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledImageValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledImageValue).Name}");
                    nodeInputCompiledImageValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledDocumentValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledDocumentValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledDocumentValue).Name}");
                    nodeInputCompiledDocumentValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.NodeInputVariableCompiledValue(
                nodeInputCompiledStringValue,

                nodeInputCompiledNumberValue,

                nodeInputCompiledJsonValue,

                nodeInputCompiledChatHistoryValue,

                nodeInputCompiledSearchResultsValue,

                nodeInputCompiledErrorValue,

                nodeInputCompiledArrayValue,

                nodeInputCompiledFunctionCallValue,

                nodeInputCompiledSecretValue,

                nodeInputCompiledAudioValue,

                nodeInputCompiledVideoValue,

                nodeInputCompiledImageValue,

                nodeInputCompiledDocumentValue
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.NodeInputVariableCompiledValue value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNodeInputCompiledStringValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledStringValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledStringValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledStringValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeInputCompiledStringValue, typeInfo);
            }
            else if (value.IsNodeInputCompiledNumberValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledNumberValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledNumberValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledNumberValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeInputCompiledNumberValue, typeInfo);
            }
            else if (value.IsNodeInputCompiledJsonValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledJsonValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledJsonValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledJsonValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeInputCompiledJsonValue, typeInfo);
            }
            else if (value.IsNodeInputCompiledChatHistoryValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledChatHistoryValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledChatHistoryValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledChatHistoryValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeInputCompiledChatHistoryValue, typeInfo);
            }
            else if (value.IsNodeInputCompiledSearchResultsValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledSearchResultsValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledSearchResultsValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledSearchResultsValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeInputCompiledSearchResultsValue, typeInfo);
            }
            else if (value.IsNodeInputCompiledErrorValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledErrorValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledErrorValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledErrorValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeInputCompiledErrorValue, typeInfo);
            }
            else if (value.IsNodeInputCompiledArrayValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledArrayValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledArrayValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledArrayValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeInputCompiledArrayValue, typeInfo);
            }
            else if (value.IsNodeInputCompiledFunctionCallValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledFunctionCallValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledFunctionCallValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledFunctionCallValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeInputCompiledFunctionCallValue, typeInfo);
            }
            else if (value.IsNodeInputCompiledSecretValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledSecretValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledSecretValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledSecretValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeInputCompiledSecretValue, typeInfo);
            }
            else if (value.IsNodeInputCompiledAudioValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledAudioValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledAudioValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledAudioValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeInputCompiledAudioValue, typeInfo);
            }
            else if (value.IsNodeInputCompiledVideoValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledVideoValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledVideoValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledVideoValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeInputCompiledVideoValue, typeInfo);
            }
            else if (value.IsNodeInputCompiledImageValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledImageValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledImageValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledImageValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeInputCompiledImageValue, typeInfo);
            }
            else if (value.IsNodeInputCompiledDocumentValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeInputCompiledDocumentValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeInputCompiledDocumentValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeInputCompiledDocumentValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeInputCompiledDocumentValue, typeInfo);
            }
        }
    }
}