
#nullable enable

namespace GitHub
{
    public partial class OrgsClient
    {
        partial void PrepareApiInsightsGetSummaryStatsByActorArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string minTimestamp,
            ref string maxTimestamp,
            ref global::GitHub.ApiInsightsGetSummaryStatsByActorActorType actorType,
            ref int actorId);
        partial void PrepareApiInsightsGetSummaryStatsByActorRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string minTimestamp,
            string maxTimestamp,
            global::GitHub.ApiInsightsGetSummaryStatsByActorActorType actorType,
            int actorId);
        partial void ProcessApiInsightsGetSummaryStatsByActorResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessApiInsightsGetSummaryStatsByActorResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get summary stats by actor<br/>
        /// Get overall statistics of API requests within the organization made by a specific actor. Actors can be GitHub App installations, OAuth apps or other tokens on behalf of a user.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="minTimestamp"></param>
        /// <param name="maxTimestamp"></param>
        /// <param name="actorType"></param>
        /// <param name="actorId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.ApiInsightsSummaryStats> ApiInsightsGetSummaryStatsByActorAsync(
            string org,
            string minTimestamp,
            string maxTimestamp,
            global::GitHub.ApiInsightsGetSummaryStatsByActorActorType actorType,
            int actorId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareApiInsightsGetSummaryStatsByActorArguments(
                httpClient: HttpClient,
                org: ref org,
                minTimestamp: ref minTimestamp,
                maxTimestamp: ref maxTimestamp,
                actorType: ref actorType,
                actorId: ref actorId);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/insights/api/summary-stats/{actorType}/{actorId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("min_timestamp", minTimestamp) 
                .AddRequiredParameter("max_timestamp", maxTimestamp) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareApiInsightsGetSummaryStatsByActorRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                minTimestamp: minTimestamp,
                maxTimestamp: maxTimestamp,
                actorType: actorType,
                actorId: actorId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessApiInsightsGetSummaryStatsByActorResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessApiInsightsGetSummaryStatsByActorResponseContent(
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
                global::GitHub.ApiInsightsSummaryStats.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}