#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete project item for user<br/>
        /// Delete a specific item from a user-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="username"></param>
        /// <param name="itemId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ProjectsDeleteItemForUserAsync(
            int projectNumber,
            string username,
            int itemId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}