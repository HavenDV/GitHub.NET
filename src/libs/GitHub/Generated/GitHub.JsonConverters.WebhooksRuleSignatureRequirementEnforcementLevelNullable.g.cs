#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhooksRuleSignatureRequirementEnforcementLevelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.WebhooksRuleSignatureRequirementEnforcementLevel?>
    {
        /// <inheritdoc />
        public override global::GitHub.WebhooksRuleSignatureRequirementEnforcementLevel? Read(
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
                        return global::GitHub.WebhooksRuleSignatureRequirementEnforcementLevelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.WebhooksRuleSignatureRequirementEnforcementLevel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.WebhooksRuleSignatureRequirementEnforcementLevel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.WebhooksRuleSignatureRequirementEnforcementLevel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.WebhooksRuleSignatureRequirementEnforcementLevelExtensions.ToValueString(value.Value));
            }
        }
    }
}
