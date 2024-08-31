
#nullable enable

namespace GitHub
{
    public partial class ReposClient
    {
        partial void PrepareReposListForUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string username,
            ref global::GitHub.ReposListForUserType? type,
            ref global::GitHub.ReposListForUserSort? sort,
            ref global::GitHub.ReposListForUserDirection? direction,
            ref int perPage,
            ref int page);
        partial void PrepareReposListForUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string username,
            global::GitHub.ReposListForUserType? type,
            global::GitHub.ReposListForUserSort? sort,
            global::GitHub.ReposListForUserDirection? direction,
            int perPage,
            int page);
        partial void ProcessReposListForUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposListForUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List repositories for a user<br/>
        /// Lists public repositories for the specified user.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="type">
        /// Default Value: owner
        /// </param>
        /// <param name="sort">
        /// Default Value: full_name
        /// </param>
        /// <param name="direction"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.MinimalRepository>> ReposListForUserAsync(
            string username,
            global::GitHub.ReposListForUserType? type = global::GitHub.ReposListForUserType.Owner,
            global::GitHub.ReposListForUserSort? sort = global::GitHub.ReposListForUserSort.FullName,
            global::GitHub.ReposListForUserDirection? direction = default,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReposListForUserArguments(
                httpClient: _httpClient,
                username: ref username,
                type: ref type,
                sort: ref sort,
                direction: ref direction,
                perPage: ref perPage,
                page: ref page);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/users/{username}/repos?type={(global::System.Uri.EscapeDataString(type?.ToValueString() ?? string.Empty))}&sort={(global::System.Uri.EscapeDataString(sort?.ToValueString() ?? string.Empty))}&direction={(global::System.Uri.EscapeDataString(direction?.ToValueString() ?? string.Empty))}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposListForUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                username: username,
                type: type,
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
            ProcessReposListForUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposListForUserResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::GitHub.SourceGenerationContext.Default.IListMinimalRepository) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}