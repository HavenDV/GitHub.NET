#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get project for user<br/>
        /// Get a specific user-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ProjectsV2> ProjectsGetForUserAsync(
            int projectNumber,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}