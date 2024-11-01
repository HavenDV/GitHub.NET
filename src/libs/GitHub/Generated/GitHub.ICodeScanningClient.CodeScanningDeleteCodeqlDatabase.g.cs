#nullable enable

namespace GitHub
{
    public partial interface ICodeScanningClient
    {
        /// <summary>
        /// Delete a CodeQL database<br/>
        /// Deletes a CodeQL database for a language in a repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="language"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.BasicError> CodeScanningDeleteCodeqlDatabaseAsync(
            string owner,
            string repo,
            string language,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}