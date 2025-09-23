
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The ownership type of the team
    /// </summary>
    public enum TeamFullType
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
    public static class TeamFullTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamFullType value)
        {
            return value switch
            {
                TeamFullType.Enterprise => "enterprise",
                TeamFullType.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamFullType? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => TeamFullType.Enterprise,
                "organization" => TeamFullType.Organization,
                _ => null,
            };
        }
    }
}