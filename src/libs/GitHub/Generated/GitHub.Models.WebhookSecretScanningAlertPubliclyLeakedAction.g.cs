
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookSecretScanningAlertPubliclyLeakedAction
    {
        /// <summary>
        /// 
        /// </summary>
        PubliclyLeaked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSecretScanningAlertPubliclyLeakedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSecretScanningAlertPubliclyLeakedAction value)
        {
            return value switch
            {
                WebhookSecretScanningAlertPubliclyLeakedAction.PubliclyLeaked => "publicly_leaked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSecretScanningAlertPubliclyLeakedAction? ToEnum(string value)
        {
            return value switch
            {
                "publicly_leaked" => WebhookSecretScanningAlertPubliclyLeakedAction.PubliclyLeaked,
                _ => null,
            };
        }
    }
}