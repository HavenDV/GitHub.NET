#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete a project column<br/>
        /// Deletes a project column.
        /// </summary>
        /// <param name="columnId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ProjectsDeleteColumnAsync(
            int columnId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}