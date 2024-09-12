
#nullable enable

namespace GitHub
{
    public partial class ReposClient
    {
        partial void PrepareReposUpdateRepoRulesetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int rulesetId,
            global::GitHub.ReposUpdateRepoRulesetRequest request);
        partial void PrepareReposUpdateRepoRulesetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int rulesetId,
            global::GitHub.ReposUpdateRepoRulesetRequest request);
        partial void ProcessReposUpdateRepoRulesetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposUpdateRepoRulesetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update a repository ruleset<br/>
        /// Update a ruleset for a repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="rulesetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.RepositoryRuleset> ReposUpdateRepoRulesetAsync(
            string owner,
            string repo,
            int rulesetId,
            global::GitHub.ReposUpdateRepoRulesetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReposUpdateRepoRulesetArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                rulesetId: ref rulesetId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/rulesets/{rulesetId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::GitHub.SourceGenerationContext.Default.ReposUpdateRepoRulesetRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposUpdateRepoRulesetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                rulesetId: rulesetId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposUpdateRepoRulesetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposUpdateRepoRulesetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::GitHub.SourceGenerationContext.Default.RepositoryRuleset) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update a repository ruleset<br/>
        /// Update a ruleset for a repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="rulesetId"></param>
        /// <param name="name">
        /// The name of the ruleset.
        /// </param>
        /// <param name="target">
        /// The target of the ruleset
        /// </param>
        /// <param name="enforcement">
        /// The enforcement level of the ruleset. `evaluate` allows admins to test rules before enforcing them. Admins can view insights on the Rule Insights page (`evaluate` is only available with GitHub Enterprise).
        /// </param>
        /// <param name="bypassActors">
        /// The actors that can bypass the rules in this ruleset
        /// </param>
        /// <param name="conditions">
        /// Parameters for a repository ruleset ref name condition
        /// </param>
        /// <param name="rules">
        /// An array of rules within the ruleset.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.RepositoryRuleset> ReposUpdateRepoRulesetAsync(
            string owner,
            string repo,
            int rulesetId,
            string? name = default,
            global::GitHub.ReposUpdateRepoRulesetRequestTarget? target = default,
            global::GitHub.RepositoryRuleEnforcement? enforcement = default,
            global::System.Collections.Generic.IList<global::GitHub.RepositoryRulesetBypassActor>? bypassActors = default,
            global::GitHub.RepositoryRulesetConditions? conditions = default,
            global::System.Collections.Generic.IList<global::GitHub.RepositoryRule>? rules = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::GitHub.ReposUpdateRepoRulesetRequest
            {
                Name = name,
                Target = target,
                Enforcement = enforcement,
                BypassActors = bypassActors,
                Conditions = conditions,
                Rules = rules,
            };

            return await ReposUpdateRepoRulesetAsync(
                owner: owner,
                repo: repo,
                rulesetId: rulesetId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}