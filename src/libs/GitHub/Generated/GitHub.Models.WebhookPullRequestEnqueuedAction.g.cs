
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestEnqueuedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Enqueued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestEnqueuedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedAction value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedAction.Enqueued => "enqueued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedAction? ToEnum(string value)
        {
            return value switch
            {
                "enqueued" => WebhookPullRequestEnqueuedAction.Enqueued,
                _ => null,
            };
        }
    }
}