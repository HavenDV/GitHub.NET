#nullable enable

namespace GitHub
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// List machine types for a codespace<br/>
        /// List the machine types a codespace can transition to use.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="codespaceName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.CodespacesCodespaceMachinesForAuthenticatedUserResponse> CodespacesCodespaceMachinesForAuthenticatedUserAsync(
            string codespaceName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}