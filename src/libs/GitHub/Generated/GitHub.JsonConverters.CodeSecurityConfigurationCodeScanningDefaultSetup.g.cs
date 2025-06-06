#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeSecurityConfigurationCodeScanningDefaultSetupJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.CodeSecurityConfigurationCodeScanningDefaultSetup>
    {
        /// <inheritdoc />
        public override global::GitHub.CodeSecurityConfigurationCodeScanningDefaultSetup Read(
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
                        return global::GitHub.CodeSecurityConfigurationCodeScanningDefaultSetupExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.CodeSecurityConfigurationCodeScanningDefaultSetup)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.CodeSecurityConfigurationCodeScanningDefaultSetup);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.CodeSecurityConfigurationCodeScanningDefaultSetup value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.CodeSecurityConfigurationCodeScanningDefaultSetupExtensions.ToValueString(value));
        }
    }
}
