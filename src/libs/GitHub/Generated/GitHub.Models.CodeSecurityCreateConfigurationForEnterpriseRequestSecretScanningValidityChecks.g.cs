
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of secret scanning validity checks<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningValidityChecks
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
    public static class CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningValidityChecksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningValidityChecks value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningValidityChecks.Enabled => "enabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningValidityChecks.Disabled => "disabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningValidityChecks.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningValidityChecks? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningValidityChecks.Enabled,
                "disabled" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningValidityChecks.Disabled,
                "not_set" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningValidityChecks.NotSet,
                _ => null,
            };
        }
    }
}