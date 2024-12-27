
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Runner type to be used.
    /// </summary>
    public enum CodeScanningDefaultSetupRunnerType
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
    public static class CodeScanningDefaultSetupRunnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningDefaultSetupRunnerType value)
        {
            return value switch
            {
                CodeScanningDefaultSetupRunnerType.Standard => "standard",
                CodeScanningDefaultSetupRunnerType.Labeled => "labeled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningDefaultSetupRunnerType? ToEnum(string value)
        {
            return value switch
            {
                "standard" => CodeScanningDefaultSetupRunnerType.Standard,
                "labeled" => CodeScanningDefaultSetupRunnerType.Labeled,
                _ => null,
            };
        }
    }
}