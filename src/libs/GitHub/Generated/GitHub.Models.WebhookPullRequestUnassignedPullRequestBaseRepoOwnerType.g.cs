
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnassignedPullRequestBaseRepoOwnerType
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
    public static class WebhookPullRequestUnassignedPullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestUnassignedPullRequestBaseRepoOwnerType.User => "User",
                WebhookPullRequestUnassignedPullRequestBaseRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestBaseRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnassignedPullRequestBaseRepoOwnerType.Bot,
                "User" => WebhookPullRequestUnassignedPullRequestBaseRepoOwnerType.User,
                "Organization" => WebhookPullRequestUnassignedPullRequestBaseRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}