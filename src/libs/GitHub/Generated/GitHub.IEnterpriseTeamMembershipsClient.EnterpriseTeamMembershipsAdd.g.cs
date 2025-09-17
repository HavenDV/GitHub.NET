#nullable enable

namespace GitHub
{
    public partial interface IEnterpriseTeamMembershipsClient
    {
        /// <summary>
        /// Add team member<br/>
        /// Add a team member to an enterprise team.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="enterpriseTeam"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.SimpleUser> EnterpriseTeamMembershipsAddAsync(
            string enterprise,
            string enterpriseTeam,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}