#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class TemplatingNodeResultOutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.TemplatingNodeResultOutput>
    {
        /// <inheritdoc />
        public override global::Vellum.TemplatingNodeResultOutput Read(
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

            global::Vellum.TemplatingNodeStringResult? templatingNodeStringResult = default;
            global::Vellum.TemplatingNodeNumberResult? templatingNodeNumberResult = default;
            global::Vellum.TemplatingNodeJsonResult? templatingNodeJsonResult = default;
            global::Vellum.TemplatingNodeChatHistoryResult? templatingNodeChatHistoryResult = default;
            global::Vellum.TemplatingNodeSearchResultsResult? templatingNodeSearchResultsResult = default;
            global::Vellum.TemplatingNodeErrorResult? templatingNodeErrorResult = default;
            global::Vellum.TemplatingNodeArrayResult? templatingNodeArrayResult = default;
            global::Vellum.TemplatingNodeFunctionCallResult? templatingNodeFunctionCallResult = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeStringResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeStringResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeStringResult).Name}");
                        templatingNodeStringResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeNumberResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeNumberResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeNumberResult).Name}");
                        templatingNodeNumberResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeJsonResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeJsonResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeJsonResult).Name}");
                        templatingNodeJsonResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeChatHistoryResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeChatHistoryResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeChatHistoryResult).Name}");
                        templatingNodeChatHistoryResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeSearchResultsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeSearchResultsResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeSearchResultsResult).Name}");
                        templatingNodeSearchResultsResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeErrorResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeErrorResult).Name}");
                        templatingNodeErrorResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeArrayResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeArrayResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeArrayResult).Name}");
                        templatingNodeArrayResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeFunctionCallResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeFunctionCallResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeFunctionCallResult).Name}");
                        templatingNodeFunctionCallResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (templatingNodeStringResult == null && templatingNodeNumberResult == null && templatingNodeJsonResult == null && templatingNodeChatHistoryResult == null && templatingNodeSearchResultsResult == null && templatingNodeErrorResult == null && templatingNodeArrayResult == null && templatingNodeFunctionCallResult == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeStringResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeStringResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeStringResult).Name}");
                    templatingNodeStringResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeNumberResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeNumberResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeNumberResult).Name}");
                    templatingNodeNumberResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeJsonResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeJsonResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeJsonResult).Name}");
                    templatingNodeJsonResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeChatHistoryResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeChatHistoryResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeChatHistoryResult).Name}");
                    templatingNodeChatHistoryResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeSearchResultsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeSearchResultsResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeSearchResultsResult).Name}");
                    templatingNodeSearchResultsResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeErrorResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeErrorResult).Name}");
                    templatingNodeErrorResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeArrayResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeArrayResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeArrayResult).Name}");
                    templatingNodeArrayResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeFunctionCallResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeFunctionCallResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeFunctionCallResult).Name}");
                    templatingNodeFunctionCallResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.TemplatingNodeResultOutput(
                templatingNodeStringResult,

                templatingNodeNumberResult,

                templatingNodeJsonResult,

                templatingNodeChatHistoryResult,

                templatingNodeSearchResultsResult,

                templatingNodeErrorResult,

                templatingNodeArrayResult,

                templatingNodeFunctionCallResult
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.TemplatingNodeResultOutput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTemplatingNodeStringResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeStringResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeStringResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeStringResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TemplatingNodeStringResult!, typeInfo);
            }
            else if (value.IsTemplatingNodeNumberResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeNumberResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeNumberResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeNumberResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TemplatingNodeNumberResult!, typeInfo);
            }
            else if (value.IsTemplatingNodeJsonResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeJsonResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeJsonResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeJsonResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TemplatingNodeJsonResult!, typeInfo);
            }
            else if (value.IsTemplatingNodeChatHistoryResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeChatHistoryResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeChatHistoryResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeChatHistoryResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TemplatingNodeChatHistoryResult!, typeInfo);
            }
            else if (value.IsTemplatingNodeSearchResultsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeSearchResultsResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeSearchResultsResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeSearchResultsResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TemplatingNodeSearchResultsResult!, typeInfo);
            }
            else if (value.IsTemplatingNodeErrorResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeErrorResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeErrorResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeErrorResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TemplatingNodeErrorResult!, typeInfo);
            }
            else if (value.IsTemplatingNodeArrayResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeArrayResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeArrayResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeArrayResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TemplatingNodeArrayResult!, typeInfo);
            }
            else if (value.IsTemplatingNodeFunctionCallResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TemplatingNodeFunctionCallResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TemplatingNodeFunctionCallResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TemplatingNodeFunctionCallResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TemplatingNodeFunctionCallResult!, typeInfo);
            }
        }
    }
}