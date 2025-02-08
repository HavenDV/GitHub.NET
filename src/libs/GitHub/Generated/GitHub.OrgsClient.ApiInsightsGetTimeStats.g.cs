
#nullable enable

namespace GitHub
{
    public partial class OrgsClient
    {
        partial void PrepareApiInsightsGetTimeStatsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string minTimestamp,
            ref string? maxTimestamp,
            ref string timestampIncrement);
        partial void PrepareApiInsightsGetTimeStatsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string minTimestamp,
            string? maxTimestamp,
            string timestampIncrement);
        partial void ProcessApiInsightsGetTimeStatsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessApiInsightsGetTimeStatsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get time stats<br/>
        /// Get the number of API requests and rate-limited requests made within an organization over a specified time period.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="minTimestamp"></param>
        /// <param name="maxTimestamp"></param>
        /// <param name="timestampIncrement"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.ApiInsightsTimeStat>> ApiInsightsGetTimeStatsAsync(
            string org,
            string minTimestamp,
            string timestampIncrement,
            string? maxTimestamp = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareApiInsightsGetTimeStatsArguments(
                httpClient: HttpClient,
                org: ref org,
                minTimestamp: ref minTimestamp,
                maxTimestamp: ref maxTimestamp,
                timestampIncrement: ref timestampIncrement);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/insights/api/time-stats",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("min_timestamp", minTimestamp) 
                .AddOptionalParameter("max_timestamp", maxTimestamp) 
                .AddRequiredParameter("timestamp_increment", timestampIncrement) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareApiInsightsGetTimeStatsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
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
            ProcessApiInsightsGetTimeStatsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessApiInsightsGetTimeStatsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::GitHub.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::GitHub.ApiInsightsTimeStat>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::GitHub.ApiInsightsTimeStat> ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::GitHub.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return
                    await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::GitHub.ApiInsightsTimeStat>), JsonSerializerContext).ConfigureAwait(false) as global::System.Collections.Generic.IList<global::GitHub.ApiInsightsTimeStat> ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}