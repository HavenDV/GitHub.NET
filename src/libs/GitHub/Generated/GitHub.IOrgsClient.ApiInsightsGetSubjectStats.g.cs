#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get subject stats<br/>
        /// Get API request statistics for all subjects within an organization within a specified time frame. Subjects can be users or GitHub Apps.
        /// </summary>
        /// <param name="org"></param>
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
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.ApiInsightsSubjectStat>> ApiInsightsGetSubjectStatsAsync(
            string org,
            string minTimestamp,
            string? maxTimestamp = default,
            int? page = default,
            int? perPage = default,
            global::GitHub.ApiInsightsGetSubjectStatsDirection? direction = default,
            global::System.Collections.Generic.IList<global::GitHub.ApiInsightsGetSubjectStatsSortItem>? sort = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}