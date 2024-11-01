#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get time stats by actor<br/>
        /// Get the number of API requests and rate-limited requests made within an organization by a specific actor within a specified time period.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="actorType"></param>
        /// <param name="actorId"></param>
        /// <param name="minTimestamp"></param>
        /// <param name="maxTimestamp"></param>
        /// <param name="timestampIncrement"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.ApiInsightsTimeStat>> ApiInsightsGetTimeStatsByActorAsync(
            string org,
            global::GitHub.ApiInsightsGetTimeStatsByActorActorType actorType,
            int actorId,
            string minTimestamp,
            string maxTimestamp,
            string timestampIncrement,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}