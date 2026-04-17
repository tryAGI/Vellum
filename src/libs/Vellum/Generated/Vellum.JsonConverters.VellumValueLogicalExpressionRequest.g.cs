#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vellum.JsonConverters
{
    /// <inheritdoc />
    public class VellumValueLogicalExpressionRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vellum.VellumValueLogicalExpressionRequest>
    {
        /// <inheritdoc />
        public override global::Vellum.VellumValueLogicalExpressionRequest Read(
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
            if (__jsonProps.Contains("lhs_variable")) __score0++;
            if (__jsonProps.Contains("operator")) __score0++;
            if (__jsonProps.Contains("rhs_variable")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("combinator")) __score1++;
            if (__jsonProps.Contains("conditions")) __score1++;
            if (__jsonProps.Contains("negated")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Vellum.VellumValueLogicalConditionRequest? vellumValueLogicalConditionRequest = default;
            global::Vellum.VellumValueLogicalConditionGroupRequest? vellumValueLogicalConditionGroupRequest = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VellumValueLogicalConditionRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VellumValueLogicalConditionRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VellumValueLogicalConditionRequest).Name}");
                        vellumValueLogicalConditionRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VellumValueLogicalConditionGroupRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VellumValueLogicalConditionGroupRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VellumValueLogicalConditionGroupRequest).Name}");
                        vellumValueLogicalConditionGroupRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (vellumValueLogicalConditionRequest == null && vellumValueLogicalConditionGroupRequest == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VellumValueLogicalConditionRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VellumValueLogicalConditionRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VellumValueLogicalConditionRequest).Name}");
                    vellumValueLogicalConditionRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VellumValueLogicalConditionGroupRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VellumValueLogicalConditionGroupRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VellumValueLogicalConditionGroupRequest).Name}");
                    vellumValueLogicalConditionGroupRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vellum.VellumValueLogicalExpressionRequest(
                vellumValueLogicalConditionRequest,

                vellumValueLogicalConditionGroupRequest
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vellum.VellumValueLogicalExpressionRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVellumValueLogicalConditionRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VellumValueLogicalConditionRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VellumValueLogicalConditionRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VellumValueLogicalConditionRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VellumValueLogicalConditionRequest!, typeInfo);
            }
            else if (value.IsVellumValueLogicalConditionGroupRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vellum.VellumValueLogicalConditionGroupRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vellum.VellumValueLogicalConditionGroupRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vellum.VellumValueLogicalConditionGroupRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VellumValueLogicalConditionGroupRequest!, typeInfo);
            }
        }
    }
}