#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update project item for organization<br/>
        /// Update a specific item in an organization-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="org"></param>
        /// <param name="itemId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ProjectsV2ItemWithContent> ProjectsUpdateItemForOrgAsync(
            int projectNumber,
            string org,
            int itemId,
            global::GitHub.ProjectsUpdateItemForOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update project item for organization<br/>
        /// Update a specific item in an organization-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="org"></param>
        /// <param name="itemId"></param>
        /// <param name="fields">
        /// A list of field updates to apply.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ProjectsV2ItemWithContent> ProjectsUpdateItemForOrgAsync(
            int projectNumber,
            string org,
            int itemId,
            global::System.Collections.Generic.IList<global::GitHub.ProjectsUpdateItemForOrgRequestField> fields,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}