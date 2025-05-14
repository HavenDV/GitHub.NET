#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class PackagesRestorePackageVersionForUserPackageTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.PackagesRestorePackageVersionForUserPackageType?>
    {
        /// <inheritdoc />
        public override global::GitHub.PackagesRestorePackageVersionForUserPackageType? Read(
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
                        return global::GitHub.PackagesRestorePackageVersionForUserPackageTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.PackagesRestorePackageVersionForUserPackageType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.PackagesRestorePackageVersionForUserPackageType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.PackagesRestorePackageVersionForUserPackageType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.PackagesRestorePackageVersionForUserPackageTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
