#nullable enable

namespace GitHub
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// List labels for issues in a milestone<br/>
        /// Lists labels for issues in a milestone.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="milestoneNumber"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Label>> IssuesListLabelsForMilestoneAsync(
            string owner,
            string repo,
            int milestoneNumber,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}