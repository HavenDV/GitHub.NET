
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The policy that controls when fork PR workflows require approval from a maintainer.
    /// </summary>
    public enum ActionsForkPrContributorApprovalApprovalPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        FirstTimeContributorsNewToGithub,
        /// <summary>
        /// 
        /// </summary>
        FirstTimeContributors,
        /// <summary>
        /// 
        /// </summary>
        AllExternalContributors,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsForkPrContributorApprovalApprovalPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsForkPrContributorApprovalApprovalPolicy value)
        {
            return value switch
            {
                ActionsForkPrContributorApprovalApprovalPolicy.FirstTimeContributorsNewToGithub => "first_time_contributors_new_to_github",
                ActionsForkPrContributorApprovalApprovalPolicy.FirstTimeContributors => "first_time_contributors",
                ActionsForkPrContributorApprovalApprovalPolicy.AllExternalContributors => "all_external_contributors",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsForkPrContributorApprovalApprovalPolicy? ToEnum(string value)
        {
            return value switch
            {
                "first_time_contributors_new_to_github" => ActionsForkPrContributorApprovalApprovalPolicy.FirstTimeContributorsNewToGithub,
                "first_time_contributors" => ActionsForkPrContributorApprovalApprovalPolicy.FirstTimeContributors,
                "all_external_contributors" => ActionsForkPrContributorApprovalApprovalPolicy.AllExternalContributors,
                _ => null,
            };
        }
    }
}