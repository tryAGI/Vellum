#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class TerminalNodeResultOutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.TerminalNodeResultOutput>
    {
        /// <inheritdoc />
        public override global::Vellum.TerminalNodeResultOutput Read(
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

            global::Vellum.TerminalNodeStringResult? terminalNodeStringResult = default;
            global::Vellum.TerminalNodeNumberResult? terminalNodeNumberResult = default;
            global::Vellum.TerminalNodeJsonResult? terminalNodeJsonResult = default;
            global::Vellum.TerminalNodeChatHistoryResult? terminalNodeChatHistoryResult = default;
            global::Vellum.TerminalNodeSearchResultsResult? terminalNodeSearchResultsResult = default;
            global::Vellum.TerminalNodeErrorResult? terminalNodeErrorResult = default;
            global::Vellum.TerminalNodeArrayResult? terminalNodeArrayResult = default;
            global::Vellum.TerminalNodeFunctionCallResult? terminalNodeFunctionCallResult = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeStringResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeStringResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeStringResult).Name}");
                        terminalNodeStringResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeNumberResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeNumberResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeNumberResult).Name}");
                        terminalNodeNumberResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeJsonResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeJsonResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeJsonResult).Name}");
                        terminalNodeJsonResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeChatHistoryResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeChatHistoryResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeChatHistoryResult).Name}");
                        terminalNodeChatHistoryResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeSearchResultsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeSearchResultsResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeSearchResultsResult).Name}");
                        terminalNodeSearchResultsResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeErrorResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeErrorResult).Name}");
                        terminalNodeErrorResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeArrayResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeArrayResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeArrayResult).Name}");
                        terminalNodeArrayResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeFunctionCallResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeFunctionCallResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeFunctionCallResult).Name}");
                        terminalNodeFunctionCallResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (terminalNodeStringResult == null && terminalNodeNumberResult == null && terminalNodeJsonResult == null && terminalNodeChatHistoryResult == null && terminalNodeSearchResultsResult == null && terminalNodeErrorResult == null && terminalNodeArrayResult == null && terminalNodeFunctionCallResult == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeStringResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeStringResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeStringResult).Name}");
                    terminalNodeStringResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeNumberResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeNumberResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeNumberResult).Name}");
                    terminalNodeNumberResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeJsonResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeJsonResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeJsonResult).Name}");
                    terminalNodeJsonResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeChatHistoryResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeChatHistoryResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeChatHistoryResult).Name}");
                    terminalNodeChatHistoryResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeSearchResultsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeSearchResultsResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeSearchResultsResult).Name}");
                    terminalNodeSearchResultsResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeErrorResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeErrorResult).Name}");
                    terminalNodeErrorResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeArrayResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeArrayResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeArrayResult).Name}");
                    terminalNodeArrayResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeFunctionCallResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeFunctionCallResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeFunctionCallResult).Name}");
                    terminalNodeFunctionCallResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.TerminalNodeResultOutput(
                terminalNodeStringResult,

                terminalNodeNumberResult,

                terminalNodeJsonResult,

                terminalNodeChatHistoryResult,

                terminalNodeSearchResultsResult,

                terminalNodeErrorResult,

                terminalNodeArrayResult,

                terminalNodeFunctionCallResult
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.TerminalNodeResultOutput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTerminalNodeStringResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeStringResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeStringResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeStringResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TerminalNodeStringResult, typeInfo);
            }
            else if (value.IsTerminalNodeNumberResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeNumberResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeNumberResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeNumberResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TerminalNodeNumberResult, typeInfo);
            }
            else if (value.IsTerminalNodeJsonResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeJsonResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeJsonResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeJsonResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TerminalNodeJsonResult, typeInfo);
            }
            else if (value.IsTerminalNodeChatHistoryResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeChatHistoryResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeChatHistoryResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeChatHistoryResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TerminalNodeChatHistoryResult, typeInfo);
            }
            else if (value.IsTerminalNodeSearchResultsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeSearchResultsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeSearchResultsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeSearchResultsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TerminalNodeSearchResultsResult, typeInfo);
            }
            else if (value.IsTerminalNodeErrorResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeErrorResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeErrorResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TerminalNodeErrorResult, typeInfo);
            }
            else if (value.IsTerminalNodeArrayResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeArrayResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeArrayResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeArrayResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TerminalNodeArrayResult, typeInfo);
            }
            else if (value.IsTerminalNodeFunctionCallResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TerminalNodeFunctionCallResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TerminalNodeFunctionCallResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TerminalNodeFunctionCallResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TerminalNodeFunctionCallResult, typeInfo);
            }
        }
    }
}