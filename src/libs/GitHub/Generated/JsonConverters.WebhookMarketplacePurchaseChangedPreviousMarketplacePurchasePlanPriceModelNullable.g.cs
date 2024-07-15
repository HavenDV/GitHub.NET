#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel?>
    {
        /// <inheritdoc />
        public override global::GitHub.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel? Read(
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
                        return global::GitHub.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::GitHub.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::GitHub.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
