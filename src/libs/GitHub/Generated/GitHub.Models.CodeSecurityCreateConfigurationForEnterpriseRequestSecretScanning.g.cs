
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of secret scanning<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanning
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
    public static class CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanning value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanning.Enabled => "enabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanning.Disabled => "disabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanning.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanning? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanning.Enabled,
                "disabled" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanning.Disabled,
                "not_set" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanning.NotSet,
                _ => null,
            };
        }
    }
}