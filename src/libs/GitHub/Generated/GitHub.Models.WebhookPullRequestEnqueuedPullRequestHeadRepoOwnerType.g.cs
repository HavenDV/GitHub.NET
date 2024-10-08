
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerType.Bot => "Bot",
                WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerType.User => "User",
                WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerType.Bot,
                "User" => WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerType.User,
                "Organization" => WebhookPullRequestEnqueuedPullRequestHeadRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}