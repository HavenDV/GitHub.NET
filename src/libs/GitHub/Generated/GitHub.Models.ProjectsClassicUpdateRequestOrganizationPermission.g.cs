
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The baseline permission that all organization members have on this project
    /// </summary>
    public enum ProjectsClassicUpdateRequestOrganizationPermission
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsClassicUpdateRequestOrganizationPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsClassicUpdateRequestOrganizationPermission value)
        {
            return value switch
            {
                ProjectsClassicUpdateRequestOrganizationPermission.Read => "read",
                ProjectsClassicUpdateRequestOrganizationPermission.Write => "write",
                ProjectsClassicUpdateRequestOrganizationPermission.Admin => "admin",
                ProjectsClassicUpdateRequestOrganizationPermission.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsClassicUpdateRequestOrganizationPermission? ToEnum(string value)
        {
            return value switch
            {
                "read" => ProjectsClassicUpdateRequestOrganizationPermission.Read,
                "write" => ProjectsClassicUpdateRequestOrganizationPermission.Write,
                "admin" => ProjectsClassicUpdateRequestOrganizationPermission.Admin,
                "none" => ProjectsClassicUpdateRequestOrganizationPermission.None,
                _ => null,
            };
        }
    }
}