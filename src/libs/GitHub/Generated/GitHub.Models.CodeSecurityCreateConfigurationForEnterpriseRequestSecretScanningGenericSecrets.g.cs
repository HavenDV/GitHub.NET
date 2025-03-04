
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of Copilot secret scanning<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecrets
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
    public static class CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecretsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecrets value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecrets.Enabled => "enabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecrets.Disabled => "disabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecrets.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecrets? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecrets.Enabled,
                "disabled" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecrets.Disabled,
                "not_set" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningGenericSecrets.NotSet,
                _ => null,
            };
        }
    }
}