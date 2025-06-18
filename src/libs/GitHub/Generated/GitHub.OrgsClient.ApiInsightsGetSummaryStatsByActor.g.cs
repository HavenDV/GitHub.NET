
#nullable enable

namespace GitHub
{
    public partial class OrgsClient
    {
        partial void PrepareApiInsightsGetSummaryStatsByActorArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string minTimestamp,
            ref string? maxTimestamp,
            ref global::GitHub.ApiInsightsGetSummaryStatsByActorActorType actorType,
            ref int actorId);
        partial void PrepareApiInsightsGetSummaryStatsByActorRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string minTimestamp,
            string? maxTimestamp,
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
        /// <exception cref="global::GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.ApiInsightsSummaryStats> ApiInsightsGetSummaryStatsByActorAsync(
            string org,
            string minTimestamp,
            global::GitHub.ApiInsightsGetSummaryStatsByActorActorType actorType,
            int actorId,
            string? maxTimestamp = default,
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

            var __pathBuilder = new global::GitHub.PathBuilder(
                path: $"/orgs/{org}/insights/api/summary-stats/{actorType}/{actorId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("min_timestamp", minTimestamp) 
                .AddOptionalParameter("max_timestamp", maxTimestamp) 
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
                ProcessApiInsightsGetSummaryStatsByActorResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::GitHub.ApiInsightsSummaryStats.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
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
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::GitHub.ApiInsightsSummaryStats.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
            }
        }
    }
}