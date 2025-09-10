#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update project item for user<br/>
        /// Update a specific item in a user-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="userId"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ProjectsV2ItemWithContent> ProjectsUpdateItemForUserAsync(
            int projectNumber,
            string userId,
            int itemId,
            global::GitHub.ProjectsUpdateItemForUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update project item for user<br/>
        /// Update a specific item in a user-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="userId"></param>
        /// <param name="itemId"></param>
        /// <param name="fields">
        /// A list of field updates to apply.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ProjectsV2ItemWithContent> ProjectsUpdateItemForUserAsync(
            int projectNumber,
            string userId,
            int itemId,
            global::System.Collections.Generic.IList<global::GitHub.ProjectsUpdateItemForUserRequestField> fields,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}