#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get a project column<br/>
        /// Gets information about a project column.
        /// </summary>
        /// <param name="columnId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ProjectColumn> ProjectsGetColumnAsync(
            int columnId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}