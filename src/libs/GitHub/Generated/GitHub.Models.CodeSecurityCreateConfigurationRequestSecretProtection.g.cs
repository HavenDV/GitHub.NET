
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of GitHub Secret Protection features.
    /// </summary>
    public enum CodeSecurityCreateConfigurationRequestSecretProtection
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
        NotSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityCreateConfigurationRequestSecretProtectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestSecretProtection value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestSecretProtection.Enabled => "enabled",
                CodeSecurityCreateConfigurationRequestSecretProtection.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestSecretProtection.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestSecretProtection? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationRequestSecretProtection.Enabled,
                "disabled" => CodeSecurityCreateConfigurationRequestSecretProtection.Disabled,
                "not_set" => CodeSecurityCreateConfigurationRequestSecretProtection.NotSet,
                _ => null,
            };
        }
    }
}