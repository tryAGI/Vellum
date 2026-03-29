#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class CodeExecutionNodeResultOutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.CodeExecutionNodeResultOutput>
    {
        /// <inheritdoc />
        public override global::Vellum.CodeExecutionNodeResultOutput Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("value")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("value")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("value")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("value")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("value")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            if (__jsonProps.Contains("value")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("id")) __score7++;
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

            global::Vellum.CodeExecutionNodeStringResult? codeExecutionNodeStringResult = default;
            global::Vellum.CodeExecutionNodeNumberResult? codeExecutionNodeNumberResult = default;
            global::Vellum.CodeExecutionNodeJsonResult? codeExecutionNodeJsonResult = default;
            global::Vellum.CodeExecutionNodeChatHistoryResult? codeExecutionNodeChatHistoryResult = default;
            global::Vellum.CodeExecutionNodeSearchResultsResult? codeExecutionNodeSearchResultsResult = default;
            global::Vellum.CodeExecutionNodeErrorResult? codeExecutionNodeErrorResult = default;
            global::Vellum.CodeExecutionNodeArrayResult? codeExecutionNodeArrayResult = default;
            global::Vellum.CodeExecutionNodeFunctionCallResult? codeExecutionNodeFunctionCallResult = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeStringResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeStringResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeStringResult).Name}");
                        codeExecutionNodeStringResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeNumberResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeNumberResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeNumberResult).Name}");
                        codeExecutionNodeNumberResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeJsonResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeJsonResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeJsonResult).Name}");
                        codeExecutionNodeJsonResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeChatHistoryResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeChatHistoryResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeChatHistoryResult).Name}");
                        codeExecutionNodeChatHistoryResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeSearchResultsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeSearchResultsResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeSearchResultsResult).Name}");
                        codeExecutionNodeSearchResultsResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeErrorResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeErrorResult).Name}");
                        codeExecutionNodeErrorResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeArrayResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeArrayResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeArrayResult).Name}");
                        codeExecutionNodeArrayResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeFunctionCallResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeFunctionCallResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeFunctionCallResult).Name}");
                        codeExecutionNodeFunctionCallResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (codeExecutionNodeStringResult == null && codeExecutionNodeNumberResult == null && codeExecutionNodeJsonResult == null && codeExecutionNodeChatHistoryResult == null && codeExecutionNodeSearchResultsResult == null && codeExecutionNodeErrorResult == null && codeExecutionNodeArrayResult == null && codeExecutionNodeFunctionCallResult == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeStringResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeStringResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeStringResult).Name}");
                    codeExecutionNodeStringResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeNumberResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeNumberResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeNumberResult).Name}");
                    codeExecutionNodeNumberResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeJsonResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeJsonResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeJsonResult).Name}");
                    codeExecutionNodeJsonResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeChatHistoryResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeChatHistoryResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeChatHistoryResult).Name}");
                    codeExecutionNodeChatHistoryResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeSearchResultsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeSearchResultsResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeSearchResultsResult).Name}");
                    codeExecutionNodeSearchResultsResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeErrorResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeErrorResult).Name}");
                    codeExecutionNodeErrorResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeArrayResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeArrayResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeArrayResult).Name}");
                    codeExecutionNodeArrayResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeFunctionCallResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeFunctionCallResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeFunctionCallResult).Name}");
                    codeExecutionNodeFunctionCallResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.CodeExecutionNodeResultOutput(
                codeExecutionNodeStringResult,

                codeExecutionNodeNumberResult,

                codeExecutionNodeJsonResult,

                codeExecutionNodeChatHistoryResult,

                codeExecutionNodeSearchResultsResult,

                codeExecutionNodeErrorResult,

                codeExecutionNodeArrayResult,

                codeExecutionNodeFunctionCallResult
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.CodeExecutionNodeResultOutput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCodeExecutionNodeStringResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeStringResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeStringResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeStringResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionNodeStringResult, typeInfo);
            }
            else if (value.IsCodeExecutionNodeNumberResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeNumberResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeNumberResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeNumberResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionNodeNumberResult, typeInfo);
            }
            else if (value.IsCodeExecutionNodeJsonResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeJsonResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeJsonResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeJsonResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionNodeJsonResult, typeInfo);
            }
            else if (value.IsCodeExecutionNodeChatHistoryResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeChatHistoryResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeChatHistoryResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeChatHistoryResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionNodeChatHistoryResult, typeInfo);
            }
            else if (value.IsCodeExecutionNodeSearchResultsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeSearchResultsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeSearchResultsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeSearchResultsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionNodeSearchResultsResult, typeInfo);
            }
            else if (value.IsCodeExecutionNodeErrorResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeErrorResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeErrorResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionNodeErrorResult, typeInfo);
            }
            else if (value.IsCodeExecutionNodeArrayResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeArrayResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeArrayResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeArrayResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionNodeArrayResult, typeInfo);
            }
            else if (value.IsCodeExecutionNodeFunctionCallResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.CodeExecutionNodeFunctionCallResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.CodeExecutionNodeFunctionCallResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.CodeExecutionNodeFunctionCallResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionNodeFunctionCallResult, typeInfo);
            }
        }
    }
}