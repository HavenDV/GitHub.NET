
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentStatusCreatedDeploymentCreatorType
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
    public static class WebhookDeploymentStatusCreatedDeploymentCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedDeploymentCreatorType value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedDeploymentCreatorType.Bot => "Bot",
                WebhookDeploymentStatusCreatedDeploymentCreatorType.User => "User",
                WebhookDeploymentStatusCreatedDeploymentCreatorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedDeploymentCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookDeploymentStatusCreatedDeploymentCreatorType.Bot,
                "User" => WebhookDeploymentStatusCreatedDeploymentCreatorType.User,
                "Organization" => WebhookDeploymentStatusCreatedDeploymentCreatorType.Organization,
                _ => null,
            };
        }
    }
}