#nullable enable

namespace GitHub
{
    public partial interface IReactionsClient
    {
        /// <summary>
        /// List reactions for a commit comment<br/>
        /// List the reactions to a [commit comment](https://docs.github.com/rest/commits/comments#get-a-commit-comment).
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
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Reaction>> ReactionsListForCommitCommentAsync(
            string owner,
            string repo,
            long commentId,
            global::GitHub.ReactionsListForCommitCommentContent? content = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}