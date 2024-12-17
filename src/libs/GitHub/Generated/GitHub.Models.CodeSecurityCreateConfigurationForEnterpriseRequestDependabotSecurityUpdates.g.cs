
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of Dependabot security updates<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationForEnterpriseRequestDependabotSecurityUpdates
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
    public static class CodeSecurityCreateConfigurationForEnterpriseRequestDependabotSecurityUpdatesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationForEnterpriseRequestDependabotSecurityUpdates value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationForEnterpriseRequestDependabotSecurityUpdates.Enabled => "enabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestDependabotSecurityUpdates.Disabled => "disabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestDependabotSecurityUpdates.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationForEnterpriseRequestDependabotSecurityUpdates? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationForEnterpriseRequestDependabotSecurityUpdates.Enabled,
                "disabled" => CodeSecurityCreateConfigurationForEnterpriseRequestDependabotSecurityUpdates.Disabled,
                "not_set" => CodeSecurityCreateConfigurationForEnterpriseRequestDependabotSecurityUpdates.NotSet,
                _ => null,
            };
        }
    }
}