
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The status of an autofix.
    /// </summary>
    public enum CodeScanningAutofixStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Outdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeScanningAutofixStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeScanningAutofixStatus value)
        {
            return value switch
            {
                CodeScanningAutofixStatus.Pending => "pending",
                CodeScanningAutofixStatus.Error => "error",
                CodeScanningAutofixStatus.Success => "success",
                CodeScanningAutofixStatus.Outdated => "outdated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeScanningAutofixStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => CodeScanningAutofixStatus.Pending,
                "error" => CodeScanningAutofixStatus.Error,
                "success" => CodeScanningAutofixStatus.Success,
                "outdated" => CodeScanningAutofixStatus.Outdated,
                _ => null,
            };
        }
    }
}