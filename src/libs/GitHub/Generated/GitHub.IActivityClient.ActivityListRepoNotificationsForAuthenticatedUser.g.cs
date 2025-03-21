#nullable enable

namespace GitHub
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// List repository notifications for the authenticated user<br/>
        /// Lists all notifications for the current user in the specified repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="all">
        /// Default Value: false
        /// </param>
        /// <param name="participating">
        /// Default Value: false
        /// </param>
        /// <param name="since"></param>
        /// <param name="before"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Thread>> ActivityListRepoNotificationsForAuthenticatedUserAsync(
            string owner,
            string repo,
            bool? all = default,
            bool? participating = default,
            global::System.DateTime? since = default,
            global::System.DateTime? before = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}