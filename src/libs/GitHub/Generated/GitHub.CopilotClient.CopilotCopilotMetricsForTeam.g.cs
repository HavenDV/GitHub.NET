
#nullable enable

namespace GitHub
{
    public partial class CopilotClient
    {
        partial void PrepareCopilotCopilotMetricsForTeamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string teamSlug,
            ref string? since,
            ref string? until,
            ref int? page,
            ref int? perPage);
        partial void PrepareCopilotCopilotMetricsForTeamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string teamSlug,
            string? since,
            string? until,
            int? page,
            int? perPage);
        partial void ProcessCopilotCopilotMetricsForTeamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCopilotCopilotMetricsForTeamResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Copilot metrics for a team<br/>
        /// Use this endpoint to see a breakdown of aggregated metrics for various GitHub Copilot features. See the response schema tab for detailed metrics definitions.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; This endpoint will only return results for a given day if the team had **five or more members with active Copilot licenses** on that day, as evaluated at the end of that day.<br/>
        /// The response contains metrics for up to 28 days prior. Metrics are processed once per day for the previous day,<br/>
        /// and the response will only include data up until yesterday. In order for an end user to be counted towards these metrics,<br/>
        /// they must have telemetry enabled in their IDE.<br/>
        /// To access this endpoint, the Copilot Metrics API access policy must be enabled for the organization containing the team within GitHub settings.<br/>
        /// Only organization owners for the organization that contains this team and owners and billing managers of the parent enterprise can view Copilot metrics for a team.<br/>
        /// OAuth app tokens and personal access tokens (classic) need either the `manage_billing:copilot`, `read:org`, or `read:enterprise` scopes to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="since"></param>
        /// <param name="until"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 28
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.CopilotUsageMetricsDay>> CopilotCopilotMetricsForTeamAsync(
            string org,
            string teamSlug,
            string? since = default,
            string? until = default,
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCopilotCopilotMetricsForTeamArguments(
                httpClient: HttpClient,
                org: ref org,
                teamSlug: ref teamSlug,
                since: ref since,
                until: ref until,
                page: ref page,
                perPage: ref perPage);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/team/{teamSlug}/copilot/metrics",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("since", since) 
                .AddOptionalParameter("until", until) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCopilotCopilotMetricsForTeamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                teamSlug: teamSlug,
                since: since,
                until: until,
                page: page,
                perPage: perPage);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCopilotCopilotMetricsForTeamResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessCopilotCopilotMetricsForTeamResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::GitHub.CopilotUsageMetricsDay>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::GitHub.CopilotUsageMetricsDay> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}