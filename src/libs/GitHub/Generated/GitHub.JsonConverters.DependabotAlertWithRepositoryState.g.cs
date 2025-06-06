#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class DependabotAlertWithRepositoryStateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.DependabotAlertWithRepositoryState>
    {
        /// <inheritdoc />
        public override global::GitHub.DependabotAlertWithRepositoryState Read(
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
                        return global::GitHub.DependabotAlertWithRepositoryStateExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.DependabotAlertWithRepositoryState)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.DependabotAlertWithRepositoryState);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.DependabotAlertWithRepositoryState value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.DependabotAlertWithRepositoryStateExtensions.ToValueString(value));
        }
    }
}
