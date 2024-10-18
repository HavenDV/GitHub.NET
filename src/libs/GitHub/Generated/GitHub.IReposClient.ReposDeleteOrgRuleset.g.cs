#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Delete an organization repository ruleset<br/>
        /// Delete a ruleset for an organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="rulesetId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.BasicError> ReposDeleteOrgRulesetAsync(
            string org,
            int rulesetId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}