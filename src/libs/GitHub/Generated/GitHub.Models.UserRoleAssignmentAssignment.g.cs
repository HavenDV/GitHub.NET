
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Determines if the user has a direct, indirect, or mixed relationship to a role<br/>
    /// Example: direct
    /// </summary>
    public enum UserRoleAssignmentAssignment
    {
        /// <summary>
        /// 
        /// </summary>
        Direct,
        /// <summary>
        /// 
        /// </summary>
        Indirect,
        /// <summary>
        /// 
        /// </summary>
        Mixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserRoleAssignmentAssignmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserRoleAssignmentAssignment value)
        {
            return value switch
            {
                UserRoleAssignmentAssignment.Direct => "direct",
                UserRoleAssignmentAssignment.Indirect => "indirect",
                UserRoleAssignmentAssignment.Mixed => "mixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserRoleAssignmentAssignment? ToEnum(string value)
        {
            return value switch
            {
                "direct" => UserRoleAssignmentAssignment.Direct,
                "indirect" => UserRoleAssignmentAssignment.Indirect,
                "mixed" => UserRoleAssignmentAssignment.Mixed,
                _ => null,
            };
        }
    }
}