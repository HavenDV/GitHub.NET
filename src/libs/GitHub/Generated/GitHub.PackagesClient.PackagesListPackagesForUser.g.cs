
#nullable enable

namespace GitHub
{
    public partial class PackagesClient
    {
        partial void PreparePackagesListPackagesForUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::GitHub.PackagesListPackagesForUserPackageType packageType,
            ref global::GitHub.PackagesListPackagesForUserVisibility? visibility,
            ref string username,
            ref int? page,
            ref int? perPage);
        partial void PreparePackagesListPackagesForUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::GitHub.PackagesListPackagesForUserPackageType packageType,
            global::GitHub.PackagesListPackagesForUserVisibility? visibility,
            string username,
            int? page,
            int? perPage);
        partial void ProcessPackagesListPackagesForUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPackagesListPackagesForUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List packages for a user<br/>
        /// Lists all packages in a user's namespace for which the requesting user has access.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint. For more information, see "[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages)."
        /// </summary>
        /// <param name="packageType"></param>
        /// <param name="visibility"></param>
        /// <param name="username"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Package>> PackagesListPackagesForUserAsync(
            global::GitHub.PackagesListPackagesForUserPackageType packageType,
            string username,
            global::GitHub.PackagesListPackagesForUserVisibility? visibility = default,
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PreparePackagesListPackagesForUserArguments(
                httpClient: HttpClient,
                packageType: ref packageType,
                visibility: ref visibility,
                username: ref username,
                page: ref page,
                perPage: ref perPage);

            var __pathBuilder = new PathBuilder(
                path: $"/users/{username}/packages",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("package_type", packageType.ToValueString()) 
                .AddOptionalParameter("visibility", visibility?.ToValueString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePackagesListPackagesForUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                packageType: packageType,
                visibility: visibility,
                username: username,
                page: page,
                perPage: perPage);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPackagesListPackagesForUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessPackagesListPackagesForUserResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::GitHub.Package>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::GitHub.Package> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}