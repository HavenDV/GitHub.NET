#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get project field for user<br/>
        /// Get a specific field for a user-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="fieldId"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ProjectsV2Field> ProjectsGetFieldForUserAsync(
            int projectNumber,
            int fieldId,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}