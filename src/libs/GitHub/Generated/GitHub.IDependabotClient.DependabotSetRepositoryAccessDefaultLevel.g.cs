#nullable enable

namespace GitHub
{
    public partial interface IDependabotClient
    {
        /// <summary>
        /// Set the default repository access level for Dependabot<br/>
        /// Sets the default level of repository access Dependabot will have while performing an update.  Available values are:<br/>
        /// - 'public' - Dependabot will only have access to public repositories, unless access is explicitly granted to non-public repositories.<br/>
        /// - 'internal' - Dependabot will only have access to public and internal repositories, unless access is explicitly granted to private repositories.<br/>
        /// Unauthorized users will not see the existence of this endpoint.<br/>
        /// This operation supports both server-to-server and user-to-server access.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task DependabotSetRepositoryAccessDefaultLevelAsync(
            string org,
            global::GitHub.DependabotSetRepositoryAccessDefaultLevelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set the default repository access level for Dependabot<br/>
        /// Sets the default level of repository access Dependabot will have while performing an update.  Available values are:<br/>
        /// - 'public' - Dependabot will only have access to public repositories, unless access is explicitly granted to non-public repositories.<br/>
        /// - 'internal' - Dependabot will only have access to public and internal repositories, unless access is explicitly granted to private repositories.<br/>
        /// Unauthorized users will not see the existence of this endpoint.<br/>
        /// This operation supports both server-to-server and user-to-server access.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="defaultLevel">
        /// The default repository access level for Dependabot updates.<br/>
        /// Example: internal
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DependabotSetRepositoryAccessDefaultLevelAsync(
            string org,
            global::GitHub.DependabotSetRepositoryAccessDefaultLevelRequestDefaultLevel defaultLevel,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}