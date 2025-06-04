#nullable enable

namespace GitHub
{
    public partial interface IDependabotClient
    {
        /// <summary>
        /// Updates repositories to the list of repositories that organization admins have allowed Dependabot to access when updating dependencies.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt;    This operation supports both server-to-server and user-to-server access.<br/>
        /// Unauthorized users will not see the existence of this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task DependabotUpdateRepositoryAccessForOrgAsync(
            string org,
            global::GitHub.DependabotUpdateRepositoryAccessForOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates repositories to the list of repositories that organization admins have allowed Dependabot to access when updating dependencies.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt;    This operation supports both server-to-server and user-to-server access.<br/>
        /// Unauthorized users will not see the existence of this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="repositoryIdsToAdd"></param>
        /// <param name="repositoryIdsToRemove"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DependabotUpdateRepositoryAccessForOrgAsync(
            string org,
            global::System.Collections.Generic.IList<int>? repositoryIdsToAdd = default,
            global::System.Collections.Generic.IList<int>? repositoryIdsToRemove = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}