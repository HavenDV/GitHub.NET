
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The type of the reviewer
    /// </summary>
    public enum RepositoryRuleParamsReviewerType
    {
        /// <summary>
        /// 
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRuleParamsReviewerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRuleParamsReviewerType value)
        {
            return value switch
            {
                RepositoryRuleParamsReviewerType.Team => "Team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRuleParamsReviewerType? ToEnum(string value)
        {
            return value switch
            {
                "Team" => RepositoryRuleParamsReviewerType.Team,
                _ => null,
            };
        }
    }
}