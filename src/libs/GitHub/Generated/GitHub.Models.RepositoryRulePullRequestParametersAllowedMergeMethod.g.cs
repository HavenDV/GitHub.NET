
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public enum RepositoryRulePullRequestParametersAllowedMergeMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Merge,
        /// <summary>
        /// 
        /// </summary>
        Squash,
        /// <summary>
        /// 
        /// </summary>
        Rebase,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRulePullRequestParametersAllowedMergeMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRulePullRequestParametersAllowedMergeMethod value)
        {
            return value switch
            {
                RepositoryRulePullRequestParametersAllowedMergeMethod.Merge => "merge",
                RepositoryRulePullRequestParametersAllowedMergeMethod.Squash => "squash",
                RepositoryRulePullRequestParametersAllowedMergeMethod.Rebase => "rebase",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRulePullRequestParametersAllowedMergeMethod? ToEnum(string value)
        {
            return value switch
            {
                "merge" => RepositoryRulePullRequestParametersAllowedMergeMethod.Merge,
                "squash" => RepositoryRulePullRequestParametersAllowedMergeMethod.Squash,
                "rebase" => RepositoryRulePullRequestParametersAllowedMergeMethod.Rebase,
                _ => null,
            };
        }
    }
}