#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatternsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns>
    {
        /// <inheritdoc />
        public override global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns Read(
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
                        return global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatternsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatternsExtensions.ToValueString(value));
        }
    }
}
