#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Create an organization repository ruleset<br/>
        /// Create a repository ruleset for an organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.RepositoryRuleset> ReposCreateOrgRulesetAsync(
            string org,
            global::GitHub.ReposCreateOrgRulesetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an organization repository ruleset<br/>
        /// Create a repository ruleset for an organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// The name of the ruleset.
        /// </param>
        /// <param name="target">
        /// The target of the ruleset<br/>
        /// Default Value: branch
        /// </param>
        /// <param name="enforcement">
        /// The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).
        /// </param>
        /// <param name="bypassActors">
        /// The actors that can bypass the rules in this ruleset
        /// </param>
        /// <param name="conditions">
        /// Conditions for an organization ruleset.<br/>
        /// The branch and tag rulesets conditions object should contain both `repository_name` and `ref_name` properties, or both `repository_id` and `ref_name` properties, or both `repository_property` and `ref_name` properties.<br/>
        /// The push rulesets conditions object does not require the `ref_name` property.
        /// </param>
        /// <param name="rules">
        /// An array of rules within the ruleset.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.RepositoryRuleset> ReposCreateOrgRulesetAsync(
            string org,
            string name,
            global::GitHub.RepositoryRuleEnforcement enforcement,
            global::GitHub.ReposCreateOrgRulesetRequestTarget? target = default,
            global::System.Collections.Generic.IList<global::GitHub.RepositoryRulesetBypassActor>? bypassActors = default,
            global::GitHub.OrgRulesetConditions? conditions = default,
            global::System.Collections.Generic.IList<global::GitHub.RepositoryRule>? rules = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}