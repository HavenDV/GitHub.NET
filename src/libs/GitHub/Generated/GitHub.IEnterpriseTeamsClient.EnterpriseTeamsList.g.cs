#nullable enable

namespace GitHub
{
    public partial interface IEnterpriseTeamsClient
    {
        /// <summary>
        /// List enterprise teams<br/>
        /// List all teams in the enterprise for the authenticated user
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.EnterpriseTeam>> EnterpriseTeamsListAsync(
            string enterprise,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}