
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueDependenciesBlockedByRemovedAction
    {
        /// <summary>
        /// 
        /// </summary>
        BlockedByRemoved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueDependenciesBlockedByRemovedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueDependenciesBlockedByRemovedAction value)
        {
            return value switch
            {
                WebhookIssueDependenciesBlockedByRemovedAction.BlockedByRemoved => "blocked_by_removed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueDependenciesBlockedByRemovedAction? ToEnum(string value)
        {
            return value switch
            {
                "blocked_by_removed" => WebhookIssueDependenciesBlockedByRemovedAction.BlockedByRemoved,
                _ => null,
            };
        }
    }
}