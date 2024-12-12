
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The target of the ruleset<br/>
    /// Default Value: branch
    /// </summary>
    public enum ReposCreateOrgRulesetRequestTarget
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
    public static class ReposCreateOrgRulesetRequestTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposCreateOrgRulesetRequestTarget value)
        {
            return value switch
            {
                ReposCreateOrgRulesetRequestTarget.Branch => "branch",
                ReposCreateOrgRulesetRequestTarget.Tag => "tag",
                ReposCreateOrgRulesetRequestTarget.Push => "push",
                ReposCreateOrgRulesetRequestTarget.Repository => "repository",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposCreateOrgRulesetRequestTarget? ToEnum(string value)
        {
            return value switch
            {
                "branch" => ReposCreateOrgRulesetRequestTarget.Branch,
                "tag" => ReposCreateOrgRulesetRequestTarget.Tag,
                "push" => ReposCreateOrgRulesetRequestTarget.Push,
                "repository" => ReposCreateOrgRulesetRequestTarget.Repository,
                _ => null,
            };
        }
    }
}