#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsOrganizationPlanNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsOrganizationPlan?>
    {
        /// <inheritdoc />
        public override global::GitHub.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsOrganizationPlan? Read(
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
                        return global::GitHub.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsOrganizationPlanExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsOrganizationPlan)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsOrganizationPlan? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsOrganizationPlanExtensions.ToValueString(value.Value));
            }
        }
    }
}