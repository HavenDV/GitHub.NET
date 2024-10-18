#nullable enable

namespace GitHub
{
    public partial interface ISecretScanningClient
    {
        /// <summary>
        /// Create a push protection bypass<br/>
        /// Creates a bypass for a previously push protected secret.<br/>
        /// The authenticated user must be the original author of the committed secret.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.SecretScanningPushProtectionBypass> SecretScanningCreatePushProtectionBypassAsync(
            string owner,
            string repo,
            global::GitHub.SecretScanningCreatePushProtectionBypassRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a push protection bypass<br/>
        /// Creates a bypass for a previously push protected secret.<br/>
        /// The authenticated user must be the original author of the committed secret.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="reason">
        /// The reason for bypassing push protection.
        /// </param>
        /// <param name="placeholderId">
        /// The ID of the push protection bypass placeholder. This value is returned on any push protected routes.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.SecretScanningPushProtectionBypass> SecretScanningCreatePushProtectionBypassAsync(
            string owner,
            string repo,
            global::GitHub.SecretScanningPushProtectionBypassReason reason,
            string placeholderId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}