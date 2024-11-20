#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get time stats by user<br/>
        /// Get the number of API requests and rate-limited requests made within an organization by a specific user over a specified time period.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="userId"></param>
        /// <param name="minTimestamp"></param>
        /// <param name="maxTimestamp"></param>
        /// <param name="timestampIncrement"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.ApiInsightsTimeStat>> ApiInsightsGetTimeStatsByUserAsync(
            string org,
            string userId,
            string minTimestamp,
            string timestampIncrement,
            string? maxTimestamp = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}