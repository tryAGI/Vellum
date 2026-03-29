#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class WorkflowRequestInputRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.WorkflowRequestInputRequest>
    {
        /// <inheritdoc />
        public override global::Vellum.WorkflowRequestInputRequest Read(
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
            var __score4 = 0;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("value")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("name")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("value")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("name")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            if (__jsonProps.Contains("value")) __score6++;
            var __score7 = 0;
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

            global::Vellum.WorkflowRequestStringInputRequest? workflowRequestStringInputRequest = default;
            global::Vellum.WorkflowRequestJSONInputRequest? workflowRequestJSONInputRequest = default;
            global::Vellum.WorkflowRequestChatHistoryInputRequest? workflowRequestChatHistoryInputRequest = default;
            global::Vellum.WorkflowRequestNumberInputRequest? workflowRequestNumberInputRequest = default;
            global::Vellum.WorkflowRequestAudioInputRequest? workflowRequestAudioInputRequest = default;
            global::Vellum.WorkflowRequestVideoInputRequest? workflowRequestVideoInputRequest = default;
            global::Vellum.WorkflowRequestImageInputRequest? workflowRequestImageInputRequest = default;
            global::Vellum.WorkflowRequestDocumentInputRequest? workflowRequestDocumentInputRequest = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestStringInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestStringInputRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestStringInputRequest).Name}");
                        workflowRequestStringInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestJSONInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestJSONInputRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestJSONInputRequest).Name}");
                        workflowRequestJSONInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestChatHistoryInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestChatHistoryInputRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestChatHistoryInputRequest).Name}");
                        workflowRequestChatHistoryInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestNumberInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestNumberInputRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestNumberInputRequest).Name}");
                        workflowRequestNumberInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestAudioInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestAudioInputRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestAudioInputRequest).Name}");
                        workflowRequestAudioInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestVideoInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestVideoInputRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestVideoInputRequest).Name}");
                        workflowRequestVideoInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestImageInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestImageInputRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestImageInputRequest).Name}");
                        workflowRequestImageInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestDocumentInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestDocumentInputRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestDocumentInputRequest).Name}");
                        workflowRequestDocumentInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (workflowRequestStringInputRequest == null && workflowRequestJSONInputRequest == null && workflowRequestChatHistoryInputRequest == null && workflowRequestNumberInputRequest == null && workflowRequestAudioInputRequest == null && workflowRequestVideoInputRequest == null && workflowRequestImageInputRequest == null && workflowRequestDocumentInputRequest == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestStringInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestStringInputRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestStringInputRequest).Name}");
                    workflowRequestStringInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestJSONInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestJSONInputRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestJSONInputRequest).Name}");
                    workflowRequestJSONInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestChatHistoryInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestChatHistoryInputRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestChatHistoryInputRequest).Name}");
                    workflowRequestChatHistoryInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestNumberInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestNumberInputRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestNumberInputRequest).Name}");
                    workflowRequestNumberInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestAudioInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestAudioInputRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestAudioInputRequest).Name}");
                    workflowRequestAudioInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestVideoInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestVideoInputRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestVideoInputRequest).Name}");
                    workflowRequestVideoInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestImageInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestImageInputRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestImageInputRequest).Name}");
                    workflowRequestImageInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestDocumentInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestDocumentInputRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestDocumentInputRequest).Name}");
                    workflowRequestDocumentInputRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.WorkflowRequestInputRequest(
                workflowRequestStringInputRequest,

                workflowRequestJSONInputRequest,

                workflowRequestChatHistoryInputRequest,

                workflowRequestNumberInputRequest,

                workflowRequestAudioInputRequest,

                workflowRequestVideoInputRequest,

                workflowRequestImageInputRequest,

                workflowRequestDocumentInputRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.WorkflowRequestInputRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWorkflowRequestStringInputRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestStringInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestStringInputRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestStringInputRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowRequestStringInputRequest, typeInfo);
            }
            else if (value.IsWorkflowRequestJSONInputRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestJSONInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestJSONInputRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestJSONInputRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowRequestJSONInputRequest, typeInfo);
            }
            else if (value.IsWorkflowRequestChatHistoryInputRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestChatHistoryInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestChatHistoryInputRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestChatHistoryInputRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowRequestChatHistoryInputRequest, typeInfo);
            }
            else if (value.IsWorkflowRequestNumberInputRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestNumberInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestNumberInputRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestNumberInputRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowRequestNumberInputRequest, typeInfo);
            }
            else if (value.IsWorkflowRequestAudioInputRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestAudioInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestAudioInputRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestAudioInputRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowRequestAudioInputRequest, typeInfo);
            }
            else if (value.IsWorkflowRequestVideoInputRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestVideoInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestVideoInputRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestVideoInputRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowRequestVideoInputRequest, typeInfo);
            }
            else if (value.IsWorkflowRequestImageInputRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestImageInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestImageInputRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestImageInputRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowRequestImageInputRequest, typeInfo);
            }
            else if (value.IsWorkflowRequestDocumentInputRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowRequestDocumentInputRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowRequestDocumentInputRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowRequestDocumentInputRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowRequestDocumentInputRequest, typeInfo);
            }
        }
    }
}