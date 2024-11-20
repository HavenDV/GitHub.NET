#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get summary stats<br/>
        /// Get overall statistics of API requests made within an organization by all users and apps within a specified time frame.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="minTimestamp"></param>
        /// <param name="maxTimestamp"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ApiInsightsSummaryStats> ApiInsightsGetSummaryStatsAsync(
            string org,
            string minTimestamp,
            string? maxTimestamp = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}