
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueDependenciesBlockingAddedAction
    {
        /// <summary>
        /// 
        /// </summary>
        BlockingAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueDependenciesBlockingAddedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueDependenciesBlockingAddedAction value)
        {
            return value switch
            {
                WebhookIssueDependenciesBlockingAddedAction.BlockingAdded => "blocking_added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueDependenciesBlockingAddedAction? ToEnum(string value)
        {
            return value switch
            {
                "blocking_added" => WebhookIssueDependenciesBlockingAddedAction.BlockingAdded,
                _ => null,
            };
        }
    }
}