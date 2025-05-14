#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class MigrationsStartImportRequestVcsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.MigrationsStartImportRequestVcs>
    {
        /// <inheritdoc />
        public override global::GitHub.MigrationsStartImportRequestVcs Read(
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
                        return global::GitHub.MigrationsStartImportRequestVcsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.MigrationsStartImportRequestVcs)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.MigrationsStartImportRequestVcs);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.MigrationsStartImportRequestVcs value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.MigrationsStartImportRequestVcsExtensions.ToValueString(value));
        }
    }
}
