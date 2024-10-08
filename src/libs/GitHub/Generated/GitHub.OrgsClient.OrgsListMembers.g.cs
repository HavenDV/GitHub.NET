
#nullable enable

namespace GitHub
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsListMembersArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref global::GitHub.OrgsListMembersFilter? filter,
            ref global::GitHub.OrgsListMembersRole? role,
            ref int perPage,
            ref int page);
        partial void PrepareOrgsListMembersRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::GitHub.OrgsListMembersFilter? filter,
            global::GitHub.OrgsListMembersRole? role,
            int perPage,
            int page);
        partial void ProcessOrgsListMembersResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsListMembersResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List organization members<br/>
        /// List all users who are members of an organization. If the authenticated user is also a member of this organization then both concealed and public members will be returned.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="filter">
        /// Default Value: all
        /// </param>
        /// <param name="role">
        /// Default Value: all
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.SimpleUser>> OrgsListMembersAsync(
            string org,
            global::GitHub.OrgsListMembersFilter? filter = global::GitHub.OrgsListMembersFilter.All,
            global::GitHub.OrgsListMembersRole? role = global::GitHub.OrgsListMembersRole.All,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareOrgsListMembersArguments(
                httpClient: _httpClient,
                org: ref org,
                filter: ref filter,
                role: ref role,
                perPage: ref perPage,
                page: ref page);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/orgs/{org}/members?filter={(global::System.Uri.EscapeDataString(filter?.ToValueString() ?? string.Empty))}&role={(global::System.Uri.EscapeDataString(role?.ToValueString() ?? string.Empty))}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOrgsListMembersRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                org: org,
                filter: filter,
                role: role,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOrgsListMembersResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOrgsListMembersResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::GitHub.SourceGenerationContext.Default.IListSimpleUser) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}