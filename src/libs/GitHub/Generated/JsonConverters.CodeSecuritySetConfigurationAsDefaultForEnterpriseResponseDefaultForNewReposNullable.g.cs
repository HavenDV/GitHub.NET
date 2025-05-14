#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewReposNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewRepos?>
    {
        /// <inheritdoc />
        public override global::GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewRepos? Read(
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
                        return global::GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewReposExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewRepos)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewRepos?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewRepos? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewReposExtensions.ToValueString(value.Value));
            }
        }
    }
}
