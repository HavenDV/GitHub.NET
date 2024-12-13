
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookSecretScanningScanCompletedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSecretScanningScanCompletedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSecretScanningScanCompletedAction value)
        {
            return value switch
            {
                WebhookSecretScanningScanCompletedAction.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSecretScanningScanCompletedAction? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookSecretScanningScanCompletedAction.Completed,
                _ => null,
            };
        }
    }
}