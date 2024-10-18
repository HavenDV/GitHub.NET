#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get a project card<br/>
        /// Gets information about a project card.
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ProjectCard> ProjectsGetCardAsync(
            int cardId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}