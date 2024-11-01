
#nullable enable

namespace GitHub
{
    public partial class OrgsClient
    {
        partial void PrepareApiInsightsGetTimeStatsByUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string userId,
            ref string minTimestamp,
            ref string maxTimestamp,
            ref string timestampIncrement);
        partial void PrepareApiInsightsGetTimeStatsByUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string userId,
            string minTimestamp,
            string maxTimestamp,
            string timestampIncrement);
        partial void ProcessApiInsightsGetTimeStatsByUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessApiInsightsGetTimeStatsByUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get time stats by user<br/>
        /// Get the number of API requests and rate-limited requests made within an organization by a specific user over a specified time period.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="userId"></param>
        /// <param name="minTimestamp"></param>
        /// <param name="maxTimestamp"></param>
        /// <param name="timestampIncrement"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.ApiInsightsTimeStat>> ApiInsightsGetTimeStatsByUserAsync(
            string org,
            string userId,
            string minTimestamp,
            string maxTimestamp,
            string timestampIncrement,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareApiInsightsGetTimeStatsByUserArguments(
                httpClient: HttpClient,
                org: ref org,
                userId: ref userId,
                minTimestamp: ref minTimestamp,
                maxTimestamp: ref maxTimestamp,
                timestampIncrement: ref timestampIncrement);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/insights/api/time-stats/users/{userId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("min_timestamp", minTimestamp) 
                .AddRequiredParameter("max_timestamp", maxTimestamp) 
                .AddRequiredParameter("timestamp_increment", timestampIncrement) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareApiInsightsGetTimeStatsByUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                userId: userId,
                minTimestamp: minTimestamp,
                maxTimestamp: maxTimestamp,
                timestampIncrement: timestampIncrement);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessApiInsightsGetTimeStatsByUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessApiInsightsGetTimeStatsByUserResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::GitHub.ApiInsightsTimeStat>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::GitHub.ApiInsightsTimeStat> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}