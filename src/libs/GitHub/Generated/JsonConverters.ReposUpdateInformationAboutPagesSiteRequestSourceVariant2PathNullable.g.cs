#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReposUpdateInformationAboutPagesSiteRequestSourceVariant2PathNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.ReposUpdateInformationAboutPagesSiteRequestSourceVariant2Path?>
    {
        /// <inheritdoc />
        public override global::GitHub.ReposUpdateInformationAboutPagesSiteRequestSourceVariant2Path? Read(
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
                        return global::GitHub.ReposUpdateInformationAboutPagesSiteRequestSourceVariant2PathExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.ReposUpdateInformationAboutPagesSiteRequestSourceVariant2Path)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.ReposUpdateInformationAboutPagesSiteRequestSourceVariant2Path? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.ReposUpdateInformationAboutPagesSiteRequestSourceVariant2PathExtensions.ToValueString(value.Value));
            }
        }
    }
}
