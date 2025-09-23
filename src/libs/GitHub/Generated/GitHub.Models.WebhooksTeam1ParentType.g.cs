
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The ownership type of the team
    /// </summary>
    public enum WebhooksTeam1ParentType
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
    public static class WebhooksTeam1ParentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksTeam1ParentType value)
        {
            return value switch
            {
                WebhooksTeam1ParentType.Enterprise => "enterprise",
                WebhooksTeam1ParentType.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksTeam1ParentType? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => WebhooksTeam1ParentType.Enterprise,
                "organization" => WebhooksTeam1ParentType.Organization,
                _ => null,
            };
        }
    }
}