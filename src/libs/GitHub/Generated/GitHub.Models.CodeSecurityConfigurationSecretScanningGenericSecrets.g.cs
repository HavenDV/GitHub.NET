
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of Copilot secret scanning
    /// </summary>
    public enum CodeSecurityConfigurationSecretScanningGenericSecrets
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
    public static class CodeSecurityConfigurationSecretScanningGenericSecretsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationSecretScanningGenericSecrets value)
        {
            return value switch
            {
                CodeSecurityConfigurationSecretScanningGenericSecrets.Enabled => "enabled",
                CodeSecurityConfigurationSecretScanningGenericSecrets.Disabled => "disabled",
                CodeSecurityConfigurationSecretScanningGenericSecrets.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationSecretScanningGenericSecrets? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityConfigurationSecretScanningGenericSecrets.Enabled,
                "disabled" => CodeSecurityConfigurationSecretScanningGenericSecrets.Disabled,
                "not_set" => CodeSecurityConfigurationSecretScanningGenericSecrets.NotSet,
                _ => null,
            };
        }
    }
}