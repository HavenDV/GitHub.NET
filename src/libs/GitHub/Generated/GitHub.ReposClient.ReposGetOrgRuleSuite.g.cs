
#nullable enable

namespace GitHub
{
    public partial class ReposClient
    {
        partial void PrepareReposGetOrgRuleSuiteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int ruleSuiteId);
        partial void PrepareReposGetOrgRuleSuiteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int ruleSuiteId);
        partial void ProcessReposGetOrgRuleSuiteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposGetOrgRuleSuiteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get an organization rule suite<br/>
        /// Gets information about a suite of rule evaluations from within an organization.<br/>
        /// For more information, see "[Managing rulesets for repositories in your organization](https://docs.github.com/organizations/managing-organization-settings/managing-rulesets-for-repositories-in-your-organization#viewing-insights-for-rulesets)."
        /// </summary>
        /// <param name="org"></param>
        /// <param name="ruleSuiteId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.RuleSuite2> ReposGetOrgRuleSuiteAsync(
            string org,
            int ruleSuiteId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReposGetOrgRuleSuiteArguments(
                httpClient: _httpClient,
                org: ref org,
                ruleSuiteId: ref ruleSuiteId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/rulesets/rule-suites/{ruleSuiteId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposGetOrgRuleSuiteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                ruleSuiteId: ruleSuiteId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposGetOrgRuleSuiteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposGetOrgRuleSuiteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::GitHub.SourceGenerationContext.Default.RuleSuite2) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}