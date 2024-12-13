
#nullable enable

namespace GitHub
{
    /// <summary>
    /// If the scan was triggered by a custom pattern update, this will be the scope of the pattern that was updated
    /// </summary>
    public enum WebhookSecretScanningScanCompletedCustomPatternScope
    {
        /// <summary>
        /// 
        /// </summary>
        Repository,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSecretScanningScanCompletedCustomPatternScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSecretScanningScanCompletedCustomPatternScope value)
        {
            return value switch
            {
                WebhookSecretScanningScanCompletedCustomPatternScope.Repository => "repository",
                WebhookSecretScanningScanCompletedCustomPatternScope.Organization => "organization",
                WebhookSecretScanningScanCompletedCustomPatternScope.Enterprise => "enterprise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSecretScanningScanCompletedCustomPatternScope? ToEnum(string value)
        {
            return value switch
            {
                "repository" => WebhookSecretScanningScanCompletedCustomPatternScope.Repository,
                "organization" => WebhookSecretScanningScanCompletedCustomPatternScope.Organization,
                "enterprise" => WebhookSecretScanningScanCompletedCustomPatternScope.Enterprise,
                _ => null,
            };
        }
    }
}