#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretScanningAlertsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretScanningAlerts?>
    {
        /// <inheritdoc />
        public override global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretScanningAlerts? Read(
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
                        return global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretScanningAlertsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretScanningAlerts)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretScanningAlerts?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretScanningAlerts? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretScanningAlertsExtensions.ToValueString(value.Value));
            }
        }
    }
}
