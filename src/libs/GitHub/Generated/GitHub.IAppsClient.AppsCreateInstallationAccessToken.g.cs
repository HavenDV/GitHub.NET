#nullable enable

namespace GitHub
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Create an installation access token for an app<br/>
        /// Creates an installation access token that enables a GitHub App to make authenticated API requests for the app's installation on an organization or individual account. Installation tokens expire one hour from the time you create them. Using an expired token produces a status code of `401 - Unauthorized`, and requires creating a new installation token. By default the installation token has access to all repositories that the installation can access.<br/>
        /// Optionally, you can use the `repositories` or `repository_ids` body parameters to specify individual repositories that the installation access token can access. If you don't use `repositories` or `repository_ids` to grant access to specific repositories, the installation access token will have access to all repositories that the installation was granted access to. The installation access token cannot be granted access to repositories that the installation was not granted access to. Up to 500 repositories can be listed in this manner.<br/>
        /// Optionally, use the `permissions` body parameter to specify the permissions that the installation access token should have. If `permissions` is not specified, the installation access token will have all of the permissions that were granted to the app. The installation access token cannot be granted permissions that the app was not granted.<br/>
        /// You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="installationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.InstallationToken> AppsCreateInstallationAccessTokenAsync(
            int installationId,
            global::GitHub.AppsCreateInstallationAccessTokenRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an installation access token for an app<br/>
        /// Creates an installation access token that enables a GitHub App to make authenticated API requests for the app's installation on an organization or individual account. Installation tokens expire one hour from the time you create them. Using an expired token produces a status code of `401 - Unauthorized`, and requires creating a new installation token. By default the installation token has access to all repositories that the installation can access.<br/>
        /// Optionally, you can use the `repositories` or `repository_ids` body parameters to specify individual repositories that the installation access token can access. If you don't use `repositories` or `repository_ids` to grant access to specific repositories, the installation access token will have access to all repositories that the installation was granted access to. The installation access token cannot be granted access to repositories that the installation was not granted access to. Up to 500 repositories can be listed in this manner.<br/>
        /// Optionally, use the `permissions` body parameter to specify the permissions that the installation access token should have. If `permissions` is not specified, the installation access token will have all of the permissions that were granted to the app. The installation access token cannot be granted permissions that the app was not granted.<br/>
        /// You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="installationId"></param>
        /// <param name="repositories">
        /// List of repository names that the token should have access to
        /// </param>
        /// <param name="repositoryIds">
        /// List of repository IDs that the token should have access to<br/>
        /// Example: [1]
        /// </param>
        /// <param name="permissions">
        /// The permissions granted to the user access token.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.InstallationToken> AppsCreateInstallationAccessTokenAsync(
            int installationId,
            global::System.Collections.Generic.IList<string>? repositories = default,
            global::System.Collections.Generic.IList<int>? repositoryIds = default,
            global::GitHub.AppPermissions? permissions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}