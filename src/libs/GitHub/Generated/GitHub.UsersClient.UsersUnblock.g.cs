
#nullable enable

namespace GitHub
{
    public partial class UsersClient
    {
        partial void PrepareUsersUnblockArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string username);
        partial void PrepareUsersUnblockRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string username);
        partial void ProcessUsersUnblockResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUsersUnblockResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Unblock a user<br/>
        /// Unblocks the given user and returns a 204.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.BasicError> UsersUnblockAsync(
            string username,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareUsersUnblockArguments(
                httpClient: _httpClient,
                username: ref username);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/user/blocks/{username}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUsersUnblockRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                username: username);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUsersUnblockResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUsersUnblockResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::GitHub.SourceGenerationContext.Default.BasicError) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}