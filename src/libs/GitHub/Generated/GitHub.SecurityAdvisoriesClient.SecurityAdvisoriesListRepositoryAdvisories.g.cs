
#nullable enable

namespace GitHub
{
    public partial class SecurityAdvisoriesClient
    {
        partial void PrepareSecurityAdvisoriesListRepositoryAdvisoriesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref global::GitHub.SecurityAdvisoriesListRepositoryAdvisoriesDirection? direction,
            ref global::GitHub.SecurityAdvisoriesListRepositoryAdvisoriesSort? sort,
            ref string? before,
            ref string? after,
            ref int perPage,
            ref global::GitHub.SecurityAdvisoriesListRepositoryAdvisoriesState? state);
        partial void PrepareSecurityAdvisoriesListRepositoryAdvisoriesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::GitHub.SecurityAdvisoriesListRepositoryAdvisoriesDirection? direction,
            global::GitHub.SecurityAdvisoriesListRepositoryAdvisoriesSort? sort,
            string? before,
            string? after,
            int perPage,
            global::GitHub.SecurityAdvisoriesListRepositoryAdvisoriesState? state);
        partial void ProcessSecurityAdvisoriesListRepositoryAdvisoriesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSecurityAdvisoriesListRepositoryAdvisoriesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List repository security advisories<br/>
        /// Lists security advisories in a repository.<br/>
        /// The authenticated user can access unpublished security advisories from a repository if they are a security manager or administrator of that repository, or if they are a collaborator on any security advisory.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` or `repository_advisories:read` scope to to get a published security advisory in a private repository, or any unpublished security advisory that the authenticated user has access to.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="state"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.RepositoryAdvisory>> SecurityAdvisoriesListRepositoryAdvisoriesAsync(
            string owner,
            string repo,
            global::GitHub.SecurityAdvisoriesListRepositoryAdvisoriesDirection? direction = global::GitHub.SecurityAdvisoriesListRepositoryAdvisoriesDirection.Desc,
            global::GitHub.SecurityAdvisoriesListRepositoryAdvisoriesSort? sort = global::GitHub.SecurityAdvisoriesListRepositoryAdvisoriesSort.Created,
            string? before = default,
            string? after = default,
            int perPage = 30,
            global::GitHub.SecurityAdvisoriesListRepositoryAdvisoriesState? state = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareSecurityAdvisoriesListRepositoryAdvisoriesArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                direction: ref direction,
                sort: ref sort,
                before: ref before,
                after: ref after,
                perPage: ref perPage,
                state: ref state);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/security-advisories?direction={(global::System.Uri.EscapeDataString(direction?.ToValueString() ?? string.Empty))}&sort={(global::System.Uri.EscapeDataString(sort?.ToValueString() ?? string.Empty))}&before={before}&after={after}&per_page={perPage}&state={(global::System.Uri.EscapeDataString(state?.ToValueString() ?? string.Empty))}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSecurityAdvisoriesListRepositoryAdvisoriesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                direction: direction,
                sort: sort,
                before: before,
                after: after,
                perPage: perPage,
                state: state);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSecurityAdvisoriesListRepositoryAdvisoriesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSecurityAdvisoriesListRepositoryAdvisoriesResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::GitHub.SourceGenerationContext.Default.IListRepositoryAdvisory) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}