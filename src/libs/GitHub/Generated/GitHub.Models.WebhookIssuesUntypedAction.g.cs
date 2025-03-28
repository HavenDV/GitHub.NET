
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesUntypedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Untyped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesUntypedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUntypedAction value)
        {
            return value switch
            {
                WebhookIssuesUntypedAction.Untyped => "untyped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUntypedAction? ToEnum(string value)
        {
            return value switch
            {
                "untyped" => WebhookIssuesUntypedAction.Untyped,
                _ => null,
            };
        }
    }
}