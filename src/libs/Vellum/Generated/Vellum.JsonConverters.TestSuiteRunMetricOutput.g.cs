#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class TestSuiteRunMetricOutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.TestSuiteRunMetricOutput>
    {
        /// <inheritdoc />
        public override global::Vellum.TestSuiteRunMetricOutput Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

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
            if (__jsonProps.Contains("value.code")) __score3++;
            if (__jsonProps.Contains("value.message")) __score3++;
            if (__jsonProps.Contains("value.raw_data")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("value")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::Vellum.TestSuiteRunMetricStringOutput? testSuiteRunMetricStringOutput = default;
            global::Vellum.TestSuiteRunMetricNumberOutput? testSuiteRunMetricNumberOutput = default;
            global::Vellum.TestSuiteRunMetricJSONOutput? testSuiteRunMetricJSONOutput = default;
            global::Vellum.TestSuiteRunMetricErrorOutput? testSuiteRunMetricErrorOutput = default;
            global::Vellum.TestSuiteRunMetricArrayOutput? testSuiteRunMetricArrayOutput = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunMetricStringOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunMetricStringOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunMetricStringOutput).Name}");
                        testSuiteRunMetricStringOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunMetricNumberOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunMetricNumberOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunMetricNumberOutput).Name}");
                        testSuiteRunMetricNumberOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunMetricJSONOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunMetricJSONOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunMetricJSONOutput).Name}");
                        testSuiteRunMetricJSONOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunMetricErrorOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunMetricErrorOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunMetricErrorOutput).Name}");
                        testSuiteRunMetricErrorOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunMetricArrayOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunMetricArrayOutput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunMetricArrayOutput).Name}");
                        testSuiteRunMetricArrayOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (testSuiteRunMetricStringOutput == null && testSuiteRunMetricNumberOutput == null && testSuiteRunMetricJSONOutput == null && testSuiteRunMetricErrorOutput == null && testSuiteRunMetricArrayOutput == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunMetricStringOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunMetricStringOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunMetricStringOutput).Name}");
                    testSuiteRunMetricStringOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunMetricNumberOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunMetricNumberOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunMetricNumberOutput).Name}");
                    testSuiteRunMetricNumberOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunMetricJSONOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunMetricJSONOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunMetricJSONOutput).Name}");
                    testSuiteRunMetricJSONOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunMetricErrorOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunMetricErrorOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunMetricErrorOutput).Name}");
                    testSuiteRunMetricErrorOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunMetricArrayOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunMetricArrayOutput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunMetricArrayOutput).Name}");
                    testSuiteRunMetricArrayOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.TestSuiteRunMetricOutput(
                testSuiteRunMetricStringOutput,

                testSuiteRunMetricNumberOutput,

                testSuiteRunMetricJSONOutput,

                testSuiteRunMetricErrorOutput,

                testSuiteRunMetricArrayOutput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.TestSuiteRunMetricOutput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTestSuiteRunMetricStringOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunMetricStringOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunMetricStringOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunMetricStringOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunMetricStringOutput!, typeInfo);
            }
            else if (value.IsTestSuiteRunMetricNumberOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunMetricNumberOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunMetricNumberOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunMetricNumberOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunMetricNumberOutput!, typeInfo);
            }
            else if (value.IsTestSuiteRunMetricJSONOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunMetricJSONOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunMetricJSONOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunMetricJSONOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunMetricJSONOutput!, typeInfo);
            }
            else if (value.IsTestSuiteRunMetricErrorOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunMetricErrorOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunMetricErrorOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunMetricErrorOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunMetricErrorOutput!, typeInfo);
            }
            else if (value.IsTestSuiteRunMetricArrayOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunMetricArrayOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunMetricArrayOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunMetricArrayOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunMetricArrayOutput!, typeInfo);
            }
        }
    }
}