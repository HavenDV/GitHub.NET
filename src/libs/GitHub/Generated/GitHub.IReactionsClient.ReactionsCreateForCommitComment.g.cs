#nullable enable

namespace GitHub
{
    public partial interface IReactionsClient
    {
        /// <summary>
        /// Create reaction for a commit comment<br/>
        /// Create a reaction to a [commit comment](https://docs.github.com/rest/commits/comments#get-a-commit-comment). A response with an HTTP `200` status means that you already added the reaction type to this commit comment.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.Reaction> ReactionsCreateForCommitCommentAsync(
            string owner,
            string repo,
            long commentId,
            global::GitHub.ReactionsCreateForCommitCommentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create reaction for a commit comment<br/>
        /// Create a reaction to a [commit comment](https://docs.github.com/rest/commits/comments#get-a-commit-comment). A response with an HTTP `200` status means that you already added the reaction type to this commit comment.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commentId"></param>
        /// <param name="content">
        /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the commit comment.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.Reaction> ReactionsCreateForCommitCommentAsync(
            string owner,
            string repo,
            long commentId,
            global::GitHub.ReactionsCreateForCommitCommentRequestContent content,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}