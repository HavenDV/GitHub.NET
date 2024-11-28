
#nullable enable

namespace GitHub
{
    public partial class OrgsClient
    {
        partial void PrepareApiInsightsGetRouteStatsByActorArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref global::GitHub.ApiInsightsGetRouteStatsByActorActorType actorType,
            ref int actorId,
            ref string minTimestamp,
            ref string? maxTimestamp,
            ref int? page,
            ref int? perPage,
            ref global::GitHub.ApiInsightsGetRouteStatsByActorDirection? direction,
            global::System.Collections.Generic.IList<global::GitHub.ApiInsightsGetRouteStatsByActorSortItem>? sort);
        partial void PrepareApiInsightsGetRouteStatsByActorRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::GitHub.ApiInsightsGetRouteStatsByActorActorType actorType,
            int actorId,
            string minTimestamp,
            string? maxTimestamp,
            int? page,
            int? perPage,
            global::GitHub.ApiInsightsGetRouteStatsByActorDirection? direction,
            global::System.Collections.Generic.IList<global::GitHub.ApiInsightsGetRouteStatsByActorSortItem>? sort);
        partial void ProcessApiInsightsGetRouteStatsByActorResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessApiInsightsGetRouteStatsByActorResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get route stats by actor<br/>
        /// Get API request count statistics for an actor broken down by route within a specified time frame.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="actorType"></param>
        /// <param name="actorId"></param>
        /// <param name="minTimestamp"></param>
        /// <param name="maxTimestamp"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="sort"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.ApiInsightsRouteStat>> ApiInsightsGetRouteStatsByActorAsync(
            string org,
            global::GitHub.ApiInsightsGetRouteStatsByActorActorType actorType,
            int actorId,
            string minTimestamp,
            string? maxTimestamp = default,
            int? page = default,
            int? perPage = default,
            global::GitHub.ApiInsightsGetRouteStatsByActorDirection? direction = default,
            global::System.Collections.Generic.IList<global::GitHub.ApiInsightsGetRouteStatsByActorSortItem>? sort = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareApiInsightsGetRouteStatsByActorArguments(
                httpClient: HttpClient,
                org: ref org,
                actorType: ref actorType,
                actorId: ref actorId,
                minTimestamp: ref minTimestamp,
                maxTimestamp: ref maxTimestamp,
                page: ref page,
                perPage: ref perPage,
                direction: ref direction,
                sort: sort);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/insights/api/route-stats/{actorType}/{actorId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("min_timestamp", minTimestamp) 
                .AddOptionalParameter("max_timestamp", maxTimestamp) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("direction", direction?.ToValueString()) 
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
            PrepareApiInsightsGetRouteStatsByActorRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                actorType: actorType,
                actorId: actorId,
                minTimestamp: minTimestamp,
                maxTimestamp: maxTimestamp,
                page: page,
                perPage: perPage,
                direction: direction,
                sort: sort);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessApiInsightsGetRouteStatsByActorResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessApiInsightsGetRouteStatsByActorResponseContent(
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
                    global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::GitHub.ApiInsightsRouteStat>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::GitHub.ApiInsightsRouteStat> ??
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

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::GitHub.ApiInsightsRouteStat>), JsonSerializerContext).ConfigureAwait(false) as global::System.Collections.Generic.IList<global::GitHub.ApiInsightsRouteStat> ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}