#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodespacesCreateForAuthenticatedUserRequestVariant2GeoNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.CodespacesCreateForAuthenticatedUserRequestVariant2Geo?>
    {
        /// <inheritdoc />
        public override global::GitHub.CodespacesCreateForAuthenticatedUserRequestVariant2Geo? Read(
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
                        return global::GitHub.CodespacesCreateForAuthenticatedUserRequestVariant2GeoExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.CodespacesCreateForAuthenticatedUserRequestVariant2Geo)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.CodespacesCreateForAuthenticatedUserRequestVariant2Geo?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.CodespacesCreateForAuthenticatedUserRequestVariant2Geo? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.CodespacesCreateForAuthenticatedUserRequestVariant2GeoExtensions.ToValueString(value.Value));
            }
        }
    }
}
