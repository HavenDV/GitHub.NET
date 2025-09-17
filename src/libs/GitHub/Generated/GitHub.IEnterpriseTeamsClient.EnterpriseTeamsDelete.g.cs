#nullable enable

namespace GitHub
{
    public partial interface IEnterpriseTeamsClient
    {
        /// <summary>
        /// Delete an enterprise team<br/>
        /// To delete an enterprise team, the authenticated user must be an enterprise owner.<br/>
        /// If you are an enterprise owner, deleting an enterprise team will delete all of its IdP mappings as well.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="teamSlug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task EnterpriseTeamsDeleteAsync(
            string enterprise,
            string teamSlug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}