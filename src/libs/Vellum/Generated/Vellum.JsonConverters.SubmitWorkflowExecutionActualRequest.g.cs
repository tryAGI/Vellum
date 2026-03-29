#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class SubmitWorkflowExecutionActualRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.SubmitWorkflowExecutionActualRequest>
    {
        /// <inheritdoc />
        public override global::Vellum.SubmitWorkflowExecutionActualRequest Read(
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
            if (__jsonProps.Contains("desired_output_value")) __score0++;
            if (__jsonProps.Contains("metadata")) __score0++;
            if (__jsonProps.Contains("output_id")) __score0++;
            if (__jsonProps.Contains("output_key")) __score0++;
            if (__jsonProps.Contains("output_type")) __score0++;
            if (__jsonProps.Contains("quality")) __score0++;
            if (__jsonProps.Contains("timestamp")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("desired_output_value")) __score1++;
            if (__jsonProps.Contains("metadata")) __score1++;
            if (__jsonProps.Contains("output_id")) __score1++;
            if (__jsonProps.Contains("output_key")) __score1++;
            if (__jsonProps.Contains("output_type")) __score1++;
            if (__jsonProps.Contains("quality")) __score1++;
            if (__jsonProps.Contains("timestamp")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("desired_output_value")) __score2++;
            if (__jsonProps.Contains("metadata")) __score2++;
            if (__jsonProps.Contains("output_id")) __score2++;
            if (__jsonProps.Contains("output_key")) __score2++;
            if (__jsonProps.Contains("output_type")) __score2++;
            if (__jsonProps.Contains("quality")) __score2++;
            if (__jsonProps.Contains("timestamp")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Vellum.WorkflowExecutionActualStringRequest? workflowExecutionActualStringRequest = default;
            global::Vellum.WorkflowExecutionActualJsonRequest? workflowExecutionActualJsonRequest = default;
            global::Vellum.WorkflowExecutionActualChatHistoryRequest? workflowExecutionActualChatHistoryRequest = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionActualStringRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionActualStringRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionActualStringRequest).Name}");
                        workflowExecutionActualStringRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionActualJsonRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionActualJsonRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionActualJsonRequest).Name}");
                        workflowExecutionActualJsonRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionActualChatHistoryRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionActualChatHistoryRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionActualChatHistoryRequest).Name}");
                        workflowExecutionActualChatHistoryRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (workflowExecutionActualStringRequest == null && workflowExecutionActualJsonRequest == null && workflowExecutionActualChatHistoryRequest == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionActualStringRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionActualStringRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionActualStringRequest).Name}");
                    workflowExecutionActualStringRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionActualJsonRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionActualJsonRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionActualJsonRequest).Name}");
                    workflowExecutionActualJsonRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionActualChatHistoryRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionActualChatHistoryRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionActualChatHistoryRequest).Name}");
                    workflowExecutionActualChatHistoryRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.SubmitWorkflowExecutionActualRequest(
                workflowExecutionActualStringRequest,

                workflowExecutionActualJsonRequest,

                workflowExecutionActualChatHistoryRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.SubmitWorkflowExecutionActualRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWorkflowExecutionActualStringRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionActualStringRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionActualStringRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionActualStringRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionActualStringRequest, typeInfo);
            }
            else if (value.IsWorkflowExecutionActualJsonRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionActualJsonRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionActualJsonRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionActualJsonRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionActualJsonRequest, typeInfo);
            }
            else if (value.IsWorkflowExecutionActualChatHistoryRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowExecutionActualChatHistoryRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowExecutionActualChatHistoryRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowExecutionActualChatHistoryRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowExecutionActualChatHistoryRequest, typeInfo);
            }
        }
    }
}