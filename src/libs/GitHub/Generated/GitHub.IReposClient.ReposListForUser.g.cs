#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List repositories for a user<br/>
        /// Lists public repositories for the specified user.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="type">
        /// Default Value: owner
        /// </param>
        /// <param name="sort">
        /// Default Value: full_name
        /// </param>
        /// <param name="direction"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.MinimalRepository>> ReposListForUserAsync(
            string username,
            global::GitHub.ReposListForUserType? type = global::GitHub.ReposListForUserType.Owner,
            global::GitHub.ReposListForUserSort? sort = global::GitHub.ReposListForUserSort.FullName,
            global::GitHub.ReposListForUserDirection? direction = default,
            int? perPage = 30,
            int? page = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}