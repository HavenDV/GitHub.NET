
#nullable enable

namespace GitHub
{
    public partial class AppsClient
    {
        partial void PrepareAppsResetTokenArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string clientId,
            global::GitHub.AppsResetTokenRequest request);
        partial void PrepareAppsResetTokenRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string clientId,
            global::GitHub.AppsResetTokenRequest request);
        partial void ProcessAppsResetTokenResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAppsResetTokenResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Reset a token<br/>
        /// OAuth applications and GitHub applications with OAuth authorizations can use this API method to reset a valid OAuth token without end-user involvement. Applications must save the "token" property in the response because changes take effect immediately. Invalid tokens will return `404 NOT FOUND`.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.Authorization> AppsResetTokenAsync(
            string clientId,
            global::GitHub.AppsResetTokenRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAppsResetTokenArguments(
                httpClient: HttpClient,
                clientId: ref clientId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/applications/{clientId}/token",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAppsResetTokenRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                clientId: clientId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAppsResetTokenResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessAppsResetTokenResponseContent(
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
                global::GitHub.Authorization.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Reset a token<br/>
        /// OAuth applications and GitHub applications with OAuth authorizations can use this API method to reset a valid OAuth token without end-user involvement. Applications must save the "token" property in the response because changes take effect immediately. Invalid tokens will return `404 NOT FOUND`.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="accessToken">
        /// The access_token of the OAuth or GitHub application.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.Authorization> AppsResetTokenAsync(
            string clientId,
            string accessToken,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::GitHub.AppsResetTokenRequest
            {
                AccessToken = accessToken,
            };

            return await AppsResetTokenAsync(
                clientId: clientId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}