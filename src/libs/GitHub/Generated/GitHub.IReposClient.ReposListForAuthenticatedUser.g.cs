#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List repositories for the authenticated user<br/>
        /// Lists repositories that the authenticated user has explicit permission (`:read`, `:write`, or `:admin`) to access.<br/>
        /// The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.
        /// </summary>
        /// <param name="visibility">
        /// Default Value: all
        /// </param>
        /// <param name="affiliation">
        /// Default Value: owner,collaborator,organization_member
        /// </param>
        /// <param name="type">
        /// Default Value: all
        /// </param>
        /// <param name="sort">
        /// Default Value: full_name
        /// </param>
        /// <param name="direction"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="since"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Repository>> ReposListForAuthenticatedUserAsync(
            global::GitHub.ReposListForAuthenticatedUserVisibility? visibility = default,
            string? affiliation = default,
            global::GitHub.ReposListForAuthenticatedUserType? type = default,
            global::GitHub.ReposListForAuthenticatedUserSort? sort = default,
            global::GitHub.ReposListForAuthenticatedUserDirection? direction = default,
            int? perPage = default,
            int? page = default,
            global::System.DateTime? since = default,
            global::System.DateTime? before = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}