
#nullable enable

namespace GitHub
{
    public partial class ReposClient
    {
        partial void PrepareReposGetRepoRulesetsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int perPage,
            ref int page,
            ref bool includesParents,
            ref string? targets);
        partial void PrepareReposGetRepoRulesetsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int perPage,
            int page,
            bool includesParents,
            string? targets);
        partial void ProcessReposGetRepoRulesetsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposGetRepoRulesetsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get all repository rulesets<br/>
        /// Get all the rulesets for a repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="includesParents">
        /// Default Value: true
        /// </param>
        /// <param name="targets">
        /// Example: branch,tag,push
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.RepositoryRuleset>> ReposGetRepoRulesetsAsync(
            string owner,
            string repo,
            int perPage = 30,
            int page = 1,
            bool includesParents = true,
            string? targets = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReposGetRepoRulesetsArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                perPage: ref perPage,
                page: ref page,
                includesParents: ref includesParents,
                targets: ref targets);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/rulesets?per_page={perPage}&page={page}&includes_parents={includesParents}&targets={targets}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposGetRepoRulesetsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                perPage: perPage,
                page: page,
                includesParents: includesParents,
                targets: targets);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposGetRepoRulesetsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposGetRepoRulesetsResponseContent(
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