#nullable enable

namespace GitHub
{
    public partial interface IReactionsClient
    {
        /// <summary>
        /// List reactions for an issue comment<br/>
        /// List the reactions to an [issue comment](https://docs.github.com/rest/issues/comments#get-an-issue-comment).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commentId"></param>
        /// <param name="content"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Reaction>> ReactionsListForIssueCommentAsync(
            string owner,
            string repo,
            long commentId,
            global::GitHub.ReactionsListForIssueCommentContent? content = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}