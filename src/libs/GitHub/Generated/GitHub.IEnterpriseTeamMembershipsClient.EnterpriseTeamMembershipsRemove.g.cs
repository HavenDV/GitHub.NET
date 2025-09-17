#nullable enable

namespace GitHub
{
    public partial interface IEnterpriseTeamMembershipsClient
    {
        /// <summary>
        /// Remove team membership<br/>
        /// Remove membership of a specific user from a particular team in an enterprise.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="enterpriseTeam"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task EnterpriseTeamMembershipsRemoveAsync(
            string enterprise,
            string enterpriseTeam,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}