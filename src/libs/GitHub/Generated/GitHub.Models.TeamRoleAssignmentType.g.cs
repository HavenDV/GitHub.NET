
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The ownership type of the team
    /// </summary>
    public enum TeamRoleAssignmentType
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
    public static class TeamRoleAssignmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamRoleAssignmentType value)
        {
            return value switch
            {
                TeamRoleAssignmentType.Enterprise => "enterprise",
                TeamRoleAssignmentType.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamRoleAssignmentType? ToEnum(string value)
        {
            return value switch
            {
                "enterprise" => TeamRoleAssignmentType.Enterprise,
                "organization" => TeamRoleAssignmentType.Organization,
                _ => null,
            };
        }
    }
}