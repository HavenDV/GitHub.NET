
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Source answers the question, "where did this role come from?"
    /// </summary>
    public enum OrganizationRoleSource
    {
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Predefined,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationRoleSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationRoleSource value)
        {
            return value switch
            {
                OrganizationRoleSource.Organization => "Organization",
                OrganizationRoleSource.Enterprise => "Enterprise",
                OrganizationRoleSource.Predefined => "Predefined",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationRoleSource? ToEnum(string value)
        {
            return value switch
            {
                "Organization" => OrganizationRoleSource.Organization,
                "Enterprise" => OrganizationRoleSource.Enterprise,
                "Predefined" => OrganizationRoleSource.Predefined,
                _ => null,
            };
        }
    }
}