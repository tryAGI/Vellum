#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class ParentContextJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.ParentContext>
    {
        /// <inheritdoc />
        public override global::Vellum.ParentContext Read(
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
            if (__jsonProps.Contains("links")) __score0++;
            if (__jsonProps.Contains("parent")) __score0++;
            if (__jsonProps.Contains("span_id")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("workflow_definition")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("links")) __score1++;
            if (__jsonProps.Contains("node_definition")) __score1++;
            if (__jsonProps.Contains("parent")) __score1++;
            if (__jsonProps.Contains("span_id")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("deployment_history_item_id")) __score2++;
            if (__jsonProps.Contains("deployment_id")) __score2++;
            if (__jsonProps.Contains("deployment_name")) __score2++;
            if (__jsonProps.Contains("external_id")) __score2++;
            if (__jsonProps.Contains("links")) __score2++;
            if (__jsonProps.Contains("metadata")) __score2++;
            if (__jsonProps.Contains("parent")) __score2++;
            if (__jsonProps.Contains("release_tag_id")) __score2++;
            if (__jsonProps.Contains("release_tag_name")) __score2++;
            if (__jsonProps.Contains("span_id")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("workflow_version_id")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("links")) __score3++;
            if (__jsonProps.Contains("parent")) __score3++;
            if (__jsonProps.Contains("sandbox_history_item_id")) __score3++;
            if (__jsonProps.Contains("sandbox_id")) __score3++;
            if (__jsonProps.Contains("scenario_id")) __score3++;
            if (__jsonProps.Contains("span_id")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("deployment_history_item_id")) __score4++;
            if (__jsonProps.Contains("deployment_id")) __score4++;
            if (__jsonProps.Contains("deployment_name")) __score4++;
            if (__jsonProps.Contains("external_id")) __score4++;
            if (__jsonProps.Contains("links")) __score4++;
            if (__jsonProps.Contains("metadata")) __score4++;
            if (__jsonProps.Contains("parent")) __score4++;
            if (__jsonProps.Contains("prompt_version_id")) __score4++;
            if (__jsonProps.Contains("release_tag_id")) __score4++;
            if (__jsonProps.Contains("release_tag_name")) __score4++;
            if (__jsonProps.Contains("span_id")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("api_actor_id")) __score5++;
            if (__jsonProps.Contains("api_actor_label")) __score5++;
            if (__jsonProps.Contains("api_actor_type")) __score5++;
            if (__jsonProps.Contains("links")) __score5++;
            if (__jsonProps.Contains("parent")) __score5++;
            if (__jsonProps.Contains("span_id")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("links")) __score6++;
            if (__jsonProps.Contains("parent")) __score6++;
            if (__jsonProps.Contains("span_id")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("links")) __score7++;
            if (__jsonProps.Contains("parent")) __score7++;
            if (__jsonProps.Contains("span_id")) __score7++;
            if (__jsonProps.Contains("trigger_id")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("links")) __score8++;
            if (__jsonProps.Contains("parent")) __score8++;
            if (__jsonProps.Contains("span_id")) __score8++;
            if (__jsonProps.Contains("trigger_id")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
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

            global::Vellum.WorkflowParentContext? workflowParentContext = default;
            global::Vellum.NodeParentContext? nodeParentContext = default;
            global::Vellum.WorkflowDeploymentParentContext? workflowDeploymentParentContext = default;
            global::Vellum.WorkflowSandboxParentContext? workflowSandboxParentContext = default;
            global::Vellum.PromptDeploymentParentContext? promptDeploymentParentContext = default;
            global::Vellum.APIRequestParentContext? aPIRequestParentContext = default;
            global::Vellum.ExternalParentContext? externalParentContext = default;
            global::Vellum.ScheduledTriggerContext? scheduledTriggerContext = default;
            global::Vellum.IntegrationTriggerContext? integrationTriggerContext = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowParentContext> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowParentContext).Name}");
                        workflowParentContext = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeParentContext> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeParentContext).Name}");
                        nodeParentContext = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowDeploymentParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowDeploymentParentContext> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowDeploymentParentContext).Name}");
                        workflowDeploymentParentContext = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowSandboxParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowSandboxParentContext> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowSandboxParentContext).Name}");
                        workflowSandboxParentContext = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.PromptDeploymentParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.PromptDeploymentParentContext> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.PromptDeploymentParentContext).Name}");
                        promptDeploymentParentContext = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.APIRequestParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.APIRequestParentContext> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.APIRequestParentContext).Name}");
                        aPIRequestParentContext = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExternalParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExternalParentContext> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExternalParentContext).Name}");
                        externalParentContext = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ScheduledTriggerContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ScheduledTriggerContext> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ScheduledTriggerContext).Name}");
                        scheduledTriggerContext = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.IntegrationTriggerContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.IntegrationTriggerContext> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.IntegrationTriggerContext).Name}");
                        integrationTriggerContext = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (workflowParentContext == null && nodeParentContext == null && workflowDeploymentParentContext == null && workflowSandboxParentContext == null && promptDeploymentParentContext == null && aPIRequestParentContext == null && externalParentContext == null && scheduledTriggerContext == null && integrationTriggerContext == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowParentContext> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowParentContext).Name}");
                    workflowParentContext = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeParentContext> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeParentContext).Name}");
                    nodeParentContext = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowDeploymentParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowDeploymentParentContext> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowDeploymentParentContext).Name}");
                    workflowDeploymentParentContext = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowSandboxParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowSandboxParentContext> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowSandboxParentContext).Name}");
                    workflowSandboxParentContext = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.PromptDeploymentParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.PromptDeploymentParentContext> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.PromptDeploymentParentContext).Name}");
                    promptDeploymentParentContext = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.APIRequestParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.APIRequestParentContext> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.APIRequestParentContext).Name}");
                    aPIRequestParentContext = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExternalParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExternalParentContext> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExternalParentContext).Name}");
                    externalParentContext = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ScheduledTriggerContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ScheduledTriggerContext> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ScheduledTriggerContext).Name}");
                    scheduledTriggerContext = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.IntegrationTriggerContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.IntegrationTriggerContext> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.IntegrationTriggerContext).Name}");
                    integrationTriggerContext = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.ParentContext(
                workflowParentContext,

                nodeParentContext,

                workflowDeploymentParentContext,

                workflowSandboxParentContext,

                promptDeploymentParentContext,

                aPIRequestParentContext,

                externalParentContext,

                scheduledTriggerContext,

                integrationTriggerContext
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.ParentContext value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWorkflowParentContext)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowParentContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowParentContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowParentContext!, typeInfo);
            }
            else if (value.IsNodeParentContext)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.NodeParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.NodeParentContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.NodeParentContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeParentContext!, typeInfo);
            }
            else if (value.IsWorkflowDeploymentParentContext)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowDeploymentParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowDeploymentParentContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowDeploymentParentContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowDeploymentParentContext!, typeInfo);
            }
            else if (value.IsWorkflowSandboxParentContext)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowSandboxParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowSandboxParentContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowSandboxParentContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowSandboxParentContext!, typeInfo);
            }
            else if (value.IsPromptDeploymentParentContext)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.PromptDeploymentParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.PromptDeploymentParentContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.PromptDeploymentParentContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PromptDeploymentParentContext!, typeInfo);
            }
            else if (value.IsAPIRequestParentContext)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.APIRequestParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.APIRequestParentContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.APIRequestParentContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.APIRequestParentContext!, typeInfo);
            }
            else if (value.IsExternalParentContext)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ExternalParentContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ExternalParentContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ExternalParentContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExternalParentContext!, typeInfo);
            }
            else if (value.IsScheduledTriggerContext)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.ScheduledTriggerContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.ScheduledTriggerContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.ScheduledTriggerContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ScheduledTriggerContext!, typeInfo);
            }
            else if (value.IsIntegrationTriggerContext)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.IntegrationTriggerContext), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.IntegrationTriggerContext?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.IntegrationTriggerContext).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.IntegrationTriggerContext!, typeInfo);
            }
        }
    }
}