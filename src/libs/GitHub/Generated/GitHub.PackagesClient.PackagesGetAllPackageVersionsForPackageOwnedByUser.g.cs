
#nullable enable

namespace GitHub
{
    public partial class PackagesClient
    {
        partial void PreparePackagesGetAllPackageVersionsForPackageOwnedByUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::GitHub.PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType packageType,
            ref string packageName,
            ref string username);
        partial void PreparePackagesGetAllPackageVersionsForPackageOwnedByUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::GitHub.PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType packageType,
            string packageName,
            string username);
        partial void ProcessPackagesGetAllPackageVersionsForPackageOwnedByUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPackagesGetAllPackageVersionsForPackageOwnedByUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List package versions for a package owned by a user<br/>
        /// Lists package versions for a public package owned by a specified user.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint. For more information, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages)."
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="packageName"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.PackageVersion>> PackagesGetAllPackageVersionsForPackageOwnedByUserAsync(
            global::GitHub.PackagesGetAllPackageVersionsForPackageOwnedByUserPackageType packageType,
            string packageName,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PreparePackagesGetAllPackageVersionsForPackageOwnedByUserArguments(
                httpClient: HttpClient,
                packageType: ref packageType,
                packageName: ref packageName,
                username: ref username);

            var __pathBuilder = new PathBuilder(
                path: $"/users/{username}/packages/{packageType}/{packageName}/versions",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePackagesGetAllPackageVersionsForPackageOwnedByUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                packageType: packageType,
                packageName: packageName,
                username: username);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPackagesGetAllPackageVersionsForPackageOwnedByUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessPackagesGetAllPackageVersionsForPackageOwnedByUserResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::GitHub.PackageVersion>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::GitHub.PackageVersion> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}