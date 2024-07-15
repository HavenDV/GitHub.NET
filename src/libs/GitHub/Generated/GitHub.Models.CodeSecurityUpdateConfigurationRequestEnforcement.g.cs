
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The status of enforcement
    /// </summary>
    public enum CodeSecurityUpdateConfigurationRequestEnforcement
    {
        /// <summary>
        /// 
        /// </summary>
        Enforced,
        /// <summary>
        /// 
        /// </summary>
        Unenforced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityUpdateConfigurationRequestEnforcementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestEnforcement value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestEnforcement.Enforced => "enforced",
                CodeSecurityUpdateConfigurationRequestEnforcement.Unenforced => "unenforced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestEnforcement? ToEnum(string value)
        {
            return value switch
            {
                "enforced" => CodeSecurityUpdateConfigurationRequestEnforcement.Enforced,
                "unenforced" => CodeSecurityUpdateConfigurationRequestEnforcement.Unenforced,
                _ => null,
            };
        }
    }
}