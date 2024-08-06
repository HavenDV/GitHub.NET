
#nullable enable

namespace GitHub
{
    public partial class ChecksClient
    {
        partial void PrepareChecksUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int checkRunId,
            global::GitHub.ChecksUpdateRequest request);
        partial void PrepareChecksUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int checkRunId,
            global::GitHub.ChecksUpdateRequest request);
        partial void ProcessChecksUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessChecksUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a check run<br/>
        /// Updates a check run for a specific commit in a repository.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.<br/>
        /// OAuth apps and personal access tokens (classic) cannot use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="checkRunId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.CheckRun> ChecksUpdateAsync(
            string owner,
            string repo,
            int checkRunId,
            global::GitHub.ChecksUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareChecksUpdateArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                checkRunId: ref checkRunId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Patch,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/check-runs/{checkRunId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, global::GitHub.SourceGenerationContext.Default.ChecksUpdateRequest),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareChecksUpdateRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                checkRunId: checkRunId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessChecksUpdateResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessChecksUpdateResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::GitHub.SourceGenerationContext.Default.CheckRun) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a check run<br/>
        /// Updates a check run for a specific commit in a repository.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.<br/>
        /// OAuth apps and personal access tokens (classic) cannot use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="checkRunId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.CheckRun> ChecksUpdateAsync(
            string owner,
            string repo,
            int checkRunId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::GitHub.ChecksUpdateRequest
            {
            };

            return await ChecksUpdateAsync(
                owner: owner,
                repo: repo,
                checkRunId: checkRunId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}