
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Runner type to be used.
    /// </summary>
    public enum CodeScanningDefaultSetupUpdateRunnerType
    {
        /// <summary>
        /// 
        /// </summary>
        Standard,
        /// <summary>
        /// 
        /// </summary>
        Labeled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningDefaultSetupUpdateRunnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningDefaultSetupUpdateRunnerType value)
        {
            return value switch
            {
                CodeScanningDefaultSetupUpdateRunnerType.Standard => "standard",
                CodeScanningDefaultSetupUpdateRunnerType.Labeled => "labeled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningDefaultSetupUpdateRunnerType? ToEnum(string value)
        {
            return value switch
            {
                "standard" => CodeScanningDefaultSetupUpdateRunnerType.Standard,
                "labeled" => CodeScanningDefaultSetupUpdateRunnerType.Labeled,
                _ => null,
            };
        }
    }
}