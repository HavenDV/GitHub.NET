
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The ownership type of the team
    /// </summary>
    public enum TeamType
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
    public static class TeamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamType value)
        {
            return value switch
            {
                TeamType.Enterprise => "enterprise",
                TeamType.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamType? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => TeamType.Enterprise,
                "organization" => TeamType.Organization,
                _ => null,
            };
        }
    }
}