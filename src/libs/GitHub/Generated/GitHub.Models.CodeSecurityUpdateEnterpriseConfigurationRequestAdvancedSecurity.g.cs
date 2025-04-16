
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of GitHub Advanced Security features. `enabled` will enable both Code Security and Secret Protection features.
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity
    {
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        CodeSecurity,
        /// <summary>
        /// 
        /// </summary>
        SecretProtection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity.Enabled => "enabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity.Disabled => "disabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity.CodeSecurity => "code_security",
                CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity.SecretProtection => "secret_protection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity.Enabled,
                "disabled" => CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity.Disabled,
                "code_security" => CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity.CodeSecurity,
                "secret_protection" => CodeSecurityUpdateEnterpriseConfigurationRequestAdvancedSecurity.SecretProtection,
                _ => null,
            };
        }
    }
}