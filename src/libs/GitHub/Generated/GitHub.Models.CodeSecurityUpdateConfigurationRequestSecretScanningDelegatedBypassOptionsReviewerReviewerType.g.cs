
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The type of the bypass reviewer
    /// </summary>
    public enum CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType
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
    public static class CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType.TEAM => "TEAM",
                CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType.ROLE => "ROLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType? ToEnum(string value)
        {
            return value switch
            {
                "TEAM" => CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType.TEAM,
                "ROLE" => CodeSecurityUpdateConfigurationRequestSecretScanningDelegatedBypassOptionsReviewerReviewerType.ROLE,
                _ => null,
            };
        }
    }
}