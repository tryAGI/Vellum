#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class NodeOutputCompiledValueJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.NodeOutputCompiledValue>
    {
        /// <inheritdoc />
        public override global::Vellum.NodeOutputCompiledValue Read(
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
            if (__jsonProps.Contains("node_output_id")) __score0++;
            if (__jsonProps.Contains("state")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("node_output_id")) __score1++;
            if (__jsonProps.Contains("state")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("value")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("node_output_id")) __score2++;
            if (__jsonProps.Contains("state")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("value")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("node_output_id")) __score3++;
            if (__jsonProps.Contains("state")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("value")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("node_output_id")) __score4++;
            if (__jsonProps.Contains("state")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("value")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("node_output_id")) __score5++;
            if (__jsonProps.Contains("state")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("value")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("node_output_id")) __score6++;
            if (__jsonProps.Contains("state")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            if (__jsonProps.Contains("value")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("node_output_id")) __score7++;
            if (__jsonProps.Contains("state")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            if (__jsonProps.Contains("value")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("node_output_id")) __score8++;
            if (__jsonProps.Contains("state")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            if (__jsonProps.Contains("value")) __score8++;
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

            global::Vellum.NodeOutputCompiledStringValue? nodeOutputCompiledStringValue = default;
            global::Vellum.NodeOutputCompiledNumberValue? nodeOutputCompiledNumberValue = default;
            global::Vellum.NodeOutputCompiledJsonValue? nodeOutputCompiledJsonValue = default;
            global::Vellum.NodeOutputCompiledChatHistoryValue? nodeOutputCompiledChatHistoryValue = default;
            global::Vellum.NodeOutputCompiledSearchResultsValue? nodeOutputCompiledSearchResultsValue = default;
            global::Vellum.NodeOutputCompiledErrorValue? nodeOutputCompiledErrorValue = default;
            global::Vellum.NodeOutputCompiledArrayValue? nodeOutputCompiledArrayValue = default;
            global::Vellum.NodeOutputCompiledFunctionCallValue? nodeOutputCompiledFunctionCallValue = default;
            global::Vellum.NodeOutputCompiledThinkingValue? nodeOutputCompiledThinkingValue = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledStringValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledStringValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledStringValue).Name}");
                        nodeOutputCompiledStringValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledNumberValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledNumberValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledNumberValue).Name}");
                        nodeOutputCompiledNumberValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledJsonValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledJsonValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledJsonValue).Name}");
                        nodeOutputCompiledJsonValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledChatHistoryValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledChatHistoryValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledChatHistoryValue).Name}");
                        nodeOutputCompiledChatHistoryValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledSearchResultsValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledSearchResultsValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledSearchResultsValue).Name}");
                        nodeOutputCompiledSearchResultsValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledErrorValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledErrorValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledErrorValue).Name}");
                        nodeOutputCompiledErrorValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledArrayValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledArrayValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledArrayValue).Name}");
                        nodeOutputCompiledArrayValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledFunctionCallValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledFunctionCallValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledFunctionCallValue).Name}");
                        nodeOutputCompiledFunctionCallValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledThinkingValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledThinkingValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledThinkingValue).Name}");
                        nodeOutputCompiledThinkingValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (nodeOutputCompiledStringValue == null && nodeOutputCompiledNumberValue == null && nodeOutputCompiledJsonValue == null && nodeOutputCompiledChatHistoryValue == null && nodeOutputCompiledSearchResultsValue == null && nodeOutputCompiledErrorValue == null && nodeOutputCompiledArrayValue == null && nodeOutputCompiledFunctionCallValue == null && nodeOutputCompiledThinkingValue == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledStringValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledStringValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledStringValue).Name}");
                    nodeOutputCompiledStringValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledNumberValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledNumberValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledNumberValue).Name}");
                    nodeOutputCompiledNumberValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledJsonValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledJsonValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledJsonValue).Name}");
                    nodeOutputCompiledJsonValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledChatHistoryValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledChatHistoryValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledChatHistoryValue).Name}");
                    nodeOutputCompiledChatHistoryValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledSearchResultsValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledSearchResultsValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledSearchResultsValue).Name}");
                    nodeOutputCompiledSearchResultsValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledErrorValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledErrorValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledErrorValue).Name}");
                    nodeOutputCompiledErrorValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledArrayValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledArrayValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledArrayValue).Name}");
                    nodeOutputCompiledArrayValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledFunctionCallValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledFunctionCallValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledFunctionCallValue).Name}");
                    nodeOutputCompiledFunctionCallValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledThinkingValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledThinkingValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledThinkingValue).Name}");
                    nodeOutputCompiledThinkingValue = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.NodeOutputCompiledValue(
                nodeOutputCompiledStringValue,

                nodeOutputCompiledNumberValue,

                nodeOutputCompiledJsonValue,

                nodeOutputCompiledChatHistoryValue,

                nodeOutputCompiledSearchResultsValue,

                nodeOutputCompiledErrorValue,

                nodeOutputCompiledArrayValue,

                nodeOutputCompiledFunctionCallValue,

                nodeOutputCompiledThinkingValue
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.NodeOutputCompiledValue value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNodeOutputCompiledStringValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledStringValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledStringValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledStringValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeOutputCompiledStringValue!, typeInfo);
            }
            else if (value.IsNodeOutputCompiledNumberValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledNumberValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledNumberValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledNumberValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeOutputCompiledNumberValue!, typeInfo);
            }
            else if (value.IsNodeOutputCompiledJsonValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledJsonValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledJsonValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledJsonValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeOutputCompiledJsonValue!, typeInfo);
            }
            else if (value.IsNodeOutputCompiledChatHistoryValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledChatHistoryValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledChatHistoryValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledChatHistoryValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeOutputCompiledChatHistoryValue!, typeInfo);
            }
            else if (value.IsNodeOutputCompiledSearchResultsValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledSearchResultsValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledSearchResultsValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledSearchResultsValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeOutputCompiledSearchResultsValue!, typeInfo);
            }
            else if (value.IsNodeOutputCompiledErrorValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledErrorValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledErrorValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledErrorValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeOutputCompiledErrorValue!, typeInfo);
            }
            else if (value.IsNodeOutputCompiledArrayValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledArrayValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledArrayValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledArrayValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeOutputCompiledArrayValue!, typeInfo);
            }
            else if (value.IsNodeOutputCompiledFunctionCallValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledFunctionCallValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledFunctionCallValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledFunctionCallValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeOutputCompiledFunctionCallValue!, typeInfo);
            }
            else if (value.IsNodeOutputCompiledThinkingValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeOutputCompiledThinkingValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeOutputCompiledThinkingValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeOutputCompiledThinkingValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeOutputCompiledThinkingValue!, typeInfo);
            }
        }
    }
}