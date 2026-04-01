#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class TestSuiteRunExecConfigRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.TestSuiteRunExecConfigRequest>
    {
        /// <inheritdoc />
        public override global::Vellum.TestSuiteRunExecConfigRequest Read(
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
            if (__jsonProps.Contains("test_case_ids")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("test_case_ids")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("data")) __score2++;
            if (__jsonProps.Contains("test_case_ids")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("data")) __score3++;
            if (__jsonProps.Contains("test_case_ids")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("data")) __score4++;
            if (__jsonProps.Contains("test_case_ids")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("data")) __score5++;
            if (__jsonProps.Contains("test_case_ids")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("data")) __score6++;
            if (__jsonProps.Contains("test_case_ids")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }

            global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest? testSuiteRunDeploymentReleaseTagExecConfigRequest = default;
            global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest? testSuiteRunPromptSandboxExecConfigRequest = default;
            global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest? testSuiteRunPromptSandboxHistoryItemExecConfigRequest = default;
            global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest? testSuiteRunWorkflowReleaseTagExecConfigRequest = default;
            global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest? testSuiteRunWorkflowSandboxExecConfigRequest = default;
            global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest? testSuiteRunWorkflowSandboxHistoryItemExecConfigRequest = default;
            global::Vellum.TestSuiteRunExternalExecConfigRequest? testSuiteRunExternalExecConfigRequest = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest).Name}");
                        testSuiteRunDeploymentReleaseTagExecConfigRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest).Name}");
                        testSuiteRunPromptSandboxExecConfigRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest).Name}");
                        testSuiteRunPromptSandboxHistoryItemExecConfigRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest).Name}");
                        testSuiteRunWorkflowReleaseTagExecConfigRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest).Name}");
                        testSuiteRunWorkflowSandboxExecConfigRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest).Name}");
                        testSuiteRunWorkflowSandboxHistoryItemExecConfigRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExternalExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExternalExecConfigRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExternalExecConfigRequest).Name}");
                        testSuiteRunExternalExecConfigRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (testSuiteRunDeploymentReleaseTagExecConfigRequest == null && testSuiteRunPromptSandboxExecConfigRequest == null && testSuiteRunPromptSandboxHistoryItemExecConfigRequest == null && testSuiteRunWorkflowReleaseTagExecConfigRequest == null && testSuiteRunWorkflowSandboxExecConfigRequest == null && testSuiteRunWorkflowSandboxHistoryItemExecConfigRequest == null && testSuiteRunExternalExecConfigRequest == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest).Name}");
                    testSuiteRunDeploymentReleaseTagExecConfigRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest).Name}");
                    testSuiteRunPromptSandboxExecConfigRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest).Name}");
                    testSuiteRunPromptSandboxHistoryItemExecConfigRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest).Name}");
                    testSuiteRunWorkflowReleaseTagExecConfigRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest).Name}");
                    testSuiteRunWorkflowSandboxExecConfigRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest).Name}");
                    testSuiteRunWorkflowSandboxHistoryItemExecConfigRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExternalExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExternalExecConfigRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExternalExecConfigRequest).Name}");
                    testSuiteRunExternalExecConfigRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.TestSuiteRunExecConfigRequest(
                testSuiteRunDeploymentReleaseTagExecConfigRequest,

                testSuiteRunPromptSandboxExecConfigRequest,

                testSuiteRunPromptSandboxHistoryItemExecConfigRequest,

                testSuiteRunWorkflowReleaseTagExecConfigRequest,

                testSuiteRunWorkflowSandboxExecConfigRequest,

                testSuiteRunWorkflowSandboxHistoryItemExecConfigRequest,

                testSuiteRunExternalExecConfigRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.TestSuiteRunExecConfigRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTestSuiteRunDeploymentReleaseTagExecConfigRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfigRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunDeploymentReleaseTagExecConfigRequest!, typeInfo);
            }
            else if (value.IsTestSuiteRunPromptSandboxExecConfigRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunPromptSandboxExecConfigRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunPromptSandboxExecConfigRequest!, typeInfo);
            }
            else if (value.IsTestSuiteRunPromptSandboxHistoryItemExecConfigRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunPromptSandboxHistoryItemExecConfigRequest!, typeInfo);
            }
            else if (value.IsTestSuiteRunWorkflowReleaseTagExecConfigRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfigRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunWorkflowReleaseTagExecConfigRequest!, typeInfo);
            }
            else if (value.IsTestSuiteRunWorkflowSandboxExecConfigRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunWorkflowSandboxExecConfigRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunWorkflowSandboxExecConfigRequest!, typeInfo);
            }
            else if (value.IsTestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunWorkflowSandboxHistoryItemExecConfigRequest!, typeInfo);
            }
            else if (value.IsTestSuiteRunExternalExecConfigRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExternalExecConfigRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExternalExecConfigRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExternalExecConfigRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunExternalExecConfigRequest!, typeInfo);
            }
        }
    }
}