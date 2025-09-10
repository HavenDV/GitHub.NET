#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get project field for organization<br/>
        /// Get a specific field for an organization-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="fieldId"></param>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ProjectsV2Field> ProjectsGetFieldForOrgAsync(
            int projectNumber,
            int fieldId,
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}