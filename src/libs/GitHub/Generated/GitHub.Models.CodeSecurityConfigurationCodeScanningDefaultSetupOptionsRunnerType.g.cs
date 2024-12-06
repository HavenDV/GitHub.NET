
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Whether to use labeled runners or standard GitHub runners.
    /// </summary>
    public enum CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerType
    {
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        Labeled,
        /// <summary>
        /// 
        /// </summary>
        NotSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerType value)
        {
            return value switch
            {
                CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerType.Standard => "standard",
                CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerType.Labeled => "labeled",
                CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerType.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerType? ToEnum(string value)
        {
            return value switch
            {
                "standard" => CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerType.Standard,
                "labeled" => CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerType.Labeled,
                "not_set" => CodeSecurityConfigurationCodeScanningDefaultSetupOptionsRunnerType.NotSet,
                _ => null,
            };
        }
    }
}