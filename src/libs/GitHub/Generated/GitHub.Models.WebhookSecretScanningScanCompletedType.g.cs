
#nullable enable

namespace GitHub
{
    /// <summary>
    /// What type of scan was completed
    /// </summary>
    public enum WebhookSecretScanningScanCompletedType
    {
        /// <summary>
        /// 
        /// </summary>
        Backfill,
        /// <summary>
        /// 
        /// </summary>
        CustomPatternBackfill,
        /// <summary>
        /// 
        /// </summary>
        PatternVersionBackfill,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSecretScanningScanCompletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSecretScanningScanCompletedType value)
        {
            return value switch
            {
                WebhookSecretScanningScanCompletedType.Backfill => "backfill",
                WebhookSecretScanningScanCompletedType.CustomPatternBackfill => "custom-pattern-backfill",
                WebhookSecretScanningScanCompletedType.PatternVersionBackfill => "pattern-version-backfill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSecretScanningScanCompletedType? ToEnum(string value)
        {
            return value switch
            {
                "backfill" => WebhookSecretScanningScanCompletedType.Backfill,
                "custom-pattern-backfill" => WebhookSecretScanningScanCompletedType.CustomPatternBackfill,
                "pattern-version-backfill" => WebhookSecretScanningScanCompletedType.PatternVersionBackfill,
                _ => null,
            };
        }
    }
}