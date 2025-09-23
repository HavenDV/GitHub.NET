
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The ownership type of the team
    /// </summary>
    public enum WebhooksTeamType
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
    public static class WebhooksTeamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksTeamType value)
        {
            return value switch
            {
                WebhooksTeamType.Enterprise => "enterprise",
                WebhooksTeamType.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksTeamType? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => WebhooksTeamType.Enterprise,
                "organization" => WebhooksTeamType.Organization,
                _ => null,
            };
        }
    }
}