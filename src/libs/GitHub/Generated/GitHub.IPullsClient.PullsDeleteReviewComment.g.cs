#nullable enable

namespace GitHub
{
    public partial interface IPullsClient
    {
        /// <summary>
        /// Delete a review comment for a pull request<br/>
        /// Deletes a review comment.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.BasicError> PullsDeleteReviewCommentAsync(
            string owner,
            string repo,
            long commentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}