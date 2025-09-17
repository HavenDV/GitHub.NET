
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepositoryRuleCopilotCodeReviewType
    {
        /// <summary>
        /// 
        /// </summary>
        CopilotCodeReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleCopilotCodeReviewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleCopilotCodeReviewType value)
        {
            return value switch
            {
                RepositoryRuleCopilotCodeReviewType.CopilotCodeReview => "copilot_code_review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleCopilotCodeReviewType? ToEnum(string value)
        {
            return value switch
            {
                "copilot_code_review" => RepositoryRuleCopilotCodeReviewType.CopilotCodeReview,
                _ => null,
            };
        }
    }
}