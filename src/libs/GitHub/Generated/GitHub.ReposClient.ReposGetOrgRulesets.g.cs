
#nullable enable

namespace GitHub
{
    public partial class ReposClient
    {
        partial void PrepareReposGetOrgRulesetsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int perPage,
            ref int page,
            ref string? targets);
        partial void PrepareReposGetOrgRulesetsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int perPage,
            int page,
            string? targets);
        partial void ProcessReposGetOrgRulesetsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposGetOrgRulesetsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get all organization repository rulesets<br/>
        /// Get all the repository rulesets for an organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="targets">
        /// Example: branch,tag,push
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.RepositoryRuleset>> ReposGetOrgRulesetsAsync(
            string org,
            int perPage = 30,
            int page = 1,
            string? targets = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReposGetOrgRulesetsArguments(
                httpClient: _httpClient,
                org: ref org,
                perPage: ref perPage,
                page: ref page,
                targets: ref targets);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/rulesets?per_page={perPage}&page={page}&targets={targets}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposGetOrgRulesetsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                perPage: perPage,
                page: page,
                targets: targets);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposGetOrgRulesetsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposGetOrgRulesetsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::GitHub.SourceGenerationContext.Default.IListRepositoryRuleset) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}