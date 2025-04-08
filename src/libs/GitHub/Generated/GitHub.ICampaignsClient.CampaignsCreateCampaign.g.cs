#nullable enable

namespace GitHub
{
    public partial interface ICampaignsClient
    {
        /// <summary>
        /// Create a campaign for an organization<br/>
        /// Create a campaign for an organization.<br/>
        /// The authenticated user must be an owner or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint.<br/>
        /// Fine-grained tokens must have the "Code scanning alerts" repository permissions (read) on all repositories included<br/>
        /// in the campaign.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.CampaignSummary> CampaignsCreateCampaignAsync(
            string org,
            global::GitHub.CampaignsCreateCampaignRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a campaign for an organization<br/>
        /// Create a campaign for an organization.<br/>
        /// The authenticated user must be an owner or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint.<br/>
        /// Fine-grained tokens must have the "Code scanning alerts" repository permissions (read) on all repositories included<br/>
        /// in the campaign.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// The name of the campaign
        /// </param>
        /// <param name="description">
        /// A description for the campaign
        /// </param>
        /// <param name="managers">
        /// The logins of the users to set as the campaign managers. At this time, only a single manager can be supplied.
        /// </param>
        /// <param name="teamManagers">
        /// The slugs of the teams to set as the campaign managers.
        /// </param>
        /// <param name="endsAt">
        /// The end date and time of the campaign. The date must be in the future.
        /// </param>
        /// <param name="contactLink">
        /// The contact link of the campaign. Must be a URI.
        /// </param>
        /// <param name="codeScanningAlerts">
        /// The code scanning alerts to include in this campaign
        /// </param>
        /// <param name="generateIssues">
        /// If true, will automatically generate issues for the campaign. The default is false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.CampaignSummary> CampaignsCreateCampaignAsync(
            string org,
            string name,
            string description,
            global::System.DateTime endsAt,
            global::System.Collections.Generic.IList<global::GitHub.CampaignsCreateCampaignRequestCodeScanningAlert> codeScanningAlerts,
            global::System.Collections.Generic.IList<string>? managers = default,
            global::System.Collections.Generic.IList<string>? teamManagers = default,
            string? contactLink = default,
            bool? generateIssues = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}