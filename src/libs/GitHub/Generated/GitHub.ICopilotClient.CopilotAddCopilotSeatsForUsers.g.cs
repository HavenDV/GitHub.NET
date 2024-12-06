#nullable enable

namespace GitHub
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Add users to the Copilot subscription for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Purchases a GitHub Copilot seat for each user specified.<br/>
        /// The organization will be billed for each seat based on the organization's Copilot plan. For more information about Copilot pricing, see "[About billing for GitHub Copilot in your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-the-copilot-subscription-for-your-organization/about-billing-for-github-copilot-in-your-organization)."<br/>
        /// Only organization owners can purchase Copilot seats for their organization members. The organization must have a Copilot Business or Copilot Enterprise subscription and a configured suggestion matching policy.<br/>
        /// For more information about setting up a Copilot subscription, see "[Subscribing to Copilot for your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-the-copilot-subscription-for-your-organization/subscribing-to-copilot-for-your-organization)."<br/>
        /// For more information about setting a suggestion matching policy, see "[Managing policies for Copilot in your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/setting-policies-for-copilot-in-your-organization/managing-policies-for-copilot-in-your-organization#policies-for-suggestion-matching)."<br/>
        /// The response contains the total number of new seats that were created and existing seats that were refreshed.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.CopilotAddCopilotSeatsForUsersResponse> CopilotAddCopilotSeatsForUsersAsync(
            string org,
            global::GitHub.CopilotAddCopilotSeatsForUsersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add users to the Copilot subscription for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Purchases a GitHub Copilot seat for each user specified.<br/>
        /// The organization will be billed for each seat based on the organization's Copilot plan. For more information about Copilot pricing, see "[About billing for GitHub Copilot in your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-the-copilot-subscription-for-your-organization/about-billing-for-github-copilot-in-your-organization)."<br/>
        /// Only organization owners can purchase Copilot seats for their organization members. The organization must have a Copilot Business or Copilot Enterprise subscription and a configured suggestion matching policy.<br/>
        /// For more information about setting up a Copilot subscription, see "[Subscribing to Copilot for your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-the-copilot-subscription-for-your-organization/subscribing-to-copilot-for-your-organization)."<br/>
        /// For more information about setting a suggestion matching policy, see "[Managing policies for Copilot in your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/setting-policies-for-copilot-in-your-organization/managing-policies-for-copilot-in-your-organization#policies-for-suggestion-matching)."<br/>
        /// The response contains the total number of new seats that were created and existing seats that were refreshed.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="selectedUsernames">
        /// The usernames of the organization members to be granted access to GitHub Copilot.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.CopilotAddCopilotSeatsForUsersResponse> CopilotAddCopilotSeatsForUsersAsync(
            string org,
            global::System.Collections.Generic.IList<string> selectedUsernames,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}