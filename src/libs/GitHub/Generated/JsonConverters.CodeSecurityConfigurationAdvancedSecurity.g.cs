#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeSecurityConfigurationAdvancedSecurityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.CodeSecurityConfigurationAdvancedSecurity>
    {
        /// <inheritdoc />
        public override global::GitHub.CodeSecurityConfigurationAdvancedSecurity Read(
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
                        return global::GitHub.CodeSecurityConfigurationAdvancedSecurityExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.CodeSecurityConfigurationAdvancedSecurity)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.CodeSecurityConfigurationAdvancedSecurity);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.CodeSecurityConfigurationAdvancedSecurity value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.CodeSecurityConfigurationAdvancedSecurityExtensions.ToValueString(value));
        }
    }
}
