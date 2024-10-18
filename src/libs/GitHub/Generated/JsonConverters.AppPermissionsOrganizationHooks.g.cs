#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class AppPermissionsOrganizationHooksJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.AppPermissionsOrganizationHooks>
    {
        /// <inheritdoc />
        public override global::GitHub.AppPermissionsOrganizationHooks Read(
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
                        return global::GitHub.AppPermissionsOrganizationHooksExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.AppPermissionsOrganizationHooks)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.AppPermissionsOrganizationHooks value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.AppPermissionsOrganizationHooksExtensions.ToValueString(value));
        }
    }
}
