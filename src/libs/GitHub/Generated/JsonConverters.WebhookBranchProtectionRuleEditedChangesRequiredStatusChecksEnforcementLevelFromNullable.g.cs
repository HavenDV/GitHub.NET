#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFromNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFrom?>
    {
        /// <inheritdoc />
        public override global::GitHub.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFrom? Read(
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
                        return global::GitHub.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFromExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFrom)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFrom?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFrom? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.WebhookBranchProtectionRuleEditedChangesRequiredStatusChecksEnforcementLevelFromExtensions.ToValueString(value.Value));
            }
        }
    }
}
