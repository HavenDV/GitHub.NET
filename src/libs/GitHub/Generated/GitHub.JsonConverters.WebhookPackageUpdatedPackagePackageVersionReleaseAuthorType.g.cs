#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPackageUpdatedPackagePackageVersionReleaseAuthorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.WebhookPackageUpdatedPackagePackageVersionReleaseAuthorType>
    {
        /// <inheritdoc />
        public override global::GitHub.WebhookPackageUpdatedPackagePackageVersionReleaseAuthorType Read(
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
                        return global::GitHub.WebhookPackageUpdatedPackagePackageVersionReleaseAuthorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.WebhookPackageUpdatedPackagePackageVersionReleaseAuthorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.WebhookPackageUpdatedPackagePackageVersionReleaseAuthorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.WebhookPackageUpdatedPackagePackageVersionReleaseAuthorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.WebhookPackageUpdatedPackagePackageVersionReleaseAuthorTypeExtensions.ToValueString(value));
        }
    }
}
