#nullable enable

namespace GitHub
{
    public partial interface IGitClient
    {
        /// <summary>
        /// Delete a reference<br/>
        /// Deletes the provided reference.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task GitDeleteRefAsync(
            string owner,
            string repo,
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}