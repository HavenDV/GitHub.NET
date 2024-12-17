#nullable enable

namespace GitHub
{
    public partial interface ICodeScanningClient
    {
        /// <summary>
        /// Commit an autofix for a code scanning alert<br/>
        /// Commits an autofix for a code scanning alert.<br/>
        /// If an autofix is commited as a result of this request, then this endpoint will return a 201 Created response.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber">
        /// The security alert number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.CodeScanningAutofixCommitsResponse> CodeScanningCommitAutofixAsync(
            string owner,
            string repo,
            int alertNumber,
            global::GitHub.CodeScanningAutofixCommits request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Commit an autofix for a code scanning alert<br/>
        /// Commits an autofix for a code scanning alert.<br/>
        /// If an autofix is commited as a result of this request, then this endpoint will return a 201 Created response.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber">
        /// The security alert number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="targetRef">
        /// The Git reference of target branch for the commit. Branch needs to already exist.  For more information, see "[Git References](https://git-scm.com/book/en/v2/Git-Internals-Git-References)" in the Git documentation.
        /// </param>
        /// <param name="message">
        /// Commit message to be used.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.CodeScanningAutofixCommitsResponse> CodeScanningCommitAutofixAsync(
            string owner,
            string repo,
            int alertNumber,
            string? targetRef = default,
            string? message = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}