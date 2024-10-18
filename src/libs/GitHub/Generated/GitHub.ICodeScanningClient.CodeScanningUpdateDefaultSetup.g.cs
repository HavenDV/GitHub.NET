#nullable enable

namespace GitHub
{
    public partial interface ICodeScanningClient
    {
        /// <summary>
        /// Update a code scanning default setup configuration<br/>
        /// Updates a code scanning default setup configuration.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.EmptyObject> CodeScanningUpdateDefaultSetupAsync(
            string owner,
            string repo,
            global::GitHub.CodeScanningDefaultSetupUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a code scanning default setup configuration<br/>
        /// Updates a code scanning default setup configuration.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="state">
        /// The desired state of code scanning default setup.
        /// </param>
        /// <param name="querySuite">
        /// CodeQL query suite to be used.
        /// </param>
        /// <param name="languages">
        /// CodeQL languages to be analyzed.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.EmptyObject> CodeScanningUpdateDefaultSetupAsync(
            string owner,
            string repo,
            global::GitHub.CodeScanningDefaultSetupUpdateState? state = default,
            global::GitHub.CodeScanningDefaultSetupUpdateQuerySuite? querySuite = default,
            global::System.Collections.Generic.IList<global::GitHub.CodeScanningDefaultSetupUpdateLanguage>? languages = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}