#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeScanningDefaultSetupUpdateRunnerTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.CodeScanningDefaultSetupUpdateRunnerType>
    {
        /// <inheritdoc />
        public override global::GitHub.CodeScanningDefaultSetupUpdateRunnerType Read(
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
                        return global::GitHub.CodeScanningDefaultSetupUpdateRunnerTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.CodeScanningDefaultSetupUpdateRunnerType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.CodeScanningDefaultSetupUpdateRunnerType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.CodeScanningDefaultSetupUpdateRunnerType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.CodeScanningDefaultSetupUpdateRunnerTypeExtensions.ToValueString(value));
        }
    }
}
