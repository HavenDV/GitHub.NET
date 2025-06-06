#nullable enable

namespace GitHub
{
    public partial interface ISecurityAdvisoriesClient
    {
        /// <summary>
        /// List repository security advisories for an organization<br/>
        /// Lists repository security advisories for an organization.<br/>
        /// The authenticated user must be an owner or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:write` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="state"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.RepositoryAdvisory>> SecurityAdvisoriesListOrgRepositoryAdvisoriesAsync(
            string org,
            global::GitHub.SecurityAdvisoriesListOrgRepositoryAdvisoriesDirection? direction = default,
            global::GitHub.SecurityAdvisoriesListOrgRepositoryAdvisoriesSort? sort = default,
            string? before = default,
            string? after = default,
            int? perPage = default,
            global::GitHub.SecurityAdvisoriesListOrgRepositoryAdvisoriesState? state = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}