
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of secret scanning delegated bypass
    /// </summary>
    public enum CodeSecurityConfigurationSecretScanningDelegatedBypass
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
    public static class CodeSecurityConfigurationSecretScanningDelegatedBypassExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationSecretScanningDelegatedBypass value)
        {
            return value switch
            {
                CodeSecurityConfigurationSecretScanningDelegatedBypass.Enabled => "enabled",
                CodeSecurityConfigurationSecretScanningDelegatedBypass.Disabled => "disabled",
                CodeSecurityConfigurationSecretScanningDelegatedBypass.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationSecretScanningDelegatedBypass? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityConfigurationSecretScanningDelegatedBypass.Enabled,
                "disabled" => CodeSecurityConfigurationSecretScanningDelegatedBypass.Disabled,
                "not_set" => CodeSecurityConfigurationSecretScanningDelegatedBypass.NotSet,
                _ => null,
            };
        }
    }
}