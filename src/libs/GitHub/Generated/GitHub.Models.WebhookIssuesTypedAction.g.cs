
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesTypedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Typed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesTypedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTypedAction value)
        {
            return value switch
            {
                WebhookIssuesTypedAction.Typed => "typed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTypedAction? ToEnum(string value)
        {
            return value switch
            {
                "typed" => WebhookIssuesTypedAction.Typed,
                _ => null,
            };
        }
    }
}