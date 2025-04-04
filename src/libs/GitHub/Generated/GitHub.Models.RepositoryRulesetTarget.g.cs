
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The target of the ruleset
    /// </summary>
    public enum RepositoryRulesetTarget
    {
        /// <summary>
        /// 
        /// </summary>
        Branch,
        /// <summary>
        /// 
        /// </summary>
        Tag,
        /// <summary>
        /// 
        /// </summary>
        Push,
        /// <summary>
        /// 
        /// </summary>
        Repository,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRulesetTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRulesetTarget value)
        {
            return value switch
            {
                RepositoryRulesetTarget.Branch => "branch",
                RepositoryRulesetTarget.Tag => "tag",
                RepositoryRulesetTarget.Push => "push",
                RepositoryRulesetTarget.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRulesetTarget? ToEnum(string value)
        {
            return value switch
            {
                "branch" => RepositoryRulesetTarget.Branch,
                "tag" => RepositoryRulesetTarget.Tag,
                "push" => RepositoryRulesetTarget.Push,
                "repository" => RepositoryRulesetTarget.Repository,
                _ => null,
            };
        }
    }
}