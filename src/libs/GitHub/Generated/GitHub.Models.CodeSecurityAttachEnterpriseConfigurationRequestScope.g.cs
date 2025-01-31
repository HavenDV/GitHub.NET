
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The type of repositories to attach the configuration to.
    /// </summary>
    public enum CodeSecurityAttachEnterpriseConfigurationRequestScope
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        AllWithoutConfigurations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityAttachEnterpriseConfigurationRequestScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityAttachEnterpriseConfigurationRequestScope value)
        {
            return value switch
            {
                CodeSecurityAttachEnterpriseConfigurationRequestScope.All => "all",
                CodeSecurityAttachEnterpriseConfigurationRequestScope.AllWithoutConfigurations => "all_without_configurations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityAttachEnterpriseConfigurationRequestScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => CodeSecurityAttachEnterpriseConfigurationRequestScope.All,
                "all_without_configurations" => CodeSecurityAttachEnterpriseConfigurationRequestScope.AllWithoutConfigurations,
                _ => null,
            };
        }
    }
}