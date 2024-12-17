
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of secret scanning
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning
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
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning.Enabled => "enabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning.Disabled => "disabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning.Enabled,
                "disabled" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning.Disabled,
                "not_set" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanning.NotSet,
                _ => null,
            };
        }
    }
}