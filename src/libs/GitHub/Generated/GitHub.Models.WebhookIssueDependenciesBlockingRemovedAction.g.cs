
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueDependenciesBlockingRemovedAction
    {
        /// <summary>
        /// 
        /// </summary>
        BlockingRemoved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueDependenciesBlockingRemovedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueDependenciesBlockingRemovedAction value)
        {
            return value switch
            {
                WebhookIssueDependenciesBlockingRemovedAction.BlockingRemoved => "blocking_removed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueDependenciesBlockingRemovedAction? ToEnum(string value)
        {
            return value switch
            {
                "blocking_removed" => WebhookIssueDependenciesBlockingRemovedAction.BlockingRemoved,
                _ => null,
            };
        }
    }
}