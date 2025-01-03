#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get a project<br/>
        /// Gets a project by its `id`. Returns a `404 Not Found` status if projects are disabled. If you do not have sufficient privileges to perform this action, a `401 Unauthorized` or `410 Gone` status is returned.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.Project> ProjectsGetAsync(
            int projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}