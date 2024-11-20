#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get user stats<br/>
        /// Get API usage statistics within an organization for a user broken down by the type of access.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="userId"></param>
        /// <param name="minTimestamp"></param>
        /// <param name="maxTimestamp"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="sort"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.ApiInsightsUserStat>> ApiInsightsGetUserStatsAsync(
            string org,
            string userId,
            string minTimestamp,
            string? maxTimestamp = default,
            int? page = default,
            int? perPage = default,
            global::GitHub.ApiInsightsGetUserStatsDirection? direction = default,
            global::System.Collections.Generic.IList<global::GitHub.ApiInsightsGetUserStatsSortItem>? sort = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}