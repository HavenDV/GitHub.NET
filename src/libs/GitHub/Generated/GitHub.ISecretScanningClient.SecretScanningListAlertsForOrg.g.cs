#nullable enable

namespace GitHub
{
    public partial interface ISecretScanningClient
    {
        /// <summary>
        /// List secret scanning alerts for an organization<br/>
        /// Lists secret scanning alerts for eligible repositories in an organization, from newest to oldest.<br/>
        /// The authenticated user must be an administrator or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="state"></param>
        /// <param name="secretType"></param>
        /// <param name="resolution"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="validity"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.OrganizationSecretScanningAlert>> SecretScanningListAlertsForOrgAsync(
            string org,
            global::GitHub.SecretScanningListAlertsForOrgState? state = default,
            string? secretType = default,
            string? resolution = default,
            global::GitHub.SecretScanningListAlertsForOrgSort? sort = global::GitHub.SecretScanningListAlertsForOrgSort.Created,
            global::GitHub.SecretScanningListAlertsForOrgDirection? direction = global::GitHub.SecretScanningListAlertsForOrgDirection.Desc,
            int? page = 1,
            int? perPage = 30,
            string? before = default,
            string? after = default,
            string? validity = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}