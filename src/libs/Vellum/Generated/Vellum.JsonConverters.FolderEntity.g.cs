#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class FolderEntityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.FolderEntity>
    {
        /// <inheritdoc />
        public override global::Vellum.FolderEntity Read(
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
            var __score4 = 0;
            if (__jsonProps.Contains("data")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("data")) __score5++;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::Vellum.FolderEntityFolder? folderEntityFolder = default;
            global::Vellum.FolderEntityPromptSandbox? folderEntityPromptSandbox = default;
            global::Vellum.FolderEntityWorkflowSandbox? folderEntityWorkflowSandbox = default;
            global::Vellum.FolderEntityDocumentIndex? folderEntityDocumentIndex = default;
            global::Vellum.FolderEntityTestSuite? folderEntityTestSuite = default;
            global::Vellum.FolderEntityDataset? folderEntityDataset = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FolderEntityFolder), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FolderEntityFolder> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FolderEntityFolder).Name}");
                        folderEntityFolder = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FolderEntityPromptSandbox), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FolderEntityPromptSandbox> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FolderEntityPromptSandbox).Name}");
                        folderEntityPromptSandbox = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FolderEntityWorkflowSandbox), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FolderEntityWorkflowSandbox> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FolderEntityWorkflowSandbox).Name}");
                        folderEntityWorkflowSandbox = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FolderEntityDocumentIndex), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FolderEntityDocumentIndex> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FolderEntityDocumentIndex).Name}");
                        folderEntityDocumentIndex = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FolderEntityTestSuite), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FolderEntityTestSuite> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FolderEntityTestSuite).Name}");
                        folderEntityTestSuite = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FolderEntityDataset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FolderEntityDataset> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FolderEntityDataset).Name}");
                        folderEntityDataset = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (folderEntityFolder == null && folderEntityPromptSandbox == null && folderEntityWorkflowSandbox == null && folderEntityDocumentIndex == null && folderEntityTestSuite == null && folderEntityDataset == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FolderEntityFolder), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FolderEntityFolder> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FolderEntityFolder).Name}");
                    folderEntityFolder = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FolderEntityPromptSandbox), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FolderEntityPromptSandbox> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FolderEntityPromptSandbox).Name}");
                    folderEntityPromptSandbox = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FolderEntityWorkflowSandbox), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FolderEntityWorkflowSandbox> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FolderEntityWorkflowSandbox).Name}");
                    folderEntityWorkflowSandbox = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FolderEntityDocumentIndex), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FolderEntityDocumentIndex> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FolderEntityDocumentIndex).Name}");
                    folderEntityDocumentIndex = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FolderEntityTestSuite), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FolderEntityTestSuite> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FolderEntityTestSuite).Name}");
                    folderEntityTestSuite = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FolderEntityDataset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FolderEntityDataset> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FolderEntityDataset).Name}");
                    folderEntityDataset = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.FolderEntity(
                folderEntityFolder,

                folderEntityPromptSandbox,

                folderEntityWorkflowSandbox,

                folderEntityDocumentIndex,

                folderEntityTestSuite,

                folderEntityDataset
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.FolderEntity value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFolderEntityFolder)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FolderEntityFolder), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FolderEntityFolder?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FolderEntityFolder).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FolderEntityFolder, typeInfo);
            }
            else if (value.IsFolderEntityPromptSandbox)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FolderEntityPromptSandbox), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FolderEntityPromptSandbox?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FolderEntityPromptSandbox).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FolderEntityPromptSandbox, typeInfo);
            }
            else if (value.IsFolderEntityWorkflowSandbox)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FolderEntityWorkflowSandbox), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FolderEntityWorkflowSandbox?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FolderEntityWorkflowSandbox).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FolderEntityWorkflowSandbox, typeInfo);
            }
            else if (value.IsFolderEntityDocumentIndex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FolderEntityDocumentIndex), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FolderEntityDocumentIndex?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FolderEntityDocumentIndex).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FolderEntityDocumentIndex, typeInfo);
            }
            else if (value.IsFolderEntityTestSuite)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FolderEntityTestSuite), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FolderEntityTestSuite?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FolderEntityTestSuite).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FolderEntityTestSuite, typeInfo);
            }
            else if (value.IsFolderEntityDataset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.FolderEntityDataset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.FolderEntityDataset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.FolderEntityDataset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FolderEntityDataset, typeInfo);
            }
        }
    }
}