#nullable enable

namespace GitHub
{
    public partial interface IMigrationsClient
    {
        /// <summary>
        /// Delete an organization migration archive<br/>
        /// Deletes a previous migration archive. Migration archives are automatically deleted after seven days.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="migrationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.BasicError> MigrationsDeleteArchiveForOrgAsync(
            string org,
            int migrationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}