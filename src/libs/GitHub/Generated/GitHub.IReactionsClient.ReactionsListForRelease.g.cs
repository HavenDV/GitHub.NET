#nullable enable

namespace GitHub
{
    public partial interface IReactionsClient
    {
        /// <summary>
        /// List reactions for a release<br/>
        /// List the reactions to a [release](https://docs.github.com/rest/releases/releases#get-a-release).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="releaseId"></param>
        /// <param name="content"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Reaction>> ReactionsListForReleaseAsync(
            string owner,
            string repo,
            int releaseId,
            global::GitHub.ReactionsListForReleaseContent? content = default,
            int? perPage = 30,
            int? page = 1,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}