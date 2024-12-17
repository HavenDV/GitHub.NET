
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Specify which types of repository this security configuration should be applied to by default.
    /// </summary>
    public enum CodeSecuritySetConfigurationAsDefaultForEnterpriseRequestDefaultForNewRepos
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        PrivateAndInternal,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecuritySetConfigurationAsDefaultForEnterpriseRequestDefaultForNewReposExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecuritySetConfigurationAsDefaultForEnterpriseRequestDefaultForNewRepos value)
        {
            return value switch
            {
                CodeSecuritySetConfigurationAsDefaultForEnterpriseRequestDefaultForNewRepos.All => "all",
                CodeSecuritySetConfigurationAsDefaultForEnterpriseRequestDefaultForNewRepos.None => "none",
                CodeSecuritySetConfigurationAsDefaultForEnterpriseRequestDefaultForNewRepos.PrivateAndInternal => "private_and_internal",
                CodeSecuritySetConfigurationAsDefaultForEnterpriseRequestDefaultForNewRepos.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecuritySetConfigurationAsDefaultForEnterpriseRequestDefaultForNewRepos? ToEnum(string value)
        {
            return value switch
            {
                "all" => CodeSecuritySetConfigurationAsDefaultForEnterpriseRequestDefaultForNewRepos.All,
                "none" => CodeSecuritySetConfigurationAsDefaultForEnterpriseRequestDefaultForNewRepos.None,
                "private_and_internal" => CodeSecuritySetConfigurationAsDefaultForEnterpriseRequestDefaultForNewRepos.PrivateAndInternal,
                "public" => CodeSecuritySetConfigurationAsDefaultForEnterpriseRequestDefaultForNewRepos.Public,
                _ => null,
            };
        }
    }
}