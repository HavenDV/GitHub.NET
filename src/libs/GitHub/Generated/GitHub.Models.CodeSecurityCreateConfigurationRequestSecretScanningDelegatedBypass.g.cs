
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of secret scanning delegated bypass<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass
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
    public static class CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypassExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass.Enabled => "enabled",
                CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass.Enabled,
                "disabled" => CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass.Disabled,
                "not_set" => CodeSecurityCreateConfigurationRequestSecretScanningDelegatedBypass.NotSet,
                _ => null,
            };
        }
    }
}