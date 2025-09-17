#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List items for a user owned project<br/>
        /// List all items for a specific user-owned project accessible by the authenticated user.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="username"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="q"></param>
        /// <param name="fields">
        /// Example: fields[]=123,fields[]=456,fields[]=789
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.ProjectsV2ItemWithContent>> ProjectsListItemsForUserAsync(
            int projectNumber,
            string username,
            string? before = default,
            string? after = default,
            int? perPage = default,
            string? q = default,
            global::System.Collections.Generic.IList<string>? fields = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}