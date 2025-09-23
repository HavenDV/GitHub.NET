
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The ownership type of the team
    /// </summary>
    public enum WebhooksTeamParentType
    {
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksTeamParentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksTeamParentType value)
        {
            return value switch
            {
                WebhooksTeamParentType.Enterprise => "enterprise",
                WebhooksTeamParentType.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksTeamParentType? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => WebhooksTeamParentType.Enterprise,
                "organization" => WebhooksTeamParentType.Organization,
                _ => null,
            };
        }
    }
}