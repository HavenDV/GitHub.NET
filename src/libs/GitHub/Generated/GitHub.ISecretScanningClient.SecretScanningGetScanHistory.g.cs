#nullable enable

namespace GitHub
{
    public partial interface ISecretScanningClient
    {
        /// <summary>
        /// Get secret scanning scan history for a repository<br/>
        /// Lists the latest default incremental and backfill scans by type for a repository. Scans from Copilot Secret Scanning are not included.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.SecretScanningScanHistory> SecretScanningGetScanHistoryAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}