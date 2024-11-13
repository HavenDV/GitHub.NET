#nullable enable

namespace GitHub
{
    public partial interface IGistsClient
    {
        /// <summary>
        /// List gists for a user<br/>
        /// Lists public gists for the specified user:
        /// </summary>
        /// <param name="username"></param>
        /// <param name="since"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.BaseGist>> GistsListForUserAsync(
            string username,
            global::System.DateTime? since = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}