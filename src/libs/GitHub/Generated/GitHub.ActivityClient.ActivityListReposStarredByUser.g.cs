
#nullable enable

namespace GitHub
{
    public partial class ActivityClient
    {
        partial void PrepareActivityListReposStarredByUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string username,
            ref global::GitHub.ActivityListReposStarredByUserSort? sort,
            ref global::GitHub.ActivityListReposStarredByUserDirection? direction,
            ref int perPage,
            ref int page);
        partial void PrepareActivityListReposStarredByUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string username,
            global::GitHub.ActivityListReposStarredByUserSort? sort,
            global::GitHub.ActivityListReposStarredByUserDirection? direction,
            int perPage,
            int page);
        partial void ProcessActivityListReposStarredByUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActivityListReposStarredByUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List repositories starred by a user<br/>
        /// Lists repositories a user has starred.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.star+json`**: Includes a timestamp of when the star was created.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.AnyOf<global::System.Collections.Generic.IList<global::GitHub.StarredRepository>, global::System.Collections.Generic.IList<global::GitHub.Repository>>> ActivityListReposStarredByUserAsync(
            string username,
            global::GitHub.ActivityListReposStarredByUserSort? sort = global::GitHub.ActivityListReposStarredByUserSort.Created,
            global::GitHub.ActivityListReposStarredByUserDirection? direction = global::GitHub.ActivityListReposStarredByUserDirection.Desc,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareActivityListReposStarredByUserArguments(
                httpClient: _httpClient,
                username: ref username,
                sort: ref sort,
                direction: ref direction,
                perPage: ref perPage,
                page: ref page);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/users/{username}/starred?sort={(global::System.Uri.EscapeDataString(sort?.ToValueString() ?? string.Empty))}&direction={(global::System.Uri.EscapeDataString(direction?.ToValueString() ?? string.Empty))}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActivityListReposStarredByUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                username: username,
                sort: sort,
                direction: direction,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActivityListReposStarredByUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessActivityListReposStarredByUserResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::GitHub.SourceGenerationContext.Default.NullableAnyOfIListStarredRepositoryIListRepository) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}