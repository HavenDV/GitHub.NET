
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of secret scanning validity checks
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningValidityChecks
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
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningValidityChecksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningValidityChecks value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningValidityChecks.Enabled => "enabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningValidityChecks.Disabled => "disabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningValidityChecks.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningValidityChecks? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningValidityChecks.Enabled,
                "disabled" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningValidityChecks.Disabled,
                "not_set" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningValidityChecks.NotSet,
                _ => null,
            };
        }
    }
}