#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeSecurityCreateConfigurationRequestAdvancedSecurityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.CodeSecurityCreateConfigurationRequestAdvancedSecurity>
    {
        /// <inheritdoc />
        public override global::GitHub.CodeSecurityCreateConfigurationRequestAdvancedSecurity Read(
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
                        return global::GitHub.CodeSecurityCreateConfigurationRequestAdvancedSecurityExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.CodeSecurityCreateConfigurationRequestAdvancedSecurity)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.CodeSecurityCreateConfigurationRequestAdvancedSecurity);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.CodeSecurityCreateConfigurationRequestAdvancedSecurity value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.CodeSecurityCreateConfigurationRequestAdvancedSecurityExtensions.ToValueString(value));
        }
    }
}
