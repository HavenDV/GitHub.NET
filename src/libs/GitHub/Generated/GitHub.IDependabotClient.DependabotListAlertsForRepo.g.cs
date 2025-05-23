#nullable enable

namespace GitHub
{
    public partial interface IDependabotClient
    {
        /// <summary>
        /// List Dependabot alerts for a repository<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="state"></param>
        /// <param name="severity"></param>
        /// <param name="ecosystem"></param>
        /// <param name="package"></param>
        /// <param name="manifest"></param>
        /// <param name="epssPercentage"></param>
        /// <param name="has"></param>
        /// <param name="scope"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="first">
        /// Default Value: 30
        /// </param>
        /// <param name="last"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.DependabotAlert>> DependabotListAlertsForRepoAsync(
            string owner,
            string repo,
            string? state = default,
            string? severity = default,
            string? ecosystem = default,
            string? package = default,
            string? manifest = default,
            string? epssPercentage = default,
            global::GitHub.OneOf<string, global::System.Collections.Generic.IList<global::GitHub.DependabotListAlertsForRepoHasVariant2Item>>? has = default,
            global::GitHub.DependabotListAlertsForRepoScope? scope = default,
            global::GitHub.DependabotListAlertsForRepoSort? sort = default,
            global::GitHub.DependabotListAlertsForRepoDirection? direction = default,
            int? page = default,
            int? perPage = default,
            string? before = default,
            string? after = default,
            int? first = default,
            int? last = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}