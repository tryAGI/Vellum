#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class TestSuiteRunExecutionOutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.TestSuiteRunExecutionOutput>
    {
        /// <inheritdoc />
        public override global::Vellum.TestSuiteRunExecutionOutput Read(
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
            if (__jsonProps.Contains("output_variable_id")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("output_variable_id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("value")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("output_variable_id")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("value")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("output_variable_id")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("value")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("output_variable_id")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("value")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("name")) __score5++;
            if (__jsonProps.Contains("output_variable_id")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("value")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("name")) __score6++;
            if (__jsonProps.Contains("output_variable_id")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            if (__jsonProps.Contains("value")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("name")) __score7++;
            if (__jsonProps.Contains("output_variable_id")) __score7++;
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

            global::Vellum.TestSuiteRunExecutionStringOutput? testSuiteRunExecutionStringOutput = default;
            global::Vellum.TestSuiteRunExecutionNumberOutput? testSuiteRunExecutionNumberOutput = default;
            global::Vellum.TestSuiteRunExecutionJsonOutput? testSuiteRunExecutionJsonOutput = default;
            global::Vellum.TestSuiteRunExecutionChatHistoryOutput? testSuiteRunExecutionChatHistoryOutput = default;
            global::Vellum.TestSuiteRunExecutionSearchResultsOutput? testSuiteRunExecutionSearchResultsOutput = default;
            global::Vellum.TestSuiteRunExecutionErrorOutput? testSuiteRunExecutionErrorOutput = default;
            global::Vellum.TestSuiteRunExecutionFunctionCallOutput? testSuiteRunExecutionFunctionCallOutput = default;
            global::Vellum.TestSuiteRunExecutionArrayOutput? testSuiteRunExecutionArrayOutput = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionStringOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionStringOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionStringOutput).Name}");
                        testSuiteRunExecutionStringOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionNumberOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionNumberOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionNumberOutput).Name}");
                        testSuiteRunExecutionNumberOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionJsonOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionJsonOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionJsonOutput).Name}");
                        testSuiteRunExecutionJsonOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionChatHistoryOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionChatHistoryOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionChatHistoryOutput).Name}");
                        testSuiteRunExecutionChatHistoryOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionSearchResultsOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionSearchResultsOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionSearchResultsOutput).Name}");
                        testSuiteRunExecutionSearchResultsOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionErrorOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionErrorOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionErrorOutput).Name}");
                        testSuiteRunExecutionErrorOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionFunctionCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionFunctionCallOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionFunctionCallOutput).Name}");
                        testSuiteRunExecutionFunctionCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionArrayOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionArrayOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionArrayOutput).Name}");
                        testSuiteRunExecutionArrayOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (testSuiteRunExecutionStringOutput == null && testSuiteRunExecutionNumberOutput == null && testSuiteRunExecutionJsonOutput == null && testSuiteRunExecutionChatHistoryOutput == null && testSuiteRunExecutionSearchResultsOutput == null && testSuiteRunExecutionErrorOutput == null && testSuiteRunExecutionFunctionCallOutput == null && testSuiteRunExecutionArrayOutput == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionStringOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionStringOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionStringOutput).Name}");
                    testSuiteRunExecutionStringOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionNumberOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionNumberOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionNumberOutput).Name}");
                    testSuiteRunExecutionNumberOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionJsonOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionJsonOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionJsonOutput).Name}");
                    testSuiteRunExecutionJsonOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionChatHistoryOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionChatHistoryOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionChatHistoryOutput).Name}");
                    testSuiteRunExecutionChatHistoryOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionSearchResultsOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionSearchResultsOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionSearchResultsOutput).Name}");
                    testSuiteRunExecutionSearchResultsOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionErrorOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionErrorOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionErrorOutput).Name}");
                    testSuiteRunExecutionErrorOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionFunctionCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionFunctionCallOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionFunctionCallOutput).Name}");
                    testSuiteRunExecutionFunctionCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionArrayOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionArrayOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionArrayOutput).Name}");
                    testSuiteRunExecutionArrayOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.TestSuiteRunExecutionOutput(
                testSuiteRunExecutionStringOutput,

                testSuiteRunExecutionNumberOutput,

                testSuiteRunExecutionJsonOutput,

                testSuiteRunExecutionChatHistoryOutput,

                testSuiteRunExecutionSearchResultsOutput,

                testSuiteRunExecutionErrorOutput,

                testSuiteRunExecutionFunctionCallOutput,

                testSuiteRunExecutionArrayOutput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.TestSuiteRunExecutionOutput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTestSuiteRunExecutionStringOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionStringOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionStringOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionStringOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunExecutionStringOutput!, typeInfo);
            }
            else if (value.IsTestSuiteRunExecutionNumberOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionNumberOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionNumberOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionNumberOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunExecutionNumberOutput!, typeInfo);
            }
            else if (value.IsTestSuiteRunExecutionJsonOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionJsonOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionJsonOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionJsonOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunExecutionJsonOutput!, typeInfo);
            }
            else if (value.IsTestSuiteRunExecutionChatHistoryOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionChatHistoryOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionChatHistoryOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionChatHistoryOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunExecutionChatHistoryOutput!, typeInfo);
            }
            else if (value.IsTestSuiteRunExecutionSearchResultsOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionSearchResultsOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionSearchResultsOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionSearchResultsOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunExecutionSearchResultsOutput!, typeInfo);
            }
            else if (value.IsTestSuiteRunExecutionErrorOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionErrorOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionErrorOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionErrorOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunExecutionErrorOutput!, typeInfo);
            }
            else if (value.IsTestSuiteRunExecutionFunctionCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionFunctionCallOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionFunctionCallOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionFunctionCallOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunExecutionFunctionCallOutput!, typeInfo);
            }
            else if (value.IsTestSuiteRunExecutionArrayOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExecutionArrayOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExecutionArrayOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExecutionArrayOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunExecutionArrayOutput!, typeInfo);
            }
        }
    }
}