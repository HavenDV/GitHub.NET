#nullable enable

namespace GitHub
{
    public partial interface IPackagesClient
    {
        /// <summary>
        /// Delete a package version for the authenticated user<br/>
        /// Deletes a specific package version for a package owned by the authenticated user.  If the package is public and the package version has more than 5,000 downloads, you cannot delete the package version. In this scenario, contact GitHub support for further assistance.<br/>
        /// The authenticated user must have admin permissions in the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` and `delete:packages` scopes to use this endpoint. For more information, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages)."
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="packageVersionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task PackagesDeletePackageVersionForAuthenticatedUserAsync(
            global::GitHub.PackagesDeletePackageVersionForAuthenticatedUserPackageType packageType,
            string packageName,
            int packageVersionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}