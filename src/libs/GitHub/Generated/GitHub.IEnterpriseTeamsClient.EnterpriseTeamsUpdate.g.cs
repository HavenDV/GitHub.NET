#nullable enable

namespace GitHub
{
    public partial interface IEnterpriseTeamsClient
    {
        /// <summary>
        /// Update an enterprise team<br/>
        /// To edit a team, the authenticated user must be an enterprise owner.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="teamSlug"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.EnterpriseTeam> EnterpriseTeamsUpdateAsync(
            string enterprise,
            string teamSlug,
            global::GitHub.EnterpriseTeamsUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an enterprise team<br/>
        /// To edit a team, the authenticated user must be an enterprise owner.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="teamSlug"></param>
        /// <param name="name">
        /// A new name for the team.
        /// </param>
        /// <param name="description">
        /// A new description for the team.
        /// </param>
        /// <param name="syncToOrganizations">
        /// Retired: this field is no longer supported.<br/>
        /// Whether the enterprise team should be reflected in each organization.<br/>
        /// This value cannot be changed.<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="groupId">
        /// The ID of the IdP group to assign team membership with. The new IdP group will replace the existing one, or replace existing direct members if the team isn't currently linked to an IdP group.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.EnterpriseTeam> EnterpriseTeamsUpdateAsync(
            string enterprise,
            string teamSlug,
            string? name = default,
            string? description = default,
            global::GitHub.EnterpriseTeamsUpdateRequestSyncToOrganizations? syncToOrganizations = default,
            string? groupId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}