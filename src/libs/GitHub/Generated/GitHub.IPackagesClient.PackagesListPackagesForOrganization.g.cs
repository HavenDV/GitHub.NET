#nullable enable

namespace GitHub
{
    public partial interface IPackagesClient
    {
        /// <summary>
        /// List packages for an organization<br/>
        /// Lists packages in an organization readable by the user.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint. For more information, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages)."
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="org"></param>
        /// <param name="visibility"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Package>> PackagesListPackagesForOrganizationAsync(
            global::GitHub.PackagesListPackagesForOrganizationPackageType packageType,
            string org,
            global::GitHub.PackagesListPackagesForOrganizationVisibility? visibility = default,
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}