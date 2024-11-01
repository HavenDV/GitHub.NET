#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get summary stats by user<br/>
        /// Get overall statistics of API requests within the organization for a user.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="userId"></param>
        /// <param name="minTimestamp"></param>
        /// <param name="maxTimestamp"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ApiInsightsSummaryStats> ApiInsightsGetSummaryStatsByUserAsync(
            string org,
            string userId,
            string minTimestamp,
            string maxTimestamp,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}