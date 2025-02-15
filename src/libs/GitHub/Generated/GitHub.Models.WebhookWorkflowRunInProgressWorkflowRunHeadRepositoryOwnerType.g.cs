
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerType
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
    public static class WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerType value)
        {
            return value switch
            {
                WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerType.Bot => "Bot",
                WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerType.User => "User",
                WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerType.Bot,
                "User" => WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerType.User,
                "Organization" => WebhookWorkflowRunInProgressWorkflowRunHeadRepositoryOwnerType.Organization,
                _ => null,
            };
        }
    }
}