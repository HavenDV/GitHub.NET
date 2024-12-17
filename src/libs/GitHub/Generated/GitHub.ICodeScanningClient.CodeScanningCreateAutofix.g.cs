#nullable enable

namespace GitHub
{
    public partial interface ICodeScanningClient
    {
        /// <summary>
        /// Create an autofix for a code scanning alert<br/>
        /// Creates an autofix for a code scanning alert.<br/>
        /// If a new autofix is to be created as a result of this request or is currently being generated, then this endpoint will return a 202 Accepted response.<br/>
        /// If an autofix already exists for a given alert, then this endpoint will return a 200 OK response.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint with private or public repositories, or the `public_repo` scope to use this endpoint with only public repositories.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="alertNumber">
        /// The security alert number.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.CodeScanningAutofix> CodeScanningCreateAutofixAsync(
            string owner,
            string repo,
            int alertNumber,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}