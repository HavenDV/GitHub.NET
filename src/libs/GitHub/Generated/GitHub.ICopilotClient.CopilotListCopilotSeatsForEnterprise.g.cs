#nullable enable

namespace GitHub
{
    public partial interface ICopilotClient
    {
        /// <summary>
        /// List all Copilot seat assignments for an enterprise<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint is in beta and is subject to change.<br/>
        /// Lists all active Copilot seats across organizations or enterprise teams for an enterprise with a Copilot Business or Copilot Enterprise subscription.<br/>
        /// Users with access through multiple organizations or enterprise teams will only be counted toward `total_seats` once.<br/>
        /// For each organization or enterprise team which grants Copilot access to a user, a seat detail object will appear in the `seats` array.<br/>
        /// Only enterprise owners and billing managers can view assigned Copilot seats across their child organizations or enterprise teams.<br/>
        /// Personal access tokens (classic) need either the `manage_billing:copilot` or `read:enterprise` scopes to use this endpoint.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 50
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.CopilotListCopilotSeatsForEnterpriseResponse> CopilotListCopilotSeatsForEnterpriseAsync(
            string enterprise,
            int? page = 1,
            int? perPage = 50,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}