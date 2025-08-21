
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueDependenciesBlockedByAddedAction
    {
        /// <summary>
        /// 
        /// </summary>
        BlockedByAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueDependenciesBlockedByAddedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueDependenciesBlockedByAddedAction value)
        {
            return value switch
            {
                WebhookIssueDependenciesBlockedByAddedAction.BlockedByAdded => "blocked_by_added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueDependenciesBlockedByAddedAction? ToEnum(string value)
        {
            return value switch
            {
                "blocked_by_added" => WebhookIssueDependenciesBlockedByAddedAction.BlockedByAdded,
                _ => null,
            };
        }
    }
}