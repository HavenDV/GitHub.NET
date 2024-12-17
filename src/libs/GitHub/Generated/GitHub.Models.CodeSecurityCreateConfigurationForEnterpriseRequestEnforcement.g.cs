
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enforcement status for a security configuration<br/>
    /// Default Value: enforced
    /// </summary>
    public enum CodeSecurityCreateConfigurationForEnterpriseRequestEnforcement
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
    public static class CodeSecurityCreateConfigurationForEnterpriseRequestEnforcementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationForEnterpriseRequestEnforcement value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationForEnterpriseRequestEnforcement.Enforced => "enforced",
                CodeSecurityCreateConfigurationForEnterpriseRequestEnforcement.Unenforced => "unenforced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationForEnterpriseRequestEnforcement? ToEnum(string value)
        {
            return value switch
            {
                "enforced" => CodeSecurityCreateConfigurationForEnterpriseRequestEnforcement.Enforced,
                "unenforced" => CodeSecurityCreateConfigurationForEnterpriseRequestEnforcement.Unenforced,
                _ => null,
            };
        }
    }
}