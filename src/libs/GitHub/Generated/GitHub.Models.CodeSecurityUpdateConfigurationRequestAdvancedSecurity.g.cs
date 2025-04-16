
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of GitHub Advanced Security features. `enabled` will enable both Code Security and Secret Protection features.
    /// </summary>
    public enum CodeSecurityUpdateConfigurationRequestAdvancedSecurity
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
    public static class CodeSecurityUpdateConfigurationRequestAdvancedSecurityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestAdvancedSecurity value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestAdvancedSecurity.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestAdvancedSecurity.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestAdvancedSecurity.CodeSecurity => "code_security",
                CodeSecurityUpdateConfigurationRequestAdvancedSecurity.SecretProtection => "secret_protection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestAdvancedSecurity? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityUpdateConfigurationRequestAdvancedSecurity.Enabled,
                "disabled" => CodeSecurityUpdateConfigurationRequestAdvancedSecurity.Disabled,
                "code_security" => CodeSecurityUpdateConfigurationRequestAdvancedSecurity.CodeSecurity,
                "secret_protection" => CodeSecurityUpdateConfigurationRequestAdvancedSecurity.SecretProtection,
                _ => null,
            };
        }
    }
}