#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Replace all repository topics
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.Topic> ReposReplaceAllTopicsAsync(
            string owner,
            string repo,
            global::GitHub.ReposReplaceAllTopicsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Replace all repository topics
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="names">
        /// An array of topics to add to the repository. Pass one or more topics to _replace_ the set of existing topics. Send an empty array (`[]`) to clear all topics from the repository. **Note:** Topic `names` cannot contain uppercase letters.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.Topic> ReposReplaceAllTopicsAsync(
            string owner,
            string repo,
            global::System.Collections.Generic.IList<string> names,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}