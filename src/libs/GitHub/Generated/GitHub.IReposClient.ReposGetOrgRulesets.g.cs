#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get all organization repository rulesets<br/>
        /// Get all the repository rulesets for an organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="targets">
        /// Example: branch,tag,push
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.RepositoryRuleset>> ReposGetOrgRulesetsAsync(
            string org,
            int? perPage = 30,
            int? page = 1,
            string? targets = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}