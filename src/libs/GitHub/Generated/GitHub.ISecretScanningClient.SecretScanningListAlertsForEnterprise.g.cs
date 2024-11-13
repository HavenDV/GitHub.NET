#nullable enable

namespace GitHub
{
    public partial interface ISecretScanningClient
    {
        /// <summary>
        /// List secret scanning alerts for an enterprise<br/>
        /// Lists secret scanning alerts for eligible repositories in an enterprise, from newest to oldest.<br/>
        /// Alerts are only returned for organizations in the enterprise for which the authenticated user is an organization owner or a [security manager](https://docs.github.com/organizations/managing-peoples-access-to-your-organization-with-roles/managing-security-managers-in-your-organization).<br/>
        /// The authenticated user must be a member of the enterprise in order to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope or `security_events` scope to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="state"></param>
        /// <param name="secretType"></param>
        /// <param name="resolution"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="validity"></param>
        /// <param name="isPubliclyLeaked">
        /// Default Value: false
        /// </param>
        /// <param name="isMultiRepo">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.OrganizationSecretScanningAlert>> SecretScanningListAlertsForEnterpriseAsync(
            string enterprise,
            global::GitHub.SecretScanningListAlertsForEnterpriseState? state = default,
            string? secretType = default,
            string? resolution = default,
            global::GitHub.SecretScanningListAlertsForEnterpriseSort? sort = default,
            global::GitHub.SecretScanningListAlertsForEnterpriseDirection? direction = default,
            int? perPage = default,
            string? before = default,
            string? after = default,
            string? validity = default,
            bool? isPubliclyLeaked = default,
            bool? isMultiRepo = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}