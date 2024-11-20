#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get summary stats by actor<br/>
        /// Get overall statistics of API requests within the organization made by a specific actor. Actors can be GitHub App installations, OAuth apps or other tokens on behalf of a user.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="minTimestamp"></param>
        /// <param name="maxTimestamp"></param>
        /// <param name="actorType"></param>
        /// <param name="actorId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ApiInsightsSummaryStats> ApiInsightsGetSummaryStatsByActorAsync(
            string org,
            string minTimestamp,
            global::GitHub.ApiInsightsGetSummaryStatsByActorActorType actorType,
            int actorId,
            string? maxTimestamp = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}