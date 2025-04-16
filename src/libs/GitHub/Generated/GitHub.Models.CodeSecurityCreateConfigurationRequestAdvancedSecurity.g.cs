
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of GitHub Advanced Security features. `enabled` will enable both Code Security and Secret Protection features.<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationRequestAdvancedSecurity
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
    public static class CodeSecurityCreateConfigurationRequestAdvancedSecurityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestAdvancedSecurity value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestAdvancedSecurity.Enabled => "enabled",
                CodeSecurityCreateConfigurationRequestAdvancedSecurity.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestAdvancedSecurity.CodeSecurity => "code_security",
                CodeSecurityCreateConfigurationRequestAdvancedSecurity.SecretProtection => "secret_protection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestAdvancedSecurity? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationRequestAdvancedSecurity.Enabled,
                "disabled" => CodeSecurityCreateConfigurationRequestAdvancedSecurity.Disabled,
                "code_security" => CodeSecurityCreateConfigurationRequestAdvancedSecurity.CodeSecurity,
                "secret_protection" => CodeSecurityCreateConfigurationRequestAdvancedSecurity.SecretProtection,
                _ => null,
            };
        }
    }
}