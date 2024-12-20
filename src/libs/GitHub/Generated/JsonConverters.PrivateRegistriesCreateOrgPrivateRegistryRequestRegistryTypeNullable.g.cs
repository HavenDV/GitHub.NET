#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType?>
    {
        /// <inheritdoc />
        public override global::GitHub.PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType? Read(
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
                        return global::GitHub.PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.PrivateRegistriesCreateOrgPrivateRegistryRequestRegistryTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
