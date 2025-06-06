#nullable enable

namespace GitHub
{
    public partial interface IMigrationsClient
    {
        /// <summary>
        /// Start a user migration<br/>
        /// Initiates the generation of a user migration archive.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.Migration> MigrationsStartForAuthenticatedUserAsync(
            global::GitHub.MigrationsStartForAuthenticatedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Start a user migration<br/>
        /// Initiates the generation of a user migration archive.
        /// </summary>
        /// <param name="lockRepositories">
        /// Lock the repositories being migrated at the start of the migration<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeMetadata">
        /// Indicates whether metadata should be excluded and only git source should be included for the migration.<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeGitData">
        /// Indicates whether the repository git data should be excluded from the migration.<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeAttachments">
        /// Do not include attachments in the migration<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeReleases">
        /// Do not include releases in the migration<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeOwnerProjects">
        /// Indicates whether projects owned by the organization or users should be excluded.<br/>
        /// Example: true
        /// </param>
        /// <param name="orgMetadataOnly">
        /// Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="exclude">
        /// Exclude attributes from the API response to improve performance<br/>
        /// Example: [repositories]
        /// </param>
        /// <param name="repositories"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.Migration> MigrationsStartForAuthenticatedUserAsync(
            global::System.Collections.Generic.IList<string> repositories,
            bool? lockRepositories = default,
            bool? excludeMetadata = default,
            bool? excludeGitData = default,
            bool? excludeAttachments = default,
            bool? excludeReleases = default,
            bool? excludeOwnerProjects = default,
            bool? orgMetadataOnly = default,
            global::System.Collections.Generic.IList<global::GitHub.MigrationsStartForAuthenticatedUserRequestExcludeItem>? exclude = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}