
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCustomPropertyPromotedToEnterpriseAction
    {
        /// <summary>
        /// 
        /// </summary>
        PromoteToEnterprise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCustomPropertyPromotedToEnterpriseActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCustomPropertyPromotedToEnterpriseAction value)
        {
            return value switch
            {
                WebhookCustomPropertyPromotedToEnterpriseAction.PromoteToEnterprise => "promote_to_enterprise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCustomPropertyPromotedToEnterpriseAction? ToEnum(string value)
        {
            return value switch
            {
                "promote_to_enterprise" => WebhookCustomPropertyPromotedToEnterpriseAction.PromoteToEnterprise,
                _ => null,
            };
        }
    }
}