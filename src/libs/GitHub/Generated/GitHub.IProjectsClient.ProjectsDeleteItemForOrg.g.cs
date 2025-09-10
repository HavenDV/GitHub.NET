#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete project item for organization<br/>
        /// Delete a specific item from an organization-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="org"></param>
        /// <param name="itemId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ProjectsDeleteItemForOrgAsync(
            int projectNumber,
            string org,
            int itemId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}