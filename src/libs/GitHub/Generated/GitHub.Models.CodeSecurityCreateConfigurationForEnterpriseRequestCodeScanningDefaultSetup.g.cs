
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of code scanning default setup<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDefaultSetup
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
    public static class CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDefaultSetupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDefaultSetup value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDefaultSetup.Enabled => "enabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDefaultSetup.Disabled => "disabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDefaultSetup.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDefaultSetup? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDefaultSetup.Enabled,
                "disabled" => CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDefaultSetup.Disabled,
                "not_set" => CodeSecurityCreateConfigurationForEnterpriseRequestCodeScanningDefaultSetup.NotSet,
                _ => null,
            };
        }
    }
}