
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The action that was performed.
    /// </summary>
    public enum WebhookIssuesClosedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesClosedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedAction value)
        {
            return value switch
            {
                WebhookIssuesClosedAction.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedAction? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssuesClosedAction.Closed,
                _ => null,
            };
        }
    }
}