#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeSecurityConfigurationDependabotSecurityUpdatesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.CodeSecurityConfigurationDependabotSecurityUpdates>
    {
        /// <inheritdoc />
        public override global::GitHub.CodeSecurityConfigurationDependabotSecurityUpdates Read(
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
                        return global::GitHub.CodeSecurityConfigurationDependabotSecurityUpdatesExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.CodeSecurityConfigurationDependabotSecurityUpdates)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.CodeSecurityConfigurationDependabotSecurityUpdates);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.CodeSecurityConfigurationDependabotSecurityUpdates value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.CodeSecurityConfigurationDependabotSecurityUpdatesExtensions.ToValueString(value));
        }
    }
}
