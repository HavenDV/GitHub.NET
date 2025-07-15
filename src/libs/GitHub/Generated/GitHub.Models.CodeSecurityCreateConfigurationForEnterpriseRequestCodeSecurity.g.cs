
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The enablement status of GitHub Code Security features.
    /// </summary>
    public enum CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity
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
    public static class CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity.Enabled => "enabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity.Disabled => "disabled",
                CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity.Enabled,
                "disabled" => CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity.Disabled,
                "not_set" => CodeSecurityCreateConfigurationForEnterpriseRequestCodeSecurity.NotSet,
                _ => null,
            };
        }
    }
}