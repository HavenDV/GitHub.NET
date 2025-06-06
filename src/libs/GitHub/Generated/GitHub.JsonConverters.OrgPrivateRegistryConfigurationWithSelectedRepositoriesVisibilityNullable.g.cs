#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibilityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibility?>
    {
        /// <inheritdoc />
        public override global::GitHub.OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibility? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::GitHub.OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibilityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibility)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibility?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibility? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.OrgPrivateRegistryConfigurationWithSelectedRepositoriesVisibilityExtensions.ToValueString(value.Value));
            }
        }
    }
}
