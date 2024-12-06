
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Whether to use labeled runners or standard GitHub runners.
    /// </summary>
    public enum CodeScanningDefaultSetupOptionsRunnerType
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
    public static class CodeScanningDefaultSetupOptionsRunnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningDefaultSetupOptionsRunnerType value)
        {
            return value switch
            {
                CodeScanningDefaultSetupOptionsRunnerType.Standard => "standard",
                CodeScanningDefaultSetupOptionsRunnerType.Labeled => "labeled",
                CodeScanningDefaultSetupOptionsRunnerType.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningDefaultSetupOptionsRunnerType? ToEnum(string value)
        {
            return value switch
            {
                "standard" => CodeScanningDefaultSetupOptionsRunnerType.Standard,
                "labeled" => CodeScanningDefaultSetupOptionsRunnerType.Labeled,
                "not_set" => CodeScanningDefaultSetupOptionsRunnerType.NotSet,
                _ => null,
            };
        }
    }
}