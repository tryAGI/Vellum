#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class TestSuiteRunExecConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.TestSuiteRunExecConfig>
    {
        /// <inheritdoc />
        public override global::Vellum.TestSuiteRunExecConfig Read(
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
            if (__jsonProps.Contains("data.deployment_id")) __score0++;
            if (__jsonProps.Contains("data.tag")) __score0++;
            if (__jsonProps.Contains("test_case_ids")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("data.history_item_id")) __score1++;
            if (__jsonProps.Contains("data.prompt_variant_id")) __score1++;
            if (__jsonProps.Contains("test_case_ids")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("data")) __score2++;
            if (__jsonProps.Contains("data.tag")) __score2++;
            if (__jsonProps.Contains("data.workflow_deployment_id")) __score2++;
            if (__jsonProps.Contains("test_case_ids")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("data")) __score3++;
            if (__jsonProps.Contains("data.history_item_id")) __score3++;
            if (__jsonProps.Contains("data.workflow_variant_id")) __score3++;
            if (__jsonProps.Contains("test_case_ids")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("data")) __score4++;
            if (__jsonProps.Contains("data.executions")) __score4++;
            if (__jsonProps.Contains("test_case_ids")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig? testSuiteRunDeploymentReleaseTagExecConfig = default;
            global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig? testSuiteRunPromptSandboxHistoryItemExecConfig = default;
            global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig? testSuiteRunWorkflowReleaseTagExecConfig = default;
            global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig? testSuiteRunWorkflowSandboxHistoryItemExecConfig = default;
            global::Vellum.TestSuiteRunExternalExecConfig? testSuiteRunExternalExecConfig = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig).Name}");
                        testSuiteRunDeploymentReleaseTagExecConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig).Name}");
                        testSuiteRunPromptSandboxHistoryItemExecConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig).Name}");
                        testSuiteRunWorkflowReleaseTagExecConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig).Name}");
                        testSuiteRunWorkflowSandboxHistoryItemExecConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExternalExecConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExternalExecConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExternalExecConfig).Name}");
                        testSuiteRunExternalExecConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (testSuiteRunDeploymentReleaseTagExecConfig == null && testSuiteRunPromptSandboxHistoryItemExecConfig == null && testSuiteRunWorkflowReleaseTagExecConfig == null && testSuiteRunWorkflowSandboxHistoryItemExecConfig == null && testSuiteRunExternalExecConfig == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig).Name}");
                    testSuiteRunDeploymentReleaseTagExecConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig).Name}");
                    testSuiteRunPromptSandboxHistoryItemExecConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig).Name}");
                    testSuiteRunWorkflowReleaseTagExecConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig).Name}");
                    testSuiteRunWorkflowSandboxHistoryItemExecConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExternalExecConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExternalExecConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExternalExecConfig).Name}");
                    testSuiteRunExternalExecConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.TestSuiteRunExecConfig(
                testSuiteRunDeploymentReleaseTagExecConfig,

                testSuiteRunPromptSandboxHistoryItemExecConfig,

                testSuiteRunWorkflowReleaseTagExecConfig,

                testSuiteRunWorkflowSandboxHistoryItemExecConfig,

                testSuiteRunExternalExecConfig
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.TestSuiteRunExecConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTestSuiteRunDeploymentReleaseTagExecConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunDeploymentReleaseTagExecConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunDeploymentReleaseTagExecConfig!, typeInfo);
            }
            else if (value.IsTestSuiteRunPromptSandboxHistoryItemExecConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunPromptSandboxHistoryItemExecConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunPromptSandboxHistoryItemExecConfig!, typeInfo);
            }
            else if (value.IsTestSuiteRunWorkflowReleaseTagExecConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunWorkflowReleaseTagExecConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunWorkflowReleaseTagExecConfig!, typeInfo);
            }
            else if (value.IsTestSuiteRunWorkflowSandboxHistoryItemExecConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunWorkflowSandboxHistoryItemExecConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunWorkflowSandboxHistoryItemExecConfig!, typeInfo);
            }
            else if (value.IsTestSuiteRunExternalExecConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.TestSuiteRunExternalExecConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.TestSuiteRunExternalExecConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.TestSuiteRunExternalExecConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestSuiteRunExternalExecConfig!, typeInfo);
            }
        }
    }
}