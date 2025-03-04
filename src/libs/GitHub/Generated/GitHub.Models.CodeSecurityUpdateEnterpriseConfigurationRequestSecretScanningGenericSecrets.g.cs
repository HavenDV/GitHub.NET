
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of Copilot secret scanning<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningGenericSecrets
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
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningGenericSecretsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningGenericSecrets value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningGenericSecrets.Enabled => "enabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningGenericSecrets.Disabled => "disabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningGenericSecrets.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningGenericSecrets? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningGenericSecrets.Enabled,
                "disabled" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningGenericSecrets.Disabled,
                "not_set" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningGenericSecrets.NotSet,
                _ => null,
            };
        }
    }
}