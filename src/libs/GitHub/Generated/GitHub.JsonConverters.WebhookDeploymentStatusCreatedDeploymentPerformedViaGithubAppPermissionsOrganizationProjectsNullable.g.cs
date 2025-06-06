#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationProjectsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationProjects?>
    {
        /// <inheritdoc />
        public override global::GitHub.WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationProjects? Read(
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
                        return global::GitHub.WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationProjectsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationProjects)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationProjects?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationProjects? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsOrganizationProjectsExtensions.ToValueString(value.Value));
            }
        }
    }
}
