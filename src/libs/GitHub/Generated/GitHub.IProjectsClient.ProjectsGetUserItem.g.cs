#nullable enable

namespace GitHub
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get an item for a user owned project<br/>
        /// Get a specific item from a user-owned project.
        /// </summary>
        /// <param name="projectNumber"></param>
        /// <param name="username"></param>
        /// <param name="itemId"></param>
        /// <param name="fields">
        /// Example: fields[]=123,fields[]=456,fields[]=789
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ProjectsV2ItemWithContent> ProjectsGetUserItemAsync(
            int projectNumber,
            string username,
            int itemId,
            global::System.Collections.Generic.IList<string>? fields = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}