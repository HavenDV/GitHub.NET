#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List project cards<br/>
        /// Lists the project cards in a project.
        /// </summary>
        /// <param name="columnId"></param>
        /// <param name="archivedState">
        /// Default Value: not_archived
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.ProjectCard>> ProjectsListCardsAsync(
            int columnId,
            global::GitHub.ProjectsListCardsArchivedState? archivedState = global::GitHub.ProjectsListCardsArchivedState.NotArchived,
            int? perPage = 30,
            int? page = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}