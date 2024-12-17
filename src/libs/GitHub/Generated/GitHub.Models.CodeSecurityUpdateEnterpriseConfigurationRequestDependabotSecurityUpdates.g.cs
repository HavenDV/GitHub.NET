
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of Dependabot security updates
    /// </summary>
    public enum CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates
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
    public static class CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdatesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates value)
        {
            return value switch
            {
                CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates.Enabled => "enabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates.Disabled => "disabled",
                CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates.Enabled,
                "disabled" => CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates.Disabled,
                "not_set" => CodeSecurityUpdateEnterpriseConfigurationRequestDependabotSecurityUpdates.NotSet,
                _ => null,
            };
        }
    }
}