#nullable enable

namespace GitHub
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// List repositories starred by a user<br/>
        /// Lists repositories a user has starred.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.star+json`**: Includes a timestamp of when the star was created.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.AnyOf<global::System.Collections.Generic.IList<global::GitHub.StarredRepository>, global::System.Collections.Generic.IList<global::GitHub.Repository>>> ActivityListReposStarredByUserAsync(
            string username,
            global::GitHub.ActivityListReposStarredByUserSort? sort = global::GitHub.ActivityListReposStarredByUserSort.Created,
            global::GitHub.ActivityListReposStarredByUserDirection? direction = global::GitHub.ActivityListReposStarredByUserDirection.Desc,
            int? perPage = 30,
            int? page = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}