
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The type of the bypass reviewer
    /// </summary>
    public enum CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerReviewerType
    {
        /// <summary>
        /// 
        /// </summary>
        TEAM,
        /// <summary>
        /// 
        /// </summary>
        ROLE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerReviewerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerReviewerType value)
        {
            return value switch
            {
                CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerReviewerType.TEAM => "TEAM",
                CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerReviewerType.ROLE => "ROLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerReviewerType? ToEnum(string value)
        {
            return value switch
            {
                "TEAM" => CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerReviewerType.TEAM,
                "ROLE" => CodeSecurityConfigurationSecretScanningDelegatedBypassOptionsReviewerReviewerType.ROLE,
                _ => null,
            };
        }
    }
}