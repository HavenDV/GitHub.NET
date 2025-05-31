
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Threat model to be used for code scanning analysis. Use `remote` to analyze only network sources and `remote_and_local` to include local sources like filesystem access, command-line arguments, database reads, environment variable and standard input.
    /// </summary>
    public enum CodeScanningDefaultSetupThreatModel
    {
        /// <summary>
        /// 
        /// </summary>
        Remote,
        /// <summary>
        /// 
        /// </summary>
        RemoteAndLocal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningDefaultSetupThreatModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningDefaultSetupThreatModel value)
        {
            return value switch
            {
                CodeScanningDefaultSetupThreatModel.Remote => "remote",
                CodeScanningDefaultSetupThreatModel.RemoteAndLocal => "remote_and_local",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningDefaultSetupThreatModel? ToEnum(string value)
        {
            return value switch
            {
                "remote" => CodeScanningDefaultSetupThreatModel.Remote,
                "remote_and_local" => CodeScanningDefaultSetupThreatModel.RemoteAndLocal,
                _ => null,
            };
        }
    }
}