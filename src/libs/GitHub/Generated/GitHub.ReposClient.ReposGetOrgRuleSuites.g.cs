
#nullable enable

namespace GitHub
{
    public partial class ReposClient
    {
        partial void PrepareReposGetOrgRuleSuitesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string? @ref,
            ref int repositoryName,
            ref global::GitHub.ReposGetOrgRuleSuitesTimePeriod? timePeriod,
            ref string? actorName,
            ref global::GitHub.ReposGetOrgRuleSuitesRuleSuiteResult? ruleSuiteResult,
            ref int perPage,
            ref int page);
        partial void PrepareReposGetOrgRuleSuitesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string? @ref,
            int repositoryName,
            global::GitHub.ReposGetOrgRuleSuitesTimePeriod? timePeriod,
            string? actorName,
            global::GitHub.ReposGetOrgRuleSuitesRuleSuiteResult? ruleSuiteResult,
            int perPage,
            int page);
        partial void ProcessReposGetOrgRuleSuitesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposGetOrgRuleSuitesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List organization rule suites<br/>
        /// Lists suites of rule evaluations at the organization level.<br/>
        /// For more information, see "[Managing rulesets for repositories in your organization](https://docs.github.com/organizations/managing-organization-settings/managing-rulesets-for-repositories-in-your-organization#viewing-insights-for-rulesets)."
        /// </summary>
        /// <param name="org"></param>
        /// <param name="ref"></param>
        /// <param name="repositoryName"></param>
        /// <param name="timePeriod">
        /// Default Value: day
        /// </param>
        /// <param name="actorName"></param>
        /// <param name="ruleSuiteResult">
        /// Default Value: all
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.RuleSuite>> ReposGetOrgRuleSuitesAsync(
            string org,
            string? @ref = default,
            int repositoryName = default,
            global::GitHub.ReposGetOrgRuleSuitesTimePeriod? timePeriod = global::GitHub.ReposGetOrgRuleSuitesTimePeriod.Day,
            string? actorName = default,
            global::GitHub.ReposGetOrgRuleSuitesRuleSuiteResult? ruleSuiteResult = global::GitHub.ReposGetOrgRuleSuitesRuleSuiteResult.All,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReposGetOrgRuleSuitesArguments(
                httpClient: _httpClient,
                org: ref org,
                @ref: ref @ref,
                repositoryName: ref repositoryName,
                timePeriod: ref timePeriod,
                actorName: ref actorName,
                ruleSuiteResult: ref ruleSuiteResult,
                perPage: ref perPage,
                page: ref page);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/rulesets/rule-suites?ref={@ref}&repository_name={repositoryName}&time_period={(global::System.Uri.EscapeDataString(timePeriod?.ToValueString() ?? string.Empty))}&actor_name={actorName}&rule_suite_result={(global::System.Uri.EscapeDataString(ruleSuiteResult?.ToValueString() ?? string.Empty))}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposGetOrgRuleSuitesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                @ref: @ref,
                repositoryName: repositoryName,
                timePeriod: timePeriod,
                actorName: actorName,
                ruleSuiteResult: ruleSuiteResult,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposGetOrgRuleSuitesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposGetOrgRuleSuitesResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::GitHub.SourceGenerationContext.Default.IListRuleSuite) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}