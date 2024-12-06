#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get route stats by actor<br/>
        /// Get API request count statistics for an actor broken down by route within a specified time frame.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="actorType"></param>
        /// <param name="actorId"></param>
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
        /// <param name="apiRouteSubstring"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.ApiInsightsRouteStat>> ApiInsightsGetRouteStatsByActorAsync(
            string org,
            global::GitHub.ApiInsightsGetRouteStatsByActorActorType actorType,
            int actorId,
            string minTimestamp,
            string? maxTimestamp = default,
            int? page = default,
            int? perPage = default,
            global::GitHub.ApiInsightsGetRouteStatsByActorDirection? direction = default,
            global::System.Collections.Generic.IList<global::GitHub.ApiInsightsGetRouteStatsByActorSortItem>? sort = default,
            string? apiRouteSubstring = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}