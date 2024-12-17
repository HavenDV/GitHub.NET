
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of secret scanning push protection<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningPushProtection
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
    public static class CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningPushProtectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningPushProtection value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningPushProtection.Enabled => "enabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningPushProtection.Disabled => "disabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningPushProtection.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningPushProtection? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningPushProtection.Enabled,
                "disabled" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningPushProtection.Disabled,
                "not_set" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningPushProtection.NotSet,
                _ => null,
            };
        }
    }
}