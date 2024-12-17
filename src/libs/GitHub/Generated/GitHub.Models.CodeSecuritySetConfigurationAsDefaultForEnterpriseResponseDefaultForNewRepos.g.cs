
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Specifies which types of repository this security configuration is applied to by default.
    /// </summary>
    public enum CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewRepos
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
    public static class CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewReposExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewRepos value)
        {
            return value switch
            {
                CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewRepos.All => "all",
                CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewRepos.None => "none",
                CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewRepos.PrivateAndInternal => "private_and_internal",
                CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewRepos.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewRepos? ToEnum(string value)
        {
            return value switch
            {
                "all" => CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewRepos.All,
                "none" => CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewRepos.None,
                "private_and_internal" => CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewRepos.PrivateAndInternal,
                "public" => CodeSecuritySetConfigurationAsDefaultForEnterpriseResponseDefaultForNewRepos.Public,
                _ => null,
            };
        }
    }
}