#nullable enable

namespace GitHub
{
    public partial interface IMigrationsClient
    {
        /// <summary>
        /// List organization migrations<br/>
        /// Lists the most recent migrations, including both exports (which can be started through the REST API) and imports (which cannot be started using the REST API).<br/>
        /// A list of `repositories` is only returned for export migrations.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="exclude"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Migration>> MigrationsListForOrgAsync(
            string org,
            int? perPage = default,
            int? page = default,
            global::System.Collections.Generic.IList<global::GitHub.MigrationsListForOrgExcludeItem>? exclude = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}