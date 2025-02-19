
#nullable enable

namespace GitHub
{
    public partial class AppsClient
    {
        partial void PrepareAppsRemoveRepoFromInstallationForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int installationId,
            ref int repositoryId);
        partial void PrepareAppsRemoveRepoFromInstallationForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int installationId,
            int repositoryId);
        partial void ProcessAppsRemoveRepoFromInstallationForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Remove a repository from an app installation<br/>
        /// Remove a single repository from an installation. The authenticated user must have admin access to the repository. The installation must have the `repository_selection` of `selected`. <br/>
        /// This endpoint only works for PATs (classic) with the `repo` scope.
        /// </summary>
        /// <param name="installationId"></param>
        /// <param name="repositoryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task AppsRemoveRepoFromInstallationForAuthenticatedUserAsync(
            int installationId,
            int repositoryId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAppsRemoveRepoFromInstallationForAuthenticatedUserArguments(
                httpClient: HttpClient,
                installationId: ref installationId,
                repositoryId: ref repositoryId);

            var __pathBuilder = new PathBuilder(
                path: $"/user/installations/{installationId}/repositories/{repositoryId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAppsRemoveRepoFromInstallationForAuthenticatedUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                installationId: installationId,
                repositoryId: repositoryId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAppsRemoveRepoFromInstallationForAuthenticatedUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::GitHub.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
        }
    }
}