#nullable enable

namespace GitHub
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// Remove users from the Copilot subscription for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Sets seats for all users specified to "pending cancellation".<br/>
        /// This will cause the specified users to lose access to GitHub Copilot at the end of the current billing cycle unless they retain access through team membership.<br/>
        /// For more information about disabling access to Copilot, see "[Revoking access to Copilot for members of your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-access-to-github-copilot-in-your-organization/revoking-access-to-copilot-for-members-of-your-organization)."<br/>
        /// Only organization owners can cancel Copilot seats for their organization members.<br/>
        /// The response contains the total number of seats set to "pending cancellation".<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.CopilotCancelCopilotSeatAssignmentForUsersResponse> CopilotCancelCopilotSeatAssignmentForUsersAsync(
            string org,
            global::GitHub.CopilotCancelCopilotSeatAssignmentForUsersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove users from the Copilot subscription for an organization<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in public preview and is subject to change.<br/>
        /// Sets seats for all users specified to "pending cancellation".<br/>
        /// This will cause the specified users to lose access to GitHub Copilot at the end of the current billing cycle unless they retain access through team membership.<br/>
        /// For more information about disabling access to Copilot, see "[Revoking access to Copilot for members of your organization](https://docs.github.com/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-access-to-github-copilot-in-your-organization/revoking-access-to-copilot-for-members-of-your-organization)."<br/>
        /// Only organization owners can cancel Copilot seats for their organization members.<br/>
        /// The response contains the total number of seats set to "pending cancellation".<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot` or `admin:org` scopes to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="selectedUsernames">
        /// The usernames of the organization members for which to revoke access to GitHub Copilot.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.CopilotCancelCopilotSeatAssignmentForUsersResponse> CopilotCancelCopilotSeatAssignmentForUsersAsync(
            string org,
            global::System.Collections.Generic.IList<string> selectedUsernames,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}