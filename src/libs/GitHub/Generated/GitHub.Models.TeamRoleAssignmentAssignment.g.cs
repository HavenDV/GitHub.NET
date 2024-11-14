
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Determines if the team has a direct, indirect, or mixed relationship to a role<br/>
    /// Example: direct
    /// </summary>
    public enum TeamRoleAssignmentAssignment
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
    public static class TeamRoleAssignmentAssignmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamRoleAssignmentAssignment value)
        {
            return value switch
            {
                TeamRoleAssignmentAssignment.Direct => "direct",
                TeamRoleAssignmentAssignment.Indirect => "indirect",
                TeamRoleAssignmentAssignment.Mixed => "mixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamRoleAssignmentAssignment? ToEnum(string value)
        {
            return value switch
            {
                "direct" => TeamRoleAssignmentAssignment.Direct,
                "indirect" => TeamRoleAssignmentAssignment.Indirect,
                "mixed" => TeamRoleAssignmentAssignment.Mixed,
                _ => null,
            };
        }
    }
}