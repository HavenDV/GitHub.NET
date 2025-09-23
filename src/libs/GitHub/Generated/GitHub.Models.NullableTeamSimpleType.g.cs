
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The ownership type of the team
    /// </summary>
    public enum NullableTeamSimpleType
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
    public static class NullableTeamSimpleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NullableTeamSimpleType value)
        {
            return value switch
            {
                NullableTeamSimpleType.Enterprise => "enterprise",
                NullableTeamSimpleType.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NullableTeamSimpleType? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => NullableTeamSimpleType.Enterprise,
                "organization" => NullableTeamSimpleType.Organization,
                _ => null,
            };
        }
    }
}