#nullable enable

namespace GitHub
{
    public partial interface IPackagesClient
    {
        /// <summary>
        /// List package versions for a package owned by the authenticated user<br/>
        /// Lists package versions for a package owned by the authenticated user.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint. For more information, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages)."
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="state">
        /// Default Value: active
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.PackageVersion>> PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserAsync(
            global::GitHub.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType packageType,
            string packageName,
            int? page = default,
            int? perPage = default,
            global::GitHub.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserState? state = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}