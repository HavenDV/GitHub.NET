#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List project columns<br/>
        /// Lists the project columns in a project.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.ProjectColumn>> ProjectsListColumnsAsync(
            int projectId,
            int? perPage = 30,
            int? page = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}