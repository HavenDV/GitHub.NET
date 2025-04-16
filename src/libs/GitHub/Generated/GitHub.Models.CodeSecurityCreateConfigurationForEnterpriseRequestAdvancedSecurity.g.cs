
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of GitHub Advanced Security features. `enabled` will enable both Code Security and Secret Protection features.<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity
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
    public static class CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity.Enabled => "enabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity.Disabled => "disabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity.CodeSecurity => "code_security",
                CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity.SecretProtection => "secret_protection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity.Enabled,
                "disabled" => CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity.Disabled,
                "code_security" => CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity.CodeSecurity,
                "secret_protection" => CodeSecurityCreateConfigurationForEnterpriseRequestAdvancedSecurity.SecretProtection,
                _ => null,
            };
        }
    }
}