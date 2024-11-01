#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get time stats<br/>
        /// Get the number of API requests and rate-limited requests made within an organization over a specified time period.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="minTimestamp"></param>
        /// <param name="maxTimestamp"></param>
        /// <param name="timestampIncrement"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.ApiInsightsTimeStat>> ApiInsightsGetTimeStatsAsync(
            string org,
            string minTimestamp,
            string maxTimestamp,
            string timestampIncrement,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}