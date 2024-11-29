#nullable enable

namespace GitHub
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Reprioritize sub-issue<br/>
        /// You can use the REST API to reprioritize a sub-issue to a different position in the parent list.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.Issue> IssuesReprioritizeSubIssueAsync(
            string owner,
            string repo,
            int issueNumber,
            global::GitHub.IssuesReprioritizeSubIssueRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Reprioritize sub-issue<br/>
        /// You can use the REST API to reprioritize a sub-issue to a different position in the parent list.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="subIssueId">
        /// The id of the sub-issue to reprioritize
        /// </param>
        /// <param name="afterId">
        /// The id of the sub-issue to be prioritized after (either positional argument after OR before should be specified).
        /// </param>
        /// <param name="beforeId">
        /// The id of the sub-issue to be prioritized before (either positional argument after OR before should be specified).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.Issue> IssuesReprioritizeSubIssueAsync(
            string owner,
            string repo,
            int issueNumber,
            int subIssueId,
            int? afterId = default,
            int? beforeId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}