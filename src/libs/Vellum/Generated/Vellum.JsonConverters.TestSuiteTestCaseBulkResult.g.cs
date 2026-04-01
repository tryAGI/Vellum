#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class TestSuiteTestCaseBulkResultJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.TestSuiteTestCaseBulkResult>
    {
        /// <inheritdoc />
        public override global::Vellum.TestSuiteTestCaseBulkResult Read(
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
            if (__jsonProps.Contains("data")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("data")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("data")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Vellum.TestSuiteTestCaseCreatedBulkResult? testSuiteTestCaseCreatedBulkResult = default;
            global::Vellum.TestSuiteTestCaseReplacedBulkResult? testSuiteTestCaseReplacedBulkResult = default;
            global::Vellum.TestSuiteTestCaseDeletedBulkResult? testSuiteTestCaseDeletedBulkResult = default;
            global::Vellum.TestSuiteTestCaseRejectedBulkResult? testSuiteTestCaseRejectedBulkResult = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseCreatedBulkResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseCreatedBulkResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseCreatedBulkResult).Name}");
                        testSuiteTestCaseCreatedBulkResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseReplacedBulkResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseReplacedBulkResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseReplacedBulkResult).Name}");
                        testSuiteTestCaseReplacedBulkResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseDeletedBulkResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseDeletedBulkResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseDeletedBulkResult).Name}");
                        testSuiteTestCaseDeletedBulkResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseRejectedBulkResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseRejectedBulkResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseRejectedBulkResult).Name}");
                        testSuiteTestCaseRejectedBulkResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (testSuiteTestCaseCreatedBulkResult == null && testSuiteTestCaseReplacedBulkResult == null && testSuiteTestCaseDeletedBulkResult == null && testSuiteTestCaseRejectedBulkResult == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseCreatedBulkResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseCreatedBulkResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseCreatedBulkResult).Name}");
                    testSuiteTestCaseCreatedBulkResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseReplacedBulkResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseReplacedBulkResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseReplacedBulkResult).Name}");
                    testSuiteTestCaseReplacedBulkResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseDeletedBulkResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseDeletedBulkResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseDeletedBulkResult).Name}");
                    testSuiteTestCaseDeletedBulkResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseRejectedBulkResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseRejectedBulkResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseRejectedBulkResult).Name}");
                    testSuiteTestCaseRejectedBulkResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.TestSuiteTestCaseBulkResult(
                testSuiteTestCaseCreatedBulkResult,

                testSuiteTestCaseReplacedBulkResult,

                testSuiteTestCaseDeletedBulkResult,

                testSuiteTestCaseRejectedBulkResult
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.TestSuiteTestCaseBulkResult value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTestSuiteTestCaseCreatedBulkResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseCreatedBulkResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseCreatedBulkResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseCreatedBulkResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteTestCaseCreatedBulkResult!, typeInfo);
            }
            else if (value.IsTestSuiteTestCaseReplacedBulkResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseReplacedBulkResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseReplacedBulkResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseReplacedBulkResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteTestCaseReplacedBulkResult!, typeInfo);
            }
            else if (value.IsTestSuiteTestCaseDeletedBulkResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseDeletedBulkResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseDeletedBulkResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseDeletedBulkResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteTestCaseDeletedBulkResult!, typeInfo);
            }
            else if (value.IsTestSuiteTestCaseRejectedBulkResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseRejectedBulkResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseRejectedBulkResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseRejectedBulkResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteTestCaseRejectedBulkResult!, typeInfo);
            }
        }
    }
}