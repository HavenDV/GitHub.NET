
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of secret scanning non-provider patterns
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns
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
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatternsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns.Enabled => "enabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns.Disabled => "disabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns.Enabled,
                "disabled" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns.Disabled,
                "not_set" => CodeSecurityUpdateEnterpriseConfigurationRequestSecretScanningNonProviderPatterns.NotSet,
                _ => null,
            };
        }
    }
}