
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of secret scanning delegated alert dismissal
    /// </summary>
    public enum CodeSecurityConfigurationSecretScanningDelegatedAlertDismissal
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
    public static class CodeSecurityConfigurationSecretScanningDelegatedAlertDismissalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationSecretScanningDelegatedAlertDismissal value)
        {
            return value switch
            {
                CodeSecurityConfigurationSecretScanningDelegatedAlertDismissal.Enabled => "enabled",
                CodeSecurityConfigurationSecretScanningDelegatedAlertDismissal.Disabled => "disabled",
                CodeSecurityConfigurationSecretScanningDelegatedAlertDismissal.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationSecretScanningDelegatedAlertDismissal? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityConfigurationSecretScanningDelegatedAlertDismissal.Enabled,
                "disabled" => CodeSecurityConfigurationSecretScanningDelegatedAlertDismissal.Disabled,
                "not_set" => CodeSecurityConfigurationSecretScanningDelegatedAlertDismissal.NotSet,
                _ => null,
            };
        }
    }
}