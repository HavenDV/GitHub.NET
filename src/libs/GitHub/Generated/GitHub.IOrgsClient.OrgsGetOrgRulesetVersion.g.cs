#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get organization ruleset version<br/>
        /// Get a version of an organization ruleset.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="rulesetId"></param>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.RulesetVersionWithState> OrgsGetOrgRulesetVersionAsync(
            string org,
            int rulesetId,
            int versionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}