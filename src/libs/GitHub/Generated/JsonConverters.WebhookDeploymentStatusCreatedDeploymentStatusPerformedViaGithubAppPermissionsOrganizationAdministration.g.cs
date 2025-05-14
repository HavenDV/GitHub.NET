#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsOrganizationAdministrationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsOrganizationAdministration>
    {
        /// <inheritdoc />
        public override global::GitHub.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsOrganizationAdministration Read(
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
                        return global::GitHub.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsOrganizationAdministrationExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsOrganizationAdministration)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsOrganizationAdministration);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsOrganizationAdministration value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsOrganizationAdministrationExtensions.ToValueString(value));
        }
    }
}
