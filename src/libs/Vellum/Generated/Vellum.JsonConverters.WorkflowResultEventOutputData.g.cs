#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class WorkflowResultEventOutputDataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.WorkflowResultEventOutputData>
    {
        /// <inheritdoc />
        public override global::Vellum.WorkflowResultEventOutputData Read(
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
            if (__jsonProps.Contains("delta")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("node_id")) __score0++;
            if (__jsonProps.Contains("state")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("delta")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("node_id")) __score1++;
            if (__jsonProps.Contains("state")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("value")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("delta")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("node_id")) __score2++;
            if (__jsonProps.Contains("state")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("value")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("delta")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("node_id")) __score3++;
            if (__jsonProps.Contains("state")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("value")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("delta")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("node_id")) __score4++;
            if (__jsonProps.Contains("state")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("value")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("delta")) __score5++;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("name")) __score5++;
            if (__jsonProps.Contains("node_id")) __score5++;
            if (__jsonProps.Contains("state")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("value")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("delta")) __score6++;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("name")) __score6++;
            if (__jsonProps.Contains("node_id")) __score6++;
            if (__jsonProps.Contains("state")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            if (__jsonProps.Contains("value")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("delta")) __score7++;
            if (__jsonProps.Contains("id")) __score7++;
            if (__jsonProps.Contains("name")) __score7++;
            if (__jsonProps.Contains("node_id")) __score7++;
            if (__jsonProps.Contains("state")) __score7++;
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

            global::Vellum.WorkflowResultEventOutputDataString? workflowResultEventOutputDataString = default;
            global::Vellum.WorkflowResultEventOutputDataNumber? workflowResultEventOutputDataNumber = default;
            global::Vellum.WorkflowResultEventOutputDataJSON? workflowResultEventOutputDataJSON = default;
            global::Vellum.WorkflowResultEventOutputDataChatHistory? workflowResultEventOutputDataChatHistory = default;
            global::Vellum.WorkflowResultEventOutputDataSearchResults? workflowResultEventOutputDataSearchResults = default;
            global::Vellum.WorkflowResultEventOutputDataArray? workflowResultEventOutputDataArray = default;
            global::Vellum.WorkflowResultEventOutputDataFunctionCall? workflowResultEventOutputDataFunctionCall = default;
            global::Vellum.WorkflowResultEventOutputDataError? workflowResultEventOutputDataError = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataString), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataString> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataString).Name}");
                        workflowResultEventOutputDataString = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataNumber> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataNumber).Name}");
                        workflowResultEventOutputDataNumber = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataJSON), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataJSON> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataJSON).Name}");
                        workflowResultEventOutputDataJSON = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataChatHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataChatHistory> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataChatHistory).Name}");
                        workflowResultEventOutputDataChatHistory = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataSearchResults), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataSearchResults> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataSearchResults).Name}");
                        workflowResultEventOutputDataSearchResults = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataArray), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataArray> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataArray).Name}");
                        workflowResultEventOutputDataArray = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataFunctionCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataFunctionCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataFunctionCall).Name}");
                        workflowResultEventOutputDataFunctionCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataError> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataError).Name}");
                        workflowResultEventOutputDataError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (workflowResultEventOutputDataString == null && workflowResultEventOutputDataNumber == null && workflowResultEventOutputDataJSON == null && workflowResultEventOutputDataChatHistory == null && workflowResultEventOutputDataSearchResults == null && workflowResultEventOutputDataArray == null && workflowResultEventOutputDataFunctionCall == null && workflowResultEventOutputDataError == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataString), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataString> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataString).Name}");
                    workflowResultEventOutputDataString = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataNumber> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataNumber).Name}");
                    workflowResultEventOutputDataNumber = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataJSON), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataJSON> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataJSON).Name}");
                    workflowResultEventOutputDataJSON = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataChatHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataChatHistory> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataChatHistory).Name}");
                    workflowResultEventOutputDataChatHistory = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataSearchResults), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataSearchResults> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataSearchResults).Name}");
                    workflowResultEventOutputDataSearchResults = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataArray), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataArray> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataArray).Name}");
                    workflowResultEventOutputDataArray = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataFunctionCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataFunctionCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataFunctionCall).Name}");
                    workflowResultEventOutputDataFunctionCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataError> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataError).Name}");
                    workflowResultEventOutputDataError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.WorkflowResultEventOutputData(
                workflowResultEventOutputDataString,

                workflowResultEventOutputDataNumber,

                workflowResultEventOutputDataJSON,

                workflowResultEventOutputDataChatHistory,

                workflowResultEventOutputDataSearchResults,

                workflowResultEventOutputDataArray,

                workflowResultEventOutputDataFunctionCall,

                workflowResultEventOutputDataError
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.WorkflowResultEventOutputData value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWorkflowResultEventOutputDataString)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataString), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataString?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataString).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowResultEventOutputDataString!, typeInfo);
            }
            else if (value.IsWorkflowResultEventOutputDataNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataNumber?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataNumber).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowResultEventOutputDataNumber!, typeInfo);
            }
            else if (value.IsWorkflowResultEventOutputDataJSON)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataJSON), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataJSON?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataJSON).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowResultEventOutputDataJSON!, typeInfo);
            }
            else if (value.IsWorkflowResultEventOutputDataChatHistory)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataChatHistory), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataChatHistory?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataChatHistory).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowResultEventOutputDataChatHistory!, typeInfo);
            }
            else if (value.IsWorkflowResultEventOutputDataSearchResults)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataSearchResults), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataSearchResults?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataSearchResults).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowResultEventOutputDataSearchResults!, typeInfo);
            }
            else if (value.IsWorkflowResultEventOutputDataArray)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataArray), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataArray?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataArray).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowResultEventOutputDataArray!, typeInfo);
            }
            else if (value.IsWorkflowResultEventOutputDataFunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataFunctionCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataFunctionCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataFunctionCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowResultEventOutputDataFunctionCall!, typeInfo);
            }
            else if (value.IsWorkflowResultEventOutputDataError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.WorkflowResultEventOutputDataError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.WorkflowResultEventOutputDataError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.WorkflowResultEventOutputDataError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WorkflowResultEventOutputDataError!, typeInfo);
            }
        }
    }
}