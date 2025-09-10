#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Add item to user owned project<br/>
        /// Add an issue or pull request item to the specified user owned project.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ProjectsV2ItemSimple> ProjectsAddItemForUserAsync(
            string userId,
            int projectNumber,
            global::GitHub.ProjectsAddItemForUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add item to user owned project<br/>
        /// Add an issue or pull request item to the specified user owned project.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="projectNumber"></param>
        /// <param name="type">
        /// The type of item to add to the project. Must be either Issue or PullRequest.
        /// </param>
        /// <param name="id">
        /// The numeric ID of the issue or pull request to add to the project.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ProjectsV2ItemSimple> ProjectsAddItemForUserAsync(
            string userId,
            int projectNumber,
            global::GitHub.ProjectsAddItemForUserRequestType type,
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}