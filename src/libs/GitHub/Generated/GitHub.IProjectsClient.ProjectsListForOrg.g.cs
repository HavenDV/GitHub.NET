#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List projects for organization<br/>
        /// List all projects owned by a specific organization accessible by the authenticated user.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="q"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.ProjectsV2>> ProjectsListForOrgAsync(
            string org,
            string? q = default,
            string? before = default,
            string? after = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}