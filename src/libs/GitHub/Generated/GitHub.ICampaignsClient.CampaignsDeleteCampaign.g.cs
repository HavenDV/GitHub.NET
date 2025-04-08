#nullable enable

namespace GitHub
{
    public partial interface ICampaignsClient
    {
        /// <summary>
        /// Delete a campaign for an organization<br/>
        /// Deletes a campaign in an organization.<br/>
        /// The authenticated user must be an owner or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="campaignNumber"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task CampaignsDeleteCampaignAsync(
            string org,
            int campaignNumber,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}