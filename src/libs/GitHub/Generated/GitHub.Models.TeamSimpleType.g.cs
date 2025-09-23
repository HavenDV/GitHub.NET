
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The ownership type of the team
    /// </summary>
    public enum TeamSimpleType
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
    public static class TeamSimpleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamSimpleType value)
        {
            return value switch
            {
                TeamSimpleType.Enterprise => "enterprise",
                TeamSimpleType.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamSimpleType? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => TeamSimpleType.Enterprise,
                "organization" => TeamSimpleType.Organization,
                _ => null,
            };
        }
    }
}