
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The ownership type of the team
    /// </summary>
    public enum WebhooksTeam1Type
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
    public static class WebhooksTeam1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksTeam1Type value)
        {
            return value switch
            {
                WebhooksTeam1Type.Enterprise => "enterprise",
                WebhooksTeam1Type.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksTeam1Type? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => WebhooksTeam1Type.Enterprise,
                "organization" => WebhooksTeam1Type.Organization,
                _ => null,
            };
        }
    }
}