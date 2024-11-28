
#nullable enable

namespace GitHub
{
    public partial class OrgsClient
    {
        partial void PrepareApiInsightsGetSubjectStatsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string minTimestamp,
            ref string? maxTimestamp,
            ref int? page,
            ref int? perPage,
            ref global::GitHub.ApiInsightsGetSubjectStatsDirection? direction,
            global::System.Collections.Generic.IList<global::GitHub.ApiInsightsGetSubjectStatsSortItem>? sort);
        partial void PrepareApiInsightsGetSubjectStatsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string minTimestamp,
            string? maxTimestamp,
            int? page,
            int? perPage,
            global::GitHub.ApiInsightsGetSubjectStatsDirection? direction,
            global::System.Collections.Generic.IList<global::GitHub.ApiInsightsGetSubjectStatsSortItem>? sort);
        partial void ProcessApiInsightsGetSubjectStatsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessApiInsightsGetSubjectStatsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get subject stats<br/>
        /// Get API request statistics for all subjects within an organization within a specified time frame. Subjects can be users or GitHub Apps.
        /// </summary>
        /// <param name="org"></param>
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
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.ApiInsightsSubjectStat>> ApiInsightsGetSubjectStatsAsync(
            string org,
            string minTimestamp,
            string? maxTimestamp = default,
            int? page = default,
            int? perPage = default,
            global::GitHub.ApiInsightsGetSubjectStatsDirection? direction = default,
            global::System.Collections.Generic.IList<global::GitHub.ApiInsightsGetSubjectStatsSortItem>? sort = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareApiInsightsGetSubjectStatsArguments(
                httpClient: HttpClient,
                org: ref org,
                minTimestamp: ref minTimestamp,
                maxTimestamp: ref maxTimestamp,
                page: ref page,
                perPage: ref perPage,
                direction: ref direction,
                sort: sort);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/insights/api/subject-stats",
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
            PrepareApiInsightsGetSubjectStatsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
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
            ProcessApiInsightsGetSubjectStatsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessApiInsightsGetSubjectStatsResponseContent(
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
                    global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::GitHub.ApiInsightsSubjectStat>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::GitHub.ApiInsightsSubjectStat> ??
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
                    await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::GitHub.ApiInsightsSubjectStat>), JsonSerializerContext).ConfigureAwait(false) as global::System.Collections.Generic.IList<global::GitHub.ApiInsightsSubjectStat> ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}