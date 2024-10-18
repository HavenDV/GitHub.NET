#nullable enable

namespace GitHub
{
    public partial interface ICodespacesClient
    {
        /// <summary>
        /// Create a codespace for the authenticated user<br/>
        /// Creates a new codespace, owned by the authenticated user.<br/>
        /// This endpoint requires either a `repository_id` OR a `pull_request` but not both.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.Codespace> CodespacesCreateForAuthenticatedUserAsync(
            global::GitHub.OneOf<global::GitHub.CodespacesCreateForAuthenticatedUserRequestVariant1, global::GitHub.CodespacesCreateForAuthenticatedUserRequestVariant2> request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a codespace for the authenticated user<br/>
        /// Creates a new codespace, owned by the authenticated user.<br/>
        /// This endpoint requires either a `repository_id` OR a `pull_request` but not both.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `codespace` scope to use this endpoint.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.Codespace> CodespacesCreateForAuthenticatedUserAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}