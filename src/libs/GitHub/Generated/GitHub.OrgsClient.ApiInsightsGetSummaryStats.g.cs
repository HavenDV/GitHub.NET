
#nullable enable

namespace GitHub
{
    public partial class OrgsClient
    {
        partial void PrepareApiInsightsGetSummaryStatsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string minTimestamp,
            ref string maxTimestamp);
        partial void PrepareApiInsightsGetSummaryStatsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string minTimestamp,
            string maxTimestamp);
        partial void ProcessApiInsightsGetSummaryStatsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessApiInsightsGetSummaryStatsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get summary stats<br/>
        /// Get overall statistics of API requests made within an organization by all users and apps within a specified time frame.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="minTimestamp"></param>
        /// <param name="maxTimestamp"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.ApiInsightsSummaryStats> ApiInsightsGetSummaryStatsAsync(
            string org,
            string minTimestamp,
            string maxTimestamp,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareApiInsightsGetSummaryStatsArguments(
                httpClient: HttpClient,
                org: ref org,
                minTimestamp: ref minTimestamp,
                maxTimestamp: ref maxTimestamp);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/insights/api/summary-stats",
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
            PrepareApiInsightsGetSummaryStatsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                minTimestamp: minTimestamp,
                maxTimestamp: maxTimestamp);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessApiInsightsGetSummaryStatsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessApiInsightsGetSummaryStatsResponseContent(
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