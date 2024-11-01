#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete a project<br/>
        /// Deletes a project board. Returns a `404 Not Found` status if projects are disabled.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ProjectsDeleteResponse> ProjectsDeleteAsync(
            int projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}