#nullable enable

namespace GitHub
{
    public partial interface IEnterpriseTeamMembershipsClient
    {
        /// <summary>
        /// Bulk add team members<br/>
        /// Add multiple team members to an enterprise team.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="enterpriseTeam"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.SimpleUser>> EnterpriseTeamMembershipsBulkAddAsync(
            string enterprise,
            string enterpriseTeam,
            global::GitHub.EnterpriseTeamMembershipsBulkAddRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Bulk add team members<br/>
        /// Add multiple team members to an enterprise team.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="enterpriseTeam"></param>
        /// <param name="usernames">
        /// The GitHub user handles to add to the team.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.SimpleUser>> EnterpriseTeamMembershipsBulkAddAsync(
            string enterprise,
            string enterpriseTeam,
            global::System.Collections.Generic.IList<string> usernames,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}