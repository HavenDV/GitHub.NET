
#nullable enable

namespace GitHub
{
    public partial class ProjectsClient
    {
        partial void PrepareProjectsListCardsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int columnId,
            ref global::GitHub.ProjectsListCardsArchivedState? archivedState,
            ref int perPage,
            ref int page);
        partial void PrepareProjectsListCardsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int columnId,
            global::GitHub.ProjectsListCardsArchivedState? archivedState,
            int perPage,
            int page);
        partial void ProcessProjectsListCardsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessProjectsListCardsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List project cards<br/>
        /// Lists the project cards in a project.
        /// </summary>
        /// <param name="columnId"></param>
        /// <param name="archivedState">
        /// Default Value: not_archived
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.ProjectCard>> ProjectsListCardsAsync(
            int columnId,
            global::GitHub.ProjectsListCardsArchivedState? archivedState = global::GitHub.ProjectsListCardsArchivedState.NotArchived,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareProjectsListCardsArguments(
                httpClient: _httpClient,
                columnId: ref columnId,
                archivedState: ref archivedState,
                perPage: ref perPage,
                page: ref page);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/projects/columns/{columnId}/cards?archived_state={(global::System.Uri.EscapeDataString(archivedState?.ToValueString() ?? string.Empty))}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareProjectsListCardsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                columnId: columnId,
                archivedState: archivedState,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessProjectsListCardsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessProjectsListCardsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::GitHub.SourceGenerationContext.Default.IListProjectCard) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}