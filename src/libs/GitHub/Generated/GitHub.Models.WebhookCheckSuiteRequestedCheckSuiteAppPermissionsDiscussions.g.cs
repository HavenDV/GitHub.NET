
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDiscussions
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDiscussionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDiscussions value)
        {
            return value switch
            {
                WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDiscussions.Read => "read",
                WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDiscussions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDiscussions? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDiscussions.Read,
                "write" => WebhookCheckSuiteRequestedCheckSuiteAppPermissionsDiscussions.Write,
                _ => null,
            };
        }
    }
}