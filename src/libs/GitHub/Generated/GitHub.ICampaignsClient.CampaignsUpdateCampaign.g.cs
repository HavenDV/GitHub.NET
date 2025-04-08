#nullable enable

namespace GitHub
{
    public partial interface ICampaignsClient
    {
        /// <summary>
        /// Update a campaign<br/>
        /// Updates a campaign in an organization.<br/>
        /// The authenticated user must be an owner or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="campaignNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.CampaignSummary> CampaignsUpdateCampaignAsync(
            string org,
            int campaignNumber,
            global::GitHub.CampaignsUpdateCampaignRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a campaign<br/>
        /// Updates a campaign in an organization.<br/>
        /// The authenticated user must be an owner or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="campaignNumber"></param>
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
        /// The end date and time of the campaign, in ISO 8601 format':' YYYY-MM-DDTHH:MM:SSZ.
        /// </param>
        /// <param name="contactLink">
        /// The contact link of the campaign. Must be a URI.
        /// </param>
        /// <param name="state">
        /// Indicates whether a campaign is open or closed
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.CampaignSummary> CampaignsUpdateCampaignAsync(
            string org,
            int campaignNumber,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? managers = default,
            global::System.Collections.Generic.IList<string>? teamManagers = default,
            global::System.DateTime? endsAt = default,
            string? contactLink = default,
            global::GitHub.CampaignState? state = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}