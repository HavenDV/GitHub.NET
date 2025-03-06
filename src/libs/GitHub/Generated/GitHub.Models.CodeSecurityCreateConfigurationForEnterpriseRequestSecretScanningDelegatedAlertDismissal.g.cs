
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of secret scanning delegated alert dismissal<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningDelegatedAlertDismissal
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
    public static class CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningDelegatedAlertDismissalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningDelegatedAlertDismissal value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningDelegatedAlertDismissal.Enabled => "enabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningDelegatedAlertDismissal.Disabled => "disabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningDelegatedAlertDismissal.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningDelegatedAlertDismissal? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningDelegatedAlertDismissal.Enabled,
                "disabled" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningDelegatedAlertDismissal.Disabled,
                "not_set" => CodeSecurityCreateConfigurationForEnterpriseRequestSecretScanningDelegatedAlertDismissal.NotSet,
                _ => null,
            };
        }
    }
}