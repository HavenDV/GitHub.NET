#nullable enable

namespace GitHub
{
    public partial interface IDependabotClient
    {
        /// <summary>
        /// Lists the repositories Dependabot can access in an organization<br/>
        /// Lists repositories that organization admins have allowed Dependabot to access when updating dependencies.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt;    This operation supports both server-to-server and user-to-server access.<br/>
        /// Unauthorized users will not see the existence of this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.DependabotRepositoryAccessDetails> DependabotRepositoryAccessForOrgAsync(
            string org,
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}