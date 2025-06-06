#nullable enable

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiInsightsGetTimeStatsByActorActorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.ApiInsightsGetTimeStatsByActorActorType>
    {
        /// <inheritdoc />
        public override global::GitHub.ApiInsightsGetTimeStatsByActorActorType Read(
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
                        return global::GitHub.ApiInsightsGetTimeStatsByActorActorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.ApiInsightsGetTimeStatsByActorActorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::GitHub.ApiInsightsGetTimeStatsByActorActorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.ApiInsightsGetTimeStatsByActorActorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::GitHub.ApiInsightsGetTimeStatsByActorActorTypeExtensions.ToValueString(value));
        }
    }
}
