#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create a project column<br/>
        /// Creates a new project column.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ProjectColumn> ProjectsCreateColumnAsync(
            int projectId,
            global::GitHub.ProjectsCreateColumnRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a project column<br/>
        /// Creates a new project column.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="name">
        /// Name of the project column<br/>
        /// Example: Remaining tasks
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ProjectColumn> ProjectsCreateColumnAsync(
            int projectId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}