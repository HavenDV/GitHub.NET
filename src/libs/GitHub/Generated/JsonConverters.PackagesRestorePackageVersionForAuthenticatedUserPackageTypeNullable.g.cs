#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class PackagesRestorePackageVersionForAuthenticatedUserPackageTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.PackagesRestorePackageVersionForAuthenticatedUserPackageType?>
    {
        /// <inheritdoc />
        public override global::GitHub.PackagesRestorePackageVersionForAuthenticatedUserPackageType? Read(
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
                        return global::GitHub.PackagesRestorePackageVersionForAuthenticatedUserPackageTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.PackagesRestorePackageVersionForAuthenticatedUserPackageType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.PackagesRestorePackageVersionForAuthenticatedUserPackageType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.PackagesRestorePackageVersionForAuthenticatedUserPackageType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.PackagesRestorePackageVersionForAuthenticatedUserPackageTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
