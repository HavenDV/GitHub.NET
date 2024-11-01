
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssuesUnlockedIssueMilestoneState
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesUnlockedIssueMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssueMilestoneState value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssueMilestoneState.Open => "open",
                WebhookIssuesUnlockedIssueMilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssueMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssuesUnlockedIssueMilestoneState.Open,
                "closed" => WebhookIssuesUnlockedIssueMilestoneState.Closed,
                _ => null,
            };
        }
    }
}