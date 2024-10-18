#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete a project card<br/>
        /// Deletes a project card
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ProjectsDeleteCardResponse> ProjectsDeleteCardAsync(
            int cardId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}