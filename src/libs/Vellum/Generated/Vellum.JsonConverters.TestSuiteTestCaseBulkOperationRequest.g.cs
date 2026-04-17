#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class TestSuiteTestCaseBulkOperationRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.TestSuiteTestCaseBulkOperationRequest>
    {
        /// <inheritdoc />
        public override global::Vellum.TestSuiteTestCaseBulkOperationRequest Read(
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
            if (__jsonProps.Contains("data")) __score0++;
            if (__jsonProps.Contains("data.evaluation_values")) __score0++;
            if (__jsonProps.Contains("data.external_id")) __score0++;
            if (__jsonProps.Contains("data.input_values")) __score0++;
            if (__jsonProps.Contains("data.label")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("data.evaluation_values")) __score1++;
            if (__jsonProps.Contains("data.external_id")) __score1++;
            if (__jsonProps.Contains("data.id")) __score1++;
            if (__jsonProps.Contains("data.input_values")) __score1++;
            if (__jsonProps.Contains("data.label")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("data")) __score2++;
            if (__jsonProps.Contains("data.evaluation_values")) __score2++;
            if (__jsonProps.Contains("data.external_id")) __score2++;
            if (__jsonProps.Contains("data.id")) __score2++;
            if (__jsonProps.Contains("data.input_values")) __score2++;
            if (__jsonProps.Contains("data.label")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("data")) __score3++;
            if (__jsonProps.Contains("data.id")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest? testSuiteTestCaseCreateBulkOperationRequest = default;
            global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest? testSuiteTestCaseReplaceBulkOperationRequest = default;
            global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest? testSuiteTestCaseUpsertBulkOperationRequest = default;
            global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest? testSuiteTestCaseDeleteBulkOperationRequest = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest).Name}");
                        testSuiteTestCaseCreateBulkOperationRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest).Name}");
                        testSuiteTestCaseReplaceBulkOperationRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest).Name}");
                        testSuiteTestCaseUpsertBulkOperationRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest).Name}");
                        testSuiteTestCaseDeleteBulkOperationRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (testSuiteTestCaseCreateBulkOperationRequest == null && testSuiteTestCaseReplaceBulkOperationRequest == null && testSuiteTestCaseUpsertBulkOperationRequest == null && testSuiteTestCaseDeleteBulkOperationRequest == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest).Name}");
                    testSuiteTestCaseCreateBulkOperationRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest).Name}");
                    testSuiteTestCaseReplaceBulkOperationRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest).Name}");
                    testSuiteTestCaseUpsertBulkOperationRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest).Name}");
                    testSuiteTestCaseDeleteBulkOperationRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.TestSuiteTestCaseBulkOperationRequest(
                testSuiteTestCaseCreateBulkOperationRequest,

                testSuiteTestCaseReplaceBulkOperationRequest,

                testSuiteTestCaseUpsertBulkOperationRequest,

                testSuiteTestCaseDeleteBulkOperationRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.TestSuiteTestCaseBulkOperationRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTestSuiteTestCaseCreateBulkOperationRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseCreateBulkOperationRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteTestCaseCreateBulkOperationRequest!, typeInfo);
            }
            else if (value.IsTestSuiteTestCaseReplaceBulkOperationRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseReplaceBulkOperationRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteTestCaseReplaceBulkOperationRequest!, typeInfo);
            }
            else if (value.IsTestSuiteTestCaseUpsertBulkOperationRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseUpsertBulkOperationRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteTestCaseUpsertBulkOperationRequest!, typeInfo);
            }
            else if (value.IsTestSuiteTestCaseDeleteBulkOperationRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteTestCaseDeleteBulkOperationRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteTestCaseDeleteBulkOperationRequest!, typeInfo);
            }
        }
    }
}