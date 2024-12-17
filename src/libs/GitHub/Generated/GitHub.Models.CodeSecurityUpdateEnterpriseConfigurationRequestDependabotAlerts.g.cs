
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of Dependabot alerts
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts
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
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlertsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts.Enabled => "enabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts.Disabled => "disabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts.Enabled,
                "disabled" => CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts.Disabled,
                "not_set" => CodeSecurityUpdateEnterpriseConfigurationRequestDependabotAlerts.NotSet,
                _ => null,
            };
        }
    }
}