#nullable enable

namespace GitHub
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// Stop a codespace for the authenticated user<br/>
        /// Stops a user's codespace.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="codespaceName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.Codespace> CodespacesStopForAuthenticatedUserAsync(
            string codespaceName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}