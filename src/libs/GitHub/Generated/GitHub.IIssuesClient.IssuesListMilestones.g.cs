#nullable enable

namespace GitHub
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// List milestones<br/>
        /// Lists milestones for a repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="state">
        /// Default Value: open
        /// </param>
        /// <param name="sort">
        /// Default Value: due_on
        /// </param>
        /// <param name="direction">
        /// Default Value: asc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Milestone>> IssuesListMilestonesAsync(
            string owner,
            string repo,
            global::GitHub.IssuesListMilestonesState? state = global::GitHub.IssuesListMilestonesState.Open,
            global::GitHub.IssuesListMilestonesSort? sort = global::GitHub.IssuesListMilestonesSort.DueOn,
            global::GitHub.IssuesListMilestonesDirection? direction = global::GitHub.IssuesListMilestonesDirection.Asc,
            int? perPage = 30,
            int? page = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}