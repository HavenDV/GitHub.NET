
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of Dependabot alerts<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationForEnterpriseRequestDependabotAlerts
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
    public static class CodeSecurityCreateConfigurationForEnterpriseRequestDependabotAlertsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationForEnterpriseRequestDependabotAlerts value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationForEnterpriseRequestDependabotAlerts.Enabled => "enabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestDependabotAlerts.Disabled => "disabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestDependabotAlerts.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationForEnterpriseRequestDependabotAlerts? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationForEnterpriseRequestDependabotAlerts.Enabled,
                "disabled" => CodeSecurityCreateConfigurationForEnterpriseRequestDependabotAlerts.Disabled,
                "not_set" => CodeSecurityCreateConfigurationForEnterpriseRequestDependabotAlerts.NotSet,
                _ => null,
            };
        }
    }
}