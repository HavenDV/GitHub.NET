#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class DependabotListAlertsForEnterpriseSortNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.DependabotListAlertsForEnterpriseSort?>
    {
        /// <inheritdoc />
        public override global::GitHub.DependabotListAlertsForEnterpriseSort? Read(
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
                        return global::GitHub.DependabotListAlertsForEnterpriseSortExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.DependabotListAlertsForEnterpriseSort)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.DependabotListAlertsForEnterpriseSort? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.DependabotListAlertsForEnterpriseSortExtensions.ToValueString(value.Value));
            }
        }
    }
}
