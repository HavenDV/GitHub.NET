#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class SecurityAdvisoriesListGlobalAdvisoriesTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.SecurityAdvisoriesListGlobalAdvisoriesType?>
    {
        /// <inheritdoc />
        public override global::GitHub.SecurityAdvisoriesListGlobalAdvisoriesType? Read(
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
                        return global::GitHub.SecurityAdvisoriesListGlobalAdvisoriesTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.SecurityAdvisoriesListGlobalAdvisoriesType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.SecurityAdvisoriesListGlobalAdvisoriesType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.SecurityAdvisoriesListGlobalAdvisoriesType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.SecurityAdvisoriesListGlobalAdvisoriesTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
