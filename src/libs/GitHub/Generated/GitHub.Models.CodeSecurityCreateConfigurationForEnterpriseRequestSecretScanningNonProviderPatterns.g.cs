
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of secret scanning non provider patterns<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningNonProviderPatterns
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
    public static class CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningNonProviderPatternsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningNonProviderPatterns value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningNonProviderPatterns.Enabled => "enabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningNonProviderPatterns.Disabled => "disabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningNonProviderPatterns.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningNonProviderPatterns? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningNonProviderPatterns.Enabled,
                "disabled" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningNonProviderPatterns.Disabled,
                "not_set" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningNonProviderPatterns.NotSet,
                _ => null,
            };
        }
    }
}