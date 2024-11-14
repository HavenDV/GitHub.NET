
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The system role from which this role inherits permissions.
    /// </summary>
    public enum OrganizationRoleBaseRole
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Triage,
        /// <summary>
        /// 
        /// </summary>
        Write,
        /// <summary>
        /// 
        /// </summary>
        Maintain,
        /// <summary>
        /// 
        /// </summary>
        Admin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationRoleBaseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationRoleBaseRole value)
        {
            return value switch
            {
                OrganizationRoleBaseRole.Read => "read",
                OrganizationRoleBaseRole.Triage => "triage",
                OrganizationRoleBaseRole.Write => "write",
                OrganizationRoleBaseRole.Maintain => "maintain",
                OrganizationRoleBaseRole.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationRoleBaseRole? ToEnum(string value)
        {
            return value switch
            {
                "read" => OrganizationRoleBaseRole.Read,
                "triage" => OrganizationRoleBaseRole.Triage,
                "write" => OrganizationRoleBaseRole.Write,
                "maintain" => OrganizationRoleBaseRole.Maintain,
                "admin" => OrganizationRoleBaseRole.Admin,
                _ => null,
            };
        }
    }
}