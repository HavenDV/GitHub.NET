
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The side of the first line of the range for a multi-line comment.<br/>
    /// Default Value: RIGHT
    /// </summary>
    public enum WebhookPullRequestReviewThreadUnresolvedThreadCommentsStartSide
    {
        /// <summary>
        /// 
        /// </summary>
        LEFT,
        /// <summary>
        /// 
        /// </summary>
        RIGHT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewThreadUnresolvedThreadCommentsStartSideExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedThreadCommentsStartSide value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedThreadCommentsStartSide.LEFT => "LEFT",
                WebhookPullRequestReviewThreadUnresolvedThreadCommentsStartSide.RIGHT => "RIGHT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedThreadCommentsStartSide? ToEnum(string value)
        {
            return value switch
            {
                "LEFT" => WebhookPullRequestReviewThreadUnresolvedThreadCommentsStartSide.LEFT,
                "RIGHT" => WebhookPullRequestReviewThreadUnresolvedThreadCommentsStartSide.RIGHT,
                _ => null,
            };
        }
    }
}