#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create a project card
        /// </summary>
        /// <param name="columnId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ProjectCard> ProjectsCreateCardAsync(
            int columnId,
            global::GitHub.OneOf<global::GitHub.ProjectsCreateCardRequestVariant1, global::GitHub.ProjectsCreateCardRequestVariant2> request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a project card
        /// </summary>
        /// <param name="columnId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ProjectCard> ProjectsCreateCardAsync(
            int columnId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}