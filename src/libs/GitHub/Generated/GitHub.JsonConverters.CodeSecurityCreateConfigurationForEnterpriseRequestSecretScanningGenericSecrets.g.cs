#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecretsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecrets>
    {
        /// <inheritdoc />
        public override global::GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecrets Read(
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
                        return global::GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecretsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecrets)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecrets);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecrets value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecretsExtensions.ToValueString(value));
        }
    }
}
