
#nullable enable

namespace GitHub
{
    public partial class SecretScanningClient
    {
        partial void PrepareSecretScanningCreatePushProtectionBypassArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            global::GitHub.SecretScanningCreatePushProtectionBypassRequest request);
        partial void PrepareSecretScanningCreatePushProtectionBypassRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::GitHub.SecretScanningCreatePushProtectionBypassRequest request);
        partial void ProcessSecretScanningCreatePushProtectionBypassResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSecretScanningCreatePushProtectionBypassResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a push protection bypass<br/>
        /// Creates a bypass for a previously push protected secret.<br/>
        /// The authenticated user must be the original author of the committed secret.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.SecretScanningPushProtectionBypass> SecretScanningCreatePushProtectionBypassAsync(
            string owner,
            string repo,
            global::GitHub.SecretScanningCreatePushProtectionBypassRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSecretScanningCreatePushProtectionBypassArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/secret-scanning/push-protection-bypasses",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareSecretScanningCreatePushProtectionBypassRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessSecretScanningCreatePushProtectionBypassResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessSecretScanningCreatePushProtectionBypassResponseContent(
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
                global::GitHub.SecretScanningPushProtectionBypass.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a push protection bypass<br/>
        /// Creates a bypass for a previously push protected secret.<br/>
        /// The authenticated user must be the original author of the committed secret.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="reason">
        /// The reason for bypassing push protection.
        /// </param>
        /// <param name="placeholderId">
        /// The ID of the push protection bypass placeholder. This value is returned on any push protected routes.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.SecretScanningPushProtectionBypass> SecretScanningCreatePushProtectionBypassAsync(
            string owner,
            string repo,
            global::GitHub.SecretScanningPushProtectionBypassReason reason,
            string placeholderId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::GitHub.SecretScanningCreatePushProtectionBypassRequest
            {
                Reason = reason,
                PlaceholderId = placeholderId,
            };

            return await SecretScanningCreatePushProtectionBypassAsync(
                owner: owner,
                repo: repo,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}