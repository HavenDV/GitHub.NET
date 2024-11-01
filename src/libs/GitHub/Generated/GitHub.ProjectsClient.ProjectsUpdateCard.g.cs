
#nullable enable

namespace GitHub
{
    public partial class ProjectsClient
    {
        partial void PrepareProjectsUpdateCardArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int cardId,
            global::GitHub.ProjectsUpdateCardRequest request);
        partial void PrepareProjectsUpdateCardRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int cardId,
            global::GitHub.ProjectsUpdateCardRequest request);
        partial void ProcessProjectsUpdateCardResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessProjectsUpdateCardResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update an existing project card
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.ProjectCard> ProjectsUpdateCardAsync(
            int cardId,
            global::GitHub.ProjectsUpdateCardRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareProjectsUpdateCardArguments(
                httpClient: HttpClient,
                cardId: ref cardId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/projects/columns/cards/{cardId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareProjectsUpdateCardRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                cardId: cardId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessProjectsUpdateCardResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessProjectsUpdateCardResponseContent(
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
                global::GitHub.ProjectCard.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update an existing project card
        /// </summary>
        /// <param name="cardId"></param>
        /// <param name="note">
        /// The project card's note<br/>
        /// Example: Update all gems
        /// </param>
        /// <param name="archived">
        /// Whether or not the card is archived<br/>
        /// Example: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.ProjectCard> ProjectsUpdateCardAsync(
            int cardId,
            string? note = default,
            bool? archived = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::GitHub.ProjectsUpdateCardRequest
            {
                Note = note,
                Archived = archived,
            };

            return await ProjectsUpdateCardAsync(
                cardId: cardId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}