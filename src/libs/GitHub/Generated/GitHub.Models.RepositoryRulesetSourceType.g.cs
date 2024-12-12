
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The type of the source of the ruleset
    /// </summary>
    public enum RepositoryRulesetSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Repository,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RepositoryRulesetSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RepositoryRulesetSourceType value)
        {
            return value switch
            {
                RepositoryRulesetSourceType.Repository => "Repository",
                RepositoryRulesetSourceType.Organization => "Organization",
                RepositoryRulesetSourceType.Enterprise => "Enterprise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RepositoryRulesetSourceType? ToEnum(string value)
        {
            return value switch
            {
                "Repository" => RepositoryRulesetSourceType.Repository,
                "Organization" => RepositoryRulesetSourceType.Organization,
                "Enterprise" => RepositoryRulesetSourceType.Enterprise,
                _ => null,
            };
        }
    }
}