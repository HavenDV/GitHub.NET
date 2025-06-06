#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissalNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissal?>
    {
        /// <inheritdoc />
        public override global::GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissal? Read(
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
                        return global::GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissalExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissal)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissal?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissal? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDelegatedAlertDismissalExtensions.ToValueString(value.Value));
            }
        }
    }
}
