#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class TeamsUpdateLegacyRequestNotificationSettingNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.TeamsUpdateLegacyRequestNotificationSetting?>
    {
        /// <inheritdoc />
        public override global::GitHub.TeamsUpdateLegacyRequestNotificationSetting? Read(
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
                        return global::GitHub.TeamsUpdateLegacyRequestNotificationSettingExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.TeamsUpdateLegacyRequestNotificationSetting)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.TeamsUpdateLegacyRequestNotificationSetting?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.TeamsUpdateLegacyRequestNotificationSetting? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.TeamsUpdateLegacyRequestNotificationSettingExtensions.ToValueString(value.Value));
            }
        }
    }
}
