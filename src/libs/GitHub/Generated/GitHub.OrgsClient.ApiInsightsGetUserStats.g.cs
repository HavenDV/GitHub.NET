
#nullable enable

namespace GitHub
{
    public partial class OrgsClient
    {
        partial void PrepareApiInsightsGetUserStatsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string userId,
            ref string minTimestamp,
            ref string maxTimestamp,
            ref int? page,
            ref int? perPage,
            ref global::GitHub.ApiInsightsGetUserStatsDirection? direction,
            global::System.Collections.Generic.IList<global::GitHub.ApiInsightsGetUserStatsSortItem>? sort);
        partial void PrepareApiInsightsGetUserStatsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string userId,
            string minTimestamp,
            string maxTimestamp,
            int? page,
            int? perPage,
            global::GitHub.ApiInsightsGetUserStatsDirection? direction,
            global::System.Collections.Generic.IList<global::GitHub.ApiInsightsGetUserStatsSortItem>? sort);
        partial void ProcessApiInsightsGetUserStatsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessApiInsightsGetUserStatsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get user stats<br/>
        /// Get API usage statistics within an organization for a user broken down by the type of access.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="userId"></param>
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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.ApiInsightsUserStat>> ApiInsightsGetUserStatsAsync(
            string org,
            string userId,
            string minTimestamp,
            string maxTimestamp,
            int? page = default,
            int? perPage = default,
            global::GitHub.ApiInsightsGetUserStatsDirection? direction = default,
            global::System.Collections.Generic.IList<global::GitHub.ApiInsightsGetUserStatsSortItem>? sort = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareApiInsightsGetUserStatsArguments(
                httpClient: HttpClient,
                org: ref org,
                userId: ref userId,
                minTimestamp: ref minTimestamp,
                maxTimestamp: ref maxTimestamp,
                page: ref page,
                perPage: ref perPage,
                direction: ref direction,
                sort: sort);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/insights/api/user-stats/{userId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("min_timestamp", minTimestamp) 
                .AddRequiredParameter("max_timestamp", maxTimestamp) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("direction", direction?.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareApiInsightsGetUserStatsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                userId: userId,
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
            ProcessApiInsightsGetUserStatsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessApiInsightsGetUserStatsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::GitHub.ApiInsightsUserStat>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::GitHub.ApiInsightsUserStat> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}