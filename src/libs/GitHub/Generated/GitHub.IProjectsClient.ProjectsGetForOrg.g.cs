#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get project for organization<br/>
        /// Get a specific organization-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ProjectsV2> ProjectsGetForOrgAsync(
            int projectNumber,
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}