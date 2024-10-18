#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public class OrgRulesetConditionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.OrgRulesetConditions>
    {
        /// <inheritdoc />
        public override global::GitHub.OrgRulesetConditions Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryNameTarget>? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryNameTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryNameTarget>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryNameTarget>).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryIdTarget>? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryIdTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryIdTarget>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryIdTarget>).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>? value3 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>).Name}");
                value3 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::GitHub.OrgRulesetConditions(
                value1,
                value2,
                value3
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryNameTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryNameTarget>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryNameTarget>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryIdTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryIdTarget>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryIdTarget>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value3 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.OrgRulesetConditions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryNameTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryNameTarget>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryNameTarget>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryIdTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryIdTarget>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryIdTarget>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.AllOf<global::GitHub.RepositoryRulesetConditions, global::GitHub.RepositoryRulesetConditionsRepositoryPropertyTarget>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3, typeInfo);
            }
        }
    }
}