#nullable enable

namespace GitHub
{
    public partial interface IEnterpriseTeamsClient
    {
        /// <summary>
        /// Create an enterprise team<br/>
        /// To create an enterprise team, the authenticated user must be an owner of the enterprise.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.EnterpriseTeam> EnterpriseTeamsCreateAsync(
            string enterprise,
            global::GitHub.EnterpriseTeamsCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an enterprise team<br/>
        /// To create an enterprise team, the authenticated user must be an owner of the enterprise.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="name">
        /// The name of the team.
        /// </param>
        /// <param name="description">
        /// A description of the team.
        /// </param>
        /// <param name="syncToOrganizations">
        /// Retired: this field is no longer supported.<br/>
        /// Whether the enterprise team should be reflected in each organization.<br/>
        /// This value cannot be set.<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="groupId">
        /// The ID of the IdP group to assign team membership with. You can get this value from the [REST API endpoints for SCIM](https://docs.github.com/rest/scim#list-provisioned-scim-groups-for-an-enterprise).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.EnterpriseTeam> EnterpriseTeamsCreateAsync(
            string enterprise,
            string name,
            string? description = default,
            global::GitHub.EnterpriseTeamsCreateRequestSyncToOrganizations? syncToOrganizations = default,
            string? groupId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}