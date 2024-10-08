
#nullable enable

namespace GitHub
{
    public partial class ChecksClient
    {
        partial void PrepareChecksListForSuiteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int checkSuiteId,
            ref string? checkName,
            ref global::GitHub.ChecksListForSuiteStatus? status,
            ref global::GitHub.ChecksListForSuiteFilter? filter,
            ref int perPage,
            ref int page);
        partial void PrepareChecksListForSuiteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int checkSuiteId,
            string? checkName,
            global::GitHub.ChecksListForSuiteStatus? status,
            global::GitHub.ChecksListForSuiteFilter? filter,
            int perPage,
            int page);
        partial void ProcessChecksListForSuiteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessChecksListForSuiteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List check runs in a check suite<br/>
        /// Lists check runs for a check suite using its `id`.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint on a private repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="checkSuiteId"></param>
        /// <param name="checkName"></param>
        /// <param name="status"></param>
        /// <param name="filter">
        /// Default Value: latest
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.ChecksListForSuiteResponse> ChecksListForSuiteAsync(
            string owner,
            string repo,
            int checkSuiteId,
            string? checkName = default,
            global::GitHub.ChecksListForSuiteStatus? status = default,
            global::GitHub.ChecksListForSuiteFilter? filter = global::GitHub.ChecksListForSuiteFilter.Latest,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareChecksListForSuiteArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                checkSuiteId: ref checkSuiteId,
                checkName: ref checkName,
                status: ref status,
                filter: ref filter,
                perPage: ref perPage,
                page: ref page);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/check-suites/{checkSuiteId}/check-runs?check_name={checkName}&status={(global::System.Uri.EscapeDataString(status?.ToValueString() ?? string.Empty))}&filter={(global::System.Uri.EscapeDataString(filter?.ToValueString() ?? string.Empty))}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareChecksListForSuiteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                checkSuiteId: checkSuiteId,
                checkName: checkName,
                status: status,
                filter: filter,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessChecksListForSuiteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessChecksListForSuiteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::GitHub.SourceGenerationContext.Default.ChecksListForSuiteResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}