
#nullable enable

namespace GitHub
{
    /// <summary>
    /// State of a code scanning alert. Events for alerts found outside the default branch will return a `null` value until they are dismissed or fixed.
    /// </summary>
    public enum WebhookCodeScanningAlertReopenedAlertState
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCodeScanningAlertReopenedAlertStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCodeScanningAlertReopenedAlertState value)
        {
            return value switch
            {
                WebhookCodeScanningAlertReopenedAlertState.Open => "open",
                WebhookCodeScanningAlertReopenedAlertState.Dismissed => "dismissed",
                WebhookCodeScanningAlertReopenedAlertState.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCodeScanningAlertReopenedAlertState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookCodeScanningAlertReopenedAlertState.Open,
                "dismissed" => WebhookCodeScanningAlertReopenedAlertState.Dismissed,
                "fixed" => WebhookCodeScanningAlertReopenedAlertState.Fixed,
                _ => null,
            };
        }
    }
}