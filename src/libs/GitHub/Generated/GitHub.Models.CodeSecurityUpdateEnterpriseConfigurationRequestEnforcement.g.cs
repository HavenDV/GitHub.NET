
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enforcement status for a security configuration
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestEnforcement
    {
        /// <summary>
        /// 
        /// </summary>
        Enforced,
        /// <summary>
        /// 
        /// </summary>
        Unenforced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestEnforcementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestEnforcement value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestEnforcement.Enforced => "enforced",
                CodeSecurityUpdateEnterpriseConfigurationRequestEnforcement.Unenforced => "unenforced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestEnforcement? ToEnum(string value)
        {
            return value switch
            {
                "enforced" => CodeSecurityUpdateEnterpriseConfigurationRequestEnforcement.Enforced,
                "unenforced" => CodeSecurityUpdateEnterpriseConfigurationRequestEnforcement.Unenforced,
                _ => null,
            };
        }
    }
}