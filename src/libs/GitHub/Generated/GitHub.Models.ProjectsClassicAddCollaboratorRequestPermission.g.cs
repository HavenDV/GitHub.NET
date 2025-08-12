
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The permission to grant the collaborator.<br/>
    /// Default Value: write<br/>
    /// Example: write
    /// </summary>
    public enum ProjectsClassicAddCollaboratorRequestPermission
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsClassicAddCollaboratorRequestPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsClassicAddCollaboratorRequestPermission value)
        {
            return value switch
            {
                ProjectsClassicAddCollaboratorRequestPermission.Read => "read",
                ProjectsClassicAddCollaboratorRequestPermission.Write => "write",
                ProjectsClassicAddCollaboratorRequestPermission.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsClassicAddCollaboratorRequestPermission? ToEnum(string value)
        {
            return value switch
            {
                "read" => ProjectsClassicAddCollaboratorRequestPermission.Read,
                "write" => ProjectsClassicAddCollaboratorRequestPermission.Write,
                "admin" => ProjectsClassicAddCollaboratorRequestPermission.Admin,
                _ => null,
            };
        }
    }
}